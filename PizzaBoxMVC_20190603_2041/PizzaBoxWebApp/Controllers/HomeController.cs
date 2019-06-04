using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaBoxWebApp.Models;
using Data.Functions;
using Domain;
using Domain.InterfaceRepositories;
using Data.Repositories;
using System.Threading;
using Microsoft.AspNetCore.Routing;

namespace PizzaBoxWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserNameRepository dbUN;
        private readonly IUserAccessRepository dbUAc;
        private readonly IUserAddressRepository dbUAd;
        private readonly IUserCardRepository dbUC;

        public HomeController(IUserNameRepository dbUN, IUserAccessRepository dbUAc, IUserAddressRepository dbUAd, IUserCardRepository dbUC) // constructor 
        {
            this.dbUN = dbUN;
            this.dbUAc = dbUAc;
            this.dbUAd = dbUAd;
            this.dbUC = dbUC; 
        }



        public IActionResult ComingSoon()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Models.UserAccessModel userConfirmation)
        {
            if (ModelState.IsValid)
            {
                List<bool> test = ExistingUser.SignIn(userConfirmation.Email, userConfirmation.Password);
                bool isEmailOnDB = test[0];
                bool isPasswordCorrect = test[1];
                if (isEmailOnDB == false)
                {
                    ModelState.AddModelError("Email", "Email not found or matched");
                    return View(userConfirmation);
                }
                else
                {
                    if (isPasswordCorrect == false)
                    {
                        ModelState.AddModelError("Password", "Incorrect password");
                        return View(userConfirmation);
                    }
                    else
                    {
                        ViewBag.Email = userConfirmation.Email;
                        return RedirectToRoute(new { controller = "Menus", action = "UserMainMenu" });
                    }
                }
            }
            return View();
        }

        public IActionResult NewUserCheck()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewUserCheck(Models.NewUserCheckModel userConfirmation)
        {
            if (ModelState.IsValid)
            {
                if (userConfirmation.Email1 == userConfirmation.Email2)
                {
                    List<bool> test = ExistingUser.SignIn(userConfirmation.Email1, "void");
                    bool isEmailOnDB = test[0];
                    if (isEmailOnDB == true)
                    {
                        ModelState.AddModelError("Email1", "Email already in use");
                        return View(userConfirmation);
                    }
                    else
                    {
                        TempData["Email"] = userConfirmation.Email1;
                        TempData.Keep("Email");
                        ViewData["Email"] = userConfirmation.Email1;
                        ViewBag.Email = userConfirmation.Email1;
                        return RedirectToRoute(new { controller = "Home", action = "NewUserInfo" }); 


                    }
                }
                else
                {
                    ModelState.AddModelError("Email2", "Emails must match");
                    return View(userConfirmation);
                }
            }
            return View();
        }

        public IActionResult NewUserInfo(string email)
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewUserInfo(Models.NewUserInfoModel userInfo, string email)
        {
  
            if (ModelState.IsValid)
            {
                if (userInfo.Password1 == userInfo.Password2)
                {
                    UserNameDomain toAddUserNameDomain = new UserNameDomain();
                    UserAccessDomain toAddUserAccessDomain = new UserAccessDomain();
                    UserAddressDomain toAddUserAddressDomain = new UserAddressDomain();
                    UserCardDomain toAddUserCardDomain = new UserCardDomain();

                    toAddUserNameDomain.Email = TempData["Email"].ToString(); 
                    toAddUserNameDomain.FirstName = userInfo.FirstName;
                    toAddUserNameDomain.LastName = userInfo.LastName;
                    /* 
                     toAddUserNameDomain.Phone = userInfo.Phone;


                     toAddUserAccessDomain.Email = toAddUserNameDomain.Email;
                     toAddUserAccessDomain.Password = userInfo.Password1;

                     toAddUserAddressDomain.Email = toAddUserNameDomain.Email;
                     toAddUserAddressDomain.AddressCount = "1";
                     toAddUserAddressDomain.Address1 = userInfo.Address1;
                     toAddUserAddressDomain.Address2 = userInfo.Address2;
                     toAddUserAddressDomain.City = userInfo.City;
                     toAddUserAddressDomain.State = userInfo.State;
                     toAddUserAddressDomain.Zipcode = userInfo.Zipcode;
                     toAddUserAddressDomain.AddressDetails = userInfo.AddressDetails;

                     toAddUserCardDomain.Email = toAddUserNameDomain.Email;
                     toAddUserCardDomain.CardNumber = userInfo.CreidtCardNumber;
                     toAddUserCardDomain.CVV = userInfo.CVV;
                     toAddUserCardDomain.ValidThru = userInfo.ValidThru;
                     toAddUserCardDomain.FirstName = userInfo.CardFirstName;
                     toAddUserCardDomain.LastName = userInfo.CardLastName;
                     toAddUserCardDomain.Address1 = userInfo.CardAddress1;
                     toAddUserCardDomain.Address2 = userInfo.CardAddress2;
                     toAddUserCardDomain.City = userInfo.CardCity;
                     toAddUserCardDomain.State = userInfo.CardState;
                     toAddUserCardDomain.Zipcode = userInfo.CardZipcode;
                     */
                    dbUN.Add(toAddUserNameDomain);
                    dbUN.Save();
                    /*
                    dbUAc.AddUserAccess(toAddUserAccessDomain);
                    dbUAc.Save();
                    dbUAd.AddUserAddress(toAddUserAddressDomain);
                    dbUAd.Save();
                    dbUC.AddUserCard(toAddUserCardDomain);
                    dbUC.Save();
                    */
                    return View("AccountConfirmation");
                }
                else
                {
                    ModelState.AddModelError("Password2", "Passwords must match");
                    return View(userInfo);
                }
            }
            return View(userInfo);
        }


        public IActionResult Privacy()
        {
            return View();

        }

        public IActionResult GuestMainMenu()
        {
            return View("/Views/Menus/GuestMainMenu.cshtml");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
