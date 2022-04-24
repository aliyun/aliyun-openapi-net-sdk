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
    public class GetResourcePackagePriceResponseUnmarshaller
    {
        public static GetResourcePackagePriceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetResourcePackagePriceResponse getResourcePackagePriceResponse = new GetResourcePackagePriceResponse();

			getResourcePackagePriceResponse.HttpResponse = _ctx.HttpResponse;
			getResourcePackagePriceResponse.Code = _ctx.StringValue("GetResourcePackagePrice.Code");
			getResourcePackagePriceResponse.Message = _ctx.StringValue("GetResourcePackagePrice.Message");
			getResourcePackagePriceResponse.RequestId = _ctx.StringValue("GetResourcePackagePrice.RequestId");
			getResourcePackagePriceResponse.Success = _ctx.BooleanValue("GetResourcePackagePrice.Success");

			GetResourcePackagePriceResponse.GetResourcePackagePrice_Data data = new GetResourcePackagePriceResponse.GetResourcePackagePrice_Data();
			data.OriginalPrice = _ctx.FloatValue("GetResourcePackagePrice.Data.OriginalPrice");
			data.DiscountPrice = _ctx.FloatValue("GetResourcePackagePrice.Data.DiscountPrice");
			data.Currency = _ctx.StringValue("GetResourcePackagePrice.Data.Currency");
			data.TradePrice = _ctx.FloatValue("GetResourcePackagePrice.Data.TradePrice");

			List<GetResourcePackagePriceResponse.GetResourcePackagePrice_Data.GetResourcePackagePrice_Promotion> data_promotions = new List<GetResourcePackagePriceResponse.GetResourcePackagePrice_Data.GetResourcePackagePrice_Promotion>();
			for (int i = 0; i < _ctx.Length("GetResourcePackagePrice.Data.Promotions.Length"); i++) {
				GetResourcePackagePriceResponse.GetResourcePackagePrice_Data.GetResourcePackagePrice_Promotion promotion = new GetResourcePackagePriceResponse.GetResourcePackagePrice_Data.GetResourcePackagePrice_Promotion();
				promotion.Name = _ctx.StringValue("GetResourcePackagePrice.Data.Promotions["+ i +"].Name");
				promotion.Id = _ctx.LongValue("GetResourcePackagePrice.Data.Promotions["+ i +"].Id");

				data_promotions.Add(promotion);
			}
			data.Promotions = data_promotions;
			getResourcePackagePriceResponse.Data = data;
        
			return getResourcePackagePriceResponse;
        }
    }
}
