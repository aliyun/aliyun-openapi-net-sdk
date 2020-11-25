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
        public static DescribeDedicatedHostTypesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDedicatedHostTypesResponse describeDedicatedHostTypesResponse = new DescribeDedicatedHostTypesResponse();

			describeDedicatedHostTypesResponse.HttpResponse = _ctx.HttpResponse;
			describeDedicatedHostTypesResponse.RequestId = _ctx.StringValue("DescribeDedicatedHostTypes.RequestId");

			List<DescribeDedicatedHostTypesResponse.DescribeDedicatedHostTypes_DedicatedHostType> describeDedicatedHostTypesResponse_dedicatedHostTypes = new List<DescribeDedicatedHostTypesResponse.DescribeDedicatedHostTypes_DedicatedHostType>();
			for (int i = 0; i < _ctx.Length("DescribeDedicatedHostTypes.DedicatedHostTypes.Length"); i++) {
				DescribeDedicatedHostTypesResponse.DescribeDedicatedHostTypes_DedicatedHostType dedicatedHostType = new DescribeDedicatedHostTypesResponse.DescribeDedicatedHostTypes_DedicatedHostType();
				dedicatedHostType.DedicatedHostType = _ctx.StringValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].DedicatedHostType");
				dedicatedHostType.Sockets = _ctx.IntegerValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].Sockets");
				dedicatedHostType.TotalVcpus = _ctx.IntegerValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].TotalVcpus");
				dedicatedHostType.TotalVgpus = _ctx.IntegerValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].TotalVgpus");
				dedicatedHostType.Cores = _ctx.IntegerValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].Cores");
				dedicatedHostType.PhysicalGpus = _ctx.IntegerValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].PhysicalGpus");
				dedicatedHostType.MemorySize = _ctx.FloatValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].MemorySize");
				dedicatedHostType.LocalStorageCapacity = _ctx.LongValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].LocalStorageCapacity");
				dedicatedHostType.LocalStorageAmount = _ctx.IntegerValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].LocalStorageAmount");
				dedicatedHostType.LocalStorageCategory = _ctx.StringValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].LocalStorageCategory");
				dedicatedHostType.GPUSpec = _ctx.StringValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].GPUSpec");
				dedicatedHostType.SupportCpuOverCommitRatio = _ctx.BooleanValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].SupportCpuOverCommitRatio");
				dedicatedHostType.CpuOverCommitRatioRange = _ctx.StringValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].CpuOverCommitRatioRange");

				List<string> dedicatedHostType_supportedInstanceTypeFamilies = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].SupportedInstanceTypeFamilies.Length"); j++) {
					dedicatedHostType_supportedInstanceTypeFamilies.Add(_ctx.StringValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].SupportedInstanceTypeFamilies["+ j +"]"));
				}
				dedicatedHostType.SupportedInstanceTypeFamilies = dedicatedHostType_supportedInstanceTypeFamilies;

				List<string> dedicatedHostType_supportedInstanceTypesList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].SupportedInstanceTypesList.Length"); j++) {
					dedicatedHostType_supportedInstanceTypesList.Add(_ctx.StringValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].SupportedInstanceTypesList["+ j +"]"));
				}
				dedicatedHostType.SupportedInstanceTypesList = dedicatedHostType_supportedInstanceTypesList;

				describeDedicatedHostTypesResponse_dedicatedHostTypes.Add(dedicatedHostType);
			}
			describeDedicatedHostTypesResponse.DedicatedHostTypes = describeDedicatedHostTypesResponse_dedicatedHostTypes;
        
			return describeDedicatedHostTypesResponse;
        }
    }
}
