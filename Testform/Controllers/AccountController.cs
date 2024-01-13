using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Testform.Controllers
{
    public class AccountController : Controller

    {
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public  ActionResult Register(string name,string address,string phoneNumber,string password,string confirmPassword)
        {
            if(password==confirmPassword)
            {
                return Content("register success");
            }
            else
            {
                return Content("Password not match");
            }
        }
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ContentResult Validate(string uname, string pass)
        {
            // string user = Request["uname"];
            // string pass = Request["pass"];
            /* string user = value["uname"];
              string pass = value["pass"];*/
            //model binding primitive

            if (uname == "admin" && pass == "123")
            return Content("Welcome here");
            else
                return Content("Sorry Unavailable");
            // return View();
        }
    }
}