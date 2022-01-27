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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeSQLLogRecordsResponseUnmarshaller
    {
        public static DescribeSQLLogRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSQLLogRecordsResponse describeSQLLogRecordsResponse = new DescribeSQLLogRecordsResponse();

			describeSQLLogRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeSQLLogRecordsResponse.MaxRecordsPerPage = _ctx.IntegerValue("DescribeSQLLogRecords.MaxRecordsPerPage");
			describeSQLLogRecordsResponse.ItemsNumbers = _ctx.IntegerValue("DescribeSQLLogRecords.ItemsNumbers");
			describeSQLLogRecordsResponse.RequestId = _ctx.StringValue("DescribeSQLLogRecords.RequestId");
			describeSQLLogRecordsResponse.EndTime = _ctx.StringValue("DescribeSQLLogRecords.EndTime");
			describeSQLLogRecordsResponse.DBInstanceID = _ctx.StringValue("DescribeSQLLogRecords.DBInstanceID");
			describeSQLLogRecordsResponse.StartTime = _ctx.StringValue("DescribeSQLLogRecords.StartTime");
			describeSQLLogRecordsResponse.TotalRecords = _ctx.IntegerValue("DescribeSQLLogRecords.TotalRecords");
			describeSQLLogRecordsResponse.Finish = _ctx.StringValue("DescribeSQLLogRecords.Finish");
			describeSQLLogRecordsResponse.PageNumbers = _ctx.IntegerValue("DescribeSQLLogRecords.PageNumbers");
			describeSQLLogRecordsResponse.JobId = _ctx.StringValue("DescribeSQLLogRecords.JobId");
			describeSQLLogRecordsResponse.PagingID = _ctx.StringValue("DescribeSQLLogRecords.PagingID");
			describeSQLLogRecordsResponse.DBInstanceName = _ctx.StringValue("DescribeSQLLogRecords.DBInstanceName");

			List<DescribeSQLLogRecordsResponse.DescribeSQLLogRecords_SQLLogRecord> describeSQLLogRecordsResponse_items = new List<DescribeSQLLogRecordsResponse.DescribeSQLLogRecords_SQLLogRecord>();
			for (int i = 0; i < _ctx.Length("DescribeSQLLogRecords.Items.Length"); i++) {
				DescribeSQLLogRecordsResponse.DescribeSQLLogRecords_SQLLogRecord sQLLogRecord = new DescribeSQLLogRecordsResponse.DescribeSQLLogRecords_SQLLogRecord();
				sQLLogRecord.ExecuteTime = _ctx.StringValue("DescribeSQLLogRecords.Items["+ i +"].ExecuteTime");
				sQLLogRecord.InsName = _ctx.StringValue("DescribeSQLLogRecords.Items["+ i +"].InsName");
				sQLLogRecord.HostAddress = _ctx.StringValue("DescribeSQLLogRecords.Items["+ i +"].HostAddress");
				sQLLogRecord.UpdateRows = _ctx.LongValue("DescribeSQLLogRecords.Items["+ i +"].UpdateRows");
				sQLLogRecord.SQLText = _ctx.StringValue("DescribeSQLLogRecords.Items["+ i +"].SQLText");
				sQLLogRecord.OriginTime = _ctx.StringValue("DescribeSQLLogRecords.Items["+ i +"].OriginTime");
				sQLLogRecord.Consume = _ctx.LongValue("DescribeSQLLogRecords.Items["+ i +"].Consume");
				sQLLogRecord.ScanRows = _ctx.LongValue("DescribeSQLLogRecords.Items["+ i +"].ScanRows");
				sQLLogRecord.ThreadID = _ctx.IntegerValue("DescribeSQLLogRecords.Items["+ i +"].ThreadID");
				sQLLogRecord.State = _ctx.StringValue("DescribeSQLLogRecords.Items["+ i +"].State");
				sQLLogRecord.DBName = _ctx.StringValue("DescribeSQLLogRecords.Items["+ i +"].DBName");
				sQLLogRecord.SqlType = _ctx.StringValue("DescribeSQLLogRecords.Items["+ i +"].SqlType");
				sQLLogRecord.Vip = _ctx.StringValue("DescribeSQLLogRecords.Items["+ i +"].Vip");
				sQLLogRecord.AccountName = _ctx.StringValue("DescribeSQLLogRecords.Items["+ i +"].AccountName");

				describeSQLLogRecordsResponse_items.Add(sQLLogRecord);
			}
			describeSQLLogRecordsResponse.Items = describeSQLLogRecordsResponse_items;
        
			return describeSQLLogRecordsResponse;
        }
    }
}
