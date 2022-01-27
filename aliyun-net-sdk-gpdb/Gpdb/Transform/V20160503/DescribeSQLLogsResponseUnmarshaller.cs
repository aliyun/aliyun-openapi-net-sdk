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
    public class DescribeSQLLogsResponseUnmarshaller
    {
        public static DescribeSQLLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSQLLogsResponse describeSQLLogsResponse = new DescribeSQLLogsResponse();

			describeSQLLogsResponse.HttpResponse = _ctx.HttpResponse;
			describeSQLLogsResponse.PageRecordCount = _ctx.IntegerValue("DescribeSQLLogs.PageRecordCount");
			describeSQLLogsResponse.RequestId = _ctx.StringValue("DescribeSQLLogs.RequestId");
			describeSQLLogsResponse.PageNumber = _ctx.IntegerValue("DescribeSQLLogs.PageNumber");

			List<DescribeSQLLogsResponse.DescribeSQLLogs_Item> describeSQLLogsResponse_items = new List<DescribeSQLLogsResponse.DescribeSQLLogs_Item>();
			for (int i = 0; i < _ctx.Length("DescribeSQLLogs.Items.Length"); i++) {
				DescribeSQLLogsResponse.DescribeSQLLogs_Item item = new DescribeSQLLogsResponse.DescribeSQLLogs_Item();
				item.OperationClass = _ctx.StringValue("DescribeSQLLogs.Items["+ i +"].OperationClass");
				item.ExecuteState = _ctx.StringValue("DescribeSQLLogs.Items["+ i +"].ExecuteState");
				item.ExecuteCost = _ctx.FloatValue("DescribeSQLLogs.Items["+ i +"].ExecuteCost");
				item.SQLText = _ctx.StringValue("DescribeSQLLogs.Items["+ i +"].SQLText");
				item.SourcePort = _ctx.IntegerValue("DescribeSQLLogs.Items["+ i +"].SourcePort");
				item.DBRole = _ctx.StringValue("DescribeSQLLogs.Items["+ i +"].DBRole");
				item.OperationType = _ctx.StringValue("DescribeSQLLogs.Items["+ i +"].OperationType");
				item.SourceIP = _ctx.StringValue("DescribeSQLLogs.Items["+ i +"].SourceIP");
				item.SQLPlan = _ctx.StringValue("DescribeSQLLogs.Items["+ i +"].SQLPlan");
				item.ReturnRowCounts = _ctx.LongValue("DescribeSQLLogs.Items["+ i +"].ReturnRowCounts");
				item.DBName = _ctx.StringValue("DescribeSQLLogs.Items["+ i +"].DBName");
				item.OperationExecuteTime = _ctx.StringValue("DescribeSQLLogs.Items["+ i +"].OperationExecuteTime");
				item.ScanRowCounts = _ctx.LongValue("DescribeSQLLogs.Items["+ i +"].ScanRowCounts");
				item.AccountName = _ctx.StringValue("DescribeSQLLogs.Items["+ i +"].AccountName");

				describeSQLLogsResponse_items.Add(item);
			}
			describeSQLLogsResponse.Items = describeSQLLogsResponse_items;
        
			return describeSQLLogsResponse;
        }
    }
}
