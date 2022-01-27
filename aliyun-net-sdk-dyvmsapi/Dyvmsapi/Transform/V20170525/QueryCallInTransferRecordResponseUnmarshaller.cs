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
using Aliyun.Acs.Dyvmsapi.Model.V20170525;

namespace Aliyun.Acs.Dyvmsapi.Transform.V20170525
{
    public class QueryCallInTransferRecordResponseUnmarshaller
    {
        public static QueryCallInTransferRecordResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryCallInTransferRecordResponse queryCallInTransferRecordResponse = new QueryCallInTransferRecordResponse();

			queryCallInTransferRecordResponse.HttpResponse = _ctx.HttpResponse;
			queryCallInTransferRecordResponse.RequestId = _ctx.StringValue("QueryCallInTransferRecord.RequestId");
			queryCallInTransferRecordResponse.Code = _ctx.StringValue("QueryCallInTransferRecord.Code");
			queryCallInTransferRecordResponse.Message = _ctx.StringValue("QueryCallInTransferRecord.Message");

			QueryCallInTransferRecordResponse.QueryCallInTransferRecord_Data data = new QueryCallInTransferRecordResponse.QueryCallInTransferRecord_Data();
			data.Total = _ctx.LongValue("QueryCallInTransferRecord.Data.Total");
			data.PageNo = _ctx.LongValue("QueryCallInTransferRecord.Data.PageNo");
			data.PageSize = _ctx.LongValue("QueryCallInTransferRecord.Data.PageSize");

			List<QueryCallInTransferRecordResponse.QueryCallInTransferRecord_Data.QueryCallInTransferRecord_ValuesItem> data_values = new List<QueryCallInTransferRecordResponse.QueryCallInTransferRecord_Data.QueryCallInTransferRecord_ValuesItem>();
			for (int i = 0; i < _ctx.Length("QueryCallInTransferRecord.Data.Values.Length"); i++) {
				QueryCallInTransferRecordResponse.QueryCallInTransferRecord_Data.QueryCallInTransferRecord_ValuesItem valuesItem = new QueryCallInTransferRecordResponse.QueryCallInTransferRecord_Data.QueryCallInTransferRecord_ValuesItem();
				valuesItem.CallInCaller = _ctx.StringValue("QueryCallInTransferRecord.Data.Values["+ i +"].CallInCaller");
				valuesItem.CallInCalled = _ctx.StringValue("QueryCallInTransferRecord.Data.Values["+ i +"].CallInCalled");
				valuesItem.TransferCaller = _ctx.StringValue("QueryCallInTransferRecord.Data.Values["+ i +"].TransferCaller");
				valuesItem.TransferCalled = _ctx.StringValue("QueryCallInTransferRecord.Data.Values["+ i +"].TransferCalled");
				valuesItem.RecordUrl = _ctx.StringValue("QueryCallInTransferRecord.Data.Values["+ i +"].RecordUrl");
				valuesItem.GmtCreate = _ctx.LongValue("QueryCallInTransferRecord.Data.Values["+ i +"].GmtCreate");

				data_values.Add(valuesItem);
			}
			data.Values = data_values;
			queryCallInTransferRecordResponse.Data = data;
        
			return queryCallInTransferRecordResponse;
        }
    }
}
