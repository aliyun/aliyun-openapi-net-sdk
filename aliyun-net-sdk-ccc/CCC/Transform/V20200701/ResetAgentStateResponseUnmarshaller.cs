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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class ResetAgentStateResponseUnmarshaller
    {
        public static ResetAgentStateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ResetAgentStateResponse resetAgentStateResponse = new ResetAgentStateResponse();

			resetAgentStateResponse.HttpResponse = _ctx.HttpResponse;
			resetAgentStateResponse.Code = _ctx.StringValue("ResetAgentState.Code");
			resetAgentStateResponse.HttpStatusCode = _ctx.IntegerValue("ResetAgentState.HttpStatusCode");
			resetAgentStateResponse.Message = _ctx.StringValue("ResetAgentState.Message");
			resetAgentStateResponse.RequestId = _ctx.StringValue("ResetAgentState.RequestId");

			List<string> resetAgentStateResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("ResetAgentState.Params.Length"); i++) {
				resetAgentStateResponse_params.Add(_ctx.StringValue("ResetAgentState.Params["+ i +"]"));
			}
			resetAgentStateResponse._Params = resetAgentStateResponse_params;

			ResetAgentStateResponse.ResetAgentState_Data data = new ResetAgentStateResponse.ResetAgentState_Data();
			data.BreakCode = _ctx.StringValue("ResetAgentState.Data.BreakCode");
			data.DeviceId = _ctx.StringValue("ResetAgentState.Data.DeviceId");
			data.Extension = _ctx.StringValue("ResetAgentState.Data.Extension");
			data.InstanceId = _ctx.StringValue("ResetAgentState.Data.InstanceId");
			data.JobId = _ctx.StringValue("ResetAgentState.Data.JobId");
			data.OutboundScenario = _ctx.BooleanValue("ResetAgentState.Data.OutboundScenario");
			data.UserId = _ctx.StringValue("ResetAgentState.Data.UserId");
			data.UserState = _ctx.StringValue("ResetAgentState.Data.UserState");
			data.WorkMode = _ctx.StringValue("ResetAgentState.Data.WorkMode");

			List<string> data_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("ResetAgentState.Data.SignedSkillGroupIdList.Length"); i++) {
				data_signedSkillGroupIdList.Add(_ctx.StringValue("ResetAgentState.Data.SignedSkillGroupIdList["+ i +"]"));
			}
			data.SignedSkillGroupIdList = data_signedSkillGroupIdList;
			resetAgentStateResponse.Data = data;
        
			return resetAgentStateResponse;
        }
    }
}
