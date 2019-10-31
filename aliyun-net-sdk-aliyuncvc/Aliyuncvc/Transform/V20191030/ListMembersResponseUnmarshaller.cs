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
    public class ListMembersResponseUnmarshaller
    {
        public static ListMembersResponse Unmarshall(UnmarshallerContext context)
        {
			ListMembersResponse listMembersResponse = new ListMembersResponse();

			listMembersResponse.HttpResponse = context.HttpResponse;
			listMembersResponse.ErrorCode = context.IntegerValue("ListMembers.ErrorCode");
			listMembersResponse.Message = context.StringValue("ListMembers.Message");
			listMembersResponse.Success = context.BooleanValue("ListMembers.Success");
			listMembersResponse.RequestId = context.StringValue("ListMembers.RequestId");

			ListMembersResponse.ListMembers_MeetingInfo meetingInfo = new ListMembersResponse.ListMembers_MeetingInfo();
			meetingInfo.MeetingName = context.StringValue("ListMembers.MeetingInfo.MeetingName");
			meetingInfo.MeetingCode = context.StringValue("ListMembers.MeetingInfo.MeetingCode");
			meetingInfo.Memo = context.StringValue("ListMembers.MeetingInfo.Memo");
			meetingInfo.UserName = context.StringValue("ListMembers.MeetingInfo.UserName");
			meetingInfo.CreateTime = context.LongValue("ListMembers.MeetingInfo.CreateTime");
			meetingInfo.UserId = context.StringValue("ListMembers.MeetingInfo.UserId");
			meetingInfo.MeetingUUID = context.StringValue("ListMembers.MeetingInfo.MeetingUUID");

			List<ListMembersResponse.ListMembers_MeetingInfo.ListMembers_MemberRecord> meetingInfo_memberInfos = new List<ListMembersResponse.ListMembers_MeetingInfo.ListMembers_MemberRecord>();
			for (int i = 0; i < context.Length("ListMembers.MeetingInfo.MemberInfos.Length"); i++) {
				ListMembersResponse.ListMembers_MeetingInfo.ListMembers_MemberRecord memberRecord = new ListMembersResponse.ListMembers_MeetingInfo.ListMembers_MemberRecord();
				memberRecord.MemberUUID = context.StringValue("ListMembers.MeetingInfo.MemberInfos["+ i +"].MemberUUID");
				memberRecord.UserId = context.StringValue("ListMembers.MeetingInfo.MemberInfos["+ i +"].UserId");
				memberRecord.Status = context.StringValue("ListMembers.MeetingInfo.MemberInfos["+ i +"].Status");
				memberRecord.BeginTime = context.LongValue("ListMembers.MeetingInfo.MemberInfos["+ i +"].BeginTime");
				memberRecord.EndTime = context.LongValue("ListMembers.MeetingInfo.MemberInfos["+ i +"].EndTime");
				memberRecord.UserName = context.StringValue("ListMembers.MeetingInfo.MemberInfos["+ i +"].UserName");

				meetingInfo_memberInfos.Add(memberRecord);
			}
			meetingInfo.MemberInfos = meetingInfo_memberInfos;
			listMembersResponse.MeetingInfo = meetingInfo;
        
			return listMembersResponse;
        }
    }
}
