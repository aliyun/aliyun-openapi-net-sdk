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
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.industry_brain.Model.V20190629;

namespace Aliyun.Acs.industry_brain.Transform.V20190629
{
    public class GetAlgorithmHistoryResultResponseUnmarshaller
    {
        public static GetAlgorithmHistoryResultResponse Unmarshall(UnmarshallerContext context)
        {
			GetAlgorithmHistoryResultResponse getAlgorithmHistoryResultResponse = new GetAlgorithmHistoryResultResponse();

			getAlgorithmHistoryResultResponse.HttpResponse = context.HttpResponse;
			getAlgorithmHistoryResultResponse.RequestId = context.StringValue("GetAlgorithmHistoryResult.RequestId");
			getAlgorithmHistoryResultResponse.Code = context.StringValue("GetAlgorithmHistoryResult.Code");
			getAlgorithmHistoryResultResponse.Message = context.StringValue("GetAlgorithmHistoryResult.Message");
			getAlgorithmHistoryResultResponse.TraceId = context.StringValue("GetAlgorithmHistoryResult.TraceId");

			List<GetAlgorithmHistoryResultResponse.GetAlgorithmHistoryResult_Region> getAlgorithmHistoryResultResponse_data = new List<GetAlgorithmHistoryResultResponse.GetAlgorithmHistoryResult_Region>();
			for (int i = 0; i < context.Length("GetAlgorithmHistoryResult.Data.Length"); i++) {
				GetAlgorithmHistoryResultResponse.GetAlgorithmHistoryResult_Region region = new GetAlgorithmHistoryResultResponse.GetAlgorithmHistoryResult_Region();
				region.Output = context.StringValue("GetAlgorithmHistoryResult.Data["+ i +"].Output");
				region.Input = context.StringValue("GetAlgorithmHistoryResult.Data["+ i +"].Input");
				region.InvokeTime = context.StringValue("GetAlgorithmHistoryResult.Data["+ i +"].InvokeTime");

				getAlgorithmHistoryResultResponse_data.Add(region);
			}
			getAlgorithmHistoryResultResponse.Data = getAlgorithmHistoryResultResponse_data;
        
			return getAlgorithmHistoryResultResponse;
        }
    }
}
