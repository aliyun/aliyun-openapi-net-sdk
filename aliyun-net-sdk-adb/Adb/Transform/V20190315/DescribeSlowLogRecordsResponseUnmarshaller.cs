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
        public static DescribeSlowLogRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSlowLogRecordsResponse describeSlowLogRecordsResponse = new DescribeSlowLogRecordsResponse();

			describeSlowLogRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeSlowLogRecordsResponse.TotalCount = _ctx.StringValue("DescribeSlowLogRecords.TotalCount");
			describeSlowLogRecordsResponse.RequestId = _ctx.StringValue("DescribeSlowLogRecords.RequestId");
			describeSlowLogRecordsResponse.PageSize = _ctx.StringValue("DescribeSlowLogRecords.PageSize");
			describeSlowLogRecordsResponse.PageNumber = _ctx.StringValue("DescribeSlowLogRecords.PageNumber");
			describeSlowLogRecordsResponse.DBClusterId = _ctx.StringValue("DescribeSlowLogRecords.DBClusterId");

			List<DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SlowLogRecord> describeSlowLogRecordsResponse_items = new List<DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SlowLogRecord>();
			for (int i = 0; i < _ctx.Length("DescribeSlowLogRecords.Items.Length"); i++) {
				DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SlowLogRecord slowLogRecord = new DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SlowLogRecord();
				slowLogRecord.OutputSize = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].OutputSize");
				slowLogRecord.UserName = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].UserName");
				slowLogRecord.PeakMemoryUsage = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].PeakMemoryUsage");
				slowLogRecord.ExecutionStartTime = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].ExecutionStartTime");
				slowLogRecord.ParseRowCounts = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].ParseRowCounts");
				slowLogRecord.QueryTime = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].QueryTime");
				slowLogRecord.ScanTime = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].ScanTime");
				slowLogRecord.HostAddress = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].HostAddress");
				slowLogRecord.SQLText = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].SQLText");
				slowLogRecord.WallTime = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].WallTime");
				slowLogRecord.ScanRows = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].ScanRows");
				slowLogRecord.State = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].State");
				slowLogRecord.ReturnRowCounts = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].ReturnRowCounts");
				slowLogRecord.PlanningTime = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].PlanningTime");
				slowLogRecord.DBName = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].DBName");
				slowLogRecord.QueueTime = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].QueueTime");
				slowLogRecord.ProcessID = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].ProcessID");
				slowLogRecord.ScanSize = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].ScanSize");

				describeSlowLogRecordsResponse_items.Add(slowLogRecord);
			}
			describeSlowLogRecordsResponse.Items = describeSlowLogRecordsResponse_items;
        
			return describeSlowLogRecordsResponse;
        }
    }
}
