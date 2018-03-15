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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class QueryPriceForBuyResponseUnmarshaller
    {
        public static QueryPriceForBuyResponse Unmarshall(UnmarshallerContext context)
        {
			QueryPriceForBuyResponse queryPriceForBuyResponse = new QueryPriceForBuyResponse();

			queryPriceForBuyResponse.HttpResponse = context.HttpResponse;
			queryPriceForBuyResponse.RequestId = context.StringValue("QueryPriceForBuy.RequestId");

			QueryPriceForBuyResponse.QueryPriceForBuy_PriceInfo priceInfo = new QueryPriceForBuyResponse.QueryPriceForBuy_PriceInfo();
			priceInfo.Currency = context.StringValue("QueryPriceForBuy.PriceInfo.Currency");
			priceInfo.OriginalPrice = context.FloatValue("QueryPriceForBuy.PriceInfo.OriginalPrice");
			priceInfo.TradePrice = context.FloatValue("QueryPriceForBuy.PriceInfo.TradePrice");
			priceInfo.DiscountPrice = context.FloatValue("QueryPriceForBuy.PriceInfo.DiscountPrice");

			List<string> priceInfo_ruleIds = new List<string>();
			for (int i = 0; i < context.Length("QueryPriceForBuy.PriceInfo.RuleIds.Length"); i++) {
				priceInfo_ruleIds.Add(context.StringValue("QueryPriceForBuy.PriceInfo.RuleIds["+ i +"]"));
			}
			priceInfo.RuleIds = priceInfo_ruleIds;

			QueryPriceForBuyResponse.QueryPriceForBuy_PriceInfo.QueryPriceForBuy_ActivityInfo activityInfo = new QueryPriceForBuyResponse.QueryPriceForBuy_PriceInfo.QueryPriceForBuy_ActivityInfo();
			activityInfo.CheckErrMsg = context.StringValue("QueryPriceForBuy.PriceInfo.ActivityInfo.CheckErrMsg");
			activityInfo.ErrorCode = context.StringValue("QueryPriceForBuy.PriceInfo.ActivityInfo.ErrorCode");
			activityInfo.Success = context.StringValue("QueryPriceForBuy.PriceInfo.ActivityInfo.Success");
			priceInfo.ActivityInfo = activityInfo;

			List<QueryPriceForBuyResponse.QueryPriceForBuy_PriceInfo.QueryPriceForBuy_Coupon> priceInfo_coupons = new List<QueryPriceForBuyResponse.QueryPriceForBuy_PriceInfo.QueryPriceForBuy_Coupon>();
			for (int i = 0; i < context.Length("QueryPriceForBuy.PriceInfo.Coupons.Length"); i++) {
				QueryPriceForBuyResponse.QueryPriceForBuy_PriceInfo.QueryPriceForBuy_Coupon coupon = new QueryPriceForBuyResponse.QueryPriceForBuy_PriceInfo.QueryPriceForBuy_Coupon();
				coupon.CouponNo = context.StringValue("QueryPriceForBuy.PriceInfo.Coupons["+ i +"].CouponNo");
				coupon.Name = context.StringValue("QueryPriceForBuy.PriceInfo.Coupons["+ i +"].Name");
				coupon.Description = context.StringValue("QueryPriceForBuy.PriceInfo.Coupons["+ i +"].Description");
				coupon.IsSelected = context.StringValue("QueryPriceForBuy.PriceInfo.Coupons["+ i +"].IsSelected");

				priceInfo_coupons.Add(coupon);
			}
			priceInfo.Coupons = priceInfo_coupons;
			queryPriceForBuyResponse.PriceInfo = priceInfo;

			List<QueryPriceForBuyResponse.QueryPriceForBuy_Rule> queryPriceForBuyResponse_rules = new List<QueryPriceForBuyResponse.QueryPriceForBuy_Rule>();
			for (int i = 0; i < context.Length("QueryPriceForBuy.Rules.Length"); i++) {
				QueryPriceForBuyResponse.QueryPriceForBuy_Rule rule = new QueryPriceForBuyResponse.QueryPriceForBuy_Rule();
				rule.RuleId = context.LongValue("QueryPriceForBuy.Rules["+ i +"].RuleId");
				rule.Name = context.StringValue("QueryPriceForBuy.Rules["+ i +"].Name");
				rule.Description = context.StringValue("QueryPriceForBuy.Rules["+ i +"].Description");

				queryPriceForBuyResponse_rules.Add(rule);
			}
			queryPriceForBuyResponse.Rules = queryPriceForBuyResponse_rules;
        
			return queryPriceForBuyResponse;
        }
    }
}