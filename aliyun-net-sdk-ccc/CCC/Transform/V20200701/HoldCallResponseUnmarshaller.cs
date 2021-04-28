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
    public class HoldCallResponseUnmarshaller
    {
        public static HoldCallResponse Unmarshall(UnmarshallerContext _ctx)
        {
			HoldCallResponse holdCallResponse = new HoldCallResponse();

			holdCallResponse.HttpResponse = _ctx.HttpResponse;
			holdCallResponse.Code = _ctx.StringValue("HoldCall.Code");
			holdCallResponse.HttpStatusCode = _ctx.IntegerValue("HoldCall.HttpStatusCode");
			holdCallResponse.Message = _ctx.StringValue("HoldCall.Message");
			holdCallResponse.RequestId = _ctx.StringValue("HoldCall.RequestId");

			List<string> holdCallResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("HoldCall.Params.Length"); i++) {
				holdCallResponse_params.Add(_ctx.StringValue("HoldCall.Params["+ i +"]"));
			}
			holdCallResponse._Params = holdCallResponse_params;

			HoldCallResponse.HoldCall_Data data = new HoldCallResponse.HoldCall_Data();

			HoldCallResponse.HoldCall_Data.HoldCall_CallContext callContext = new HoldCallResponse.HoldCall_Data.HoldCall_CallContext();
			callContext.CallType = _ctx.StringValue("HoldCall.Data.CallContext.CallType");
			callContext.InstanceId = _ctx.StringValue("HoldCall.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("HoldCall.Data.CallContext.JobId");

			List<HoldCallResponse.HoldCall_Data.HoldCall_CallContext.HoldCall_ChannelContext> callContext_channelContexts = new List<HoldCallResponse.HoldCall_Data.HoldCall_CallContext.HoldCall_ChannelContext>();
			for (int i = 0; i < _ctx.Length("HoldCall.Data.CallContext.ChannelContexts.Length"); i++) {
				HoldCallResponse.HoldCall_Data.HoldCall_CallContext.HoldCall_ChannelContext channelContext = new HoldCallResponse.HoldCall_Data.HoldCall_CallContext.HoldCall_ChannelContext();
				channelContext.AssociatedData = _ctx.StringValue("HoldCall.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.CallType = _ctx.StringValue("HoldCall.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.ChannelId = _ctx.StringValue("HoldCall.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.ChannelState = _ctx.StringValue("HoldCall.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("HoldCall.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.JobId = _ctx.StringValue("HoldCall.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.Originator = _ctx.StringValue("HoldCall.Data.CallContext.ChannelContexts["+ i +"].Originator");
				channelContext.ReleaseInitiator = _ctx.StringValue("HoldCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ReleaseReason = _ctx.StringValue("HoldCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.SkillGroupId = _ctx.StringValue("HoldCall.Data.CallContext.ChannelContexts["+ i +"].SkillGroupId");
				channelContext.Timestamp = _ctx.LongValue("HoldCall.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.UserExtension = _ctx.StringValue("HoldCall.Data.CallContext.ChannelContexts["+ i +"].UserExtension");
				channelContext.UserId = _ctx.StringValue("HoldCall.Data.CallContext.ChannelContexts["+ i +"].UserId");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			HoldCallResponse.HoldCall_Data.HoldCall_UserContext userContext = new HoldCallResponse.HoldCall_Data.HoldCall_UserContext();
			userContext.BreakCode = _ctx.StringValue("HoldCall.Data.UserContext.BreakCode");
			userContext.DeviceId = _ctx.StringValue("HoldCall.Data.UserContext.DeviceId");
			userContext.Extension = _ctx.StringValue("HoldCall.Data.UserContext.Extension");
			userContext.Heartbeat = _ctx.LongValue("HoldCall.Data.UserContext.Heartbeat");
			userContext.InstanceId = _ctx.StringValue("HoldCall.Data.UserContext.InstanceId");
			userContext.JobId = _ctx.StringValue("HoldCall.Data.UserContext.JobId");
			userContext.Mobile = _ctx.StringValue("HoldCall.Data.UserContext.Mobile");
			userContext.OutboundScenario = _ctx.BooleanValue("HoldCall.Data.UserContext.OutboundScenario");
			userContext.Reserved = _ctx.LongValue("HoldCall.Data.UserContext.Reserved");
			userContext.UserId = _ctx.StringValue("HoldCall.Data.UserContext.UserId");
			userContext.UserState = _ctx.StringValue("HoldCall.Data.UserContext.UserState");
			userContext.WorkMode = _ctx.StringValue("HoldCall.Data.UserContext.WorkMode");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("HoldCall.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("HoldCall.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			holdCallResponse.Data = data;
        
			return holdCallResponse;
        }
    }
}
