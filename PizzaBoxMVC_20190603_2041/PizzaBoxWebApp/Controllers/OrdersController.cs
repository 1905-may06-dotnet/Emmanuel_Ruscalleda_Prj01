using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PizzaBoxWebApp.Controllers
{
    public class OrdersController : Controller
    {

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Confirmation()
        {
            return View();
        }


        public IActionResult CustomePizza()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }

        public IActionResult Offers()
        {
            return View();
        }


        public IActionResult SelectLocation()
        {
            return View();
        }








    }
}