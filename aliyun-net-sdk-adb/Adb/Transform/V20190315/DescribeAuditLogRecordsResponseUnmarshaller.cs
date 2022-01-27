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
    public class DescribeAuditLogRecordsResponseUnmarshaller
    {
        public static DescribeAuditLogRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAuditLogRecordsResponse describeAuditLogRecordsResponse = new DescribeAuditLogRecordsResponse();

			describeAuditLogRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeAuditLogRecordsResponse.RequestId = _ctx.StringValue("DescribeAuditLogRecords.RequestId");
			describeAuditLogRecordsResponse.TotalCount = _ctx.StringValue("DescribeAuditLogRecords.TotalCount");
			describeAuditLogRecordsResponse.PageNumber = _ctx.StringValue("DescribeAuditLogRecords.PageNumber");
			describeAuditLogRecordsResponse.PageSize = _ctx.StringValue("DescribeAuditLogRecords.PageSize");
			describeAuditLogRecordsResponse.DBClusterId = _ctx.StringValue("DescribeAuditLogRecords.DBClusterId");

			List<DescribeAuditLogRecordsResponse.DescribeAuditLogRecords_SlowLogRecord> describeAuditLogRecordsResponse_items = new List<DescribeAuditLogRecordsResponse.DescribeAuditLogRecords_SlowLogRecord>();
			for (int i = 0; i < _ctx.Length("DescribeAuditLogRecords.Items.Length"); i++) {
				DescribeAuditLogRecordsResponse.DescribeAuditLogRecords_SlowLogRecord slowLogRecord = new DescribeAuditLogRecordsResponse.DescribeAuditLogRecords_SlowLogRecord();
				slowLogRecord.HostAddress = _ctx.StringValue("DescribeAuditLogRecords.Items["+ i +"].HostAddress");
				slowLogRecord.DBName = _ctx.StringValue("DescribeAuditLogRecords.Items["+ i +"].DBName");
				slowLogRecord.SQLText = _ctx.StringValue("DescribeAuditLogRecords.Items["+ i +"].SQLText");
				slowLogRecord.SQLType = _ctx.StringValue("DescribeAuditLogRecords.Items["+ i +"].SQLType");
				slowLogRecord.ConnId = _ctx.StringValue("DescribeAuditLogRecords.Items["+ i +"].ConnId");
				slowLogRecord.ExecuteTime = _ctx.StringValue("DescribeAuditLogRecords.Items["+ i +"].ExecuteTime");
				slowLogRecord.Succeed = _ctx.StringValue("DescribeAuditLogRecords.Items["+ i +"].Succeed");
				slowLogRecord.TotalTime = _ctx.StringValue("DescribeAuditLogRecords.Items["+ i +"].TotalTime");
				slowLogRecord.ProcessID = _ctx.StringValue("DescribeAuditLogRecords.Items["+ i +"].ProcessID");

				describeAuditLogRecordsResponse_items.Add(slowLogRecord);
			}
			describeAuditLogRecordsResponse.Items = describeAuditLogRecordsResponse_items;
        
			return describeAuditLogRecordsResponse;
        }
    }
}
