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
using Aliyun.Acs.Core.Retry.Condition;

namespace Aliyun.Acs.Core.Retry
{
    public class RetryPolicyContext
    {
        public RetryPolicyContext(ClientException exception, string httpStatusCode, int retryAttemptTimes,
            string product, string version, string apiName, RetryCondition retryable)
        {
            Exception = exception;
            HttpStatusCode = httpStatusCode;
            RetryAttemptTimes = retryAttemptTimes;
            Product = product;
            Version = version;
            ApiName = apiName;
            Retryable = retryable;
        }

        public ClientException Exception { get; private set; }
        public string HttpStatusCode { get; private set; }

        public int RetryAttemptTimes { get; set; }

        public string Product { get; private set; }
        public string Version { get; private set; }
        public string ApiName { get; private set; }

        private RetryCondition retryable = RetryCondition.BlankStatus;

        public RetryCondition Retryable
        {
            get { return retryable; }
            set { retryable = value; }
        }
    }
}
