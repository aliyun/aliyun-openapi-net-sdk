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
using Aliyun.Acs.appstream_center.Model.V20210901;

namespace Aliyun.Acs.appstream_center.Transform.V20210901
{
    public class GetResourceRenewPriceResponseUnmarshaller
    {
        public static GetResourceRenewPriceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetResourceRenewPriceResponse getResourceRenewPriceResponse = new GetResourceRenewPriceResponse();

			getResourceRenewPriceResponse.HttpResponse = _ctx.HttpResponse;
			getResourceRenewPriceResponse.RequestId = _ctx.StringValue("GetResourceRenewPrice.RequestId");

			GetResourceRenewPriceResponse.GetResourceRenewPrice_Data data = new GetResourceRenewPriceResponse.GetResourceRenewPrice_Data();

			GetResourceRenewPriceResponse.GetResourceRenewPrice_Data.GetResourceRenewPrice_Price price = new GetResourceRenewPriceResponse.GetResourceRenewPrice_Data.GetResourceRenewPrice_Price();
			price.OriginalPrice = _ctx.StringValue("GetResourceRenewPrice.Data.Price.OriginalPrice");
			price.DiscountPrice = _ctx.StringValue("GetResourceRenewPrice.Data.Price.DiscountPrice");
			price.TradePrice = _ctx.StringValue("GetResourceRenewPrice.Data.Price.TradePrice");
			price.Currency = _ctx.StringValue("GetResourceRenewPrice.Data.Price.Currency");

			List<GetResourceRenewPriceResponse.GetResourceRenewPrice_Data.GetResourceRenewPrice_Price.GetResourceRenewPrice_Promotion> price_promotions = new List<GetResourceRenewPriceResponse.GetResourceRenewPrice_Data.GetResourceRenewPrice_Price.GetResourceRenewPrice_Promotion>();
			for (int i = 0; i < _ctx.Length("GetResourceRenewPrice.Data.Price.Promotions.Length"); i++) {
				GetResourceRenewPriceResponse.GetResourceRenewPrice_Data.GetResourceRenewPrice_Price.GetResourceRenewPrice_Promotion promotion = new GetResourceRenewPriceResponse.GetResourceRenewPrice_Data.GetResourceRenewPrice_Price.GetResourceRenewPrice_Promotion();
				promotion.OptionCode = _ctx.StringValue("GetResourceRenewPrice.Data.Price.Promotions["+ i +"].OptionCode");
				promotion.PromotionId = _ctx.StringValue("GetResourceRenewPrice.Data.Price.Promotions["+ i +"].PromotionId");
				promotion.PromotionName = _ctx.StringValue("GetResourceRenewPrice.Data.Price.Promotions["+ i +"].PromotionName");
				promotion.PromotionDesc = _ctx.StringValue("GetResourceRenewPrice.Data.Price.Promotions["+ i +"].PromotionDesc");
				promotion.Selected = _ctx.BooleanValue("GetResourceRenewPrice.Data.Price.Promotions["+ i +"].Selected");

				price_promotions.Add(promotion);
			}
			price.Promotions = price_promotions;
			data.Price = price;

			List<GetResourceRenewPriceResponse.GetResourceRenewPrice_Data.GetResourceRenewPrice_Rule> data_rules = new List<GetResourceRenewPriceResponse.GetResourceRenewPrice_Data.GetResourceRenewPrice_Rule>();
			for (int i = 0; i < _ctx.Length("GetResourceRenewPrice.Data.Rules.Length"); i++) {
				GetResourceRenewPriceResponse.GetResourceRenewPrice_Data.GetResourceRenewPrice_Rule rule = new GetResourceRenewPriceResponse.GetResourceRenewPrice_Data.GetResourceRenewPrice_Rule();
				rule.RuleId = _ctx.LongValue("GetResourceRenewPrice.Data.Rules["+ i +"].RuleId");
				rule.Description = _ctx.StringValue("GetResourceRenewPrice.Data.Rules["+ i +"].Description");

				data_rules.Add(rule);
			}
			data.Rules = data_rules;
			getResourceRenewPriceResponse.Data = data;
        
			return getResourceRenewPriceResponse;
        }
    }
}
