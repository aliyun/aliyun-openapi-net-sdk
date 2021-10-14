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
    public class ReleaseCallResponseUnmarshaller
    {
        public static ReleaseCallResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ReleaseCallResponse releaseCallResponse = new ReleaseCallResponse();

			releaseCallResponse.HttpResponse = _ctx.HttpResponse;
			releaseCallResponse.Code = _ctx.StringValue("ReleaseCall.Code");
			releaseCallResponse.HttpStatusCode = _ctx.IntegerValue("ReleaseCall.HttpStatusCode");
			releaseCallResponse.Message = _ctx.StringValue("ReleaseCall.Message");
			releaseCallResponse.RequestId = _ctx.StringValue("ReleaseCall.RequestId");

			List<string> releaseCallResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("ReleaseCall.Params.Length"); i++) {
				releaseCallResponse_params.Add(_ctx.StringValue("ReleaseCall.Params["+ i +"]"));
			}
			releaseCallResponse._Params = releaseCallResponse_params;

			ReleaseCallResponse.ReleaseCall_Data data = new ReleaseCallResponse.ReleaseCall_Data();

			ReleaseCallResponse.ReleaseCall_Data.ReleaseCall_CallContext callContext = new ReleaseCallResponse.ReleaseCall_Data.ReleaseCall_CallContext();
			callContext.InstanceId = _ctx.StringValue("ReleaseCall.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("ReleaseCall.Data.CallContext.JobId");

			List<ReleaseCallResponse.ReleaseCall_Data.ReleaseCall_CallContext.ReleaseCall_ChannelContext> callContext_channelContexts = new List<ReleaseCallResponse.ReleaseCall_Data.ReleaseCall_CallContext.ReleaseCall_ChannelContext>();
			for (int i = 0; i < _ctx.Length("ReleaseCall.Data.CallContext.ChannelContexts.Length"); i++) {
				ReleaseCallResponse.ReleaseCall_Data.ReleaseCall_CallContext.ReleaseCall_ChannelContext channelContext = new ReleaseCallResponse.ReleaseCall_Data.ReleaseCall_CallContext.ReleaseCall_ChannelContext();
				channelContext.AssociatedData = _ctx.StringValue("ReleaseCall.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.CallType = _ctx.StringValue("ReleaseCall.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.ChannelId = _ctx.StringValue("ReleaseCall.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.ChannelState = _ctx.StringValue("ReleaseCall.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("ReleaseCall.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.JobId = _ctx.StringValue("ReleaseCall.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.Originator = _ctx.StringValue("ReleaseCall.Data.CallContext.ChannelContexts["+ i +"].Originator");
				channelContext.ReleaseInitiator = _ctx.StringValue("ReleaseCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ReleaseReason = _ctx.StringValue("ReleaseCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.Timestamp = _ctx.LongValue("ReleaseCall.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.UserExtension = _ctx.StringValue("ReleaseCall.Data.CallContext.ChannelContexts["+ i +"].UserExtension");
				channelContext.UserId = _ctx.StringValue("ReleaseCall.Data.CallContext.ChannelContexts["+ i +"].UserId");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			ReleaseCallResponse.ReleaseCall_Data.ReleaseCall_UserContext userContext = new ReleaseCallResponse.ReleaseCall_Data.ReleaseCall_UserContext();
			userContext.BreakCode = _ctx.StringValue("ReleaseCall.Data.UserContext.BreakCode");
			userContext.DeviceId = _ctx.StringValue("ReleaseCall.Data.UserContext.DeviceId");
			userContext.Extension = _ctx.StringValue("ReleaseCall.Data.UserContext.Extension");
			userContext.InstanceId = _ctx.StringValue("ReleaseCall.Data.UserContext.InstanceId");
			userContext.JobId = _ctx.StringValue("ReleaseCall.Data.UserContext.JobId");
			userContext.OutboundScenario = _ctx.BooleanValue("ReleaseCall.Data.UserContext.OutboundScenario");
			userContext.UserId = _ctx.StringValue("ReleaseCall.Data.UserContext.UserId");
			userContext.UserState = _ctx.StringValue("ReleaseCall.Data.UserContext.UserState");
			userContext.WorkMode = _ctx.StringValue("ReleaseCall.Data.UserContext.WorkMode");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("ReleaseCall.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("ReleaseCall.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			releaseCallResponse.Data = data;
        
			return releaseCallResponse;
        }
    }
}
