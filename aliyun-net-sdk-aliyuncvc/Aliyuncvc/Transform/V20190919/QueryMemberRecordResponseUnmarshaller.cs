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
    public class QueryMemberRecordResponseUnmarshaller
    {
        public static QueryMemberRecordResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMemberRecordResponse queryMemberRecordResponse = new QueryMemberRecordResponse();

			queryMemberRecordResponse.HttpResponse = context.HttpResponse;
			queryMemberRecordResponse.ErrorCode = context.IntegerValue("QueryMemberRecord.ErrorCode");
			queryMemberRecordResponse.Message = context.StringValue("QueryMemberRecord.Message");
			queryMemberRecordResponse.Success = context.BooleanValue("QueryMemberRecord.Success");
			queryMemberRecordResponse.RequestId = context.StringValue("QueryMemberRecord.RequestId");

			QueryMemberRecordResponse.QueryMemberRecord_MeetingInfo meetingInfo = new QueryMemberRecordResponse.QueryMemberRecord_MeetingInfo();
			meetingInfo.MeetingName = context.StringValue("QueryMemberRecord.MeetingInfo.MeetingName");
			meetingInfo.MeetingCode = context.StringValue("QueryMemberRecord.MeetingInfo.MeetingCode");
			meetingInfo.Memo = context.StringValue("QueryMemberRecord.MeetingInfo.Memo");
			meetingInfo.UserName = context.StringValue("QueryMemberRecord.MeetingInfo.UserName");
			meetingInfo.CreateDate = context.LongValue("QueryMemberRecord.MeetingInfo.CreateDate");
			meetingInfo.UserId = context.StringValue("QueryMemberRecord.MeetingInfo.UserId");
			meetingInfo.MeetingUUID = context.StringValue("QueryMemberRecord.MeetingInfo.MeetingUUID");

			List<QueryMemberRecordResponse.QueryMemberRecord_MeetingInfo.QueryMemberRecord_MemberRecord> meetingInfo_memberRecordsList = new List<QueryMemberRecordResponse.QueryMemberRecord_MeetingInfo.QueryMemberRecord_MemberRecord>();
			for (int i = 0; i < context.Length("QueryMemberRecord.MeetingInfo.MemberRecordsList.Length"); i++) {
				QueryMemberRecordResponse.QueryMemberRecord_MeetingInfo.QueryMemberRecord_MemberRecord memberRecord = new QueryMemberRecordResponse.QueryMemberRecord_MeetingInfo.QueryMemberRecord_MemberRecord();
				memberRecord.MemberUUID = context.StringValue("QueryMemberRecord.MeetingInfo.MemberRecordsList["+ i +"].MemberUUID");
				memberRecord.UserId = context.StringValue("QueryMemberRecord.MeetingInfo.MemberRecordsList["+ i +"].UserId");
				memberRecord.Status = context.StringValue("QueryMemberRecord.MeetingInfo.MemberRecordsList["+ i +"].Status");

				meetingInfo_memberRecordsList.Add(memberRecord);
			}
			meetingInfo.MemberRecordsList = meetingInfo_memberRecordsList;
			queryMemberRecordResponse.MeetingInfo = meetingInfo;
        
			return queryMemberRecordResponse;
        }
    }
}
