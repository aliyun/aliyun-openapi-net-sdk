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
    public class DescribePriceResponseUnmarshaller
    {
        public static DescribePriceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePriceResponse describePriceResponse = new DescribePriceResponse();

			describePriceResponse.HttpResponse = _ctx.HttpResponse;
			describePriceResponse.ExpressionCode = _ctx.StringValue("DescribePrice.ExpressionCode");
			describePriceResponse.Cuxiao = _ctx.BooleanValue("DescribePrice.Cuxiao");
			describePriceResponse.DiscountPrice = _ctx.FloatValue("DescribePrice.DiscountPrice");
			describePriceResponse.Cycle = _ctx.StringValue("DescribePrice.Cycle");
			describePriceResponse.TradePrice = _ctx.FloatValue("DescribePrice.TradePrice");
			describePriceResponse.OriginalPrice = _ctx.FloatValue("DescribePrice.OriginalPrice");
			describePriceResponse.Duration = _ctx.IntegerValue("DescribePrice.Duration");
			describePriceResponse.Currency = _ctx.StringValue("DescribePrice.Currency");
			describePriceResponse.ExpressionMessage = _ctx.StringValue("DescribePrice.ExpressionMessage");
			describePriceResponse.InfoTitle = _ctx.StringValue("DescribePrice.InfoTitle");
			describePriceResponse.ProductCode = _ctx.StringValue("DescribePrice.ProductCode");

			List<DescribePriceResponse.DescribePrice_PromotionRule> describePriceResponse_promotionRules = new List<DescribePriceResponse.DescribePrice_PromotionRule>();
			for (int i = 0; i < _ctx.Length("DescribePrice.PromotionRules.Length"); i++) {
				DescribePriceResponse.DescribePrice_PromotionRule promotionRule = new DescribePriceResponse.DescribePrice_PromotionRule();
				promotionRule.Title = _ctx.StringValue("DescribePrice.PromotionRules["+ i +"].Title");
				promotionRule.Name = _ctx.StringValue("DescribePrice.PromotionRules["+ i +"].Name");
				promotionRule.RuleId = _ctx.StringValue("DescribePrice.PromotionRules["+ i +"].RuleId");

				describePriceResponse_promotionRules.Add(promotionRule);
			}
			describePriceResponse.PromotionRules = describePriceResponse_promotionRules;

			List<DescribePriceResponse.DescribePrice_Coupon> describePriceResponse_coupons = new List<DescribePriceResponse.DescribePrice_Coupon>();
			for (int i = 0; i < _ctx.Length("DescribePrice.Coupons.Length"); i++) {
				DescribePriceResponse.DescribePrice_Coupon coupon = new DescribePriceResponse.DescribePrice_Coupon();
				coupon.CouponOptionCode = _ctx.StringValue("DescribePrice.Coupons["+ i +"].CouponOptionCode");
				coupon.CouponOptionNo = _ctx.StringValue("DescribePrice.Coupons["+ i +"].CouponOptionNo");
				coupon.CouponName = _ctx.StringValue("DescribePrice.Coupons["+ i +"].CouponName");
				coupon.CouponDesc = _ctx.StringValue("DescribePrice.Coupons["+ i +"].CouponDesc");
				coupon.IsSelected = _ctx.BooleanValue("DescribePrice.Coupons["+ i +"].IsSelected");
				coupon.CanPromFee = _ctx.FloatValue("DescribePrice.Coupons["+ i +"].CanPromFee");

				describePriceResponse_coupons.Add(coupon);
			}
			describePriceResponse.Coupons = describePriceResponse_coupons;
        
			return describePriceResponse;
        }
    }
}
