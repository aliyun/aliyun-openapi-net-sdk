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
    public class DescribeDedicatedHostsResponseUnmarshaller
    {
        public static DescribeDedicatedHostsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDedicatedHostsResponse describeDedicatedHostsResponse = new DescribeDedicatedHostsResponse();

			describeDedicatedHostsResponse.HttpResponse = _ctx.HttpResponse;
			describeDedicatedHostsResponse.DedicatedHostGroupId = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHostGroupId");
			describeDedicatedHostsResponse.RequestId = _ctx.StringValue("DescribeDedicatedHosts.RequestId");

			List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHostsItem> describeDedicatedHostsResponse_dedicatedHosts = new List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHostsItem>();
			for (int i = 0; i < _ctx.Length("DescribeDedicatedHosts.DedicatedHosts.Length"); i++) {
				DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHostsItem dedicatedHostsItem = new DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHostsItem();
				dedicatedHostsItem.HostType = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].HostType");
				dedicatedHostsItem.HostStorage = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].HostStorage");
				dedicatedHostsItem.MemoryUsed = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].MemoryUsed");
				dedicatedHostsItem.DedicatedHostGroupId = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].DedicatedHostGroupId");
				dedicatedHostsItem.AllocationStatus = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].AllocationStatus");
				dedicatedHostsItem.StorageUsed = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].StorageUsed");
				dedicatedHostsItem.DedicatedHostId = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].DedicatedHostId");
				dedicatedHostsItem.MemAllocationRatio = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].MemAllocationRatio");
				dedicatedHostsItem.CreatedTime = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].CreatedTime");
				dedicatedHostsItem.IPAddress = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].IPAddress");
				dedicatedHostsItem.HostStatus = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].HostStatus");
				dedicatedHostsItem.HostName = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].HostName");
				dedicatedHostsItem.HostCPU = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].HostCPU");
				dedicatedHostsItem.InstanceNumber = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].InstanceNumber");
				dedicatedHostsItem.OpenPermission = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].OpenPermission");
				dedicatedHostsItem.CpuUsed = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].CpuUsed");
				dedicatedHostsItem.VPCId = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].VPCId");
				dedicatedHostsItem.HostClass = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].HostClass");
				dedicatedHostsItem.EndTime = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].EndTime");
				dedicatedHostsItem.VSwitchId = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].VSwitchId");
				dedicatedHostsItem.CPUAllocationRatio = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].CPUAllocationRatio");
				dedicatedHostsItem.ZoneId = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].ZoneId");
				dedicatedHostsItem.ImageCategory = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].ImageCategory");
				dedicatedHostsItem.Engine = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Engine");
				dedicatedHostsItem.DiskAllocationRatio = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].DiskAllocationRatio");
				dedicatedHostsItem.HostMem = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].HostMem");
				dedicatedHostsItem.BastionInstanceId = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].BastionInstanceId");
				dedicatedHostsItem.AccountName = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].AccountName");

				describeDedicatedHostsResponse_dedicatedHosts.Add(dedicatedHostsItem);
			}
			describeDedicatedHostsResponse.DedicatedHosts = describeDedicatedHostsResponse_dedicatedHosts;
        
			return describeDedicatedHostsResponse;
        }
    }
}
