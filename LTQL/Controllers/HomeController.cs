using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Về chúng tôi";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Trang liên hệ";

            return View();
        }
    }
}