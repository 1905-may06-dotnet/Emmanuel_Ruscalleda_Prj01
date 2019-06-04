using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Domain.InterfaceRepositories;
using Data.DataModel;
using Data.Mappers;
using System.Linq;

namespace Data.Repositories
{
    public class UserAddressRepository : IUserAddressRepository
    {
        private readonly DBContext _db;

        public UserAddressRepository(DBContext db) // constructor
        {
            _db = db;
        }

        public void AddUserAddress(UserAddressDomain newUserAddress)
        {
            _db.UserAddress.Add(UserAddressMapper.Map(newUserAddress));
        }
        public void EditUserAddress(UserAddressDomain editUserAddress)
        {
            var address = _db.UserAddress.Where<UserAddress>(a => a.Email == editUserAddress.Email && a.AddressCount == editUserAddress.AddressCount).FirstOrDefault();
            if (address != null)
            {
                _db.UserAddress.Update(UserAddressMapper.Map(editUserAddress));
            }
        }
        public void DeleteUserAddress(string email, string addressCount)
        {
            var address = _db.UserAddress.Where<UserAddress>(a => a.Email == email && a.AddressCount == addressCount).FirstOrDefault();
            if (address != null)
            {
                _db.UserAddress.Remove(address);
            }
        }
        public UserAddressDomain GetUserAddressById(string email, string addressCount)
        {
            var address = _db.UserAddress.Where<UserAddress>(a => a.Email == email && a.AddressCount == addressCount).FirstOrDefault();
            return UserAddressMapper.Map(address);
        }
        public IEnumerable<UserAddressDomain> GetAllUserAddress(string email)
        {

            var addressCollection = _db.UserAddress.Where(a => a.Email == email);

            List<UserAddressDomain> addressList = new List<UserAddressDomain>();
            foreach (var address in addressCollection)
            {
                addressList.Add(UserAddressMapper.Map(address));

            }
            return addressList;
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
