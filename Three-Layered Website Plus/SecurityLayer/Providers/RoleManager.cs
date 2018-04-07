using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using $ext_safeprojectname$.Data;
using $ext_safeprojectname$.Data.Interfaces;

namespace $safeprojectname$.Providers
{
    public class RoleManager : RoleProvider
    {

        private readonly IUnitOfWork _unitOfWork;

        public RoleManager()
        {
            _unitOfWork = DependencyResolver.Current.GetService<IUnitOfWork>();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            return _unitOfWork.UserRepository.All().Any(x => x.UserDetail.Username == username && x.UserToRoles.Any(userToRole => userToRole.Role.Name == roleName));
        }

        public override string[] GetRolesForUser(string username)
        {
            return _unitOfWork.UserRepository.All().Single(x => x.UserDetail.Username == username).UserToRoles.Select(x => x.Role.Name).ToArray();
        }

        public override void CreateRole(string roleName)
        {
            _unitOfWork.RoleRepository.Add(new Role() {Name = roleName});
            _unitOfWork.Commit();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            if (GetUsersInRole(roleName).Any()) return false;
            var role = _unitOfWork.RoleRepository.All().Single(x => x.Name == roleName);
            _unitOfWork.RoleRepository.Delete(role);
            return true;
        }

        public override bool RoleExists(string roleName)
        {
            return _unitOfWork.RoleRepository.All().Any(x => x.Name == roleName);
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            var rolesToAdd = _unitOfWork.RoleRepository.All().Where(x => roleNames.Contains(x.Name)).Select(x => x.Id).ToArray();
            var usersToAddTo = _unitOfWork.UserRepository.All().Where(x => usernames.Contains(x.UserDetail.Username)).ToArray();
            foreach (var user in usersToAddTo)
            {
                foreach (var role in rolesToAdd)
                {
                    if(user.UserToRoles.Any(x => x.RoleId == role)) continue;
                    user.UserToRoles.Add(new UserToRole()
                    {
                        UserId = user.Id,
                        RoleId = role
                    });
                }
            }
            _unitOfWork.Commit();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            var users = _unitOfWork.UserRepository.All().Where(x => usernames.Contains(x.UserDetail.Username)).ToArray();
            var rolesToRemove = _unitOfWork.RoleRepository.All().Where(x => roleNames.Contains(x.Name)).ToArray();
            foreach (var user in users)
            {
                foreach (var role in rolesToRemove)
                {
                    var userToRole = user.UserToRoles.SingleOrDefault(x => x.RoleId == role.Id);
                    if (userToRole ==  null) continue;
                    user.UserToRoles.Remove(userToRole);
                }
            }
            _unitOfWork.Commit();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            return _unitOfWork.UserRepository.All().Where(x => x.UserToRoles.Any(y => y.Role.Name == roleName)).Select(x => x.UserDetail.Username).ToArray();
        }

        public override string[] GetAllRoles()
        {
            return _unitOfWork.RoleRepository.All().Select(x => x.Name).ToArray();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            return GetUsersInRole(roleName).Where(x => x.Contains(usernameToMatch)).ToArray();
        }

        public override string ApplicationName { get; set; }
    }
}