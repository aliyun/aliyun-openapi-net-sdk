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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ccs.Model.V20171001;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ccs.Transform.V20171001
{
    public class QueryHotlineRecordResponseUnmarshaller
    {
        public static QueryHotlineRecordResponse Unmarshall(UnmarshallerContext context)
        {
			QueryHotlineRecordResponse queryHotlineRecordResponse = new QueryHotlineRecordResponse();

			queryHotlineRecordResponse.HttpResponse = context.HttpResponse;
			queryHotlineRecordResponse.RequestId = context.StringValue("QueryHotlineRecord.RequestId");
			queryHotlineRecordResponse.TotalCount = context.IntegerValue("QueryHotlineRecord.TotalCount");
			queryHotlineRecordResponse.PageNum = context.IntegerValue("QueryHotlineRecord.PageNum");
			queryHotlineRecordResponse.PageSize = context.IntegerValue("QueryHotlineRecord.PageSize");

			List<QueryHotlineRecordResponse.QueryHotlineRecord_HotlineRecord> queryHotlineRecordResponse_records = new List<QueryHotlineRecordResponse.QueryHotlineRecord_HotlineRecord>();
			for (int i = 0; i < context.Length("QueryHotlineRecord.Records.Length"); i++) {
				QueryHotlineRecordResponse.QueryHotlineRecord_HotlineRecord hotlineRecord = new QueryHotlineRecordResponse.QueryHotlineRecord_HotlineRecord();
				hotlineRecord.Id = context.StringValue("QueryHotlineRecord.Records["+ i +"].Id");
				hotlineRecord.VisitorId = context.StringValue("QueryHotlineRecord.Records["+ i +"].VisitorId");
				hotlineRecord.VisitorPhone = context.StringValue("QueryHotlineRecord.Records["+ i +"].VisitorPhone");
				hotlineRecord.VisitorProvince = context.StringValue("QueryHotlineRecord.Records["+ i +"].VisitorProvince");
				hotlineRecord.CallType = context.StringValue("QueryHotlineRecord.Records["+ i +"].CallType");
				hotlineRecord.AgentId = context.StringValue("QueryHotlineRecord.Records["+ i +"].AgentId");
				hotlineRecord.AgentName = context.StringValue("QueryHotlineRecord.Records["+ i +"].AgentName");
				hotlineRecord.GroupId = context.StringValue("QueryHotlineRecord.Records["+ i +"].GroupId");
				hotlineRecord.GroupName = context.StringValue("QueryHotlineRecord.Records["+ i +"].GroupName");
				hotlineRecord.CreateTime = context.StringValue("QueryHotlineRecord.Records["+ i +"].CreateTime");
				hotlineRecord.FinishTime = context.StringValue("QueryHotlineRecord.Records["+ i +"].FinishTime");
				hotlineRecord.Status = context.StringValue("QueryHotlineRecord.Records["+ i +"].Status");
				hotlineRecord.Memo = context.StringValue("QueryHotlineRecord.Records["+ i +"].Memo");
				hotlineRecord.HangupType = context.StringValue("QueryHotlineRecord.Records["+ i +"].HangupType");
				hotlineRecord.Satisfaction = context.StringValue("QueryHotlineRecord.Records["+ i +"].Satisfaction");
				hotlineRecord.OutboundTaskId = context.StringValue("QueryHotlineRecord.Records["+ i +"].OutboundTaskId");
				hotlineRecord.Categories = context.StringValue("QueryHotlineRecord.Records["+ i +"].Categories");
				hotlineRecord.CcsInstanceId = context.StringValue("QueryHotlineRecord.Records["+ i +"].CcsInstanceId");
				hotlineRecord.TalkDuration = context.LongValue("QueryHotlineRecord.Records["+ i +"].TalkDuration");

				queryHotlineRecordResponse_records.Add(hotlineRecord);
			}
			queryHotlineRecordResponse.Records = queryHotlineRecordResponse_records;
        
			return queryHotlineRecordResponse;
        }
    }
}