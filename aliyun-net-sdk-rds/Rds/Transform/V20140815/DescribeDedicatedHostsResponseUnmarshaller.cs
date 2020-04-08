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
        public static DescribeDedicatedHostsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDedicatedHostsResponse describeDedicatedHostsResponse = new DescribeDedicatedHostsResponse();

			describeDedicatedHostsResponse.HttpResponse = context.HttpResponse;
			describeDedicatedHostsResponse.RequestId = context.StringValue("DescribeDedicatedHosts.RequestId");
			describeDedicatedHostsResponse.DedicatedHostGroupId = context.StringValue("DescribeDedicatedHosts.DedicatedHostGroupId");

			List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHostsItem> describeDedicatedHostsResponse_dedicatedHosts = new List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHostsItem>();
			for (int i = 0; i < context.Length("DescribeDedicatedHosts.DedicatedHosts.Length"); i++) {
				DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHostsItem dedicatedHostsItem = new DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHostsItem();
				dedicatedHostsItem.HostName = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].HostName");
				dedicatedHostsItem.HostStatus = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].HostStatus");
				dedicatedHostsItem.InstanceNumber = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].InstanceNumber");
				dedicatedHostsItem.CPUAllocationRatio = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].CPUAllocationRatio");
				dedicatedHostsItem.MemAllocationRatio = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].MemAllocationRatio");
				dedicatedHostsItem.DiskAllocationRatio = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].DiskAllocationRatio");
				dedicatedHostsItem.VPCId = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].VPCId");
				dedicatedHostsItem.VSwitchId = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].VSwitchId");
				dedicatedHostsItem.ZoneId = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].ZoneId");
				dedicatedHostsItem.IPAddress = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].IPAddress");
				dedicatedHostsItem.HostClass = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].HostClass");
				dedicatedHostsItem.CreatedTime = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].CreatedTime");
				dedicatedHostsItem.DedicatedHostId = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].DedicatedHostId");
				dedicatedHostsItem.AllocationStatus = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].AllocationStatus");
				dedicatedHostsItem.EndTime = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].EndTime");
				dedicatedHostsItem.HostType = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].HostType");
				dedicatedHostsItem.BastionInstanceId = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].BastionInstanceId");
				dedicatedHostsItem.OpenPermission = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].OpenPermission");
				dedicatedHostsItem.AccountName = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].AccountName");
				dedicatedHostsItem.HostCPU = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].HostCPU");
				dedicatedHostsItem.HostMem = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].HostMem");
				dedicatedHostsItem.HostStorage = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].HostStorage");
				dedicatedHostsItem.CpuUsed = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].CpuUsed");
				dedicatedHostsItem.MemoryUsed = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].MemoryUsed");
				dedicatedHostsItem.StorageUsed = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].StorageUsed");

				describeDedicatedHostsResponse_dedicatedHosts.Add(dedicatedHostsItem);
			}
			describeDedicatedHostsResponse.DedicatedHosts = describeDedicatedHostsResponse_dedicatedHosts;
        
			return describeDedicatedHostsResponse;
        }
    }
}
