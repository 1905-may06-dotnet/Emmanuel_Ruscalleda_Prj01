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
    public class UserCardRepository : IUserCardRepository
    {
        private readonly DBContext _db;

        public UserCardRepository(DBContext db) // constructor 
        {
            _db = db;
        }

        public void AddUserCard(UserCardDomain newUserCard)
        {
            _db.UserCard.Add(UserCardMapper.Map(newUserCard));
        }
        public void EditUserCard(UserCardDomain editUserCard)
        {
            var card = _db.UserCard.Where(a => a.Email == editUserCard.Email && a.CardNumber == editUserCard.CardNumber).FirstOrDefault();
            if (card != null)
            {
                _db.UserCard.Update(UserCardMapper.Map(editUserCard));
            }

        }
        public void DeleteUserCard(string email, string cardNumber)
        {
            var card = _db.UserCard.Where<UserCard>(a => a.Email == email && a.CardNumber == cardNumber).FirstOrDefault();
            if (card != null)
            {
                _db.UserCard.Remove(card);
            }
        }
        public UserCardDomain GetUserCardById(string email, string cardNumber)
        {
            var card = _db.UserCard.Where<UserCard>(a => a.Email == email && a.CardNumber == cardNumber).FirstOrDefault();
            return UserCardMapper.Map(card);
        }
        public IEnumerable<UserCardDomain> GetAllUserAddress(string email)
        {
            var cardsCollection = _db.UserCard.Where<UserCard>(a => a.Email == email);
            List<UserCardDomain> cardList = new List<UserCardDomain>();
            foreach (var card in cardsCollection)
            {
                cardList.Add(UserCardMapper.Map(card));
            }
            return cardList;
        }
        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
