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
using Aliyun.Acs.viapi_oxs_cross.Model.V20200701;

namespace Aliyun.Acs.viapi_oxs_cross.Transform.V20200701
{
    public class GetSDKInstanceDebugInfoResponseUnmarshaller
    {
        public static GetSDKInstanceDebugInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSDKInstanceDebugInfoResponse getSDKInstanceDebugInfoResponse = new GetSDKInstanceDebugInfoResponse();

			getSDKInstanceDebugInfoResponse.HttpResponse = _ctx.HttpResponse;
			getSDKInstanceDebugInfoResponse.Ok = _ctx.BooleanValue("GetSDKInstanceDebugInfo.Ok");
			getSDKInstanceDebugInfoResponse.Code = _ctx.StringValue("GetSDKInstanceDebugInfo.Code");
			getSDKInstanceDebugInfoResponse.HttpCode = _ctx.IntegerValue("GetSDKInstanceDebugInfo.HttpCode");
			getSDKInstanceDebugInfoResponse.ErrorMessage = _ctx.StringValue("GetSDKInstanceDebugInfo.ErrorMessage");
			getSDKInstanceDebugInfoResponse.RequestId = _ctx.StringValue("GetSDKInstanceDebugInfo.RequestId");

			GetSDKInstanceDebugInfoResponse.GetSDKInstanceDebugInfo_Data data = new GetSDKInstanceDebugInfoResponse.GetSDKInstanceDebugInfo_Data();
			data.Status = _ctx.StringValue("GetSDKInstanceDebugInfo.Data.Status");
			data.LatestBuild = _ctx.StringValue("GetSDKInstanceDebugInfo.Data.LatestBuild");
			data.ValidFromDate = _ctx.StringValue("GetSDKInstanceDebugInfo.Data.ValidFromDate");
			data.ValidToDate = _ctx.StringValue("GetSDKInstanceDebugInfo.Data.ValidToDate");
			data.Platform = _ctx.StringValue("GetSDKInstanceDebugInfo.Data.Platform");
			data.CreatedAt = _ctx.StringValue("GetSDKInstanceDebugInfo.Data.CreatedAt");
			data.Recipe = _ctx.StringValue("GetSDKInstanceDebugInfo.Data.Recipe");
			data.UpdatedAt = _ctx.StringValue("GetSDKInstanceDebugInfo.Data.UpdatedAt");
			data.InstanceId = _ctx.StringValue("GetSDKInstanceDebugInfo.Data.InstanceId");
			data.BundleId = _ctx.StringValue("GetSDKInstanceDebugInfo.Data.BundleId");

			List<GetSDKInstanceDebugInfoResponse.GetSDKInstanceDebugInfo_Data.GetSDKInstanceDebugInfo__Event> data_events = new List<GetSDKInstanceDebugInfoResponse.GetSDKInstanceDebugInfo_Data.GetSDKInstanceDebugInfo__Event>();
			for (int i = 0; i < _ctx.Length("GetSDKInstanceDebugInfo.Data.Events.Length"); i++) {
				GetSDKInstanceDebugInfoResponse.GetSDKInstanceDebugInfo_Data.GetSDKInstanceDebugInfo__Event _event = new GetSDKInstanceDebugInfoResponse.GetSDKInstanceDebugInfo_Data.GetSDKInstanceDebugInfo__Event();
				_event.TimeStamp = _ctx.StringValue("GetSDKInstanceDebugInfo.Data.Events["+ i +"].TimeStamp");
				_event.Success = _ctx.BooleanValue("GetSDKInstanceDebugInfo.Data.Events["+ i +"].Success");
				_event.Content = _ctx.StringValue("GetSDKInstanceDebugInfo.Data.Events["+ i +"].Content");
				_event.Id = _ctx.LongValue("GetSDKInstanceDebugInfo.Data.Events["+ i +"].Id");

				data_events.Add(_event);
			}
			data.Events = data_events;
			getSDKInstanceDebugInfoResponse.Data = data;
        
			return getSDKInstanceDebugInfoResponse;
        }
    }
}
