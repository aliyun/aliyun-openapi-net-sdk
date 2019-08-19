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
using Aliyun.Acs.Core.Retry.Util;

namespace Aliyun.Acs.Core.Retry.Condition
{
    public class RetryOnExceptionCondition : IAlibabaRetryCondition
    {
        private const string SdkHttpError = "SDK.HttpError";
        private const string NormalErrorSectionName = "RetryableNormalErrors";
        private const string ThrottlingErrorSectionName = "RetryableThrottlingErrors";

        public RetryCondition ShouldRetry(RetryPolicyContext retryPolicyContext)
        {
            var exception = retryPolicyContext.Exception;

            if (exception == null)
            {
                return RetryCondition.NoRetry;
            }

            if (exception.ErrorCode != null &&
                exception.ErrorCode.Equals(SdkHttpError))
            {
                return RetryCondition.ShouldRetry;
            }

            if (exception is ServerException)
            {
                var serverException = (ServerException) exception;
                var errorCode = serverException.ErrorCode;

                var product = retryPolicyContext.Product;
                var version = retryPolicyContext.Version;

                var normalErrorList = RetryConfig.GetRetryableApiList(product, version, NormalErrorSectionName);
                if (normalErrorList != null && normalErrorList.Contains(errorCode))
                {
                    return RetryCondition.ShouldRetry;
                }

                var throttlingErrorList =
                    RetryConfig.GetRetryableApiList(product, version, ThrottlingErrorSectionName);

                if (throttlingErrorList == null)
                {
                    return RetryCondition.NoRetry;
                }

                var shouldThrottlingFromConfig = throttlingErrorList.Contains(errorCode);

                var localShouldRetry = shouldThrottlingFromConfig ? RetryCondition.ShouldRetry : RetryCondition.NoRetry;
                return localShouldRetry | RetryCondition.ShouldRetryWithThrottlingBackoff;
            }

            return RetryCondition.NoRetry;
        }
    }
}
