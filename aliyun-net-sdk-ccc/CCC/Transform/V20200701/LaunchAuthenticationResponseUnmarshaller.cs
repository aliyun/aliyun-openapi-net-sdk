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
    public class LaunchAuthenticationResponseUnmarshaller
    {
        public static LaunchAuthenticationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			LaunchAuthenticationResponse launchAuthenticationResponse = new LaunchAuthenticationResponse();

			launchAuthenticationResponse.HttpResponse = _ctx.HttpResponse;
			launchAuthenticationResponse.Code = _ctx.StringValue("LaunchAuthentication.Code");
			launchAuthenticationResponse.HttpStatusCode = _ctx.IntegerValue("LaunchAuthentication.HttpStatusCode");
			launchAuthenticationResponse.Message = _ctx.StringValue("LaunchAuthentication.Message");
			launchAuthenticationResponse.RequestId = _ctx.StringValue("LaunchAuthentication.RequestId");

			List<string> launchAuthenticationResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("LaunchAuthentication.Params.Length"); i++) {
				launchAuthenticationResponse_params.Add(_ctx.StringValue("LaunchAuthentication.Params["+ i +"]"));
			}
			launchAuthenticationResponse._Params = launchAuthenticationResponse_params;

			LaunchAuthenticationResponse.LaunchAuthentication_Data data = new LaunchAuthenticationResponse.LaunchAuthentication_Data();

			LaunchAuthenticationResponse.LaunchAuthentication_Data.LaunchAuthentication_CallContext callContext = new LaunchAuthenticationResponse.LaunchAuthentication_Data.LaunchAuthentication_CallContext();
			callContext.CallType = _ctx.StringValue("LaunchAuthentication.Data.CallContext.CallType");
			callContext.InstanceId = _ctx.StringValue("LaunchAuthentication.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("LaunchAuthentication.Data.CallContext.JobId");

			List<LaunchAuthenticationResponse.LaunchAuthentication_Data.LaunchAuthentication_CallContext.LaunchAuthentication_ChannelContext> callContext_channelContexts = new List<LaunchAuthenticationResponse.LaunchAuthentication_Data.LaunchAuthentication_CallContext.LaunchAuthentication_ChannelContext>();
			for (int i = 0; i < _ctx.Length("LaunchAuthentication.Data.CallContext.ChannelContexts.Length"); i++) {
				LaunchAuthenticationResponse.LaunchAuthentication_Data.LaunchAuthentication_CallContext.LaunchAuthentication_ChannelContext channelContext = new LaunchAuthenticationResponse.LaunchAuthentication_Data.LaunchAuthentication_CallContext.LaunchAuthentication_ChannelContext();
				channelContext.AssociatedData = _ctx.StringValue("LaunchAuthentication.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.CallType = _ctx.StringValue("LaunchAuthentication.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.ChannelFlags = _ctx.StringValue("LaunchAuthentication.Data.CallContext.ChannelContexts["+ i +"].ChannelFlags");
				channelContext.ChannelId = _ctx.StringValue("LaunchAuthentication.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.ChannelState = _ctx.StringValue("LaunchAuthentication.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("LaunchAuthentication.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.Index = _ctx.IntegerValue("LaunchAuthentication.Data.CallContext.ChannelContexts["+ i +"].Index");
				channelContext.JobId = _ctx.StringValue("LaunchAuthentication.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.Originator = _ctx.StringValue("LaunchAuthentication.Data.CallContext.ChannelContexts["+ i +"].Originator");
				channelContext.ReleaseInitiator = _ctx.StringValue("LaunchAuthentication.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ReleaseReason = _ctx.StringValue("LaunchAuthentication.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.SkillGroupId = _ctx.StringValue("LaunchAuthentication.Data.CallContext.ChannelContexts["+ i +"].SkillGroupId");
				channelContext.Timestamp = _ctx.LongValue("LaunchAuthentication.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.UserExtension = _ctx.StringValue("LaunchAuthentication.Data.CallContext.ChannelContexts["+ i +"].UserExtension");
				channelContext.UserId = _ctx.StringValue("LaunchAuthentication.Data.CallContext.ChannelContexts["+ i +"].UserId");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			LaunchAuthenticationResponse.LaunchAuthentication_Data.LaunchAuthentication_UserContext userContext = new LaunchAuthenticationResponse.LaunchAuthentication_Data.LaunchAuthentication_UserContext();
			userContext.BreakCode = _ctx.StringValue("LaunchAuthentication.Data.UserContext.BreakCode");
			userContext.DeviceId = _ctx.StringValue("LaunchAuthentication.Data.UserContext.DeviceId");
			userContext.Extension = _ctx.StringValue("LaunchAuthentication.Data.UserContext.Extension");
			userContext.Heartbeat = _ctx.LongValue("LaunchAuthentication.Data.UserContext.Heartbeat");
			userContext.InstanceId = _ctx.StringValue("LaunchAuthentication.Data.UserContext.InstanceId");
			userContext.JobId = _ctx.StringValue("LaunchAuthentication.Data.UserContext.JobId");
			userContext.Mobile = _ctx.StringValue("LaunchAuthentication.Data.UserContext.Mobile");
			userContext.OutboundScenario = _ctx.BooleanValue("LaunchAuthentication.Data.UserContext.OutboundScenario");
			userContext.Reserved = _ctx.LongValue("LaunchAuthentication.Data.UserContext.Reserved");
			userContext.UserId = _ctx.StringValue("LaunchAuthentication.Data.UserContext.UserId");
			userContext.UserState = _ctx.StringValue("LaunchAuthentication.Data.UserContext.UserState");
			userContext.WorkMode = _ctx.StringValue("LaunchAuthentication.Data.UserContext.WorkMode");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("LaunchAuthentication.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("LaunchAuthentication.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			launchAuthenticationResponse.Data = data;
        
			return launchAuthenticationResponse;
        }
    }
}
