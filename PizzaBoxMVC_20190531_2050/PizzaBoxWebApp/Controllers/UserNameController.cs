using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace PizzaBoxWebApp.Controllers
{
    public class UserNameController : Controller
    {
        private readonly IUserRepository db;

        public UserNameController(IUserRepository db) // constructor 
        {
            this.db = db; 
        }

        Models.UserName userModel;

        List<Models.UserName> userNameList = new List<Models.UserName>(); 

        // GET: UserName
        public ActionResult Index()
        {
            var allUserName = db.GetAllUserName(); 
            foreach(var user in allUserName)
            {
                userModel = new Models.UserName();
                userModel.Email = user.Email;
                userModel.FirstName = user.FirstName;
                userModel.LastName = user.LastName;
                userModel.Phone = user.Phone;
                userNameList.Add(userModel); 
            }
            return View(userNameList);
        }
















    }
}