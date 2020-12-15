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
    public class DescribePriceResponseUnmarshaller
    {
        public static DescribePriceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePriceResponse describePriceResponse = new DescribePriceResponse();

			describePriceResponse.HttpResponse = _ctx.HttpResponse;
			describePriceResponse.RequestId = _ctx.StringValue("DescribePrice.RequestId");

			DescribePriceResponse.DescribePrice_PriceInfo priceInfo = new DescribePriceResponse.DescribePrice_PriceInfo();
			priceInfo.Currency = _ctx.StringValue("DescribePrice.PriceInfo.Currency");
			priceInfo.OriginalPrice = _ctx.FloatValue("DescribePrice.PriceInfo.OriginalPrice");
			priceInfo.TradePrice = _ctx.FloatValue("DescribePrice.PriceInfo.TradePrice");
			priceInfo.DiscountPrice = _ctx.FloatValue("DescribePrice.PriceInfo.DiscountPrice");

			List<string> priceInfo_ruleIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribePrice.PriceInfo.RuleIds.Length"); i++) {
				priceInfo_ruleIds.Add(_ctx.StringValue("DescribePrice.PriceInfo.RuleIds["+ i +"]"));
			}
			priceInfo.RuleIds = priceInfo_ruleIds;

			DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_ActivityInfo activityInfo = new DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_ActivityInfo();
			activityInfo.CheckErrMsg = _ctx.StringValue("DescribePrice.PriceInfo.ActivityInfo.CheckErrMsg");
			activityInfo.ErrorCode = _ctx.StringValue("DescribePrice.PriceInfo.ActivityInfo.ErrorCode");
			activityInfo.Success = _ctx.StringValue("DescribePrice.PriceInfo.ActivityInfo.Success");
			priceInfo.ActivityInfo = activityInfo;

			List<DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Coupon> priceInfo_coupons = new List<DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Coupon>();
			for (int i = 0; i < _ctx.Length("DescribePrice.PriceInfo.Coupons.Length"); i++) {
				DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Coupon coupon = new DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Coupon();
				coupon.CouponNo = _ctx.StringValue("DescribePrice.PriceInfo.Coupons["+ i +"].CouponNo");
				coupon.Name = _ctx.StringValue("DescribePrice.PriceInfo.Coupons["+ i +"].Name");
				coupon.Description = _ctx.StringValue("DescribePrice.PriceInfo.Coupons["+ i +"].Description");
				coupon.IsSelected = _ctx.StringValue("DescribePrice.PriceInfo.Coupons["+ i +"].IsSelected");

				priceInfo_coupons.Add(coupon);
			}
			priceInfo.Coupons = priceInfo_coupons;
			describePriceResponse.PriceInfo = priceInfo;

			List<DescribePriceResponse.DescribePrice_Rule> describePriceResponse_rules = new List<DescribePriceResponse.DescribePrice_Rule>();
			for (int i = 0; i < _ctx.Length("DescribePrice.Rules.Length"); i++) {
				DescribePriceResponse.DescribePrice_Rule rule = new DescribePriceResponse.DescribePrice_Rule();
				rule.RuleId = _ctx.LongValue("DescribePrice.Rules["+ i +"].RuleId");
				rule.Name = _ctx.StringValue("DescribePrice.Rules["+ i +"].Name");
				rule.Description = _ctx.StringValue("DescribePrice.Rules["+ i +"].Description");

				describePriceResponse_rules.Add(rule);
			}
			describePriceResponse.Rules = describePriceResponse_rules;
        
			return describePriceResponse;
        }
    }
}
