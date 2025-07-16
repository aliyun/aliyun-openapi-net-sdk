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
using Aliyun.Acs.LingMou.Model.V20250527;

namespace Aliyun.Acs.LingMou.Transform.V20250527
{
    public class CreateChatSessionResponseUnmarshaller
    {
        public static CreateChatSessionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateChatSessionResponse createChatSessionResponse = new CreateChatSessionResponse();

			createChatSessionResponse.HttpResponse = _ctx.HttpResponse;
			createChatSessionResponse.RequestId = _ctx.StringValue("CreateChatSession.requestId");
			createChatSessionResponse.Message = _ctx.StringValue("CreateChatSession.message");
			createChatSessionResponse.HttpStatusCode = _ctx.LongValue("CreateChatSession.httpStatusCode");
			createChatSessionResponse.Code = _ctx.StringValue("CreateChatSession.code");
			createChatSessionResponse.Success = _ctx.BooleanValue("CreateChatSession.success");

			CreateChatSessionResponse.CreateChatSession_Data data = new CreateChatSessionResponse.CreateChatSession_Data();
			data.SessionId = _ctx.StringValue("CreateChatSession.Data.sessionId");

			CreateChatSessionResponse.CreateChatSession_Data.CreateChatSession_RtcParams rtcParams = new CreateChatSessionResponse.CreateChatSession_Data.CreateChatSession_RtcParams();
			rtcParams.AppId = _ctx.StringValue("CreateChatSession.Data.RtcParams.appId");
			rtcParams.AvatarUserId = _ctx.StringValue("CreateChatSession.Data.RtcParams.avatarUserId");
			rtcParams.Channel = _ctx.StringValue("CreateChatSession.Data.RtcParams.channel");
			rtcParams.ClientUserId = _ctx.StringValue("CreateChatSession.Data.RtcParams.clientUserId");
			rtcParams.Gslb = _ctx.StringValue("CreateChatSession.Data.RtcParams.gslb");
			rtcParams.Nonce = _ctx.StringValue("CreateChatSession.Data.RtcParams.nonce");
			rtcParams.ServerUserId = _ctx.StringValue("CreateChatSession.Data.RtcParams.serverUserId");
			rtcParams.Timestamp = _ctx.LongValue("CreateChatSession.Data.RtcParams.timestamp");
			rtcParams.Token = _ctx.StringValue("CreateChatSession.Data.RtcParams.token");
			data.RtcParams = rtcParams;

			CreateChatSessionResponse.CreateChatSession_Data.CreateChatSession_AvatarAssets avatarAssets = new CreateChatSessionResponse.CreateChatSession_Data.CreateChatSession_AvatarAssets();
			avatarAssets.Url = _ctx.StringValue("CreateChatSession.Data.AvatarAssets.url");
			avatarAssets.Md5 = _ctx.StringValue("CreateChatSession.Data.AvatarAssets.md5");
			avatarAssets.Secret = _ctx.StringValue("CreateChatSession.Data.AvatarAssets.secret");
			avatarAssets.Type = _ctx.StringValue("CreateChatSession.Data.AvatarAssets.type");
			avatarAssets.MinRequiredVersion = _ctx.StringValue("CreateChatSession.Data.AvatarAssets.minRequiredVersion");
			data.AvatarAssets = avatarAssets;
			createChatSessionResponse.Data = data;
        
			return createChatSessionResponse;
        }
    }
}
