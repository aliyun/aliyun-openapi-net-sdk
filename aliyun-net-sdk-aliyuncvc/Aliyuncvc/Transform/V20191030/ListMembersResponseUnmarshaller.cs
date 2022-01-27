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
        public static ListMembersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMembersResponse listMembersResponse = new ListMembersResponse();

			listMembersResponse.HttpResponse = _ctx.HttpResponse;
			listMembersResponse.ErrorCode = _ctx.IntegerValue("ListMembers.ErrorCode");
			listMembersResponse.Message = _ctx.StringValue("ListMembers.Message");
			listMembersResponse.Success = _ctx.BooleanValue("ListMembers.Success");
			listMembersResponse.RequestId = _ctx.StringValue("ListMembers.RequestId");

			ListMembersResponse.ListMembers_MeetingInfo meetingInfo = new ListMembersResponse.ListMembers_MeetingInfo();
			meetingInfo.MeetingName = _ctx.StringValue("ListMembers.MeetingInfo.MeetingName");
			meetingInfo.MeetingCode = _ctx.StringValue("ListMembers.MeetingInfo.MeetingCode");
			meetingInfo.Memo = _ctx.StringValue("ListMembers.MeetingInfo.Memo");
			meetingInfo.UserName = _ctx.StringValue("ListMembers.MeetingInfo.UserName");
			meetingInfo.CreateTime = _ctx.LongValue("ListMembers.MeetingInfo.CreateTime");
			meetingInfo.UserId = _ctx.StringValue("ListMembers.MeetingInfo.UserId");
			meetingInfo.MeetingUUID = _ctx.StringValue("ListMembers.MeetingInfo.MeetingUUID");

			List<ListMembersResponse.ListMembers_MeetingInfo.ListMembers_MemberRecord> meetingInfo_memberInfos = new List<ListMembersResponse.ListMembers_MeetingInfo.ListMembers_MemberRecord>();
			for (int i = 0; i < _ctx.Length("ListMembers.MeetingInfo.MemberInfos.Length"); i++) {
				ListMembersResponse.ListMembers_MeetingInfo.ListMembers_MemberRecord memberRecord = new ListMembersResponse.ListMembers_MeetingInfo.ListMembers_MemberRecord();
				memberRecord.MemberUUID = _ctx.StringValue("ListMembers.MeetingInfo.MemberInfos["+ i +"].MemberUUID");
				memberRecord.UserId = _ctx.StringValue("ListMembers.MeetingInfo.MemberInfos["+ i +"].UserId");
				memberRecord.Status = _ctx.StringValue("ListMembers.MeetingInfo.MemberInfos["+ i +"].Status");
				memberRecord.BeginTime = _ctx.LongValue("ListMembers.MeetingInfo.MemberInfos["+ i +"].BeginTime");
				memberRecord.EndTime = _ctx.LongValue("ListMembers.MeetingInfo.MemberInfos["+ i +"].EndTime");
				memberRecord.UserName = _ctx.StringValue("ListMembers.MeetingInfo.MemberInfos["+ i +"].UserName");

				meetingInfo_memberInfos.Add(memberRecord);
			}
			meetingInfo.MemberInfos = meetingInfo_memberInfos;
			listMembersResponse.MeetingInfo = meetingInfo;
        
			return listMembersResponse;
        }
    }
}
