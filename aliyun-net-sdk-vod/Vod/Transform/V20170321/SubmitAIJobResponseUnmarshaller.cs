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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class SubmitAIJobResponseUnmarshaller
    {
        public static SubmitAIJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitAIJobResponse submitAIJobResponse = new SubmitAIJobResponse();

			submitAIJobResponse.HttpResponse = _ctx.HttpResponse;
			submitAIJobResponse.RequestId = _ctx.StringValue("SubmitAIJob.RequestId");

			List<SubmitAIJobResponse.SubmitAIJob_AIJob> submitAIJobResponse_aIJobList = new List<SubmitAIJobResponse.SubmitAIJob_AIJob>();
			for (int i = 0; i < _ctx.Length("SubmitAIJob.AIJobList.Length"); i++) {
				SubmitAIJobResponse.SubmitAIJob_AIJob aIJob = new SubmitAIJobResponse.SubmitAIJob_AIJob();
				aIJob.JobId = _ctx.StringValue("SubmitAIJob.AIJobList["+ i +"].JobId");
				aIJob.Type = _ctx.StringValue("SubmitAIJob.AIJobList["+ i +"].Type");
				aIJob.MediaId = _ctx.StringValue("SubmitAIJob.AIJobList["+ i +"].MediaId");
				aIJob.Status = _ctx.StringValue("SubmitAIJob.AIJobList["+ i +"].Status");
				aIJob.Code = _ctx.StringValue("SubmitAIJob.AIJobList["+ i +"].Code");
				aIJob.Message = _ctx.StringValue("SubmitAIJob.AIJobList["+ i +"].Message");
				aIJob.CreationTime = _ctx.StringValue("SubmitAIJob.AIJobList["+ i +"].CreationTime");
				aIJob.Data = _ctx.StringValue("SubmitAIJob.AIJobList["+ i +"].Data");

				submitAIJobResponse_aIJobList.Add(aIJob);
			}
			submitAIJobResponse.AIJobList = submitAIJobResponse_aIJobList;
        
			return submitAIJobResponse;
        }
    }
}
