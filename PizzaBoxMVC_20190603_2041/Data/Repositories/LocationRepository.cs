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
    public class LocationRepository : ILocationRepository
    {

        private readonly DBContext _db;

        public LocationRepository(DBContext db) // constructor
        {
            _db = db;
        }


        public void Add(Domain.LocationInfoDomain newLocation)
        {
            _db.LocationInfo.Add(LocationMapper.Map(newLocation));
        }


        public void DelteLocaiton(int locaitonId)
        {
            var loct = _db.LocationInfo.Where(a => a.LocationId == locaitonId).FirstOrDefault();
            if (loct != null)
            {
                _db.LocationInfo.Remove(loct);
            }
        }


        public void EditLocation(Domain.LocationInfoDomain editLocation)
        {
            if (_db.LocationInfo.Find(editLocation.LocationId) != null)
            {
                _db.LocationInfo.Update(LocationMapper.Map(editLocation));
            }
        }


        public Domain.LocationInfoDomain GetLocationById(int locationId)
        {
            var loct = _db.LocationInfo.Where(u => u.LocationId == locationId).FirstOrDefault();
            return LocationMapper.Map(loct); 
        }


        public IEnumerable<Domain.LocationInfoDomain> GetAllLocations()
        {
            return _db.LocationInfo.Select(x => LocationMapper.Map(x));


        }


        public void Save()
        {
            _db.SaveChanges();

        }



    }
}
