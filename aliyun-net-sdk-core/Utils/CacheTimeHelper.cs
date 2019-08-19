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
using System.Collections.Concurrent;

namespace Aliyun.Acs.Core.Utils
{
    public class CacheTimeHelper
    {
        private const int ENDPOINT_CACHE_TIME = 3600; //Seconds

        private static readonly ConcurrentDictionary<string, DateTime> lastClearTimePerProduct =
            new ConcurrentDictionary<string, DateTime>();

        public static bool CheckCacheIsExpire(string product, string regionId)
        {
            DateTime lastClearTime;
            var key = product + "_" + regionId;

            if (lastClearTimePerProduct.ContainsKey(key))
            {
                lastClearTime = lastClearTimePerProduct[key];
            }
            else
            {
                lastClearTime = DateTime.UtcNow;
                lastClearTimePerProduct.TryAdd(key, lastClearTime);
            }

            var ts = DateTime.UtcNow - lastClearTime;

            if (ENDPOINT_CACHE_TIME < ts.TotalSeconds)
            {
                return true;
            }

            return false;
        }

        public static void AddLastClearTimePerProduct(string product, string regionId, DateTime lastClearTime)
        {
            var key = product + "_" + regionId;

            if (lastClearTimePerProduct.ContainsKey(key))
            {
                DateTime dt;
                lastClearTimePerProduct.TryRemove(key, out dt);
            }

            lastClearTimePerProduct.TryAdd(key, lastClearTime);
        }
    }
}
