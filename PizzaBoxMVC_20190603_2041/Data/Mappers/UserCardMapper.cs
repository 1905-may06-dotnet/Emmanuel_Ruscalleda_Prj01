using System;
using System.Collections.Generic;
using System.Text;
using Domain;


namespace Data.Mappers
{
    class UserCardMapper
    {
        public static Data.DataModel.UserCard Map(UserCardDomain domUserCard)
        {
            Data.DataModel.UserCard datUserCard = new DataModel.UserCard();
            datUserCard.Email = domUserCard.Email;
            datUserCard.CardNumber = domUserCard.CardNumber;
            datUserCard.Cvv = domUserCard.CVV;
            datUserCard.ValidThru = domUserCard.ValidThru;
            datUserCard.FirstName = domUserCard.FirstName;
            datUserCard.LastName = domUserCard.LastName;
            datUserCard.Address1 = domUserCard.Address1;
            datUserCard.Address2 = domUserCard.Address2;
            datUserCard.City = domUserCard.City;
            datUserCard.State = domUserCard.State;
            datUserCard.Zipcode = domUserCard.Zipcode;
            return datUserCard;
        }

        public static UserCardDomain Map(Data.DataModel.UserCard datUserCard) => new UserCardDomain
        {
            Email = datUserCard.Email,
            CardNumber = datUserCard.CardNumber,
            CVV = datUserCard.Cvv,
            ValidThru = datUserCard.ValidThru,
            FirstName = datUserCard.FirstName,
            LastName = datUserCard.LastName,
            Address1 = datUserCard.Address1,
            Address2 = datUserCard.Address2,
            City = datUserCard.City,
            State = datUserCard.State,
            Zipcode = datUserCard.Zipcode
        };

    }
}
