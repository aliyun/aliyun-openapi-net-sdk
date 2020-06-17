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
    public class GetMembersResponseUnmarshaller
    {
        public static GetMembersResponse Unmarshall(UnmarshallerContext context)
        {
			GetMembersResponse getMembersResponse = new GetMembersResponse();

			getMembersResponse.HttpResponse = context.HttpResponse;
			getMembersResponse.ErrorCode = context.IntegerValue("GetMembers.ErrorCode");
			getMembersResponse.Message = context.StringValue("GetMembers.Message");
			getMembersResponse.Success = context.BooleanValue("GetMembers.Success");
			getMembersResponse.RequestId = context.StringValue("GetMembers.RequestId");

			GetMembersResponse.GetMembers_MeetingInfo meetingInfo = new GetMembersResponse.GetMembers_MeetingInfo();
			meetingInfo.MeetingName = context.StringValue("GetMembers.MeetingInfo.MeetingName");
			meetingInfo.ValidTime = context.LongValue("GetMembers.MeetingInfo.ValidTime");
			meetingInfo.MeetingCode = context.StringValue("GetMembers.MeetingInfo.MeetingCode");
			meetingInfo.CreateTime = context.LongValue("GetMembers.MeetingInfo.CreateTime");
			meetingInfo.UserId = context.StringValue("GetMembers.MeetingInfo.UserId");
			meetingInfo.MeetingUUID = context.StringValue("GetMembers.MeetingInfo.MeetingUUID");

			List<GetMembersResponse.GetMembers_MeetingInfo.GetMembers_MemberListItem> meetingInfo_memberList = new List<GetMembersResponse.GetMembers_MeetingInfo.GetMembers_MemberListItem>();
			for (int i = 0; i < context.Length("GetMembers.MeetingInfo.MemberList.Length"); i++) {
				GetMembersResponse.GetMembers_MeetingInfo.GetMembers_MemberListItem memberListItem = new GetMembersResponse.GetMembers_MeetingInfo.GetMembers_MemberListItem();
				memberListItem.UserAvatarUrl = context.StringValue("GetMembers.MeetingInfo.MemberList["+ i +"].UserAvatarUrl");
				memberListItem.MemberUUID = context.StringValue("GetMembers.MeetingInfo.MemberList["+ i +"].MemberUUID");
				memberListItem.UserName = context.StringValue("GetMembers.MeetingInfo.MemberList["+ i +"].UserName");
				memberListItem.UserId = context.StringValue("GetMembers.MeetingInfo.MemberList["+ i +"].UserId");
				memberListItem.Status = context.StringValue("GetMembers.MeetingInfo.MemberList["+ i +"].Status");

				meetingInfo_memberList.Add(memberListItem);
			}
			meetingInfo.MemberList = meetingInfo_memberList;
			getMembersResponse.MeetingInfo = meetingInfo;
        
			return getMembersResponse;
        }
    }
}
