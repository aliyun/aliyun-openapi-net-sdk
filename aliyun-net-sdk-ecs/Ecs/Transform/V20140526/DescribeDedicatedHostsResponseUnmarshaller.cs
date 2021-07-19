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
        public static DescribeDedicatedHostsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDedicatedHostsResponse describeDedicatedHostsResponse = new DescribeDedicatedHostsResponse();

			describeDedicatedHostsResponse.HttpResponse = _ctx.HttpResponse;
			describeDedicatedHostsResponse.PageSize = _ctx.IntegerValue("DescribeDedicatedHosts.PageSize");
			describeDedicatedHostsResponse.RequestId = _ctx.StringValue("DescribeDedicatedHosts.RequestId");
			describeDedicatedHostsResponse.PageNumber = _ctx.IntegerValue("DescribeDedicatedHosts.PageNumber");
			describeDedicatedHostsResponse.TotalCount = _ctx.IntegerValue("DescribeDedicatedHosts.TotalCount");

			List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost> describeDedicatedHostsResponse_dedicatedHosts = new List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost>();
			for (int i = 0; i < _ctx.Length("DescribeDedicatedHosts.DedicatedHosts.Length"); i++) {
				DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost dedicatedHost = new DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost();
				dedicatedHost.CreationTime = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].CreationTime");
				dedicatedHost.Status = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Status");
				dedicatedHost.Cores = _ctx.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Cores");
				dedicatedHost.AutoPlacement = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].AutoPlacement");
				dedicatedHost.GPUSpec = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].GPUSpec");
				dedicatedHost.AutoReleaseTime = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].AutoReleaseTime");
				dedicatedHost.ChargeType = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].ChargeType");
				dedicatedHost.CpuOverCommitRatio = _ctx.FloatValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].CpuOverCommitRatio");
				dedicatedHost.ActionOnMaintenance = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].ActionOnMaintenance");
				dedicatedHost.SaleCycle = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].SaleCycle");
				dedicatedHost.PhysicalGpus = _ctx.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].PhysicalGpus");
				dedicatedHost.RegionId = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].RegionId");
				dedicatedHost.DedicatedHostName = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].DedicatedHostName");
				dedicatedHost.Description = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Description");
				dedicatedHost.DedicatedHostClusterId = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].DedicatedHostClusterId");
				dedicatedHost.ExpiredTime = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].ExpiredTime");
				dedicatedHost.DedicatedHostType = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].DedicatedHostType");
				dedicatedHost.ResourceGroupId = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].ResourceGroupId");
				dedicatedHost.ZoneId = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].ZoneId");
				dedicatedHost.DedicatedHostId = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].DedicatedHostId");
				dedicatedHost.Sockets = _ctx.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Sockets");
				dedicatedHost.MachineId = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].MachineId");

				List<string> dedicatedHost_supportedInstanceTypeFamilies = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDedicatedHosts.DedicatedHosts["+ i +"].SupportedInstanceTypeFamilies.Length"); j++) {
					dedicatedHost_supportedInstanceTypeFamilies.Add(_ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].SupportedInstanceTypeFamilies["+ j +"]"));
				}
				dedicatedHost.SupportedInstanceTypeFamilies = dedicatedHost_supportedInstanceTypeFamilies;

				List<string> dedicatedHost_supportedCustomInstanceTypeFamilies = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDedicatedHosts.DedicatedHosts["+ i +"].SupportedCustomInstanceTypeFamilies.Length"); j++) {
					dedicatedHost_supportedCustomInstanceTypeFamilies.Add(_ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].SupportedCustomInstanceTypeFamilies["+ j +"]"));
				}
				dedicatedHost.SupportedCustomInstanceTypeFamilies = dedicatedHost_supportedCustomInstanceTypeFamilies;

				List<string> dedicatedHost_supportedInstanceTypesList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDedicatedHosts.DedicatedHosts["+ i +"].SupportedInstanceTypesList.Length"); j++) {
					dedicatedHost_supportedInstanceTypesList.Add(_ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].SupportedInstanceTypesList["+ j +"]"));
				}
				dedicatedHost.SupportedInstanceTypesList = dedicatedHost_supportedInstanceTypesList;

				DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Capacity capacity = new DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Capacity();
				capacity.AvailableMemory = _ctx.FloatValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.AvailableMemory");
				capacity.LocalStorageCategory = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.LocalStorageCategory");
				capacity.TotalMemory = _ctx.FloatValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.TotalMemory");
				capacity.TotalLocalStorage = _ctx.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.TotalLocalStorage");
				capacity.TotalVcpus = _ctx.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.TotalVcpus");
				capacity.TotalVgpus = _ctx.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.TotalVgpus");
				capacity.AvailableLocalStorage = _ctx.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.AvailableLocalStorage");
				capacity.AvailableVcpus = _ctx.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.AvailableVcpus");
				capacity.AvailableVgpus = _ctx.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.AvailableVgpus");
				dedicatedHost.Capacity = capacity;

				DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_NetworkAttributes networkAttributes = new DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_NetworkAttributes();
				networkAttributes.UdpTimeout = _ctx.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].NetworkAttributes.UdpTimeout");
				networkAttributes.SlbUdpTimeout = _ctx.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].NetworkAttributes.SlbUdpTimeout");
				dedicatedHost.NetworkAttributes = networkAttributes;

				DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_HostDetailInfo hostDetailInfo = new DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_HostDetailInfo();
				hostDetailInfo.SerialNumber = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].HostDetailInfo.SerialNumber");
				dedicatedHost.HostDetailInfo = hostDetailInfo;

				List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Instance> dedicatedHost_instances = new List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Instance>();
				for (int j = 0; j < _ctx.Length("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Instances.Length"); j++) {
					DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Instance instance = new DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Instance();
					instance.InstanceType = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Instances["+ j +"].InstanceType");
					instance.InstanceId = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Instances["+ j +"].InstanceId");

					dedicatedHost_instances.Add(instance);
				}
				dedicatedHost.Instances = dedicatedHost_instances;

				List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_OperationLock> dedicatedHost_operationLocks = new List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_OperationLock>();
				for (int j = 0; j < _ctx.Length("DescribeDedicatedHosts.DedicatedHosts["+ i +"].OperationLocks.Length"); j++) {
					DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_OperationLock operationLock = new DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_OperationLock();
					operationLock.LockReason = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].OperationLocks["+ j +"].LockReason");

					dedicatedHost_operationLocks.Add(operationLock);
				}
				dedicatedHost.OperationLocks = dedicatedHost_operationLocks;

				List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Tag> dedicatedHost_tags = new List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Tags.Length"); j++) {
					DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Tag tag = new DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Tag();
					tag.TagValue = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Tags["+ j +"].TagValue");
					tag.TagKey = _ctx.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Tags["+ j +"].TagKey");

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
