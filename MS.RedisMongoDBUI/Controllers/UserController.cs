using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MS.RedisMongoDBUI.Models;

namespace MS.RedisMongoDBUI.Controllers
{
    public class UserController : BaseController
    {
        // GET: User
        public ActionResult ShowUser()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddUser()
        {
            ViewBag.UserInfo = new User_ViewModel();
            return View();
        }


        [HttpPost]
        public ActionResult AddUser(User_ViewModel user)
        {
            if (ModelState.IsValid)
            {
                //save data
            }
            else
            {
                return RedirectToAction("AddUser");
            }

            return RedirectToAction("ShowUser");
        }
    }
}