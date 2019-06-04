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
    public class UserNameRepository : IUserNameRepository
    {

        private readonly DBContext _db;

        public UserNameRepository(DBContext db) // constructor
        {
            _db = db;
        }

        public void Add(Domain.UserNameDomain newUserName)
        {
            _db.UserName.Add(UserNameMapper.Map(newUserName));
        }

        public void DeleteUserName(string email)
        {
            var user = _db.UserName.Where(a => a.Email == email).FirstOrDefault();
            if (user != null)
            {
                _db.UserName.Remove(user);
            }
        }

        public void EditUserName(Domain.UserNameDomain editUserName)
        {
            if (_db.UserName.Find(editUserName.Email) != null)
            {
                _db.UserName.Update(UserNameMapper.Map(editUserName));
            }
        }

        public Domain.UserNameDomain GetUserNameById(string email)
        {
            var user = _db.UserName.Where(x => x.Email == email).FirstOrDefault();
            return UserNameMapper.Map(user);
        }

        public IEnumerable<Domain.UserNameDomain> GetAllUserName()
        {
            return _db.UserName.Select(x => UserNameMapper.Map(x));
        }

        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
