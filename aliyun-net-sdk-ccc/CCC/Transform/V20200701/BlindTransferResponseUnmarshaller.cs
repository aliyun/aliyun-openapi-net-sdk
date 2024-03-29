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
    public class BlindTransferResponseUnmarshaller
    {
        public static BlindTransferResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BlindTransferResponse blindTransferResponse = new BlindTransferResponse();

			blindTransferResponse.HttpResponse = _ctx.HttpResponse;
			blindTransferResponse.Code = _ctx.StringValue("BlindTransfer.Code");
			blindTransferResponse.HttpStatusCode = _ctx.IntegerValue("BlindTransfer.HttpStatusCode");
			blindTransferResponse.Message = _ctx.StringValue("BlindTransfer.Message");
			blindTransferResponse.RequestId = _ctx.StringValue("BlindTransfer.RequestId");

			List<string> blindTransferResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("BlindTransfer.Params.Length"); i++) {
				blindTransferResponse_params.Add(_ctx.StringValue("BlindTransfer.Params["+ i +"]"));
			}
			blindTransferResponse._Params = blindTransferResponse_params;

			BlindTransferResponse.BlindTransfer_Data data = new BlindTransferResponse.BlindTransfer_Data();
			data.ContextId = _ctx.LongValue("BlindTransfer.Data.ContextId");

			BlindTransferResponse.BlindTransfer_Data.BlindTransfer_CallContext callContext = new BlindTransferResponse.BlindTransfer_Data.BlindTransfer_CallContext();
			callContext.CallType = _ctx.StringValue("BlindTransfer.Data.CallContext.CallType");
			callContext.InstanceId = _ctx.StringValue("BlindTransfer.Data.CallContext.InstanceId");
			callContext.JobId = _ctx.StringValue("BlindTransfer.Data.CallContext.JobId");

			List<BlindTransferResponse.BlindTransfer_Data.BlindTransfer_CallContext.BlindTransfer_ChannelContext> callContext_channelContexts = new List<BlindTransferResponse.BlindTransfer_Data.BlindTransfer_CallContext.BlindTransfer_ChannelContext>();
			for (int i = 0; i < _ctx.Length("BlindTransfer.Data.CallContext.ChannelContexts.Length"); i++) {
				BlindTransferResponse.BlindTransfer_Data.BlindTransfer_CallContext.BlindTransfer_ChannelContext channelContext = new BlindTransferResponse.BlindTransfer_Data.BlindTransfer_CallContext.BlindTransfer_ChannelContext();
				channelContext.ReleaseInitiator = _ctx.StringValue("BlindTransfer.Data.CallContext.ChannelContexts["+ i +"].ReleaseInitiator");
				channelContext.ChannelState = _ctx.StringValue("BlindTransfer.Data.CallContext.ChannelContexts["+ i +"].ChannelState");
				channelContext.Destination = _ctx.StringValue("BlindTransfer.Data.CallContext.ChannelContexts["+ i +"].Destination");
				channelContext.UserId = _ctx.StringValue("BlindTransfer.Data.CallContext.ChannelContexts["+ i +"].UserId");
				channelContext.ChannelFlags = _ctx.StringValue("BlindTransfer.Data.CallContext.ChannelContexts["+ i +"].ChannelFlags");
				channelContext.Timestamp = _ctx.LongValue("BlindTransfer.Data.CallContext.ChannelContexts["+ i +"].Timestamp");
				channelContext.AssociatedData = _ctx.StringValue("BlindTransfer.Data.CallContext.ChannelContexts["+ i +"].AssociatedData");
				channelContext.ReleaseReason = _ctx.StringValue("BlindTransfer.Data.CallContext.ChannelContexts["+ i +"].ReleaseReason");
				channelContext.CallType = _ctx.StringValue("BlindTransfer.Data.CallContext.ChannelContexts["+ i +"].CallType");
				channelContext.JobId = _ctx.StringValue("BlindTransfer.Data.CallContext.ChannelContexts["+ i +"].JobId");
				channelContext.ChannelId = _ctx.StringValue("BlindTransfer.Data.CallContext.ChannelContexts["+ i +"].ChannelId");
				channelContext.Originator = _ctx.StringValue("BlindTransfer.Data.CallContext.ChannelContexts["+ i +"].Originator");
				channelContext.UserExtension = _ctx.StringValue("BlindTransfer.Data.CallContext.ChannelContexts["+ i +"].UserExtension");

				callContext_channelContexts.Add(channelContext);
			}
			callContext.ChannelContexts = callContext_channelContexts;
			data.CallContext = callContext;

			BlindTransferResponse.BlindTransfer_Data.BlindTransfer_UserContext userContext = new BlindTransferResponse.BlindTransfer_Data.BlindTransfer_UserContext();
			userContext.Extension = _ctx.StringValue("BlindTransfer.Data.UserContext.Extension");
			userContext.Heartbeat = _ctx.LongValue("BlindTransfer.Data.UserContext.Heartbeat");
			userContext.WorkMode = _ctx.StringValue("BlindTransfer.Data.UserContext.WorkMode");
			userContext.DeviceId = _ctx.StringValue("BlindTransfer.Data.UserContext.DeviceId");
			userContext.UserId = _ctx.StringValue("BlindTransfer.Data.UserContext.UserId");
			userContext.Reserved = _ctx.LongValue("BlindTransfer.Data.UserContext.Reserved");
			userContext.BreakCode = _ctx.StringValue("BlindTransfer.Data.UserContext.BreakCode");
			userContext.InstanceId = _ctx.StringValue("BlindTransfer.Data.UserContext.InstanceId");
			userContext.OutboundScenario = _ctx.BooleanValue("BlindTransfer.Data.UserContext.OutboundScenario");
			userContext.Mobile = _ctx.StringValue("BlindTransfer.Data.UserContext.Mobile");
			userContext.JobId = _ctx.StringValue("BlindTransfer.Data.UserContext.JobId");
			userContext.UserState = _ctx.StringValue("BlindTransfer.Data.UserContext.UserState");

			List<string> userContext_signedSkillGroupIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("BlindTransfer.Data.UserContext.SignedSkillGroupIdList.Length"); i++) {
				userContext_signedSkillGroupIdList.Add(_ctx.StringValue("BlindTransfer.Data.UserContext.SignedSkillGroupIdList["+ i +"]"));
			}
			userContext.SignedSkillGroupIdList = userContext_signedSkillGroupIdList;
			data.UserContext = userContext;
			blindTransferResponse.Data = data;
        
			return blindTransferResponse;
        }
    }
}
