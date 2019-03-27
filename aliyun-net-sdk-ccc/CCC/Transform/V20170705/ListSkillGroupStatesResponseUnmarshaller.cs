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
    public class ListSkillGroupStatesResponseUnmarshaller
    {
        public static ListSkillGroupStatesResponse Unmarshall(UnmarshallerContext context)
        {
			ListSkillGroupStatesResponse listSkillGroupStatesResponse = new ListSkillGroupStatesResponse();

			listSkillGroupStatesResponse.HttpResponse = context.HttpResponse;
			listSkillGroupStatesResponse.RequestId = context.StringValue("ListSkillGroupStates.RequestId");
			listSkillGroupStatesResponse.Success = context.BooleanValue("ListSkillGroupStates.Success");
			listSkillGroupStatesResponse.Code = context.StringValue("ListSkillGroupStates.Code");
			listSkillGroupStatesResponse.Message = context.StringValue("ListSkillGroupStates.Message");
			listSkillGroupStatesResponse.HttpStatusCode = context.IntegerValue("ListSkillGroupStates.HttpStatusCode");

			ListSkillGroupStatesResponse.ListSkillGroupStates_Data data = new ListSkillGroupStatesResponse.ListSkillGroupStates_Data();
			data.TotalCount = context.IntegerValue("ListSkillGroupStates.Data.TotalCount");
			data.PageNumber = context.IntegerValue("ListSkillGroupStates.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListSkillGroupStates.Data.PageSize");

			List<ListSkillGroupStatesResponse.ListSkillGroupStates_Data.ListSkillGroupStates_RealTimeSkillGroupState> data_list = new List<ListSkillGroupStatesResponse.ListSkillGroupStates_Data.ListSkillGroupStates_RealTimeSkillGroupState>();
			for (int i = 0; i < context.Length("ListSkillGroupStates.Data.List.Length"); i++) {
				ListSkillGroupStatesResponse.ListSkillGroupStates_Data.ListSkillGroupStates_RealTimeSkillGroupState realTimeSkillGroupState = new ListSkillGroupStatesResponse.ListSkillGroupStates_Data.ListSkillGroupStates_RealTimeSkillGroupState();
				realTimeSkillGroupState.InstanceId = context.StringValue("ListSkillGroupStates.Data.List["+ i +"].InstanceId");
				realTimeSkillGroupState.SkillGroupId = context.StringValue("ListSkillGroupStates.Data.List["+ i +"].SkillGroupId");
				realTimeSkillGroupState.SkillGroupName = context.StringValue("ListSkillGroupStates.Data.List["+ i +"].SkillGroupName");
				realTimeSkillGroupState.WaitingCalls = context.LongValue("ListSkillGroupStates.Data.List["+ i +"].WaitingCalls");
				realTimeSkillGroupState.LongestCall = context.LongValue("ListSkillGroupStates.Data.List["+ i +"].LongestCall");
				realTimeSkillGroupState.LoggedInAgents = context.LongValue("ListSkillGroupStates.Data.List["+ i +"].LoggedInAgents");
				realTimeSkillGroupState.ReadyAgents = context.LongValue("ListSkillGroupStates.Data.List["+ i +"].ReadyAgents");
				realTimeSkillGroupState.BreakingAgents = context.LongValue("ListSkillGroupStates.Data.List["+ i +"].BreakingAgents");
				realTimeSkillGroupState.TalkingAgents = context.LongValue("ListSkillGroupStates.Data.List["+ i +"].TalkingAgents");
				realTimeSkillGroupState.WorkingAgents = context.LongValue("ListSkillGroupStates.Data.List["+ i +"].WorkingAgents");

				data_list.Add(realTimeSkillGroupState);
			}
			data.List = data_list;
			listSkillGroupStatesResponse.Data = data;
        
			return listSkillGroupStatesResponse;
        }
    }
}
