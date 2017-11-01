using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aliyun.Acs.Core.Profile;

namespace Aliyun.Acs.Core.Utils
{
    public class CacheTimeHelper
    {
        private static Dictionary<String, DateTime> lastClearTimePerProduct = new Dictionary<string, DateTime>();
        private const int ENDPOINT_CACHE_TIME = 3600; //Seconds

        public static bool CheckCacheIsExpire(String product, String regionId)
        {
            DateTime lastClearTime;
            String key = product + "_" + regionId;

            if (lastClearTimePerProduct.ContainsKey(key))
            {
                lastClearTime = lastClearTimePerProduct[key];
            }
            else
            {
                lastClearTime = DateTime.Now;
                lastClearTimePerProduct.Add(key, lastClearTime);
            }
            
            TimeSpan ts = DateTime.Now - lastClearTime;

            if (ENDPOINT_CACHE_TIME < ts.TotalSeconds)
            {
                return true;
            }

            return false;
        }

        public static void AddLastClearTimePerProduct(String product, String regionId, DateTime lastClearTime)
        {
            String key = product + "_" + regionId;

            if (lastClearTimePerProduct.ContainsKey(key))
            {
                lastClearTimePerProduct.Remove(key);
            }
            lastClearTimePerProduct.Add(key, lastClearTime);
        }
    }
}
