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
using Aliyun.Acs.aliyuncvc.Model.V20200330;

namespace Aliyun.Acs.aliyuncvc.Transform.V20200330
{
    public class JoinMeetingResponseUnmarshaller
    {
        public static JoinMeetingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			JoinMeetingResponse joinMeetingResponse = new JoinMeetingResponse();

			joinMeetingResponse.HttpResponse = _ctx.HttpResponse;
			joinMeetingResponse.ErrorCode = _ctx.IntegerValue("JoinMeeting.ErrorCode");
			joinMeetingResponse.Success = _ctx.BooleanValue("JoinMeeting.Success");
			joinMeetingResponse.RequestId = _ctx.StringValue("JoinMeeting.RequestId");
			joinMeetingResponse.Message = _ctx.StringValue("JoinMeeting.Message");

			JoinMeetingResponse.JoinMeeting_MeetingInfo meetingInfo = new JoinMeetingResponse.JoinMeeting_MeetingInfo();
			meetingInfo.MeetingDomain = _ctx.StringValue("JoinMeeting.MeetingInfo.MeetingDomain");
			meetingInfo.MeetingToken = _ctx.StringValue("JoinMeeting.MeetingInfo.MeetingToken");
			meetingInfo.MeetingCode = _ctx.StringValue("JoinMeeting.MeetingInfo.MeetingCode");
			meetingInfo.MemberUUID = _ctx.StringValue("JoinMeeting.MeetingInfo.MemberUUID");
			meetingInfo.ClientAppId = _ctx.StringValue("JoinMeeting.MeetingInfo.ClientAppId");
			meetingInfo.MeetingUUID = _ctx.StringValue("JoinMeeting.MeetingInfo.MeetingUUID");
			meetingInfo.MeetingAppId = _ctx.StringValue("JoinMeeting.MeetingInfo.MeetingAppId");

			JoinMeetingResponse.JoinMeeting_MeetingInfo.JoinMeeting_SlsInfo slsInfo = new JoinMeetingResponse.JoinMeeting_MeetingInfo.JoinMeeting_SlsInfo();
			slsInfo.LogServiceEndpoint = _ctx.StringValue("JoinMeeting.MeetingInfo.SlsInfo.LogServiceEndpoint");
			slsInfo.Logstore = _ctx.StringValue("JoinMeeting.MeetingInfo.SlsInfo.Logstore");
			slsInfo.Project = _ctx.StringValue("JoinMeeting.MeetingInfo.SlsInfo.Project");
			meetingInfo.SlsInfo = slsInfo;
			joinMeetingResponse.MeetingInfo = meetingInfo;
        
			return joinMeetingResponse;
        }
    }
}
