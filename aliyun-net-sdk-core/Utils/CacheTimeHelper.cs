/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

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
