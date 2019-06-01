using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    class UserMapper
    {
        public static Data.DataModel.UserName Map(Domain.UserName domUserName)
        {
            Data.DataModel.UserName datUserName = new DataModel.UserName();
            datUserName.Email = domUserName.Email;
            datUserName.FirstName = domUserName.FirstName;
            datUserName.LastName = domUserName.LastName;
            datUserName.Phone = domUserName.Phone;
            return datUserName;
        }

        public static Domain.UserName Map(Data.DataModel.UserName datUserName) => new Domain.UserName
        {
            Email = datUserName.Email,
            FirstName = datUserName.FirstName,
            LastName = datUserName.LastName,
            Phone = datUserName.Phone
        };
    }
}
