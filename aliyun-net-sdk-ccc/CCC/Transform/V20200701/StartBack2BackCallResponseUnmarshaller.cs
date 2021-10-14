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
    public class StartBack2BackCallResponseUnmarshaller
    {
        public static StartBack2BackCallResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StartBack2BackCallResponse startBack2BackCallResponse = new StartBack2BackCallResponse();

			startBack2BackCallResponse.HttpResponse = _ctx.HttpResponse;
			startBack2BackCallResponse.Code = _ctx.StringValue("StartBack2BackCall.Code");
			startBack2BackCallResponse.HttpStatusCode = _ctx.IntegerValue("StartBack2BackCall.HttpStatusCode");
			startBack2BackCallResponse.Message = _ctx.StringValue("StartBack2BackCall.Message");
			startBack2BackCallResponse.RequestId = _ctx.StringValue("StartBack2BackCall.RequestId");

			List<string> startBack2BackCallResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("StartBack2BackCall.Params.Length"); i++) {
				startBack2BackCallResponse_params.Add(_ctx.StringValue("StartBack2BackCall.Params["+ i +"]"));
			}
			startBack2BackCallResponse._Params = startBack2BackCallResponse_params;

			StartBack2BackCallResponse.StartBack2BackCall_Data data = new StartBack2BackCallResponse.StartBack2BackCall_Data();

			StartBack2BackCallResponse.StartBack2BackCall_Data.StartBack2BackCall_CallContext callContext = new StartBack2BackCallResponse.StartBack2BackCall_Data.StartBack2BackCall_CallContext();
			callContext.CallType = _ctx.StringValue("StartBack2BackCall.Data.CallContext.CallType");
			callContext.InstanceId = _ctx.StringValue("StartBack2BackCall.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("StartBack2BackCall.Data.CallContext.JobId");

			List<StartBack2BackCallResponse.StartBack2BackCall_Data.StartBack2BackCall_CallContext.StartBack2BackCall_ChannelContext> callContext_channelContexts = new List<StartBack2BackCallResponse.StartBack2BackCall_Data.StartBack2BackCall_CallContext.StartBack2BackCall_ChannelContext>();
			for (int i = 0; i < _ctx.Length("StartBack2BackCall.Data.CallContext.ChannelContexts.Length"); i++) {
				StartBack2BackCallResponse.StartBack2BackCall_Data.StartBack2BackCall_CallContext.StartBack2BackCall_ChannelContext channelContext = new StartBack2BackCallResponse.StartBack2BackCall_Data.StartBack2BackCall_CallContext.StartBack2BackCall_ChannelContext();
				channelContext.AssociatedData = _ctx.StringValue("StartBack2BackCall.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.CallType = _ctx.StringValue("StartBack2BackCall.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.ChannelFlags = _ctx.StringValue("StartBack2BackCall.Data.CallContext.ChannelContexts["+ i +"].ChannelFlags");
				channelContext.ChannelId = _ctx.StringValue("StartBack2BackCall.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.ChannelState = _ctx.StringValue("StartBack2BackCall.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("StartBack2BackCall.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.JobId = _ctx.StringValue("StartBack2BackCall.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.Originator = _ctx.StringValue("StartBack2BackCall.Data.CallContext.ChannelContexts["+ i +"].Originator");
				channelContext.ReleaseInitiator = _ctx.StringValue("StartBack2BackCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ReleaseReason = _ctx.StringValue("StartBack2BackCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.Timestamp = _ctx.LongValue("StartBack2BackCall.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.UserExtension = _ctx.StringValue("StartBack2BackCall.Data.CallContext.ChannelContexts["+ i +"].UserExtension");
				channelContext.UserId = _ctx.StringValue("StartBack2BackCall.Data.CallContext.ChannelContexts["+ i +"].UserId");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			StartBack2BackCallResponse.StartBack2BackCall_Data.StartBack2BackCall_UserContext userContext = new StartBack2BackCallResponse.StartBack2BackCall_Data.StartBack2BackCall_UserContext();
			userContext.BreakCode = _ctx.StringValue("StartBack2BackCall.Data.UserContext.BreakCode");
			userContext.DeviceId = _ctx.StringValue("StartBack2BackCall.Data.UserContext.DeviceId");
			userContext.DeviceState = _ctx.StringValue("StartBack2BackCall.Data.UserContext.DeviceState");
			userContext.Extension = _ctx.StringValue("StartBack2BackCall.Data.UserContext.Extension");
			userContext.Heartbeat = _ctx.LongValue("StartBack2BackCall.Data.UserContext.Heartbeat");
			userContext.InstanceId = _ctx.StringValue("StartBack2BackCall.Data.UserContext.InstanceId");
			userContext.JobId = _ctx.StringValue("StartBack2BackCall.Data.UserContext.JobId");
			userContext.Mobile = _ctx.StringValue("StartBack2BackCall.Data.UserContext.Mobile");
			userContext.OutboundScenario = _ctx.BooleanValue("StartBack2BackCall.Data.UserContext.OutboundScenario");
			userContext.Reserved = _ctx.LongValue("StartBack2BackCall.Data.UserContext.Reserved");
			userContext.Uri = _ctx.StringValue("StartBack2BackCall.Data.UserContext.Uri");
			userContext.UserId = _ctx.StringValue("StartBack2BackCall.Data.UserContext.UserId");
			userContext.UserState = _ctx.StringValue("StartBack2BackCall.Data.UserContext.UserState");
			userContext.WorkMode = _ctx.StringValue("StartBack2BackCall.Data.UserContext.WorkMode");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("StartBack2BackCall.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("StartBack2BackCall.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			startBack2BackCallResponse.Data = data;
        
			return startBack2BackCallResponse;
        }
    }
}
