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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeRenewalPriceResponseUnmarshaller
    {
        public static DescribeRenewalPriceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRenewalPriceResponse describeRenewalPriceResponse = new DescribeRenewalPriceResponse();

			describeRenewalPriceResponse.HttpResponse = _ctx.HttpResponse;
			describeRenewalPriceResponse.RequestId = _ctx.StringValue("DescribeRenewalPrice.RequestId");

			DescribeRenewalPriceResponse.DescribeRenewalPrice_Order order = new DescribeRenewalPriceResponse.DescribeRenewalPrice_Order();
			order.OriginalAmount = _ctx.FloatValue("DescribeRenewalPrice.Order.OriginalAmount");
			order.TradeAmount = _ctx.FloatValue("DescribeRenewalPrice.Order.TradeAmount");
			order.DiscountAmount = _ctx.FloatValue("DescribeRenewalPrice.Order.DiscountAmount");
			order.Currency = _ctx.StringValue("DescribeRenewalPrice.Order.Currency");

			List<string> order_ruleIds1 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeRenewalPrice.Order.RuleIds.Length"); i++) {
				order_ruleIds1.Add(_ctx.StringValue("DescribeRenewalPrice.Order.RuleIds["+ i +"]"));
			}
			order.RuleIds1 = order_ruleIds1;

			List<DescribeRenewalPriceResponse.DescribeRenewalPrice_Order.DescribeRenewalPrice_Coupon> order_coupons = new List<DescribeRenewalPriceResponse.DescribeRenewalPrice_Order.DescribeRenewalPrice_Coupon>();
			for (int i = 0; i < _ctx.Length("DescribeRenewalPrice.Order.Coupons.Length"); i++) {
				DescribeRenewalPriceResponse.DescribeRenewalPrice_Order.DescribeRenewalPrice_Coupon coupon = new DescribeRenewalPriceResponse.DescribeRenewalPrice_Order.DescribeRenewalPrice_Coupon();
				coupon.CouponNo = _ctx.StringValue("DescribeRenewalPrice.Order.Coupons["+ i +"].CouponNo");
				coupon.Name = _ctx.StringValue("DescribeRenewalPrice.Order.Coupons["+ i +"].Name");
				coupon.Description = _ctx.StringValue("DescribeRenewalPrice.Order.Coupons["+ i +"].Description");
				coupon.IsSelected = _ctx.StringValue("DescribeRenewalPrice.Order.Coupons["+ i +"].IsSelected");

				order_coupons.Add(coupon);
			}
			order.Coupons = order_coupons;
			describeRenewalPriceResponse.Order = order;

			List<DescribeRenewalPriceResponse.DescribeRenewalPrice_Rule> describeRenewalPriceResponse_rules = new List<DescribeRenewalPriceResponse.DescribeRenewalPrice_Rule>();
			for (int i = 0; i < _ctx.Length("DescribeRenewalPrice.Rules.Length"); i++) {
				DescribeRenewalPriceResponse.DescribeRenewalPrice_Rule rule = new DescribeRenewalPriceResponse.DescribeRenewalPrice_Rule();
				rule.RuleDescId = _ctx.LongValue("DescribeRenewalPrice.Rules["+ i +"].RuleDescId");
				rule.Name = _ctx.StringValue("DescribeRenewalPrice.Rules["+ i +"].Name");
				rule.Title = _ctx.StringValue("DescribeRenewalPrice.Rules["+ i +"].Title");

				describeRenewalPriceResponse_rules.Add(rule);
			}
			describeRenewalPriceResponse.Rules = describeRenewalPriceResponse_rules;

			List<DescribeRenewalPriceResponse.DescribeRenewalPrice_SubOrder> describeRenewalPriceResponse_subOrders = new List<DescribeRenewalPriceResponse.DescribeRenewalPrice_SubOrder>();
			for (int i = 0; i < _ctx.Length("DescribeRenewalPrice.SubOrders.Length"); i++) {
				DescribeRenewalPriceResponse.DescribeRenewalPrice_SubOrder subOrder = new DescribeRenewalPriceResponse.DescribeRenewalPrice_SubOrder();
				subOrder.OriginalAmount = _ctx.FloatValue("DescribeRenewalPrice.SubOrders["+ i +"].OriginalAmount");
				subOrder.TradeAmount = _ctx.FloatValue("DescribeRenewalPrice.SubOrders["+ i +"].TradeAmount");
				subOrder.DiscountAmount = _ctx.FloatValue("DescribeRenewalPrice.SubOrders["+ i +"].DiscountAmount");
				subOrder.InstanceId = _ctx.StringValue("DescribeRenewalPrice.SubOrders["+ i +"].InstanceId");

				List<string> subOrder_ruleIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeRenewalPrice.SubOrders["+ i +"].RuleIds.Length"); j++) {
					subOrder_ruleIds.Add(_ctx.StringValue("DescribeRenewalPrice.SubOrders["+ i +"].RuleIds["+ j +"]"));
				}
				subOrder.RuleIds = subOrder_ruleIds;

				describeRenewalPriceResponse_subOrders.Add(subOrder);
			}
			describeRenewalPriceResponse.SubOrders = describeRenewalPriceResponse_subOrders;
        
			return describeRenewalPriceResponse;
        }
    }
}
