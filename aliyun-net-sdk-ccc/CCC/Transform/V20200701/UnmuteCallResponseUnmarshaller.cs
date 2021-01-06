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
    public class UnmuteCallResponseUnmarshaller
    {
        public static UnmuteCallResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UnmuteCallResponse unmuteCallResponse = new UnmuteCallResponse();

			unmuteCallResponse.HttpResponse = _ctx.HttpResponse;
			unmuteCallResponse.Code = _ctx.StringValue("UnmuteCall.Code");
			unmuteCallResponse.HttpStatusCode = _ctx.IntegerValue("UnmuteCall.HttpStatusCode");
			unmuteCallResponse.Message = _ctx.StringValue("UnmuteCall.Message");
			unmuteCallResponse.RequestId = _ctx.StringValue("UnmuteCall.RequestId");

			List<string> unmuteCallResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("UnmuteCall.Params.Length"); i++) {
				unmuteCallResponse_params.Add(_ctx.StringValue("UnmuteCall.Params["+ i +"]"));
			}
			unmuteCallResponse._Params = unmuteCallResponse_params;

			UnmuteCallResponse.UnmuteCall_Data data = new UnmuteCallResponse.UnmuteCall_Data();

			UnmuteCallResponse.UnmuteCall_Data.UnmuteCall_CallContext callContext = new UnmuteCallResponse.UnmuteCall_Data.UnmuteCall_CallContext();
			callContext.CallType = _ctx.StringValue("UnmuteCall.Data.CallContext.CallType");
			callContext.InstanceId = _ctx.StringValue("UnmuteCall.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("UnmuteCall.Data.CallContext.JobId");

			List<UnmuteCallResponse.UnmuteCall_Data.UnmuteCall_CallContext.UnmuteCall_ChannelContext> callContext_channelContexts = new List<UnmuteCallResponse.UnmuteCall_Data.UnmuteCall_CallContext.UnmuteCall_ChannelContext>();
			for (int i = 0; i < _ctx.Length("UnmuteCall.Data.CallContext.ChannelContexts.Length"); i++) {
				UnmuteCallResponse.UnmuteCall_Data.UnmuteCall_CallContext.UnmuteCall_ChannelContext channelContext = new UnmuteCallResponse.UnmuteCall_Data.UnmuteCall_CallContext.UnmuteCall_ChannelContext();
				channelContext.AssociatedData = _ctx.StringValue("UnmuteCall.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.CallType = _ctx.StringValue("UnmuteCall.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.ChannelFlags = _ctx.StringValue("UnmuteCall.Data.CallContext.ChannelContexts["+ i +"].ChannelFlags");
				channelContext.ChannelId = _ctx.StringValue("UnmuteCall.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.ChannelState = _ctx.StringValue("UnmuteCall.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("UnmuteCall.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.Index = _ctx.IntegerValue("UnmuteCall.Data.CallContext.ChannelContexts["+ i +"].Index");
				channelContext.JobId = _ctx.StringValue("UnmuteCall.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.Originator = _ctx.StringValue("UnmuteCall.Data.CallContext.ChannelContexts["+ i +"].Originator");
				channelContext.ReleaseInitiator = _ctx.StringValue("UnmuteCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ReleaseReason = _ctx.StringValue("UnmuteCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.SkillGroupId = _ctx.StringValue("UnmuteCall.Data.CallContext.ChannelContexts["+ i +"].SkillGroupId");
				channelContext.Timestamp = _ctx.LongValue("UnmuteCall.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.UserExtension = _ctx.StringValue("UnmuteCall.Data.CallContext.ChannelContexts["+ i +"].UserExtension");
				channelContext.UserId = _ctx.StringValue("UnmuteCall.Data.CallContext.ChannelContexts["+ i +"].UserId");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			UnmuteCallResponse.UnmuteCall_Data.UnmuteCall_UserContext userContext = new UnmuteCallResponse.UnmuteCall_Data.UnmuteCall_UserContext();
			userContext.BreakCode = _ctx.StringValue("UnmuteCall.Data.UserContext.BreakCode");
			userContext.DeviceId = _ctx.StringValue("UnmuteCall.Data.UserContext.DeviceId");
			userContext.Extension = _ctx.StringValue("UnmuteCall.Data.UserContext.Extension");
			userContext.Heartbeat = _ctx.LongValue("UnmuteCall.Data.UserContext.Heartbeat");
			userContext.InstanceId = _ctx.StringValue("UnmuteCall.Data.UserContext.InstanceId");
			userContext.JobId = _ctx.StringValue("UnmuteCall.Data.UserContext.JobId");
			userContext.Mobile = _ctx.StringValue("UnmuteCall.Data.UserContext.Mobile");
			userContext.OutboundScenario = _ctx.BooleanValue("UnmuteCall.Data.UserContext.OutboundScenario");
			userContext.UserId = _ctx.StringValue("UnmuteCall.Data.UserContext.UserId");
			userContext.UserState = _ctx.StringValue("UnmuteCall.Data.UserContext.UserState");
			userContext.WorkMode = _ctx.StringValue("UnmuteCall.Data.UserContext.WorkMode");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("UnmuteCall.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("UnmuteCall.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			unmuteCallResponse.Data = data;
        
			return unmuteCallResponse;
        }
    }
}
