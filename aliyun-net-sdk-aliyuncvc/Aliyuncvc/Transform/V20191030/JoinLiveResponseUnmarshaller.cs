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
using Aliyun.Acs.aliyuncvc.Model.V20191030;

namespace Aliyun.Acs.aliyuncvc.Transform.V20191030
{
    public class JoinLiveResponseUnmarshaller
    {
        public static JoinLiveResponse Unmarshall(UnmarshallerContext _ctx)
        {
			JoinLiveResponse joinLiveResponse = new JoinLiveResponse();

			joinLiveResponse.HttpResponse = _ctx.HttpResponse;
			joinLiveResponse.ErrorCode = _ctx.IntegerValue("JoinLive.ErrorCode");
			joinLiveResponse.Success = _ctx.BooleanValue("JoinLive.Success");
			joinLiveResponse.RequestId = _ctx.StringValue("JoinLive.RequestId");
			joinLiveResponse.Message = _ctx.StringValue("JoinLive.Message");

			JoinLiveResponse.JoinLive_MeetingInfo meetingInfo = new JoinLiveResponse.JoinLive_MeetingInfo();
			meetingInfo.MeetingDomain = _ctx.StringValue("JoinLive.MeetingInfo.MeetingDomain");
			meetingInfo.MeetingToken = _ctx.StringValue("JoinLive.MeetingInfo.MeetingToken");
			meetingInfo.MeetingCode = _ctx.StringValue("JoinLive.MeetingInfo.MeetingCode");
			meetingInfo.MemberUUID = _ctx.StringValue("JoinLive.MeetingInfo.MemberUUID");
			meetingInfo.ClientAppId = _ctx.StringValue("JoinLive.MeetingInfo.ClientAppId");
			meetingInfo.MeetingUUID = _ctx.StringValue("JoinLive.MeetingInfo.MeetingUUID");
			meetingInfo.MeetingAppId = _ctx.StringValue("JoinLive.MeetingInfo.MeetingAppId");

			JoinLiveResponse.JoinLive_MeetingInfo.JoinLive_SlsInfo slsInfo = new JoinLiveResponse.JoinLive_MeetingInfo.JoinLive_SlsInfo();
			slsInfo.LogServiceEndpoint = _ctx.StringValue("JoinLive.MeetingInfo.SlsInfo.LogServiceEndpoint");
			slsInfo.Logstore = _ctx.StringValue("JoinLive.MeetingInfo.SlsInfo.Logstore");
			slsInfo.Project = _ctx.StringValue("JoinLive.MeetingInfo.SlsInfo.Project");
			meetingInfo.SlsInfo = slsInfo;
			joinLiveResponse.MeetingInfo = meetingInfo;
        
			return joinLiveResponse;
        }
    }
}
