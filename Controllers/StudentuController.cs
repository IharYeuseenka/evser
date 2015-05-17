using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class StudentuController : Controller
    {
        //
        // GET: /Studentu/

        public ActionResult Index()
        {
            return PartialView();
        }
        public ActionResult Trud()
        {
            return PartialView();
        }
        public ActionResult Session()
        {
            return PartialView();
        }
        public ActionResult Raspisanie()
        {
            return PartialView();
        }
        public ActionResult Pametka()
        {
            return PartialView();
        }
        public ActionResult Graffiki()
        {
            return PartialView();
        }
    }
}
