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
    public class ListAgentEventsResponseUnmarshaller
    {
        public static ListAgentEventsResponse Unmarshall(UnmarshallerContext context)
        {
			ListAgentEventsResponse listAgentEventsResponse = new ListAgentEventsResponse();

			listAgentEventsResponse.HttpResponse = context.HttpResponse;
			listAgentEventsResponse.RequestId = context.StringValue("ListAgentEvents.RequestId");
			listAgentEventsResponse.Success = context.BooleanValue("ListAgentEvents.Success");
			listAgentEventsResponse.Code = context.StringValue("ListAgentEvents.Code");
			listAgentEventsResponse.Message = context.StringValue("ListAgentEvents.Message");
			listAgentEventsResponse.HttpStatusCode = context.IntegerValue("ListAgentEvents.HttpStatusCode");

			List<ListAgentEventsResponse.ListAgentEvents_AgentEvent> listAgentEventsResponse_agentEventList = new List<ListAgentEventsResponse.ListAgentEvents_AgentEvent>();
			for (int i = 0; i < context.Length("ListAgentEvents.AgentEventList.Length"); i++) {
				ListAgentEventsResponse.ListAgentEvents_AgentEvent agentEvent = new ListAgentEventsResponse.ListAgentEvents_AgentEvent();
				agentEvent.InstanceId = context.StringValue("ListAgentEvents.AgentEventList["+ i +"].InstanceId");
				agentEvent.RamId = context.LongValue("ListAgentEvents.AgentEventList["+ i +"].RamId");
				agentEvent.LoginName = context.StringValue("ListAgentEvents.AgentEventList["+ i +"].LoginName");
				agentEvent._Event = context.StringValue("ListAgentEvents.AgentEventList["+ i +"].Event");
				agentEvent.EventTime = context.LongValue("ListAgentEvents.AgentEventList["+ i +"].EventTime");

				List<ListAgentEventsResponse.ListAgentEvents_AgentEvent.ListAgentEvents_SkillGroup> agentEvent_skillGroupIds = new List<ListAgentEventsResponse.ListAgentEvents_AgentEvent.ListAgentEvents_SkillGroup>();
				for (int j = 0; j < context.Length("ListAgentEvents.AgentEventList["+ i +"].SkillGroupIds.Length"); j++) {
					ListAgentEventsResponse.ListAgentEvents_AgentEvent.ListAgentEvents_SkillGroup skillGroup = new ListAgentEventsResponse.ListAgentEvents_AgentEvent.ListAgentEvents_SkillGroup();
					skillGroup.SkillGroupId = context.StringValue("ListAgentEvents.AgentEventList["+ i +"].SkillGroupIds["+ j +"].SkillGroupId");
					skillGroup.SkillGroupName = context.StringValue("ListAgentEvents.AgentEventList["+ i +"].SkillGroupIds["+ j +"].SkillGroupName");

					agentEvent_skillGroupIds.Add(skillGroup);
				}
				agentEvent.SkillGroupIds = agentEvent_skillGroupIds;

				listAgentEventsResponse_agentEventList.Add(agentEvent);
			}
			listAgentEventsResponse.AgentEventList = listAgentEventsResponse_agentEventList;
        
			return listAgentEventsResponse;
        }
    }
}
