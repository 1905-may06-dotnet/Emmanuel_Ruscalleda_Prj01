using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Data.DataModel;
using System.Linq;


namespace Data
{
    public class UserRepository : IUserRepository
    {

        private readonly DBContext _db;

        public UserRepository(DBContext db) // constructor
        {
            _db = db;
        }

        public void Add(Domain.UserName newUserName)
        {
            _db.UserName.Add(UserMapper.Map(newUserName));
        }

        public void DeleteUserName(string email)
        {
            var user = _db.UserName.Where(a => a.Email == email).FirstOrDefault();
            if (user != null)
            {
                _db.UserName.Remove(user);
            }
        }

        public void EditUserName(Domain.UserName editUserName)
        {
            if (_db.UserName.Find(editUserName.Email) != null)
            {
                _db.UserName.Update(UserMapper.Map(editUserName));
            }
        }

        public Domain.UserName GetUserNameById(string email)
        {
            var user = _db.UserName.Where(x => x.Email == email).FirstOrDefault();
            return UserMapper.Map(user);
        }

        public IEnumerable<Domain.UserName> GetAllUserName()
        {
            return _db.UserName.Select(x => UserMapper.Map(x));
        }



        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
