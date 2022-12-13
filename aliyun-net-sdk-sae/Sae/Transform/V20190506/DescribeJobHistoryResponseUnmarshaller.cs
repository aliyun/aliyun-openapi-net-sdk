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
    public class DescribeJobHistoryResponseUnmarshaller
    {
        public static DescribeJobHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeJobHistoryResponse describeJobHistoryResponse = new DescribeJobHistoryResponse();

			describeJobHistoryResponse.HttpResponse = _ctx.HttpResponse;
			describeJobHistoryResponse.RequestId = _ctx.StringValue("DescribeJobHistory.RequestId");
			describeJobHistoryResponse.Message = _ctx.StringValue("DescribeJobHistory.Message");
			describeJobHistoryResponse.TraceId = _ctx.StringValue("DescribeJobHistory.TraceId");
			describeJobHistoryResponse.ErrorCode = _ctx.StringValue("DescribeJobHistory.ErrorCode");
			describeJobHistoryResponse.Code = _ctx.StringValue("DescribeJobHistory.Code");
			describeJobHistoryResponse.Success = _ctx.BooleanValue("DescribeJobHistory.Success");

			DescribeJobHistoryResponse.DescribeJobHistory_Data data = new DescribeJobHistoryResponse.DescribeJobHistory_Data();
			data.CurrentPage = _ctx.LongValue("DescribeJobHistory.Data.CurrentPage");
			data.TotalSize = _ctx.LongValue("DescribeJobHistory.Data.TotalSize");
			data.PageSize = _ctx.LongValue("DescribeJobHistory.Data.PageSize");

			List<DescribeJobHistoryResponse.DescribeJobHistory_Data.DescribeJobHistory_Job> data_jobs = new List<DescribeJobHistoryResponse.DescribeJobHistory_Data.DescribeJobHistory_Job>();
			for (int i = 0; i < _ctx.Length("DescribeJobHistory.Data.Jobs.Length"); i++) {
				DescribeJobHistoryResponse.DescribeJobHistory_Data.DescribeJobHistory_Job job = new DescribeJobHistoryResponse.DescribeJobHistory_Data.DescribeJobHistory_Job();
				job.JobId = _ctx.StringValue("DescribeJobHistory.Data.Jobs["+ i +"].JobId");
				job.Active = _ctx.LongValue("DescribeJobHistory.Data.Jobs["+ i +"].Active");
				job.Succeeded = _ctx.LongValue("DescribeJobHistory.Data.Jobs["+ i +"].Succeeded");
				job.Failed = _ctx.LongValue("DescribeJobHistory.Data.Jobs["+ i +"].Failed");
				job.StartTime = _ctx.LongValue("DescribeJobHistory.Data.Jobs["+ i +"].StartTime");
				job.CompletionTime = _ctx.LongValue("DescribeJobHistory.Data.Jobs["+ i +"].CompletionTime");
				job.Message = _ctx.StringValue("DescribeJobHistory.Data.Jobs["+ i +"].Message");
				job.State = _ctx.StringValue("DescribeJobHistory.Data.Jobs["+ i +"].State");

				data_jobs.Add(job);
			}
			data.Jobs = data_jobs;
			describeJobHistoryResponse.Data = data;
        
			return describeJobHistoryResponse;
        }
    }
}
