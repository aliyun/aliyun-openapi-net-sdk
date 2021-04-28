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
    public class BargeInCallResponseUnmarshaller
    {
        public static BargeInCallResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BargeInCallResponse bargeInCallResponse = new BargeInCallResponse();

			bargeInCallResponse.HttpResponse = _ctx.HttpResponse;
			bargeInCallResponse.Code = _ctx.StringValue("BargeInCall.Code");
			bargeInCallResponse.HttpStatusCode = _ctx.IntegerValue("BargeInCall.HttpStatusCode");
			bargeInCallResponse.Message = _ctx.StringValue("BargeInCall.Message");
			bargeInCallResponse.RequestId = _ctx.StringValue("BargeInCall.RequestId");

			List<string> bargeInCallResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("BargeInCall.Params.Length"); i++) {
				bargeInCallResponse_params.Add(_ctx.StringValue("BargeInCall.Params["+ i +"]"));
			}
			bargeInCallResponse._Params = bargeInCallResponse_params;

			BargeInCallResponse.BargeInCall_Data data = new BargeInCallResponse.BargeInCall_Data();

			BargeInCallResponse.BargeInCall_Data.BargeInCall_CallContext callContext = new BargeInCallResponse.BargeInCall_Data.BargeInCall_CallContext();
			callContext.CallType = _ctx.StringValue("BargeInCall.Data.CallContext.CallType");
			callContext.InstanceId = _ctx.StringValue("BargeInCall.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("BargeInCall.Data.CallContext.JobId");

			List<BargeInCallResponse.BargeInCall_Data.BargeInCall_CallContext.BargeInCall_ChannelContext> callContext_channelContexts = new List<BargeInCallResponse.BargeInCall_Data.BargeInCall_CallContext.BargeInCall_ChannelContext>();
			for (int i = 0; i < _ctx.Length("BargeInCall.Data.CallContext.ChannelContexts.Length"); i++) {
				BargeInCallResponse.BargeInCall_Data.BargeInCall_CallContext.BargeInCall_ChannelContext channelContext = new BargeInCallResponse.BargeInCall_Data.BargeInCall_CallContext.BargeInCall_ChannelContext();
				channelContext.AssociatedData = _ctx.StringValue("BargeInCall.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.CallType = _ctx.StringValue("BargeInCall.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.ChannelFlags = _ctx.StringValue("BargeInCall.Data.CallContext.ChannelContexts["+ i +"].ChannelFlags");
				channelContext.ChannelId = _ctx.StringValue("BargeInCall.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.ChannelState = _ctx.StringValue("BargeInCall.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("BargeInCall.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.Index = _ctx.IntegerValue("BargeInCall.Data.CallContext.ChannelContexts["+ i +"].Index");
				channelContext.JobId = _ctx.StringValue("BargeInCall.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.Originator = _ctx.StringValue("BargeInCall.Data.CallContext.ChannelContexts["+ i +"].Originator");
				channelContext.ReleaseInitiator = _ctx.StringValue("BargeInCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ReleaseReason = _ctx.StringValue("BargeInCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.SkillGroupId = _ctx.StringValue("BargeInCall.Data.CallContext.ChannelContexts["+ i +"].SkillGroupId");
				channelContext.Timestamp = _ctx.LongValue("BargeInCall.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.UserExtension = _ctx.StringValue("BargeInCall.Data.CallContext.ChannelContexts["+ i +"].UserExtension");
				channelContext.UserId = _ctx.StringValue("BargeInCall.Data.CallContext.ChannelContexts["+ i +"].UserId");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			BargeInCallResponse.BargeInCall_Data.BargeInCall_UserContext userContext = new BargeInCallResponse.BargeInCall_Data.BargeInCall_UserContext();
			userContext.BreakCode = _ctx.StringValue("BargeInCall.Data.UserContext.BreakCode");
			userContext.DeviceId = _ctx.StringValue("BargeInCall.Data.UserContext.DeviceId");
			userContext.Extension = _ctx.StringValue("BargeInCall.Data.UserContext.Extension");
			userContext.Heartbeat = _ctx.LongValue("BargeInCall.Data.UserContext.Heartbeat");
			userContext.InstanceId = _ctx.StringValue("BargeInCall.Data.UserContext.InstanceId");
			userContext.JobId = _ctx.StringValue("BargeInCall.Data.UserContext.JobId");
			userContext.Mobile = _ctx.StringValue("BargeInCall.Data.UserContext.Mobile");
			userContext.OutboundScenario = _ctx.BooleanValue("BargeInCall.Data.UserContext.OutboundScenario");
			userContext.Reserved = _ctx.LongValue("BargeInCall.Data.UserContext.Reserved");
			userContext.UserId = _ctx.StringValue("BargeInCall.Data.UserContext.UserId");
			userContext.UserState = _ctx.StringValue("BargeInCall.Data.UserContext.UserState");
			userContext.WorkMode = _ctx.StringValue("BargeInCall.Data.UserContext.WorkMode");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("BargeInCall.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("BargeInCall.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			bargeInCallResponse.Data = data;
        
			return bargeInCallResponse;
        }
    }
}
