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
    public class RetrieveCallResponseUnmarshaller
    {
        public static RetrieveCallResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RetrieveCallResponse retrieveCallResponse = new RetrieveCallResponse();

			retrieveCallResponse.HttpResponse = _ctx.HttpResponse;
			retrieveCallResponse.Code = _ctx.StringValue("RetrieveCall.Code");
			retrieveCallResponse.HttpStatusCode = _ctx.IntegerValue("RetrieveCall.HttpStatusCode");
			retrieveCallResponse.Message = _ctx.StringValue("RetrieveCall.Message");
			retrieveCallResponse.RequestId = _ctx.StringValue("RetrieveCall.RequestId");

			List<string> retrieveCallResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("RetrieveCall.Params.Length"); i++) {
				retrieveCallResponse_params.Add(_ctx.StringValue("RetrieveCall.Params["+ i +"]"));
			}
			retrieveCallResponse._Params = retrieveCallResponse_params;

			RetrieveCallResponse.RetrieveCall_Data data = new RetrieveCallResponse.RetrieveCall_Data();

			RetrieveCallResponse.RetrieveCall_Data.RetrieveCall_CallContext callContext = new RetrieveCallResponse.RetrieveCall_Data.RetrieveCall_CallContext();
			callContext.CallType = _ctx.StringValue("RetrieveCall.Data.CallContext.CallType");
			callContext.InstanceId = _ctx.StringValue("RetrieveCall.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("RetrieveCall.Data.CallContext.JobId");

			List<RetrieveCallResponse.RetrieveCall_Data.RetrieveCall_CallContext.RetrieveCall_ChannelContext> callContext_channelContexts = new List<RetrieveCallResponse.RetrieveCall_Data.RetrieveCall_CallContext.RetrieveCall_ChannelContext>();
			for (int i = 0; i < _ctx.Length("RetrieveCall.Data.CallContext.ChannelContexts.Length"); i++) {
				RetrieveCallResponse.RetrieveCall_Data.RetrieveCall_CallContext.RetrieveCall_ChannelContext channelContext = new RetrieveCallResponse.RetrieveCall_Data.RetrieveCall_CallContext.RetrieveCall_ChannelContext();
				channelContext.AssociatedData = _ctx.StringValue("RetrieveCall.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.CallType = _ctx.StringValue("RetrieveCall.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.ChannelId = _ctx.StringValue("RetrieveCall.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.ChannelState = _ctx.StringValue("RetrieveCall.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("RetrieveCall.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.JobId = _ctx.StringValue("RetrieveCall.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.Originator = _ctx.StringValue("RetrieveCall.Data.CallContext.ChannelContexts["+ i +"].Originator");
				channelContext.ReleaseInitiator = _ctx.StringValue("RetrieveCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ReleaseReason = _ctx.StringValue("RetrieveCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.SkillGroupId = _ctx.StringValue("RetrieveCall.Data.CallContext.ChannelContexts["+ i +"].SkillGroupId");
				channelContext.Timestamp = _ctx.LongValue("RetrieveCall.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.UserExtension = _ctx.StringValue("RetrieveCall.Data.CallContext.ChannelContexts["+ i +"].UserExtension");
				channelContext.UserId = _ctx.StringValue("RetrieveCall.Data.CallContext.ChannelContexts["+ i +"].UserId");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			RetrieveCallResponse.RetrieveCall_Data.RetrieveCall_UserContext userContext = new RetrieveCallResponse.RetrieveCall_Data.RetrieveCall_UserContext();
			userContext.BreakCode = _ctx.StringValue("RetrieveCall.Data.UserContext.BreakCode");
			userContext.DeviceId = _ctx.StringValue("RetrieveCall.Data.UserContext.DeviceId");
			userContext.Extension = _ctx.StringValue("RetrieveCall.Data.UserContext.Extension");
			userContext.Heartbeat = _ctx.LongValue("RetrieveCall.Data.UserContext.Heartbeat");
			userContext.InstanceId = _ctx.StringValue("RetrieveCall.Data.UserContext.InstanceId");
			userContext.JobId = _ctx.StringValue("RetrieveCall.Data.UserContext.JobId");
			userContext.Mobile = _ctx.StringValue("RetrieveCall.Data.UserContext.Mobile");
			userContext.OutboundScenario = _ctx.BooleanValue("RetrieveCall.Data.UserContext.OutboundScenario");
			userContext.Reserved = _ctx.LongValue("RetrieveCall.Data.UserContext.Reserved");
			userContext.UserId = _ctx.StringValue("RetrieveCall.Data.UserContext.UserId");
			userContext.UserState = _ctx.StringValue("RetrieveCall.Data.UserContext.UserState");
			userContext.WorkMode = _ctx.StringValue("RetrieveCall.Data.UserContext.WorkMode");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("RetrieveCall.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("RetrieveCall.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			retrieveCallResponse.Data = data;
        
			return retrieveCallResponse;
        }
    }
}
