using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.InterfaceRepositories
{
    public interface IUserAddressRepository
    {
        // Add, Edit, Delete, Get One, Get All, Save 
        void AddUserAddress(UserAddressDomain newUserAddress);
        void EditUserAddress(UserAddressDomain editUserAddress);
        void DeleteUserAddress(string email, string addressCount);
        UserAddressDomain GetUserAddressById(string email, string addressCount); 
        IEnumerable<UserAddressDomain> GetAllUserAddress(string email);
        void Save(); 
    }
}
