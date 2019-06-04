using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Data;
using Domain.InterfaceRepositories; 
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PizzaBoxWebApp.Models;

namespace PizzaBoxWebApp.Controllers
{
    public class UserNameController : Controller
    {
        private readonly IUserNameRepository db;

        public UserNameController(IUserNameRepository db) // constructor 
        {
            this.db = db;
        }


        Models.UserNameModel userModel;
        List<Models.UserNameModel> userNameList = new List<Models.UserNameModel>();
        // GET: UserName
        public IActionResult Index()
        {
            var allUserName = db.GetAllUserName();
            foreach (var user in allUserName)
            {
                userModel = new Models.UserNameModel();
                userModel.Email = user.Email;
                userModel.FirstName = user.FirstName;
                userModel.LastName = user.LastName;
                userModel.Phone = user.Phone;
                userNameList.Add(userModel);
            }
            return View(userNameList);
        }




        public IActionResult TestCase()
        {
            return View();
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult TestCase(Models.UserNameModel newUserName)
        {
            Domain.UserNameDomain toAddDomainUserName = new Domain.UserNameDomain();

            if (ModelState.IsValid)
            {
                toAddDomainUserName.Email = newUserName.Email;
                toAddDomainUserName.FirstName = newUserName.FirstName;
                toAddDomainUserName.LastName = newUserName.LastName;
                toAddDomainUserName.Phone = newUserName.Phone;
                db.Add(toAddDomainUserName);
                db.Save();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }













    }
}