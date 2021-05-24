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
    public class ListRealtimeSkillGroupStatesResponseUnmarshaller
    {
        public static ListRealtimeSkillGroupStatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRealtimeSkillGroupStatesResponse listRealtimeSkillGroupStatesResponse = new ListRealtimeSkillGroupStatesResponse();

			listRealtimeSkillGroupStatesResponse.HttpResponse = _ctx.HttpResponse;
			listRealtimeSkillGroupStatesResponse.Code = _ctx.StringValue("ListRealtimeSkillGroupStates.Code");
			listRealtimeSkillGroupStatesResponse.HttpStatusCode = _ctx.IntegerValue("ListRealtimeSkillGroupStates.HttpStatusCode");
			listRealtimeSkillGroupStatesResponse.Message = _ctx.StringValue("ListRealtimeSkillGroupStates.Message");
			listRealtimeSkillGroupStatesResponse.RequestId = _ctx.StringValue("ListRealtimeSkillGroupStates.RequestId");

			ListRealtimeSkillGroupStatesResponse.ListRealtimeSkillGroupStates_Data data = new ListRealtimeSkillGroupStatesResponse.ListRealtimeSkillGroupStates_Data();
			data.PageNumber = _ctx.IntegerValue("ListRealtimeSkillGroupStates.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListRealtimeSkillGroupStates.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListRealtimeSkillGroupStates.Data.TotalCount");

			List<ListRealtimeSkillGroupStatesResponse.ListRealtimeSkillGroupStates_Data.ListRealtimeSkillGroupStates_SkillGroupState> data_list = new List<ListRealtimeSkillGroupStatesResponse.ListRealtimeSkillGroupStates_Data.ListRealtimeSkillGroupStates_SkillGroupState>();
			for (int i = 0; i < _ctx.Length("ListRealtimeSkillGroupStates.Data.List.Length"); i++) {
				ListRealtimeSkillGroupStatesResponse.ListRealtimeSkillGroupStates_Data.ListRealtimeSkillGroupStates_SkillGroupState skillGroupState = new ListRealtimeSkillGroupStatesResponse.ListRealtimeSkillGroupStates_Data.ListRealtimeSkillGroupStates_SkillGroupState();
				skillGroupState.BreakingAgents = _ctx.LongValue("ListRealtimeSkillGroupStates.Data.List["+ i +"].BreakingAgents");
				skillGroupState.InstanceId = _ctx.StringValue("ListRealtimeSkillGroupStates.Data.List["+ i +"].InstanceId");
				skillGroupState.LoggedInAgents = _ctx.LongValue("ListRealtimeSkillGroupStates.Data.List["+ i +"].LoggedInAgents");
				skillGroupState.LongestWaitingTime = _ctx.LongValue("ListRealtimeSkillGroupStates.Data.List["+ i +"].LongestWaitingTime");
				skillGroupState.ReadyAgents = _ctx.LongValue("ListRealtimeSkillGroupStates.Data.List["+ i +"].ReadyAgents");
				skillGroupState.SkillGroupId = _ctx.StringValue("ListRealtimeSkillGroupStates.Data.List["+ i +"].SkillGroupId");
				skillGroupState.SkillGroupName = _ctx.StringValue("ListRealtimeSkillGroupStates.Data.List["+ i +"].SkillGroupName");
				skillGroupState.TalkingAgents = _ctx.LongValue("ListRealtimeSkillGroupStates.Data.List["+ i +"].TalkingAgents");
				skillGroupState.WaitingCalls = _ctx.LongValue("ListRealtimeSkillGroupStates.Data.List["+ i +"].WaitingCalls");
				skillGroupState.WorkingAgents = _ctx.LongValue("ListRealtimeSkillGroupStates.Data.List["+ i +"].WorkingAgents");

				data_list.Add(skillGroupState);
			}
			data.List = data_list;
			listRealtimeSkillGroupStatesResponse.Data = data;
        
			return listRealtimeSkillGroupStatesResponse;
        }
    }
}
