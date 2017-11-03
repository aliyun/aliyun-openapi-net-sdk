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
    public class SubmitAIVideoTerrorismRecogJobResponseUnmarshaller
    {
        public static SubmitAIVideoTerrorismRecogJobResponse Unmarshall(UnmarshallerContext context)
        {
			SubmitAIVideoTerrorismRecogJobResponse submitAIVideoTerrorismRecogJobResponse = new SubmitAIVideoTerrorismRecogJobResponse();

			submitAIVideoTerrorismRecogJobResponse.HttpResponse = context.HttpResponse;
			submitAIVideoTerrorismRecogJobResponse.RequestId = context.StringValue("SubmitAIVideoTerrorismRecogJob.RequestId");

			SubmitAIVideoTerrorismRecogJobResponse.SubmitAIVideoTerrorismRecogJob_AIVideoTerrorismRecogJob aIVideoTerrorismRecogJob = new SubmitAIVideoTerrorismRecogJobResponse.SubmitAIVideoTerrorismRecogJob_AIVideoTerrorismRecogJob();
			aIVideoTerrorismRecogJob.JobId = context.StringValue("SubmitAIVideoTerrorismRecogJob.AIVideoTerrorismRecogJob.JobId");
			aIVideoTerrorismRecogJob.MediaId = context.StringValue("SubmitAIVideoTerrorismRecogJob.AIVideoTerrorismRecogJob.MediaId");
			aIVideoTerrorismRecogJob.Status = context.StringValue("SubmitAIVideoTerrorismRecogJob.AIVideoTerrorismRecogJob.Status");
			aIVideoTerrorismRecogJob.Code = context.StringValue("SubmitAIVideoTerrorismRecogJob.AIVideoTerrorismRecogJob.Code");
			aIVideoTerrorismRecogJob.Message = context.StringValue("SubmitAIVideoTerrorismRecogJob.AIVideoTerrorismRecogJob.Message");
			aIVideoTerrorismRecogJob.CreationTime = context.StringValue("SubmitAIVideoTerrorismRecogJob.AIVideoTerrorismRecogJob.CreationTime");
			aIVideoTerrorismRecogJob.Data = context.StringValue("SubmitAIVideoTerrorismRecogJob.AIVideoTerrorismRecogJob.Data");
			submitAIVideoTerrorismRecogJobResponse.AIVideoTerrorismRecogJob = aIVideoTerrorismRecogJob;
        
			return submitAIVideoTerrorismRecogJobResponse;
        }
    }
}