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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class DescribeJobStatusResponseUnmarshaller
    {
        public static DescribeJobStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeJobStatusResponse describeJobStatusResponse = new DescribeJobStatusResponse();

			describeJobStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeJobStatusResponse.RequestId = _ctx.StringValue("DescribeJobStatus.RequestId");
			describeJobStatusResponse.Message = _ctx.StringValue("DescribeJobStatus.Message");
			describeJobStatusResponse.TraceId = _ctx.StringValue("DescribeJobStatus.TraceId");
			describeJobStatusResponse.ErrorCode = _ctx.StringValue("DescribeJobStatus.ErrorCode");
			describeJobStatusResponse.Code = _ctx.StringValue("DescribeJobStatus.Code");
			describeJobStatusResponse.Success = _ctx.BooleanValue("DescribeJobStatus.Success");

			DescribeJobStatusResponse.DescribeJobStatus_Data data = new DescribeJobStatusResponse.DescribeJobStatus_Data();
			data.JobId = _ctx.StringValue("DescribeJobStatus.Data.JobId");
			data.Active = _ctx.LongValue("DescribeJobStatus.Data.Active");
			data.Succeeded = _ctx.LongValue("DescribeJobStatus.Data.Succeeded");
			data.Failed = _ctx.LongValue("DescribeJobStatus.Data.Failed");
			data.StartTime = _ctx.LongValue("DescribeJobStatus.Data.StartTime");
			data.CompletionTime = _ctx.LongValue("DescribeJobStatus.Data.CompletionTime");
			data.Message = _ctx.StringValue("DescribeJobStatus.Data.Message");
			data.State = _ctx.StringValue("DescribeJobStatus.Data.State");
			describeJobStatusResponse.Data = data;
        
			return describeJobStatusResponse;
        }
    }
}
