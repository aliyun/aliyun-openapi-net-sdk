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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeSlowLogRecordsResponseUnmarshaller
    {
        public static DescribeSlowLogRecordsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSlowLogRecordsResponse describeSlowLogRecordsResponse = new DescribeSlowLogRecordsResponse();

			describeSlowLogRecordsResponse.HttpResponse = context.HttpResponse;
			describeSlowLogRecordsResponse.RequestId = context.StringValue("DescribeSlowLogRecords.RequestId");
			describeSlowLogRecordsResponse.TotalCount = context.StringValue("DescribeSlowLogRecords.TotalCount");
			describeSlowLogRecordsResponse.PageNumber = context.StringValue("DescribeSlowLogRecords.PageNumber");
			describeSlowLogRecordsResponse.PageSize = context.StringValue("DescribeSlowLogRecords.PageSize");
			describeSlowLogRecordsResponse.DBClusterId = context.StringValue("DescribeSlowLogRecords.DBClusterId");

			List<DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SlowLogRecord> describeSlowLogRecordsResponse_items = new List<DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SlowLogRecord>();
			for (int i = 0; i < context.Length("DescribeSlowLogRecords.Items.Length"); i++) {
				DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SlowLogRecord slowLogRecord = new DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SlowLogRecord();
				slowLogRecord.HostAddress = context.StringValue("DescribeSlowLogRecords.Items["+ i +"].HostAddress");
				slowLogRecord.DBName = context.StringValue("DescribeSlowLogRecords.Items["+ i +"].DBName");
				slowLogRecord.SQLText = context.StringValue("DescribeSlowLogRecords.Items["+ i +"].SQLText");
				slowLogRecord.QueryTime = context.LongValue("DescribeSlowLogRecords.Items["+ i +"].QueryTime");
				slowLogRecord.ReturnRowCounts = context.LongValue("DescribeSlowLogRecords.Items["+ i +"].ReturnRowCounts");
				slowLogRecord.ExecutionStartTime = context.StringValue("DescribeSlowLogRecords.Items["+ i +"].ExecutionStartTime");
				slowLogRecord.ParseRowCounts = context.LongValue("DescribeSlowLogRecords.Items["+ i +"].ParseRowCounts");
				slowLogRecord.ProcessID = context.StringValue("DescribeSlowLogRecords.Items["+ i +"].ProcessID");
				slowLogRecord.UserName = context.StringValue("DescribeSlowLogRecords.Items["+ i +"].UserName");
				slowLogRecord.ScanSize = context.StringValue("DescribeSlowLogRecords.Items["+ i +"].ScanSize");
				slowLogRecord.PeakMemoryUsage = context.StringValue("DescribeSlowLogRecords.Items["+ i +"].PeakMemoryUsage");
				slowLogRecord.QueueTime = context.LongValue("DescribeSlowLogRecords.Items["+ i +"].QueueTime");
				slowLogRecord.State = context.StringValue("DescribeSlowLogRecords.Items["+ i +"].State");

				describeSlowLogRecordsResponse_items.Add(slowLogRecord);
			}
			describeSlowLogRecordsResponse.Items = describeSlowLogRecordsResponse_items;
        
			return describeSlowLogRecordsResponse;
        }
    }
}
