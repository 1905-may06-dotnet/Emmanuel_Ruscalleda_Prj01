using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain;


namespace PizzaBoxWebApp.Controllers
{
    public class LocationInfoController : Controller
    {
        private readonly ILocationRepository db;

        public LocationInfoController(ILocationRepository db)
        {
            this.db = db; 
        }

        Models.LocationInfo loctModel;
        List<Models.LocationInfo> loctList = new List<Models.LocationInfo>(); 


        public IActionResult Index()
        {
            var allLocations = db.GetAllLocations();
            List<string> allNames = new List<string>();
            allNames.Add("PizzaBox #1");
            allNames.Add("PizzaBox at Stadium Plaza");
            allNames.Add("PizzaBox at Legacy");
            int x = 1;
            foreach (var loct in allLocations)
            {
                loctModel = new Models.LocationInfo();
                //loctModel.LocaitonId = loct.LocationId;
                loctModel.LocaitonId = x;
                loctModel.Name = allNames[x-1]; // <---- problem here 
                loctModel.Address1 = loct.Address1;
                loctModel.Address2 = loct.Address2;
                loctModel.City = "Arlington";//loct.City;
                loctModel.State = "TX";//loct.State;
                loctModel.Zipcode = loct.Zipcode;
                loctModel.Phone = loct.Phone;
                loctList.Add(loctModel);
                x = x + 1;

            }

            return View(loctList);
        }
    }
}