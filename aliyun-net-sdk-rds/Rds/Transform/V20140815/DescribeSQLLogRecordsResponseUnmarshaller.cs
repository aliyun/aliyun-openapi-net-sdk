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
    public class DescribeSQLLogRecordsResponseUnmarshaller
    {
        public static DescribeSQLLogRecordsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSQLLogRecordsResponse describeSQLLogRecordsResponse = new DescribeSQLLogRecordsResponse();

			describeSQLLogRecordsResponse.HttpResponse = context.HttpResponse;
			describeSQLLogRecordsResponse.RequestId = context.StringValue("DescribeSQLLogRecords.RequestId");
			describeSQLLogRecordsResponse.TotalRecordCount = context.IntegerValue("DescribeSQLLogRecords.TotalRecordCount");
			describeSQLLogRecordsResponse.PageNumber = context.IntegerValue("DescribeSQLLogRecords.PageNumber");
			describeSQLLogRecordsResponse.PageRecordCount = context.IntegerValue("DescribeSQLLogRecords.PageRecordCount");

			List<DescribeSQLLogRecordsResponse.SQLRecord> items = new List<DescribeSQLLogRecordsResponse.SQLRecord>();
			for (int i = 0; i < context.Length("DescribeSQLLogRecords.Items.Length"); i++) {
				DescribeSQLLogRecordsResponse.SQLRecord sQLRecord = new DescribeSQLLogRecordsResponse.SQLRecord();
				sQLRecord.DBName = context.StringValue("DescribeSQLLogRecords.Items["+ i +"].DBName");
				sQLRecord.AccountName = context.StringValue("DescribeSQLLogRecords.Items["+ i +"].AccountName");
				sQLRecord.HostAddress = context.StringValue("DescribeSQLLogRecords.Items["+ i +"].HostAddress");
				sQLRecord.SQLText = context.StringValue("DescribeSQLLogRecords.Items["+ i +"].SQLText");
				sQLRecord.TotalExecutionTimes = context.LongValue("DescribeSQLLogRecords.Items["+ i +"].TotalExecutionTimes");
				sQLRecord.ReturnRowCounts = context.LongValue("DescribeSQLLogRecords.Items["+ i +"].ReturnRowCounts");
				sQLRecord.ExecuteTime = context.StringValue("DescribeSQLLogRecords.Items["+ i +"].ExecuteTime");
				sQLRecord.ThreadID = context.StringValue("DescribeSQLLogRecords.Items["+ i +"].ThreadID");

				items.Add(sQLRecord);
			}
			describeSQLLogRecordsResponse.Items = items;
        
			return describeSQLLogRecordsResponse;
        }
    }
}