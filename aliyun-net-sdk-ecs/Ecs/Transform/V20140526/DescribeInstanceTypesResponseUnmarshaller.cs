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
    public class DescribeInstanceTypesResponseUnmarshaller
    {
        public static DescribeInstanceTypesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceTypesResponse describeInstanceTypesResponse = new DescribeInstanceTypesResponse();

			describeInstanceTypesResponse.HttpResponse = context.HttpResponse;
			describeInstanceTypesResponse.RequestId = context.StringValue("DescribeInstanceTypes.RequestId");

			List<DescribeInstanceTypesResponse.DescribeInstanceTypes_InstanceType> describeInstanceTypesResponse_instanceTypes = new List<DescribeInstanceTypesResponse.DescribeInstanceTypes_InstanceType>();
			for (int i = 0; i < context.Length("DescribeInstanceTypes.InstanceTypes.Length"); i++) {
				DescribeInstanceTypesResponse.DescribeInstanceTypes_InstanceType instanceType = new DescribeInstanceTypesResponse.DescribeInstanceTypes_InstanceType();
				instanceType.InstanceTypeId = context.StringValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstanceTypeId");
				instanceType.CpuCoreCount = context.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].CpuCoreCount");
				instanceType.MemorySize = context.FloatValue("DescribeInstanceTypes.InstanceTypes["+ i +"].MemorySize");
				instanceType.InstanceTypeFamily = context.StringValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstanceTypeFamily");
				instanceType.LocalStorageCapacity = context.LongValue("DescribeInstanceTypes.InstanceTypes["+ i +"].LocalStorageCapacity");
				instanceType.LocalStorageAmount = context.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].LocalStorageAmount");
				instanceType.LocalStorageCategory = context.StringValue("DescribeInstanceTypes.InstanceTypes["+ i +"].LocalStorageCategory");
				instanceType.GPUAmount = context.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].GPUAmount");
				instanceType.GPUSpec = context.StringValue("DescribeInstanceTypes.InstanceTypes["+ i +"].GPUSpec");
				instanceType.InitialCredit = context.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InitialCredit");
				instanceType.BaselineCredit = context.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].BaselineCredit");
				instanceType.EniQuantity = context.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].EniQuantity");
				instanceType.EniPrivateIpAddressQuantity = context.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].EniPrivateIpAddressQuantity");
				instanceType.EniIpv6AddressQuantity = context.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].EniIpv6AddressQuantity");
				instanceType.InstanceBandwidthRx = context.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstanceBandwidthRx");
				instanceType.InstanceBandwidthTx = context.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstanceBandwidthTx");
				instanceType.InstancePpsRx = context.LongValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstancePpsRx");
				instanceType.InstancePpsTx = context.LongValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstancePpsTx");
				instanceType.InstanceFamilyLevel = context.StringValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstanceFamilyLevel");
				instanceType.TotalEniQueueQuantity = context.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].TotalEniQueueQuantity");
				instanceType.EniTrunkSupported = context.BooleanValue("DescribeInstanceTypes.InstanceTypes["+ i +"].EniTrunkSupported");
				instanceType.EniTotalQuantity = context.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].EniTotalQuantity");
				instanceType.MaximumQueueNumberPerEni = context.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].MaximumQueueNumberPerEni");
				instanceType.PrimaryEniQueueNumber = context.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].PrimaryEniQueueNumber");
				instanceType.SecondaryEniQueueNumber = context.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].SecondaryEniQueueNumber");

				describeInstanceTypesResponse_instanceTypes.Add(instanceType);
			}
			describeInstanceTypesResponse.InstanceTypes = describeInstanceTypesResponse_instanceTypes;
        
			return describeInstanceTypesResponse;
        }
    }
}
