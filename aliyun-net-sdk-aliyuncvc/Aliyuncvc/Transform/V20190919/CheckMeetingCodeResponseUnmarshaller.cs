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
using Aliyun.Acs.aliyuncvc.Model.V20190919;

namespace Aliyun.Acs.aliyuncvc.Transform.V20190919
{
    public class CheckMeetingCodeResponseUnmarshaller
    {
        public static CheckMeetingCodeResponse Unmarshall(UnmarshallerContext context)
        {
			CheckMeetingCodeResponse checkMeetingCodeResponse = new CheckMeetingCodeResponse();

			checkMeetingCodeResponse.HttpResponse = context.HttpResponse;
			checkMeetingCodeResponse.ErrorCode = context.IntegerValue("CheckMeetingCode.ErrorCode");
			checkMeetingCodeResponse.Success = context.BooleanValue("CheckMeetingCode.Success");
			checkMeetingCodeResponse.RequestId = context.StringValue("CheckMeetingCode.RequestId");
			checkMeetingCodeResponse.Message = context.StringValue("CheckMeetingCode.Message");

			CheckMeetingCodeResponse.CheckMeetingCode_MeetingInfo meetingInfo = new CheckMeetingCodeResponse.CheckMeetingCode_MeetingInfo();
			meetingInfo.MeetingDomain = context.StringValue("CheckMeetingCode.MeetingInfo.MeetingDomain");
			meetingInfo.MeetingToken = context.StringValue("CheckMeetingCode.MeetingInfo.MeetingToken");
			meetingInfo.MeetingCode = context.StringValue("CheckMeetingCode.MeetingInfo.MeetingCode");
			meetingInfo.MemberUUID = context.StringValue("CheckMeetingCode.MeetingInfo.MemberUUID");
			meetingInfo.ClientAppId = context.StringValue("CheckMeetingCode.MeetingInfo.ClientAppId");
			meetingInfo.MeetingUUID = context.StringValue("CheckMeetingCode.MeetingInfo.MeetingUUID");
			meetingInfo.MeetingAppId = context.StringValue("CheckMeetingCode.MeetingInfo.MeetingAppId");

			CheckMeetingCodeResponse.CheckMeetingCode_MeetingInfo.CheckMeetingCode_SlsInfo slsInfo = new CheckMeetingCodeResponse.CheckMeetingCode_MeetingInfo.CheckMeetingCode_SlsInfo();
			slsInfo.LogServiceEndpoint = context.StringValue("CheckMeetingCode.MeetingInfo.SlsInfo.LogServiceEndpoint");
			slsInfo.Logstore = context.StringValue("CheckMeetingCode.MeetingInfo.SlsInfo.Logstore");
			slsInfo.Project = context.StringValue("CheckMeetingCode.MeetingInfo.SlsInfo.Project");
			meetingInfo.SlsInfo = slsInfo;
			checkMeetingCodeResponse.MeetingInfo = meetingInfo;
        
			return checkMeetingCodeResponse;
        }
    }
}
