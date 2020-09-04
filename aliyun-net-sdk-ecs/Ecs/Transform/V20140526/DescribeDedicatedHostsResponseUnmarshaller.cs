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
    public class DescribeDedicatedHostsResponseUnmarshaller
    {
        public static DescribeDedicatedHostsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDedicatedHostsResponse describeDedicatedHostsResponse = new DescribeDedicatedHostsResponse();

			describeDedicatedHostsResponse.HttpResponse = context.HttpResponse;
			describeDedicatedHostsResponse.RequestId = context.StringValue("DescribeDedicatedHosts.RequestId");
			describeDedicatedHostsResponse.TotalCount = context.IntegerValue("DescribeDedicatedHosts.TotalCount");
			describeDedicatedHostsResponse.PageNumber = context.IntegerValue("DescribeDedicatedHosts.PageNumber");
			describeDedicatedHostsResponse.PageSize = context.IntegerValue("DescribeDedicatedHosts.PageSize");

			List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost> describeDedicatedHostsResponse_dedicatedHosts = new List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost>();
			for (int i = 0; i < context.Length("DescribeDedicatedHosts.DedicatedHosts.Length"); i++) {
				DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost dedicatedHost = new DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost();
				dedicatedHost.DedicatedHostId = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].DedicatedHostId");
				dedicatedHost.AutoPlacement = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].AutoPlacement");
				dedicatedHost.RegionId = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].RegionId");
				dedicatedHost.ZoneId = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].ZoneId");
				dedicatedHost.DedicatedHostName = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].DedicatedHostName");
				dedicatedHost.MachineId = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].MachineId");
				dedicatedHost.Description = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Description");
				dedicatedHost.DedicatedHostType = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].DedicatedHostType");
				dedicatedHost.Sockets = context.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Sockets");
				dedicatedHost.Cores = context.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Cores");
				dedicatedHost.PhysicalGpus = context.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].PhysicalGpus");
				dedicatedHost.GPUSpec = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].GPUSpec");
				dedicatedHost.ActionOnMaintenance = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].ActionOnMaintenance");
				dedicatedHost.Status = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Status");
				dedicatedHost.CreationTime = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].CreationTime");
				dedicatedHost.ChargeType = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].ChargeType");
				dedicatedHost.SaleCycle = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].SaleCycle");
				dedicatedHost.ExpiredTime = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].ExpiredTime");
				dedicatedHost.AutoReleaseTime = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].AutoReleaseTime");
				dedicatedHost.ResourceGroupId = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].ResourceGroupId");
				dedicatedHost.DedicatedHostClusterId = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].DedicatedHostClusterId");
				dedicatedHost.CpuOverCommitRatio = context.FloatValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].CpuOverCommitRatio");

				List<string> dedicatedHost_supportedInstanceTypeFamilies = new List<string>();
				for (int j = 0; j < context.Length("DescribeDedicatedHosts.DedicatedHosts["+ i +"].SupportedInstanceTypeFamilies.Length"); j++) {
					dedicatedHost_supportedInstanceTypeFamilies.Add(context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].SupportedInstanceTypeFamilies["+ j +"]"));
				}
				dedicatedHost.SupportedInstanceTypeFamilies = dedicatedHost_supportedInstanceTypeFamilies;

				List<string> dedicatedHost_supportedCustomInstanceTypeFamilies = new List<string>();
				for (int j = 0; j < context.Length("DescribeDedicatedHosts.DedicatedHosts["+ i +"].SupportedCustomInstanceTypeFamilies.Length"); j++) {
					dedicatedHost_supportedCustomInstanceTypeFamilies.Add(context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].SupportedCustomInstanceTypeFamilies["+ j +"]"));
				}
				dedicatedHost.SupportedCustomInstanceTypeFamilies = dedicatedHost_supportedCustomInstanceTypeFamilies;

				List<string> dedicatedHost_supportedInstanceTypesList = new List<string>();
				for (int j = 0; j < context.Length("DescribeDedicatedHosts.DedicatedHosts["+ i +"].SupportedInstanceTypesList.Length"); j++) {
					dedicatedHost_supportedInstanceTypesList.Add(context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].SupportedInstanceTypesList["+ j +"]"));
				}
				dedicatedHost.SupportedInstanceTypesList = dedicatedHost_supportedInstanceTypesList;

				DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Capacity capacity = new DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Capacity();
				capacity.TotalVcpus = context.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.TotalVcpus");
				capacity.AvailableVcpus = context.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.AvailableVcpus");
				capacity.TotalVgpus = context.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.TotalVgpus");
				capacity.AvailableVgpus = context.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.AvailableVgpus");
				capacity.TotalMemory = context.FloatValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.TotalMemory");
				capacity.AvailableMemory = context.FloatValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.AvailableMemory");
				capacity.TotalLocalStorage = context.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.TotalLocalStorage");
				capacity.AvailableLocalStorage = context.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.AvailableLocalStorage");
				capacity.LocalStorageCategory = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.LocalStorageCategory");
				dedicatedHost.Capacity = capacity;

				DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_NetworkAttributes networkAttributes = new DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_NetworkAttributes();
				networkAttributes.SlbUdpTimeout = context.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].NetworkAttributes.SlbUdpTimeout");
				networkAttributes.UdpTimeout = context.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].NetworkAttributes.UdpTimeout");
				dedicatedHost.NetworkAttributes = networkAttributes;

				List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Instance> dedicatedHost_instances = new List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Instance>();
				for (int j = 0; j < context.Length("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Instances.Length"); j++) {
					DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Instance instance = new DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Instance();
					instance.InstanceId = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Instances["+ j +"].InstanceId");
					instance.InstanceType = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Instances["+ j +"].InstanceType");

					dedicatedHost_instances.Add(instance);
				}
				dedicatedHost.Instances = dedicatedHost_instances;

				List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_OperationLock> dedicatedHost_operationLocks = new List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_OperationLock>();
				for (int j = 0; j < context.Length("DescribeDedicatedHosts.DedicatedHosts["+ i +"].OperationLocks.Length"); j++) {
					DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_OperationLock operationLock = new DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_OperationLock();
					operationLock.LockReason = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].OperationLocks["+ j +"].LockReason");

					dedicatedHost_operationLocks.Add(operationLock);
				}
				dedicatedHost.OperationLocks = dedicatedHost_operationLocks;

				List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Tag> dedicatedHost_tags = new List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Tag>();
				for (int j = 0; j < context.Length("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Tags.Length"); j++) {
					DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Tag tag = new DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Tag();
					tag.TagKey = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Tags["+ j +"].TagValue");

					dedicatedHost_tags.Add(tag);
				}
				dedicatedHost.Tags = dedicatedHost_tags;

				describeDedicatedHostsResponse_dedicatedHosts.Add(dedicatedHost);
			}
			describeDedicatedHostsResponse.DedicatedHosts = describeDedicatedHostsResponse_dedicatedHosts;
        
			return describeDedicatedHostsResponse;
        }
    }
}
