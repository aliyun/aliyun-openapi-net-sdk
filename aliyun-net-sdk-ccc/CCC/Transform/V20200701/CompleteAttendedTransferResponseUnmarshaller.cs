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
    public class CompleteAttendedTransferResponseUnmarshaller
    {
        public static CompleteAttendedTransferResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CompleteAttendedTransferResponse completeAttendedTransferResponse = new CompleteAttendedTransferResponse();

			completeAttendedTransferResponse.HttpResponse = _ctx.HttpResponse;
			completeAttendedTransferResponse.Code = _ctx.StringValue("CompleteAttendedTransfer.Code");
			completeAttendedTransferResponse.HttpStatusCode = _ctx.IntegerValue("CompleteAttendedTransfer.HttpStatusCode");
			completeAttendedTransferResponse.Message = _ctx.StringValue("CompleteAttendedTransfer.Message");
			completeAttendedTransferResponse.RequestId = _ctx.StringValue("CompleteAttendedTransfer.RequestId");

			List<string> completeAttendedTransferResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("CompleteAttendedTransfer.Params.Length"); i++) {
				completeAttendedTransferResponse_params.Add(_ctx.StringValue("CompleteAttendedTransfer.Params["+ i +"]"));
			}
			completeAttendedTransferResponse._Params = completeAttendedTransferResponse_params;

			CompleteAttendedTransferResponse.CompleteAttendedTransfer_Data data = new CompleteAttendedTransferResponse.CompleteAttendedTransfer_Data();

			CompleteAttendedTransferResponse.CompleteAttendedTransfer_Data.CompleteAttendedTransfer_CallContext callContext = new CompleteAttendedTransferResponse.CompleteAttendedTransfer_Data.CompleteAttendedTransfer_CallContext();
			callContext.CallType = _ctx.StringValue("CompleteAttendedTransfer.Data.CallContext.CallType");
			callContext.InstanceId = _ctx.StringValue("CompleteAttendedTransfer.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("CompleteAttendedTransfer.Data.CallContext.JobId");

			List<CompleteAttendedTransferResponse.CompleteAttendedTransfer_Data.CompleteAttendedTransfer_CallContext.CompleteAttendedTransfer_ChannelContext> callContext_channelContexts = new List<CompleteAttendedTransferResponse.CompleteAttendedTransfer_Data.CompleteAttendedTransfer_CallContext.CompleteAttendedTransfer_ChannelContext>();
			for (int i = 0; i < _ctx.Length("CompleteAttendedTransfer.Data.CallContext.ChannelContexts.Length"); i++) {
				CompleteAttendedTransferResponse.CompleteAttendedTransfer_Data.CompleteAttendedTransfer_CallContext.CompleteAttendedTransfer_ChannelContext channelContext = new CompleteAttendedTransferResponse.CompleteAttendedTransfer_Data.CompleteAttendedTransfer_CallContext.CompleteAttendedTransfer_ChannelContext();
				channelContext.AssociatedData = _ctx.StringValue("CompleteAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.CallType = _ctx.StringValue("CompleteAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.ChannelFlags = _ctx.StringValue("CompleteAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].ChannelFlags");
				channelContext.ChannelId = _ctx.StringValue("CompleteAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.ChannelState = _ctx.StringValue("CompleteAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("CompleteAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.Index = _ctx.IntegerValue("CompleteAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].Index");
				channelContext.JobId = _ctx.StringValue("CompleteAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.Originator = _ctx.StringValue("CompleteAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].Originator");
				channelContext.ReleaseInitiator = _ctx.StringValue("CompleteAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ReleaseReason = _ctx.StringValue("CompleteAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.SkillGroupId = _ctx.StringValue("CompleteAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].SkillGroupId");
				channelContext.Timestamp = _ctx.LongValue("CompleteAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.UserExtension = _ctx.StringValue("CompleteAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].UserExtension");
				channelContext.UserId = _ctx.StringValue("CompleteAttendedTransfer.Data.CallContext.ChannelContexts["+ i +"].UserId");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			CompleteAttendedTransferResponse.CompleteAttendedTransfer_Data.CompleteAttendedTransfer_UserContext userContext = new CompleteAttendedTransferResponse.CompleteAttendedTransfer_Data.CompleteAttendedTransfer_UserContext();
			userContext.BreakCode = _ctx.StringValue("CompleteAttendedTransfer.Data.UserContext.BreakCode");
			userContext.DeviceId = _ctx.StringValue("CompleteAttendedTransfer.Data.UserContext.DeviceId");
			userContext.Extension = _ctx.StringValue("CompleteAttendedTransfer.Data.UserContext.Extension");
			userContext.Heartbeat = _ctx.LongValue("CompleteAttendedTransfer.Data.UserContext.Heartbeat");
			userContext.InstanceId = _ctx.StringValue("CompleteAttendedTransfer.Data.UserContext.InstanceId");
			userContext.JobId = _ctx.StringValue("CompleteAttendedTransfer.Data.UserContext.JobId");
			userContext.Mobile = _ctx.StringValue("CompleteAttendedTransfer.Data.UserContext.Mobile");
			userContext.OutboundScenario = _ctx.BooleanValue("CompleteAttendedTransfer.Data.UserContext.OutboundScenario");
			userContext.Reserved = _ctx.LongValue("CompleteAttendedTransfer.Data.UserContext.Reserved");
			userContext.UserId = _ctx.StringValue("CompleteAttendedTransfer.Data.UserContext.UserId");
			userContext.UserState = _ctx.StringValue("CompleteAttendedTransfer.Data.UserContext.UserState");
			userContext.WorkMode = _ctx.StringValue("CompleteAttendedTransfer.Data.UserContext.WorkMode");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("CompleteAttendedTransfer.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("CompleteAttendedTransfer.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			completeAttendedTransferResponse.Data = data;
        
			return completeAttendedTransferResponse;
        }
    }
}
