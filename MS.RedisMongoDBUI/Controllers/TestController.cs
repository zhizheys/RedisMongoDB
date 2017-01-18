using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MS.BLL.User;
using MS.Common.LogHelper;

namespace MS.RedisMongoDBUI.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            LogHelper.CreateInstance().Info("任务发生的当前系统时间:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            LogHelper.CreateInstance().Error("任务发生的当前系统时间:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            string aa = Newtonsoft.Json.JsonConvert.SerializeObject(UserBLL.GetAllUserInfo());

            //ViewBag.AllUser = UserBLL.GetAllUserInfo();


            ViewBag.ListJsonInfo = aa;


            return View();
        }
    }
}