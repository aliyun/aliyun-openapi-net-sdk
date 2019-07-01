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

using Aliyun.Acs.Core.Retry.BackoffStrategy;
using Aliyun.Acs.Core.Retry.Condition;

namespace Aliyun.Acs.Core.Retry
{
    public class RetryPolicy : IAlibabaRetryCondition, IAlibabaBackoffStrategy
    {
        private readonly IAlibabaBackoffStrategy backoffStrategy;
        private readonly IAlibabaRetryCondition retryCondition;

        // Stands for no retry condition and no delay strategy.
        public RetryPolicy()
        {
            retryCondition = new NoRetryCondition();
            backoffStrategy = new NoDelayStrategy();
        }

        public RetryPolicy(int maxRetries, bool preDefined)
        {
            retryCondition = preDefined ? new ConditionRetryHandler() : new ConditionRetryHandler(maxRetries);
            backoffStrategy = new BackoffStrategyHandler();
        }

        public RetryPolicy(IAlibabaRetryCondition retryCondition, IAlibabaBackoffStrategy backoffStrategy)
        {
            this.retryCondition = retryCondition;
            this.backoffStrategy = backoffStrategy;
        }

        public int GetDelayTimeBeforeNextRetry(RetryPolicyContext retryPolicyContext)
        {
            return backoffStrategy.GetDelayTimeBeforeNextRetry(retryPolicyContext);
        }

        public RetryCondition ShouldRetry(RetryPolicyContext retryPolicyContext)
        {
            return retryCondition.ShouldRetry(retryPolicyContext);
        }
    }
}
