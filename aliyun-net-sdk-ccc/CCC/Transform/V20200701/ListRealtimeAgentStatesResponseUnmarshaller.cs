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
    public class ListRealtimeAgentStatesResponseUnmarshaller
    {
        public static ListRealtimeAgentStatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRealtimeAgentStatesResponse listRealtimeAgentStatesResponse = new ListRealtimeAgentStatesResponse();

			listRealtimeAgentStatesResponse.HttpResponse = _ctx.HttpResponse;
			listRealtimeAgentStatesResponse.Code = _ctx.StringValue("ListRealtimeAgentStates.Code");
			listRealtimeAgentStatesResponse.HttpStatusCode = _ctx.IntegerValue("ListRealtimeAgentStates.HttpStatusCode");
			listRealtimeAgentStatesResponse.Message = _ctx.StringValue("ListRealtimeAgentStates.Message");
			listRealtimeAgentStatesResponse.RequestId = _ctx.StringValue("ListRealtimeAgentStates.RequestId");

			ListRealtimeAgentStatesResponse.ListRealtimeAgentStates_Data data = new ListRealtimeAgentStatesResponse.ListRealtimeAgentStates_Data();
			data.PageNumber = _ctx.IntegerValue("ListRealtimeAgentStates.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListRealtimeAgentStates.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListRealtimeAgentStates.Data.TotalCount");

			List<ListRealtimeAgentStatesResponse.ListRealtimeAgentStates_Data.ListRealtimeAgentStates_AgentState> data_list = new List<ListRealtimeAgentStatesResponse.ListRealtimeAgentStates_Data.ListRealtimeAgentStates_AgentState>();
			for (int i = 0; i < _ctx.Length("ListRealtimeAgentStates.Data.List.Length"); i++) {
				ListRealtimeAgentStatesResponse.ListRealtimeAgentStates_Data.ListRealtimeAgentStates_AgentState agentState = new ListRealtimeAgentStatesResponse.ListRealtimeAgentStates_Data.ListRealtimeAgentStates_AgentState();
				agentState.AgentId = _ctx.StringValue("ListRealtimeAgentStates.Data.List["+ i +"].AgentId");
				agentState.AgentName = _ctx.StringValue("ListRealtimeAgentStates.Data.List["+ i +"].AgentName");
				agentState.CounterParty = _ctx.StringValue("ListRealtimeAgentStates.Data.List["+ i +"].CounterParty");
				agentState.Extension = _ctx.StringValue("ListRealtimeAgentStates.Data.List["+ i +"].Extension");
				agentState.InstanceId = _ctx.StringValue("ListRealtimeAgentStates.Data.List["+ i +"].InstanceId");
				agentState.State = _ctx.StringValue("ListRealtimeAgentStates.Data.List["+ i +"].State");
				agentState.StateCode = _ctx.StringValue("ListRealtimeAgentStates.Data.List["+ i +"].StateCode");
				agentState.StateTime = _ctx.LongValue("ListRealtimeAgentStates.Data.List["+ i +"].StateTime");

				List<string> agentState_skillGroupIdList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListRealtimeAgentStates.Data.List["+ i +"].SkillGroupIdList.Length"); j++) {
					agentState_skillGroupIdList.Add(_ctx.StringValue("ListRealtimeAgentStates.Data.List["+ i +"].SkillGroupIdList["+ j +"]"));
				}
				agentState.SkillGroupIdList = agentState_skillGroupIdList;

				data_list.Add(agentState);
			}
			data.List = data_list;
			listRealtimeAgentStatesResponse.Data = data;
        
			return listRealtimeAgentStatesResponse;
        }
    }
}
