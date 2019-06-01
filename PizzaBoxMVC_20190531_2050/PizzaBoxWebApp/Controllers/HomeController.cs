using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaBoxWebApp.Models;

namespace PizzaBoxWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();

        }

        public IActionResult SelectLocation()
        {
            return View();

        }

        public IActionResult NewUser()
        {
            return View();

        }

        public IActionResult Guest()
        {
            return View();

        }

        public IActionResult Menu()
        {
            return View();

        }

        public IActionResult MainMenu()
        {
            return View();

        }


        public IActionResult Order()
        {
            return View();

        }

        public IActionResult Confirmation()
        {
            return View();

        }


        public IActionResult Offers()
        {
            return View();

        }

        public IActionResult History()
        {
            return View();
        }

        public IActionResult Settings()
        {
            return View();
        }


        public IActionResult UserInfo()
        {
            return View();
        }

        public IActionResult ComingSoon()
        {
            return View();
        }


        public IActionResult Cart()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
