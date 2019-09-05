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
using Aliyun.Acs.cusanalytic_sc_online.Model.V20190524;

namespace Aliyun.Acs.cusanalytic_sc_online.Transform.V20190524
{
    public class GetSupportStoreResponseUnmarshaller
    {
        public static GetSupportStoreResponse Unmarshall(UnmarshallerContext context)
        {
			GetSupportStoreResponse getSupportStoreResponse = new GetSupportStoreResponse();

			getSupportStoreResponse.HttpResponse = context.HttpResponse;

			List<GetSupportStoreResponse.GetSupportStore_StorePopDTO> getSupportStoreResponse_storePopDTOs = new List<GetSupportStoreResponse.GetSupportStore_StorePopDTO>();
			for (int i = 0; i < context.Length("GetSupportStore.StorePopDTOs.Length"); i++) {
				GetSupportStoreResponse.GetSupportStore_StorePopDTO storePopDTO = new GetSupportStoreResponse.GetSupportStore_StorePopDTO();
				storePopDTO.StoreId = context.LongValue("GetSupportStore.StorePopDTOs["+ i +"].StoreId");
				storePopDTO.Name = context.StringValue("GetSupportStore.StorePopDTOs["+ i +"].Name");
				storePopDTO.RegionName = context.StringValue("GetSupportStore.StorePopDTOs["+ i +"].RegionName");
				storePopDTO.OpeningStartTime = context.StringValue("GetSupportStore.StorePopDTOs["+ i +"].OpeningStartTime");
				storePopDTO.OpeningEndTime = context.StringValue("GetSupportStore.StorePopDTOs["+ i +"].OpeningEndTime");
				storePopDTO.RegionId = context.LongValue("GetSupportStore.StorePopDTOs["+ i +"].RegionId");
				storePopDTO.StoreType = context.StringValue("GetSupportStore.StorePopDTOs["+ i +"].StoreType");
				storePopDTO.Address = context.StringValue("GetSupportStore.StorePopDTOs["+ i +"].Address");

				getSupportStoreResponse_storePopDTOs.Add(storePopDTO);
			}
			getSupportStoreResponse.StorePopDTOs = getSupportStoreResponse_storePopDTOs;
        
			return getSupportStoreResponse;
        }
    }
}
