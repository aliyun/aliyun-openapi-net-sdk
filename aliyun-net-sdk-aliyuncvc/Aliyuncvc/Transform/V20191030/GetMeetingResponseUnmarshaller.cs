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
    public class GetMeetingResponseUnmarshaller
    {
        public static GetMeetingResponse Unmarshall(UnmarshallerContext context)
        {
			GetMeetingResponse getMeetingResponse = new GetMeetingResponse();

			getMeetingResponse.HttpResponse = context.HttpResponse;
			getMeetingResponse.ErrorCode = context.IntegerValue("GetMeeting.ErrorCode");
			getMeetingResponse.Message = context.StringValue("GetMeeting.Message");
			getMeetingResponse.Success = context.BooleanValue("GetMeeting.Success");
			getMeetingResponse.RequestId = context.StringValue("GetMeeting.RequestId");

			GetMeetingResponse.GetMeeting_MeetingInfo meetingInfo = new GetMeetingResponse.GetMeeting_MeetingInfo();
			meetingInfo.MeetingName = context.StringValue("GetMeeting.MeetingInfo.MeetingName");
			meetingInfo.ValidTime = context.LongValue("GetMeeting.MeetingInfo.ValidTime");
			meetingInfo.MeetingCode = context.StringValue("GetMeeting.MeetingInfo.MeetingCode");
			meetingInfo.CreateTime = context.LongValue("GetMeeting.MeetingInfo.CreateTime");
			meetingInfo.UserId = context.StringValue("GetMeeting.MeetingInfo.UserId");
			meetingInfo.MeetingUUID = context.StringValue("GetMeeting.MeetingInfo.MeetingUUID");
			meetingInfo.Password = context.StringValue("GetMeeting.MeetingInfo.Password");

			List<GetMeetingResponse.GetMeeting_MeetingInfo.GetMeeting_MemberListItem> meetingInfo_memberList = new List<GetMeetingResponse.GetMeeting_MeetingInfo.GetMeeting_MemberListItem>();
			for (int i = 0; i < context.Length("GetMeeting.MeetingInfo.MemberList.Length"); i++) {
				GetMeetingResponse.GetMeeting_MeetingInfo.GetMeeting_MemberListItem memberListItem = new GetMeetingResponse.GetMeeting_MeetingInfo.GetMeeting_MemberListItem();
				memberListItem.UserAvatarUrl = context.StringValue("GetMeeting.MeetingInfo.MemberList["+ i +"].UserAvatarUrl");
				memberListItem.MemberUUID = context.StringValue("GetMeeting.MeetingInfo.MemberList["+ i +"].MemberUUID");
				memberListItem.UserName = context.StringValue("GetMeeting.MeetingInfo.MemberList["+ i +"].UserName");
				memberListItem.UserId = context.StringValue("GetMeeting.MeetingInfo.MemberList["+ i +"].UserId");
				memberListItem.Status = context.StringValue("GetMeeting.MeetingInfo.MemberList["+ i +"].Status");

				meetingInfo_memberList.Add(memberListItem);
			}
			meetingInfo.MemberList = meetingInfo_memberList;
			getMeetingResponse.MeetingInfo = meetingInfo;
        
			return getMeetingResponse;
        }
    }
}
