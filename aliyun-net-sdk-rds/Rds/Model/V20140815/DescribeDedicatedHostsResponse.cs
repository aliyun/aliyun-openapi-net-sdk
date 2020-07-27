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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDedicatedHostsResponse : AcsResponse
	{

		private string requestId;

		private string dedicatedHostGroupId;

		private List<DescribeDedicatedHosts_DedicatedHostsItem> dedicatedHosts;

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

			private string hostName;

			private string hostStatus;

			private string instanceNumber;

			private string cPUAllocationRatio;

			private string memAllocationRatio;

			private string diskAllocationRatio;

			private string vPCId;

			private string vSwitchId;

			private string zoneId;

			private string iPAddress;

			private string hostClass;

			private string createdTime;

			private string dedicatedHostId;

			private string allocationStatus;

			private string endTime;

			private string hostType;

			private string bastionInstanceId;

			private string openPermission;

			private string accountName;

			private string hostCPU;

			private string hostMem;

			private string hostStorage;

			private string cpuUsed;

			private string memoryUsed;

			private string storageUsed;

			private string imageCategory;

			private string dedicatedHostGroupId;

			private string engine;

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
		}
	}
}
