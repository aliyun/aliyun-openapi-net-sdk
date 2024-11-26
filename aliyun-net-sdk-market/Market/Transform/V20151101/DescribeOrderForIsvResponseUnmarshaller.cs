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
    public class DescribeOrderForIsvResponseUnmarshaller
    {
        public static DescribeOrderForIsvResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOrderForIsvResponse describeOrderForIsvResponse = new DescribeOrderForIsvResponse();

			describeOrderForIsvResponse.HttpResponse = _ctx.HttpResponse;
			describeOrderForIsvResponse.ProductName = _ctx.StringValue("DescribeOrderForIsv.ProductName");
			describeOrderForIsvResponse.OriginalPrice = _ctx.FloatValue("DescribeOrderForIsv.OriginalPrice");
			describeOrderForIsvResponse.AliUid = _ctx.LongValue("DescribeOrderForIsv.AliUid");
			describeOrderForIsvResponse.CouponPrice = _ctx.FloatValue("DescribeOrderForIsv.CouponPrice");
			describeOrderForIsvResponse.AccountQuantity = _ctx.LongValue("DescribeOrderForIsv.AccountQuantity");
			describeOrderForIsvResponse.PeriodType = _ctx.StringValue("DescribeOrderForIsv.PeriodType");
			describeOrderForIsvResponse.PayStatus = _ctx.StringValue("DescribeOrderForIsv.PayStatus");
			describeOrderForIsvResponse.PaymentPrice = _ctx.FloatValue("DescribeOrderForIsv.PaymentPrice");
			describeOrderForIsvResponse.OrderStatus = _ctx.StringValue("DescribeOrderForIsv.OrderStatus");
			describeOrderForIsvResponse.ProductSkuCode = _ctx.StringValue("DescribeOrderForIsv.ProductSkuCode");
			describeOrderForIsvResponse.PaidOn = _ctx.LongValue("DescribeOrderForIsv.PaidOn");
			describeOrderForIsvResponse.Components = _ctx.StringValue("DescribeOrderForIsv.Components");
			describeOrderForIsvResponse.CreatedOn = _ctx.LongValue("DescribeOrderForIsv.CreatedOn");
			describeOrderForIsvResponse.OrderType = _ctx.StringValue("DescribeOrderForIsv.OrderType");
			describeOrderForIsvResponse.TotalPrice = _ctx.FloatValue("DescribeOrderForIsv.TotalPrice");
			describeOrderForIsvResponse.Quantity = _ctx.IntegerValue("DescribeOrderForIsv.Quantity");
			describeOrderForIsvResponse.OrderId = _ctx.LongValue("DescribeOrderForIsv.OrderId");
			describeOrderForIsvResponse.ProductCode = _ctx.StringValue("DescribeOrderForIsv.ProductCode");
			describeOrderForIsvResponse.RequestId = _ctx.StringValue("DescribeOrderForIsv.RequestId");

			List<string> describeOrderForIsvResponse_instanceIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOrderForIsv.InstanceIds.Length"); i++) {
				describeOrderForIsvResponse_instanceIds.Add(_ctx.StringValue("DescribeOrderForIsv.InstanceIds["+ i +"]"));
			}
			describeOrderForIsvResponse.InstanceIds = describeOrderForIsvResponse_instanceIds;
        
			return describeOrderForIsvResponse;
        }
    }
}
