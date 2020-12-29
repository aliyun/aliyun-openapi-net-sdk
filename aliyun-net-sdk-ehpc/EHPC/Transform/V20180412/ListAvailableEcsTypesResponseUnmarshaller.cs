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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListAvailableEcsTypesResponseUnmarshaller
    {
        public static ListAvailableEcsTypesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAvailableEcsTypesResponse listAvailableEcsTypesResponse = new ListAvailableEcsTypesResponse();

			listAvailableEcsTypesResponse.HttpResponse = _ctx.HttpResponse;
			listAvailableEcsTypesResponse.RequestId = _ctx.StringValue("ListAvailableEcsTypes.RequestId");
			listAvailableEcsTypesResponse.SupportSpotInstance = _ctx.BooleanValue("ListAvailableEcsTypes.SupportSpotInstance");

			List<ListAvailableEcsTypesResponse.ListAvailableEcsTypes_InstanceTypeFamilyInfo> listAvailableEcsTypesResponse_instanceTypeFamilies = new List<ListAvailableEcsTypesResponse.ListAvailableEcsTypes_InstanceTypeFamilyInfo>();
			for (int i = 0; i < _ctx.Length("ListAvailableEcsTypes.InstanceTypeFamilies.Length"); i++) {
				ListAvailableEcsTypesResponse.ListAvailableEcsTypes_InstanceTypeFamilyInfo instanceTypeFamilyInfo = new ListAvailableEcsTypesResponse.ListAvailableEcsTypes_InstanceTypeFamilyInfo();
				instanceTypeFamilyInfo.InstanceTypeFamilyId = _ctx.StringValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].InstanceTypeFamilyId");
				instanceTypeFamilyInfo.Generation = _ctx.StringValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Generation");

				List<ListAvailableEcsTypesResponse.ListAvailableEcsTypes_InstanceTypeFamilyInfo.ListAvailableEcsTypes_TypesInfo> instanceTypeFamilyInfo_types = new List<ListAvailableEcsTypesResponse.ListAvailableEcsTypes_InstanceTypeFamilyInfo.ListAvailableEcsTypes_TypesInfo>();
				for (int j = 0; j < _ctx.Length("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types.Length"); j++) {
					ListAvailableEcsTypesResponse.ListAvailableEcsTypes_InstanceTypeFamilyInfo.ListAvailableEcsTypes_TypesInfo typesInfo = new ListAvailableEcsTypesResponse.ListAvailableEcsTypes_InstanceTypeFamilyInfo.ListAvailableEcsTypes_TypesInfo();
					typesInfo.CpuCoreCount = _ctx.IntegerValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].CpuCoreCount");
					typesInfo.MemorySize = _ctx.IntegerValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].MemorySize");
					typesInfo.GPUAmount = _ctx.IntegerValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].GPUAmount");
					typesInfo.InstanceBandwidthRx = _ctx.IntegerValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].InstanceBandwidthRx");
					typesInfo.InstancePpsRx = _ctx.IntegerValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].InstancePpsRx");
					typesInfo.InstancePpsTx = _ctx.IntegerValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].InstancePpsTx");
					typesInfo.EniQuantity = _ctx.IntegerValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].EniQuantity");
					typesInfo.InstanceBandwidthTx = _ctx.IntegerValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].InstanceBandwidthTx");
					typesInfo.InstanceTypeId = _ctx.StringValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].InstanceTypeId");
					typesInfo.GPUSpec = _ctx.StringValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].GPUSpec");
					typesInfo.Status = _ctx.StringValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].Status");

					instanceTypeFamilyInfo_types.Add(typesInfo);
				}
				instanceTypeFamilyInfo.Types = instanceTypeFamilyInfo_types;

				listAvailableEcsTypesResponse_instanceTypeFamilies.Add(instanceTypeFamilyInfo);
			}
			listAvailableEcsTypesResponse.InstanceTypeFamilies = listAvailableEcsTypesResponse_instanceTypeFamilies;
        
			return listAvailableEcsTypesResponse;
        }
    }
}
