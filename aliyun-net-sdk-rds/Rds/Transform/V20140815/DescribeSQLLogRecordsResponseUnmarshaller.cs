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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeSQLLogRecordsResponseUnmarshaller
    {
        public static DescribeSQLLogRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSQLLogRecordsResponse describeSQLLogRecordsResponse = new DescribeSQLLogRecordsResponse();

			describeSQLLogRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeSQLLogRecordsResponse.RequestId = _ctx.StringValue("DescribeSQLLogRecords.RequestId");
			describeSQLLogRecordsResponse.TotalRecordCount = _ctx.LongValue("DescribeSQLLogRecords.TotalRecordCount");
			describeSQLLogRecordsResponse.PageNumber = _ctx.IntegerValue("DescribeSQLLogRecords.PageNumber");
			describeSQLLogRecordsResponse.PageRecordCount = _ctx.IntegerValue("DescribeSQLLogRecords.PageRecordCount");

			List<DescribeSQLLogRecordsResponse.DescribeSQLLogRecords_SQLRecord> describeSQLLogRecordsResponse_items = new List<DescribeSQLLogRecordsResponse.DescribeSQLLogRecords_SQLRecord>();
			for (int i = 0; i < _ctx.Length("DescribeSQLLogRecords.Items.Length"); i++) {
				DescribeSQLLogRecordsResponse.DescribeSQLLogRecords_SQLRecord sQLRecord = new DescribeSQLLogRecordsResponse.DescribeSQLLogRecords_SQLRecord();
				sQLRecord.DBName = _ctx.StringValue("DescribeSQLLogRecords.Items["+ i +"].DBName");
				sQLRecord.AccountName = _ctx.StringValue("DescribeSQLLogRecords.Items["+ i +"].AccountName");
				sQLRecord.HostAddress = _ctx.StringValue("DescribeSQLLogRecords.Items["+ i +"].HostAddress");
				sQLRecord.SQLText = _ctx.StringValue("DescribeSQLLogRecords.Items["+ i +"].SQLText");
				sQLRecord.TotalExecutionTimes = _ctx.LongValue("DescribeSQLLogRecords.Items["+ i +"].TotalExecutionTimes");
				sQLRecord.ReturnRowCounts = _ctx.LongValue("DescribeSQLLogRecords.Items["+ i +"].ReturnRowCounts");
				sQLRecord.ExecuteTime = _ctx.StringValue("DescribeSQLLogRecords.Items["+ i +"].ExecuteTime");
				sQLRecord.ThreadID = _ctx.StringValue("DescribeSQLLogRecords.Items["+ i +"].ThreadID");

				describeSQLLogRecordsResponse_items.Add(sQLRecord);
			}
			describeSQLLogRecordsResponse.Items = describeSQLLogRecordsResponse_items;
        
			return describeSQLLogRecordsResponse;
        }
    }
}
