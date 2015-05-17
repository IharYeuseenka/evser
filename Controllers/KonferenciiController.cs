using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class KonferenciiController : Controller
    {
        //
        // GET: /Konferencii/

        public ActionResult Index()
        {
            return PartialView();
        }
        public ActionResult Pismo()
        {
            return PartialView();
        }
        public ActionResult Pravila()
        {
            return PartialView();
        }
        public ActionResult Trebovaniya()
        {
            return PartialView();
        }
        public ActionResult Archiv()
        {
            return PartialView();
        }
        public ActionResult NetKonf()
        {
            return PartialView();
        }
        public ActionResult InfPismo()
        {
            return PartialView();
        }
        public ActionResult IntPravila()
        {
            return PartialView();
        }
        public ActionResult IntTrebovaniya()
        {
            return PartialView();
        }
        public ActionResult IntArchive()
        {
            return PartialView();
        }

    }
}
