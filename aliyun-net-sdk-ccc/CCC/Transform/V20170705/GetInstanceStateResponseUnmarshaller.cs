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
    public class GetInstanceStateResponseUnmarshaller
    {
        public static GetInstanceStateResponse Unmarshall(UnmarshallerContext context)
        {
			GetInstanceStateResponse getInstanceStateResponse = new GetInstanceStateResponse();

			getInstanceStateResponse.HttpResponse = context.HttpResponse;
			getInstanceStateResponse.RequestId = context.StringValue("GetInstanceState.RequestId");
			getInstanceStateResponse.Success = context.BooleanValue("GetInstanceState.Success");
			getInstanceStateResponse.Code = context.StringValue("GetInstanceState.Code");
			getInstanceStateResponse.Message = context.StringValue("GetInstanceState.Message");
			getInstanceStateResponse.HttpStatusCode = context.IntegerValue("GetInstanceState.HttpStatusCode");

			GetInstanceStateResponse.GetInstanceState_RealTimeInstanceState realTimeInstanceState = new GetInstanceStateResponse.GetInstanceState_RealTimeInstanceState();

			List<GetInstanceStateResponse.GetInstanceState_RealTimeInstanceState.GetInstanceState_AgentStateCount> realTimeInstanceState_agentStateDistributions = new List<GetInstanceStateResponse.GetInstanceState_RealTimeInstanceState.GetInstanceState_AgentStateCount>();
			for (int i = 0; i < context.Length("GetInstanceState.RealTimeInstanceState.AgentStateDistributions.Length"); i++) {
				GetInstanceStateResponse.GetInstanceState_RealTimeInstanceState.GetInstanceState_AgentStateCount agentStateCount = new GetInstanceStateResponse.GetInstanceState_RealTimeInstanceState.GetInstanceState_AgentStateCount();
				agentStateCount.State = context.StringValue("GetInstanceState.RealTimeInstanceState.AgentStateDistributions["+ i +"].State");
				agentStateCount.Count = context.LongValue("GetInstanceState.RealTimeInstanceState.AgentStateDistributions["+ i +"].Count");

				realTimeInstanceState_agentStateDistributions.Add(agentStateCount);
			}
			realTimeInstanceState.AgentStateDistributions = realTimeInstanceState_agentStateDistributions;
			getInstanceStateResponse.RealTimeInstanceState = realTimeInstanceState;
        
			return getInstanceStateResponse;
        }
    }
}
