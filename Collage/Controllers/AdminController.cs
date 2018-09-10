using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Collage.DataModel;
namespace Collage.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        VasmmEntities db;
        public AdminController()
        {
            db = new VasmmEntities();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult StafDetail()
        {
            var model = db.FACULITYDETAILs.ToList();
            return View(model);
        }
        public ActionResult AddStafDetail()
        {

            return View();
        }
        public ActionResult LatestNews()
        {

            return View();
        }

    }
}