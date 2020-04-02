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
    public class QueryOrderInfoAfterSaleResponseUnmarshaller
    {
        public static QueryOrderInfoAfterSaleResponse Unmarshall(UnmarshallerContext context)
        {
			QueryOrderInfoAfterSaleResponse queryOrderInfoAfterSaleResponse = new QueryOrderInfoAfterSaleResponse();

			queryOrderInfoAfterSaleResponse.HttpResponse = context.HttpResponse;
			queryOrderInfoAfterSaleResponse.RequestId = context.StringValue("QueryOrderInfoAfterSale.RequestId");
			queryOrderInfoAfterSaleResponse.Code = context.StringValue("QueryOrderInfoAfterSale.Code");
			queryOrderInfoAfterSaleResponse.Message = context.StringValue("QueryOrderInfoAfterSale.Message");

			QueryOrderInfoAfterSaleResponse.QueryOrderInfoAfterSale_Model model = new QueryOrderInfoAfterSaleResponse.QueryOrderInfoAfterSale_Model();
			model.LmOrderId = context.LongValue("QueryOrderInfoAfterSale.Model.LmOrderId");
			model.TbOrderId = context.LongValue("QueryOrderInfoAfterSale.Model.TbOrderId");
			model.CreateDate = context.StringValue("QueryOrderInfoAfterSale.Model.CreateDate");
			model.CashAmount = context.StringValue("QueryOrderInfoAfterSale.Model.CashAmount");
			model.Points = context.LongValue("QueryOrderInfoAfterSale.Model.Points");
			model.PointsAmount = context.LongValue("QueryOrderInfoAfterSale.Model.PointsAmount");
			model.OrderStatus = context.StringValue("QueryOrderInfoAfterSale.Model.OrderStatus");
			model.ShopName = context.StringValue("QueryOrderInfoAfterSale.Model.ShopName");
			model.RefundStatus = context.StringValue("QueryOrderInfoAfterSale.Model.RefundStatus");
			model.RefundAmount = context.LongValue("QueryOrderInfoAfterSale.Model.RefundAmount");
			model.RefundRate = context.StringValue("QueryOrderInfoAfterSale.Model.RefundRate");
			model.XiaomiCode = context.StringValue("QueryOrderInfoAfterSale.Model.XiaomiCode");
			model.ShopServiceTelephone = context.StringValue("QueryOrderInfoAfterSale.Model.ShopServiceTelephone");
			model.ExtJson = context.StringValue("QueryOrderInfoAfterSale.Model.ExtJson");
			model.RefundPoints = context.LongValue("QueryOrderInfoAfterSale.Model.RefundPoints");

			List<QueryOrderInfoAfterSaleResponse.QueryOrderInfoAfterSale_Model.QueryOrderInfoAfterSale_Logistics> model_logisticsList = new List<QueryOrderInfoAfterSaleResponse.QueryOrderInfoAfterSale_Model.QueryOrderInfoAfterSale_Logistics>();
			for (int i = 0; i < context.Length("QueryOrderInfoAfterSale.Model.LogisticsList.Length"); i++) {
				QueryOrderInfoAfterSaleResponse.QueryOrderInfoAfterSale_Model.QueryOrderInfoAfterSale_Logistics logistics = new QueryOrderInfoAfterSaleResponse.QueryOrderInfoAfterSale_Model.QueryOrderInfoAfterSale_Logistics();
				logistics.LogisticsNo = context.StringValue("QueryOrderInfoAfterSale.Model.LogisticsList["+ i +"].LogisticsNo");
				logistics.LogisticsStatus = context.StringValue("QueryOrderInfoAfterSale.Model.LogisticsList["+ i +"].LogisticsStatus");
				logistics.LogisticsCompanyName = context.StringValue("QueryOrderInfoAfterSale.Model.LogisticsList["+ i +"].LogisticsCompanyName");
				logistics.LogisticsCompanyCode = context.StringValue("QueryOrderInfoAfterSale.Model.LogisticsList["+ i +"].LogisticsCompanyCode");

				model_logisticsList.Add(logistics);
			}
			model.LogisticsList = model_logisticsList;
			queryOrderInfoAfterSaleResponse.Model = model;
        
			return queryOrderInfoAfterSaleResponse;
        }
    }
}
