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
    public class QueryCommodityListResponseUnmarshaller
    {
        public static QueryCommodityListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryCommodityListResponse queryCommodityListResponse = new QueryCommodityListResponse();

			queryCommodityListResponse.HttpResponse = _ctx.HttpResponse;
			queryCommodityListResponse.RequestId = _ctx.StringValue("QueryCommodityList.RequestId");
			queryCommodityListResponse.Message = _ctx.StringValue("QueryCommodityList.Message");
			queryCommodityListResponse.Success = _ctx.BooleanValue("QueryCommodityList.Success");
			queryCommodityListResponse.Code = _ctx.StringValue("QueryCommodityList.Code");

			QueryCommodityListResponse.QueryCommodityList_Data data = new QueryCommodityListResponse.QueryCommodityList_Data();

			List<QueryCommodityListResponse.QueryCommodityList_Data.QueryCommodityList_CommodityDTO> data_commodityList = new List<QueryCommodityListResponse.QueryCommodityList_Data.QueryCommodityList_CommodityDTO>();
			for (int i = 0; i < _ctx.Length("QueryCommodityList.Data.CommodityList.Length"); i++) {
				QueryCommodityListResponse.QueryCommodityList_Data.QueryCommodityList_CommodityDTO commodityDTO = new QueryCommodityListResponse.QueryCommodityList_Data.QueryCommodityList_CommodityDTO();
				commodityDTO.CommodityCode = _ctx.StringValue("QueryCommodityList.Data.CommodityList["+ i +"].CommodityCode");
				commodityDTO.CommodityName = _ctx.StringValue("QueryCommodityList.Data.CommodityList["+ i +"].CommodityName");
				commodityDTO.ChargeType = _ctx.StringValue("QueryCommodityList.Data.CommodityList["+ i +"].ChargeType");

				data_commodityList.Add(commodityDTO);
			}
			data.CommodityList = data_commodityList;
			queryCommodityListResponse.Data = data;
        
			return queryCommodityListResponse;
        }
    }
}
