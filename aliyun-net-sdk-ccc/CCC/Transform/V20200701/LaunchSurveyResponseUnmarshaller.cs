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
    public class LaunchSurveyResponseUnmarshaller
    {
        public static LaunchSurveyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			LaunchSurveyResponse launchSurveyResponse = new LaunchSurveyResponse();

			launchSurveyResponse.HttpResponse = _ctx.HttpResponse;
			launchSurveyResponse.Code = _ctx.StringValue("LaunchSurvey.Code");
			launchSurveyResponse.HttpStatusCode = _ctx.IntegerValue("LaunchSurvey.HttpStatusCode");
			launchSurveyResponse.Message = _ctx.StringValue("LaunchSurvey.Message");
			launchSurveyResponse.RequestId = _ctx.StringValue("LaunchSurvey.RequestId");

			List<string> launchSurveyResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("LaunchSurvey.Params.Length"); i++) {
				launchSurveyResponse_params.Add(_ctx.StringValue("LaunchSurvey.Params["+ i +"]"));
			}
			launchSurveyResponse._Params = launchSurveyResponse_params;

			LaunchSurveyResponse.LaunchSurvey_Data data = new LaunchSurveyResponse.LaunchSurvey_Data();

			LaunchSurveyResponse.LaunchSurvey_Data.LaunchSurvey_CallContext callContext = new LaunchSurveyResponse.LaunchSurvey_Data.LaunchSurvey_CallContext();
			callContext.CallType = _ctx.StringValue("LaunchSurvey.Data.CallContext.CallType");
			callContext.InstanceId = _ctx.StringValue("LaunchSurvey.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("LaunchSurvey.Data.CallContext.JobId");

			List<LaunchSurveyResponse.LaunchSurvey_Data.LaunchSurvey_CallContext.LaunchSurvey_ChannelContext> callContext_channelContexts = new List<LaunchSurveyResponse.LaunchSurvey_Data.LaunchSurvey_CallContext.LaunchSurvey_ChannelContext>();
			for (int i = 0; i < _ctx.Length("LaunchSurvey.Data.CallContext.ChannelContexts.Length"); i++) {
				LaunchSurveyResponse.LaunchSurvey_Data.LaunchSurvey_CallContext.LaunchSurvey_ChannelContext channelContext = new LaunchSurveyResponse.LaunchSurvey_Data.LaunchSurvey_CallContext.LaunchSurvey_ChannelContext();
				channelContext.AssociatedData = _ctx.StringValue("LaunchSurvey.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.CallType = _ctx.StringValue("LaunchSurvey.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.ChannelFlags = _ctx.StringValue("LaunchSurvey.Data.CallContext.ChannelContexts["+ i +"].ChannelFlags");
				channelContext.ChannelId = _ctx.StringValue("LaunchSurvey.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.ChannelState = _ctx.StringValue("LaunchSurvey.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("LaunchSurvey.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.Index = _ctx.IntegerValue("LaunchSurvey.Data.CallContext.ChannelContexts["+ i +"].Index");
				channelContext.JobId = _ctx.StringValue("LaunchSurvey.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.Originator = _ctx.StringValue("LaunchSurvey.Data.CallContext.ChannelContexts["+ i +"].Originator");
				channelContext.ReleaseInitiator = _ctx.StringValue("LaunchSurvey.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ReleaseReason = _ctx.StringValue("LaunchSurvey.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.SkillGroupId = _ctx.StringValue("LaunchSurvey.Data.CallContext.ChannelContexts["+ i +"].SkillGroupId");
				channelContext.Timestamp = _ctx.LongValue("LaunchSurvey.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.UserExtension = _ctx.StringValue("LaunchSurvey.Data.CallContext.ChannelContexts["+ i +"].UserExtension");
				channelContext.UserId = _ctx.StringValue("LaunchSurvey.Data.CallContext.ChannelContexts["+ i +"].UserId");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			LaunchSurveyResponse.LaunchSurvey_Data.LaunchSurvey_UserContext userContext = new LaunchSurveyResponse.LaunchSurvey_Data.LaunchSurvey_UserContext();
			userContext.BreakCode = _ctx.StringValue("LaunchSurvey.Data.UserContext.BreakCode");
			userContext.DeviceId = _ctx.StringValue("LaunchSurvey.Data.UserContext.DeviceId");
			userContext.Extension = _ctx.StringValue("LaunchSurvey.Data.UserContext.Extension");
			userContext.Heartbeat = _ctx.LongValue("LaunchSurvey.Data.UserContext.Heartbeat");
			userContext.InstanceId = _ctx.StringValue("LaunchSurvey.Data.UserContext.InstanceId");
			userContext.JobId = _ctx.StringValue("LaunchSurvey.Data.UserContext.JobId");
			userContext.Mobile = _ctx.StringValue("LaunchSurvey.Data.UserContext.Mobile");
			userContext.OutboundScenario = _ctx.BooleanValue("LaunchSurvey.Data.UserContext.OutboundScenario");
			userContext.Reserved = _ctx.LongValue("LaunchSurvey.Data.UserContext.Reserved");
			userContext.UserId = _ctx.StringValue("LaunchSurvey.Data.UserContext.UserId");
			userContext.UserState = _ctx.StringValue("LaunchSurvey.Data.UserContext.UserState");
			userContext.WorkMode = _ctx.StringValue("LaunchSurvey.Data.UserContext.WorkMode");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("LaunchSurvey.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("LaunchSurvey.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			launchSurveyResponse.Data = data;
        
			return launchSurveyResponse;
        }
    }
}
