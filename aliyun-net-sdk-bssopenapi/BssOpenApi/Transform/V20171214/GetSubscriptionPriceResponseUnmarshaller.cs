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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class GetSubscriptionPriceResponseUnmarshaller
    {
        public static GetSubscriptionPriceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSubscriptionPriceResponse getSubscriptionPriceResponse = new GetSubscriptionPriceResponse();

			getSubscriptionPriceResponse.HttpResponse = _ctx.HttpResponse;
			getSubscriptionPriceResponse.RequestId = _ctx.StringValue("GetSubscriptionPrice.RequestId");
			getSubscriptionPriceResponse.Success = _ctx.BooleanValue("GetSubscriptionPrice.Success");
			getSubscriptionPriceResponse.Code = _ctx.StringValue("GetSubscriptionPrice.Code");
			getSubscriptionPriceResponse.Message = _ctx.StringValue("GetSubscriptionPrice.Message");

			GetSubscriptionPriceResponse.GetSubscriptionPrice_Data data = new GetSubscriptionPriceResponse.GetSubscriptionPrice_Data();
			data.OriginalPrice = _ctx.FloatValue("GetSubscriptionPrice.Data.OriginalPrice");
			data.DiscountPrice = _ctx.FloatValue("GetSubscriptionPrice.Data.DiscountPrice");
			data.TradePrice = _ctx.FloatValue("GetSubscriptionPrice.Data.TradePrice");
			data.Currency = _ctx.StringValue("GetSubscriptionPrice.Data.Currency");
			data.Quantity = _ctx.IntegerValue("GetSubscriptionPrice.Data.Quantity");

			List<GetSubscriptionPriceResponse.GetSubscriptionPrice_Data.GetSubscriptionPrice_ModuleDetail> data_moduleDetails = new List<GetSubscriptionPriceResponse.GetSubscriptionPrice_Data.GetSubscriptionPrice_ModuleDetail>();
			for (int i = 0; i < _ctx.Length("GetSubscriptionPrice.Data.ModuleDetails.Length"); i++) {
				GetSubscriptionPriceResponse.GetSubscriptionPrice_Data.GetSubscriptionPrice_ModuleDetail moduleDetail = new GetSubscriptionPriceResponse.GetSubscriptionPrice_Data.GetSubscriptionPrice_ModuleDetail();
				moduleDetail.ModuleCode = _ctx.StringValue("GetSubscriptionPrice.Data.ModuleDetails["+ i +"].ModuleCode");
				moduleDetail.OriginalCost = _ctx.FloatValue("GetSubscriptionPrice.Data.ModuleDetails["+ i +"].OriginalCost");
				moduleDetail.InvoiceDiscount = _ctx.FloatValue("GetSubscriptionPrice.Data.ModuleDetails["+ i +"].InvoiceDiscount");
				moduleDetail.CostAfterDiscount = _ctx.FloatValue("GetSubscriptionPrice.Data.ModuleDetails["+ i +"].CostAfterDiscount");
				moduleDetail.UnitPrice = _ctx.FloatValue("GetSubscriptionPrice.Data.ModuleDetails["+ i +"].UnitPrice");

				data_moduleDetails.Add(moduleDetail);
			}
			data.ModuleDetails = data_moduleDetails;

			List<GetSubscriptionPriceResponse.GetSubscriptionPrice_Data.GetSubscriptionPrice_PromotionDetail> data_promotionDetails = new List<GetSubscriptionPriceResponse.GetSubscriptionPrice_Data.GetSubscriptionPrice_PromotionDetail>();
			for (int i = 0; i < _ctx.Length("GetSubscriptionPrice.Data.PromotionDetails.Length"); i++) {
				GetSubscriptionPriceResponse.GetSubscriptionPrice_Data.GetSubscriptionPrice_PromotionDetail promotionDetail = new GetSubscriptionPriceResponse.GetSubscriptionPrice_Data.GetSubscriptionPrice_PromotionDetail();
				promotionDetail.PromotionName = _ctx.StringValue("GetSubscriptionPrice.Data.PromotionDetails["+ i +"].PromotionName");
				promotionDetail.PromotionDesc = _ctx.StringValue("GetSubscriptionPrice.Data.PromotionDetails["+ i +"].PromotionDesc");
				promotionDetail.PromotionId = _ctx.LongValue("GetSubscriptionPrice.Data.PromotionDetails["+ i +"].PromotionId");

				data_promotionDetails.Add(promotionDetail);
			}
			data.PromotionDetails = data_promotionDetails;
			getSubscriptionPriceResponse.Data = data;
        
			return getSubscriptionPriceResponse;
        }
    }
}
