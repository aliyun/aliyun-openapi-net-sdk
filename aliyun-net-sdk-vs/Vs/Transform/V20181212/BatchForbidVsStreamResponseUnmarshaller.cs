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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class BatchForbidVsStreamResponseUnmarshaller
    {
        public static BatchForbidVsStreamResponse Unmarshall(UnmarshallerContext context)
        {
			BatchForbidVsStreamResponse batchForbidVsStreamResponse = new BatchForbidVsStreamResponse();

			batchForbidVsStreamResponse.HttpResponse = context.HttpResponse;
			batchForbidVsStreamResponse.RequestId = context.StringValue("BatchForbidVsStream.RequestId");

			List<BatchForbidVsStreamResponse.BatchForbidVsStream_ForbidResultInfo> batchForbidVsStreamResponse_forbidResult = new List<BatchForbidVsStreamResponse.BatchForbidVsStream_ForbidResultInfo>();
			for (int i = 0; i < context.Length("BatchForbidVsStream.ForbidResult.Length"); i++) {
				BatchForbidVsStreamResponse.BatchForbidVsStream_ForbidResultInfo forbidResultInfo = new BatchForbidVsStreamResponse.BatchForbidVsStream_ForbidResultInfo();
				forbidResultInfo.Result = context.StringValue("BatchForbidVsStream.ForbidResult["+ i +"].Result");
				forbidResultInfo.Detail = context.StringValue("BatchForbidVsStream.ForbidResult["+ i +"].Detail");
				forbidResultInfo.Count = context.IntegerValue("BatchForbidVsStream.ForbidResult["+ i +"].Count");

				List<string> forbidResultInfo_channels = new List<string>();
				for (int j = 0; j < context.Length("BatchForbidVsStream.ForbidResult["+ i +"].Channels.Length"); j++) {
					forbidResultInfo_channels.Add(context.StringValue("BatchForbidVsStream.ForbidResult["+ i +"].Channels["+ j +"]"));
				}
				forbidResultInfo.Channels = forbidResultInfo_channels;

				batchForbidVsStreamResponse_forbidResult.Add(forbidResultInfo);
			}
			batchForbidVsStreamResponse.ForbidResult = batchForbidVsStreamResponse_forbidResult;
        
			return batchForbidVsStreamResponse;
        }
    }
}
