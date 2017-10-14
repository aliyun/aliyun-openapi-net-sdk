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
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class SubmitAIASRJobResponseUnmarshaller
    {
        public static SubmitAIASRJobResponse Unmarshall(UnmarshallerContext context)
        {
			SubmitAIASRJobResponse submitAIASRJobResponse = new SubmitAIASRJobResponse();

			submitAIASRJobResponse.HttpResponse = context.HttpResponse;
			submitAIASRJobResponse.RequestId = context.StringValue("SubmitAIASRJob.RequestId");

			SubmitAIASRJobResponse.SubmitAIASRJob_AIASRJob aIASRJob = new SubmitAIASRJobResponse.SubmitAIASRJob_AIASRJob();
			aIASRJob.JobId = context.StringValue("SubmitAIASRJob.AIASRJob.JobId");
			aIASRJob.MediaId = context.StringValue("SubmitAIASRJob.AIASRJob.MediaId");
			aIASRJob.Status = context.StringValue("SubmitAIASRJob.AIASRJob.Status");
			aIASRJob.Code = context.StringValue("SubmitAIASRJob.AIASRJob.Code");
			aIASRJob.Message = context.StringValue("SubmitAIASRJob.AIASRJob.Message");
			aIASRJob.CreationTime = context.StringValue("SubmitAIASRJob.AIASRJob.CreationTime");
			aIASRJob.Data = context.StringValue("SubmitAIASRJob.AIASRJob.Data");
			submitAIASRJobResponse.AIASRJob = aIASRJob;
        
			return submitAIASRJobResponse;
        }
    }
}