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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class SubmitBatchJobsResponseUnmarshaller
    {
        public static SubmitBatchJobsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitBatchJobsResponse submitBatchJobsResponse = new SubmitBatchJobsResponse();

			submitBatchJobsResponse.HttpResponse = _ctx.HttpResponse;
			submitBatchJobsResponse.HttpStatusCode = _ctx.IntegerValue("SubmitBatchJobs.HttpStatusCode");
			submitBatchJobsResponse.Code = _ctx.StringValue("SubmitBatchJobs.Code");
			submitBatchJobsResponse.Message = _ctx.StringValue("SubmitBatchJobs.Message");
			submitBatchJobsResponse.RequestId = _ctx.StringValue("SubmitBatchJobs.RequestId");
			submitBatchJobsResponse.Success = _ctx.BooleanValue("SubmitBatchJobs.Success");
        
			return submitBatchJobsResponse;
        }
    }
}
