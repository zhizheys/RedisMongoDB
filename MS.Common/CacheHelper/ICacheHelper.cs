using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Common.CacheHelper
{
   public interface ICacheHelper
    {
        Object Get<T>(string key);
        void Insert(string key, object value);
        //void Insert(string key, object value,int timeToLiveMinute);
        bool Remove(string key);
        //void Clear();
    }
}
