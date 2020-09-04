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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeDedicatedHostTypesResponseUnmarshaller
    {
        public static DescribeDedicatedHostTypesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDedicatedHostTypesResponse describeDedicatedHostTypesResponse = new DescribeDedicatedHostTypesResponse();

			describeDedicatedHostTypesResponse.HttpResponse = context.HttpResponse;
			describeDedicatedHostTypesResponse.RequestId = context.StringValue("DescribeDedicatedHostTypes.RequestId");

			List<DescribeDedicatedHostTypesResponse.DescribeDedicatedHostTypes_DedicatedHostType> describeDedicatedHostTypesResponse_dedicatedHostTypes = new List<DescribeDedicatedHostTypesResponse.DescribeDedicatedHostTypes_DedicatedHostType>();
			for (int i = 0; i < context.Length("DescribeDedicatedHostTypes.DedicatedHostTypes.Length"); i++) {
				DescribeDedicatedHostTypesResponse.DescribeDedicatedHostTypes_DedicatedHostType dedicatedHostType = new DescribeDedicatedHostTypesResponse.DescribeDedicatedHostTypes_DedicatedHostType();
				dedicatedHostType.DedicatedHostType = context.StringValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].DedicatedHostType");
				dedicatedHostType.Sockets = context.IntegerValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].Sockets");
				dedicatedHostType.TotalVcpus = context.IntegerValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].TotalVcpus");
				dedicatedHostType.TotalVgpus = context.IntegerValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].TotalVgpus");
				dedicatedHostType.Cores = context.IntegerValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].Cores");
				dedicatedHostType.PhysicalGpus = context.IntegerValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].PhysicalGpus");
				dedicatedHostType.MemorySize = context.FloatValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].MemorySize");
				dedicatedHostType.LocalStorageCapacity = context.LongValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].LocalStorageCapacity");
				dedicatedHostType.LocalStorageAmount = context.IntegerValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].LocalStorageAmount");
				dedicatedHostType.LocalStorageCategory = context.StringValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].LocalStorageCategory");
				dedicatedHostType.GPUSpec = context.StringValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].GPUSpec");
				dedicatedHostType.SupportCpuOverCommitRatio = context.BooleanValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].SupportCpuOverCommitRatio");
				dedicatedHostType.CpuOverCommitRatioRange = context.StringValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].CpuOverCommitRatioRange");

				List<string> dedicatedHostType_supportedInstanceTypeFamilies = new List<string>();
				for (int j = 0; j < context.Length("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].SupportedInstanceTypeFamilies.Length"); j++) {
					dedicatedHostType_supportedInstanceTypeFamilies.Add(context.StringValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].SupportedInstanceTypeFamilies["+ j +"]"));
				}
				dedicatedHostType.SupportedInstanceTypeFamilies = dedicatedHostType_supportedInstanceTypeFamilies;

				List<string> dedicatedHostType_supportedInstanceTypesList = new List<string>();
				for (int j = 0; j < context.Length("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].SupportedInstanceTypesList.Length"); j++) {
					dedicatedHostType_supportedInstanceTypesList.Add(context.StringValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].SupportedInstanceTypesList["+ j +"]"));
				}
				dedicatedHostType.SupportedInstanceTypesList = dedicatedHostType_supportedInstanceTypesList;

				describeDedicatedHostTypesResponse_dedicatedHostTypes.Add(dedicatedHostType);
			}
			describeDedicatedHostTypesResponse.DedicatedHostTypes = describeDedicatedHostTypesResponse_dedicatedHostTypes;
        
			return describeDedicatedHostTypesResponse;
        }
    }
}
