using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.portal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Areas/basic/Views/Home/Index.cshtml");
        }

        public ActionResult About()
        {
            return View("~/Areas/basic/Views/Home/About.cshtml");
        }

        public ActionResult Contact()
        {
            return View("~/Areas/basic/Views/Home/Contact.cshtml");
        }
    
    }
}