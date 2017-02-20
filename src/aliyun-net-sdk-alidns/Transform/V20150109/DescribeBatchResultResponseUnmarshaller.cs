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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Alidns.Model.V20150109;
using System.Collections.Generic;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeBatchResultResponseUnmarshaller
    {
        public static DescribeBatchResultResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeBatchResultResponse describeBatchResultResponse = new DescribeBatchResultResponse
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeBatchResult.RequestId"),
                TraceId = context.StringValue("DescribeBatchResult.TraceId"),
                Status = context.LongValue("DescribeBatchResult.Status"),
                BatchCount = context.LongValue("DescribeBatchResult.BatchCount"),
                SuccessNumber = context.LongValue("DescribeBatchResult.SuccessNumber")
            };


            List<DescribeBatchResultResponse.FailResult> failResults = new List<DescribeBatchResultResponse.FailResult>();
			for (int i = 0; i < context.Length("DescribeBatchResult.FailResults.Length"); i++) {
			    DescribeBatchResultResponse.FailResult failResult = new DescribeBatchResultResponse.FailResult
			    {
			        BatchIndex = context.StringValue($"DescribeBatchResult.FailResults[{i}].BatchIndex"),
			        ErrorCode = context.StringValue($"DescribeBatchResult.FailResults[{i}].ErrorCode")
			    };

			    failResults.Add(failResult);
			}
			describeBatchResultResponse.FailResults = failResults;
        
			return describeBatchResultResponse;
        }
    }
}