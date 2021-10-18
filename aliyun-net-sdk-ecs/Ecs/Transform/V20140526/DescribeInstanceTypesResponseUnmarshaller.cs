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
			describeInstanceTypesResponse.NextToken = _ctx.StringValue("DescribeInstanceTypes.NextToken");

			List<DescribeInstanceTypesResponse.DescribeInstanceTypes_InstanceType> describeInstanceTypesResponse_instanceTypes = new List<DescribeInstanceTypesResponse.DescribeInstanceTypes_InstanceType>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceTypes.InstanceTypes.Length"); i++) {
				DescribeInstanceTypesResponse.DescribeInstanceTypes_InstanceType instanceType = new DescribeInstanceTypesResponse.DescribeInstanceTypes_InstanceType();
				instanceType.EniTotalQuantity = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].EniTotalQuantity");
				instanceType.LocalStorageCategory = _ctx.StringValue("DescribeInstanceTypes.InstanceTypes["+ i +"].LocalStorageCategory");
				instanceType.PrimaryEniQueueNumber = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].PrimaryEniQueueNumber");
				instanceType.MemorySize = _ctx.FloatValue("DescribeInstanceTypes.InstanceTypes["+ i +"].MemorySize");
				instanceType.LocalStorageCapacity = _ctx.LongValue("DescribeInstanceTypes.InstanceTypes["+ i +"].LocalStorageCapacity");
				instanceType.InstanceFamilyLevel = _ctx.StringValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstanceFamilyLevel");
				instanceType.InstancePpsRx = _ctx.LongValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstancePpsRx");
				instanceType.EniIpv6AddressQuantity = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].EniIpv6AddressQuantity");
				instanceType.MaximumQueueNumberPerEni = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].MaximumQueueNumberPerEni");
				instanceType.InstanceTypeId = _ctx.StringValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstanceTypeId");
				instanceType.InstanceBandwidthRx = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstanceBandwidthRx");
				instanceType.SecondaryEniQueueNumber = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].SecondaryEniQueueNumber");
				instanceType.GPUSpec = _ctx.StringValue("DescribeInstanceTypes.InstanceTypes["+ i +"].GPUSpec");
				instanceType.InstanceBandwidthTx = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstanceBandwidthTx");
				instanceType.QueuePairNumber = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].QueuePairNumber");
				instanceType.EriQuantity = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].EriQuantity");
				instanceType.GPUAmount = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].GPUAmount");
				instanceType.TotalEniQueueQuantity = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].TotalEniQueueQuantity");
				instanceType.NvmeSupport = _ctx.StringValue("DescribeInstanceTypes.InstanceTypes["+ i +"].NvmeSupport");
				instanceType.DiskQuantity = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].DiskQuantity");
				instanceType.InitialCredit = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InitialCredit");
				instanceType.LocalStorageAmount = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].LocalStorageAmount");
				instanceType.BaselineCredit = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].BaselineCredit");
				instanceType.InstancePpsTx = _ctx.LongValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstancePpsTx");
				instanceType.EniPrivateIpAddressQuantity = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].EniPrivateIpAddressQuantity");
				instanceType.CpuCoreCount = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].CpuCoreCount");
				instanceType.InstanceTypeFamily = _ctx.StringValue("DescribeInstanceTypes.InstanceTypes["+ i +"].InstanceTypeFamily");
				instanceType.EniQuantity = _ctx.IntegerValue("DescribeInstanceTypes.InstanceTypes["+ i +"].EniQuantity");
				instanceType.EniTrunkSupported = _ctx.BooleanValue("DescribeInstanceTypes.InstanceTypes["+ i +"].EniTrunkSupported");

				describeInstanceTypesResponse_instanceTypes.Add(instanceType);
			}
			describeInstanceTypesResponse.InstanceTypes = describeInstanceTypesResponse_instanceTypes;
        
			return describeInstanceTypesResponse;
        }
    }
}
