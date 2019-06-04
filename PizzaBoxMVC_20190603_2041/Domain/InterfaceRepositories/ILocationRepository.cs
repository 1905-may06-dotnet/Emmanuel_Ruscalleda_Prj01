using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.InterfaceRepositories
{
    public interface ILocationRepository
    {
        void Add(LocationInfoDomain newLocation);
        void EditLocation(LocationInfoDomain editLocation);
        void DelteLocaiton(int locaitonId);
        LocationInfoDomain GetLocationById(int locaitonId);
        IEnumerable<LocationInfoDomain> GetAllLocations();
        void Save();
    }
}
