
using StackExchange.Redis;
using System.Configuration;
using System.Reflection;
using System;


namespace MS.Common.CacheHelper
{
    public class RedisCacheHelper
    {

        private static ConnectionMultiplexer _redis;
        private static object _locker = new object();
        private static string connectionString = ConfigurationManager.ConnectionStrings["RedisStr"].ConnectionString;


        public ConnectionMultiplexer Instance
        {
            get
            {
                if (_redis == null)
                {
                    lock (_locker)
                    {
                        if (_redis != null)
                        {
                            return _redis;
                        }
                        else {
                            _redis = GetManager();
                            return _redis;
                        }

                    }
                }

                return _redis;
            }
        }

        private ConnectionMultiplexer GetManager()
        {
            return ConnectionMultiplexer.Connect(connectionString);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IDatabase GetDatabase()
        {
            return Instance.GetDatabase();
        }

        public object Get<T>(string key)
        {
            string obj = GetDatabase().StringGet(key);

            if (!string.IsNullOrWhiteSpace(obj))
            {
                return JsonHelper.ConvertStringToObject<T>(obj);
            }
            else
            {
                return null;
            }
           
            
        }

        public void Insert(string key, object value)
        {
            GetDatabase().StringSet(key, JsonHelper.ConvertObjectToString(value));
        }

        public bool Remove(string key)
        {
            return GetDatabase().KeyDelete(key);
        }

    }
}
