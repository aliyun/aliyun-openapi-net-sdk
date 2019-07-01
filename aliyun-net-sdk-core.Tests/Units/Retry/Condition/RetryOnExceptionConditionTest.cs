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

using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Retry;
using Aliyun.Acs.Core.Retry.Condition;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Retry.Condition
{
    public class RetryOnExceptionConditionTest
    {
        [Fact]
        public void TestRetryOnException()
        {
            var product = "ecs";
            var version = "2014-05-26";
            var apiName = "DescribeInstances";
            ClientException exception = null;

            var retryPolicyContext = new RetryPolicyContext(exception, "200", 1, product,
                version, apiName, RetryCondition.BlankStatus);
            var retryOnApiCondition = new RetryOnExceptionCondition();
            var shouldRetry = retryOnApiCondition.ShouldRetry(retryPolicyContext);

            Assert.Equal(RetryCondition.NoRetry, shouldRetry);

            exception = new ClientException("SDK.HttpError", "TestMessage");
            retryPolicyContext = new RetryPolicyContext(exception, "200", 1, product,
                version, apiName, RetryCondition.BlankStatus);
            shouldRetry = retryOnApiCondition.ShouldRetry(retryPolicyContext);

            Assert.Equal(RetryCondition.ShouldRetry, shouldRetry);

            var serverException = new ServerException("InternalError", "TestMessage");

            retryPolicyContext = new RetryPolicyContext(serverException, "200", 1, product,
                version, apiName, RetryCondition.BlankStatus);
            shouldRetry = retryOnApiCondition.ShouldRetry(retryPolicyContext);

            Assert.Equal(RetryCondition.ShouldRetry, shouldRetry);

            product = "vpc";
            serverException = new ServerException("Throttling", "TestMessage");
            retryPolicyContext = new RetryPolicyContext(serverException, "200", 1, product,
                version, apiName, RetryCondition.BlankStatus);
            shouldRetry = retryOnApiCondition.ShouldRetry(retryPolicyContext);

            Assert.Equal(RetryCondition.NoRetry, shouldRetry);

            product = "ecs";
            serverException = new ServerException("ThrottlingTest", "TestMessage");
            retryPolicyContext = new RetryPolicyContext(serverException, "200", 1, product,
                version, apiName, RetryCondition.BlankStatus);
            shouldRetry = retryOnApiCondition.ShouldRetry(retryPolicyContext);

            Assert.Equal(RetryCondition.NoRetry | RetryCondition.ShouldRetryWithThrottlingBackoff, shouldRetry);

            serverException = new ServerException("Throttling", "TestMessage");
            retryPolicyContext = new RetryPolicyContext(serverException, "200", 1, product,
                version, apiName, RetryCondition.BlankStatus);
            shouldRetry = retryOnApiCondition.ShouldRetry(retryPolicyContext);

            Assert.Equal(RetryCondition.ShouldRetry | RetryCondition.ShouldRetryWithThrottlingBackoff, shouldRetry);

            var clientException = new ClientException("TestCode", "TestNullMessage");
            retryPolicyContext = new RetryPolicyContext(clientException, "200", 1, product,
                version, apiName, RetryCondition.BlankStatus);
            shouldRetry = retryOnApiCondition.ShouldRetry(retryPolicyContext);

            Assert.Equal(RetryCondition.NoRetry, shouldRetry);
        }
    }
}
