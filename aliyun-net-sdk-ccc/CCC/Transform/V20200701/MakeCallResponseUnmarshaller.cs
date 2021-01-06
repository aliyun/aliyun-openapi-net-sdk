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
    public class MakeCallResponseUnmarshaller
    {
        public static MakeCallResponse Unmarshall(UnmarshallerContext _ctx)
        {
			MakeCallResponse makeCallResponse = new MakeCallResponse();

			makeCallResponse.HttpResponse = _ctx.HttpResponse;
			makeCallResponse.Code = _ctx.StringValue("MakeCall.Code");
			makeCallResponse.HttpStatusCode = _ctx.IntegerValue("MakeCall.HttpStatusCode");
			makeCallResponse.Message = _ctx.StringValue("MakeCall.Message");
			makeCallResponse.RequestId = _ctx.StringValue("MakeCall.RequestId");

			List<string> makeCallResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("MakeCall.Params.Length"); i++) {
				makeCallResponse_params.Add(_ctx.StringValue("MakeCall.Params["+ i +"]"));
			}
			makeCallResponse._Params = makeCallResponse_params;

			MakeCallResponse.MakeCall_Data data = new MakeCallResponse.MakeCall_Data();

			MakeCallResponse.MakeCall_Data.MakeCall_CallContext callContext = new MakeCallResponse.MakeCall_Data.MakeCall_CallContext();
			callContext.CallType = _ctx.StringValue("MakeCall.Data.CallContext.CallType");
			callContext.InstanceId = _ctx.StringValue("MakeCall.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("MakeCall.Data.CallContext.JobId");

			List<MakeCallResponse.MakeCall_Data.MakeCall_CallContext.MakeCall_ChannelContext> callContext_channelContexts = new List<MakeCallResponse.MakeCall_Data.MakeCall_CallContext.MakeCall_ChannelContext>();
			for (int i = 0; i < _ctx.Length("MakeCall.Data.CallContext.ChannelContexts.Length"); i++) {
				MakeCallResponse.MakeCall_Data.MakeCall_CallContext.MakeCall_ChannelContext channelContext = new MakeCallResponse.MakeCall_Data.MakeCall_CallContext.MakeCall_ChannelContext();
				channelContext.AssociatedData = _ctx.StringValue("MakeCall.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.CallType = _ctx.StringValue("MakeCall.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.ChannelFlags = _ctx.StringValue("MakeCall.Data.CallContext.ChannelContexts["+ i +"].ChannelFlags");
				channelContext.ChannelId = _ctx.StringValue("MakeCall.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.ChannelState = _ctx.StringValue("MakeCall.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("MakeCall.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.JobId = _ctx.StringValue("MakeCall.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.Originator = _ctx.StringValue("MakeCall.Data.CallContext.ChannelContexts["+ i +"].Originator");
				channelContext.ReleaseInitiator = _ctx.StringValue("MakeCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ReleaseReason = _ctx.StringValue("MakeCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.Timestamp = _ctx.LongValue("MakeCall.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.UserExtension = _ctx.StringValue("MakeCall.Data.CallContext.ChannelContexts["+ i +"].UserExtension");
				channelContext.UserId = _ctx.StringValue("MakeCall.Data.CallContext.ChannelContexts["+ i +"].UserId");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			MakeCallResponse.MakeCall_Data.MakeCall_UserContext userContext = new MakeCallResponse.MakeCall_Data.MakeCall_UserContext();
			userContext.BreakCode = _ctx.StringValue("MakeCall.Data.UserContext.BreakCode");
			userContext.DeviceId = _ctx.StringValue("MakeCall.Data.UserContext.DeviceId");
			userContext.Extension = _ctx.StringValue("MakeCall.Data.UserContext.Extension");
			userContext.InstanceId = _ctx.StringValue("MakeCall.Data.UserContext.InstanceId");
			userContext.JobId = _ctx.StringValue("MakeCall.Data.UserContext.JobId");
			userContext.OutboundScenario = _ctx.BooleanValue("MakeCall.Data.UserContext.OutboundScenario");
			userContext.UserId = _ctx.StringValue("MakeCall.Data.UserContext.UserId");
			userContext.UserState = _ctx.StringValue("MakeCall.Data.UserContext.UserState");
			userContext.WorkMode = _ctx.StringValue("MakeCall.Data.UserContext.WorkMode");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("MakeCall.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("MakeCall.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			makeCallResponse.Data = data;
        
			return makeCallResponse;
        }
    }
}
