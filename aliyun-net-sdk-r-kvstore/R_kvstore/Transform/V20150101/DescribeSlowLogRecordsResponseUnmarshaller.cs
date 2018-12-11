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
using Aliyun.Acs.R_kvstore.Model.V20150101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeSlowLogRecordsResponseUnmarshaller
    {
        public static DescribeSlowLogRecordsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSlowLogRecordsResponse describeSlowLogRecordsResponse = new DescribeSlowLogRecordsResponse();

			describeSlowLogRecordsResponse.HttpResponse = context.HttpResponse;
			describeSlowLogRecordsResponse.RequestId = context.StringValue("DescribeSlowLogRecords.RequestId");
			describeSlowLogRecordsResponse.InstanceId = context.StringValue("DescribeSlowLogRecords.InstanceId");
			describeSlowLogRecordsResponse.StartTime = context.StringValue("DescribeSlowLogRecords.StartTime");
			describeSlowLogRecordsResponse.Engine = context.StringValue("DescribeSlowLogRecords.Engine");
			describeSlowLogRecordsResponse.TotalRecordCount = context.IntegerValue("DescribeSlowLogRecords.TotalRecordCount");
			describeSlowLogRecordsResponse.PageNumber = context.IntegerValue("DescribeSlowLogRecords.PageNumber");
			describeSlowLogRecordsResponse.PageRecordCount = context.IntegerValue("DescribeSlowLogRecords.PageRecordCount");

			List<DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_LogRecords> describeSlowLogRecordsResponse_items = new List<DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_LogRecords>();
			for (int i = 0; i < context.Length("DescribeSlowLogRecords.Items.Length"); i++) {
				DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_LogRecords logRecords = new DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_LogRecords();
				logRecords.NodeId = context.StringValue("DescribeSlowLogRecords.Items["+ i +"].NodeId");
				logRecords.IPAddress = context.StringValue("DescribeSlowLogRecords.Items["+ i +"].IPAddress");
				logRecords.DBName = context.StringValue("DescribeSlowLogRecords.Items["+ i +"].DBName");
				logRecords.DataBaseName = context.StringValue("DescribeSlowLogRecords.Items["+ i +"].DataBaseName");
				logRecords.Command = context.StringValue("DescribeSlowLogRecords.Items["+ i +"].Command");
				logRecords.ElapsedTime = context.LongValue("DescribeSlowLogRecords.Items["+ i +"].ElapsedTime");
				logRecords.ExecuteTime = context.StringValue("DescribeSlowLogRecords.Items["+ i +"].ExecuteTime");
				logRecords.Account = context.StringValue("DescribeSlowLogRecords.Items["+ i +"].Account");
				logRecords.AccountName = context.StringValue("DescribeSlowLogRecords.Items["+ i +"].AccountName");

				describeSlowLogRecordsResponse_items.Add(logRecords);
			}
			describeSlowLogRecordsResponse.Items = describeSlowLogRecordsResponse_items;
        
			return describeSlowLogRecordsResponse;
        }
    }
}