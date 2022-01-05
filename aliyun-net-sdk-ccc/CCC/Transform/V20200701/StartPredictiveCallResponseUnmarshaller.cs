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
    public class StartPredictiveCallResponseUnmarshaller
    {
        public static StartPredictiveCallResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StartPredictiveCallResponse startPredictiveCallResponse = new StartPredictiveCallResponse();

			startPredictiveCallResponse.HttpResponse = _ctx.HttpResponse;
			startPredictiveCallResponse.Code = _ctx.StringValue("StartPredictiveCall.Code");
			startPredictiveCallResponse.HttpStatusCode = _ctx.IntegerValue("StartPredictiveCall.HttpStatusCode");
			startPredictiveCallResponse.Message = _ctx.StringValue("StartPredictiveCall.Message");
			startPredictiveCallResponse.RequestId = _ctx.StringValue("StartPredictiveCall.RequestId");

			List<string> startPredictiveCallResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("StartPredictiveCall.Params.Length"); i++) {
				startPredictiveCallResponse_params.Add(_ctx.StringValue("StartPredictiveCall.Params["+ i +"]"));
			}
			startPredictiveCallResponse._Params = startPredictiveCallResponse_params;

			StartPredictiveCallResponse.StartPredictiveCall_Data data = new StartPredictiveCallResponse.StartPredictiveCall_Data();

			StartPredictiveCallResponse.StartPredictiveCall_Data.StartPredictiveCall_CallContext callContext = new StartPredictiveCallResponse.StartPredictiveCall_Data.StartPredictiveCall_CallContext();
			callContext.CallType = _ctx.StringValue("StartPredictiveCall.Data.CallContext.CallType");
			callContext.InstanceId = _ctx.StringValue("StartPredictiveCall.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("StartPredictiveCall.Data.CallContext.JobId");

			List<StartPredictiveCallResponse.StartPredictiveCall_Data.StartPredictiveCall_CallContext.StartPredictiveCall_ChannelContext> callContext_channelContexts = new List<StartPredictiveCallResponse.StartPredictiveCall_Data.StartPredictiveCall_CallContext.StartPredictiveCall_ChannelContext>();
			for (int i = 0; i < _ctx.Length("StartPredictiveCall.Data.CallContext.ChannelContexts.Length"); i++) {
				StartPredictiveCallResponse.StartPredictiveCall_Data.StartPredictiveCall_CallContext.StartPredictiveCall_ChannelContext channelContext = new StartPredictiveCallResponse.StartPredictiveCall_Data.StartPredictiveCall_CallContext.StartPredictiveCall_ChannelContext();
				channelContext.ReleaseInitiator = _ctx.StringValue("StartPredictiveCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ChannelState = _ctx.StringValue("StartPredictiveCall.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("StartPredictiveCall.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.UserId = _ctx.StringValue("StartPredictiveCall.Data.CallContext.ChannelContexts["+ i +"].UserId");
				channelContext.ChannelFlags = _ctx.StringValue("StartPredictiveCall.Data.CallContext.ChannelContexts["+ i +"].ChannelFlags");
				channelContext.Timestamp = _ctx.LongValue("StartPredictiveCall.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.AssociatedData = _ctx.StringValue("StartPredictiveCall.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.ReleaseReason = _ctx.StringValue("StartPredictiveCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.CallType = _ctx.StringValue("StartPredictiveCall.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.JobId = _ctx.StringValue("StartPredictiveCall.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.ChannelId = _ctx.StringValue("StartPredictiveCall.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.Originator = _ctx.StringValue("StartPredictiveCall.Data.CallContext.ChannelContexts["+ i +"].Originator");
				channelContext.UserExtension = _ctx.StringValue("StartPredictiveCall.Data.CallContext.ChannelContexts["+ i +"].UserExtension");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			StartPredictiveCallResponse.StartPredictiveCall_Data.StartPredictiveCall_UserContext userContext = new StartPredictiveCallResponse.StartPredictiveCall_Data.StartPredictiveCall_UserContext();
			userContext.Extension = _ctx.StringValue("StartPredictiveCall.Data.UserContext.Extension");
			userContext.Heartbeat = _ctx.LongValue("StartPredictiveCall.Data.UserContext.Heartbeat");
			userContext.WorkMode = _ctx.StringValue("StartPredictiveCall.Data.UserContext.WorkMode");
			userContext.DeviceId = _ctx.StringValue("StartPredictiveCall.Data.UserContext.DeviceId");
			userContext.UserId = _ctx.StringValue("StartPredictiveCall.Data.UserContext.UserId");
			userContext.Reserved = _ctx.LongValue("StartPredictiveCall.Data.UserContext.Reserved");
			userContext.BreakCode = _ctx.StringValue("StartPredictiveCall.Data.UserContext.BreakCode");
			userContext.InstanceId = _ctx.StringValue("StartPredictiveCall.Data.UserContext.InstanceId");
			userContext.OutboundScenario = _ctx.BooleanValue("StartPredictiveCall.Data.UserContext.OutboundScenario");
			userContext.DeviceState = _ctx.StringValue("StartPredictiveCall.Data.UserContext.DeviceState");
			userContext.Mobile = _ctx.StringValue("StartPredictiveCall.Data.UserContext.Mobile");
			userContext.JobId = _ctx.StringValue("StartPredictiveCall.Data.UserContext.JobId");
			userContext.UserState = _ctx.StringValue("StartPredictiveCall.Data.UserContext.UserState");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("StartPredictiveCall.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("StartPredictiveCall.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			startPredictiveCallResponse.Data = data;
        
			return startPredictiveCallResponse;
        }
    }
}
