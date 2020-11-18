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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeAuditRecordsResponseUnmarshaller
    {
        public static DescribeAuditRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAuditRecordsResponse describeAuditRecordsResponse = new DescribeAuditRecordsResponse();

			describeAuditRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeAuditRecordsResponse.RequestId = _ctx.StringValue("DescribeAuditRecords.RequestId");
			describeAuditRecordsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeAuditRecords.TotalRecordCount");
			describeAuditRecordsResponse.PageNumber = _ctx.IntegerValue("DescribeAuditRecords.PageNumber");
			describeAuditRecordsResponse.PageRecordCount = _ctx.IntegerValue("DescribeAuditRecords.PageRecordCount");

			List<DescribeAuditRecordsResponse.DescribeAuditRecords_SQLRecord> describeAuditRecordsResponse_items = new List<DescribeAuditRecordsResponse.DescribeAuditRecords_SQLRecord>();
			for (int i = 0; i < _ctx.Length("DescribeAuditRecords.Items.Length"); i++) {
				DescribeAuditRecordsResponse.DescribeAuditRecords_SQLRecord sQLRecord = new DescribeAuditRecordsResponse.DescribeAuditRecords_SQLRecord();
				sQLRecord.DBName = _ctx.StringValue("DescribeAuditRecords.Items["+ i +"].DBName");
				sQLRecord.AccountName = _ctx.StringValue("DescribeAuditRecords.Items["+ i +"].AccountName");
				sQLRecord.HostAddress = _ctx.StringValue("DescribeAuditRecords.Items["+ i +"].HostAddress");
				sQLRecord.Syntax = _ctx.StringValue("DescribeAuditRecords.Items["+ i +"].Syntax");
				sQLRecord.TotalExecutionTimes = _ctx.LongValue("DescribeAuditRecords.Items["+ i +"].TotalExecutionTimes");
				sQLRecord.ReturnRowCounts = _ctx.LongValue("DescribeAuditRecords.Items["+ i +"].ReturnRowCounts");
				sQLRecord.ExecuteTime = _ctx.StringValue("DescribeAuditRecords.Items["+ i +"].ExecuteTime");
				sQLRecord.ThreadID = _ctx.StringValue("DescribeAuditRecords.Items["+ i +"].ThreadID");
				sQLRecord.TableName = _ctx.StringValue("DescribeAuditRecords.Items["+ i +"].TableName");

				describeAuditRecordsResponse_items.Add(sQLRecord);
			}
			describeAuditRecordsResponse.Items = describeAuditRecordsResponse_items;
        
			return describeAuditRecordsResponse;
        }
    }
}
