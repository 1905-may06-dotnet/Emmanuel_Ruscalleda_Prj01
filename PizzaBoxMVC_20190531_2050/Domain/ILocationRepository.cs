using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface ILocationRepository
    {
        void Add(LocationInfo newLocation);
        void EditLocation(LocationInfo editLocation);
        void DelteLocaiton(int locaitonId);
        LocationInfo GetLocationById(int locaitonId);
        IEnumerable<LocationInfo> GetAllLocations();
        void Save();
    }
}
