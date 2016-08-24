using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.Common.CacheHelper;

namespace MS.Common.SessionHelper
{
    public  class RedisSessionHelper
    {
 
        RedisCacheHelper cacheHelper = new RedisCacheHelper();

        //public  string this[string index]
        //{
        //    get
        //    {
        //        return cacheHelper.Get<string>
        //    }
        //    set { name.Add(index, value); }
        //}

    }
}
