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
    public class ListSkillGroupStatesResponseUnmarshaller
    {
        public static ListSkillGroupStatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSkillGroupStatesResponse listSkillGroupStatesResponse = new ListSkillGroupStatesResponse();

			listSkillGroupStatesResponse.HttpResponse = _ctx.HttpResponse;
			listSkillGroupStatesResponse.HttpStatusCode = _ctx.IntegerValue("ListSkillGroupStates.HttpStatusCode");
			listSkillGroupStatesResponse.Code = _ctx.StringValue("ListSkillGroupStates.Code");
			listSkillGroupStatesResponse.Message = _ctx.StringValue("ListSkillGroupStates.Message");
			listSkillGroupStatesResponse.RequestId = _ctx.StringValue("ListSkillGroupStates.RequestId");
			listSkillGroupStatesResponse.Success = _ctx.BooleanValue("ListSkillGroupStates.Success");

			ListSkillGroupStatesResponse.ListSkillGroupStates_Data data = new ListSkillGroupStatesResponse.ListSkillGroupStates_Data();
			data.PageNumber = _ctx.IntegerValue("ListSkillGroupStates.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListSkillGroupStates.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListSkillGroupStates.Data.TotalCount");

			List<ListSkillGroupStatesResponse.ListSkillGroupStates_Data.ListSkillGroupStates_RealTimeSkillGroupState> data_list = new List<ListSkillGroupStatesResponse.ListSkillGroupStates_Data.ListSkillGroupStates_RealTimeSkillGroupState>();
			for (int i = 0; i < _ctx.Length("ListSkillGroupStates.Data.List.Length"); i++) {
				ListSkillGroupStatesResponse.ListSkillGroupStates_Data.ListSkillGroupStates_RealTimeSkillGroupState realTimeSkillGroupState = new ListSkillGroupStatesResponse.ListSkillGroupStates_Data.ListSkillGroupStates_RealTimeSkillGroupState();
				realTimeSkillGroupState.WorkingAgents = _ctx.LongValue("ListSkillGroupStates.Data.List["+ i +"].WorkingAgents");
				realTimeSkillGroupState.LoggedInAgents = _ctx.LongValue("ListSkillGroupStates.Data.List["+ i +"].LoggedInAgents");
				realTimeSkillGroupState.BreakingAgents = _ctx.LongValue("ListSkillGroupStates.Data.List["+ i +"].BreakingAgents");
				realTimeSkillGroupState.LongestCall = _ctx.LongValue("ListSkillGroupStates.Data.List["+ i +"].LongestCall");
				realTimeSkillGroupState.WaitingCalls = _ctx.LongValue("ListSkillGroupStates.Data.List["+ i +"].WaitingCalls");
				realTimeSkillGroupState.TalkingAgents = _ctx.LongValue("ListSkillGroupStates.Data.List["+ i +"].TalkingAgents");
				realTimeSkillGroupState.SkillGroupName = _ctx.StringValue("ListSkillGroupStates.Data.List["+ i +"].SkillGroupName");
				realTimeSkillGroupState.SkillGroupId = _ctx.StringValue("ListSkillGroupStates.Data.List["+ i +"].SkillGroupId");
				realTimeSkillGroupState.ReadyAgents = _ctx.LongValue("ListSkillGroupStates.Data.List["+ i +"].ReadyAgents");
				realTimeSkillGroupState.InstanceId = _ctx.StringValue("ListSkillGroupStates.Data.List["+ i +"].InstanceId");

				data_list.Add(realTimeSkillGroupState);
			}
			data.List = data_list;
			listSkillGroupStatesResponse.Data = data;
        
			return listSkillGroupStatesResponse;
        }
    }
}
