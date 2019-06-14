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

using Aliyun.Acs.Core.Retry;
using Aliyun.Acs.Core.Retry.Condition;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Retry.Condition
{
    public class RetryOnApiConditionTest
    {
        [Fact]
        public void TestRetryOnApiCondition()
        {
            var product = "ecs";
            var version = "2014-05-26";
            var apiName = "DescribeInstances";

            var retryPolicyContext = new RetryPolicyContext(null, "200", 1, product,
                version, apiName, RetryCondition.BlankStatus);
            var retryOnApiCondition = new RetryOnApiCondition();
            var shouldRetry = retryOnApiCondition.ShouldRetry(retryPolicyContext);

            Assert.Equal(RetryCondition.ShouldRetry, shouldRetry);

            apiName = "DescribeTestInstance";
            retryPolicyContext = new RetryPolicyContext(null, "200", 1, product,
                version, apiName, RetryCondition.BlankStatus);
            shouldRetry = retryOnApiCondition.ShouldRetry(retryPolicyContext);

            Assert.Equal(RetryCondition.NoRetry, shouldRetry);

            product = "vpc";
            retryPolicyContext = new RetryPolicyContext(null, "200", 1, product,
                version, "DescribeInstances", RetryCondition.BlankStatus);
            shouldRetry = retryOnApiCondition.ShouldRetry(retryPolicyContext);

            Assert.Equal(RetryCondition.NoRetry, shouldRetry);
        }
    }
}
