using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MS.BLL;

namespace MS.RedisMongoDBUI.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            string address = UserBLL.GetUserAddress("MorningStar");

            ViewBag.Address = address;

            HttpCookie cookieItem = new HttpCookie("Hello", "world");
            cookieItem.Expires.AddMinutes(20);

            HttpContext.Response.Cookies.Add(cookieItem);




            return View();
        }


        public ActionResult AA()
        {

            var item = HttpContext.Request.Cookies["Hello"].Value.ToString();

          return  RedirectToAction("Index");
        }
    }
}