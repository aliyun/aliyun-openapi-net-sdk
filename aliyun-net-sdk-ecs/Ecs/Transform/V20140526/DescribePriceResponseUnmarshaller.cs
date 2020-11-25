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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribePriceResponseUnmarshaller
    {
        public static DescribePriceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePriceResponse describePriceResponse = new DescribePriceResponse();

			describePriceResponse.HttpResponse = _ctx.HttpResponse;
			describePriceResponse.RequestId = _ctx.StringValue("DescribePrice.RequestId");

			DescribePriceResponse.DescribePrice_PriceInfo priceInfo = new DescribePriceResponse.DescribePrice_PriceInfo();

			DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Price price = new DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Price();
			price.OriginalPrice = _ctx.FloatValue("DescribePrice.PriceInfo.Price.OriginalPrice");
			price.DiscountPrice = _ctx.FloatValue("DescribePrice.PriceInfo.Price.DiscountPrice");
			price.TradePrice = _ctx.FloatValue("DescribePrice.PriceInfo.Price.TradePrice");
			price.ReservedInstanceHourPrice = _ctx.FloatValue("DescribePrice.PriceInfo.Price.ReservedInstanceHourPrice");
			price.Currency = _ctx.StringValue("DescribePrice.PriceInfo.Price.Currency");

			List<DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Price.DescribePrice_ResourcePriceModel> price_detailInfos = new List<DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Price.DescribePrice_ResourcePriceModel>();
			for (int i = 0; i < _ctx.Length("DescribePrice.PriceInfo.Price.DetailInfos.Length"); i++) {
				DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Price.DescribePrice_ResourcePriceModel resourcePriceModel = new DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Price.DescribePrice_ResourcePriceModel();
				resourcePriceModel.Resource = _ctx.StringValue("DescribePrice.PriceInfo.Price.DetailInfos["+ i +"].Resource");
				resourcePriceModel.OriginalPrice = _ctx.FloatValue("DescribePrice.PriceInfo.Price.DetailInfos["+ i +"].OriginalPrice");
				resourcePriceModel.DiscountPrice = _ctx.FloatValue("DescribePrice.PriceInfo.Price.DetailInfos["+ i +"].DiscountPrice");
				resourcePriceModel.TradePrice = _ctx.FloatValue("DescribePrice.PriceInfo.Price.DetailInfos["+ i +"].TradePrice");

				List<DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Price.DescribePrice_ResourcePriceModel.DescribePrice_Rule1> resourcePriceModel_subRules = new List<DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Price.DescribePrice_ResourcePriceModel.DescribePrice_Rule1>();
				for (int j = 0; j < _ctx.Length("DescribePrice.PriceInfo.Price.DetailInfos["+ i +"].SubRules.Length"); j++) {
					DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Price.DescribePrice_ResourcePriceModel.DescribePrice_Rule1 rule1 = new DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Price.DescribePrice_ResourcePriceModel.DescribePrice_Rule1();
					rule1.RuleId = _ctx.LongValue("DescribePrice.PriceInfo.Price.DetailInfos["+ i +"].SubRules["+ j +"].RuleId");
					rule1.Description = _ctx.StringValue("DescribePrice.PriceInfo.Price.DetailInfos["+ i +"].SubRules["+ j +"].Description");

					resourcePriceModel_subRules.Add(rule1);
				}
				resourcePriceModel.SubRules = resourcePriceModel_subRules;

				price_detailInfos.Add(resourcePriceModel);
			}
			price.DetailInfos = price_detailInfos;
			priceInfo.Price = price;

			List<DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Rule> priceInfo_rules = new List<DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Rule>();
			for (int i = 0; i < _ctx.Length("DescribePrice.PriceInfo.Rules.Length"); i++) {
				DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Rule rule = new DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Rule();
				rule.RuleId = _ctx.LongValue("DescribePrice.PriceInfo.Rules["+ i +"].RuleId");
				rule.Description = _ctx.StringValue("DescribePrice.PriceInfo.Rules["+ i +"].Description");

				priceInfo_rules.Add(rule);
			}
			priceInfo.Rules = priceInfo_rules;
			describePriceResponse.PriceInfo = priceInfo;
        
			return describePriceResponse;
        }
    }
}
