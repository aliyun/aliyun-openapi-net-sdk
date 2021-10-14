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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class ListRecentCallDetailRecordsResponseUnmarshaller
    {
        public static ListRecentCallDetailRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRecentCallDetailRecordsResponse listRecentCallDetailRecordsResponse = new ListRecentCallDetailRecordsResponse();

			listRecentCallDetailRecordsResponse.HttpResponse = _ctx.HttpResponse;
			listRecentCallDetailRecordsResponse.Code = _ctx.StringValue("ListRecentCallDetailRecords.Code");
			listRecentCallDetailRecordsResponse.HttpStatusCode = _ctx.IntegerValue("ListRecentCallDetailRecords.HttpStatusCode");
			listRecentCallDetailRecordsResponse.Message = _ctx.StringValue("ListRecentCallDetailRecords.Message");
			listRecentCallDetailRecordsResponse.RequestId = _ctx.StringValue("ListRecentCallDetailRecords.RequestId");

			ListRecentCallDetailRecordsResponse.ListRecentCallDetailRecords_Data data = new ListRecentCallDetailRecordsResponse.ListRecentCallDetailRecords_Data();
			data.PageNumber = _ctx.IntegerValue("ListRecentCallDetailRecords.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListRecentCallDetailRecords.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListRecentCallDetailRecords.Data.TotalCount");

			List<ListRecentCallDetailRecordsResponse.ListRecentCallDetailRecords_Data.ListRecentCallDetailRecords_CallDetailRecord> data_list = new List<ListRecentCallDetailRecordsResponse.ListRecentCallDetailRecords_Data.ListRecentCallDetailRecords_CallDetailRecord>();
			for (int i = 0; i < _ctx.Length("ListRecentCallDetailRecords.Data.List.Length"); i++) {
				ListRecentCallDetailRecordsResponse.ListRecentCallDetailRecords_Data.ListRecentCallDetailRecords_CallDetailRecord callDetailRecord = new ListRecentCallDetailRecordsResponse.ListRecentCallDetailRecords_Data.ListRecentCallDetailRecords_CallDetailRecord();
				callDetailRecord.AgentIds = _ctx.StringValue("ListRecentCallDetailRecords.Data.List["+ i +"].AgentIds");
				callDetailRecord.CallDuration = _ctx.StringValue("ListRecentCallDetailRecords.Data.List["+ i +"].CallDuration");
				callDetailRecord.CalledNumber = _ctx.StringValue("ListRecentCallDetailRecords.Data.List["+ i +"].CalledNumber");
				callDetailRecord.CallingNumber = _ctx.StringValue("ListRecentCallDetailRecords.Data.List["+ i +"].CallingNumber");
				callDetailRecord.ContactDisposition = _ctx.StringValue("ListRecentCallDetailRecords.Data.List["+ i +"].ContactDisposition");
				callDetailRecord.ContactId = _ctx.StringValue("ListRecentCallDetailRecords.Data.List["+ i +"].ContactId");
				callDetailRecord.ContactType = _ctx.StringValue("ListRecentCallDetailRecords.Data.List["+ i +"].ContactType");
				callDetailRecord.Duration = _ctx.LongValue("ListRecentCallDetailRecords.Data.List["+ i +"].Duration");
				callDetailRecord.InstanceId = _ctx.StringValue("ListRecentCallDetailRecords.Data.List["+ i +"].InstanceId");
				callDetailRecord.SkillGroupIds = _ctx.StringValue("ListRecentCallDetailRecords.Data.List["+ i +"].SkillGroupIds");
				callDetailRecord.StartTime = _ctx.LongValue("ListRecentCallDetailRecords.Data.List["+ i +"].StartTime");

				data_list.Add(callDetailRecord);
			}
			data.List = data_list;
			listRecentCallDetailRecordsResponse.Data = data;
        
			return listRecentCallDetailRecordsResponse;
        }
    }
}
