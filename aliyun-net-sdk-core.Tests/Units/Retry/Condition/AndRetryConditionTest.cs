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
    public class AndRetryConditionTest
    {
        [Fact]
        public void TestAndRetryCondition()
        {
            var retryPolicyContext = new RetryPolicyContext(null, "200", 2, "ecs", "2014-05-26",
                "DescribeInstances", RetryCondition.BlankStatus);

            var retryOnApiCondition = new RetryOnApiCondition();

            var orList = new List<IAlibabaRetryCondition>
            {
                retryOnApiCondition
            };

            var orRetryCondition = new OrRetryCondition(orList);

            var maxRetryTimesCondition = new MaxRetryTimesCondition(3);

            var andList = new List<IAlibabaRetryCondition>
            {
                orRetryCondition,
                maxRetryTimesCondition
            };

            var andRetryCondition = new AndRetryCondition(andList);

            var shouldRetry = andRetryCondition.ShouldRetry(retryPolicyContext);

            Assert.Equal(RetryCondition.ShouldRetry, shouldRetry);
        }
    }
}
