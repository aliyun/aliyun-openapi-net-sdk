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
        public static DescribeAuditRecordsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAuditRecordsResponse describeAuditRecordsResponse = new DescribeAuditRecordsResponse();

			describeAuditRecordsResponse.HttpResponse = context.HttpResponse;
			describeAuditRecordsResponse.RequestId = context.StringValue("DescribeAuditRecords.RequestId");
			describeAuditRecordsResponse.PageNumber = context.IntegerValue("DescribeAuditRecords.PageNumber");
			describeAuditRecordsResponse.PageSize = context.IntegerValue("DescribeAuditRecords.PageSize");
			describeAuditRecordsResponse.TotalRecordCount = context.IntegerValue("DescribeAuditRecords.TotalRecordCount");
			describeAuditRecordsResponse.InstanceName = context.StringValue("DescribeAuditRecords.InstanceName");
			describeAuditRecordsResponse.StartTime = context.StringValue("DescribeAuditRecords.StartTime");
			describeAuditRecordsResponse.EndTime = context.StringValue("DescribeAuditRecords.EndTime");

			List<DescribeAuditRecordsResponse.DescribeAuditRecords_SQL> describeAuditRecordsResponse_items = new List<DescribeAuditRecordsResponse.DescribeAuditRecords_SQL>();
			for (int i = 0; i < context.Length("DescribeAuditRecords.Items.Length"); i++) {
				DescribeAuditRecordsResponse.DescribeAuditRecords_SQL sQL = new DescribeAuditRecordsResponse.DescribeAuditRecords_SQL();
				sQL.HostAddress = context.IntegerValue("DescribeAuditRecords.Items["+ i +"].HostAddress");
				sQL.DatabaseName = context.StringValue("DescribeAuditRecords.Items["+ i +"].DatabaseName");
				sQL.IPAddress = context.StringValue("DescribeAuditRecords.Items["+ i +"].IPAddress");
				sQL.SQLText = context.StringValue("DescribeAuditRecords.Items["+ i +"].SQLText");
				sQL.SQLType = context.StringValue("DescribeAuditRecords.Items["+ i +"].SQLType");
				sQL.TotalExecutionTimes = context.StringValue("DescribeAuditRecords.Items["+ i +"].TotalExecutionTimes");
				sQL.ExecuteTime = context.StringValue("DescribeAuditRecords.Items["+ i +"].ExecuteTime");
				sQL.AccountName = context.StringValue("DescribeAuditRecords.Items["+ i +"].AccountName");

				describeAuditRecordsResponse_items.Add(sQL);
			}
			describeAuditRecordsResponse.Items = describeAuditRecordsResponse_items;
        
			return describeAuditRecordsResponse;
        }
    }
}
