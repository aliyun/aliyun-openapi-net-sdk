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
    public class CancelAttendedTransferResponseUnmarshaller
    {
        public static CancelAttendedTransferResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CancelAttendedTransferResponse cancelAttendedTransferResponse = new CancelAttendedTransferResponse();

			cancelAttendedTransferResponse.HttpResponse = _ctx.HttpResponse;
			cancelAttendedTransferResponse.Code = _ctx.StringValue("CancelAttendedTransfer.Code");
			cancelAttendedTransferResponse.HttpStatusCode = _ctx.IntegerValue("CancelAttendedTransfer.HttpStatusCode");
			cancelAttendedTransferResponse.Message = _ctx.StringValue("CancelAttendedTransfer.Message");
			cancelAttendedTransferResponse.RequestId = _ctx.StringValue("CancelAttendedTransfer.RequestId");

			List<string> cancelAttendedTransferResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("CancelAttendedTransfer.Params.Length"); i++) {
				cancelAttendedTransferResponse_params.Add(_ctx.StringValue("CancelAttendedTransfer.Params["+ i +"]"));
			}
			cancelAttendedTransferResponse._Params = cancelAttendedTransferResponse_params;

			CancelAttendedTransferResponse.CancelAttendedTransfer_Data data = new CancelAttendedTransferResponse.CancelAttendedTransfer_Data();

			CancelAttendedTransferResponse.CancelAttendedTransfer_Data.CancelAttendedTransfer_CallContext callContext = new CancelAttendedTransferResponse.CancelAttendedTransfer_Data.CancelAttendedTransfer_CallContext();
			callContext.CallType = _ctx.StringValue("CancelAttendedTransfer.Data.CallContext.CallType");
			callContext.InstanceId = _ctx.StringValue("CancelAttendedTransfer.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("CancelAttendedTransfer.Data.CallContext.JobId");

			List<CancelAttendedTransferResponse.CancelAttendedTransfer_Data.CancelAttendedTransfer_CallContext.CancelAttendedTransfer_ChannelContext> callContext_channelContexts = new List<CancelAttendedTransferResponse.CancelAttendedTransfer_Data.CancelAttendedTransfer_CallContext.CancelAttendedTransfer_ChannelContext>();
			for (int i = 0; i < _ctx.Length("CancelAttendedTransfer.Data.CallContext.ChannelContexts.Length"); i++) {
				CancelAttendedTransferResponse.CancelAttendedTransfer_Data.CancelAttendedTransfer_CallContext.CancelAttendedTransfer_ChannelContext channelContext = new CancelAttendedTransferResponse.CancelAttendedTransfer_Data.CancelAttendedTransfer_CallContext.CancelAttendedTransfer_ChannelContext();
				channelContext.AssociatedData = _ctx.StringValue("CancelAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.CallType = _ctx.StringValue("CancelAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.ChannelFlags = _ctx.StringValue("CancelAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].ChannelFlags");
				channelContext.ChannelId = _ctx.StringValue("CancelAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.ChannelState = _ctx.StringValue("CancelAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("CancelAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.Index = _ctx.IntegerValue("CancelAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].Index");
				channelContext.JobId = _ctx.StringValue("CancelAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.Originator = _ctx.StringValue("CancelAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].Originator");
				channelContext.ReleaseInitiator = _ctx.StringValue("CancelAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ReleaseReason = _ctx.StringValue("CancelAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.Timestamp = _ctx.LongValue("CancelAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.UserExtension = _ctx.StringValue("CancelAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].UserExtension");
				channelContext.UserId = _ctx.StringValue("CancelAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].UserId");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			CancelAttendedTransferResponse.CancelAttendedTransfer_Data.CancelAttendedTransfer_UserContext userContext = new CancelAttendedTransferResponse.CancelAttendedTransfer_Data.CancelAttendedTransfer_UserContext();
			userContext.BreakCode = _ctx.StringValue("CancelAttendedTransfer.Data.UserContext.BreakCode");
			userContext.DeviceId = _ctx.StringValue("CancelAttendedTransfer.Data.UserContext.DeviceId");
			userContext.Extension = _ctx.StringValue("CancelAttendedTransfer.Data.UserContext.Extension");
			userContext.Heartbeat = _ctx.LongValue("CancelAttendedTransfer.Data.UserContext.Heartbeat");
			userContext.InstanceId = _ctx.StringValue("CancelAttendedTransfer.Data.UserContext.InstanceId");
			userContext.JobId = _ctx.StringValue("CancelAttendedTransfer.Data.UserContext.JobId");
			userContext.Mobile = _ctx.StringValue("CancelAttendedTransfer.Data.UserContext.Mobile");
			userContext.OutboundScenario = _ctx.BooleanValue("CancelAttendedTransfer.Data.UserContext.OutboundScenario");
			userContext.Reserved = _ctx.LongValue("CancelAttendedTransfer.Data.UserContext.Reserved");
			userContext.UserId = _ctx.StringValue("CancelAttendedTransfer.Data.UserContext.UserId");
			userContext.UserState = _ctx.StringValue("CancelAttendedTransfer.Data.UserContext.UserState");
			userContext.WorkMode = _ctx.StringValue("CancelAttendedTransfer.Data.UserContext.WorkMode");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("CancelAttendedTransfer.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("CancelAttendedTransfer.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			cancelAttendedTransferResponse.Data = data;
        
			return cancelAttendedTransferResponse;
        }
    }
}
