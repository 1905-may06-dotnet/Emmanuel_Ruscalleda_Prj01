using System;
using System.Collections.Generic;
using System.Text;
using Domain;


namespace Data.Mappers
{
    class UserAccessMapper
    {
        public static Data.DataModel.UserAccess Map(UserAccessDomain domUserAccess)
        {
            Data.DataModel.UserAccess datUserAccess = new DataModel.UserAccess();
            datUserAccess.Email = domUserAccess.Email;
            datUserAccess.Password = domUserAccess.Password;
            return datUserAccess;
        }

        public static Domain.UserAccessDomain Map(Data.DataModel.UserAccess datUserAccess) => new Domain.UserAccessDomain
        {
            Email = datUserAccess.Email,
            Password = datUserAccess.Password
        };






    }
}
