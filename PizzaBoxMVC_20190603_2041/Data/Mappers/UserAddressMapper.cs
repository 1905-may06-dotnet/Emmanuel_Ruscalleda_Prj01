using System;
using System.Collections.Generic;
using System.Text;
using Domain;


namespace Data.Mappers
{
    class UserAddressMapper
    {
        
        public static Data.DataModel.UserAddress Map(UserAddressDomain domUserAddress)
        {
            Data.DataModel.UserAddress datUserAddress = new DataModel.UserAddress();
            datUserAddress.Email = domUserAddress.Email;
            datUserAddress.AddressCount = domUserAddress.AddressCount;
            datUserAddress.Address1 = domUserAddress.Address1;
            datUserAddress.Address2 = domUserAddress.Address2;
            datUserAddress.City = domUserAddress.City;
            datUserAddress.State = domUserAddress.State;
            datUserAddress.Zipcode = domUserAddress.Zipcode;
            datUserAddress.AddressDetails = domUserAddress.AddressDetails;
            return datUserAddress;
        }

        public static UserAddressDomain Map(Data.DataModel.UserAddress datUserAddress) => new UserAddressDomain
        {
            Email = datUserAddress.Email,
            AddressCount = datUserAddress.AddressCount,
            Address1 = datUserAddress.Address1,
            Address2 = datUserAddress.Address2,
            City = datUserAddress.City,
            State = datUserAddress.State,
            Zipcode = datUserAddress.Zipcode,
            AddressDetails = datUserAddress.AddressDetails,
        };



    }
}
