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
using Aliyun.Acs.BssOpenApi.Model.V20171214;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class GetPayAsYouGoPriceResponseUnmarshaller
    {
        public static GetPayAsYouGoPriceResponse Unmarshall(UnmarshallerContext context)
        {
			GetPayAsYouGoPriceResponse getPayAsYouGoPriceResponse = new GetPayAsYouGoPriceResponse();

			getPayAsYouGoPriceResponse.HttpResponse = context.HttpResponse;
			getPayAsYouGoPriceResponse.RequestId = context.StringValue("GetPayAsYouGoPrice.RequestId");
			getPayAsYouGoPriceResponse.Success = context.BooleanValue("GetPayAsYouGoPrice.Success");
			getPayAsYouGoPriceResponse.Code = context.StringValue("GetPayAsYouGoPrice.Code");
			getPayAsYouGoPriceResponse.Message = context.StringValue("GetPayAsYouGoPrice.Message");

			GetPayAsYouGoPriceResponse.GetPayAsYouGoPrice_Data data = new GetPayAsYouGoPriceResponse.GetPayAsYouGoPrice_Data();
			data.Currency = context.StringValue("GetPayAsYouGoPrice.Data.Currency");

			List<GetPayAsYouGoPriceResponse.GetPayAsYouGoPrice_Data.GetPayAsYouGoPrice_ModuleDetail> data_moduleDetails = new List<GetPayAsYouGoPriceResponse.GetPayAsYouGoPrice_Data.GetPayAsYouGoPrice_ModuleDetail>();
			for (int i = 0; i < context.Length("GetPayAsYouGoPrice.Data.ModuleDetails.Length"); i++) {
				GetPayAsYouGoPriceResponse.GetPayAsYouGoPrice_Data.GetPayAsYouGoPrice_ModuleDetail moduleDetail = new GetPayAsYouGoPriceResponse.GetPayAsYouGoPrice_Data.GetPayAsYouGoPrice_ModuleDetail();
				moduleDetail.ModuleCode = context.StringValue("GetPayAsYouGoPrice.Data.ModuleDetails["+ i +"].ModuleCode");
				moduleDetail.OriginalCost = context.FloatValue("GetPayAsYouGoPrice.Data.ModuleDetails["+ i +"].OriginalCost");
				moduleDetail.InvoiceDiscount = context.FloatValue("GetPayAsYouGoPrice.Data.ModuleDetails["+ i +"].InvoiceDiscount");
				moduleDetail.CostAfterDiscount = context.FloatValue("GetPayAsYouGoPrice.Data.ModuleDetails["+ i +"].CostAfterDiscount");
				moduleDetail.UnitPrice = context.FloatValue("GetPayAsYouGoPrice.Data.ModuleDetails["+ i +"].UnitPrice");

				data_moduleDetails.Add(moduleDetail);
			}
			data.ModuleDetails = data_moduleDetails;

			List<GetPayAsYouGoPriceResponse.GetPayAsYouGoPrice_Data.GetPayAsYouGoPrice_PromotionDetail> data_promotionDetails = new List<GetPayAsYouGoPriceResponse.GetPayAsYouGoPrice_Data.GetPayAsYouGoPrice_PromotionDetail>();
			for (int i = 0; i < context.Length("GetPayAsYouGoPrice.Data.PromotionDetails.Length"); i++) {
				GetPayAsYouGoPriceResponse.GetPayAsYouGoPrice_Data.GetPayAsYouGoPrice_PromotionDetail promotionDetail = new GetPayAsYouGoPriceResponse.GetPayAsYouGoPrice_Data.GetPayAsYouGoPrice_PromotionDetail();
				promotionDetail.PromotionName = context.StringValue("GetPayAsYouGoPrice.Data.PromotionDetails["+ i +"].PromotionName");
				promotionDetail.PromotionDesc = context.StringValue("GetPayAsYouGoPrice.Data.PromotionDetails["+ i +"].PromotionDesc");
				promotionDetail.PromotionId = context.LongValue("GetPayAsYouGoPrice.Data.PromotionDetails["+ i +"].PromotionId");

				data_promotionDetails.Add(promotionDetail);
			}
			data.PromotionDetails = data_promotionDetails;
			getPayAsYouGoPriceResponse.Data = data;
        
			return getPayAsYouGoPriceResponse;
        }
    }
}