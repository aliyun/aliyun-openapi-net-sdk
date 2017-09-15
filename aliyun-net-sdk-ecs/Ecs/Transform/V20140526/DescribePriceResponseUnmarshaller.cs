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
using Aliyun.Acs.Ecs.Model.V20140526;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribePriceResponseUnmarshaller
    {
        public static DescribePriceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePriceResponse describePriceResponse = new DescribePriceResponse();

			describePriceResponse.HttpResponse = context.HttpResponse;
			describePriceResponse.RequestId = context.StringValue("DescribePrice.RequestId");

			DescribePriceResponse.DescribePrice_PriceInfo priceInfo = new DescribePriceResponse.DescribePrice_PriceInfo();

			DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Price price = new DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Price();
			price.OriginalPrice = context.FloatValue("DescribePrice.PriceInfo.Price.OriginalPrice");
			price.DiscountPrice = context.FloatValue("DescribePrice.PriceInfo.Price.DiscountPrice");
			price.TradePrice = context.FloatValue("DescribePrice.PriceInfo.Price.TradePrice");
			price.Currency = context.StringValue("DescribePrice.PriceInfo.Price.Currency");
			priceInfo.Price = price;

			List<DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Rule> priceInfo_rules = new List<DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Rule>();
			for (int i = 0; i < context.Length("DescribePrice.PriceInfo.Rules.Length"); i++) {
				DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Rule rule = new DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Rule();
				rule.RuleId = context.LongValue("DescribePrice.PriceInfo.Rules["+ i +"].RuleId");
				rule.Description = context.StringValue("DescribePrice.PriceInfo.Rules["+ i +"].Description");

				priceInfo_rules.Add(rule);
			}
			priceInfo.Rules = priceInfo_rules;
			describePriceResponse.PriceInfo = priceInfo;
        
			return describePriceResponse;
        }
    }
}