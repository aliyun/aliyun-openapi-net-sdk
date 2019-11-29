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
using Aliyun.Acs.cloudesl.Model.V20190801;

namespace Aliyun.Acs.cloudesl.Transform.V20190801
{
    public class DescribePayOrdersResponseUnmarshaller
    {
        public static DescribePayOrdersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePayOrdersResponse describePayOrdersResponse = new DescribePayOrdersResponse();

			describePayOrdersResponse.HttpResponse = context.HttpResponse;
			describePayOrdersResponse.ErrorMessage = context.StringValue("DescribePayOrders.ErrorMessage");
			describePayOrdersResponse.TotalCount = context.IntegerValue("DescribePayOrders.TotalCount");
			describePayOrdersResponse.ErrorCode = context.StringValue("DescribePayOrders.ErrorCode");
			describePayOrdersResponse.Message = context.StringValue("DescribePayOrders.Message");
			describePayOrdersResponse.PageSize = context.IntegerValue("DescribePayOrders.PageSize");
			describePayOrdersResponse.DynamicCode = context.StringValue("DescribePayOrders.DynamicCode");
			describePayOrdersResponse.Code = context.StringValue("DescribePayOrders.Code");
			describePayOrdersResponse.DynamicMessage = context.StringValue("DescribePayOrders.DynamicMessage");
			describePayOrdersResponse.RequestId = context.StringValue("DescribePayOrders.RequestId");
			describePayOrdersResponse.Success = context.BooleanValue("DescribePayOrders.Success");
			describePayOrdersResponse.PageNumber = context.IntegerValue("DescribePayOrders.PageNumber");

			List<DescribePayOrdersResponse.DescribePayOrders_PayOrderInfo> describePayOrdersResponse_payOrders = new List<DescribePayOrdersResponse.DescribePayOrders_PayOrderInfo>();
			for (int i = 0; i < context.Length("DescribePayOrders.PayOrders.Length"); i++) {
				DescribePayOrdersResponse.DescribePayOrders_PayOrderInfo payOrderInfo = new DescribePayOrdersResponse.DescribePayOrders_PayOrderInfo();
				payOrderInfo.GmtPay = context.StringValue("DescribePayOrders.PayOrders["+ i +"].GmtPay");
				payOrderInfo.PayAmount = context.FloatValue("DescribePayOrders.PayOrders["+ i +"].PayAmount");
				payOrderInfo.Quantity = context.IntegerValue("DescribePayOrders.PayOrders["+ i +"].Quantity");
				payOrderInfo.OrderType = context.StringValue("DescribePayOrders.PayOrders["+ i +"].OrderType");
				payOrderInfo.IsAccepted = context.BooleanValue("DescribePayOrders.PayOrders["+ i +"].IsAccepted");
				payOrderInfo.OrderId = context.StringValue("DescribePayOrders.PayOrders["+ i +"].OrderId");
				payOrderInfo.OriginalAmount = context.FloatValue("DescribePayOrders.PayOrders["+ i +"].OriginalAmount");
				payOrderInfo.DetailName = context.StringValue("DescribePayOrders.PayOrders["+ i +"].DetailName");
				payOrderInfo.OrderStatus = context.StringValue("DescribePayOrders.PayOrders["+ i +"].OrderStatus");
				payOrderInfo.CommodityCode = context.StringValue("DescribePayOrders.PayOrders["+ i +"].CommodityCode");
				payOrderInfo.CommodityName = context.StringValue("DescribePayOrders.PayOrders["+ i +"].CommodityName");
				payOrderInfo.GmtCreate = context.StringValue("DescribePayOrders.PayOrders["+ i +"].GmtCreate");

				describePayOrdersResponse_payOrders.Add(payOrderInfo);
			}
			describePayOrdersResponse.PayOrders = describePayOrdersResponse_payOrders;
        
			return describePayOrdersResponse;
        }
    }
}
