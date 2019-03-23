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
    public class DescribePriceResponseUnmarshaller
    {
        public static DescribePriceResponse Unmarshall(UnmarshallerContext context)
        {
            DescribePriceResponse describePriceResponse = new DescribePriceResponse();

            describePriceResponse.HttpResponse = context.HttpResponse;
            describePriceResponse.RequestId = context.StringValue("DescribePrice.RequestId");

            DescribePriceResponse.DescribePrice_PriceInfo priceInfo = new DescribePriceResponse.DescribePrice_PriceInfo();
            priceInfo.Currency = context.StringValue("DescribePrice.PriceInfo.Currency");
            priceInfo.OriginalPrice = context.FloatValue("DescribePrice.PriceInfo.OriginalPrice");
            priceInfo.TradePrice = context.FloatValue("DescribePrice.PriceInfo.TradePrice");
            priceInfo.DiscountPrice = context.FloatValue("DescribePrice.PriceInfo.DiscountPrice");

            List<string> priceInfo_ruleIds = new List<string>();
            for (int i = 0; i < context.Length("DescribePrice.PriceInfo.RuleIds.Length"); i++)
            {
                priceInfo_ruleIds.Add(context.StringValue("DescribePrice.PriceInfo.RuleIds[" + i + "]"));
            }
            priceInfo.RuleIds = priceInfo_ruleIds;

            DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_ActivityInfo activityInfo = new DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_ActivityInfo();
            activityInfo.CheckErrMsg = context.StringValue("DescribePrice.PriceInfo.ActivityInfo.CheckErrMsg");
            activityInfo.ErrorCode = context.StringValue("DescribePrice.PriceInfo.ActivityInfo.ErrorCode");
            activityInfo.Success = context.StringValue("DescribePrice.PriceInfo.ActivityInfo.Success");
            priceInfo.ActivityInfo = activityInfo;

            List<DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Coupon> priceInfo_coupons = new List<DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Coupon>();
            for (int i = 0; i < context.Length("DescribePrice.PriceInfo.Coupons.Length"); i++)
            {
                DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Coupon coupon = new DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Coupon();
                coupon.CouponNo = context.StringValue("DescribePrice.PriceInfo.Coupons[" + i + "].CouponNo");
                coupon.Name = context.StringValue("DescribePrice.PriceInfo.Coupons[" + i + "].Name");
                coupon.Description = context.StringValue("DescribePrice.PriceInfo.Coupons[" + i + "].Description");
                coupon.IsSelected = context.StringValue("DescribePrice.PriceInfo.Coupons[" + i + "].IsSelected");

                priceInfo_coupons.Add(coupon);
            }
            priceInfo.Coupons = priceInfo_coupons;
            describePriceResponse.PriceInfo = priceInfo;

            List<DescribePriceResponse.DescribePrice_Rule> describePriceResponse_rules = new List<DescribePriceResponse.DescribePrice_Rule>();
            for (int i = 0; i < context.Length("DescribePrice.Rules.Length"); i++)
            {
                DescribePriceResponse.DescribePrice_Rule rule = new DescribePriceResponse.DescribePrice_Rule();
                rule.RuleId = context.LongValue("DescribePrice.Rules[" + i + "].RuleId");
                rule.Name = context.StringValue("DescribePrice.Rules[" + i + "].Name");
                rule.Description = context.StringValue("DescribePrice.Rules[" + i + "].Description");

                describePriceResponse_rules.Add(rule);
            }
            describePriceResponse.Rules = describePriceResponse_rules;

            return describePriceResponse;
        }
    }
}