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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.EHPC.Model.V20180412;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListAvailableEcsTypesResponseUnmarshaller
    {
        public static ListAvailableEcsTypesResponse Unmarshall(UnmarshallerContext context)
        {
			ListAvailableEcsTypesResponse listAvailableEcsTypesResponse = new ListAvailableEcsTypesResponse();

			listAvailableEcsTypesResponse.HttpResponse = context.HttpResponse;
			listAvailableEcsTypesResponse.RequestId = context.StringValue("ListAvailableEcsTypes.RequestId");
			listAvailableEcsTypesResponse.SupportSpotInstance = context.BooleanValue("ListAvailableEcsTypes.SupportSpotInstance");

			List<ListAvailableEcsTypesResponse.ListAvailableEcsTypes_InstanceTypeFamilyInfo> listAvailableEcsTypesResponse_instanceTypeFamilies = new List<ListAvailableEcsTypesResponse.ListAvailableEcsTypes_InstanceTypeFamilyInfo>();
			for (int i = 0; i < context.Length("ListAvailableEcsTypes.InstanceTypeFamilies.Length"); i++) {
				ListAvailableEcsTypesResponse.ListAvailableEcsTypes_InstanceTypeFamilyInfo instanceTypeFamilyInfo = new ListAvailableEcsTypesResponse.ListAvailableEcsTypes_InstanceTypeFamilyInfo();
				instanceTypeFamilyInfo.InstanceTypeFamilyId = context.StringValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].InstanceTypeFamilyId");
				instanceTypeFamilyInfo.Generation = context.StringValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Generation");

				List<ListAvailableEcsTypesResponse.ListAvailableEcsTypes_InstanceTypeFamilyInfo.ListAvailableEcsTypes_TypesInfo> instanceTypeFamilyInfo_types = new List<ListAvailableEcsTypesResponse.ListAvailableEcsTypes_InstanceTypeFamilyInfo.ListAvailableEcsTypes_TypesInfo>();
				for (int j = 0; j < context.Length("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types.Length"); j++) {
					ListAvailableEcsTypesResponse.ListAvailableEcsTypes_InstanceTypeFamilyInfo.ListAvailableEcsTypes_TypesInfo typesInfo = new ListAvailableEcsTypesResponse.ListAvailableEcsTypes_InstanceTypeFamilyInfo.ListAvailableEcsTypes_TypesInfo();
					typesInfo.CpuCoreCount = context.IntegerValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].CpuCoreCount");
					typesInfo.MemorySize = context.IntegerValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].MemorySize");
					typesInfo.GPUAmount = context.IntegerValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].GPUAmount");
					typesInfo.InstanceBandwidthRx = context.IntegerValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].InstanceBandwidthRx");
					typesInfo.InstancePpsRx = context.IntegerValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].InstancePpsRx");
					typesInfo.InstancePpsTx = context.IntegerValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].InstancePpsTx");
					typesInfo.EniQuantity = context.IntegerValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].EniQuantity");
					typesInfo.InstanceBandwidthTx = context.IntegerValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].InstanceBandwidthTx");
					typesInfo.InstanceTypeId = context.StringValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].InstanceTypeId");
					typesInfo.GPUSpec = context.StringValue("ListAvailableEcsTypes.InstanceTypeFamilies["+ i +"].Types["+ j +"].GPUSpec");

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