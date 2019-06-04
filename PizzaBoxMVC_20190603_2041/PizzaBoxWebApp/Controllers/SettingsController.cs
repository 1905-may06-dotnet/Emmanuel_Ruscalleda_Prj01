using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PizzaBoxWebApp.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult MainSettings()
        {
            return View();
        }
    }
}