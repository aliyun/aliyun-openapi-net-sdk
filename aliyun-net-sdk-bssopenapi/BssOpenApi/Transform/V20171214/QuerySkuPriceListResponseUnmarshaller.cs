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
    public class QuerySkuPriceListResponseUnmarshaller
    {
        public static QuerySkuPriceListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySkuPriceListResponse querySkuPriceListResponse = new QuerySkuPriceListResponse();

			querySkuPriceListResponse.HttpResponse = _ctx.HttpResponse;
			querySkuPriceListResponse.RequestId = _ctx.StringValue("QuerySkuPriceList.RequestId");
			querySkuPriceListResponse.Code = _ctx.StringValue("QuerySkuPriceList.Code");
			querySkuPriceListResponse.Message = _ctx.StringValue("QuerySkuPriceList.Message");
			querySkuPriceListResponse.Success = _ctx.BooleanValue("QuerySkuPriceList.Success");

			QuerySkuPriceListResponse.QuerySkuPriceList_Data data = new QuerySkuPriceListResponse.QuerySkuPriceList_Data();

			QuerySkuPriceListResponse.QuerySkuPriceList_Data.QuerySkuPriceList_SkuPricePage skuPricePage = new QuerySkuPriceListResponse.QuerySkuPriceList_Data.QuerySkuPriceList_SkuPricePage();
			skuPricePage.TotalCount = _ctx.IntegerValue("QuerySkuPriceList.Data.SkuPricePage.TotalCount");
			skuPricePage.NextPageToken = _ctx.StringValue("QuerySkuPriceList.Data.SkuPricePage.NextPageToken");

			List<QuerySkuPriceListResponse.QuerySkuPriceList_Data.QuerySkuPriceList_SkuPricePage.QuerySkuPriceList_SkuPricePageDTO> skuPricePage_skuPriceList = new List<QuerySkuPriceListResponse.QuerySkuPriceList_Data.QuerySkuPriceList_SkuPricePage.QuerySkuPriceList_SkuPricePageDTO>();
			for (int i = 0; i < _ctx.Length("QuerySkuPriceList.Data.SkuPricePage.SkuPriceList.Length"); i++) {
				QuerySkuPriceListResponse.QuerySkuPriceList_Data.QuerySkuPriceList_SkuPricePage.QuerySkuPriceList_SkuPricePageDTO skuPricePageDTO = new QuerySkuPriceListResponse.QuerySkuPriceList_Data.QuerySkuPriceList_SkuPricePage.QuerySkuPriceList_SkuPricePageDTO();
				skuPricePageDTO.SkuCode = _ctx.StringValue("QuerySkuPriceList.Data.SkuPricePage.SkuPriceList["+ i +"].SkuCode");
				skuPricePageDTO.SkuFactorMap = _ctx.StringValue("QuerySkuPriceList.Data.SkuPricePage.SkuPriceList["+ i +"].SkuFactorMap");

				List<QuerySkuPriceListResponse.QuerySkuPriceList_Data.QuerySkuPriceList_SkuPricePage.QuerySkuPriceList_SkuPricePageDTO.QuerySkuPriceList_CSkuPriceDTO> skuPricePageDTO_cskuPriceList = new List<QuerySkuPriceListResponse.QuerySkuPriceList_Data.QuerySkuPriceList_SkuPricePage.QuerySkuPriceList_SkuPricePageDTO.QuerySkuPriceList_CSkuPriceDTO>();
				for (int j = 0; j < _ctx.Length("QuerySkuPriceList.Data.SkuPricePage.SkuPriceList["+ i +"].CskuPriceList.Length"); j++) {
					QuerySkuPriceListResponse.QuerySkuPriceList_Data.QuerySkuPriceList_SkuPricePage.QuerySkuPriceList_SkuPricePageDTO.QuerySkuPriceList_CSkuPriceDTO cSkuPriceDTO = new QuerySkuPriceListResponse.QuerySkuPriceList_Data.QuerySkuPriceList_SkuPricePage.QuerySkuPriceList_SkuPricePageDTO.QuerySkuPriceList_CSkuPriceDTO();
					cSkuPriceDTO.CskuCode = _ctx.StringValue("QuerySkuPriceList.Data.SkuPricePage.SkuPriceList["+ i +"].CskuPriceList["+ j +"].CskuCode");
					cSkuPriceDTO.Currency = _ctx.StringValue("QuerySkuPriceList.Data.SkuPricePage.SkuPriceList["+ i +"].CskuPriceList["+ j +"].Currency");
					cSkuPriceDTO.UsageUnit = _ctx.StringValue("QuerySkuPriceList.Data.SkuPricePage.SkuPriceList["+ i +"].CskuPriceList["+ j +"].UsageUnit");
					cSkuPriceDTO.PriceType = _ctx.StringValue("QuerySkuPriceList.Data.SkuPricePage.SkuPriceList["+ i +"].CskuPriceList["+ j +"].PriceType");
					cSkuPriceDTO.PriceMode = _ctx.StringValue("QuerySkuPriceList.Data.SkuPricePage.SkuPriceList["+ i +"].CskuPriceList["+ j +"].PriceMode");
					cSkuPriceDTO.Price = _ctx.StringValue("QuerySkuPriceList.Data.SkuPricePage.SkuPriceList["+ i +"].CskuPriceList["+ j +"].Price");
					cSkuPriceDTO.PriceUnit = _ctx.StringValue("QuerySkuPriceList.Data.SkuPricePage.SkuPriceList["+ i +"].CskuPriceList["+ j +"].PriceUnit");

					List<QuerySkuPriceListResponse.QuerySkuPriceList_Data.QuerySkuPriceList_SkuPricePage.QuerySkuPriceList_SkuPricePageDTO.QuerySkuPriceList_CSkuPriceDTO.QuerySkuPriceList_RangeDTO> cSkuPriceDTO_rangeList = new List<QuerySkuPriceListResponse.QuerySkuPriceList_Data.QuerySkuPriceList_SkuPricePage.QuerySkuPriceList_SkuPricePageDTO.QuerySkuPriceList_CSkuPriceDTO.QuerySkuPriceList_RangeDTO>();
					for (int k = 0; k < _ctx.Length("QuerySkuPriceList.Data.SkuPricePage.SkuPriceList["+ i +"].CskuPriceList["+ j +"].RangeList.Length"); k++) {
						QuerySkuPriceListResponse.QuerySkuPriceList_Data.QuerySkuPriceList_SkuPricePage.QuerySkuPriceList_SkuPricePageDTO.QuerySkuPriceList_CSkuPriceDTO.QuerySkuPriceList_RangeDTO rangeDTO = new QuerySkuPriceListResponse.QuerySkuPriceList_Data.QuerySkuPriceList_SkuPricePage.QuerySkuPriceList_SkuPricePageDTO.QuerySkuPriceList_CSkuPriceDTO.QuerySkuPriceList_RangeDTO();
						rangeDTO.FactorCode = _ctx.StringValue("QuerySkuPriceList.Data.SkuPricePage.SkuPriceList["+ i +"].CskuPriceList["+ j +"].RangeList["+ k +"].FactorCode");
						rangeDTO.Min = _ctx.StringValue("QuerySkuPriceList.Data.SkuPricePage.SkuPriceList["+ i +"].CskuPriceList["+ j +"].RangeList["+ k +"].Min");
						rangeDTO.Max = _ctx.StringValue("QuerySkuPriceList.Data.SkuPricePage.SkuPriceList["+ i +"].CskuPriceList["+ j +"].RangeList["+ k +"].Max");
						rangeDTO.Type = _ctx.StringValue("QuerySkuPriceList.Data.SkuPricePage.SkuPriceList["+ i +"].CskuPriceList["+ j +"].RangeList["+ k +"].Type");

						cSkuPriceDTO_rangeList.Add(rangeDTO);
					}
					cSkuPriceDTO.RangeList = cSkuPriceDTO_rangeList;

					skuPricePageDTO_cskuPriceList.Add(cSkuPriceDTO);
				}
				skuPricePageDTO.CskuPriceList = skuPricePageDTO_cskuPriceList;

				skuPricePage_skuPriceList.Add(skuPricePageDTO);
			}
			skuPricePage.SkuPriceList = skuPricePage_skuPriceList;
			data.SkuPricePage = skuPricePage;
			querySkuPriceListResponse.Data = data;
        
			return querySkuPriceListResponse;
        }
    }
}
