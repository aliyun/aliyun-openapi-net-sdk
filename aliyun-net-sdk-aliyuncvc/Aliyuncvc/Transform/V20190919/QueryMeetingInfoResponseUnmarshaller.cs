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
    public class QueryMeetingInfoResponseUnmarshaller
    {
        public static QueryMeetingInfoResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMeetingInfoResponse queryMeetingInfoResponse = new QueryMeetingInfoResponse();

			queryMeetingInfoResponse.HttpResponse = context.HttpResponse;
			queryMeetingInfoResponse.ErrorCode = context.IntegerValue("QueryMeetingInfo.ErrorCode");
			queryMeetingInfoResponse.Message = context.StringValue("QueryMeetingInfo.Message");
			queryMeetingInfoResponse.Success = context.BooleanValue("QueryMeetingInfo.Success");
			queryMeetingInfoResponse.RequestId = context.StringValue("QueryMeetingInfo.RequestId");

			QueryMeetingInfoResponse.QueryMeetingInfo_MeetingInfo meetingInfo = new QueryMeetingInfoResponse.QueryMeetingInfo_MeetingInfo();
			meetingInfo.MeetingName = context.StringValue("QueryMeetingInfo.MeetingInfo.MeetingName");
			meetingInfo.ValidDate = context.LongValue("QueryMeetingInfo.MeetingInfo.ValidDate");
			meetingInfo.MeetingCode = context.StringValue("QueryMeetingInfo.MeetingInfo.MeetingCode");
			meetingInfo.CreateDate = context.LongValue("QueryMeetingInfo.MeetingInfo.CreateDate");
			meetingInfo.UserId = context.StringValue("QueryMeetingInfo.MeetingInfo.UserId");
			meetingInfo.MeetingUUID = context.StringValue("QueryMeetingInfo.MeetingInfo.MeetingUUID");

			List<QueryMeetingInfoResponse.QueryMeetingInfo_MeetingInfo.QueryMeetingInfo_MemberListItem> meetingInfo_memberList = new List<QueryMeetingInfoResponse.QueryMeetingInfo_MeetingInfo.QueryMeetingInfo_MemberListItem>();
			for (int i = 0; i < context.Length("QueryMeetingInfo.MeetingInfo.MemberList.Length"); i++) {
				QueryMeetingInfoResponse.QueryMeetingInfo_MeetingInfo.QueryMeetingInfo_MemberListItem memberListItem = new QueryMeetingInfoResponse.QueryMeetingInfo_MeetingInfo.QueryMeetingInfo_MemberListItem();
				memberListItem.UserAvatarUrl = context.StringValue("QueryMeetingInfo.MeetingInfo.MemberList["+ i +"].UserAvatarUrl");
				memberListItem.MemberUUID = context.StringValue("QueryMeetingInfo.MeetingInfo.MemberList["+ i +"].MemberUUID");
				memberListItem.UserName = context.StringValue("QueryMeetingInfo.MeetingInfo.MemberList["+ i +"].UserName");
				memberListItem.UserId = context.StringValue("QueryMeetingInfo.MeetingInfo.MemberList["+ i +"].UserId");
				memberListItem.Status = context.StringValue("QueryMeetingInfo.MeetingInfo.MemberList["+ i +"].Status");

				meetingInfo_memberList.Add(memberListItem);
			}
			meetingInfo.MemberList = meetingInfo_memberList;
			queryMeetingInfoResponse.MeetingInfo = meetingInfo;
        
			return queryMeetingInfoResponse;
        }
    }
}
