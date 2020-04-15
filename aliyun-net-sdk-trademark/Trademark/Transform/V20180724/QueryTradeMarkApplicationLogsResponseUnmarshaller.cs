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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class QueryTradeMarkApplicationLogsResponseUnmarshaller
    {
        public static QueryTradeMarkApplicationLogsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTradeMarkApplicationLogsResponse queryTradeMarkApplicationLogsResponse = new QueryTradeMarkApplicationLogsResponse();

			queryTradeMarkApplicationLogsResponse.HttpResponse = context.HttpResponse;
			queryTradeMarkApplicationLogsResponse.RequestId = context.StringValue("QueryTradeMarkApplicationLogs.RequestId");

			List<QueryTradeMarkApplicationLogsResponse.QueryTradeMarkApplicationLogs_DataItem> queryTradeMarkApplicationLogsResponse_data = new List<QueryTradeMarkApplicationLogsResponse.QueryTradeMarkApplicationLogs_DataItem>();
			for (int i = 0; i < context.Length("QueryTradeMarkApplicationLogs.Data.Length"); i++) {
				QueryTradeMarkApplicationLogsResponse.QueryTradeMarkApplicationLogs_DataItem dataItem = new QueryTradeMarkApplicationLogsResponse.QueryTradeMarkApplicationLogs_DataItem();
				dataItem.BizId = context.StringValue("QueryTradeMarkApplicationLogs.Data["+ i +"].BizId");
				dataItem.Note = context.StringValue("QueryTradeMarkApplicationLogs.Data["+ i +"].Note");
				dataItem.OperateType = context.IntegerValue("QueryTradeMarkApplicationLogs.Data["+ i +"].OperateType");
				dataItem.OperateTime = context.LongValue("QueryTradeMarkApplicationLogs.Data["+ i +"].OperateTime");
				dataItem.BizStatus = context.IntegerValue("QueryTradeMarkApplicationLogs.Data["+ i +"].BizStatus");
				dataItem.ExtendContent = context.StringValue("QueryTradeMarkApplicationLogs.Data["+ i +"].ExtendContent");

				queryTradeMarkApplicationLogsResponse_data.Add(dataItem);
			}
			queryTradeMarkApplicationLogsResponse.Data = queryTradeMarkApplicationLogsResponse_data;
        
			return queryTradeMarkApplicationLogsResponse;
        }
    }
}
