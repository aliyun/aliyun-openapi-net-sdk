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
    public class InitiateAttendedTransferResponseUnmarshaller
    {
        public static InitiateAttendedTransferResponse Unmarshall(UnmarshallerContext _ctx)
        {
			InitiateAttendedTransferResponse initiateAttendedTransferResponse = new InitiateAttendedTransferResponse();

			initiateAttendedTransferResponse.HttpResponse = _ctx.HttpResponse;
			initiateAttendedTransferResponse.Code = _ctx.StringValue("InitiateAttendedTransfer.Code");
			initiateAttendedTransferResponse.HttpStatusCode = _ctx.IntegerValue("InitiateAttendedTransfer.HttpStatusCode");
			initiateAttendedTransferResponse.Message = _ctx.StringValue("InitiateAttendedTransfer.Message");
			initiateAttendedTransferResponse.RequestId = _ctx.StringValue("InitiateAttendedTransfer.RequestId");

			List<string> initiateAttendedTransferResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("InitiateAttendedTransfer.Params.Length"); i++) {
				initiateAttendedTransferResponse_params.Add(_ctx.StringValue("InitiateAttendedTransfer.Params["+ i +"]"));
			}
			initiateAttendedTransferResponse._Params = initiateAttendedTransferResponse_params;

			InitiateAttendedTransferResponse.InitiateAttendedTransfer_Data data = new InitiateAttendedTransferResponse.InitiateAttendedTransfer_Data();

			InitiateAttendedTransferResponse.InitiateAttendedTransfer_Data.InitiateAttendedTransfer_CallContext callContext = new InitiateAttendedTransferResponse.InitiateAttendedTransfer_Data.InitiateAttendedTransfer_CallContext();
			callContext.CallType = _ctx.StringValue("InitiateAttendedTransfer.Data.CallContext.CallType");
			callContext.InstanceId = _ctx.StringValue("InitiateAttendedTransfer.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("InitiateAttendedTransfer.Data.CallContext.JobId");

			List<InitiateAttendedTransferResponse.InitiateAttendedTransfer_Data.InitiateAttendedTransfer_CallContext.InitiateAttendedTransfer_ChannelContext> callContext_channelContexts = new List<InitiateAttendedTransferResponse.InitiateAttendedTransfer_Data.InitiateAttendedTransfer_CallContext.InitiateAttendedTransfer_ChannelContext>();
			for (int i = 0; i < _ctx.Length("InitiateAttendedTransfer.Data.CallContext.ChannelContexts.Length"); i++) {
				InitiateAttendedTransferResponse.InitiateAttendedTransfer_Data.InitiateAttendedTransfer_CallContext.InitiateAttendedTransfer_ChannelContext channelContext = new InitiateAttendedTransferResponse.InitiateAttendedTransfer_Data.InitiateAttendedTransfer_CallContext.InitiateAttendedTransfer_ChannelContext();
				channelContext.AssociatedData = _ctx.StringValue("InitiateAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.CallType = _ctx.StringValue("InitiateAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.ChannelFlags = _ctx.StringValue("InitiateAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].ChannelFlags");
				channelContext.ChannelId = _ctx.StringValue("InitiateAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.ChannelState = _ctx.StringValue("InitiateAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("InitiateAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.Index = _ctx.IntegerValue("InitiateAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].Index");
				channelContext.JobId = _ctx.StringValue("InitiateAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.Originator = _ctx.StringValue("InitiateAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].Originator");
				channelContext.ReleaseInitiator = _ctx.StringValue("InitiateAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ReleaseReason = _ctx.StringValue("InitiateAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.SkillGroupId = _ctx.StringValue("InitiateAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].SkillGroupId");
				channelContext.Timestamp = _ctx.LongValue("InitiateAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.UserExtension = _ctx.StringValue("InitiateAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].UserExtension");
				channelContext.UserId = _ctx.StringValue("InitiateAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].UserId");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			InitiateAttendedTransferResponse.InitiateAttendedTransfer_Data.InitiateAttendedTransfer_UserContext userContext = new InitiateAttendedTransferResponse.InitiateAttendedTransfer_Data.InitiateAttendedTransfer_UserContext();
			userContext.BreakCode = _ctx.StringValue("InitiateAttendedTransfer.Data.UserContext.BreakCode");
			userContext.DeviceId = _ctx.StringValue("InitiateAttendedTransfer.Data.UserContext.DeviceId");
			userContext.Extension = _ctx.StringValue("InitiateAttendedTransfer.Data.UserContext.Extension");
			userContext.Heartbeat = _ctx.LongValue("InitiateAttendedTransfer.Data.UserContext.Heartbeat");
			userContext.InstanceId = _ctx.StringValue("InitiateAttendedTransfer.Data.UserContext.InstanceId");
			userContext.JobId = _ctx.StringValue("InitiateAttendedTransfer.Data.UserContext.JobId");
			userContext.Mobile = _ctx.StringValue("InitiateAttendedTransfer.Data.UserContext.Mobile");
			userContext.OutboundScenario = _ctx.BooleanValue("InitiateAttendedTransfer.Data.UserContext.OutboundScenario");
			userContext.Reserved = _ctx.LongValue("InitiateAttendedTransfer.Data.UserContext.Reserved");
			userContext.UserId = _ctx.StringValue("InitiateAttendedTransfer.Data.UserContext.UserId");
			userContext.UserState = _ctx.StringValue("InitiateAttendedTransfer.Data.UserContext.UserState");
			userContext.WorkMode = _ctx.StringValue("InitiateAttendedTransfer.Data.UserContext.WorkMode");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("InitiateAttendedTransfer.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("InitiateAttendedTransfer.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			initiateAttendedTransferResponse.Data = data;
        
			return initiateAttendedTransferResponse;
        }
    }
}
