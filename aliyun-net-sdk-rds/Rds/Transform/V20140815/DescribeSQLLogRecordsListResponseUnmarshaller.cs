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
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeSQLLogRecordsListResponseUnmarshaller
    {
        public static DescribeSQLLogRecordsListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSQLLogRecordsListResponse describeSQLLogRecordsListResponse = new DescribeSQLLogRecordsListResponse();

			describeSQLLogRecordsListResponse.HttpResponse = context.HttpResponse;
			describeSQLLogRecordsListResponse.RequestId = context.StringValue("DescribeSQLLogRecordsList.RequestId");
			describeSQLLogRecordsListResponse.MaxRecordsPerPage = context.IntegerValue("DescribeSQLLogRecordsList.MaxRecordsPerPage");
			describeSQLLogRecordsListResponse.ItemsNumbers = context.IntegerValue("DescribeSQLLogRecordsList.ItemsNumbers");
			describeSQLLogRecordsListResponse.EndTime = context.StringValue("DescribeSQLLogRecordsList.EndTime");
			describeSQLLogRecordsListResponse.StartTime = context.StringValue("DescribeSQLLogRecordsList.StartTime");
			describeSQLLogRecordsListResponse.DBInstanceID = context.StringValue("DescribeSQLLogRecordsList.DBInstanceID");
			describeSQLLogRecordsListResponse.TotalRecords = context.IntegerValue("DescribeSQLLogRecordsList.TotalRecords");

			List<DescribeSQLLogRecordsListResponse.DescribeSQLLogRecordsList_SQLLogRecord> describeSQLLogRecordsListResponse_items = new List<DescribeSQLLogRecordsListResponse.DescribeSQLLogRecordsList_SQLLogRecord>();
			for (int i = 0; i < context.Length("DescribeSQLLogRecordsList.Items.Length"); i++) {
				DescribeSQLLogRecordsListResponse.DescribeSQLLogRecordsList_SQLLogRecord sQLLogRecord = new DescribeSQLLogRecordsListResponse.DescribeSQLLogRecordsList_SQLLogRecord();
				sQLLogRecord.DBName = context.StringValue("DescribeSQLLogRecordsList.Items["+ i +"].DBName");
				sQLLogRecord.AccountName = context.StringValue("DescribeSQLLogRecordsList.Items["+ i +"].AccountName");
				sQLLogRecord.HostAddress = context.StringValue("DescribeSQLLogRecordsList.Items["+ i +"].HostAddress");
				sQLLogRecord.SQLText = context.StringValue("DescribeSQLLogRecordsList.Items["+ i +"].SQLText");
				sQLLogRecord.Consume = context.LongValue("DescribeSQLLogRecordsList.Items["+ i +"].Consume");
				sQLLogRecord.ScanRows = context.LongValue("DescribeSQLLogRecordsList.Items["+ i +"].ScanRows");
				sQLLogRecord.UpdateRows = context.LongValue("DescribeSQLLogRecordsList.Items["+ i +"].UpdateRows");
				sQLLogRecord.State = context.IntegerValue("DescribeSQLLogRecordsList.Items["+ i +"].State");
				sQLLogRecord.ExecuteTime = context.StringValue("DescribeSQLLogRecordsList.Items["+ i +"].ExecuteTime");
				sQLLogRecord.ThreadID = context.StringValue("DescribeSQLLogRecordsList.Items["+ i +"].ThreadID");
				sQLLogRecord.SqlType = context.StringValue("DescribeSQLLogRecordsList.Items["+ i +"].SqlType");

				describeSQLLogRecordsListResponse_items.Add(sQLLogRecord);
			}
			describeSQLLogRecordsListResponse.Items = describeSQLLogRecordsListResponse_items;
        
			return describeSQLLogRecordsListResponse;
        }
    }
}