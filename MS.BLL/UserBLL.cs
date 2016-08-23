using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.Common.CacheHelper;

namespace MS.BLL
{
    public class UserBLL
    {
        public static string GetUserAddress(string userName)
        {
            string address = new CacheHelper().Get<string>(userName) as string;

            if (string.IsNullOrWhiteSpace(address))
            {
                address = string.Format("SZ_{0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                new CacheHelper().Insert(userName, address);
            }

            return address;
        }
    }
}
