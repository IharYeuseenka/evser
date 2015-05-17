using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class AspirantsController : Controller
    {
        //
        // GET: /Aspirants/

        public ActionResult Index()
        {
            return PartialView();
        }
        public ActionResult Journales()
        {
            return PartialView();
        }
        public ActionResult Passport()
        {
            return PartialView();
        }
    }
}
