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
    public class QueryOrderLogisticsResponseUnmarshaller
    {
        public static QueryOrderLogisticsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryOrderLogisticsResponse queryOrderLogisticsResponse = new QueryOrderLogisticsResponse();

			queryOrderLogisticsResponse.HttpResponse = context.HttpResponse;
			queryOrderLogisticsResponse.RequestId = context.StringValue("QueryOrderLogistics.RequestId");
			queryOrderLogisticsResponse.Code = context.StringValue("QueryOrderLogistics.Code");
			queryOrderLogisticsResponse.Message = context.StringValue("QueryOrderLogistics.Message");

			QueryOrderLogisticsResponse.QueryOrderLogistics_OrderLogistics orderLogistics = new QueryOrderLogisticsResponse.QueryOrderLogistics_OrderLogistics();
			orderLogistics.DataProvider = context.StringValue("QueryOrderLogistics.OrderLogistics.DataProvider");
			orderLogistics.DataProviderTitle = context.StringValue("QueryOrderLogistics.OrderLogistics.DataProviderTitle");
			orderLogistics.LogisticsCompanyCode = context.StringValue("QueryOrderLogistics.OrderLogistics.LogisticsCompanyCode");
			orderLogistics.LogisticsCompanyName = context.StringValue("QueryOrderLogistics.OrderLogistics.LogisticsCompanyName");

			QueryOrderLogisticsResponse.QueryOrderLogistics_OrderLogistics.QueryOrderLogistics_Receiver receiver = new QueryOrderLogisticsResponse.QueryOrderLogistics_OrderLogistics.QueryOrderLogistics_Receiver();
			receiver.Address = context.StringValue("QueryOrderLogistics.OrderLogistics.Receiver.Address");
			receiver.Name = context.StringValue("QueryOrderLogistics.OrderLogistics.Receiver.Name");
			receiver.PhoneNumber = context.StringValue("QueryOrderLogistics.OrderLogistics.Receiver.PhoneNumber");
			receiver.ZipCode = context.StringValue("QueryOrderLogistics.OrderLogistics.Receiver.ZipCode");
			orderLogistics.Receiver = receiver;

			QueryOrderLogisticsResponse.QueryOrderLogistics_OrderLogistics.QueryOrderLogistics_Fetcher fetcher = new QueryOrderLogisticsResponse.QueryOrderLogistics_OrderLogistics.QueryOrderLogistics_Fetcher();
			fetcher.Address = context.StringValue("QueryOrderLogistics.OrderLogistics.Fetcher.Address");
			fetcher.Name = context.StringValue("QueryOrderLogistics.OrderLogistics.Fetcher.Name");
			fetcher.PhoneNumber = context.StringValue("QueryOrderLogistics.OrderLogistics.Fetcher.PhoneNumber");
			fetcher.ZipCode = context.StringValue("QueryOrderLogistics.OrderLogistics.Fetcher.ZipCode");
			orderLogistics.Fetcher = fetcher;

			List<QueryOrderLogisticsResponse.QueryOrderLogistics_OrderLogistics.QueryOrderLogistics_LogisticsDetailListItem> orderLogistics_logisticsDetailList = new List<QueryOrderLogisticsResponse.QueryOrderLogistics_OrderLogistics.QueryOrderLogistics_LogisticsDetailListItem>();
			for (int i = 0; i < context.Length("QueryOrderLogistics.OrderLogistics.LogisticsDetailList.Length"); i++) {
				QueryOrderLogisticsResponse.QueryOrderLogistics_OrderLogistics.QueryOrderLogistics_LogisticsDetailListItem logisticsDetailListItem = new QueryOrderLogisticsResponse.QueryOrderLogistics_OrderLogistics.QueryOrderLogistics_LogisticsDetailListItem();
				logisticsDetailListItem.OcurrTimeStr = context.StringValue("QueryOrderLogistics.OrderLogistics.LogisticsDetailList["+ i +"].OcurrTimeStr");
				logisticsDetailListItem.StanderdDesc = context.StringValue("QueryOrderLogistics.OrderLogistics.LogisticsDetailList["+ i +"].StanderdDesc");
				logisticsDetailListItem.StatusIcon = context.StringValue("QueryOrderLogistics.OrderLogistics.LogisticsDetailList["+ i +"].StatusIcon");

				orderLogistics_logisticsDetailList.Add(logisticsDetailListItem);
			}
			orderLogistics.LogisticsDetailList = orderLogistics_logisticsDetailList;
			queryOrderLogisticsResponse.OrderLogistics = orderLogistics;
        
			return queryOrderLogisticsResponse;
        }
    }
}
