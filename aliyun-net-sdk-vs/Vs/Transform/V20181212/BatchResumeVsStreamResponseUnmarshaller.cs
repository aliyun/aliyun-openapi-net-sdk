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
    public class BatchResumeVsStreamResponseUnmarshaller
    {
        public static BatchResumeVsStreamResponse Unmarshall(UnmarshallerContext context)
        {
			BatchResumeVsStreamResponse batchResumeVsStreamResponse = new BatchResumeVsStreamResponse();

			batchResumeVsStreamResponse.HttpResponse = context.HttpResponse;
			batchResumeVsStreamResponse.RequestId = context.StringValue("BatchResumeVsStream.RequestId");

			List<BatchResumeVsStreamResponse.BatchResumeVsStream_ResumeResultInfo> batchResumeVsStreamResponse_resumeResult = new List<BatchResumeVsStreamResponse.BatchResumeVsStream_ResumeResultInfo>();
			for (int i = 0; i < context.Length("BatchResumeVsStream.ResumeResult.Length"); i++) {
				BatchResumeVsStreamResponse.BatchResumeVsStream_ResumeResultInfo resumeResultInfo = new BatchResumeVsStreamResponse.BatchResumeVsStream_ResumeResultInfo();
				resumeResultInfo.Result = context.StringValue("BatchResumeVsStream.ResumeResult["+ i +"].Result");
				resumeResultInfo.Detail = context.StringValue("BatchResumeVsStream.ResumeResult["+ i +"].Detail");
				resumeResultInfo.Count = context.IntegerValue("BatchResumeVsStream.ResumeResult["+ i +"].Count");

				List<string> resumeResultInfo_channels = new List<string>();
				for (int j = 0; j < context.Length("BatchResumeVsStream.ResumeResult["+ i +"].Channels.Length"); j++) {
					resumeResultInfo_channels.Add(context.StringValue("BatchResumeVsStream.ResumeResult["+ i +"].Channels["+ j +"]"));
				}
				resumeResultInfo.Channels = resumeResultInfo_channels;

				batchResumeVsStreamResponse_resumeResult.Add(resumeResultInfo);
			}
			batchResumeVsStreamResponse.ResumeResult = batchResumeVsStreamResponse_resumeResult;
        
			return batchResumeVsStreamResponse;
        }
    }
}
