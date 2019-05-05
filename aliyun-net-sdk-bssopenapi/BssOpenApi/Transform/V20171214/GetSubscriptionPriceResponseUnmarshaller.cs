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
        public static GetSubscriptionPriceResponse Unmarshall(UnmarshallerContext context)
        {
			GetSubscriptionPriceResponse getSubscriptionPriceResponse = new GetSubscriptionPriceResponse();

			getSubscriptionPriceResponse.HttpResponse = context.HttpResponse;
			getSubscriptionPriceResponse.RequestId = context.StringValue("GetSubscriptionPrice.RequestId");
			getSubscriptionPriceResponse.Success = context.BooleanValue("GetSubscriptionPrice.Success");
			getSubscriptionPriceResponse.Code = context.StringValue("GetSubscriptionPrice.Code");
			getSubscriptionPriceResponse.Message = context.StringValue("GetSubscriptionPrice.Message");

			GetSubscriptionPriceResponse.GetSubscriptionPrice_Data data = new GetSubscriptionPriceResponse.GetSubscriptionPrice_Data();
			data.OriginalPrice = context.FloatValue("GetSubscriptionPrice.Data.OriginalPrice");
			data.DiscountPrice = context.FloatValue("GetSubscriptionPrice.Data.DiscountPrice");
			data.TradePrice = context.FloatValue("GetSubscriptionPrice.Data.TradePrice");
			data.Currency = context.StringValue("GetSubscriptionPrice.Data.Currency");
			data.Quantity = context.IntegerValue("GetSubscriptionPrice.Data.Quantity");

			List<GetSubscriptionPriceResponse.GetSubscriptionPrice_Data.GetSubscriptionPrice_ModuleDetail> data_moduleDetails = new List<GetSubscriptionPriceResponse.GetSubscriptionPrice_Data.GetSubscriptionPrice_ModuleDetail>();
			for (int i = 0; i < context.Length("GetSubscriptionPrice.Data.ModuleDetails.Length"); i++) {
				GetSubscriptionPriceResponse.GetSubscriptionPrice_Data.GetSubscriptionPrice_ModuleDetail moduleDetail = new GetSubscriptionPriceResponse.GetSubscriptionPrice_Data.GetSubscriptionPrice_ModuleDetail();
				moduleDetail.ModuleCode = context.StringValue("GetSubscriptionPrice.Data.ModuleDetails["+ i +"].ModuleCode");
				moduleDetail.OriginalCost = context.FloatValue("GetSubscriptionPrice.Data.ModuleDetails["+ i +"].OriginalCost");
				moduleDetail.InvoiceDiscount = context.FloatValue("GetSubscriptionPrice.Data.ModuleDetails["+ i +"].InvoiceDiscount");
				moduleDetail.CostAfterDiscount = context.FloatValue("GetSubscriptionPrice.Data.ModuleDetails["+ i +"].CostAfterDiscount");
				moduleDetail.UnitPrice = context.FloatValue("GetSubscriptionPrice.Data.ModuleDetails["+ i +"].UnitPrice");

				data_moduleDetails.Add(moduleDetail);
			}
			data.ModuleDetails = data_moduleDetails;

			List<GetSubscriptionPriceResponse.GetSubscriptionPrice_Data.GetSubscriptionPrice_PromotionDetail> data_promotionDetails = new List<GetSubscriptionPriceResponse.GetSubscriptionPrice_Data.GetSubscriptionPrice_PromotionDetail>();
			for (int i = 0; i < context.Length("GetSubscriptionPrice.Data.PromotionDetails.Length"); i++) {
				GetSubscriptionPriceResponse.GetSubscriptionPrice_Data.GetSubscriptionPrice_PromotionDetail promotionDetail = new GetSubscriptionPriceResponse.GetSubscriptionPrice_Data.GetSubscriptionPrice_PromotionDetail();
				promotionDetail.PromotionName = context.StringValue("GetSubscriptionPrice.Data.PromotionDetails["+ i +"].PromotionName");
				promotionDetail.PromotionDesc = context.StringValue("GetSubscriptionPrice.Data.PromotionDetails["+ i +"].PromotionDesc");
				promotionDetail.PromotionId = context.LongValue("GetSubscriptionPrice.Data.PromotionDetails["+ i +"].PromotionId");

				data_promotionDetails.Add(promotionDetail);
			}
			data.PromotionDetails = data_promotionDetails;
			getSubscriptionPriceResponse.Data = data;
        
			return getSubscriptionPriceResponse;
        }
    }
}
