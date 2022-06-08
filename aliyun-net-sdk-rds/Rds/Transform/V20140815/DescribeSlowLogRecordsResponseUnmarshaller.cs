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
    public class DescribeSlowLogRecordsResponseUnmarshaller
    {
        public static DescribeSlowLogRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSlowLogRecordsResponse describeSlowLogRecordsResponse = new DescribeSlowLogRecordsResponse();

			describeSlowLogRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeSlowLogRecordsResponse.RowsAffectedCount = _ctx.LongValue("DescribeSlowLogRecords.RowsAffectedCount");
			describeSlowLogRecordsResponse.PageRecordCount = _ctx.IntegerValue("DescribeSlowLogRecords.PageRecordCount");
			describeSlowLogRecordsResponse.WritesIOCount = _ctx.LongValue("DescribeSlowLogRecords.WritesIOCount");
			describeSlowLogRecordsResponse.SQLHash = _ctx.StringValue("DescribeSlowLogRecords.SQLHash");
			describeSlowLogRecordsResponse.LogicalIORead = _ctx.LongValue("DescribeSlowLogRecords.LogicalIORead");
			describeSlowLogRecordsResponse.RequestId = _ctx.StringValue("DescribeSlowLogRecords.RequestId");
			describeSlowLogRecordsResponse.PhysicalIORead = _ctx.LongValue("DescribeSlowLogRecords.PhysicalIORead");
			describeSlowLogRecordsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeSlowLogRecords.TotalRecordCount");
			describeSlowLogRecordsResponse.DBInstanceId = _ctx.StringValue("DescribeSlowLogRecords.DBInstanceId");
			describeSlowLogRecordsResponse.Engine = _ctx.StringValue("DescribeSlowLogRecords.Engine");
			describeSlowLogRecordsResponse.PageNumber = _ctx.IntegerValue("DescribeSlowLogRecords.PageNumber");
			describeSlowLogRecordsResponse.CPUTime = _ctx.LongValue("DescribeSlowLogRecords.CPUTime");
			describeSlowLogRecordsResponse.UserName = _ctx.StringValue("DescribeSlowLogRecords.UserName");
			describeSlowLogRecordsResponse.LastRowsAffectedCount = _ctx.LongValue("DescribeSlowLogRecords.LastRowsAffectedCount");

			List<DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SQLSlowRecord> describeSlowLogRecordsResponse_items = new List<DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SQLSlowRecord>();
			for (int i = 0; i < _ctx.Length("DescribeSlowLogRecords.Items.Length"); i++) {
				DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SQLSlowRecord sQLSlowRecord = new DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SQLSlowRecord();
				sQLSlowRecord.HostAddress = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].HostAddress");
				sQLSlowRecord.RowsAffectedCount = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].RowsAffectedCount");
				sQLSlowRecord.QueryTimes = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].QueryTimes");
				sQLSlowRecord.SQLText = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].SQLText");
				sQLSlowRecord.CpuTime = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].CpuTime");
				sQLSlowRecord.QueryTimeMS = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].QueryTimeMS");
				sQLSlowRecord.ApplicationName = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].ApplicationName");
				sQLSlowRecord.LockTimes = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].LockTimes");
				sQLSlowRecord.ExecutionStartTime = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].ExecutionStartTime");
				sQLSlowRecord.LogicalIORead = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].LogicalIORead");
				sQLSlowRecord.WriteIOCount = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].WriteIOCount");
				sQLSlowRecord.PhysicalIORead = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].PhysicalIORead");
				sQLSlowRecord.ReturnRowCounts = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].ReturnRowCounts");
				sQLSlowRecord.ParseRowCounts = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].ParseRowCounts");
				sQLSlowRecord.DBName = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].DBName");
				sQLSlowRecord.ClientHostName = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].ClientHostName");
				sQLSlowRecord.UserName = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].UserName");
				sQLSlowRecord.LastRowsAffectedCount = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].LastRowsAffectedCount");

				describeSlowLogRecordsResponse_items.Add(sQLSlowRecord);
			}
			describeSlowLogRecordsResponse.Items = describeSlowLogRecordsResponse_items;
        
			return describeSlowLogRecordsResponse;
        }
    }
}
