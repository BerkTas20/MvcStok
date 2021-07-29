using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcStok.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Senin hakkında sayfan";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Senin iletişim sayfan";

            return View();
        }

       
    }
}