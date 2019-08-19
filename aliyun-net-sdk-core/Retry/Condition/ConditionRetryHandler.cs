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

namespace Aliyun.Acs.Core.Retry.Condition
{
    public class ConditionRetryHandler : IAlibabaRetryCondition
    {
        private readonly MaxRetryTimesCondition maxRetryTimesCondition;
        private readonly RetryOnApiCondition retryOnApiCondition;
        private readonly RetryOnApiWithClientTokenCondition retryOnApiWithClientTokenCondition;
        private readonly RetryOnExceptionCondition retryOnExceptionCondition;
        private readonly RetryOnHttpStatusCondition retryOnHttpStatusCondition;

        public ConditionRetryHandler(int maxRetries = 3, List<string> retryHttpCodeList = null)
        {
            retryOnApiCondition = new RetryOnApiCondition();
            retryOnApiWithClientTokenCondition = new RetryOnApiWithClientTokenCondition();
            maxRetryTimesCondition = new MaxRetryTimesCondition(maxRetries);
            retryOnExceptionCondition = new RetryOnExceptionCondition();
            retryOnHttpStatusCondition = new RetryOnHttpStatusCondition(retryHttpCodeList);
        }

        public RetryCondition ShouldRetry(RetryPolicyContext retryPolicyContext)
        {
            var orRetryConditionList1 = new List<IAlibabaRetryCondition>
            {
                retryOnApiCondition,
                retryOnApiWithClientTokenCondition
            };
            var orRetryConditionList2 = new List<IAlibabaRetryCondition>
            {
                retryOnExceptionCondition,
                retryOnHttpStatusCondition
            };
            var andConditionList = new List<IAlibabaRetryCondition>
            {
                maxRetryTimesCondition
            };

            var orRetryCondition1 = new OrRetryCondition(orRetryConditionList1);
            var orRetryCondition2 = new OrRetryCondition(orRetryConditionList2);
            var andCondition = new AndRetryCondition(andConditionList);

            var innerConditionList = new List<IAlibabaRetryCondition>
            {
                orRetryCondition1,
                orRetryCondition2,
                andCondition
            };

            var innerCondition = new AndRetryCondition(innerConditionList);

            return innerCondition.ShouldRetry(retryPolicyContext);
        }
    }
}
