using System;
using System.Data.Entity;

namespace WebSite8.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Role> RoleRepository { get; }
        IRepository<SecurityQuestion> SecurityQuestionsRepository { get; }
        IRepository<User> UserRepository { get; }
        IRepository<UserActivity> UserActivityRepository { get; }
        IRepository<UserAndPassword> UserAndPasswordRepository { get; }
        IRepository<UserDetail> UserDetailRepository { get; }
        IRepository<UserSecurityQuestionAndAnswer> UserSecurityQuestionAndAnswerRepository { get; }
    }
}