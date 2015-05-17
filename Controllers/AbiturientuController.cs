using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class AbiturientuController : Controller
    {
        //
        // GET: /Abiturientu/

        public ActionResult Index() { return PartialView(); }
        public ActionResult Napravleniya() { return View(); }
        public ActionResult Disciplines() { return View(); }
    }
}
