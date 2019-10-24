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
    public class QueryCostUnitResponseUnmarshaller
    {
        public static QueryCostUnitResponse Unmarshall(UnmarshallerContext context)
        {
			QueryCostUnitResponse queryCostUnitResponse = new QueryCostUnitResponse();

			queryCostUnitResponse.HttpResponse = context.HttpResponse;
			queryCostUnitResponse.RequestId = context.StringValue("QueryCostUnit.RequestId");
			queryCostUnitResponse.Success = context.BooleanValue("QueryCostUnit.Success");
			queryCostUnitResponse.Code = context.StringValue("QueryCostUnit.Code");
			queryCostUnitResponse.Message = context.StringValue("QueryCostUnit.Message");

			QueryCostUnitResponse.QueryCostUnit_Data data = new QueryCostUnitResponse.QueryCostUnit_Data();
			data.PageNum = context.IntegerValue("QueryCostUnit.Data.PageNum");
			data.PageSize = context.IntegerValue("QueryCostUnit.Data.PageSize");
			data.TotalCount = context.IntegerValue("QueryCostUnit.Data.TotalCount");

			List<QueryCostUnitResponse.QueryCostUnit_Data.QueryCostUnit_CostUnitDtoListItem> data_costUnitDtoList = new List<QueryCostUnitResponse.QueryCostUnit_Data.QueryCostUnit_CostUnitDtoListItem>();
			for (int i = 0; i < context.Length("QueryCostUnit.Data.CostUnitDtoList.Length"); i++) {
				QueryCostUnitResponse.QueryCostUnit_Data.QueryCostUnit_CostUnitDtoListItem costUnitDtoListItem = new QueryCostUnitResponse.QueryCostUnit_Data.QueryCostUnit_CostUnitDtoListItem();
				costUnitDtoListItem.OwnerUid = context.LongValue("QueryCostUnit.Data.CostUnitDtoList["+ i +"].OwnerUid");
				costUnitDtoListItem.ParentUnitId = context.LongValue("QueryCostUnit.Data.CostUnitDtoList["+ i +"].ParentUnitId");
				costUnitDtoListItem.UnitId = context.LongValue("QueryCostUnit.Data.CostUnitDtoList["+ i +"].UnitId");
				costUnitDtoListItem.UnitName = context.StringValue("QueryCostUnit.Data.CostUnitDtoList["+ i +"].UnitName");

				data_costUnitDtoList.Add(costUnitDtoListItem);
			}
			data.CostUnitDtoList = data_costUnitDtoList;
			queryCostUnitResponse.Data = data;
        
			return queryCostUnitResponse;
        }
    }
}
