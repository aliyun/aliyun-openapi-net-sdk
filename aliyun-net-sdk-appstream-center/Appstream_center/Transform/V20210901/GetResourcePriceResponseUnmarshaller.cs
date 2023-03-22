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
    public class GetResourcePriceResponseUnmarshaller
    {
        public static GetResourcePriceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetResourcePriceResponse getResourcePriceResponse = new GetResourcePriceResponse();

			getResourcePriceResponse.HttpResponse = _ctx.HttpResponse;
			getResourcePriceResponse.RequestId = _ctx.StringValue("GetResourcePrice.RequestId");
			getResourcePriceResponse.Code = _ctx.StringValue("GetResourcePrice.Code");
			getResourcePriceResponse.Message = _ctx.StringValue("GetResourcePrice.Message");

			GetResourcePriceResponse.GetResourcePrice_PriceModel priceModel = new GetResourcePriceResponse.GetResourcePrice_PriceModel();

			GetResourcePriceResponse.GetResourcePrice_PriceModel.GetResourcePrice_Price price = new GetResourcePriceResponse.GetResourcePrice_PriceModel.GetResourcePrice_Price();
			price.OriginalPrice = _ctx.StringValue("GetResourcePrice.PriceModel.Price.OriginalPrice");
			price.DiscountPrice = _ctx.StringValue("GetResourcePrice.PriceModel.Price.DiscountPrice");
			price.TradePrice = _ctx.StringValue("GetResourcePrice.PriceModel.Price.TradePrice");
			price.Currency = _ctx.StringValue("GetResourcePrice.PriceModel.Price.Currency");

			List<GetResourcePriceResponse.GetResourcePrice_PriceModel.GetResourcePrice_Price.GetResourcePrice_Promotion> price_promotions = new List<GetResourcePriceResponse.GetResourcePrice_PriceModel.GetResourcePrice_Price.GetResourcePrice_Promotion>();
			for (int i = 0; i < _ctx.Length("GetResourcePrice.PriceModel.Price.Promotions.Length"); i++) {
				GetResourcePriceResponse.GetResourcePrice_PriceModel.GetResourcePrice_Price.GetResourcePrice_Promotion promotion = new GetResourcePriceResponse.GetResourcePrice_PriceModel.GetResourcePrice_Price.GetResourcePrice_Promotion();
				promotion.OptionCode = _ctx.StringValue("GetResourcePrice.PriceModel.Price.Promotions["+ i +"].OptionCode");
				promotion.PromotionId = _ctx.StringValue("GetResourcePrice.PriceModel.Price.Promotions["+ i +"].PromotionId");
				promotion.PromotionName = _ctx.StringValue("GetResourcePrice.PriceModel.Price.Promotions["+ i +"].PromotionName");
				promotion.PromotionDesc = _ctx.StringValue("GetResourcePrice.PriceModel.Price.Promotions["+ i +"].PromotionDesc");
				promotion.Selected = _ctx.BooleanValue("GetResourcePrice.PriceModel.Price.Promotions["+ i +"].Selected");

				price_promotions.Add(promotion);
			}
			price.Promotions = price_promotions;
			priceModel.Price = price;

			List<GetResourcePriceResponse.GetResourcePrice_PriceModel.GetResourcePrice_Rule> priceModel_rules = new List<GetResourcePriceResponse.GetResourcePrice_PriceModel.GetResourcePrice_Rule>();
			for (int i = 0; i < _ctx.Length("GetResourcePrice.PriceModel.Rules.Length"); i++) {
				GetResourcePriceResponse.GetResourcePrice_PriceModel.GetResourcePrice_Rule rule = new GetResourcePriceResponse.GetResourcePrice_PriceModel.GetResourcePrice_Rule();
				rule.RuleId = _ctx.LongValue("GetResourcePrice.PriceModel.Rules["+ i +"].RuleId");
				rule.Description = _ctx.StringValue("GetResourcePrice.PriceModel.Rules["+ i +"].Description");

				priceModel_rules.Add(rule);
			}
			priceModel.Rules = priceModel_rules;
			getResourcePriceResponse.PriceModel = priceModel;
        
			return getResourcePriceResponse;
        }
    }
}
