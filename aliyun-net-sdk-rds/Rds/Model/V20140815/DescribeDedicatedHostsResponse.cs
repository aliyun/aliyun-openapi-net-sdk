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
using System.Collections.Generic;
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDedicatedHostsResponse : AcsResponse
	{

		private string dedicatedHostGroupId;

		private string requestId;

		private List<DescribeDedicatedHosts_DedicatedHostsItem> dedicatedHosts;

		[JsonProperty(PropertyName = "DedicatedHostGroupId")]
		public string DedicatedHostGroupId
		{
			get
			{
				return dedicatedHostGroupId;
			}
			set	
			{
				dedicatedHostGroupId = value;
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		[JsonProperty(PropertyName = "DedicatedHosts")]
		public List<DescribeDedicatedHosts_DedicatedHostsItem> DedicatedHosts
		{
			get
			{
				return dedicatedHosts;
			}
			set	
			{
				dedicatedHosts = value;
			}
		}

		public class DescribeDedicatedHosts_DedicatedHostsItem
		{

			private string hostType;

			private string hostStorage;

			private string memoryUsed;

			private string dedicatedHostGroupId;

			private string allocationStatus;

			private string storageUsed;

			private string dedicatedHostId;

			private string memAllocationRatio;

			private string createdTime;

			private string iPAddress;

			private string hostStatus;

			private string hostName;

			private string hostCPU;

			private string instanceNumber;

			private string openPermission;

			private string cpuUsed;

			private string vPCId;

			private string hostClass;

			private string endTime;

			private string vSwitchId;

			private string cPUAllocationRatio;

			private string zoneId;

			private string imageCategory;

			private string engine;

			private string diskAllocationRatio;

			private string hostMem;

			private string bastionInstanceId;

			private string accountName;

			[JsonProperty(PropertyName = "HostType")]
			public string HostType
			{
				get
				{
					return hostType;
				}
				set	
				{
					hostType = value;
				}
			}

			[JsonProperty(PropertyName = "HostStorage")]
			public string HostStorage
			{
				get
				{
					return hostStorage;
				}
				set	
				{
					hostStorage = value;
				}
			}

			[JsonProperty(PropertyName = "MemoryUsed")]
			public string MemoryUsed
			{
				get
				{
					return memoryUsed;
				}
				set	
				{
					memoryUsed = value;
				}
			}

			[JsonProperty(PropertyName = "DedicatedHostGroupId")]
			public string DedicatedHostGroupId
			{
				get
				{
					return dedicatedHostGroupId;
				}
				set	
				{
					dedicatedHostGroupId = value;
				}
			}

			[JsonProperty(PropertyName = "AllocationStatus")]
			public string AllocationStatus
			{
				get
				{
					return allocationStatus;
				}
				set	
				{
					allocationStatus = value;
				}
			}

			[JsonProperty(PropertyName = "StorageUsed")]
			public string StorageUsed
			{
				get
				{
					return storageUsed;
				}
				set	
				{
					storageUsed = value;
				}
			}

			[JsonProperty(PropertyName = "DedicatedHostId")]
			public string DedicatedHostId
			{
				get
				{
					return dedicatedHostId;
				}
				set	
				{
					dedicatedHostId = value;
				}
			}

			[JsonProperty(PropertyName = "MemAllocationRatio")]
			public string MemAllocationRatio
			{
				get
				{
					return memAllocationRatio;
				}
				set	
				{
					memAllocationRatio = value;
				}
			}

			[JsonProperty(PropertyName = "CreatedTime")]
			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			[JsonProperty(PropertyName = "IPAddress")]
			public string IPAddress
			{
				get
				{
					return iPAddress;
				}
				set	
				{
					iPAddress = value;
				}
			}

			[JsonProperty(PropertyName = "HostStatus")]
			public string HostStatus
			{
				get
				{
					return hostStatus;
				}
				set	
				{
					hostStatus = value;
				}
			}

			[JsonProperty(PropertyName = "HostName")]
			public string HostName
			{
				get
				{
					return hostName;
				}
				set	
				{
					hostName = value;
				}
			}

			[JsonProperty(PropertyName = "HostCPU")]
			public string HostCPU
			{
				get
				{
					return hostCPU;
				}
				set	
				{
					hostCPU = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceNumber")]
			public string InstanceNumber
			{
				get
				{
					return instanceNumber;
				}
				set	
				{
					instanceNumber = value;
				}
			}

			[JsonProperty(PropertyName = "OpenPermission")]
			public string OpenPermission
			{
				get
				{
					return openPermission;
				}
				set	
				{
					openPermission = value;
				}
			}

			[JsonProperty(PropertyName = "CpuUsed")]
			public string CpuUsed
			{
				get
				{
					return cpuUsed;
				}
				set	
				{
					cpuUsed = value;
				}
			}

			[JsonProperty(PropertyName = "VPCId")]
			public string VPCId
			{
				get
				{
					return vPCId;
				}
				set	
				{
					vPCId = value;
				}
			}

			[JsonProperty(PropertyName = "HostClass")]
			public string HostClass
			{
				get
				{
					return hostClass;
				}
				set	
				{
					hostClass = value;
				}
			}

			[JsonProperty(PropertyName = "EndTime")]
			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			[JsonProperty(PropertyName = "VSwitchId")]
			public string VSwitchId
			{
				get
				{
					return vSwitchId;
				}
				set	
				{
					vSwitchId = value;
				}
			}

			[JsonProperty(PropertyName = "CPUAllocationRatio")]
			public string CPUAllocationRatio
			{
				get
				{
					return cPUAllocationRatio;
				}
				set	
				{
					cPUAllocationRatio = value;
				}
			}

			[JsonProperty(PropertyName = "ZoneId")]
			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			[JsonProperty(PropertyName = "ImageCategory")]
			public string ImageCategory
			{
				get
				{
					return imageCategory;
				}
				set	
				{
					imageCategory = value;
				}
			}

			[JsonProperty(PropertyName = "Engine")]
			public string Engine
			{
				get
				{
					return engine;
				}
				set	
				{
					engine = value;
				}
			}

			[JsonProperty(PropertyName = "DiskAllocationRatio")]
			public string DiskAllocationRatio
			{
				get
				{
					return diskAllocationRatio;
				}
				set	
				{
					diskAllocationRatio = value;
				}
			}

			[JsonProperty(PropertyName = "HostMem")]
			public string HostMem
			{
				get
				{
					return hostMem;
				}
				set	
				{
					hostMem = value;
				}
			}

			[JsonProperty(PropertyName = "BastionInstanceId")]
			public string BastionInstanceId
			{
				get
				{
					return bastionInstanceId;
				}
				set	
				{
					bastionInstanceId = value;
				}
			}

			[JsonProperty(PropertyName = "AccountName")]
			public string AccountName
			{
				get
				{
					return accountName;
				}
				set	
				{
					accountName = value;
				}
			}
		}
	}
}
