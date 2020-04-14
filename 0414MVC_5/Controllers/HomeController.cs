using _0414MVC_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace _0414MVC_5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Test()
        {
            ViewBag.title = "jQuery";
            return View();
        }
        [HttpGet]
        public ActionResult GetForm()
        {
            Thread.Sleep(5000);
            return Json(
                new Get
                {
                    status = true,
                    statuscode = "100",
                    Data = new model
                    {
                        Title = "1",
                        Desc = "2"
                    }
                },JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult SubmitForm(model model)
        {
            return Json(
                new Get
                {
                    status = true,
                    statuscode = "510"

                });
        }
    }
}