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
    public class ListAgentStateLogsResponseUnmarshaller
    {
        public static ListAgentStateLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAgentStateLogsResponse listAgentStateLogsResponse = new ListAgentStateLogsResponse();

			listAgentStateLogsResponse.HttpResponse = _ctx.HttpResponse;
			listAgentStateLogsResponse.RequestId = _ctx.StringValue("ListAgentStateLogs.RequestId");
			listAgentStateLogsResponse.Success = _ctx.BooleanValue("ListAgentStateLogs.Success");
			listAgentStateLogsResponse.Code = _ctx.StringValue("ListAgentStateLogs.Code");
			listAgentStateLogsResponse.Message = _ctx.StringValue("ListAgentStateLogs.Message");
			listAgentStateLogsResponse.HttpStatusCode = _ctx.IntegerValue("ListAgentStateLogs.HttpStatusCode");

			ListAgentStateLogsResponse.ListAgentStateLogs_AgentStateLogPage agentStateLogPage = new ListAgentStateLogsResponse.ListAgentStateLogs_AgentStateLogPage();
			agentStateLogPage.TotalCount = _ctx.IntegerValue("ListAgentStateLogs.AgentStateLogPage.TotalCount");
			agentStateLogPage.PageNumber = _ctx.IntegerValue("ListAgentStateLogs.AgentStateLogPage.PageNumber");
			agentStateLogPage.PageSize = _ctx.IntegerValue("ListAgentStateLogs.AgentStateLogPage.PageSize");

			List<ListAgentStateLogsResponse.ListAgentStateLogs_AgentStateLogPage.ListAgentStateLogs_AgentStateLog> agentStateLogPage_list = new List<ListAgentStateLogsResponse.ListAgentStateLogs_AgentStateLogPage.ListAgentStateLogs_AgentStateLog>();
			for (int i = 0; i < _ctx.Length("ListAgentStateLogs.AgentStateLogPage.List.Length"); i++) {
				ListAgentStateLogsResponse.ListAgentStateLogs_AgentStateLogPage.ListAgentStateLogs_AgentStateLog agentStateLog = new ListAgentStateLogsResponse.ListAgentStateLogs_AgentStateLogPage.ListAgentStateLogs_AgentStateLog();
				agentStateLog.InstanceId = _ctx.StringValue("ListAgentStateLogs.AgentStateLogPage.List["+ i +"].InstanceId");
				agentStateLog.RamId = _ctx.LongValue("ListAgentStateLogs.AgentStateLogPage.List["+ i +"].RamId");
				agentStateLog.State = _ctx.StringValue("ListAgentStateLogs.AgentStateLogPage.List["+ i +"].State");
				agentStateLog.StateCode = _ctx.StringValue("ListAgentStateLogs.AgentStateLogPage.List["+ i +"].StateCode");
				agentStateLog.StateTime = _ctx.LongValue("ListAgentStateLogs.AgentStateLogPage.List["+ i +"].StateTime");
				agentStateLog.ContactId = _ctx.StringValue("ListAgentStateLogs.AgentStateLogPage.List["+ i +"].ContactId");
				agentStateLog.ConnectId = _ctx.StringValue("ListAgentStateLogs.AgentStateLogPage.List["+ i +"].ConnectId");
				agentStateLog.SkillGroupIds = _ctx.StringValue("ListAgentStateLogs.AgentStateLogPage.List["+ i +"].SkillGroupIds");
				agentStateLog.CounterParty = _ctx.StringValue("ListAgentStateLogs.AgentStateLogPage.List["+ i +"].CounterParty");

				agentStateLogPage_list.Add(agentStateLog);
			}
			agentStateLogPage.List = agentStateLogPage_list;
			listAgentStateLogsResponse.AgentStateLogPage = agentStateLogPage;
        
			return listAgentStateLogsResponse;
        }
    }
}
