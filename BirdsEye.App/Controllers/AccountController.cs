using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BirdsEye.App.Models;
using BirdsEye.Domain.Models;
using BirdsEye.Data;

namespace BirdsEye.App.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            if(null == Session["id"])
            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }
        
        public ActionResult MyProfile()
        {
            if (null == Session["id"])
            {
                return RedirectToAction("Login", "Home");
            }
            MyProfile myProfile = new MyProfile();
            DatabaseAccess databaseAccess = new DatabaseAccess();
            User user = databaseAccess.GetUserById((int)Session["id"]);
            myProfile.UserName = user.UserName;
            myProfile.FirstName = user.FirstName;
            myProfile.LastName = user.LastName;
            myProfile.EmailAddress = user.EmailAddress;
            return View(myProfile);
        }

    }
}