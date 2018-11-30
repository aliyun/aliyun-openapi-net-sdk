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
    public class SubmitAIVideoCategoryJobResponseUnmarshaller
    {
        public static SubmitAIVideoCategoryJobResponse Unmarshall(UnmarshallerContext context)
        {
			SubmitAIVideoCategoryJobResponse submitAIVideoCategoryJobResponse = new SubmitAIVideoCategoryJobResponse();

			submitAIVideoCategoryJobResponse.HttpResponse = context.HttpResponse;
			submitAIVideoCategoryJobResponse.RequestId = context.StringValue("SubmitAIVideoCategoryJob.RequestId");

			SubmitAIVideoCategoryJobResponse.SubmitAIVideoCategoryJob_AIVideoCategoryJob aIVideoCategoryJob = new SubmitAIVideoCategoryJobResponse.SubmitAIVideoCategoryJob_AIVideoCategoryJob();
			aIVideoCategoryJob.JobId = context.StringValue("SubmitAIVideoCategoryJob.AIVideoCategoryJob.JobId");
			aIVideoCategoryJob.MediaId = context.StringValue("SubmitAIVideoCategoryJob.AIVideoCategoryJob.MediaId");
			aIVideoCategoryJob.Status = context.StringValue("SubmitAIVideoCategoryJob.AIVideoCategoryJob.Status");
			aIVideoCategoryJob.Code = context.StringValue("SubmitAIVideoCategoryJob.AIVideoCategoryJob.Code");
			aIVideoCategoryJob.Message = context.StringValue("SubmitAIVideoCategoryJob.AIVideoCategoryJob.Message");
			aIVideoCategoryJob.CreationTime = context.StringValue("SubmitAIVideoCategoryJob.AIVideoCategoryJob.CreationTime");
			aIVideoCategoryJob.Data = context.StringValue("SubmitAIVideoCategoryJob.AIVideoCategoryJob.Data");
			submitAIVideoCategoryJobResponse.AIVideoCategoryJob = aIVideoCategoryJob;
        
			return submitAIVideoCategoryJobResponse;
        }
    }
}