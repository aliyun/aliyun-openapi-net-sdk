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
using Aliyun.Acs.Dds.Model.V20151201;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeAuditRecordsResponseUnmarshaller
    {
        public static DescribeAuditRecordsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAuditRecordsResponse describeAuditRecordsResponse = new DescribeAuditRecordsResponse();

			describeAuditRecordsResponse.HttpResponse = context.HttpResponse;
			describeAuditRecordsResponse.RequestId = context.StringValue("DescribeAuditRecords.RequestId");
			describeAuditRecordsResponse.TotalRecordCount = context.IntegerValue("DescribeAuditRecords.TotalRecordCount");
			describeAuditRecordsResponse.PageNumber = context.IntegerValue("DescribeAuditRecords.PageNumber");
			describeAuditRecordsResponse.PageRecordCount = context.IntegerValue("DescribeAuditRecords.PageRecordCount");

			List<DescribeAuditRecordsResponse.DescribeAuditRecords_SQLRecord> describeAuditRecordsResponse_items = new List<DescribeAuditRecordsResponse.DescribeAuditRecords_SQLRecord>();
			for (int i = 0; i < context.Length("DescribeAuditRecords.Items.Length"); i++) {
				DescribeAuditRecordsResponse.DescribeAuditRecords_SQLRecord sQLRecord = new DescribeAuditRecordsResponse.DescribeAuditRecords_SQLRecord();
				sQLRecord.DBName = context.StringValue("DescribeAuditRecords.Items["+ i +"].DBName");
				sQLRecord.AccountName = context.StringValue("DescribeAuditRecords.Items["+ i +"].AccountName");
				sQLRecord.HostAddress = context.StringValue("DescribeAuditRecords.Items["+ i +"].HostAddress");
				sQLRecord.Syntax = context.StringValue("DescribeAuditRecords.Items["+ i +"].Syntax");
				sQLRecord.TotalExecutionTimes = context.LongValue("DescribeAuditRecords.Items["+ i +"].TotalExecutionTimes");
				sQLRecord.ReturnRowCounts = context.LongValue("DescribeAuditRecords.Items["+ i +"].ReturnRowCounts");
				sQLRecord.ExecuteTime = context.StringValue("DescribeAuditRecords.Items["+ i +"].ExecuteTime");
				sQLRecord.ThreadID = context.StringValue("DescribeAuditRecords.Items["+ i +"].ThreadID");

				describeAuditRecordsResponse_items.Add(sQLRecord);
			}
			describeAuditRecordsResponse.Items = describeAuditRecordsResponse_items;
        
			return describeAuditRecordsResponse;
        }
    }
}