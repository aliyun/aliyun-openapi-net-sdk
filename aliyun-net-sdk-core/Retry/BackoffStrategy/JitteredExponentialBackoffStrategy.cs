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

namespace Aliyun.Acs.Core.Retry.BackoffStrategy
{
    public class JitteredExponentialBackoffStrategy : ExponentialBackoffStrategy
    {
        private static readonly Random GenerateRandomNum = new Random();

        public JitteredExponentialBackoffStrategy(int baseDelayInMilliseconds, int maxDelayInMilliseconds) : base(
            baseDelayInMilliseconds, maxDelayInMilliseconds)
        {
        }

        public new int GetDelayTimeBeforeNextRetry(RetryPolicyContext retryPolicyContext)
        {
            var delay = base.GetDelayTimeBeforeNextRetry(retryPolicyContext);

            lock (GenerateRandomNum)
            {
                return delay / 2 + GenerateRandomNum.Next(delay / 2);
            }
        }
    }
}
