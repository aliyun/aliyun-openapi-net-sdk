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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class GetAgentStateResponseUnmarshaller
    {
        public static GetAgentStateResponse Unmarshall(UnmarshallerContext context)
        {
			GetAgentStateResponse getAgentStateResponse = new GetAgentStateResponse();

			getAgentStateResponse.HttpResponse = context.HttpResponse;
			getAgentStateResponse.RequestId = context.StringValue("GetAgentState.RequestId");
			getAgentStateResponse.Success = context.BooleanValue("GetAgentState.Success");
			getAgentStateResponse.Code = context.StringValue("GetAgentState.Code");
			getAgentStateResponse.Message = context.StringValue("GetAgentState.Message");
			getAgentStateResponse.HttpStatusCode = context.IntegerValue("GetAgentState.HttpStatusCode");

			GetAgentStateResponse.GetAgentState_Data data = new GetAgentStateResponse.GetAgentState_Data();
			data.InstanceId = context.StringValue("GetAgentState.Data.InstanceId");
			data.AgentId = context.StringValue("GetAgentState.Data.AgentId");
			data.LoginName = context.StringValue("GetAgentState.Data.LoginName");
			data.AgentName = context.StringValue("GetAgentState.Data.AgentName");
			data.State = context.StringValue("GetAgentState.Data.State");
			data.Dn = context.StringValue("GetAgentState.Data.Dn");
			data.StateDuration = context.StringValue("GetAgentState.Data.StateDuration");
			getAgentStateResponse.Data = data;
        
			return getAgentStateResponse;
        }
    }
}
