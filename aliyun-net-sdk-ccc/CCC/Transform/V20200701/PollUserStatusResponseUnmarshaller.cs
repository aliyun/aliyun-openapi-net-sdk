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
    public class PollUserStatusResponseUnmarshaller
    {
        public static PollUserStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PollUserStatusResponse pollUserStatusResponse = new PollUserStatusResponse();

			pollUserStatusResponse.HttpResponse = _ctx.HttpResponse;
			pollUserStatusResponse.Code = _ctx.StringValue("PollUserStatus.Code");
			pollUserStatusResponse.HttpStatusCode = _ctx.IntegerValue("PollUserStatus.HttpStatusCode");
			pollUserStatusResponse.Message = _ctx.StringValue("PollUserStatus.Message");
			pollUserStatusResponse.RequestId = _ctx.StringValue("PollUserStatus.RequestId");

			List<string> pollUserStatusResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("PollUserStatus.Params.Length"); i++) {
				pollUserStatusResponse_params.Add(_ctx.StringValue("PollUserStatus.Params["+ i +"]"));
			}
			pollUserStatusResponse._Params = pollUserStatusResponse_params;

			PollUserStatusResponse.PollUserStatus_Data data = new PollUserStatusResponse.PollUserStatus_Data();
			data.ContextId = _ctx.LongValue("PollUserStatus.Data.ContextId");

			PollUserStatusResponse.PollUserStatus_Data.PollUserStatus_CallContext callContext = new PollUserStatusResponse.PollUserStatus_Data.PollUserStatus_CallContext();
			callContext.CallType = _ctx.StringValue("PollUserStatus.Data.CallContext.CallType");
			callContext.InstanceId = _ctx.StringValue("PollUserStatus.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("PollUserStatus.Data.CallContext.JobId");

			List<PollUserStatusResponse.PollUserStatus_Data.PollUserStatus_CallContext.PollUserStatus_ChannelContext> callContext_channelContexts = new List<PollUserStatusResponse.PollUserStatus_Data.PollUserStatus_CallContext.PollUserStatus_ChannelContext>();
			for (int i = 0; i < _ctx.Length("PollUserStatus.Data.CallContext.ChannelContexts.Length"); i++) {
				PollUserStatusResponse.PollUserStatus_Data.PollUserStatus_CallContext.PollUserStatus_ChannelContext channelContext = new PollUserStatusResponse.PollUserStatus_Data.PollUserStatus_CallContext.PollUserStatus_ChannelContext();
				channelContext.Index = _ctx.IntegerValue("PollUserStatus.Data.CallContext.ChannelContexts["+ i +"].Index");
				channelContext.ReleaseInitiator = _ctx.StringValue("PollUserStatus.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ChannelState = _ctx.StringValue("PollUserStatus.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("PollUserStatus.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.UserId = _ctx.StringValue("PollUserStatus.Data.CallContext.ChannelContexts["+ i +"].UserId");
				channelContext.ChannelFlags = _ctx.StringValue("PollUserStatus.Data.CallContext.ChannelContexts["+ i +"].ChannelFlags");
				channelContext.SkillGroupId = _ctx.StringValue("PollUserStatus.Data.CallContext.ChannelContexts["+ i +"].SkillGroupId");
				channelContext.Timestamp = _ctx.LongValue("PollUserStatus.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.AssociatedData = _ctx.StringValue("PollUserStatus.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.ReleaseReason = _ctx.StringValue("PollUserStatus.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.CallType = _ctx.StringValue("PollUserStatus.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.ChannelVariables = _ctx.StringValue("PollUserStatus.Data.CallContext.ChannelContexts["+ i +"].ChannelVariables");
				channelContext.JobId = _ctx.StringValue("PollUserStatus.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.ChannelId = _ctx.StringValue("PollUserStatus.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.UserExtension = _ctx.StringValue("PollUserStatus.Data.CallContext.ChannelContexts["+ i +"].UserExtension");
				channelContext.Originator = _ctx.StringValue("PollUserStatus.Data.CallContext.ChannelContexts["+ i +"].Originator");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			PollUserStatusResponse.PollUserStatus_Data.PollUserStatus_UserContext userContext = new PollUserStatusResponse.PollUserStatus_Data.PollUserStatus_UserContext();
			userContext.Extension = _ctx.StringValue("PollUserStatus.Data.UserContext.Extension");
			userContext.Heartbeat = _ctx.LongValue("PollUserStatus.Data.UserContext.Heartbeat");
			userContext.WorkMode = _ctx.StringValue("PollUserStatus.Data.UserContext.WorkMode");
			userContext.DeviceId = _ctx.StringValue("PollUserStatus.Data.UserContext.DeviceId");
			userContext.UserId = _ctx.StringValue("PollUserStatus.Data.UserContext.UserId");
			userContext.Reserved = _ctx.LongValue("PollUserStatus.Data.UserContext.Reserved");
			userContext.BreakCode = _ctx.StringValue("PollUserStatus.Data.UserContext.BreakCode");
			userContext.InstanceId = _ctx.StringValue("PollUserStatus.Data.UserContext.InstanceId");
			userContext.OutboundScenario = _ctx.BooleanValue("PollUserStatus.Data.UserContext.OutboundScenario");
			userContext.Mobile = _ctx.StringValue("PollUserStatus.Data.UserContext.Mobile");
			userContext.JobId = _ctx.StringValue("PollUserStatus.Data.UserContext.JobId");
			userContext.UserState = _ctx.StringValue("PollUserStatus.Data.UserContext.UserState");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("PollUserStatus.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("PollUserStatus.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			pollUserStatusResponse.Data = data;
        
			return pollUserStatusResponse;
        }
    }
}
