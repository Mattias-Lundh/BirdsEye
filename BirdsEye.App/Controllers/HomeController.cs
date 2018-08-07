using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using BirdsEye.App.Models;
using BirdsEye.Data;
using BirdsEye.Domain.Models;

namespace BirdsEye.App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LoginGo(LogIn logIn)
        {
            if (ModelState.IsValid)
            {
                DatabaseAccess database = new DatabaseAccess();
                User user = database.GetUserByEmailAddress(logIn.EmailAddress);
                if(user.Password == logIn.Password)
                {
                    Session["EmailAddress"] = user.EmailAddress;
                    Session["id"] = user.Id;
                    return RedirectToAction("index","Account");
                }
                return View();
            }
            return View();
         //   return View("Register", user);
        }

        public ActionResult Register()
        {
            RegisterUser model = new RegisterUser();
            return View(model);
        }

        [HttpPost]
        public ActionResult RegisterUserGo(RegisterUser user)
        {
            if (ModelState.IsValid)
            {
                DatabaseAccess database = new DatabaseAccess();
                User newUser = new User();
                newUser.FirstName = user.FirstName;
                newUser.LastName = user.LastName;
                newUser.EmailAddress = user.EmailAddress;
                newUser.Password = user.Password;
                database.AddUser(newUser);
                return RedirectToAction("Login");
            }
            return View("Register", user);
        }

        public ActionResult PasswordReset()
        {
            return View();
        }

        public ActionResult PasswordResetGo()
        {
            return View();
        }
    }
}