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

using System.Collections.Generic;

using Aliyun.Acs.Core.Retry;
using Aliyun.Acs.Core.Retry.Condition;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Retry.Condition
{
    public class RetryOnHttpStatusConditionTest
    {
        [Fact]
        public void TestRetryOnHttpStatusCondition()
        {
            var retryOnHttpStatusCondition = new RetryOnHttpStatusCondition(null);
            var retryPolicyContext = new RetryPolicyContext(null, "504", 2, "ecs", "2019-06-01",
                "DescribeInstances", RetryCondition.BlankStatus);
            var shouldRetry = retryOnHttpStatusCondition.ShouldRetry(retryPolicyContext);

            Assert.Equal(RetryCondition.ShouldRetry, shouldRetry);

            var customStatusCodeList = new List<string> {"404", "500"};
            retryOnHttpStatusCondition = new RetryOnHttpStatusCondition(customStatusCodeList);

            shouldRetry = retryOnHttpStatusCondition.ShouldRetry(retryPolicyContext);

            Assert.Equal(RetryCondition.NoRetry, shouldRetry);
        }
    }
}
