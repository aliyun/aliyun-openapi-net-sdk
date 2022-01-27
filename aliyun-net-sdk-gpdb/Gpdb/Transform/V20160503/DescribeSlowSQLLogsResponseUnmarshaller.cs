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
using Aliyun.Acs.gpdb.Model.V20160503;

namespace Aliyun.Acs.gpdb.Transform.V20160503
{
    public class DescribeSlowSQLLogsResponseUnmarshaller
    {
        public static DescribeSlowSQLLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSlowSQLLogsResponse describeSlowSQLLogsResponse = new DescribeSlowSQLLogsResponse();

			describeSlowSQLLogsResponse.HttpResponse = _ctx.HttpResponse;
			describeSlowSQLLogsResponse.PageRecordCount = _ctx.IntegerValue("DescribeSlowSQLLogs.PageRecordCount");
			describeSlowSQLLogsResponse.RequestId = _ctx.StringValue("DescribeSlowSQLLogs.RequestId");
			describeSlowSQLLogsResponse.PageNumber = _ctx.IntegerValue("DescribeSlowSQLLogs.PageNumber");

			List<DescribeSlowSQLLogsResponse.DescribeSlowSQLLogs_Item> describeSlowSQLLogsResponse_items = new List<DescribeSlowSQLLogsResponse.DescribeSlowSQLLogs_Item>();
			for (int i = 0; i < _ctx.Length("DescribeSlowSQLLogs.Items.Length"); i++) {
				DescribeSlowSQLLogsResponse.DescribeSlowSQLLogs_Item item = new DescribeSlowSQLLogsResponse.DescribeSlowSQLLogs_Item();
				item.OperationClass = _ctx.StringValue("DescribeSlowSQLLogs.Items["+ i +"].OperationClass");
				item.ExecuteState = _ctx.StringValue("DescribeSlowSQLLogs.Items["+ i +"].ExecuteState");
				item.ExecuteCost = _ctx.FloatValue("DescribeSlowSQLLogs.Items["+ i +"].ExecuteCost");
				item.SQLText = _ctx.StringValue("DescribeSlowSQLLogs.Items["+ i +"].SQLText");
				item.SourcePort = _ctx.IntegerValue("DescribeSlowSQLLogs.Items["+ i +"].SourcePort");
				item.DBRole = _ctx.StringValue("DescribeSlowSQLLogs.Items["+ i +"].DBRole");
				item.OperationType = _ctx.StringValue("DescribeSlowSQLLogs.Items["+ i +"].OperationType");
				item.SourceIP = _ctx.StringValue("DescribeSlowSQLLogs.Items["+ i +"].SourceIP");
				item.SQLPlan = _ctx.StringValue("DescribeSlowSQLLogs.Items["+ i +"].SQLPlan");
				item.ReturnRowCounts = _ctx.LongValue("DescribeSlowSQLLogs.Items["+ i +"].ReturnRowCounts");
				item.DBName = _ctx.StringValue("DescribeSlowSQLLogs.Items["+ i +"].DBName");
				item.OperationExecuteTime = _ctx.StringValue("DescribeSlowSQLLogs.Items["+ i +"].OperationExecuteTime");
				item.ScanRowCounts = _ctx.LongValue("DescribeSlowSQLLogs.Items["+ i +"].ScanRowCounts");
				item.AccountName = _ctx.StringValue("DescribeSlowSQLLogs.Items["+ i +"].AccountName");
				item.QueryId = _ctx.StringValue("DescribeSlowSQLLogs.Items["+ i +"].QueryId");

				describeSlowSQLLogsResponse_items.Add(item);
			}
			describeSlowSQLLogsResponse.Items = describeSlowSQLLogsResponse_items;
        
			return describeSlowSQLLogsResponse;
        }
    }
}
