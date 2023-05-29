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
        public static DescribeOrderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOrderResponse describeOrderResponse = new DescribeOrderResponse();

			describeOrderResponse.HttpResponse = _ctx.HttpResponse;
			describeOrderResponse.ProductName = _ctx.StringValue("DescribeOrder.ProductName");
			describeOrderResponse.SupplierCompanyName = _ctx.StringValue("DescribeOrder.SupplierCompanyName");
			describeOrderResponse.OriginalPrice = _ctx.FloatValue("DescribeOrder.OriginalPrice");
			describeOrderResponse.AliUid = _ctx.LongValue("DescribeOrder.AliUid");
			describeOrderResponse.CouponPrice = _ctx.FloatValue("DescribeOrder.CouponPrice");
			describeOrderResponse.AccountQuantity = _ctx.LongValue("DescribeOrder.AccountQuantity");
			describeOrderResponse.PeriodType = _ctx.StringValue("DescribeOrder.PeriodType");
			describeOrderResponse.RequestId = _ctx.StringValue("DescribeOrder.RequestId");
			describeOrderResponse.PayStatus = _ctx.StringValue("DescribeOrder.PayStatus");
			describeOrderResponse.PaymentPrice = _ctx.FloatValue("DescribeOrder.PaymentPrice");
			describeOrderResponse.OrderStatus = _ctx.StringValue("DescribeOrder.OrderStatus");
			describeOrderResponse.ProductSkuCode = _ctx.StringValue("DescribeOrder.ProductSkuCode");
			describeOrderResponse.PaidOn = _ctx.LongValue("DescribeOrder.PaidOn");
			describeOrderResponse.Components = _ctx.StringValue("DescribeOrder.Components");
			describeOrderResponse.CreatedOn = _ctx.LongValue("DescribeOrder.CreatedOn");
			describeOrderResponse.OrderType = _ctx.StringValue("DescribeOrder.OrderType");
			describeOrderResponse.TotalPrice = _ctx.FloatValue("DescribeOrder.TotalPrice");
			describeOrderResponse.Quantity = _ctx.IntegerValue("DescribeOrder.Quantity");
			describeOrderResponse.OrderId = _ctx.LongValue("DescribeOrder.OrderId");
			describeOrderResponse.ProductCode = _ctx.StringValue("DescribeOrder.ProductCode");

			List<string> describeOrderResponse_supplierTelephones = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOrder.SupplierTelephones.Length"); i++) {
				describeOrderResponse_supplierTelephones.Add(_ctx.StringValue("DescribeOrder.SupplierTelephones["+ i +"]"));
			}
			describeOrderResponse.SupplierTelephones = describeOrderResponse_supplierTelephones;

			List<string> describeOrderResponse_instanceIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOrder.InstanceIds.Length"); i++) {
				describeOrderResponse_instanceIds.Add(_ctx.StringValue("DescribeOrder.InstanceIds["+ i +"]"));
			}
			describeOrderResponse.InstanceIds = describeOrderResponse_instanceIds;
        
			return describeOrderResponse;
        }
    }
}
