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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeRenewalPriceResponseUnmarshaller
    {
        public static DescribeRenewalPriceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRenewalPriceResponse describeRenewalPriceResponse = new DescribeRenewalPriceResponse();

			describeRenewalPriceResponse.HttpResponse = context.HttpResponse;
			describeRenewalPriceResponse.RequestId = context.StringValue("DescribeRenewalPrice.RequestId");

			DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo priceInfo = new DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo();
			priceInfo.Currency = context.StringValue("DescribeRenewalPrice.PriceInfo.Currency");
			priceInfo.OriginalPrice = context.FloatValue("DescribeRenewalPrice.PriceInfo.OriginalPrice");
			priceInfo.TradePrice = context.FloatValue("DescribeRenewalPrice.PriceInfo.TradePrice");
			priceInfo.DiscountPrice = context.FloatValue("DescribeRenewalPrice.PriceInfo.DiscountPrice");

			List<string> priceInfo_ruleIds = new List<string>();
			for (int i = 0; i < context.Length("DescribeRenewalPrice.PriceInfo.RuleIds.Length"); i++) {
				priceInfo_ruleIds.Add(context.StringValue("DescribeRenewalPrice.PriceInfo.RuleIds["+ i +"]"));
			}
			priceInfo.RuleIds = priceInfo_ruleIds;

			DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_ActivityInfo activityInfo = new DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_ActivityInfo();
			activityInfo.CheckErrMsg = context.StringValue("DescribeRenewalPrice.PriceInfo.ActivityInfo.CheckErrMsg");
			activityInfo.ErrorCode = context.StringValue("DescribeRenewalPrice.PriceInfo.ActivityInfo.ErrorCode");
			activityInfo.Success = context.StringValue("DescribeRenewalPrice.PriceInfo.ActivityInfo.Success");
			priceInfo.ActivityInfo = activityInfo;

			List<DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Coupon> priceInfo_coupons = new List<DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Coupon>();
			for (int i = 0; i < context.Length("DescribeRenewalPrice.PriceInfo.Coupons.Length"); i++) {
				DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Coupon coupon = new DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Coupon();
				coupon.CouponNo = context.StringValue("DescribeRenewalPrice.PriceInfo.Coupons["+ i +"].CouponNo");
				coupon.Name = context.StringValue("DescribeRenewalPrice.PriceInfo.Coupons["+ i +"].Name");
				coupon.Description = context.StringValue("DescribeRenewalPrice.PriceInfo.Coupons["+ i +"].Description");
				coupon.IsSelected = context.StringValue("DescribeRenewalPrice.PriceInfo.Coupons["+ i +"].IsSelected");

				priceInfo_coupons.Add(coupon);
			}
			priceInfo.Coupons = priceInfo_coupons;
			describeRenewalPriceResponse.PriceInfo = priceInfo;

			List<DescribeRenewalPriceResponse.DescribeRenewalPrice_Rule> describeRenewalPriceResponse_rules = new List<DescribeRenewalPriceResponse.DescribeRenewalPrice_Rule>();
			for (int i = 0; i < context.Length("DescribeRenewalPrice.Rules.Length"); i++) {
				DescribeRenewalPriceResponse.DescribeRenewalPrice_Rule rule = new DescribeRenewalPriceResponse.DescribeRenewalPrice_Rule();
				rule.RuleId = context.LongValue("DescribeRenewalPrice.Rules["+ i +"].RuleId");
				rule.Name = context.StringValue("DescribeRenewalPrice.Rules["+ i +"].Name");
				rule.Description = context.StringValue("DescribeRenewalPrice.Rules["+ i +"].Description");

				describeRenewalPriceResponse_rules.Add(rule);
			}
			describeRenewalPriceResponse.Rules = describeRenewalPriceResponse_rules;
        
			return describeRenewalPriceResponse;
        }
    }
}
