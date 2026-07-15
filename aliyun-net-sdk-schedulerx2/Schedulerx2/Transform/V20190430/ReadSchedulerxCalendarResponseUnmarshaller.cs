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
using Aliyun.Acs.schedulerx2.Model.V20190430;

namespace Aliyun.Acs.schedulerx2.Transform.V20190430
{
    public class ReadSchedulerxCalendarResponseUnmarshaller
    {
        public static ReadSchedulerxCalendarResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ReadSchedulerxCalendarResponse readSchedulerxCalendarResponse = new ReadSchedulerxCalendarResponse();

			readSchedulerxCalendarResponse.HttpResponse = _ctx.HttpResponse;
			readSchedulerxCalendarResponse.Message = _ctx.StringValue("ReadSchedulerxCalendar.Message");
			readSchedulerxCalendarResponse.RequestId = _ctx.StringValue("ReadSchedulerxCalendar.RequestId");
			readSchedulerxCalendarResponse.Code = _ctx.IntegerValue("ReadSchedulerxCalendar.Code");
			readSchedulerxCalendarResponse.Success = _ctx.BooleanValue("ReadSchedulerxCalendar.Success");

			ReadSchedulerxCalendarResponse.ReadSchedulerxCalendar_AccessDeniedDetail accessDeniedDetail = new ReadSchedulerxCalendarResponse.ReadSchedulerxCalendar_AccessDeniedDetail();
			accessDeniedDetail.PolicyType = _ctx.StringValue("ReadSchedulerxCalendar.AccessDeniedDetail.PolicyType");
			accessDeniedDetail.AuthPrincipalOwnerId = _ctx.StringValue("ReadSchedulerxCalendar.AccessDeniedDetail.AuthPrincipalOwnerId");
			accessDeniedDetail.EncodedDiagnosticMessage = _ctx.StringValue("ReadSchedulerxCalendar.AccessDeniedDetail.EncodedDiagnosticMessage");
			accessDeniedDetail.AuthPrincipalType = _ctx.StringValue("ReadSchedulerxCalendar.AccessDeniedDetail.AuthPrincipalType");
			accessDeniedDetail.AuthPrincipalDisplayName = _ctx.StringValue("ReadSchedulerxCalendar.AccessDeniedDetail.AuthPrincipalDisplayName");
			accessDeniedDetail.NoPermissionType = _ctx.StringValue("ReadSchedulerxCalendar.AccessDeniedDetail.NoPermissionType");
			accessDeniedDetail.AuthAction = _ctx.StringValue("ReadSchedulerxCalendar.AccessDeniedDetail.AuthAction");
			readSchedulerxCalendarResponse.AccessDeniedDetail = accessDeniedDetail;

			ReadSchedulerxCalendarResponse.ReadSchedulerxCalendar_Data data = new ReadSchedulerxCalendarResponse.ReadSchedulerxCalendar_Data();
			data.NextToken = _ctx.StringValue("ReadSchedulerxCalendar.Data.NextToken");
			data.Total = _ctx.LongValue("ReadSchedulerxCalendar.Data.Total");
			data.MaxResults = _ctx.IntegerValue("ReadSchedulerxCalendar.Data.MaxResults");

			List<ReadSchedulerxCalendarResponse.ReadSchedulerxCalendar_Data.ReadSchedulerxCalendar_Record> data_records = new List<ReadSchedulerxCalendarResponse.ReadSchedulerxCalendar_Data.ReadSchedulerxCalendar_Record>();
			for (int i = 0; i < _ctx.Length("ReadSchedulerxCalendar.Data.Records.Length"); i++) {
				ReadSchedulerxCalendarResponse.ReadSchedulerxCalendar_Data.ReadSchedulerxCalendar_Record record = new ReadSchedulerxCalendarResponse.ReadSchedulerxCalendar_Data.ReadSchedulerxCalendar_Record();
				record.Year = _ctx.IntegerValue("ReadSchedulerxCalendar.Data.Records["+ i +"].Year");
				record.SystemCalendar = _ctx.BooleanValue("ReadSchedulerxCalendar.Data.Records["+ i +"].SystemCalendar");
				record.CalendarName = _ctx.StringValue("ReadSchedulerxCalendar.Data.Records["+ i +"].CalendarName");
				record.Creator = _ctx.StringValue("ReadSchedulerxCalendar.Data.Records["+ i +"].Creator");
				record.MonthDaysContent = _ctx.StringValue("ReadSchedulerxCalendar.Data.Records["+ i +"].MonthDaysContent");

				data_records.Add(record);
			}
			data.Records = data_records;
			readSchedulerxCalendarResponse.Data = data;
        
			return readSchedulerxCalendarResponse;
        }
    }
}
