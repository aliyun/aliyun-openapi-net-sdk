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
using Aliyun.Acs.schedulerx2.Model.V20190430;

namespace Aliyun.Acs.schedulerx2.Transform.V20190430
{
    public class GetAppGroupResponseUnmarshaller
    {
        public static GetAppGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAppGroupResponse getAppGroupResponse = new GetAppGroupResponse();

			getAppGroupResponse.HttpResponse = _ctx.HttpResponse;
			getAppGroupResponse.RequestId = _ctx.StringValue("GetAppGroup.RequestId");
			getAppGroupResponse.Code = _ctx.IntegerValue("GetAppGroup.Code");
			getAppGroupResponse.Message = _ctx.StringValue("GetAppGroup.Message");
			getAppGroupResponse.Success = _ctx.BooleanValue("GetAppGroup.Success");

			GetAppGroupResponse.GetAppGroup_Data data = new GetAppGroupResponse.GetAppGroup_Data();
			data.AppName = _ctx.StringValue("GetAppGroup.Data.AppName");
			data.Description = _ctx.StringValue("GetAppGroup.Data.Description");
			data.MaxJobs = _ctx.IntegerValue("GetAppGroup.Data.MaxJobs");
			data.GroupId = _ctx.StringValue("GetAppGroup.Data.GroupId");
			data.AlarmJson = _ctx.StringValue("GetAppGroup.Data.AlarmJson");
			data.MetricsThresholdJson = _ctx.StringValue("GetAppGroup.Data.MetricsThresholdJson");
			data.MonitorConfigJson = _ctx.StringValue("GetAppGroup.Data.MonitorConfigJson");
			data.MaxConcurrency = _ctx.IntegerValue("GetAppGroup.Data.MaxConcurrency");
			data.CurJobs = _ctx.IntegerValue("GetAppGroup.Data.CurJobs");
			data.RunningInstanceNum = _ctx.IntegerValue("GetAppGroup.Data.RunningInstanceNum");
			data.ReadyInstanceNum = _ctx.IntegerValue("GetAppGroup.Data.ReadyInstanceNum");
			data.AppGroupId = _ctx.LongValue("GetAppGroup.Data.AppGroupId");
			data.AppKey = _ctx.StringValue("GetAppGroup.Data.AppKey");
			data.Xattrs = _ctx.StringValue("GetAppGroup.Data.Xattrs");
			getAppGroupResponse.Data = data;
        
			return getAppGroupResponse;
        }
    }
}
