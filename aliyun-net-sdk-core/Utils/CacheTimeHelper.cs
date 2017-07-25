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

        public static bool CheckCacheIsExpire(String product)
        {
            DateTime lastClearTime;

            if (lastClearTimePerProduct.ContainsKey(product))
            {
                lastClearTime = lastClearTimePerProduct[product];
            }
            else
            {
                lastClearTime = DateTime.Now;
                lastClearTimePerProduct.Add(product, lastClearTime);
            }
            
            TimeSpan ts = DateTime.Now - lastClearTime;

            if (ENDPOINT_CACHE_TIME < ts.TotalSeconds)
            {
                lastClearTime = DateTime.Now;
                if (lastClearTimePerProduct.ContainsKey(product))
                {
                    lastClearTimePerProduct.Remove(product);
                }
                lastClearTimePerProduct.Add(product, lastClearTime);
                return true;
            }

            return false;
        }

        public static void AddLastClearTimePerProduct(String product, DateTime lastClearTime)
        {
            if (lastClearTimePerProduct.ContainsKey(product))
            {
                lastClearTimePerProduct.Remove(product);
            }
            lastClearTimePerProduct.Add(product, lastClearTime);
        }
    }
}
