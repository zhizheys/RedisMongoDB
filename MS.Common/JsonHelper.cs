using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MS.Common
{
    public class JsonHelper
    {
        public static string ConvertObjectToString(object obj)
        {
            try
            {
                return JsonConvert.SerializeObject(obj);
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public static string ConvertObjectToString(object obj, string dateFormat)
        {
            IsoDateTimeConverter timeFormat = new IsoDateTimeConverter();
            timeFormat.DateTimeFormat = dateFormat;

            try
            {
                return JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented, timeFormat);
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public static T ConvertStringToObject<T>(string strJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(strJson);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
