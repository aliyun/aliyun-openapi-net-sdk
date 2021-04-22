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
        public static DescribeInstanceTypesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceTypesResponse describeInstanceTypesResponse = new DescribeInstanceTypesResponse();

			describeInstanceTypesResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceTypesResponse.RequestId = _ctx.StringValue("DescribeInstanceTypes.RequestId");

			List<DescribeInstanceTypesResponse.DescribeInstanceTypes_InstanceType> describeInstanceTypesResponse_instanceTypes = new List<DescribeInstanceTypesResponse.DescribeInstanceTypes_InstanceType>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceTypes.InstanceTypes.Length"); i++) {
				DescribeInstanceTypesResponse.DescribeInstanceTypes_InstanceType instanceType = new DescribeInstanceTypesResponse.DescribeInstanceTypes_InstanceType();
				instanceType.InstanceTypeId = _ctx.StringValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstanceTypeId");
				instanceType.CpuCoreCount = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].CpuCoreCount");
				instanceType.MemorySize = _ctx.FloatValue("DescribeInstanceTypes.InstanceTypes["+ i +"].MemorySize");
				instanceType.InstanceTypeFamily = _ctx.StringValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstanceTypeFamily");
				instanceType.LocalStorageCapacity = _ctx.LongValue("DescribeInstanceTypes.InstanceTypes["+ i +"].LocalStorageCapacity");
				instanceType.LocalStorageAmount = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].LocalStorageAmount");
				instanceType.LocalStorageCategory = _ctx.StringValue("DescribeInstanceTypes.InstanceTypes["+ i +"].LocalStorageCategory");
				instanceType.GPUAmount = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].GPUAmount");
				instanceType.GPUSpec = _ctx.StringValue("DescribeInstanceTypes.InstanceTypes["+ i +"].GPUSpec");
				instanceType.InitialCredit = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InitialCredit");
				instanceType.BaselineCredit = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].BaselineCredit");
				instanceType.EniQuantity = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].EniQuantity");
				instanceType.EniPrivateIpAddressQuantity = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].EniPrivateIpAddressQuantity");
				instanceType.EniIpv6AddressQuantity = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].EniIpv6AddressQuantity");
				instanceType.InstanceBandwidthRx = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstanceBandwidthRx");
				instanceType.InstanceBandwidthTx = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstanceBandwidthTx");
				instanceType.InstancePpsRx = _ctx.LongValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstancePpsRx");
				instanceType.InstancePpsTx = _ctx.LongValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstancePpsTx");
				instanceType.InstanceFamilyLevel = _ctx.StringValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstanceFamilyLevel");
				instanceType.TotalEniQueueQuantity = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].TotalEniQueueQuantity");
				instanceType.EniTrunkSupported = _ctx.BooleanValue("DescribeInstanceTypes.InstanceTypes["+ i +"].EniTrunkSupported");
				instanceType.EniTotalQuantity = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].EniTotalQuantity");
				instanceType.MaximumQueueNumberPerEni = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].MaximumQueueNumberPerEni");
				instanceType.PrimaryEniQueueNumber = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].PrimaryEniQueueNumber");
				instanceType.SecondaryEniQueueNumber = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].SecondaryEniQueueNumber");
				instanceType.DiskQuantity = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].DiskQuantity");
				instanceType.EriQuantity = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].EriQuantity");
				instanceType.QueuePairNumber = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].QueuePairNumber");
				instanceType.NvmeSupport = _ctx.StringValue("DescribeInstanceTypes.InstanceTypes["+ i +"].NvmeSupport");

				describeInstanceTypesResponse_instanceTypes.Add(instanceType);
			}
			describeInstanceTypesResponse.InstanceTypes = describeInstanceTypesResponse_instanceTypes;
        
			return describeInstanceTypesResponse;
        }
    }
}
