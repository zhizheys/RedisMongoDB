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

            return View();
        }
    }
}