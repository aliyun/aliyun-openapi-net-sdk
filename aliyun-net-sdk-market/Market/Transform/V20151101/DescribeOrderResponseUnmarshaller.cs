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
using Aliyun.Acs.Market.Model.V20151101;

namespace Aliyun.Acs.Market.Transform.V20151101
{
    public class DescribeOrderResponseUnmarshaller
    {
        public static DescribeOrderResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOrderResponse describeOrderResponse = new DescribeOrderResponse();

			describeOrderResponse.HttpResponse = context.HttpResponse;
			describeOrderResponse.OrderId = context.LongValue("DescribeOrder.OrderId");
			describeOrderResponse.AliUid = context.LongValue("DescribeOrder.AliUid");
			describeOrderResponse.SupplierCompanyName = context.StringValue("DescribeOrder.SupplierCompanyName");
			describeOrderResponse.ProductCode = context.StringValue("DescribeOrder.ProductCode");
			describeOrderResponse.ProductSkuCode = context.StringValue("DescribeOrder.ProductSkuCode");
			describeOrderResponse.ProductName = context.StringValue("DescribeOrder.ProductName");
			describeOrderResponse.PeriodType = context.StringValue("DescribeOrder.PeriodType");
			describeOrderResponse.Quantity = context.IntegerValue("DescribeOrder.Quantity");
			describeOrderResponse.AccountQuantity = context.LongValue("DescribeOrder.AccountQuantity");
			describeOrderResponse.OrderType = context.StringValue("DescribeOrder.OrderType");
			describeOrderResponse.OrderStatus = context.StringValue("DescribeOrder.OrderStatus");
			describeOrderResponse.PayStatus = context.StringValue("DescribeOrder.PayStatus");
			describeOrderResponse.PaidOn = context.LongValue("DescribeOrder.PaidOn");
			describeOrderResponse.CreatedOn = context.LongValue("DescribeOrder.CreatedOn");
			describeOrderResponse.OriginalPrice = context.FloatValue("DescribeOrder.OriginalPrice");
			describeOrderResponse.TotalPrice = context.FloatValue("DescribeOrder.TotalPrice");
			describeOrderResponse.PaymentPrice = context.FloatValue("DescribeOrder.PaymentPrice");
			describeOrderResponse.CouponPrice = context.FloatValue("DescribeOrder.CouponPrice");
			describeOrderResponse.Components = context.StringValue("DescribeOrder.Components");
			describeOrderResponse.RequestId = context.StringValue("DescribeOrder.RequestId");

			List<string> describeOrderResponse_supplierTelephones = new List<string>();
			for (int i = 0; i < context.Length("DescribeOrder.SupplierTelephones.Length"); i++) {
				describeOrderResponse_supplierTelephones.Add(context.StringValue("DescribeOrder.SupplierTelephones["+ i +"]"));
			}
			describeOrderResponse.SupplierTelephones = describeOrderResponse_supplierTelephones;

			List<string> describeOrderResponse_instanceIds = new List<string>();
			for (int i = 0; i < context.Length("DescribeOrder.InstanceIds.Length"); i++) {
				describeOrderResponse_instanceIds.Add(context.StringValue("DescribeOrder.InstanceIds["+ i +"]"));
			}
			describeOrderResponse.InstanceIds = describeOrderResponse_instanceIds;
        
			return describeOrderResponse;
        }
    }
}
