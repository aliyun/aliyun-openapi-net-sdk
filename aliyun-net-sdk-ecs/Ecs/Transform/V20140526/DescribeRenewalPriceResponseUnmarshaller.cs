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
    public class DescribeRenewalPriceResponseUnmarshaller
    {
        public static DescribeRenewalPriceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRenewalPriceResponse describeRenewalPriceResponse = new DescribeRenewalPriceResponse();

			describeRenewalPriceResponse.HttpResponse = _ctx.HttpResponse;
			describeRenewalPriceResponse.RequestId = _ctx.StringValue("DescribeRenewalPrice.RequestId");

			DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo priceInfo = new DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo();

			DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Price price = new DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Price();
			price.OriginalPrice = _ctx.FloatValue("DescribeRenewalPrice.PriceInfo.Price.OriginalPrice");
			price.DiscountPrice = _ctx.FloatValue("DescribeRenewalPrice.PriceInfo.Price.DiscountPrice");
			price.Currency = _ctx.StringValue("DescribeRenewalPrice.PriceInfo.Price.Currency");
			price.TradePrice = _ctx.FloatValue("DescribeRenewalPrice.PriceInfo.Price.TradePrice");

			List<DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Price.DescribeRenewalPrice_ResourcePriceModel> price_detailInfos = new List<DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Price.DescribeRenewalPrice_ResourcePriceModel>();
			for (int i = 0; i < _ctx.Length("DescribeRenewalPrice.PriceInfo.Price.DetailInfos.Length"); i++) {
				DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Price.DescribeRenewalPrice_ResourcePriceModel resourcePriceModel = new DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Price.DescribeRenewalPrice_ResourcePriceModel();
				resourcePriceModel.Resource = _ctx.StringValue("DescribeRenewalPrice.PriceInfo.Price.DetailInfos["+ i +"].Resource");
				resourcePriceModel.OriginalPrice = _ctx.FloatValue("DescribeRenewalPrice.PriceInfo.Price.DetailInfos["+ i +"].OriginalPrice");
				resourcePriceModel.DiscountPrice = _ctx.FloatValue("DescribeRenewalPrice.PriceInfo.Price.DetailInfos["+ i +"].DiscountPrice");
				resourcePriceModel.TradePrice = _ctx.FloatValue("DescribeRenewalPrice.PriceInfo.Price.DetailInfos["+ i +"].TradePrice");

				List<DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Price.DescribeRenewalPrice_ResourcePriceModel.DescribeRenewalPrice_Rule1> resourcePriceModel_subRules = new List<DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Price.DescribeRenewalPrice_ResourcePriceModel.DescribeRenewalPrice_Rule1>();
				for (int j = 0; j < _ctx.Length("DescribeRenewalPrice.PriceInfo.Price.DetailInfos["+ i +"].SubRules.Length"); j++) {
					DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Price.DescribeRenewalPrice_ResourcePriceModel.DescribeRenewalPrice_Rule1 rule1 = new DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Price.DescribeRenewalPrice_ResourcePriceModel.DescribeRenewalPrice_Rule1();
					rule1.Description = _ctx.StringValue("DescribeRenewalPrice.PriceInfo.Price.DetailInfos["+ i +"].SubRules["+ j +"].Description");
					rule1.RuleId = _ctx.LongValue("DescribeRenewalPrice.PriceInfo.Price.DetailInfos["+ i +"].SubRules["+ j +"].RuleId");

					resourcePriceModel_subRules.Add(rule1);
				}
				resourcePriceModel.SubRules = resourcePriceModel_subRules;

				price_detailInfos.Add(resourcePriceModel);
			}
			price.DetailInfos = price_detailInfos;
			priceInfo.Price = price;

			List<DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Rule> priceInfo_rules = new List<DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Rule>();
			for (int i = 0; i < _ctx.Length("DescribeRenewalPrice.PriceInfo.Rules.Length"); i++) {
				DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Rule rule = new DescribeRenewalPriceResponse.DescribeRenewalPrice_PriceInfo.DescribeRenewalPrice_Rule();
				rule.Description = _ctx.StringValue("DescribeRenewalPrice.PriceInfo.Rules["+ i +"].Description");
				rule.RuleId = _ctx.LongValue("DescribeRenewalPrice.PriceInfo.Rules["+ i +"].RuleId");

				priceInfo_rules.Add(rule);
			}
			priceInfo.Rules = priceInfo_rules;
			describeRenewalPriceResponse.PriceInfo = priceInfo;
        
			return describeRenewalPriceResponse;
        }
    }
}
