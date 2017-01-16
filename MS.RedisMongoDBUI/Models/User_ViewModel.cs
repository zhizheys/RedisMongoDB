using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MS.Model;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MS.RedisMongoDBUI.Models
{
    public class User_ViewModel
    {
        [Required(ErrorMessage ="User Name can not empty")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Age can not empty")]
        public int Age { get; set; }

        [Required(ErrorMessage ="Provience can not empty")]
        public string Provience { get; set; }

        [Required(ErrorMessage = "City can not empty")]
        public string City { get; set; }
    }
}