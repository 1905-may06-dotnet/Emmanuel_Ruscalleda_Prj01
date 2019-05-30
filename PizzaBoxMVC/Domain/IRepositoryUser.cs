using System;
using System.Collections.Generic;
using System.Text;
using Data.DataModel;

namespace Domain
{   // A repository managing data acces for User (UserName, UserAccess, UserCard, UserAddress) 

    public interface IRepositoryUser
    {
        
        // Persist changes to the data source 
        void Save();

        // *********************************************** 

        #region UserNameTable

        // Get all from UserName 
        IEnumerable<UserName> GetAllUserName(string search);

        // Get a UserName by ID
        UserName GetUserNameById(string email);

        // Add a UserName 
        void AddUserName(UserName newUserName);

        // Delete a UserName by ID
        void DeleteUserNameById(string email);

        // Update a UserName 
        void UpdateUserName(UserName updatedUserName);

        #endregion

        // *********************************************** 

        #region UserAccessTable

        // Get all from UserAccess 
        IEnumerable<UserAccess> GetAllUserAccess(string search);

        // Get a UserAccess by ID
        UserAccess GetUserAccessById(string email);

        // Add a UserAccess 
        void AddUserAccess(UserAccess newUserAccess);

        // Delete a UserAccess by ID
        void DeleteUserAccess(string email);

        // Update a UserAccess 
        void UpdateUserAccess(UserAccess updatedUserAccess);

        #endregion

        // *********************************************** 

        #region UserCardTable

        // Get all from UserCard 
        IEnumerable<UserCard> GetAllUserCard(string search);

        // Get all user cards by email
        IEnumerable<UserCard> GetUserCardsByEmail(string email);

        // Add a UserCard 
        void AddUserCard(UserCard newUserCard);

        // Delete a UserCard by composite ID (email and card number)
        void DeleteUserCard(string email, string cardNumber);

        // Update a UserCard 
        void UpdateUserCard(UserCard updatedUserCard);

        #endregion

        // *********************************************** 

        #region UserAddressTable

        // Get all from UserAddress 
        IEnumerable<UserAddress> GetAllUserAddress(string search);

        // Get all user addresses by email
        IEnumerable<UserAddress> GetUserAddresssByEmail(string email);

        // Add a UserAddress 
        void AddUserAddress(UserAddress newUserAddress);

        // Delete a UserAddress by composite ID (email and address count)
        void DeleteUserAddress(string email, string addressCount);

        // Update a UserAddress 
        void UpdateUserAddress(UserAddress updatedUserAddress);

        #endregion
        
    } // end of: IRepositoryUser interface 
}