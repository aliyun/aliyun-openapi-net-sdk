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
    public class GetSparkAppInfoResponseUnmarshaller
    {
        public static GetSparkAppInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSparkAppInfoResponse getSparkAppInfoResponse = new GetSparkAppInfoResponse();

			getSparkAppInfoResponse.HttpResponse = _ctx.HttpResponse;
			getSparkAppInfoResponse.RequestId = _ctx.StringValue("GetSparkAppInfo.RequestId");

			GetSparkAppInfoResponse.GetSparkAppInfo_Data data = new GetSparkAppInfoResponse.GetSparkAppInfo_Data();
			data.AppId = _ctx.StringValue("GetSparkAppInfo.Data.AppId");
			data.AppName = _ctx.StringValue("GetSparkAppInfo.Data.AppName");
			data.State = _ctx.StringValue("GetSparkAppInfo.Data.State");
			data.Message = _ctx.StringValue("GetSparkAppInfo.Data.Message");
			data.DBClusterId = _ctx.StringValue("GetSparkAppInfo.Data.DBClusterId");

			GetSparkAppInfoResponse.GetSparkAppInfo_Data.GetSparkAppInfo_Detail detail = new GetSparkAppInfoResponse.GetSparkAppInfo_Data.GetSparkAppInfo_Detail();
			detail.Data = _ctx.StringValue("GetSparkAppInfo.Data.Detail.Data");
			detail.EstimateExecutionCpuTimeInSeconds = _ctx.LongValue("GetSparkAppInfo.Data.Detail.EstimateExecutionCpuTimeInSeconds");
			detail.LogRootPath = _ctx.StringValue("GetSparkAppInfo.Data.Detail.LogRootPath");
			detail.LastAttemptId = _ctx.StringValue("GetSparkAppInfo.Data.Detail.LastAttemptId");
			detail.WebUiAddress = _ctx.StringValue("GetSparkAppInfo.Data.Detail.WebUiAddress");
			detail.SubmittedTimeInMillis = _ctx.LongValue("GetSparkAppInfo.Data.Detail.SubmittedTimeInMillis");
			detail.StartedTimeInMillis = _ctx.LongValue("GetSparkAppInfo.Data.Detail.StartedTimeInMillis");
			detail.LastUpdatedTimeInMillis = _ctx.LongValue("GetSparkAppInfo.Data.Detail.LastUpdatedTimeInMillis");
			detail.TerminatedTimeInMillis = _ctx.LongValue("GetSparkAppInfo.Data.Detail.TerminatedTimeInMillis");
			detail.DBClusterId = _ctx.StringValue("GetSparkAppInfo.Data.Detail.DBClusterId");
			detail.ResourceGroupName = _ctx.StringValue("GetSparkAppInfo.Data.Detail.ResourceGroupName");
			detail.DurationInMillis = _ctx.LongValue("GetSparkAppInfo.Data.Detail.DurationInMillis");
			data.Detail = detail;
			getSparkAppInfoResponse.Data = data;
        
			return getSparkAppInfoResponse;
        }
    }
}
