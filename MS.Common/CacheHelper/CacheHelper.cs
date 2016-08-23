using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Common.CacheHelper
{
    public class CacheHelper : ICacheHelper
    {

        RedisCacheHelper cacheHelper = new RedisCacheHelper();

        public  Object Get<T>(string key)
        {
            return cacheHelper.Get<T>(key);
        }

        public  void Insert(string key, object value)
        {
            cacheHelper.Insert(key, value);
        }

        public  bool Remove(string key)
        {
            return cacheHelper.Remove(key);
        }

    }
}
