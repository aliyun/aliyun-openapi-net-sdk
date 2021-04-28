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
    public class MonitorCallResponseUnmarshaller
    {
        public static MonitorCallResponse Unmarshall(UnmarshallerContext _ctx)
        {
			MonitorCallResponse monitorCallResponse = new MonitorCallResponse();

			monitorCallResponse.HttpResponse = _ctx.HttpResponse;
			monitorCallResponse.Code = _ctx.StringValue("MonitorCall.Code");
			monitorCallResponse.HttpStatusCode = _ctx.IntegerValue("MonitorCall.HttpStatusCode");
			monitorCallResponse.Message = _ctx.StringValue("MonitorCall.Message");
			monitorCallResponse.RequestId = _ctx.StringValue("MonitorCall.RequestId");

			List<string> monitorCallResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("MonitorCall.Params.Length"); i++) {
				monitorCallResponse_params.Add(_ctx.StringValue("MonitorCall.Params["+ i +"]"));
			}
			monitorCallResponse._Params = monitorCallResponse_params;

			MonitorCallResponse.MonitorCall_Data data = new MonitorCallResponse.MonitorCall_Data();

			MonitorCallResponse.MonitorCall_Data.MonitorCall_CallContext callContext = new MonitorCallResponse.MonitorCall_Data.MonitorCall_CallContext();
			callContext.CallType = _ctx.StringValue("MonitorCall.Data.CallContext.CallType");
			callContext.InstanceId = _ctx.StringValue("MonitorCall.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("MonitorCall.Data.CallContext.JobId");

			List<MonitorCallResponse.MonitorCall_Data.MonitorCall_CallContext.MonitorCall_ChannelContext> callContext_channelContexts = new List<MonitorCallResponse.MonitorCall_Data.MonitorCall_CallContext.MonitorCall_ChannelContext>();
			for (int i = 0; i < _ctx.Length("MonitorCall.Data.CallContext.ChannelContexts.Length"); i++) {
				MonitorCallResponse.MonitorCall_Data.MonitorCall_CallContext.MonitorCall_ChannelContext channelContext = new MonitorCallResponse.MonitorCall_Data.MonitorCall_CallContext.MonitorCall_ChannelContext();
				channelContext.AssociatedData = _ctx.StringValue("MonitorCall.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.CallType = _ctx.StringValue("MonitorCall.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.ChannelFlags = _ctx.StringValue("MonitorCall.Data.CallContext.ChannelContexts["+ i +"].ChannelFlags");
				channelContext.ChannelId = _ctx.StringValue("MonitorCall.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.ChannelState = _ctx.StringValue("MonitorCall.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("MonitorCall.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.Index = _ctx.IntegerValue("MonitorCall.Data.CallContext.ChannelContexts["+ i +"].Index");
				channelContext.JobId = _ctx.StringValue("MonitorCall.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.Originator = _ctx.StringValue("MonitorCall.Data.CallContext.ChannelContexts["+ i +"].Originator");
				channelContext.ReleaseInitiator = _ctx.StringValue("MonitorCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ReleaseReason = _ctx.StringValue("MonitorCall.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.SkillGroupId = _ctx.StringValue("MonitorCall.Data.CallContext.ChannelContexts["+ i +"].SkillGroupId");
				channelContext.Timestamp = _ctx.LongValue("MonitorCall.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.UserExtension = _ctx.StringValue("MonitorCall.Data.CallContext.ChannelContexts["+ i +"].UserExtension");
				channelContext.UserId = _ctx.StringValue("MonitorCall.Data.CallContext.ChannelContexts["+ i +"].UserId");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			MonitorCallResponse.MonitorCall_Data.MonitorCall_UserContext userContext = new MonitorCallResponse.MonitorCall_Data.MonitorCall_UserContext();
			userContext.BreakCode = _ctx.StringValue("MonitorCall.Data.UserContext.BreakCode");
			userContext.DeviceId = _ctx.StringValue("MonitorCall.Data.UserContext.DeviceId");
			userContext.Extension = _ctx.StringValue("MonitorCall.Data.UserContext.Extension");
			userContext.Heartbeat = _ctx.LongValue("MonitorCall.Data.UserContext.Heartbeat");
			userContext.InstanceId = _ctx.StringValue("MonitorCall.Data.UserContext.InstanceId");
			userContext.JobId = _ctx.StringValue("MonitorCall.Data.UserContext.JobId");
			userContext.Mobile = _ctx.StringValue("MonitorCall.Data.UserContext.Mobile");
			userContext.OutboundScenario = _ctx.BooleanValue("MonitorCall.Data.UserContext.OutboundScenario");
			userContext.Reserved = _ctx.LongValue("MonitorCall.Data.UserContext.Reserved");
			userContext.UserId = _ctx.StringValue("MonitorCall.Data.UserContext.UserId");
			userContext.UserState = _ctx.StringValue("MonitorCall.Data.UserContext.UserState");
			userContext.WorkMode = _ctx.StringValue("MonitorCall.Data.UserContext.WorkMode");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("MonitorCall.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("MonitorCall.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			monitorCallResponse.Data = data;
        
			return monitorCallResponse;
        }
    }
}
