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

using Aliyun.Acs.Core.Utils;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Utils
{
    public class CacheTimeHelperTest
    {
        [Fact]
        public void AddLastClearTimePerProduct()
        {
            var lastClearTime = DateTime.UtcNow.AddDays(-1);
            CacheTimeHelper.AddLastClearTimePerProduct("ecs", "ch-hangzhou", lastClearTime);
            Assert.True(CacheTimeHelper.CheckCacheIsExpire("ecs", "ch-hangzhou"));

            lastClearTime = DateTime.UtcNow.AddDays(1);
            CacheTimeHelper.AddLastClearTimePerProduct("ecs", "ch-hangzhou", lastClearTime);
            Assert.False(CacheTimeHelper.CheckCacheIsExpire("ecs", "ch-hangzhou"));
        }

        [Fact]
        public void CheckCacheIsExpire()
        {
            // When Not Exist
            Assert.False(CacheTimeHelper.CheckCacheIsExpire("someNotExist", "ch-hangzhou"));

            // When Exist
            var lastClearTime = DateTime.UtcNow.AddDays(-1);
            CacheTimeHelper.AddLastClearTimePerProduct("ecs", "ch-hangzhou", lastClearTime);
            Assert.True(CacheTimeHelper.CheckCacheIsExpire("ecs", "ch-hangzhou"));
        }
    }
}
