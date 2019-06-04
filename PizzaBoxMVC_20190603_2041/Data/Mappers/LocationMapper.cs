using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mappers
{
    class LocationMapper
    {
        public static Data.DataModel.LocationInfo Map(Domain.LocationInfoDomain domLocationInfo)
        {
            Data.DataModel.LocationInfo daLocaitonInfo = new DataModel.LocationInfo();

            daLocaitonInfo.LocationId = domLocationInfo.LocationId;
            daLocaitonInfo.Name = domLocationInfo.Name; //<-- good
            daLocaitonInfo.Address1 = domLocationInfo.Address1;
            daLocaitonInfo.Address2 = domLocationInfo.Address2;
            daLocaitonInfo.City = domLocationInfo.City;
            daLocaitonInfo.State = domLocationInfo.State;
            daLocaitonInfo.Zipcode = domLocationInfo.Zipcode;
            daLocaitonInfo.Phone = domLocationInfo.Phone;

            return daLocaitonInfo;
        }


        public static Domain.LocationInfoDomain Map(Data.DataModel.LocationInfo daLocaitonInfo) => new Domain.LocationInfoDomain
        {
            LocationId = daLocaitonInfo.LocationId,
            Name = daLocaitonInfo.Name, //<-- good
            Address1 = daLocaitonInfo.Address1,
            Address2 = daLocaitonInfo.Address2,
            City = daLocaitonInfo.City,
            State = daLocaitonInfo.State,
            Zipcode = daLocaitonInfo.Zipcode,
            Phone = daLocaitonInfo.Phone
        };
    }
}
