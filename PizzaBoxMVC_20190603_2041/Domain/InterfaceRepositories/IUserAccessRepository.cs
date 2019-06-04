using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.InterfaceRepositories
{
    public interface IUserAccessRepository
    {
        void AddUserAccess(UserAccessDomain newUserAccess);
        UserAccessDomain GetUserAccessById(string email);
        void DeleteUserAccess(string email);
        void EditUserAccess(UserAccessDomain editUserAccess);
        void Save();
    }
}
