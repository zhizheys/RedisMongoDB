using System;
using System.Web;
using MS.Common.CacheHelper;

namespace MS.Common.SessionHelper
{
  public  class SessionHelper
    {
        private string sessionKey = string.Empty;
        private const string SESSIONID = "SESSIONIDMS";

        RedisCacheHelper redisCache = new RedisCacheHelper();

        public SessionHelper()
        {
            sessionKey = System.Web.HttpContext.Current.Request.Cookies[SESSIONID] ==null?string.Empty: System.Web.HttpContext.Current.Request.Cookies[SESSIONID].Value;

            if (String.IsNullOrWhiteSpace(sessionKey))
            {
                sessionKey = System.Guid.NewGuid().ToString("B");
                HttpCookie cookie = new HttpCookie(SESSIONID, sessionKey);
                System.Web.HttpContext.Current.Response.Cookies.Add(cookie);
            }
            
        }

        public object this[string key]
        {
            get {
                return redisCache.Get<object>(sessionKey + "_" + key);
            }
            set {
                redisCache.Insert(sessionKey + "_" + key, value);
            }
        }

    }
}
