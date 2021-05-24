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
    public class MuteCallResponseUnmarshaller
    {
        public static MuteCallResponse Unmarshall(UnmarshallerContext _ctx)
        {
			MuteCallResponse muteCallResponse = new MuteCallResponse();

			muteCallResponse.HttpResponse = _ctx.HttpResponse;
			muteCallResponse.Code = _ctx.StringValue("MuteCall.Code");
			muteCallResponse.HttpStatusCode = _ctx.IntegerValue("MuteCall.HttpStatusCode");
			muteCallResponse.Message = _ctx.StringValue("MuteCall.Message");
			muteCallResponse.RequestId = _ctx.StringValue("MuteCall.RequestId");

			List<string> muteCallResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("MuteCall.Params.Length"); i++) {
				muteCallResponse_params.Add(_ctx.StringValue("MuteCall.Params["+ i +"]"));
			}
			muteCallResponse._Params = muteCallResponse_params;

			MuteCallResponse.MuteCall_Data data = new MuteCallResponse.MuteCall_Data();

			MuteCallResponse.MuteCall_Data.MuteCall_CallContext callContext = new MuteCallResponse.MuteCall_Data.MuteCall_CallContext();
			callContext.CallType = _ctx.StringValue("MuteCall.Data.CallContext.CallType");
			callContext.InstanceId = _ctx.StringValue("MuteCall.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("MuteCall.Data.CallContext.JobId");

			List<MuteCallResponse.MuteCall_Data.MuteCall_CallContext.MuteCall_ChannelContext> callContext_channelContexts = new List<MuteCallResponse.MuteCall_Data.MuteCall_CallContext.MuteCall_ChannelContext>();
			for (int i = 0; i < _ctx.Length("MuteCall.Data.CallContext.ChannelContexts.Length"); i++) {
				MuteCallResponse.MuteCall_Data.MuteCall_CallContext.MuteCall_ChannelContext channelContext = new MuteCallResponse.MuteCall_Data.MuteCall_CallContext.MuteCall_ChannelContext();
				channelContext.AssociatedData = _ctx.StringValue("MuteCall.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.CallType = _ctx.StringValue("MuteCall.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.ChannelFlags = _ctx.StringValue("MuteCall.Data.CallContext.ChannelContexts["+ i +"].ChannelFlags");
				channelContext.ChannelId = _ctx.StringValue("MuteCall.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.ChannelState = _ctx.StringValue("MuteCall.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("MuteCall.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.Index = _ctx.IntegerValue("MuteCall.Data.CallContext.ChannelContexts["+ i +"].Index");
				channelContext.JobId = _ctx.StringValue("MuteCall.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.Originator = _ctx.StringValue("MuteCall.Data.CallContext.ChannelContexts["+ i +"].Originator");
				channelContext.ReleaseInitiator = _ctx.StringValue("MuteCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ReleaseReason = _ctx.StringValue("MuteCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.Timestamp = _ctx.LongValue("MuteCall.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.UserExtension = _ctx.StringValue("MuteCall.Data.CallContext.ChannelContexts["+ i +"].UserExtension");
				channelContext.UserId = _ctx.StringValue("MuteCall.Data.CallContext.ChannelContexts["+ i +"].UserId");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			MuteCallResponse.MuteCall_Data.MuteCall_UserContext userContext = new MuteCallResponse.MuteCall_Data.MuteCall_UserContext();
			userContext.BreakCode = _ctx.StringValue("MuteCall.Data.UserContext.BreakCode");
			userContext.DeviceId = _ctx.StringValue("MuteCall.Data.UserContext.DeviceId");
			userContext.Extension = _ctx.StringValue("MuteCall.Data.UserContext.Extension");
			userContext.Heartbeat = _ctx.LongValue("MuteCall.Data.UserContext.Heartbeat");
			userContext.InstanceId = _ctx.StringValue("MuteCall.Data.UserContext.InstanceId");
			userContext.JobId = _ctx.StringValue("MuteCall.Data.UserContext.JobId");
			userContext.Mobile = _ctx.StringValue("MuteCall.Data.UserContext.Mobile");
			userContext.OutboundScenario = _ctx.BooleanValue("MuteCall.Data.UserContext.OutboundScenario");
			userContext.Reserved = _ctx.LongValue("MuteCall.Data.UserContext.Reserved");
			userContext.UserId = _ctx.StringValue("MuteCall.Data.UserContext.UserId");
			userContext.UserState = _ctx.StringValue("MuteCall.Data.UserContext.UserState");
			userContext.WorkMode = _ctx.StringValue("MuteCall.Data.UserContext.WorkMode");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("MuteCall.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("MuteCall.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			muteCallResponse.Data = data;
        
			return muteCallResponse;
        }
    }
}
