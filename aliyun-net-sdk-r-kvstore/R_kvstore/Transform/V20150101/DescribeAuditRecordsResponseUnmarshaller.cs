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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeAuditRecordsResponseUnmarshaller
    {
        public static DescribeAuditRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAuditRecordsResponse describeAuditRecordsResponse = new DescribeAuditRecordsResponse();

			describeAuditRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeAuditRecordsResponse.RequestId = _ctx.StringValue("DescribeAuditRecords.RequestId");
			describeAuditRecordsResponse.PageNumber = _ctx.IntegerValue("DescribeAuditRecords.PageNumber");
			describeAuditRecordsResponse.PageSize = _ctx.IntegerValue("DescribeAuditRecords.PageSize");
			describeAuditRecordsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeAuditRecords.TotalRecordCount");
			describeAuditRecordsResponse.InstanceName = _ctx.StringValue("DescribeAuditRecords.InstanceName");
			describeAuditRecordsResponse.StartTime = _ctx.StringValue("DescribeAuditRecords.StartTime");
			describeAuditRecordsResponse.EndTime = _ctx.StringValue("DescribeAuditRecords.EndTime");

			List<DescribeAuditRecordsResponse.DescribeAuditRecords_SQL> describeAuditRecordsResponse_items = new List<DescribeAuditRecordsResponse.DescribeAuditRecords_SQL>();
			for (int i = 0; i < _ctx.Length("DescribeAuditRecords.Items.Length"); i++) {
				DescribeAuditRecordsResponse.DescribeAuditRecords_SQL sQL = new DescribeAuditRecordsResponse.DescribeAuditRecords_SQL();
				sQL.HostAddress = _ctx.StringValue("DescribeAuditRecords.Items["+ i +"].HostAddress");
				sQL.DatabaseName = _ctx.StringValue("DescribeAuditRecords.Items["+ i +"].DatabaseName");
				sQL.IPAddress = _ctx.StringValue("DescribeAuditRecords.Items["+ i +"].IPAddress");
				sQL.SQLText = _ctx.StringValue("DescribeAuditRecords.Items["+ i +"].SQLText");
				sQL.SQLType = _ctx.StringValue("DescribeAuditRecords.Items["+ i +"].SQLType");
				sQL.TotalExecutionTimes = _ctx.StringValue("DescribeAuditRecords.Items["+ i +"].TotalExecutionTimes");
				sQL.ExecuteTime = _ctx.StringValue("DescribeAuditRecords.Items["+ i +"].ExecuteTime");
				sQL.AccountName = _ctx.StringValue("DescribeAuditRecords.Items["+ i +"].AccountName");
				sQL.NodeId = _ctx.StringValue("DescribeAuditRecords.Items["+ i +"].NodeId");

				describeAuditRecordsResponse_items.Add(sQL);
			}
			describeAuditRecordsResponse.Items = describeAuditRecordsResponse_items;
        
			return describeAuditRecordsResponse;
        }
    }
}
