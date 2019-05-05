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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QueryAccountBookListResponseUnmarshaller
    {
        public static QueryAccountBookListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAccountBookListResponse queryAccountBookListResponse = new QueryAccountBookListResponse();

			queryAccountBookListResponse.HttpResponse = context.HttpResponse;
			queryAccountBookListResponse.RequestId = context.StringValue("QueryAccountBookList.RequestId");
			queryAccountBookListResponse.Code = context.StringValue("QueryAccountBookList.Code");
			queryAccountBookListResponse.Message = context.StringValue("QueryAccountBookList.Message");
			queryAccountBookListResponse.Success = context.BooleanValue("QueryAccountBookList.Success");
			queryAccountBookListResponse.Count = context.IntegerValue("QueryAccountBookList.Count");

			List<QueryAccountBookListResponse.QueryAccountBookList_Data> queryAccountBookListResponse_datas = new List<QueryAccountBookListResponse.QueryAccountBookList_Data>();
			for (int i = 0; i < context.Length("QueryAccountBookList.Datas.Length"); i++) {
				QueryAccountBookListResponse.QueryAccountBookList_Data data = new QueryAccountBookListResponse.QueryAccountBookList_Data();
				data.UserId = context.LongValue("QueryAccountBookList.Datas["+ i +"].UserId");
				data.Bid = context.StringValue("QueryAccountBookList.Datas["+ i +"].Bid");
				data.ItemCode = context.StringValue("QueryAccountBookList.Datas["+ i +"].ItemCode");
				data.Amount = context.StringValue("QueryAccountBookList.Datas["+ i +"].Amount");
				data.EffectTimeStamp = context.LongValue("QueryAccountBookList.Datas["+ i +"].EffectTimeStamp");
				data.InvalidTimeStamp = context.LongValue("QueryAccountBookList.Datas["+ i +"].InvalidTimeStamp");
				data.Currency = context.StringValue("QueryAccountBookList.Datas["+ i +"].Currency");

				queryAccountBookListResponse_datas.Add(data);
			}
			queryAccountBookListResponse.Datas = queryAccountBookListResponse_datas;
        
			return queryAccountBookListResponse;
        }
    }
}
