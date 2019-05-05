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
    public class QueryPriceListResponseUnmarshaller
    {
        public static QueryPriceListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryPriceListResponse queryPriceListResponse = new QueryPriceListResponse();

			queryPriceListResponse.HttpResponse = context.HttpResponse;
			queryPriceListResponse.RequestId = context.StringValue("QueryPriceList.RequestId");
			queryPriceListResponse.Success = context.BooleanValue("QueryPriceList.Success");
			queryPriceListResponse.Code = context.StringValue("QueryPriceList.Code");
			queryPriceListResponse.Message = context.StringValue("QueryPriceList.Message");

			QueryPriceListResponse.QueryPriceList_Data data = new QueryPriceListResponse.QueryPriceList_Data();
			data.Currency = context.StringValue("QueryPriceList.Data.Currency");

			List<QueryPriceListResponse.QueryPriceList_Data.QueryPriceList_Module> data_modules = new List<QueryPriceListResponse.QueryPriceList_Data.QueryPriceList_Module>();
			for (int i = 0; i < context.Length("QueryPriceList.Data.Modules.Length"); i++) {
				QueryPriceListResponse.QueryPriceList_Data.QueryPriceList_Module module = new QueryPriceListResponse.QueryPriceList_Data.QueryPriceList_Module();
				module.ModuleCode = context.StringValue("QueryPriceList.Data.Modules["+ i +"].ModuleCode");
				module.Region = context.StringValue("QueryPriceList.Data.Modules["+ i +"].Region");
				module.Config = context.StringValue("QueryPriceList.Data.Modules["+ i +"].Config");
				module.PriceUnitQuantity = context.StringValue("QueryPriceList.Data.Modules["+ i +"].PriceUnitQuantity");
				module.PriceUnit = context.StringValue("QueryPriceList.Data.Modules["+ i +"].PriceUnit");

				List<QueryPriceListResponse.QueryPriceList_Data.QueryPriceList_Module.QueryPriceList_TierPrice> module_tierPrices = new List<QueryPriceListResponse.QueryPriceList_Data.QueryPriceList_Module.QueryPriceList_TierPrice>();
				for (int j = 0; j < context.Length("QueryPriceList.Data.Modules["+ i +"].TierPrices.Length"); j++) {
					QueryPriceListResponse.QueryPriceList_Data.QueryPriceList_Module.QueryPriceList_TierPrice tierPrice = new QueryPriceListResponse.QueryPriceList_Data.QueryPriceList_Module.QueryPriceList_TierPrice();
					tierPrice.TierStart = context.StringValue("QueryPriceList.Data.Modules["+ i +"].TierPrices["+ j +"].TierStart");
					tierPrice.StartSymbol = context.StringValue("QueryPriceList.Data.Modules["+ i +"].TierPrices["+ j +"].StartSymbol");
					tierPrice.TierEnd = context.StringValue("QueryPriceList.Data.Modules["+ i +"].TierPrices["+ j +"].TierEnd");
					tierPrice.EndSymbol = context.StringValue("QueryPriceList.Data.Modules["+ i +"].TierPrices["+ j +"].EndSymbol");
					tierPrice.TierType = context.StringValue("QueryPriceList.Data.Modules["+ i +"].TierPrices["+ j +"].TierType");
					tierPrice.PriceType = context.StringValue("QueryPriceList.Data.Modules["+ i +"].TierPrices["+ j +"].PriceType");
					tierPrice.Price = context.StringValue("QueryPriceList.Data.Modules["+ i +"].TierPrices["+ j +"].Price");

					module_tierPrices.Add(tierPrice);
				}
				module.TierPrices = module_tierPrices;

				data_modules.Add(module);
			}
			data.Modules = data_modules;
			queryPriceListResponse.Data = data;
        
			return queryPriceListResponse;
        }
    }
}
