using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain.InterfaceRepositories;


namespace PizzaBoxWebApp.Controllers
{
    public class MenusController : Controller
    {

        private readonly ILocationRepository db;
        public MenusController(ILocationRepository db) // constructor 
        {
            this.db = db;
        }


        Models.LocationInfoModel locationInfoModel;
        List<Models.LocationInfoModel> locationsInfoList = new List<Models.LocationInfoModel>();
        public IActionResult GuestLocationsList()
        {
            var allLocations = db.GetAllLocations();
            int tempCount = 1;
            foreach (var location in allLocations)
            {
                string a1a2space = ", ";
                locationInfoModel = new Models.LocationInfoModel();
                locationInfoModel.Number = tempCount;
                locationInfoModel.LocaitonId = location.LocationId;
                locationInfoModel.Name = location.Name;
                locationInfoModel.Address1 = "";
                locationInfoModel.Address2 = "";
                locationInfoModel.City = "";
                locationInfoModel.State = "";
                locationInfoModel.Zipcode = "";
                if (String.IsNullOrEmpty(location.Address2))
                {
                    a1a2space = " ";
                }
                locationInfoModel.FullAddress = location.Address1 + a1a2space + location.Address2 + " \n| " + location.City + ", " + location.State + " " + location.Zipcode;
                locationInfoModel.Phone = location.Phone;
                locationsInfoList.Add(locationInfoModel);
                tempCount = tempCount + 1;

            }

            return View(locationsInfoList);
        }

        public IActionResult GuestMainMenu()
        {
            return View();
        }

        public IActionResult GuestRestaurantMenu()
        {
            return View();
        }



        //Models.LocationInfoModel locationInfoModel;
        //List<Models.LocationInfoModel> locationsInfoList = new List<Models.LocationInfoModel>();
        public IActionResult UserLocationsList()
        {
            var allLocations = db.GetAllLocations();
            int tempCount = 1;
            foreach (var location in allLocations)
            {
                string a1a2space = ", "; 
                locationInfoModel = new Models.LocationInfoModel();
                locationInfoModel.Number = tempCount;
                locationInfoModel.LocaitonId = location.LocationId;
                locationInfoModel.Name = location.Name;
                locationInfoModel.Address1 = "";
                locationInfoModel.Address2 = "";
                locationInfoModel.City = "";
                locationInfoModel.State = "";
                locationInfoModel.Zipcode = "";
                if (String.IsNullOrEmpty(location.Address2))
                {
                    a1a2space = " "; 
                }
                locationInfoModel.FullAddress = location.Address1 + a1a2space + location.Address2 + " \n| " + location.City + ", " + location.State + " " + location.Zipcode;
                locationInfoModel.Phone = location.Phone;
                locationsInfoList.Add(locationInfoModel);
                tempCount = tempCount + 1;

            }

            return View(locationsInfoList);
        }

        public IActionResult UserMainMenu()
        {
            return View();
        }

        public IActionResult UserRestaurantMenu()
        {
            return View();
        }








    }
}