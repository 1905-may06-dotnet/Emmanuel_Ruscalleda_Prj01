using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.InterfaceRepositories
{
    public interface IUserNameRepository
    {
        void Add(UserNameDomain newUserName);
        void EditUserName(UserNameDomain editUserName);
        void DeleteUserName(string email);
        UserNameDomain GetUserNameById(string email);
        IEnumerable<UserNameDomain> GetAllUserName();
        void Save();
    }
}