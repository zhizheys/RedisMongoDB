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
            LogHelper.CreateInstance().Debug("debug任务发生的当前系统时间:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            LogHelper.CreateInstance().Info("Info任务发生的当前系统时间:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            LogHelper.CreateInstance().Warn("war任务发生的当前系统时间:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            LogHelper.CreateInstance().Error("Error任务发生的当前系统时间:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            LogHelper.CreateInstance().Fatal("fata任务发生的当前系统时间:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            string aa = Newtonsoft.Json.JsonConvert.SerializeObject(UserBLL.GetAllUserInfo());

            //ViewBag.AllUser = UserBLL.GetAllUserInfo();


            ViewBag.ListJsonInfo = aa;


            return View();
        }
    }
}