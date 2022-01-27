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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class GetImageJobResponseUnmarshaller
    {
        public static GetImageJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetImageJobResponse getImageJobResponse = new GetImageJobResponse();

			getImageJobResponse.HttpResponse = _ctx.HttpResponse;
			getImageJobResponse.RequestId = _ctx.StringValue("GetImageJob.RequestId");
			getImageJobResponse.JobId = _ctx.StringValue("GetImageJob.JobId");
			getImageJobResponse.JobType = _ctx.StringValue("GetImageJob.JobType");
			getImageJobResponse.Parameters = _ctx.StringValue("GetImageJob.Parameters");
			getImageJobResponse.Result = _ctx.StringValue("GetImageJob.Result");
			getImageJobResponse.Status = _ctx.StringValue("GetImageJob.Status");
			getImageJobResponse.StartTime = _ctx.StringValue("GetImageJob.StartTime");
			getImageJobResponse.EndTime = _ctx.StringValue("GetImageJob.EndTime");
			getImageJobResponse.ErrorMessage = _ctx.StringValue("GetImageJob.ErrorMessage");
			getImageJobResponse.NotifyEndpoint = _ctx.StringValue("GetImageJob.NotifyEndpoint");
			getImageJobResponse.NotifyTopicName = _ctx.StringValue("GetImageJob.NotifyTopicName");
			getImageJobResponse.Progress = _ctx.IntegerValue("GetImageJob.Progress");
        
			return getImageJobResponse;
        }
    }
}
