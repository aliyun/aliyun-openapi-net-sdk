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
    public class AnswerCallResponseUnmarshaller
    {
        public static AnswerCallResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AnswerCallResponse answerCallResponse = new AnswerCallResponse();

			answerCallResponse.HttpResponse = _ctx.HttpResponse;
			answerCallResponse.Code = _ctx.StringValue("AnswerCall.Code");
			answerCallResponse.HttpStatusCode = _ctx.IntegerValue("AnswerCall.HttpStatusCode");
			answerCallResponse.Message = _ctx.StringValue("AnswerCall.Message");
			answerCallResponse.RequestId = _ctx.StringValue("AnswerCall.RequestId");

			List<string> answerCallResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("AnswerCall.Params.Length"); i++) {
				answerCallResponse_params.Add(_ctx.StringValue("AnswerCall.Params["+ i +"]"));
			}
			answerCallResponse._Params = answerCallResponse_params;

			AnswerCallResponse.AnswerCall_Data data = new AnswerCallResponse.AnswerCall_Data();

			AnswerCallResponse.AnswerCall_Data.AnswerCall_CallContext callContext = new AnswerCallResponse.AnswerCall_Data.AnswerCall_CallContext();
			callContext.InstanceId = _ctx.StringValue("AnswerCall.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("AnswerCall.Data.CallContext.JobId");

			List<AnswerCallResponse.AnswerCall_Data.AnswerCall_CallContext.AnswerCall_ChannelContext> callContext_channelContexts = new List<AnswerCallResponse.AnswerCall_Data.AnswerCall_CallContext.AnswerCall_ChannelContext>();
			for (int i = 0; i < _ctx.Length("AnswerCall.Data.CallContext.ChannelContexts.Length"); i++) {
				AnswerCallResponse.AnswerCall_Data.AnswerCall_CallContext.AnswerCall_ChannelContext channelContext = new AnswerCallResponse.AnswerCall_Data.AnswerCall_CallContext.AnswerCall_ChannelContext();
				channelContext.AssociatedData = _ctx.StringValue("AnswerCall.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.CallType = _ctx.StringValue("AnswerCall.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.ChannelId = _ctx.StringValue("AnswerCall.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.ChannelState = _ctx.StringValue("AnswerCall.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("AnswerCall.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.JobId = _ctx.StringValue("AnswerCall.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.Originator = _ctx.StringValue("AnswerCall.Data.CallContext.ChannelContexts["+ i +"].Originator");
				channelContext.ReleaseInitiator = _ctx.StringValue("AnswerCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ReleaseReason = _ctx.StringValue("AnswerCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.SkillGroupId = _ctx.StringValue("AnswerCall.Data.CallContext.ChannelContexts["+ i +"].SkillGroupId");
				channelContext.Timestamp = _ctx.LongValue("AnswerCall.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.UserExtension = _ctx.StringValue("AnswerCall.Data.CallContext.ChannelContexts["+ i +"].UserExtension");
				channelContext.UserId = _ctx.StringValue("AnswerCall.Data.CallContext.ChannelContexts["+ i +"].UserId");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			AnswerCallResponse.AnswerCall_Data.AnswerCall_UserContext userContext = new AnswerCallResponse.AnswerCall_Data.AnswerCall_UserContext();
			userContext.BreakCode = _ctx.StringValue("AnswerCall.Data.UserContext.BreakCode");
			userContext.DeviceId = _ctx.StringValue("AnswerCall.Data.UserContext.DeviceId");
			userContext.Extension = _ctx.StringValue("AnswerCall.Data.UserContext.Extension");
			userContext.Heartbeat = _ctx.LongValue("AnswerCall.Data.UserContext.Heartbeat");
			userContext.InstanceId = _ctx.StringValue("AnswerCall.Data.UserContext.InstanceId");
			userContext.JobId = _ctx.StringValue("AnswerCall.Data.UserContext.JobId");
			userContext.Mobile = _ctx.StringValue("AnswerCall.Data.UserContext.Mobile");
			userContext.OutboundScenario = _ctx.BooleanValue("AnswerCall.Data.UserContext.OutboundScenario");
			userContext.Reserved = _ctx.LongValue("AnswerCall.Data.UserContext.Reserved");
			userContext.UserId = _ctx.StringValue("AnswerCall.Data.UserContext.UserId");
			userContext.UserState = _ctx.StringValue("AnswerCall.Data.UserContext.UserState");
			userContext.WorkMode = _ctx.StringValue("AnswerCall.Data.UserContext.WorkMode");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("AnswerCall.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("AnswerCall.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			answerCallResponse.Data = data;
        
			return answerCallResponse;
        }
    }
}
