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
        public static DescribeRenewalPriceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRenewalPriceResponse describeRenewalPriceResponse = new DescribeRenewalPriceResponse();

			describeRenewalPriceResponse.HttpResponse = _ctx.HttpResponse;
			describeRenewalPriceResponse.RequestId = _ctx.StringValue("DescribeRenewalPrice.RequestId");

			DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo priceInfo = new DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo();
			priceInfo.Currency = _ctx.StringValue("DescribeRenewalPrice.PriceInfo.Currency");
			priceInfo.OriginalPrice = _ctx.FloatValue("DescribeRenewalPrice.PriceInfo.OriginalPrice");
			priceInfo.TradePrice = _ctx.FloatValue("DescribeRenewalPrice.PriceInfo.TradePrice");
			priceInfo.DiscountPrice = _ctx.FloatValue("DescribeRenewalPrice.PriceInfo.DiscountPrice");

			List<string> priceInfo_ruleIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeRenewalPrice.PriceInfo.RuleIds.Length"); i++) {
				priceInfo_ruleIds.Add(_ctx.StringValue("DescribeRenewalPrice.PriceInfo.RuleIds["+ i +"]"));
			}
			priceInfo.RuleIds = priceInfo_ruleIds;

			DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_ActivityInfo activityInfo = new DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_ActivityInfo();
			activityInfo.CheckErrMsg = _ctx.StringValue("DescribeRenewalPrice.PriceInfo.ActivityInfo.CheckErrMsg");
			activityInfo.ErrorCode = _ctx.StringValue("DescribeRenewalPrice.PriceInfo.ActivityInfo.ErrorCode");
			activityInfo.Success = _ctx.StringValue("DescribeRenewalPrice.PriceInfo.ActivityInfo.Success");
			priceInfo.ActivityInfo = activityInfo;

			List<DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Coupon> priceInfo_coupons = new List<DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Coupon>();
			for (int i = 0; i < _ctx.Length("DescribeRenewalPrice.PriceInfo.Coupons.Length"); i++) {
				DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Coupon coupon = new DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Coupon();
				coupon.CouponNo = _ctx.StringValue("DescribeRenewalPrice.PriceInfo.Coupons["+ i +"].CouponNo");
				coupon.Name = _ctx.StringValue("DescribeRenewalPrice.PriceInfo.Coupons["+ i +"].Name");
				coupon.Description = _ctx.StringValue("DescribeRenewalPrice.PriceInfo.Coupons["+ i +"].Description");
				coupon.IsSelected = _ctx.StringValue("DescribeRenewalPrice.PriceInfo.Coupons["+ i +"].IsSelected");

				priceInfo_coupons.Add(coupon);
			}
			priceInfo.Coupons = priceInfo_coupons;
			describeRenewalPriceResponse.PriceInfo = priceInfo;

			List<DescribeRenewalPriceResponse.DescribeRenewalPrice_Rule> describeRenewalPriceResponse_rules = new List<DescribeRenewalPriceResponse.DescribeRenewalPrice_Rule>();
			for (int i = 0; i < _ctx.Length("DescribeRenewalPrice.Rules.Length"); i++) {
				DescribeRenewalPriceResponse.DescribeRenewalPrice_Rule rule = new DescribeRenewalPriceResponse.DescribeRenewalPrice_Rule();
				rule.RuleId = _ctx.LongValue("DescribeRenewalPrice.Rules["+ i +"].RuleId");
				rule.Name = _ctx.StringValue("DescribeRenewalPrice.Rules["+ i +"].Name");
				rule.Description = _ctx.StringValue("DescribeRenewalPrice.Rules["+ i +"].Description");

				describeRenewalPriceResponse_rules.Add(rule);
			}
			describeRenewalPriceResponse.Rules = describeRenewalPriceResponse_rules;
        
			return describeRenewalPriceResponse;
        }
    }
}
