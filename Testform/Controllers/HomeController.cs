using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Testform.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       
        public ActionResult List()
        {
            return View();
        }
        public ActionResult Detail()
        {
            int id = Convert.ToInt32( Request["id"]);
            string myname = Request["name"];
            string country = "";
            switch(id)
            {
                case 1:
                    country = "USA";
                        break;
                case 2:
                    country = "China";
                    break;
                case 3:
                    country = "Singapore";
                    break;
                default:
                    country = "None";
                    break;

            }
            return Content(myname+ " From " + country);
           // return View();
        }
    }
}