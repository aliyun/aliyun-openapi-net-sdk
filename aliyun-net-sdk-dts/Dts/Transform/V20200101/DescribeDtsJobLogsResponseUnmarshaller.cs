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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class DescribeDtsJobLogsResponseUnmarshaller
    {
        public static DescribeDtsJobLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDtsJobLogsResponse describeDtsJobLogsResponse = new DescribeDtsJobLogsResponse();

			describeDtsJobLogsResponse.HttpResponse = _ctx.HttpResponse;
			describeDtsJobLogsResponse.DynamicCode = _ctx.StringValue("DescribeDtsJobLogs.DynamicCode");
			describeDtsJobLogsResponse.DynamicMessage = _ctx.StringValue("DescribeDtsJobLogs.DynamicMessage");
			describeDtsJobLogsResponse.ErrCode = _ctx.StringValue("DescribeDtsJobLogs.ErrCode");
			describeDtsJobLogsResponse.ErrMessage = _ctx.StringValue("DescribeDtsJobLogs.ErrMessage");
			describeDtsJobLogsResponse.HttpStatusCode = _ctx.IntegerValue("DescribeDtsJobLogs.HttpStatusCode");
			describeDtsJobLogsResponse.RequestId = _ctx.StringValue("DescribeDtsJobLogs.RequestId");
			describeDtsJobLogsResponse.Success = _ctx.BooleanValue("DescribeDtsJobLogs.Success");
			describeDtsJobLogsResponse.PageNumber = _ctx.IntegerValue("DescribeDtsJobLogs.PageNumber");
			describeDtsJobLogsResponse.PageRecordCount = _ctx.IntegerValue("DescribeDtsJobLogs.PageRecordCount");
			describeDtsJobLogsResponse.TotalRecordCount = _ctx.LongValue("DescribeDtsJobLogs.TotalRecordCount");

			List<DescribeDtsJobLogsResponse.DescribeDtsJobLogs_JobRunningLog> describeDtsJobLogsResponse_jobRunningLogs = new List<DescribeDtsJobLogsResponse.DescribeDtsJobLogs_JobRunningLog>();
			for (int i = 0; i < _ctx.Length("DescribeDtsJobLogs.JobRunningLogs.Length"); i++) {
				DescribeDtsJobLogsResponse.DescribeDtsJobLogs_JobRunningLog jobRunningLog = new DescribeDtsJobLogsResponse.DescribeDtsJobLogs_JobRunningLog();
				jobRunningLog.Id = _ctx.LongValue("DescribeDtsJobLogs.JobRunningLogs["+ i +"].Id");
				jobRunningLog.JobId = _ctx.StringValue("DescribeDtsJobLogs.JobRunningLogs["+ i +"].JobId");
				jobRunningLog.LogDatetime = _ctx.LongValue("DescribeDtsJobLogs.JobRunningLogs["+ i +"].LogDatetime");
				jobRunningLog.ContentKey = _ctx.StringValue("DescribeDtsJobLogs.JobRunningLogs["+ i +"].ContentKey");
				jobRunningLog.Status = _ctx.StringValue("DescribeDtsJobLogs.JobRunningLogs["+ i +"].Status");

				List<string> jobRunningLog_params = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDtsJobLogs.JobRunningLogs["+ i +"].Params.Length"); j++) {
					jobRunningLog_params.Add(_ctx.StringValue("DescribeDtsJobLogs.JobRunningLogs["+ i +"].Params["+ j +"]"));
				}
				jobRunningLog._Params = jobRunningLog_params;

				describeDtsJobLogsResponse_jobRunningLogs.Add(jobRunningLog);
			}
			describeDtsJobLogsResponse.JobRunningLogs = describeDtsJobLogsResponse_jobRunningLogs;
        
			return describeDtsJobLogsResponse;
        }
    }
}
