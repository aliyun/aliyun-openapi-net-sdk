using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aliyun.Acs.Core.Utils
{
    public static class CacheTime
    {
        private static DateTime lastClearTime = DateTime.Now;
        private static readonly object syncRoot = new object();

        public static bool CheckCacheIsExpire()
        {

            lock (syncRoot)
            {
                TimeSpan ts = DateTime.Now - lastClearTime;
                if (ts.TotalSeconds > 600)
                {
                    lastClearTime = DateTime.Now;
                    return true;
                }

                return false;
            }
        }
    }
}
