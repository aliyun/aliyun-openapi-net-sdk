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
    public class CoachCallResponseUnmarshaller
    {
        public static CoachCallResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CoachCallResponse coachCallResponse = new CoachCallResponse();

			coachCallResponse.HttpResponse = _ctx.HttpResponse;
			coachCallResponse.Code = _ctx.StringValue("CoachCall.Code");
			coachCallResponse.HttpStatusCode = _ctx.IntegerValue("CoachCall.HttpStatusCode");
			coachCallResponse.Message = _ctx.StringValue("CoachCall.Message");
			coachCallResponse.RequestId = _ctx.StringValue("CoachCall.RequestId");

			List<string> coachCallResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("CoachCall.Params.Length"); i++) {
				coachCallResponse_params.Add(_ctx.StringValue("CoachCall.Params["+ i +"]"));
			}
			coachCallResponse._Params = coachCallResponse_params;

			CoachCallResponse.CoachCall_Data data = new CoachCallResponse.CoachCall_Data();

			CoachCallResponse.CoachCall_Data.CoachCall_CallContext callContext = new CoachCallResponse.CoachCall_Data.CoachCall_CallContext();
			callContext.CallType = _ctx.StringValue("CoachCall.Data.CallContext.CallType");
			callContext.InstanceId = _ctx.StringValue("CoachCall.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("CoachCall.Data.CallContext.JobId");

			List<CoachCallResponse.CoachCall_Data.CoachCall_CallContext.CoachCall_ChannelContext> callContext_channelContexts = new List<CoachCallResponse.CoachCall_Data.CoachCall_CallContext.CoachCall_ChannelContext>();
			for (int i = 0; i < _ctx.Length("CoachCall.Data.CallContext.ChannelContexts.Length"); i++) {
				CoachCallResponse.CoachCall_Data.CoachCall_CallContext.CoachCall_ChannelContext channelContext = new CoachCallResponse.CoachCall_Data.CoachCall_CallContext.CoachCall_ChannelContext();
				channelContext.AssociatedData = _ctx.StringValue("CoachCall.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.CallType = _ctx.StringValue("CoachCall.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.ChannelFlags = _ctx.StringValue("CoachCall.Data.CallContext.ChannelContexts["+ i +"].ChannelFlags");
				channelContext.ChannelId = _ctx.StringValue("CoachCall.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.ChannelState = _ctx.StringValue("CoachCall.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("CoachCall.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.Index = _ctx.IntegerValue("CoachCall.Data.CallContext.ChannelContexts["+ i +"].Index");
				channelContext.JobId = _ctx.StringValue("CoachCall.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.Originator = _ctx.StringValue("CoachCall.Data.CallContext.ChannelContexts["+ i +"].Originator");
				channelContext.ReleaseInitiator = _ctx.StringValue("CoachCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ReleaseReason = _ctx.StringValue("CoachCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.SkillGroupId = _ctx.StringValue("CoachCall.Data.CallContext.ChannelContexts["+ i +"].SkillGroupId");
				channelContext.Timestamp = _ctx.LongValue("CoachCall.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.UserExtension = _ctx.StringValue("CoachCall.Data.CallContext.ChannelContexts["+ i +"].UserExtension");
				channelContext.UserId = _ctx.StringValue("CoachCall.Data.CallContext.ChannelContexts["+ i +"].UserId");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			CoachCallResponse.CoachCall_Data.CoachCall_UserContext userContext = new CoachCallResponse.CoachCall_Data.CoachCall_UserContext();
			userContext.BreakCode = _ctx.StringValue("CoachCall.Data.UserContext.BreakCode");
			userContext.DeviceId = _ctx.StringValue("CoachCall.Data.UserContext.DeviceId");
			userContext.DeviceState = _ctx.StringValue("CoachCall.Data.UserContext.DeviceState");
			userContext.Extension = _ctx.StringValue("CoachCall.Data.UserContext.Extension");
			userContext.Heartbeat = _ctx.LongValue("CoachCall.Data.UserContext.Heartbeat");
			userContext.InstanceId = _ctx.StringValue("CoachCall.Data.UserContext.InstanceId");
			userContext.JobId = _ctx.StringValue("CoachCall.Data.UserContext.JobId");
			userContext.Mobile = _ctx.StringValue("CoachCall.Data.UserContext.Mobile");
			userContext.OutboundScenario = _ctx.BooleanValue("CoachCall.Data.UserContext.OutboundScenario");
			userContext.Reserved = _ctx.LongValue("CoachCall.Data.UserContext.Reserved");
			userContext.Uri = _ctx.StringValue("CoachCall.Data.UserContext.Uri");
			userContext.UserId = _ctx.StringValue("CoachCall.Data.UserContext.UserId");
			userContext.UserState = _ctx.StringValue("CoachCall.Data.UserContext.UserState");
			userContext.WorkMode = _ctx.StringValue("CoachCall.Data.UserContext.WorkMode");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("CoachCall.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("CoachCall.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			coachCallResponse.Data = data;
        
			return coachCallResponse;
        }
    }
}
