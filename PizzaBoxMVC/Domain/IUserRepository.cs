


using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IUserRepository
    {
        void Add(UserName newUserName);
        void EditUserName(UserName editUserName);
        void DeleteUserName(string email);
        UserName GetUserNameById(string email);
        IEnumerable<UserName> GetAllUserName(); 
        void Save();
    }
}