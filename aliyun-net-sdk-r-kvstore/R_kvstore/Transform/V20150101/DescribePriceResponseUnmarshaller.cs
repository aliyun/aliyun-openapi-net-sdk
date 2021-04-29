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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribePriceResponseUnmarshaller
    {
        public static DescribePriceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePriceResponse describePriceResponse = new DescribePriceResponse();

			describePriceResponse.HttpResponse = _ctx.HttpResponse;
			describePriceResponse.RequestId = _ctx.StringValue("DescribePrice.RequestId");
			describePriceResponse.OrderParams = _ctx.StringValue("DescribePrice.OrderParams");

			DescribePriceResponse.DescribePrice_Order order = new DescribePriceResponse.DescribePrice_Order();
			order.OriginalAmount = _ctx.StringValue("DescribePrice.Order.OriginalAmount");
			order.TradeAmount = _ctx.StringValue("DescribePrice.Order.TradeAmount");
			order.DiscountAmount = _ctx.StringValue("DescribePrice.Order.DiscountAmount");
			order.Currency = _ctx.StringValue("DescribePrice.Order.Currency");
			order.HandlingFeeAmount = _ctx.StringValue("DescribePrice.Order.HandlingFeeAmount");

			List<string> order_ruleIds1 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribePrice.Order.RuleIds.Length"); i++) {
				order_ruleIds1.Add(_ctx.StringValue("DescribePrice.Order.RuleIds["+ i +"]"));
			}
			order.RuleIds1 = order_ruleIds1;

			List<DescribePriceResponse.DescribePrice_Order.DescribePrice_Coupon> order_coupons = new List<DescribePriceResponse.DescribePrice_Order.DescribePrice_Coupon>();
			for (int i = 0; i < _ctx.Length("DescribePrice.Order.Coupons.Length"); i++) {
				DescribePriceResponse.DescribePrice_Order.DescribePrice_Coupon coupon = new DescribePriceResponse.DescribePrice_Order.DescribePrice_Coupon();
				coupon.CouponNo = _ctx.StringValue("DescribePrice.Order.Coupons["+ i +"].CouponNo");
				coupon.Name = _ctx.StringValue("DescribePrice.Order.Coupons["+ i +"].Name");
				coupon.Description = _ctx.StringValue("DescribePrice.Order.Coupons["+ i +"].Description");
				coupon.IsSelected = _ctx.StringValue("DescribePrice.Order.Coupons["+ i +"].IsSelected");

				order_coupons.Add(coupon);
			}
			order.Coupons = order_coupons;
			describePriceResponse.Order = order;

			List<DescribePriceResponse.DescribePrice_Rule> describePriceResponse_rules = new List<DescribePriceResponse.DescribePrice_Rule>();
			for (int i = 0; i < _ctx.Length("DescribePrice.Rules.Length"); i++) {
				DescribePriceResponse.DescribePrice_Rule rule = new DescribePriceResponse.DescribePrice_Rule();
				rule.RuleDescId = _ctx.LongValue("DescribePrice.Rules["+ i +"].RuleDescId");
				rule.Name = _ctx.StringValue("DescribePrice.Rules["+ i +"].Name");
				rule.Title = _ctx.StringValue("DescribePrice.Rules["+ i +"].Title");

				describePriceResponse_rules.Add(rule);
			}
			describePriceResponse.Rules = describePriceResponse_rules;

			List<DescribePriceResponse.DescribePrice_SubOrder> describePriceResponse_subOrders = new List<DescribePriceResponse.DescribePrice_SubOrder>();
			for (int i = 0; i < _ctx.Length("DescribePrice.SubOrders.Length"); i++) {
				DescribePriceResponse.DescribePrice_SubOrder subOrder = new DescribePriceResponse.DescribePrice_SubOrder();
				subOrder.OriginalAmount = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].OriginalAmount");
				subOrder.TradeAmount = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].TradeAmount");
				subOrder.DiscountAmount = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].DiscountAmount");
				subOrder.InstanceId = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].InstanceId");

				List<string> subOrder_ruleIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribePrice.SubOrders["+ i +"].RuleIds.Length"); j++) {
					subOrder_ruleIds.Add(_ctx.StringValue("DescribePrice.SubOrders["+ i +"].RuleIds["+ j +"]"));
				}
				subOrder.RuleIds = subOrder_ruleIds;

				describePriceResponse_subOrders.Add(subOrder);
			}
			describePriceResponse.SubOrders = describePriceResponse_subOrders;
        
			return describePriceResponse;
        }
    }
}
