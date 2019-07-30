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
        public static DescribePriceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePriceResponse describePriceResponse = new DescribePriceResponse();

			describePriceResponse.HttpResponse = context.HttpResponse;
			describePriceResponse.ProductCode = context.StringValue("DescribePrice.ProductCode");
			describePriceResponse.OriginalPrice = context.FloatValue("DescribePrice.OriginalPrice");
			describePriceResponse.TradePrice = context.FloatValue("DescribePrice.TradePrice");
			describePriceResponse.DiscountPrice = context.FloatValue("DescribePrice.DiscountPrice");

			List<DescribePriceResponse.DescribePrice_PromotionRule> describePriceResponse_promotionRules = new List<DescribePriceResponse.DescribePrice_PromotionRule>();
			for (int i = 0; i < context.Length("DescribePrice.PromotionRules.Length"); i++) {
				DescribePriceResponse.DescribePrice_PromotionRule promotionRule = new DescribePriceResponse.DescribePrice_PromotionRule();
				promotionRule.RuleId = context.StringValue("DescribePrice.PromotionRules["+ i +"].RuleId");
				promotionRule.Name = context.StringValue("DescribePrice.PromotionRules["+ i +"].Name");
				promotionRule.Title = context.StringValue("DescribePrice.PromotionRules["+ i +"].Title");

				describePriceResponse_promotionRules.Add(promotionRule);
			}
			describePriceResponse.PromotionRules = describePriceResponse_promotionRules;
        
			return describePriceResponse;
        }
    }
}
