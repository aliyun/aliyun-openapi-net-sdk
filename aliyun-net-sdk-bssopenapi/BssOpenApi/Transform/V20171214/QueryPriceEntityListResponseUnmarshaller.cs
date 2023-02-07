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
    public class QueryPriceEntityListResponseUnmarshaller
    {
        public static QueryPriceEntityListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryPriceEntityListResponse queryPriceEntityListResponse = new QueryPriceEntityListResponse();

			queryPriceEntityListResponse.HttpResponse = _ctx.HttpResponse;
			queryPriceEntityListResponse.RequestId = _ctx.StringValue("QueryPriceEntityList.RequestId");
			queryPriceEntityListResponse.Code = _ctx.StringValue("QueryPriceEntityList.Code");
			queryPriceEntityListResponse.Message = _ctx.StringValue("QueryPriceEntityList.Message");
			queryPriceEntityListResponse.Success = _ctx.BooleanValue("QueryPriceEntityList.Success");

			QueryPriceEntityListResponse.QueryPriceEntityList_Data data = new QueryPriceEntityListResponse.QueryPriceEntityList_Data();

			List<QueryPriceEntityListResponse.QueryPriceEntityList_Data.QueryPriceEntityList_PriceEntityInfoDTO> data_priceEntityInfoList = new List<QueryPriceEntityListResponse.QueryPriceEntityList_Data.QueryPriceEntityList_PriceEntityInfoDTO>();
			for (int i = 0; i < _ctx.Length("QueryPriceEntityList.Data.PriceEntityInfoList.Length"); i++) {
				QueryPriceEntityListResponse.QueryPriceEntityList_Data.QueryPriceEntityList_PriceEntityInfoDTO priceEntityInfoDTO = new QueryPriceEntityListResponse.QueryPriceEntityList_Data.QueryPriceEntityList_PriceEntityInfoDTO();
				priceEntityInfoDTO.PriceEntityCode = _ctx.StringValue("QueryPriceEntityList.Data.PriceEntityInfoList["+ i +"].PriceEntityCode");
				priceEntityInfoDTO.PriceEntityName = _ctx.StringValue("QueryPriceEntityList.Data.PriceEntityInfoList["+ i +"].PriceEntityName");

				List<QueryPriceEntityListResponse.QueryPriceEntityList_Data.QueryPriceEntityList_PriceEntityInfoDTO.QueryPriceEntityList_PriceFactorDTO> priceEntityInfoDTO_priceFactorList = new List<QueryPriceEntityListResponse.QueryPriceEntityList_Data.QueryPriceEntityList_PriceEntityInfoDTO.QueryPriceEntityList_PriceFactorDTO>();
				for (int j = 0; j < _ctx.Length("QueryPriceEntityList.Data.PriceEntityInfoList["+ i +"].PriceFactorList.Length"); j++) {
					QueryPriceEntityListResponse.QueryPriceEntityList_Data.QueryPriceEntityList_PriceEntityInfoDTO.QueryPriceEntityList_PriceFactorDTO priceFactorDTO = new QueryPriceEntityListResponse.QueryPriceEntityList_Data.QueryPriceEntityList_PriceEntityInfoDTO.QueryPriceEntityList_PriceFactorDTO();
					priceFactorDTO.PriceFactorCode = _ctx.StringValue("QueryPriceEntityList.Data.PriceEntityInfoList["+ i +"].PriceFactorList["+ j +"].PriceFactorCode");
					priceFactorDTO.PriceFactorName = _ctx.StringValue("QueryPriceEntityList.Data.PriceEntityInfoList["+ i +"].PriceFactorList["+ j +"].PriceFactorName");

					List<string> priceFactorDTO_priceFactorValueList = new List<string>();
					for (int k = 0; k < _ctx.Length("QueryPriceEntityList.Data.PriceEntityInfoList["+ i +"].PriceFactorList["+ j +"].PriceFactorValueList.Length"); k++) {
						priceFactorDTO_priceFactorValueList.Add(_ctx.StringValue("QueryPriceEntityList.Data.PriceEntityInfoList["+ i +"].PriceFactorList["+ j +"].PriceFactorValueList["+ k +"]"));
					}
					priceFactorDTO.PriceFactorValueList = priceFactorDTO_priceFactorValueList;

					priceEntityInfoDTO_priceFactorList.Add(priceFactorDTO);
				}
				priceEntityInfoDTO.PriceFactorList = priceEntityInfoDTO_priceFactorList;

				data_priceEntityInfoList.Add(priceEntityInfoDTO);
			}
			data.PriceEntityInfoList = data_priceEntityInfoList;
			queryPriceEntityListResponse.Data = data;
        
			return queryPriceEntityListResponse;
        }
    }
}
