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
    public class JoinMeetingInternationalResponseUnmarshaller
    {
        public static JoinMeetingInternationalResponse Unmarshall(UnmarshallerContext context)
        {
			JoinMeetingInternationalResponse joinMeetingInternationalResponse = new JoinMeetingInternationalResponse();

			joinMeetingInternationalResponse.HttpResponse = context.HttpResponse;
			joinMeetingInternationalResponse.ErrorCode = context.IntegerValue("JoinMeetingInternational.ErrorCode");
			joinMeetingInternationalResponse.Success = context.BooleanValue("JoinMeetingInternational.Success");
			joinMeetingInternationalResponse.RequestId = context.StringValue("JoinMeetingInternational.RequestId");
			joinMeetingInternationalResponse.Message = context.StringValue("JoinMeetingInternational.Message");

			JoinMeetingInternationalResponse.JoinMeetingInternational_MeetingInfo meetingInfo = new JoinMeetingInternationalResponse.JoinMeetingInternational_MeetingInfo();
			meetingInfo.MeetingDomain = context.StringValue("JoinMeetingInternational.MeetingInfo.MeetingDomain");
			meetingInfo.MeetingToken = context.StringValue("JoinMeetingInternational.MeetingInfo.MeetingToken");
			meetingInfo.MeetingCode = context.StringValue("JoinMeetingInternational.MeetingInfo.MeetingCode");
			meetingInfo.MemberUUID = context.StringValue("JoinMeetingInternational.MeetingInfo.MemberUUID");
			meetingInfo.ClientAppId = context.StringValue("JoinMeetingInternational.MeetingInfo.ClientAppId");
			meetingInfo.MeetingUUID = context.StringValue("JoinMeetingInternational.MeetingInfo.MeetingUUID");
			meetingInfo.MeetingAppId = context.StringValue("JoinMeetingInternational.MeetingInfo.MeetingAppId");

			JoinMeetingInternationalResponse.JoinMeetingInternational_MeetingInfo.JoinMeetingInternational_SlsInfo slsInfo = new JoinMeetingInternationalResponse.JoinMeetingInternational_MeetingInfo.JoinMeetingInternational_SlsInfo();
			slsInfo.LogServiceEndpoint = context.StringValue("JoinMeetingInternational.MeetingInfo.SlsInfo.LogServiceEndpoint");
			slsInfo.Logstore = context.StringValue("JoinMeetingInternational.MeetingInfo.SlsInfo.Logstore");
			slsInfo.Project = context.StringValue("JoinMeetingInternational.MeetingInfo.SlsInfo.Project");
			meetingInfo.SlsInfo = slsInfo;
			joinMeetingInternationalResponse.MeetingInfo = meetingInfo;
        
			return joinMeetingInternationalResponse;
        }
    }
}
