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
    public class ListAgentStatesResponseUnmarshaller
    {
        public static ListAgentStatesResponse Unmarshall(UnmarshallerContext context)
        {
			ListAgentStatesResponse listAgentStatesResponse = new ListAgentStatesResponse();

			listAgentStatesResponse.HttpResponse = context.HttpResponse;
			listAgentStatesResponse.RequestId = context.StringValue("ListAgentStates.RequestId");
			listAgentStatesResponse.Success = context.BooleanValue("ListAgentStates.Success");
			listAgentStatesResponse.Code = context.StringValue("ListAgentStates.Code");
			listAgentStatesResponse.Message = context.StringValue("ListAgentStates.Message");
			listAgentStatesResponse.HttpStatusCode = context.IntegerValue("ListAgentStates.HttpStatusCode");

			ListAgentStatesResponse.ListAgentStates_Data data = new ListAgentStatesResponse.ListAgentStates_Data();
			data.TotalCount = context.IntegerValue("ListAgentStates.Data.TotalCount");
			data.PageNumber = context.IntegerValue("ListAgentStates.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListAgentStates.Data.PageSize");

			List<ListAgentStatesResponse.ListAgentStates_Data.ListAgentStates_RealTimeAgentState> data_list = new List<ListAgentStatesResponse.ListAgentStates_Data.ListAgentStates_RealTimeAgentState>();
			for (int i = 0; i < context.Length("ListAgentStates.Data.List.Length"); i++) {
				ListAgentStatesResponse.ListAgentStates_Data.ListAgentStates_RealTimeAgentState realTimeAgentState = new ListAgentStatesResponse.ListAgentStates_Data.ListAgentStates_RealTimeAgentState();
				realTimeAgentState.InstanceId = context.StringValue("ListAgentStates.Data.List["+ i +"].InstanceId");
				realTimeAgentState.AgentId = context.StringValue("ListAgentStates.Data.List["+ i +"].AgentId");
				realTimeAgentState.LoginName = context.StringValue("ListAgentStates.Data.List["+ i +"].LoginName");
				realTimeAgentState.AgentName = context.StringValue("ListAgentStates.Data.List["+ i +"].AgentName");
				realTimeAgentState.State = context.StringValue("ListAgentStates.Data.List["+ i +"].State");
				realTimeAgentState.Dn = context.StringValue("ListAgentStates.Data.List["+ i +"].Dn");
				realTimeAgentState.StateDuration = context.StringValue("ListAgentStates.Data.List["+ i +"].StateDuration");

				data_list.Add(realTimeAgentState);
			}
			data.List = data_list;
			listAgentStatesResponse.Data = data;
        
			return listAgentStatesResponse;
        }
    }
}
