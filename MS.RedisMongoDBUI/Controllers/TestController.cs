using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MS.BLL.User;

namespace MS.RedisMongoDBUI.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            string aa = Newtonsoft.Json.JsonConvert.SerializeObject(UserBLL.GetAllUserInfo());

            //ViewBag.AllUser = UserBLL.GetAllUserInfo();


            ViewBag.ListJsonInfo = aa;


            return View();
        }
    }
}