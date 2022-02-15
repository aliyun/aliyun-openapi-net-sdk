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
using Aliyun.Acs.Copyright.Model.V20190123;

namespace Aliyun.Acs.Copyright.Transform.V20190123
{
    public class QuerySupplementInfoListResponseUnmarshaller
    {
        public static QuerySupplementInfoListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySupplementInfoListResponse querySupplementInfoListResponse = new QuerySupplementInfoListResponse();

			querySupplementInfoListResponse.HttpResponse = _ctx.HttpResponse;
			querySupplementInfoListResponse.RequestId = _ctx.StringValue("QuerySupplementInfoList.RequestId");
			querySupplementInfoListResponse.Success = _ctx.BooleanValue("QuerySupplementInfoList.Success");
			querySupplementInfoListResponse.Message = _ctx.StringValue("QuerySupplementInfoList.Message");

			List<QuerySupplementInfoListResponse.QuerySupplementInfoList_DataItem> querySupplementInfoListResponse_data = new List<QuerySupplementInfoListResponse.QuerySupplementInfoList_DataItem>();
			for (int i = 0; i < _ctx.Length("QuerySupplementInfoList.Data.Length"); i++) {
				QuerySupplementInfoListResponse.QuerySupplementInfoList_DataItem dataItem = new QuerySupplementInfoListResponse.QuerySupplementInfoList_DataItem();
				dataItem.BizId = _ctx.StringValue("QuerySupplementInfoList.Data["+ i +"].BizId");
				dataItem.SupplementId = _ctx.StringValue("QuerySupplementInfoList.Data["+ i +"].SupplementId");
				dataItem.SupplementReason = _ctx.StringValue("QuerySupplementInfoList.Data["+ i +"].SupplementReason");
				dataItem.ReceiveTimestamp = _ctx.LongValue("QuerySupplementInfoList.Data["+ i +"].ReceiveTimestamp");
				dataItem.SupplementFields = _ctx.StringValue("QuerySupplementInfoList.Data["+ i +"].SupplementFields");
				dataItem.SupplementType = _ctx.StringValue("QuerySupplementInfoList.Data["+ i +"].SupplementType");
				dataItem.SupplementFileUrl = _ctx.StringValue("QuerySupplementInfoList.Data["+ i +"].SupplementFileUrl");
				dataItem.AdditionalReason = _ctx.StringValue("QuerySupplementInfoList.Data["+ i +"].AdditionalReason");

				querySupplementInfoListResponse_data.Add(dataItem);
			}
			querySupplementInfoListResponse.Data = querySupplementInfoListResponse_data;
        
			return querySupplementInfoListResponse;
        }
    }
}
