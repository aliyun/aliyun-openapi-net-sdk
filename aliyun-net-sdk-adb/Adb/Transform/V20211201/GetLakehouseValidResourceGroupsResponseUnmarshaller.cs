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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class GetLakehouseValidResourceGroupsResponseUnmarshaller
    {
        public static GetLakehouseValidResourceGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetLakehouseValidResourceGroupsResponse getLakehouseValidResourceGroupsResponse = new GetLakehouseValidResourceGroupsResponse();

			getLakehouseValidResourceGroupsResponse.HttpResponse = _ctx.HttpResponse;
			getLakehouseValidResourceGroupsResponse.RequestId = _ctx.StringValue("GetLakehouseValidResourceGroups.RequestId");
			getLakehouseValidResourceGroupsResponse.Message = _ctx.StringValue("GetLakehouseValidResourceGroups.Message");
			getLakehouseValidResourceGroupsResponse.HttpStatusCode = _ctx.LongValue("GetLakehouseValidResourceGroups.HttpStatusCode");
			getLakehouseValidResourceGroupsResponse.Success = _ctx.BooleanValue("GetLakehouseValidResourceGroups.Success");

			GetLakehouseValidResourceGroupsResponse.GetLakehouseValidResourceGroups_Data data = new GetLakehouseValidResourceGroupsResponse.GetLakehouseValidResourceGroups_Data();
			data.LakehouseMinComputeResource = _ctx.LongValue("GetLakehouseValidResourceGroups.Data.LakehouseMinComputeResource");

			List<GetLakehouseValidResourceGroupsResponse.GetLakehouseValidResourceGroups_Data.GetLakehouseValidResourceGroups_ValidPoolsInfoItem> data_validPoolsInfo = new List<GetLakehouseValidResourceGroupsResponse.GetLakehouseValidResourceGroups_Data.GetLakehouseValidResourceGroups_ValidPoolsInfoItem>();
			for (int i = 0; i < _ctx.Length("GetLakehouseValidResourceGroups.Data.ValidPoolsInfo.Length"); i++) {
				GetLakehouseValidResourceGroupsResponse.GetLakehouseValidResourceGroups_Data.GetLakehouseValidResourceGroups_ValidPoolsInfoItem validPoolsInfoItem = new GetLakehouseValidResourceGroupsResponse.GetLakehouseValidResourceGroups_Data.GetLakehouseValidResourceGroups_ValidPoolsInfoItem();
				validPoolsInfoItem.MaxComputeResource = _ctx.StringValue("GetLakehouseValidResourceGroups.Data.ValidPoolsInfo["+ i +"].MaxComputeResource");
				validPoolsInfoItem.MinComputeResource = _ctx.StringValue("GetLakehouseValidResourceGroups.Data.ValidPoolsInfo["+ i +"].MinComputeResource");
				validPoolsInfoItem.GroupName = _ctx.StringValue("GetLakehouseValidResourceGroups.Data.ValidPoolsInfo["+ i +"].GroupName");
				validPoolsInfoItem.GroupType = _ctx.StringValue("GetLakehouseValidResourceGroups.Data.ValidPoolsInfo["+ i +"].GroupType");
				validPoolsInfoItem.Available = _ctx.BooleanValue("GetLakehouseValidResourceGroups.Data.ValidPoolsInfo["+ i +"].Available");

				List<string> validPoolsInfoItem_cuOptions = new List<string>();
				for (int j = 0; j < _ctx.Length("GetLakehouseValidResourceGroups.Data.ValidPoolsInfo["+ i +"].CuOptions.Length"); j++) {
					validPoolsInfoItem_cuOptions.Add(_ctx.StringValue("GetLakehouseValidResourceGroups.Data.ValidPoolsInfo["+ i +"].CuOptions["+ j +"]"));
				}
				validPoolsInfoItem.CuOptions = validPoolsInfoItem_cuOptions;

				data_validPoolsInfo.Add(validPoolsInfoItem);
			}
			data.ValidPoolsInfo = data_validPoolsInfo;
			getLakehouseValidResourceGroupsResponse.Data = data;
        
			return getLakehouseValidResourceGroupsResponse;
        }
    }
}
