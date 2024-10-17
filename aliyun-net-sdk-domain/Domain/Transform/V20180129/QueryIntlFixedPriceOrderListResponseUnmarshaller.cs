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
using Aliyun.Acs.Domain.Model.V20180129;

namespace Aliyun.Acs.Domain.Transform.V20180129
{
    public class QueryIntlFixedPriceOrderListResponseUnmarshaller
    {
        public static QueryIntlFixedPriceOrderListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryIntlFixedPriceOrderListResponse queryIntlFixedPriceOrderListResponse = new QueryIntlFixedPriceOrderListResponse();

			queryIntlFixedPriceOrderListResponse.HttpResponse = _ctx.HttpResponse;
			queryIntlFixedPriceOrderListResponse.RequestId = _ctx.StringValue("QueryIntlFixedPriceOrderList.RequestId");

			QueryIntlFixedPriceOrderListResponse.QueryIntlFixedPriceOrderList_Module module = new QueryIntlFixedPriceOrderListResponse.QueryIntlFixedPriceOrderList_Module();
			module.TotalItemNum = _ctx.IntegerValue("QueryIntlFixedPriceOrderList.Module.TotalItemNum");
			module.CurrentPageNum = _ctx.IntegerValue("QueryIntlFixedPriceOrderList.Module.CurrentPageNum");
			module.PageSize = _ctx.IntegerValue("QueryIntlFixedPriceOrderList.Module.PageSize");
			module.TotalPageNum = _ctx.IntegerValue("QueryIntlFixedPriceOrderList.Module.TotalPageNum");

			List<QueryIntlFixedPriceOrderListResponse.QueryIntlFixedPriceOrderList_Module.QueryIntlFixedPriceOrderList_OrderList> module_data = new List<QueryIntlFixedPriceOrderListResponse.QueryIntlFixedPriceOrderList_Module.QueryIntlFixedPriceOrderList_OrderList>();
			for (int i = 0; i < _ctx.Length("QueryIntlFixedPriceOrderList.Module.Data.Length"); i++) {
				QueryIntlFixedPriceOrderListResponse.QueryIntlFixedPriceOrderList_Module.QueryIntlFixedPriceOrderList_OrderList orderList = new QueryIntlFixedPriceOrderListResponse.QueryIntlFixedPriceOrderList_Module.QueryIntlFixedPriceOrderList_OrderList();
				orderList.OrderType = _ctx.IntegerValue("QueryIntlFixedPriceOrderList.Module.Data["+ i +"].OrderType");
				orderList.BizId = _ctx.StringValue("QueryIntlFixedPriceOrderList.Module.Data["+ i +"].BizId");
				orderList.UserId = _ctx.StringValue("QueryIntlFixedPriceOrderList.Module.Data["+ i +"].UserId");
				orderList.Status = _ctx.IntegerValue("QueryIntlFixedPriceOrderList.Module.Data["+ i +"].Status");
				orderList.Price = _ctx.LongValue("QueryIntlFixedPriceOrderList.Module.Data["+ i +"].Price");
				orderList.Domain = _ctx.StringValue("QueryIntlFixedPriceOrderList.Module.Data["+ i +"].Domain");
				orderList.CreateTime = _ctx.LongValue("QueryIntlFixedPriceOrderList.Module.Data["+ i +"].CreateTime");
				orderList.UpdateTime = _ctx.LongValue("QueryIntlFixedPriceOrderList.Module.Data["+ i +"].UpdateTime");

				module_data.Add(orderList);
			}
			module.Data = module_data;
			queryIntlFixedPriceOrderListResponse.Module = module;
        
			return queryIntlFixedPriceOrderListResponse;
        }
    }
}
