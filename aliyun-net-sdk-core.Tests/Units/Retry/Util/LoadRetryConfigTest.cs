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

using Aliyun.Acs.Core.Retry.Util;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Retry.Util
{
    public class LoadRetryConfigTest
    {
        private string product = "ecs";
        private string version = "2014-05-26";
        private string sectionName = "RetryableAPIs";

        [Fact]
        public void TestGetRetryableList()
        {
            var list = RetryConfig.GetRetryableApiList(product, version, sectionName);

            Assert.True(79 == list.Count);

            sectionName = "RetryableNormalErrors";
            list = RetryConfig.GetRetryableApiList(product, version, sectionName);

            Assert.True(3 == list.Count);
        }

        [Fact]
        public void TestInvalidJsonSection()
        {
            product = "fakeProduct";

            var list = RetryConfig.GetRetryableApiList(product, version, sectionName);

            Assert.Null(list);

            product = "ecs";
            version = "2014-05-27";

            list = RetryConfig.GetRetryableApiList(product, version, sectionName);
            Assert.Null(list);

            sectionName = "RetryableAPIsTest";
            list = RetryConfig.GetRetryableApiList(product, version, sectionName);
            Assert.Null(list);
        }
    }
}
