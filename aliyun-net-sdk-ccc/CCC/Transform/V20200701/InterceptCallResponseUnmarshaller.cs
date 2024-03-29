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
    public class InterceptCallResponseUnmarshaller
    {
        public static InterceptCallResponse Unmarshall(UnmarshallerContext _ctx)
        {
			InterceptCallResponse interceptCallResponse = new InterceptCallResponse();

			interceptCallResponse.HttpResponse = _ctx.HttpResponse;
			interceptCallResponse.Code = _ctx.StringValue("InterceptCall.Code");
			interceptCallResponse.HttpStatusCode = _ctx.IntegerValue("InterceptCall.HttpStatusCode");
			interceptCallResponse.Message = _ctx.StringValue("InterceptCall.Message");
			interceptCallResponse.RequestId = _ctx.StringValue("InterceptCall.RequestId");

			List<string> interceptCallResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("InterceptCall.Params.Length"); i++) {
				interceptCallResponse_params.Add(_ctx.StringValue("InterceptCall.Params["+ i +"]"));
			}
			interceptCallResponse._Params = interceptCallResponse_params;

			InterceptCallResponse.InterceptCall_Data data = new InterceptCallResponse.InterceptCall_Data();

			InterceptCallResponse.InterceptCall_Data.InterceptCall_CallContext callContext = new InterceptCallResponse.InterceptCall_Data.InterceptCall_CallContext();
			callContext.CallType = _ctx.StringValue("InterceptCall.Data.CallContext.CallType");
			callContext.InstanceId = _ctx.StringValue("InterceptCall.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("InterceptCall.Data.CallContext.JobId");

			List<InterceptCallResponse.InterceptCall_Data.InterceptCall_CallContext.InterceptCall_ChannelContext> callContext_channelContexts = new List<InterceptCallResponse.InterceptCall_Data.InterceptCall_CallContext.InterceptCall_ChannelContext>();
			for (int i = 0; i < _ctx.Length("InterceptCall.Data.CallContext.ChannelContexts.Length"); i++) {
				InterceptCallResponse.InterceptCall_Data.InterceptCall_CallContext.InterceptCall_ChannelContext channelContext = new InterceptCallResponse.InterceptCall_Data.InterceptCall_CallContext.InterceptCall_ChannelContext();
				channelContext.Index = _ctx.IntegerValue("InterceptCall.Data.CallContext.ChannelContexts["+ i +"].Index");
				channelContext.ReleaseInitiator = _ctx.StringValue("InterceptCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ChannelState = _ctx.StringValue("InterceptCall.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("InterceptCall.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.UserId = _ctx.StringValue("InterceptCall.Data.CallContext.ChannelContexts["+ i +"].UserId");
				channelContext.ChannelFlags = _ctx.StringValue("InterceptCall.Data.CallContext.ChannelContexts["+ i +"].ChannelFlags");
				channelContext.SkillGroupId = _ctx.StringValue("InterceptCall.Data.CallContext.ChannelContexts["+ i +"].SkillGroupId");
				channelContext.Timestamp = _ctx.LongValue("InterceptCall.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.AssociatedData = _ctx.StringValue("InterceptCall.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.ReleaseReason = _ctx.StringValue("InterceptCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.CallType = _ctx.StringValue("InterceptCall.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.JobId = _ctx.StringValue("InterceptCall.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.ChannelId = _ctx.StringValue("InterceptCall.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.UserExtension = _ctx.StringValue("InterceptCall.Data.CallContext.ChannelContexts["+ i +"].UserExtension");
				channelContext.Originator = _ctx.StringValue("InterceptCall.Data.CallContext.ChannelContexts["+ i +"].Originator");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			InterceptCallResponse.InterceptCall_Data.InterceptCall_UserContext userContext = new InterceptCallResponse.InterceptCall_Data.InterceptCall_UserContext();
			userContext.Extension = _ctx.StringValue("InterceptCall.Data.UserContext.Extension");
			userContext.Heartbeat = _ctx.LongValue("InterceptCall.Data.UserContext.Heartbeat");
			userContext.WorkMode = _ctx.StringValue("InterceptCall.Data.UserContext.WorkMode");
			userContext.DeviceId = _ctx.StringValue("InterceptCall.Data.UserContext.DeviceId");
			userContext.UserId = _ctx.StringValue("InterceptCall.Data.UserContext.UserId");
			userContext.Reserved = _ctx.LongValue("InterceptCall.Data.UserContext.Reserved");
			userContext.BreakCode = _ctx.StringValue("InterceptCall.Data.UserContext.BreakCode");
			userContext.InstanceId = _ctx.StringValue("InterceptCall.Data.UserContext.InstanceId");
			userContext.OutboundScenario = _ctx.BooleanValue("InterceptCall.Data.UserContext.OutboundScenario");
			userContext.Mobile = _ctx.StringValue("InterceptCall.Data.UserContext.Mobile");
			userContext.JobId = _ctx.StringValue("InterceptCall.Data.UserContext.JobId");
			userContext.UserState = _ctx.StringValue("InterceptCall.Data.UserContext.UserState");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("InterceptCall.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("InterceptCall.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			interceptCallResponse.Data = data;
        
			return interceptCallResponse;
        }
    }
}
