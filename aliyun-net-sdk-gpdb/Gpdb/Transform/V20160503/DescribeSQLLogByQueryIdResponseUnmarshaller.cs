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
    public class DescribeSQLLogByQueryIdResponseUnmarshaller
    {
        public static DescribeSQLLogByQueryIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSQLLogByQueryIdResponse describeSQLLogByQueryIdResponse = new DescribeSQLLogByQueryIdResponse();

			describeSQLLogByQueryIdResponse.HttpResponse = _ctx.HttpResponse;
			describeSQLLogByQueryIdResponse.RequestId = _ctx.StringValue("DescribeSQLLogByQueryId.RequestId");

			List<DescribeSQLLogByQueryIdResponse.DescribeSQLLogByQueryId_SQLLog> describeSQLLogByQueryIdResponse_items = new List<DescribeSQLLogByQueryIdResponse.DescribeSQLLogByQueryId_SQLLog>();
			for (int i = 0; i < _ctx.Length("DescribeSQLLogByQueryId.Items.Length"); i++) {
				DescribeSQLLogByQueryIdResponse.DescribeSQLLogByQueryId_SQLLog sQLLog = new DescribeSQLLogByQueryIdResponse.DescribeSQLLogByQueryId_SQLLog();
				sQLLog.OperationClass = _ctx.StringValue("DescribeSQLLogByQueryId.Items["+ i +"].OperationClass");
				sQLLog.ExecuteState = _ctx.StringValue("DescribeSQLLogByQueryId.Items["+ i +"].ExecuteState");
				sQLLog.ExecuteCost = _ctx.FloatValue("DescribeSQLLogByQueryId.Items["+ i +"].ExecuteCost");
				sQLLog.SQLText = _ctx.StringValue("DescribeSQLLogByQueryId.Items["+ i +"].SQLText");
				sQLLog.SourcePort = _ctx.IntegerValue("DescribeSQLLogByQueryId.Items["+ i +"].SourcePort");
				sQLLog.DBRole = _ctx.StringValue("DescribeSQLLogByQueryId.Items["+ i +"].DBRole");
				sQLLog.OperationType = _ctx.StringValue("DescribeSQLLogByQueryId.Items["+ i +"].OperationType");
				sQLLog.SourceIP = _ctx.StringValue("DescribeSQLLogByQueryId.Items["+ i +"].SourceIP");
				sQLLog.SQLPlan = _ctx.StringValue("DescribeSQLLogByQueryId.Items["+ i +"].SQLPlan");
				sQLLog.ReturnRowCounts = _ctx.LongValue("DescribeSQLLogByQueryId.Items["+ i +"].ReturnRowCounts");
				sQLLog.DBName = _ctx.StringValue("DescribeSQLLogByQueryId.Items["+ i +"].DBName");
				sQLLog.OperationExecuteTime = _ctx.StringValue("DescribeSQLLogByQueryId.Items["+ i +"].OperationExecuteTime");
				sQLLog.ScanRowCounts = _ctx.LongValue("DescribeSQLLogByQueryId.Items["+ i +"].ScanRowCounts");
				sQLLog.AccountName = _ctx.StringValue("DescribeSQLLogByQueryId.Items["+ i +"].AccountName");
				sQLLog.QueryId = _ctx.StringValue("DescribeSQLLogByQueryId.Items["+ i +"].QueryId");

				List<string> sQLLog_sliceIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeSQLLogByQueryId.Items["+ i +"].SliceIds.Length"); j++) {
					sQLLog_sliceIds.Add(_ctx.StringValue("DescribeSQLLogByQueryId.Items["+ i +"].SliceIds["+ j +"]"));
				}
				sQLLog.SliceIds = sQLLog_sliceIds;

				describeSQLLogByQueryIdResponse_items.Add(sQLLog);
			}
			describeSQLLogByQueryIdResponse.Items = describeSQLLogByQueryIdResponse_items;
        
			return describeSQLLogByQueryIdResponse;
        }
    }
}
