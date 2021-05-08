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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryJobResponseUnmarshaller
    {
        public static QueryJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryJobResponse queryJobResponse = new QueryJobResponse();

			queryJobResponse.HttpResponse = _ctx.HttpResponse;
			queryJobResponse.RequestId = _ctx.StringValue("QueryJob.RequestId");
			queryJobResponse.Success = _ctx.BooleanValue("QueryJob.Success");
			queryJobResponse.Code = _ctx.StringValue("QueryJob.Code");
			queryJobResponse.ErrorMessage = _ctx.StringValue("QueryJob.ErrorMessage");

			QueryJobResponse.QueryJob_Data data = new QueryJobResponse.QueryJob_Data();
			data.JobId = _ctx.StringValue("QueryJob.Data.JobId");
			data.JobName = _ctx.StringValue("QueryJob.Data.JobName");
			data.UtcCreate = _ctx.StringValue("QueryJob.Data.UtcCreate");
			data.Status = _ctx.StringValue("QueryJob.Data.Status");
			data.Description = _ctx.StringValue("QueryJob.Data.Description");
			data.Type = _ctx.StringValue("QueryJob.Data.Type");
			data.JobDocument = _ctx.StringValue("QueryJob.Data.JobDocument");
			data.UtcModified = _ctx.StringValue("QueryJob.Data.UtcModified");
			data.ScheduledTime = _ctx.LongValue("QueryJob.Data.ScheduledTime");

			QueryJobResponse.QueryJob_Data.QueryJob_RolloutConfig rolloutConfig = new QueryJobResponse.QueryJob_Data.QueryJob_RolloutConfig();
			rolloutConfig.MaximumPerMinute = _ctx.IntegerValue("QueryJob.Data.RolloutConfig.MaximumPerMinute");
			data.RolloutConfig = rolloutConfig;

			QueryJobResponse.QueryJob_Data.QueryJob_TimeoutConfig timeoutConfig = new QueryJobResponse.QueryJob_Data.QueryJob_TimeoutConfig();
			timeoutConfig.InProgressTimeoutInMinutes = _ctx.IntegerValue("QueryJob.Data.TimeoutConfig.InProgressTimeoutInMinutes");
			data.TimeoutConfig = timeoutConfig;

			QueryJobResponse.QueryJob_Data.QueryJob_JobFile jobFile = new QueryJobResponse.QueryJob_Data.QueryJob_JobFile();
			jobFile.FileUrl = _ctx.StringValue("QueryJob.Data.JobFile.FileUrl");
			jobFile.SignMethod = _ctx.StringValue("QueryJob.Data.JobFile.SignMethod");
			jobFile.Sign = _ctx.StringValue("QueryJob.Data.JobFile.Sign");
			data.JobFile = jobFile;

			QueryJobResponse.QueryJob_Data.QueryJob_TargetConfig targetConfig = new QueryJobResponse.QueryJob_Data.QueryJob_TargetConfig();
			targetConfig.TargetGroup = _ctx.StringValue("QueryJob.Data.TargetConfig.TargetGroup");
			targetConfig.TargetProduct = _ctx.StringValue("QueryJob.Data.TargetConfig.TargetProduct");
			targetConfig.TargetType = _ctx.StringValue("QueryJob.Data.TargetConfig.TargetType");

			List<QueryJobResponse.QueryJob_Data.QueryJob_TargetConfig.QueryJob_TargetDevicesItem> targetConfig_targetDevices = new List<QueryJobResponse.QueryJob_Data.QueryJob_TargetConfig.QueryJob_TargetDevicesItem>();
			for (int i = 0; i < _ctx.Length("QueryJob.Data.TargetConfig.TargetDevices.Length"); i++) {
				QueryJobResponse.QueryJob_Data.QueryJob_TargetConfig.QueryJob_TargetDevicesItem targetDevicesItem = new QueryJobResponse.QueryJob_Data.QueryJob_TargetConfig.QueryJob_TargetDevicesItem();
				targetDevicesItem.ProductKey = _ctx.StringValue("QueryJob.Data.TargetConfig.TargetDevices["+ i +"].ProductKey");
				targetDevicesItem.DeviceName = _ctx.StringValue("QueryJob.Data.TargetConfig.TargetDevices["+ i +"].DeviceName");

				targetConfig_targetDevices.Add(targetDevicesItem);
			}
			targetConfig.TargetDevices = targetConfig_targetDevices;
			data.TargetConfig = targetConfig;
			queryJobResponse.Data = data;
        
			return queryJobResponse;
        }
    }
}
