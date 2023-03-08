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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class ListSparkAppAttemptsResponseUnmarshaller
    {
        public static ListSparkAppAttemptsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSparkAppAttemptsResponse listSparkAppAttemptsResponse = new ListSparkAppAttemptsResponse();

			listSparkAppAttemptsResponse.HttpResponse = _ctx.HttpResponse;
			listSparkAppAttemptsResponse.RequestId = _ctx.StringValue("ListSparkAppAttempts.RequestId");

			ListSparkAppAttemptsResponse.ListSparkAppAttempts_Data data = new ListSparkAppAttemptsResponse.ListSparkAppAttempts_Data();
			data.PageNumber = _ctx.LongValue("ListSparkAppAttempts.Data.PageNumber");
			data.PageSize = _ctx.LongValue("ListSparkAppAttempts.Data.PageSize");
			data.TotalCount = _ctx.LongValue("ListSparkAppAttempts.Data.TotalCount");

			List<ListSparkAppAttemptsResponse.ListSparkAppAttempts_Data.ListSparkAppAttempts_AttemptInfo> data_attemptInfoList = new List<ListSparkAppAttemptsResponse.ListSparkAppAttempts_Data.ListSparkAppAttempts_AttemptInfo>();
			for (int i = 0; i < _ctx.Length("ListSparkAppAttempts.Data.AttemptInfoList.Length"); i++) {
				ListSparkAppAttemptsResponse.ListSparkAppAttempts_Data.ListSparkAppAttempts_AttemptInfo attemptInfo = new ListSparkAppAttemptsResponse.ListSparkAppAttempts_Data.ListSparkAppAttempts_AttemptInfo();
				attemptInfo.AttemptId = _ctx.StringValue("ListSparkAppAttempts.Data.AttemptInfoList["+ i +"].AttemptId");
				attemptInfo.State = _ctx.StringValue("ListSparkAppAttempts.Data.AttemptInfoList["+ i +"].State");
				attemptInfo.Message = _ctx.StringValue("ListSparkAppAttempts.Data.AttemptInfoList["+ i +"].Message");

				ListSparkAppAttemptsResponse.ListSparkAppAttempts_Data.ListSparkAppAttempts_AttemptInfo.ListSparkAppAttempts_Detail detail = new ListSparkAppAttemptsResponse.ListSparkAppAttempts_Data.ListSparkAppAttempts_AttemptInfo.ListSparkAppAttempts_Detail();
				detail.Data = _ctx.StringValue("ListSparkAppAttempts.Data.AttemptInfoList["+ i +"].Detail.Data");
				detail.EstimateExecutionCpuTimeInSeconds = _ctx.LongValue("ListSparkAppAttempts.Data.AttemptInfoList["+ i +"].Detail.EstimateExecutionCpuTimeInSeconds");
				detail.LogRootPath = _ctx.StringValue("ListSparkAppAttempts.Data.AttemptInfoList["+ i +"].Detail.LogRootPath");
				detail.LastAttemptId = _ctx.StringValue("ListSparkAppAttempts.Data.AttemptInfoList["+ i +"].Detail.LastAttemptId");
				detail.WebUiAddress = _ctx.StringValue("ListSparkAppAttempts.Data.AttemptInfoList["+ i +"].Detail.WebUiAddress");
				detail.SubmittedTimeInMillis = _ctx.LongValue("ListSparkAppAttempts.Data.AttemptInfoList["+ i +"].Detail.SubmittedTimeInMillis");
				detail.StartedTimeInMillis = _ctx.LongValue("ListSparkAppAttempts.Data.AttemptInfoList["+ i +"].Detail.StartedTimeInMillis");
				detail.LastUpdatedTimeInMillis = _ctx.LongValue("ListSparkAppAttempts.Data.AttemptInfoList["+ i +"].Detail.LastUpdatedTimeInMillis");
				detail.TerminatedTimeInMillis = _ctx.LongValue("ListSparkAppAttempts.Data.AttemptInfoList["+ i +"].Detail.TerminatedTimeInMillis");
				detail.DBClusterId = _ctx.StringValue("ListSparkAppAttempts.Data.AttemptInfoList["+ i +"].Detail.DBClusterId");
				detail.ResourceGroupName = _ctx.StringValue("ListSparkAppAttempts.Data.AttemptInfoList["+ i +"].Detail.ResourceGroupName");
				detail.DurationInMillis = _ctx.LongValue("ListSparkAppAttempts.Data.AttemptInfoList["+ i +"].Detail.DurationInMillis");
				attemptInfo.Detail = detail;

				data_attemptInfoList.Add(attemptInfo);
			}
			data.AttemptInfoList = data_attemptInfoList;
			listSparkAppAttemptsResponse.Data = data;
        
			return listSparkAppAttemptsResponse;
        }
    }
}
