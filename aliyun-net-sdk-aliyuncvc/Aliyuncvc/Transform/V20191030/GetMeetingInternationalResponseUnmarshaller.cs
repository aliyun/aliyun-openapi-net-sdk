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
    public class GetMeetingInternationalResponseUnmarshaller
    {
        public static GetMeetingInternationalResponse Unmarshall(UnmarshallerContext context)
        {
			GetMeetingInternationalResponse getMeetingInternationalResponse = new GetMeetingInternationalResponse();

			getMeetingInternationalResponse.HttpResponse = context.HttpResponse;
			getMeetingInternationalResponse.ErrorCode = context.IntegerValue("GetMeetingInternational.ErrorCode");
			getMeetingInternationalResponse.Message = context.StringValue("GetMeetingInternational.Message");
			getMeetingInternationalResponse.Success = context.BooleanValue("GetMeetingInternational.Success");
			getMeetingInternationalResponse.RequestId = context.StringValue("GetMeetingInternational.RequestId");

			GetMeetingInternationalResponse.GetMeetingInternational_MeetingInfo meetingInfo = new GetMeetingInternationalResponse.GetMeetingInternational_MeetingInfo();
			meetingInfo.MeetingName = context.StringValue("GetMeetingInternational.MeetingInfo.MeetingName");
			meetingInfo.ValidTime = context.LongValue("GetMeetingInternational.MeetingInfo.ValidTime");
			meetingInfo.MeetingCode = context.StringValue("GetMeetingInternational.MeetingInfo.MeetingCode");
			meetingInfo.CreateTime = context.LongValue("GetMeetingInternational.MeetingInfo.CreateTime");
			meetingInfo.UserId = context.StringValue("GetMeetingInternational.MeetingInfo.UserId");
			meetingInfo.MeetingUUID = context.StringValue("GetMeetingInternational.MeetingInfo.MeetingUUID");
			meetingInfo.Password = context.StringValue("GetMeetingInternational.MeetingInfo.Password");

			List<GetMeetingInternationalResponse.GetMeetingInternational_MeetingInfo.GetMeetingInternational_MemberListItem> meetingInfo_memberList = new List<GetMeetingInternationalResponse.GetMeetingInternational_MeetingInfo.GetMeetingInternational_MemberListItem>();
			for (int i = 0; i < context.Length("GetMeetingInternational.MeetingInfo.MemberList.Length"); i++) {
				GetMeetingInternationalResponse.GetMeetingInternational_MeetingInfo.GetMeetingInternational_MemberListItem memberListItem = new GetMeetingInternationalResponse.GetMeetingInternational_MeetingInfo.GetMeetingInternational_MemberListItem();
				memberListItem.UserAvatarUrl = context.StringValue("GetMeetingInternational.MeetingInfo.MemberList["+ i +"].UserAvatarUrl");
				memberListItem.MemberUUID = context.StringValue("GetMeetingInternational.MeetingInfo.MemberList["+ i +"].MemberUUID");
				memberListItem.UserName = context.StringValue("GetMeetingInternational.MeetingInfo.MemberList["+ i +"].UserName");
				memberListItem.UserId = context.StringValue("GetMeetingInternational.MeetingInfo.MemberList["+ i +"].UserId");
				memberListItem.Status = context.StringValue("GetMeetingInternational.MeetingInfo.MemberList["+ i +"].Status");

				meetingInfo_memberList.Add(memberListItem);
			}
			meetingInfo.MemberList = meetingInfo_memberList;
			getMeetingInternationalResponse.MeetingInfo = meetingInfo;
        
			return getMeetingInternationalResponse;
        }
    }
}
