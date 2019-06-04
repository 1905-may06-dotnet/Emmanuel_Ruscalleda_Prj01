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
    public class UserAccessRepository : IUserAccessRepository
    {
        private readonly DBContext _db;

        public UserAccessRepository(DBContext db) // constructor
        {
            _db = db;
        }

        public void AddUserAccess(UserAccessDomain newUserAccess)
        {
            _db.UserAccess.Add(UserAccessMapper.Map(newUserAccess));
        }
        public UserAccessDomain GetUserAccessById(string email)
        {
            var userAccess = _db.UserAccess.Where(x => x.Email == email).FirstOrDefault();
            return UserAccessMapper.Map(userAccess);
        }
        public void DeleteUserAccess(string email)
        {
            var userAccess = _db.UserAccess.Where(a => a.Email == email).FirstOrDefault();
            if (userAccess != null)
            {
                _db.UserAccess.Remove(userAccess);
            }
        }
        public void EditUserAccess(UserAccessDomain editUserAccess)
        {
            if (_db.UserAccess.Find(editUserAccess.Email) != null)
            {
                _db.UserAccess.Update(UserAccessMapper.Map(editUserAccess));
            }
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
