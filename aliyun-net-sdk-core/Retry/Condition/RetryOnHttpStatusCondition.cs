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
    public class RetryOnHttpStatusCondition : IAlibabaRetryCondition
    {
        private readonly List<string> defaultRetryHttpStatusCodeList;

        public RetryOnHttpStatusCondition(List<string> retryHttpCodeList)
        {
            defaultRetryHttpStatusCodeList = retryHttpCodeList ?? new List<string> {"500", "502", "503", "504"};
        }

        public RetryCondition ShouldRetry(RetryPolicyContext retryPolicyContext)
        {
            return defaultRetryHttpStatusCodeList.Contains(retryPolicyContext.HttpStatusCode)
                ? RetryCondition.ShouldRetry
                : RetryCondition.NoRetry;
        }
    }
}
