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
using Aliyun.Acs.linkedmall.Model.V20180116;

namespace Aliyun.Acs.linkedmall.Transform.V20180116
{
    public class QueryLogisticsResponseUnmarshaller
    {
        public static QueryLogisticsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryLogisticsResponse queryLogisticsResponse = new QueryLogisticsResponse();

			queryLogisticsResponse.HttpResponse = context.HttpResponse;
			queryLogisticsResponse.RequestId = context.StringValue("QueryLogistics.RequestId");
			queryLogisticsResponse.Code = context.StringValue("QueryLogistics.Code");
			queryLogisticsResponse.Message = context.StringValue("QueryLogistics.Message");

			List<QueryLogisticsResponse.QueryLogistics_DataItem> queryLogisticsResponse_data = new List<QueryLogisticsResponse.QueryLogistics_DataItem>();
			for (int i = 0; i < context.Length("QueryLogistics.Data.Length"); i++) {
				QueryLogisticsResponse.QueryLogistics_DataItem dataItem = new QueryLogisticsResponse.QueryLogistics_DataItem();
				dataItem.MailNo = context.StringValue("QueryLogistics.Data["+ i +"].MailNo");
				dataItem.DataProvider = context.StringValue("QueryLogistics.Data["+ i +"].DataProvider");
				dataItem.DataProviderTitle = context.StringValue("QueryLogistics.Data["+ i +"].DataProviderTitle");
				dataItem.LogisticsCompanyName = context.StringValue("QueryLogistics.Data["+ i +"].LogisticsCompanyName");

				List<QueryLogisticsResponse.QueryLogistics_DataItem.QueryLogistics_LogisticsDetailListItem> dataItem_logisticsDetailList = new List<QueryLogisticsResponse.QueryLogistics_DataItem.QueryLogistics_LogisticsDetailListItem>();
				for (int j = 0; j < context.Length("QueryLogistics.Data["+ i +"].LogisticsDetailList.Length"); j++) {
					QueryLogisticsResponse.QueryLogistics_DataItem.QueryLogistics_LogisticsDetailListItem logisticsDetailListItem = new QueryLogisticsResponse.QueryLogistics_DataItem.QueryLogistics_LogisticsDetailListItem();
					logisticsDetailListItem.StanderdDesc = context.StringValue("QueryLogistics.Data["+ i +"].LogisticsDetailList["+ j +"].StanderdDesc");
					logisticsDetailListItem.OcurrTimeStr = context.StringValue("QueryLogistics.Data["+ i +"].LogisticsDetailList["+ j +"].OcurrTimeStr");

					dataItem_logisticsDetailList.Add(logisticsDetailListItem);
				}
				dataItem.LogisticsDetailList = dataItem_logisticsDetailList;

				List<QueryLogisticsResponse.QueryLogistics_DataItem.QueryLogistics_GoodsItem> dataItem_goods = new List<QueryLogisticsResponse.QueryLogistics_DataItem.QueryLogistics_GoodsItem>();
				for (int j = 0; j < context.Length("QueryLogistics.Data["+ i +"].Goods.Length"); j++) {
					QueryLogisticsResponse.QueryLogistics_DataItem.QueryLogistics_GoodsItem goodsItem = new QueryLogisticsResponse.QueryLogistics_DataItem.QueryLogistics_GoodsItem();
					goodsItem.GoodName = context.StringValue("QueryLogistics.Data["+ i +"].Goods["+ j +"].GoodName");
					goodsItem.Quantity = context.IntegerValue("QueryLogistics.Data["+ i +"].Goods["+ j +"].Quantity");
					goodsItem.ItemId = context.LongValue("QueryLogistics.Data["+ i +"].Goods["+ j +"].ItemId");

					dataItem_goods.Add(goodsItem);
				}
				dataItem.Goods = dataItem_goods;

				queryLogisticsResponse_data.Add(dataItem);
			}
			queryLogisticsResponse.Data = queryLogisticsResponse_data;
        
			return queryLogisticsResponse;
        }
    }
}
