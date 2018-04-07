using System.Data.Entity;
using $safeprojectname$.Interfaces;

namespace $safeprojectname$
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly $ext_safeprojectname$DBEntities _database = new $ext_safeprojectname$DBEntities();
        public void Dispose()
        {
            _database.Dispose();
        }
        public IRepository<Role> RoleRepository => new Repository<Role>(_database.Roles);
        public IRepository<SecurityQuestion> SecurityQuestionsRepository => new Repository<SecurityQuestion>(_database.SecurityQuestions);
        public IRepository<User> UserRepository => new Repository<User>(_database.Users);
        public IRepository<UserActivity> UserActivityRepository => new Repository<UserActivity>(_database.UserActivities);
        public IRepository<UserAndPassword> UserAndPasswordRepository => new Repository<UserAndPassword>(_database.UserAndPasswords);
        public IRepository<UserDetail> UserDetailRepository => new Repository<UserDetail>(_database.UserDetails);
        public IRepository<UserSecurityQuestionAndAnswer> UserSecurityQuestionAndAnswerRepository => new Repository<UserSecurityQuestionAndAnswer>(_database.UserSecurityQuestionAndAnswers);
        public void Commit()
        {
            _database.SaveChanges();
        }
}
}
