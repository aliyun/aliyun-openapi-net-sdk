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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Domain.Model.V20160511;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Transform.V20160511
{
    public class QueryOrderResponseUnmarshaller
    {
        public static QueryOrderResponse Unmarshall(UnmarshallerContext context)
        {
			QueryOrderResponse queryOrderResponse = new QueryOrderResponse();

			queryOrderResponse.HttpResponse = context.HttpResponse;
			queryOrderResponse.RequestId = context.StringValue("QueryOrder.RequestId");
			queryOrderResponse.OrderID = context.StringValue("QueryOrder.OrderID");
			queryOrderResponse.UserID = context.StringValue("QueryOrder.UserID");
			queryOrderResponse.Money = context.StringValue("QueryOrder.Money");
			queryOrderResponse.OrderDate = context.StringValue("QueryOrder.OrderDate");
			queryOrderResponse.CheckFlag = context.BooleanValue("QueryOrder.CheckFlag");
			queryOrderResponse.CheckDate = context.StringValue("QueryOrder.CheckDate");
			queryOrderResponse.ValidFlag = context.BooleanValue("QueryOrder.ValidFlag");
			queryOrderResponse.CheckType = context.BooleanValue("QueryOrder.CheckType");

			List<QueryOrderResponse.SubOrderResult> orderProducts = new List<QueryOrderResponse.SubOrderResult>();
			for (int i = 0; i < context.Length("QueryOrder.OrderProducts.Length"); i++) {
				QueryOrderResponse.SubOrderResult subOrderResult = new QueryOrderResponse.SubOrderResult();
				subOrderResult.TrackID = context.StringValue("QueryOrder.OrderProducts["+ i +"].TrackID");
				subOrderResult.OrderID = context.StringValue("QueryOrder.OrderProducts["+ i +"].OrderID");
				subOrderResult.SaleID = context.StringValue("QueryOrder.OrderProducts["+ i +"].SaleID");
				subOrderResult.UserID = context.StringValue("QueryOrder.OrderProducts["+ i +"].UserID");
				subOrderResult.ClassID = context.StringValue("QueryOrder.OrderProducts["+ i +"].ClassID");
				subOrderResult.ProductName = context.StringValue("QueryOrder.OrderProducts["+ i +"].ProductName");
				subOrderResult.RelatedName = context.StringValue("QueryOrder.OrderProducts["+ i +"].RelatedName");
				subOrderResult.ActionType = context.StringValue("QueryOrder.OrderProducts["+ i +"].ActionType");
				subOrderResult.PeriodUnit = context.IntegerValue("QueryOrder.OrderProducts["+ i +"].PeriodUnit");
				subOrderResult.PeriodNum = context.IntegerValue("QueryOrder.OrderProducts["+ i +"].PeriodNum");
				subOrderResult.Amount = context.IntegerValue("QueryOrder.OrderProducts["+ i +"].Amount");
				subOrderResult.OrderDate = context.StringValue("QueryOrder.OrderProducts["+ i +"].OrderDate");
				subOrderResult.CheckFlag = context.BooleanValue("QueryOrder.OrderProducts["+ i +"].CheckFlag");
				subOrderResult.CheckDate = context.StringValue("QueryOrder.OrderProducts["+ i +"].CheckDate");
				subOrderResult.BizStatus = context.IntegerValue("QueryOrder.OrderProducts["+ i +"].BizStatus");
				subOrderResult.UpdateDate = context.StringValue("QueryOrder.OrderProducts["+ i +"].UpdateDate");
				subOrderResult.DeadDate = context.StringValue("QueryOrder.OrderProducts["+ i +"].DeadDate");
				subOrderResult.ValidFlag = context.BooleanValue("QueryOrder.OrderProducts["+ i +"].ValidFlag");
				subOrderResult.Money = context.StringValue("QueryOrder.OrderProducts["+ i +"].Money");
				subOrderResult.ParentSaleID = context.StringValue("QueryOrder.OrderProducts["+ i +"].ParentSaleID");

				orderProducts.Add(subOrderResult);
			}
			queryOrderResponse.OrderProducts = orderProducts;
        
			return queryOrderResponse;
        }
    }
}