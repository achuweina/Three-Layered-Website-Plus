using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Security;
using DevOne.Security.Cryptography.BCrypt;
using $ext_safeprojectname$.Data;
using $ext_safeprojectname$.Data.Interfaces;

namespace $safeprojectname$.Providers
{
    public class Membership : MembershipProvider
    {
        private readonly IUnitOfWork _unitOfWork;
        private const string ProviderName = "$ext_safeprojectname$Membership";

        public Membership()
        {
            _unitOfWork = DependencyResolver.Current.GetService<IUnitOfWork>();
        }

        private static MembershipUser GetMembershipUserFromUser(User user)
        {
            if (user == null) return null;
            return new MembershipUser(ProviderName, user.UserDetail.Username, user.Id, user.UserDetail.Email,
                user.UserSecurityQuestionAndAnswer.SecurityQuestion.Text, user.UserDetail.Comment,
                user.UserActivity.IsApproved, user.UserActivity.IsLockedOut, user.UserActivity.CreatedDate,
                user.UserActivity.LastLoggedInDate ?? DateTime.MinValue, user.UserActivity.LastActiveDate,
                user.UserAndPassword.LastChanged,
                user.UserActivity.LastLockedOutDate ?? DateTime.MinValue);
        }

        private static MembershipUserCollection GetCollectionFromArray(IEnumerable<User> users)
        {
            var userCollection = new MembershipUserCollection();
            foreach (var user in users)
            {
                userCollection.Add(GetMembershipUserFromUser(user));
            }
            return userCollection;
        }

        private static string GetPasswordToStore(string password)
        {
            return BCryptHelper.HashPassword(password, BCryptHelper.GenerateSalt(5));
        }

        private static bool ValidatePassword(string password, string userPassword)
        {
            return BCryptHelper.CheckPassword(password, userPassword);
        }

        private static string GetGeneratedPassword()
        {
            var randomGen = new Random();
            var passwordLength = randomGen.Next(8, 51);
            var password = new StringBuilder();
            while (passwordLength > 0)
            {
                var nextCharacter = (char) randomGen.Next(32, 127);
                password.Append(nextCharacter);
                passwordLength--;
            }
            return password.ToString();
        }
        
        public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer,
            bool isApproved, object providerUserKey, out MembershipCreateStatus status)
        {
            int questionId;
            if (_unitOfWork.SecurityQuestionsRepository.All().Any(x => x.Text == passwordQuestion))
            {
                var securityQuestion = _unitOfWork.SecurityQuestionsRepository.All().Single(x => x.Text == passwordQuestion);
                questionId = securityQuestion.Id;
            }
            else
            {
                var newQuestion = new SecurityQuestion
                {
                    Text = passwordQuestion
                };
                _unitOfWork.SecurityQuestionsRepository.Add(newQuestion);
                _unitOfWork.Commit();
                questionId = newQuestion.Id;
            }
            var defaultRoleId = _unitOfWork.RoleRepository.All().Where(x => x.Name == "Default" && x.SystemDefault).Select(x => x.Id).Single();
            var user = new User
            {
                UserDetail = new UserDetail
                {
                    Username = username,
                    Email = email
                },
                UserActivity = new UserActivity
                {
                    CreatedDate = DateTime.Now,
                    IsApproved = isApproved,
                    IsLockedOut = false,
                    LastActiveDate = DateTime.Now
                },
                UserAndPassword = new UserAndPassword
                {
                    Password = GetPasswordToStore(password),
                    LastChanged = DateTime.Now
                },
                UserSecurityQuestionAndAnswer = new UserSecurityQuestionAndAnswer
                {
                    Answer = passwordAnswer,
                    QuestionId = questionId
                }
            };
            user.UserToRoles.Add(new UserToRole()
            {
                RoleId = defaultRoleId
            });
            _unitOfWork.UserRepository.Add(user);
            _unitOfWork.Commit();
            status = MembershipCreateStatus.Success;
            return GetMembershipUserFromUser(user);
        }

        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion,
            string newPasswordAnswer)
        {
            var isValid = ValidateUser(username, password);
            if (!isValid) return false;
            int questionId;
            if (_unitOfWork.SecurityQuestionsRepository.All().Any(x => x.Text == newPasswordQuestion))
            {
                var securityQuestion = _unitOfWork.SecurityQuestionsRepository.All().Single(x => x.Text == newPasswordQuestion);
                questionId = securityQuestion.Id;
            }
            else
            {
                var newQuestion = new SecurityQuestion
                {
                    Text = newPasswordQuestion
                };
                _unitOfWork.SecurityQuestionsRepository.Add(newQuestion);
                _unitOfWork.Commit();
                questionId = newQuestion.Id;
            }
            var userMembership = GetUser(username, false);
            if (userMembership?.ProviderUserKey == null) return false;
            var userId = (int) userMembership.ProviderUserKey;
            var user = _unitOfWork.UserRepository.All().Single(x => x.Id == userId);
            user.UserSecurityQuestionAndAnswer.QuestionId = questionId;
            user.UserSecurityQuestionAndAnswer.Answer = newPasswordAnswer;
            _unitOfWork.Commit();
            return true;
        }

        public override string GetPassword(string username, string answer)
        {
            var userMembership = GetUser(username, false);
            if (userMembership?.ProviderUserKey == null) return string.Empty;
            var id = (int)userMembership.ProviderUserKey;
            var user = _unitOfWork.UserRepository.All().Single(x => x.Id == id);
            return user.UserSecurityQuestionAndAnswer.Answer == answer ? user.UserAndPassword.Password : string.Empty;
        }

        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            if (!ValidateUser(username, oldPassword)) return false;
            var userMembership = GetUser(username, false);
            if (userMembership != null && userMembership.ProviderUserKey == null) return false;
            if (userMembership?.ProviderUserKey != null)
            {
                var id = (int) userMembership.ProviderUserKey;
                var user = _unitOfWork.UserRepository.All().Single(x => x.Id == id);
                user.UserAndPassword.Password = GetPasswordToStore(newPassword);
                user.UserAndPassword.LastChanged = DateTime.Now;
            }
            _unitOfWork.Commit();
            return true;
        }

        public override string ResetPassword(string username, string answer)
        {
            var userMembership = GetUser(username, false);
            if (userMembership?.ProviderUserKey == null) return string.Empty;
            var id = (int)userMembership.ProviderUserKey;
            var user = _unitOfWork.UserRepository.All().Single(x => x.Id == id);
            var newPassword = GetGeneratedPassword();
            user.UserAndPassword.Password = GetPasswordToStore(newPassword);
            user.UserAndPassword.LastChanged = DateTime.Now;
            _unitOfWork.Commit();
            return user.UserSecurityQuestionAndAnswer.Answer == answer ? newPassword : string.Empty;
        }
        
        public override void UpdateUser(MembershipUser user)
        {
            var dbUser = _unitOfWork.UserRepository.All().Single(x => x.Id == (int) user.ProviderUserKey);
            dbUser.UserDetail.Comment = user.Comment;
            dbUser.UserDetail.Email = user.Email;
            dbUser.UserActivity.IsApproved = user.IsApproved;
            dbUser.UserActivity.IsLockedOut = user.IsLockedOut;
            dbUser.UserActivity.LastActiveDate = user.LastActivityDate;
            dbUser.UserActivity.LastLoggedInDate = user.LastLoginDate;
            _unitOfWork.Commit();
        }

        public override bool ValidateUser(string username, string password)
        {
            var userMembership = GetUser(username, false);
            if (userMembership?.ProviderUserKey == null) return false;
            var id = (int) userMembership.ProviderUserKey;
            var user = _unitOfWork.UserRepository.All().Single(x => x.Id == id);
            var userPassword = user.UserAndPassword.Password;
            if (ValidatePassword(password, userPassword)) return true;
            user.UserActivity.FailedLogins++;
            if (!user.UserActivity.IsLockedOut && user.UserActivity.FailedLogins > MaxInvalidPasswordAttempts)
            {
                user.UserActivity.IsLockedOut = true;
                user.UserActivity.LastLockedOutDate = DateTime.Now;
            }
            _unitOfWork.Commit();
            return false;
        }

        public override bool UnlockUser(string userName)
        {
            var userMembership = GetUser(userName, false);
            if (userMembership?.ProviderUserKey == null) return false;
            var id = (int)userMembership.ProviderUserKey;
            var user = _unitOfWork.UserRepository.All().Single(x => x.Id == id);
            user.UserActivity.IsLockedOut = false;
            _unitOfWork.Commit();
            return true;
        }

        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            var id = (int) providerUserKey;
            var user = _unitOfWork.UserRepository.All().Single(x => x.Id == id);
            if (userIsOnline)
            {
                user.UserActivity.LastActiveDate = DateTime.Now;
            }
            return GetMembershipUserFromUser(user);
        }

        public override MembershipUser GetUser(string username, bool userIsOnline)
        {
            var user = _unitOfWork.UserRepository.All().SingleOrDefault(x => x.UserDetail.Username == username);
            if (user == null)
            {
                return null;
            }
            if (userIsOnline)
            {
                user.UserActivity.LastActiveDate = DateTime.Now;
            }
            return GetMembershipUserFromUser(user);
        }

        public override string GetUserNameByEmail(string email)
        {
            return _unitOfWork.UserRepository.All().Single(x => x.UserDetail.Email == email).UserDetail.Username;
        }

        public override bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            var userMembership = GetUser(username, false);
            if (userMembership?.ProviderUserKey == null) return false;
            var id = (int)userMembership.ProviderUserKey;
            var user = _unitOfWork.UserRepository.All().Single(x => x.Id == id);
            _unitOfWork.UserRepository.Delete(user);
            _unitOfWork.Commit();
            return true;
        }

        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            var usersList = _unitOfWork.UserRepository.All();
            totalRecords = usersList.Count();
            return GetCollectionFromArray(usersList.Take(pageSize).Skip(pageIndex * pageSize).ToArray());
        }

        public override int GetNumberOfUsersOnline()
        {
            return _unitOfWork.UserRepository.All().Count(x => x.UserActivity.LastActiveDate < DateTime.Now.AddHours(-1));
        }

        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            var usersList = _unitOfWork.UserRepository.All().Where(x => x.UserDetail.Username == usernameToMatch);
            totalRecords = usersList.Count();
            return GetCollectionFromArray(usersList.Take(pageSize).Skip(pageIndex * pageSize).ToArray());
        }

        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            var usersList = _unitOfWork.UserRepository.All().Where(x => x.UserDetail.Email == emailToMatch);
            totalRecords = usersList.Count();
            return GetCollectionFromArray(usersList.Take(pageSize).Skip(pageIndex * pageSize).ToArray());
        }
        
        public override string ApplicationName { get; set; }

        public override bool EnablePasswordRetrieval => false;

        public override bool EnablePasswordReset => true;

        public override bool RequiresQuestionAndAnswer => true;

        public override int MaxInvalidPasswordAttempts => 3;

        public override int PasswordAttemptWindow => 10;

        public override bool RequiresUniqueEmail => true;

        public override MembershipPasswordFormat PasswordFormat => MembershipPasswordFormat.Hashed;

        public override int MinRequiredPasswordLength => 8;

        public override int MinRequiredNonAlphanumericCharacters => 1;

        public override string PasswordStrengthRegularExpression => @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d$@$!%*?&]{8,}";
    }
}