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
        public static GetMeetingInternationalResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMeetingInternationalResponse getMeetingInternationalResponse = new GetMeetingInternationalResponse();

			getMeetingInternationalResponse.HttpResponse = _ctx.HttpResponse;
			getMeetingInternationalResponse.ErrorCode = _ctx.IntegerValue("GetMeetingInternational.ErrorCode");
			getMeetingInternationalResponse.Message = _ctx.StringValue("GetMeetingInternational.Message");
			getMeetingInternationalResponse.Success = _ctx.BooleanValue("GetMeetingInternational.Success");
			getMeetingInternationalResponse.RequestId = _ctx.StringValue("GetMeetingInternational.RequestId");

			GetMeetingInternationalResponse.GetMeetingInternational_MeetingInfo meetingInfo = new GetMeetingInternationalResponse.GetMeetingInternational_MeetingInfo();
			meetingInfo.MeetingName = _ctx.StringValue("GetMeetingInternational.MeetingInfo.MeetingName");
			meetingInfo.ValidTime = _ctx.LongValue("GetMeetingInternational.MeetingInfo.ValidTime");
			meetingInfo.MeetingCode = _ctx.StringValue("GetMeetingInternational.MeetingInfo.MeetingCode");
			meetingInfo.CreateTime = _ctx.LongValue("GetMeetingInternational.MeetingInfo.CreateTime");
			meetingInfo.UserId = _ctx.StringValue("GetMeetingInternational.MeetingInfo.UserId");
			meetingInfo.MeetingUUID = _ctx.StringValue("GetMeetingInternational.MeetingInfo.MeetingUUID");
			meetingInfo.Password = _ctx.StringValue("GetMeetingInternational.MeetingInfo.Password");

			List<GetMeetingInternationalResponse.GetMeetingInternational_MeetingInfo.GetMeetingInternational_MemberListItem> meetingInfo_memberList = new List<GetMeetingInternationalResponse.GetMeetingInternational_MeetingInfo.GetMeetingInternational_MemberListItem>();
			for (int i = 0; i < _ctx.Length("GetMeetingInternational.MeetingInfo.MemberList.Length"); i++) {
				GetMeetingInternationalResponse.GetMeetingInternational_MeetingInfo.GetMeetingInternational_MemberListItem memberListItem = new GetMeetingInternationalResponse.GetMeetingInternational_MeetingInfo.GetMeetingInternational_MemberListItem();
				memberListItem.UserAvatarUrl = _ctx.StringValue("GetMeetingInternational.MeetingInfo.MemberList["+ i +"].UserAvatarUrl");
				memberListItem.MemberUUID = _ctx.StringValue("GetMeetingInternational.MeetingInfo.MemberList["+ i +"].MemberUUID");
				memberListItem.UserName = _ctx.StringValue("GetMeetingInternational.MeetingInfo.MemberList["+ i +"].UserName");
				memberListItem.UserId = _ctx.StringValue("GetMeetingInternational.MeetingInfo.MemberList["+ i +"].UserId");
				memberListItem.Status = _ctx.StringValue("GetMeetingInternational.MeetingInfo.MemberList["+ i +"].Status");

				meetingInfo_memberList.Add(memberListItem);
			}
			meetingInfo.MemberList = meetingInfo_memberList;
			getMeetingInternationalResponse.MeetingInfo = meetingInfo;
        
			return getMeetingInternationalResponse;
        }
    }
}
