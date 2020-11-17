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
    public class DescribeSlowLogRecordsResponseUnmarshaller
    {
        public static DescribeSlowLogRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSlowLogRecordsResponse describeSlowLogRecordsResponse = new DescribeSlowLogRecordsResponse();

			describeSlowLogRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeSlowLogRecordsResponse.RequestId = _ctx.StringValue("DescribeSlowLogRecords.RequestId");
			describeSlowLogRecordsResponse.DBClusterId = _ctx.StringValue("DescribeSlowLogRecords.DBClusterId");
			describeSlowLogRecordsResponse.Engine = _ctx.StringValue("DescribeSlowLogRecords.Engine");
			describeSlowLogRecordsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeSlowLogRecords.TotalRecordCount");
			describeSlowLogRecordsResponse.PageNumber = _ctx.IntegerValue("DescribeSlowLogRecords.PageNumber");
			describeSlowLogRecordsResponse.PageRecordCount = _ctx.IntegerValue("DescribeSlowLogRecords.PageRecordCount");

			List<DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SQLSlowRecord> describeSlowLogRecordsResponse_items = new List<DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SQLSlowRecord>();
			for (int i = 0; i < _ctx.Length("DescribeSlowLogRecords.Items.Length"); i++) {
				DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SQLSlowRecord sQLSlowRecord = new DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SQLSlowRecord();
				sQLSlowRecord.HostAddress = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].HostAddress");
				sQLSlowRecord.DBName = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].DBName");
				sQLSlowRecord.SQLText = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].SQLText");
				sQLSlowRecord.QueryTimes = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].QueryTimes");
				sQLSlowRecord.LockTimes = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].LockTimes");
				sQLSlowRecord.ParseRowCounts = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].ParseRowCounts");
				sQLSlowRecord.ReturnRowCounts = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].ReturnRowCounts");
				sQLSlowRecord.ExecutionStartTime = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].ExecutionStartTime");
				sQLSlowRecord.DBNodeId = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].DBNodeId");

				describeSlowLogRecordsResponse_items.Add(sQLSlowRecord);
			}
			describeSlowLogRecordsResponse.Items = describeSlowLogRecordsResponse_items;
        
			return describeSlowLogRecordsResponse;
        }
    }
}
