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
    public class SendDtmfSignalingResponseUnmarshaller
    {
        public static SendDtmfSignalingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SendDtmfSignalingResponse sendDtmfSignalingResponse = new SendDtmfSignalingResponse();

			sendDtmfSignalingResponse.HttpResponse = _ctx.HttpResponse;
			sendDtmfSignalingResponse.Code = _ctx.StringValue("SendDtmfSignaling.Code");
			sendDtmfSignalingResponse.HttpStatusCode = _ctx.IntegerValue("SendDtmfSignaling.HttpStatusCode");
			sendDtmfSignalingResponse.Message = _ctx.StringValue("SendDtmfSignaling.Message");
			sendDtmfSignalingResponse.RequestId = _ctx.StringValue("SendDtmfSignaling.RequestId");

			List<string> sendDtmfSignalingResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("SendDtmfSignaling.Params.Length"); i++) {
				sendDtmfSignalingResponse_params.Add(_ctx.StringValue("SendDtmfSignaling.Params["+ i +"]"));
			}
			sendDtmfSignalingResponse._Params = sendDtmfSignalingResponse_params;

			SendDtmfSignalingResponse.SendDtmfSignaling_Data data = new SendDtmfSignalingResponse.SendDtmfSignaling_Data();

			SendDtmfSignalingResponse.SendDtmfSignaling_Data.SendDtmfSignaling_CallContext callContext = new SendDtmfSignalingResponse.SendDtmfSignaling_Data.SendDtmfSignaling_CallContext();
			callContext.CallType = _ctx.StringValue("SendDtmfSignaling.Data.CallContext.CallType");
			callContext.InstanceId = _ctx.StringValue("SendDtmfSignaling.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("SendDtmfSignaling.Data.CallContext.JobId");

			List<SendDtmfSignalingResponse.SendDtmfSignaling_Data.SendDtmfSignaling_CallContext.SendDtmfSignaling_ChannelContext> callContext_channelContexts = new List<SendDtmfSignalingResponse.SendDtmfSignaling_Data.SendDtmfSignaling_CallContext.SendDtmfSignaling_ChannelContext>();
			for (int i = 0; i < _ctx.Length("SendDtmfSignaling.Data.CallContext.ChannelContexts.Length"); i++) {
				SendDtmfSignalingResponse.SendDtmfSignaling_Data.SendDtmfSignaling_CallContext.SendDtmfSignaling_ChannelContext channelContext = new SendDtmfSignalingResponse.SendDtmfSignaling_Data.SendDtmfSignaling_CallContext.SendDtmfSignaling_ChannelContext();
				channelContext.AssociatedData = _ctx.StringValue("SendDtmfSignaling.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.CallType = _ctx.StringValue("SendDtmfSignaling.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.ChannelFlags = _ctx.StringValue("SendDtmfSignaling.Data.CallContext.ChannelContexts["+ i +"].ChannelFlags");
				channelContext.ChannelId = _ctx.StringValue("SendDtmfSignaling.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.ChannelState = _ctx.StringValue("SendDtmfSignaling.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("SendDtmfSignaling.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.Index = _ctx.IntegerValue("SendDtmfSignaling.Data.CallContext.ChannelContexts["+ i +"].Index");
				channelContext.JobId = _ctx.StringValue("SendDtmfSignaling.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.Originator = _ctx.StringValue("SendDtmfSignaling.Data.CallContext.ChannelContexts["+ i +"].Originator");
				channelContext.ReleaseInitiator = _ctx.StringValue("SendDtmfSignaling.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ReleaseReason = _ctx.StringValue("SendDtmfSignaling.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.SkillGroupId = _ctx.StringValue("SendDtmfSignaling.Data.CallContext.ChannelContexts["+ i +"].SkillGroupId");
				channelContext.Timestamp = _ctx.LongValue("SendDtmfSignaling.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.UserExtension = _ctx.StringValue("SendDtmfSignaling.Data.CallContext.ChannelContexts["+ i +"].UserExtension");
				channelContext.UserId = _ctx.StringValue("SendDtmfSignaling.Data.CallContext.ChannelContexts["+ i +"].UserId");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			SendDtmfSignalingResponse.SendDtmfSignaling_Data.SendDtmfSignaling_UserContext userContext = new SendDtmfSignalingResponse.SendDtmfSignaling_Data.SendDtmfSignaling_UserContext();
			userContext.BreakCode = _ctx.StringValue("SendDtmfSignaling.Data.UserContext.BreakCode");
			userContext.DeviceId = _ctx.StringValue("SendDtmfSignaling.Data.UserContext.DeviceId");
			userContext.Extension = _ctx.StringValue("SendDtmfSignaling.Data.UserContext.Extension");
			userContext.Heartbeat = _ctx.LongValue("SendDtmfSignaling.Data.UserContext.Heartbeat");
			userContext.InstanceId = _ctx.StringValue("SendDtmfSignaling.Data.UserContext.InstanceId");
			userContext.JobId = _ctx.StringValue("SendDtmfSignaling.Data.UserContext.JobId");
			userContext.Mobile = _ctx.StringValue("SendDtmfSignaling.Data.UserContext.Mobile");
			userContext.OutboundScenario = _ctx.BooleanValue("SendDtmfSignaling.Data.UserContext.OutboundScenario");
			userContext.Reserved = _ctx.LongValue("SendDtmfSignaling.Data.UserContext.Reserved");
			userContext.UserId = _ctx.StringValue("SendDtmfSignaling.Data.UserContext.UserId");
			userContext.UserState = _ctx.StringValue("SendDtmfSignaling.Data.UserContext.UserState");
			userContext.WorkMode = _ctx.StringValue("SendDtmfSignaling.Data.UserContext.WorkMode");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("SendDtmfSignaling.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("SendDtmfSignaling.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			sendDtmfSignalingResponse.Data = data;
        
			return sendDtmfSignalingResponse;
        }
    }
}
