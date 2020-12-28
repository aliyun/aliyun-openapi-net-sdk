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
    public class GetPayAsYouGoPriceResponseUnmarshaller
    {
        public static GetPayAsYouGoPriceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPayAsYouGoPriceResponse getPayAsYouGoPriceResponse = new GetPayAsYouGoPriceResponse();

			getPayAsYouGoPriceResponse.HttpResponse = _ctx.HttpResponse;
			getPayAsYouGoPriceResponse.RequestId = _ctx.StringValue("GetPayAsYouGoPrice.RequestId");
			getPayAsYouGoPriceResponse.Success = _ctx.BooleanValue("GetPayAsYouGoPrice.Success");
			getPayAsYouGoPriceResponse.Code = _ctx.StringValue("GetPayAsYouGoPrice.Code");
			getPayAsYouGoPriceResponse.Message = _ctx.StringValue("GetPayAsYouGoPrice.Message");

			GetPayAsYouGoPriceResponse.GetPayAsYouGoPrice_Data data = new GetPayAsYouGoPriceResponse.GetPayAsYouGoPrice_Data();
			data.Currency = _ctx.StringValue("GetPayAsYouGoPrice.Data.Currency");

			List<GetPayAsYouGoPriceResponse.GetPayAsYouGoPrice_Data.GetPayAsYouGoPrice_ModuleDetail> data_moduleDetails = new List<GetPayAsYouGoPriceResponse.GetPayAsYouGoPrice_Data.GetPayAsYouGoPrice_ModuleDetail>();
			for (int i = 0; i < _ctx.Length("GetPayAsYouGoPrice.Data.ModuleDetails.Length"); i++) {
				GetPayAsYouGoPriceResponse.GetPayAsYouGoPrice_Data.GetPayAsYouGoPrice_ModuleDetail moduleDetail = new GetPayAsYouGoPriceResponse.GetPayAsYouGoPrice_Data.GetPayAsYouGoPrice_ModuleDetail();
				moduleDetail.ModuleCode = _ctx.StringValue("GetPayAsYouGoPrice.Data.ModuleDetails["+ i +"].ModuleCode");
				moduleDetail.OriginalCost = _ctx.FloatValue("GetPayAsYouGoPrice.Data.ModuleDetails["+ i +"].OriginalCost");
				moduleDetail.InvoiceDiscount = _ctx.FloatValue("GetPayAsYouGoPrice.Data.ModuleDetails["+ i +"].InvoiceDiscount");
				moduleDetail.CostAfterDiscount = _ctx.FloatValue("GetPayAsYouGoPrice.Data.ModuleDetails["+ i +"].CostAfterDiscount");
				moduleDetail.UnitPrice = _ctx.FloatValue("GetPayAsYouGoPrice.Data.ModuleDetails["+ i +"].UnitPrice");

				data_moduleDetails.Add(moduleDetail);
			}
			data.ModuleDetails = data_moduleDetails;

			List<GetPayAsYouGoPriceResponse.GetPayAsYouGoPrice_Data.GetPayAsYouGoPrice_PromotionDetail> data_promotionDetails = new List<GetPayAsYouGoPriceResponse.GetPayAsYouGoPrice_Data.GetPayAsYouGoPrice_PromotionDetail>();
			for (int i = 0; i < _ctx.Length("GetPayAsYouGoPrice.Data.PromotionDetails.Length"); i++) {
				GetPayAsYouGoPriceResponse.GetPayAsYouGoPrice_Data.GetPayAsYouGoPrice_PromotionDetail promotionDetail = new GetPayAsYouGoPriceResponse.GetPayAsYouGoPrice_Data.GetPayAsYouGoPrice_PromotionDetail();
				promotionDetail.PromotionName = _ctx.StringValue("GetPayAsYouGoPrice.Data.PromotionDetails["+ i +"].PromotionName");
				promotionDetail.PromotionDesc = _ctx.StringValue("GetPayAsYouGoPrice.Data.PromotionDetails["+ i +"].PromotionDesc");
				promotionDetail.PromotionId = _ctx.LongValue("GetPayAsYouGoPrice.Data.PromotionDetails["+ i +"].PromotionId");

				data_promotionDetails.Add(promotionDetail);
			}
			data.PromotionDetails = data_promotionDetails;
			getPayAsYouGoPriceResponse.Data = data;
        
			return getPayAsYouGoPriceResponse;
        }
    }
}
