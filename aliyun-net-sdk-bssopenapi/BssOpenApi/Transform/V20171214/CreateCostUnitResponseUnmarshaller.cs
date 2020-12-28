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
    public class CreateCostUnitResponseUnmarshaller
    {
        public static CreateCostUnitResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateCostUnitResponse createCostUnitResponse = new CreateCostUnitResponse();

			createCostUnitResponse.HttpResponse = _ctx.HttpResponse;
			createCostUnitResponse.RequestId = _ctx.StringValue("CreateCostUnit.RequestId");
			createCostUnitResponse.Message = _ctx.StringValue("CreateCostUnit.Message");
			createCostUnitResponse.Code = _ctx.StringValue("CreateCostUnit.Code");
			createCostUnitResponse.Success = _ctx.BooleanValue("CreateCostUnit.Success");

			CreateCostUnitResponse.CreateCostUnit_Data data = new CreateCostUnitResponse.CreateCostUnit_Data();

			List<CreateCostUnitResponse.CreateCostUnit_Data.CreateCostUnit_CostUnitDtoListItem> data_costUnitDtoList = new List<CreateCostUnitResponse.CreateCostUnit_Data.CreateCostUnit_CostUnitDtoListItem>();
			for (int i = 0; i < _ctx.Length("CreateCostUnit.Data.CostUnitDtoList.Length"); i++) {
				CreateCostUnitResponse.CreateCostUnit_Data.CreateCostUnit_CostUnitDtoListItem costUnitDtoListItem = new CreateCostUnitResponse.CreateCostUnit_Data.CreateCostUnit_CostUnitDtoListItem();
				costUnitDtoListItem.UnitId = _ctx.LongValue("CreateCostUnit.Data.CostUnitDtoList["+ i +"].UnitId");
				costUnitDtoListItem.ParentUnitId = _ctx.LongValue("CreateCostUnit.Data.CostUnitDtoList["+ i +"].ParentUnitId");
				costUnitDtoListItem.OwnerUid = _ctx.LongValue("CreateCostUnit.Data.CostUnitDtoList["+ i +"].OwnerUid");
				costUnitDtoListItem.UnitName = _ctx.StringValue("CreateCostUnit.Data.CostUnitDtoList["+ i +"].UnitName");

				data_costUnitDtoList.Add(costUnitDtoListItem);
			}
			data.CostUnitDtoList = data_costUnitDtoList;
			createCostUnitResponse.Data = data;
        
			return createCostUnitResponse;
        }
    }
}
