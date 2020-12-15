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
        public static DescribeDedicatedHostAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDedicatedHostAttributeResponse describeDedicatedHostAttributeResponse = new DescribeDedicatedHostAttributeResponse();

			describeDedicatedHostAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeDedicatedHostAttributeResponse.RequestId = _ctx.StringValue("DescribeDedicatedHostAttribute.RequestId");
			describeDedicatedHostAttributeResponse.DedicatedHostGroupId = _ctx.StringValue("DescribeDedicatedHostAttribute.DedicatedHostGroupId");
			describeDedicatedHostAttributeResponse.DedicatedHostId = _ctx.StringValue("DescribeDedicatedHostAttribute.DedicatedHostId");
			describeDedicatedHostAttributeResponse.RegionId = _ctx.StringValue("DescribeDedicatedHostAttribute.RegionId");
			describeDedicatedHostAttributeResponse.ZoneId = _ctx.StringValue("DescribeDedicatedHostAttribute.ZoneId");
			describeDedicatedHostAttributeResponse.VPCId = _ctx.StringValue("DescribeDedicatedHostAttribute.VPCId");
			describeDedicatedHostAttributeResponse.VSwitchId = _ctx.StringValue("DescribeDedicatedHostAttribute.VSwitchId");
			describeDedicatedHostAttributeResponse.IPAddress = _ctx.StringValue("DescribeDedicatedHostAttribute.IPAddress");
			describeDedicatedHostAttributeResponse.HostName = _ctx.StringValue("DescribeDedicatedHostAttribute.HostName");
			describeDedicatedHostAttributeResponse.HostStatus = _ctx.StringValue("DescribeDedicatedHostAttribute.HostStatus");
			describeDedicatedHostAttributeResponse.HostClass = _ctx.StringValue("DescribeDedicatedHostAttribute.HostClass");
			describeDedicatedHostAttributeResponse.HostCPU = _ctx.IntegerValue("DescribeDedicatedHostAttribute.HostCPU");
			describeDedicatedHostAttributeResponse.HostMem = _ctx.IntegerValue("DescribeDedicatedHostAttribute.HostMem");
			describeDedicatedHostAttributeResponse.HostStorage = _ctx.IntegerValue("DescribeDedicatedHostAttribute.HostStorage");
			describeDedicatedHostAttributeResponse.CPUAllocationRatio = _ctx.StringValue("DescribeDedicatedHostAttribute.CPUAllocationRatio");
			describeDedicatedHostAttributeResponse.MemAllocationRatio = _ctx.StringValue("DescribeDedicatedHostAttribute.MemAllocationRatio");
			describeDedicatedHostAttributeResponse.DiskAllocationRatio = _ctx.StringValue("DescribeDedicatedHostAttribute.DiskAllocationRatio");
			describeDedicatedHostAttributeResponse.InstanceNumber = _ctx.IntegerValue("DescribeDedicatedHostAttribute.InstanceNumber");
			describeDedicatedHostAttributeResponse.InstanceNumberMaster = _ctx.IntegerValue("DescribeDedicatedHostAttribute.InstanceNumberMaster");
			describeDedicatedHostAttributeResponse.InstanceNumberSlave = _ctx.IntegerValue("DescribeDedicatedHostAttribute.InstanceNumberSlave");
			describeDedicatedHostAttributeResponse.InstanceNumberROMaster = _ctx.IntegerValue("DescribeDedicatedHostAttribute.InstanceNumberROMaster");
			describeDedicatedHostAttributeResponse.InstanceNumberROSlave = _ctx.IntegerValue("DescribeDedicatedHostAttribute.InstanceNumberROSlave");
			describeDedicatedHostAttributeResponse.CreatedTime = _ctx.StringValue("DescribeDedicatedHostAttribute.CreatedTime");
			describeDedicatedHostAttributeResponse.ExpiredTime = _ctx.StringValue("DescribeDedicatedHostAttribute.ExpiredTime");
			describeDedicatedHostAttributeResponse.AutoRenew = _ctx.StringValue("DescribeDedicatedHostAttribute.AutoRenew");
			describeDedicatedHostAttributeResponse.AllocationStatus = _ctx.StringValue("DescribeDedicatedHostAttribute.AllocationStatus");
			describeDedicatedHostAttributeResponse.CpuUsed = _ctx.StringValue("DescribeDedicatedHostAttribute.CpuUsed");
			describeDedicatedHostAttributeResponse.MemoryUsed = _ctx.StringValue("DescribeDedicatedHostAttribute.MemoryUsed");
			describeDedicatedHostAttributeResponse.StorageUsed = _ctx.StringValue("DescribeDedicatedHostAttribute.StorageUsed");
			describeDedicatedHostAttributeResponse.HostType = _ctx.StringValue("DescribeDedicatedHostAttribute.HostType");
			describeDedicatedHostAttributeResponse.AccountName = _ctx.StringValue("DescribeDedicatedHostAttribute.AccountName");
			describeDedicatedHostAttributeResponse.OpenPermission = _ctx.StringValue("DescribeDedicatedHostAttribute.OpenPermission");
			describeDedicatedHostAttributeResponse.ImageCategory = _ctx.StringValue("DescribeDedicatedHostAttribute.ImageCategory");
        
			return describeDedicatedHostAttributeResponse;
        }
    }
}
