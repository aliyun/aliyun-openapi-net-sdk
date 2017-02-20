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
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Transform.V20160511
{
    public class QueryOrderResponseUnmarshaller
    {
        public static QueryOrderResponse Unmarshall(UnmarshallerContext context)
        {
            QueryOrderResponse queryOrderResponse = new QueryOrderResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QueryOrder.RequestId"),
                OrderID = context.StringValue("QueryOrder.OrderID"),
                UserID = context.StringValue("QueryOrder.UserID"),
                Money = context.StringValue("QueryOrder.Money"),
                OrderDate = context.StringValue("QueryOrder.OrderDate"),
                CheckFlag = context.BooleanValue("QueryOrder.CheckFlag"),
                CheckDate = context.StringValue("QueryOrder.CheckDate"),
                ValidFlag = context.BooleanValue("QueryOrder.ValidFlag"),
                CheckType = context.BooleanValue("QueryOrder.CheckType")
            };
            List<QueryOrderResponse.SubOrderResult> orderProducts = new List<QueryOrderResponse.SubOrderResult>();
			for (int i = 0; i < context.Length("QueryOrder.OrderProducts.Length"); i++) {
                QueryOrderResponse.SubOrderResult subOrderResult = new QueryOrderResponse.SubOrderResult()
                {
                    TrackID = context.StringValue($"QueryOrder.OrderProducts[{i}].TrackID"),
                    OrderID = context.StringValue($"QueryOrder.OrderProducts[{i}].OrderID"),
                    SaleID = context.StringValue($"QueryOrder.OrderProducts[{i}].SaleID"),
                    UserID = context.StringValue($"QueryOrder.OrderProducts[{i}].UserID"),
                    ClassID = context.StringValue($"QueryOrder.OrderProducts[{i}].ClassID"),
                    ProductName = context.StringValue($"QueryOrder.OrderProducts[{i}].ProductName"),
                    RelatedName = context.StringValue($"QueryOrder.OrderProducts[{i}].RelatedName"),
                    ActionType = context.StringValue($"QueryOrder.OrderProducts[{i}].ActionType"),
                    PeriodUnit = context.IntegerValue($"QueryOrder.OrderProducts[{i}].PeriodUnit"),
                    PeriodNum = context.IntegerValue($"QueryOrder.OrderProducts[{i}].PeriodNum"),
                    Amount = context.IntegerValue($"QueryOrder.OrderProducts[{i}].Amount"),
                    OrderDate = context.StringValue($"QueryOrder.OrderProducts[{i}].OrderDate"),
                    CheckFlag = context.BooleanValue($"QueryOrder.OrderProducts[{i}].CheckFlag"),
                    CheckDate = context.StringValue($"QueryOrder.OrderProducts[{i}].CheckDate"),
                    BizStatus = context.IntegerValue($"QueryOrder.OrderProducts[{i}].BizStatus"),
                    UpdateDate = context.StringValue($"QueryOrder.OrderProducts[{i}].UpdateDate"),
                    DeadDate = context.StringValue($"QueryOrder.OrderProducts[{i}].DeadDate"),
                    ValidFlag = context.BooleanValue($"QueryOrder.OrderProducts[{i}].ValidFlag"),
                    Money = context.StringValue($"QueryOrder.OrderProducts[{i}].Money"),
                    ParentSaleID = context.StringValue($"QueryOrder.OrderProducts[{i}].ParentSaleID")
                };
                orderProducts.Add(subOrderResult);
			}
			queryOrderResponse.OrderProducts = orderProducts;
        
			return queryOrderResponse;
        }
    }
}