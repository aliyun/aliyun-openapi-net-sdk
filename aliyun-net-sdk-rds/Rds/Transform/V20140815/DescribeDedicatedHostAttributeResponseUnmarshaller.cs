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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDedicatedHostAttributeResponseUnmarshaller
    {
        public static DescribeDedicatedHostAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDedicatedHostAttributeResponse describeDedicatedHostAttributeResponse = new DescribeDedicatedHostAttributeResponse();

			describeDedicatedHostAttributeResponse.HttpResponse = context.HttpResponse;
			describeDedicatedHostAttributeResponse.RequestId = context.StringValue("DescribeDedicatedHostAttribute.RequestId");
			describeDedicatedHostAttributeResponse.DedicatedHostGroupId = context.StringValue("DescribeDedicatedHostAttribute.DedicatedHostGroupId");
			describeDedicatedHostAttributeResponse.DedicatedHostId = context.StringValue("DescribeDedicatedHostAttribute.DedicatedHostId");
			describeDedicatedHostAttributeResponse.RegionId = context.StringValue("DescribeDedicatedHostAttribute.RegionId");
			describeDedicatedHostAttributeResponse.ZoneId = context.StringValue("DescribeDedicatedHostAttribute.ZoneId");
			describeDedicatedHostAttributeResponse.VPCId = context.StringValue("DescribeDedicatedHostAttribute.VPCId");
			describeDedicatedHostAttributeResponse.VSwitchId = context.StringValue("DescribeDedicatedHostAttribute.VSwitchId");
			describeDedicatedHostAttributeResponse.IPAddress = context.StringValue("DescribeDedicatedHostAttribute.IPAddress");
			describeDedicatedHostAttributeResponse.HostName = context.StringValue("DescribeDedicatedHostAttribute.HostName");
			describeDedicatedHostAttributeResponse.HostStatus = context.StringValue("DescribeDedicatedHostAttribute.HostStatus");
			describeDedicatedHostAttributeResponse.HostClass = context.StringValue("DescribeDedicatedHostAttribute.HostClass");
			describeDedicatedHostAttributeResponse.HostCPU = context.IntegerValue("DescribeDedicatedHostAttribute.HostCPU");
			describeDedicatedHostAttributeResponse.HostMem = context.IntegerValue("DescribeDedicatedHostAttribute.HostMem");
			describeDedicatedHostAttributeResponse.HostStorage = context.IntegerValue("DescribeDedicatedHostAttribute.HostStorage");
			describeDedicatedHostAttributeResponse.CPUAllocationRatio = context.StringValue("DescribeDedicatedHostAttribute.CPUAllocationRatio");
			describeDedicatedHostAttributeResponse.MemAllocationRatio = context.StringValue("DescribeDedicatedHostAttribute.MemAllocationRatio");
			describeDedicatedHostAttributeResponse.DiskAllocationRatio = context.StringValue("DescribeDedicatedHostAttribute.DiskAllocationRatio");
			describeDedicatedHostAttributeResponse.InstanceNumber = context.IntegerValue("DescribeDedicatedHostAttribute.InstanceNumber");
			describeDedicatedHostAttributeResponse.InstanceNumberMaster = context.IntegerValue("DescribeDedicatedHostAttribute.InstanceNumberMaster");
			describeDedicatedHostAttributeResponse.InstanceNumberSlave = context.IntegerValue("DescribeDedicatedHostAttribute.InstanceNumberSlave");
			describeDedicatedHostAttributeResponse.InstanceNumberROMaster = context.IntegerValue("DescribeDedicatedHostAttribute.InstanceNumberROMaster");
			describeDedicatedHostAttributeResponse.InstanceNumberROSlave = context.IntegerValue("DescribeDedicatedHostAttribute.InstanceNumberROSlave");
			describeDedicatedHostAttributeResponse.CreatedTime = context.StringValue("DescribeDedicatedHostAttribute.CreatedTime");
			describeDedicatedHostAttributeResponse.ExpiredTime = context.StringValue("DescribeDedicatedHostAttribute.ExpiredTime");
			describeDedicatedHostAttributeResponse.AutoRenew = context.StringValue("DescribeDedicatedHostAttribute.AutoRenew");
			describeDedicatedHostAttributeResponse.AllocationStatus = context.StringValue("DescribeDedicatedHostAttribute.AllocationStatus");
			describeDedicatedHostAttributeResponse.CpuUsed = context.StringValue("DescribeDedicatedHostAttribute.CpuUsed");
			describeDedicatedHostAttributeResponse.MemoryUsed = context.StringValue("DescribeDedicatedHostAttribute.MemoryUsed");
			describeDedicatedHostAttributeResponse.StorageUsed = context.StringValue("DescribeDedicatedHostAttribute.StorageUsed");
			describeDedicatedHostAttributeResponse.HostType = context.StringValue("DescribeDedicatedHostAttribute.HostType");
			describeDedicatedHostAttributeResponse.AccountName = context.StringValue("DescribeDedicatedHostAttribute.AccountName");
			describeDedicatedHostAttributeResponse.OpenPermission = context.StringValue("DescribeDedicatedHostAttribute.OpenPermission");
        
			return describeDedicatedHostAttributeResponse;
        }
    }
}
