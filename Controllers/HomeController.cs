using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return PartialView();
        }
        public ActionResult Abiturient()
        {
            return View();
        }
        public ActionResult Student()
        {
            return View();
        }
        public ActionResult Konferencii()
        {
            return View();
        }
        public ActionResult Aspirant()
        {
            return View();
        }
        public ActionResult History()
        {
            return PartialView();
        }
        public ActionResult Sostav()
        {
            return PartialView();
        }
        public ActionResult Nauka()
        {
            return PartialView();
        }
        public ActionResult Works()
        {
            return PartialView();
        }
        public ActionResult Art()
        {
            return PartialView();
        }
        public ActionResult FinishHim()
        {
            return PartialView();
        }
        public ActionResult Contacts()
        {
            return PartialView();
        }
    }
}
