using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.InterfaceRepositories
{
    public interface IUserCardRepository
    {
        // Add, Edit, Delete, Get One, Get All, Save 

        void AddUserCard(UserCardDomain newUserCard);
        void EditUserCard(UserCardDomain editUserCard);
        void DeleteUserCard(string email, string cardNumber);
        UserCardDomain GetUserCardById(string email, string cardNumber);
        IEnumerable<UserCardDomain> GetAllUserAddress(string email);
        void Save();
    }
}
