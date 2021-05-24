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
    public class GetRealtimeInstanceStatesResponseUnmarshaller
    {
        public static GetRealtimeInstanceStatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRealtimeInstanceStatesResponse getRealtimeInstanceStatesResponse = new GetRealtimeInstanceStatesResponse();

			getRealtimeInstanceStatesResponse.HttpResponse = _ctx.HttpResponse;
			getRealtimeInstanceStatesResponse.Code = _ctx.StringValue("GetRealtimeInstanceStates.Code");
			getRealtimeInstanceStatesResponse.HttpStatusCode = _ctx.IntegerValue("GetRealtimeInstanceStates.HttpStatusCode");
			getRealtimeInstanceStatesResponse.Message = _ctx.StringValue("GetRealtimeInstanceStates.Message");
			getRealtimeInstanceStatesResponse.RequestId = _ctx.StringValue("GetRealtimeInstanceStates.RequestId");

			GetRealtimeInstanceStatesResponse.GetRealtimeInstanceStates_Data data = new GetRealtimeInstanceStatesResponse.GetRealtimeInstanceStates_Data();
			data.BreakingAgents = _ctx.LongValue("GetRealtimeInstanceStates.Data.BreakingAgents");
			data.InstanceId = _ctx.StringValue("GetRealtimeInstanceStates.Data.InstanceId");
			data.InteractiveCalls = _ctx.LongValue("GetRealtimeInstanceStates.Data.InteractiveCalls");
			data.LoggedInAgents = _ctx.LongValue("GetRealtimeInstanceStates.Data.LoggedInAgents");
			data.LongestCall = _ctx.LongValue("GetRealtimeInstanceStates.Data.LongestCall");
			data.ReadyAgents = _ctx.LongValue("GetRealtimeInstanceStates.Data.ReadyAgents");
			data.TalkingAgents = _ctx.LongValue("GetRealtimeInstanceStates.Data.TalkingAgents");
			data.TotalAgents = _ctx.LongValue("GetRealtimeInstanceStates.Data.TotalAgents");
			data.WaitingCalls = _ctx.LongValue("GetRealtimeInstanceStates.Data.WaitingCalls");
			data.WorkingAgents = _ctx.LongValue("GetRealtimeInstanceStates.Data.WorkingAgents");
			getRealtimeInstanceStatesResponse.Data = data;
        
			return getRealtimeInstanceStatesResponse;
        }
    }
}
