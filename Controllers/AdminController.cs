using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcApplication1.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Panel");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            if (model.Username == "admin" && model.Password == "admin")//TODO:костыль
            {
                FormsAuthentication.SetAuthCookie(model.Username, false);
                return RedirectToAction("Panel");
            }
            ModelState.AddModelError("","Ты не с нашего раёна");
            return View(model);
        }

        [Authorize]
        public ActionResult Panel()
        {
            var model = new NewsViewModel { NewsList = new Entities().Newses.Where(t =>!(bool)t.IsDeleted ) };
            return View(model);
        }
        public ActionResult AddNews()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNews(Newse model)
        {
            if (model != null)
            {
                model.IsDeleted = false;
                model.Date = DateTime.Now;
                var context = new Entities();
                context.Newses.Add(model);
                context.SaveChanges();
                return RedirectToAction("Panel");
            }
            return View(model);
        }
        

        public ActionResult DeleteNews(int id)
        {
            var context = new Entities();
            var model = context.Newses.FirstOrDefault(t => t.ID == id);
            if(model != null)
                model.IsDeleted = true;
            context.SaveChanges();
            return RedirectToAction("Panel");
        }
    }
}
