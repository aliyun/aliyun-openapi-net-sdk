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
    public class GetInstanceConfigResponseUnmarshaller
    {
        public static GetInstanceConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInstanceConfigResponse getInstanceConfigResponse = new GetInstanceConfigResponse();

			getInstanceConfigResponse.HttpResponse = _ctx.HttpResponse;
			getInstanceConfigResponse.RequestId = _ctx.StringValue("GetInstanceConfig.RequestId");
			getInstanceConfigResponse.HttpStatusCode = _ctx.IntegerValue("GetInstanceConfig.HttpStatusCode");
			getInstanceConfigResponse.Code = _ctx.StringValue("GetInstanceConfig.Code");
			getInstanceConfigResponse.Message = _ctx.StringValue("GetInstanceConfig.Message");
			getInstanceConfigResponse.Success = _ctx.BooleanValue("GetInstanceConfig.Success");

			GetInstanceConfigResponse.GetInstanceConfig_Data data = new GetInstanceConfigResponse.GetInstanceConfig_Data();

			GetInstanceConfigResponse.GetInstanceConfig_Data.GetInstanceConfig_InstanceConfig instanceConfig = new GetInstanceConfigResponse.GetInstanceConfig_Data.GetInstanceConfig_InstanceConfig();
			instanceConfig.MiniPlaybackSystemSwitch = _ctx.BooleanValue("GetInstanceConfig.Data.InstanceConfig.MiniPlaybackSystemSwitch");
			instanceConfig.NewBargeInSystemSwitch = _ctx.BooleanValue("GetInstanceConfig.Data.InstanceConfig.NewBargeInSystemSwitch");
			instanceConfig.SearchTaskFunctionSwitch = _ctx.BooleanValue("GetInstanceConfig.Data.InstanceConfig.SearchTaskFunctionSwitch");
			data.InstanceConfig = instanceConfig;
			getInstanceConfigResponse.Data = data;
        
			return getInstanceConfigResponse;
        }
    }
}
