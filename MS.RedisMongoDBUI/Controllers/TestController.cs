using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MS.BLL;
using MS.Common.SessionHelper;

namespace MS.RedisMongoDBUI.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            string address = UserBLL.GetUserAddress("MorningStar");

            ViewBag.Address = address;

            ViewBag.IsLogin = "NO";

            SessionHelper Session = new SessionHelper();
            if (Session["LoginUser"] != null)
            {
                ViewBag.IsLogin = "YES";
            }
            else
            {
                ViewBag.IsLogin = "NO";
            }


            return View();
        }


        public ActionResult AA()
        {

           // var item = HttpContext.Request.Cookies["Hello"].Value.ToString();

          return  RedirectToAction("Index");
        }



        public ActionResult Register()
        {

            SessionHelper Session = new SessionHelper();
            Session["LoginUser"] = "JLiu";

            return RedirectToAction("Index");

        }
    }
}