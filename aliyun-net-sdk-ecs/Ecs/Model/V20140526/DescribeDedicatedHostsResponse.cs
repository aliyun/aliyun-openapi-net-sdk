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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeDedicatedHostsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeDedicatedHosts_DedicatedHost> dedicatedHosts;

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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribeDedicatedHosts_DedicatedHost> DedicatedHosts
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

		public class DescribeDedicatedHosts_DedicatedHost
		{

			private string dedicatedHostId;

			private string autoPlacement;

			private string regionId;

			private string zoneId;

			private string dedicatedHostName;

			private string machineId;

			private string description;

			private string dedicatedHostType;

			private int? sockets;

			private int? cores;

			private int? physicalGpus;

			private string gPUSpec;

			private string actionOnMaintenance;

			private string status;

			private string creationTime;

			private string chargeType;

			private string saleCycle;

			private string expiredTime;

			private string autoReleaseTime;

			private string resourceGroupId;

			private string dedicatedHostClusterId;

			private float? cpuOverCommitRatio;

			private List<DescribeDedicatedHosts_Instance> instances;

			private List<DescribeDedicatedHosts_OperationLock> operationLocks;

			private List<DescribeDedicatedHosts_Tag> tags;

			private List<string> supportedInstanceTypeFamilies;

			private List<string> supportedCustomInstanceTypeFamilies;

			private List<string> supportedInstanceTypesList;

			private DescribeDedicatedHosts_Capacity capacity;

			private DescribeDedicatedHosts_NetworkAttributes networkAttributes;

			private DescribeDedicatedHosts_HostDetailInfo hostDetailInfo;

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

			public string AutoPlacement
			{
				get
				{
					return autoPlacement;
				}
				set	
				{
					autoPlacement = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
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

			public string DedicatedHostName
			{
				get
				{
					return dedicatedHostName;
				}
				set	
				{
					dedicatedHostName = value;
				}
			}

			public string MachineId
			{
				get
				{
					return machineId;
				}
				set	
				{
					machineId = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string DedicatedHostType
			{
				get
				{
					return dedicatedHostType;
				}
				set	
				{
					dedicatedHostType = value;
				}
			}

			public int? Sockets
			{
				get
				{
					return sockets;
				}
				set	
				{
					sockets = value;
				}
			}

			public int? Cores
			{
				get
				{
					return cores;
				}
				set	
				{
					cores = value;
				}
			}

			public int? PhysicalGpus
			{
				get
				{
					return physicalGpus;
				}
				set	
				{
					physicalGpus = value;
				}
			}

			public string GPUSpec
			{
				get
				{
					return gPUSpec;
				}
				set	
				{
					gPUSpec = value;
				}
			}

			public string ActionOnMaintenance
			{
				get
				{
					return actionOnMaintenance;
				}
				set	
				{
					actionOnMaintenance = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
				}
			}

			public string SaleCycle
			{
				get
				{
					return saleCycle;
				}
				set	
				{
					saleCycle = value;
				}
			}

			public string ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
				}
			}

			public string AutoReleaseTime
			{
				get
				{
					return autoReleaseTime;
				}
				set	
				{
					autoReleaseTime = value;
				}
			}

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
				}
			}

			public string DedicatedHostClusterId
			{
				get
				{
					return dedicatedHostClusterId;
				}
				set	
				{
					dedicatedHostClusterId = value;
				}
			}

			public float? CpuOverCommitRatio
			{
				get
				{
					return cpuOverCommitRatio;
				}
				set	
				{
					cpuOverCommitRatio = value;
				}
			}

			public List<DescribeDedicatedHosts_Instance> Instances
			{
				get
				{
					return instances;
				}
				set	
				{
					instances = value;
				}
			}

			public List<DescribeDedicatedHosts_OperationLock> OperationLocks
			{
				get
				{
					return operationLocks;
				}
				set	
				{
					operationLocks = value;
				}
			}

			public List<DescribeDedicatedHosts_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public List<string> SupportedInstanceTypeFamilies
			{
				get
				{
					return supportedInstanceTypeFamilies;
				}
				set	
				{
					supportedInstanceTypeFamilies = value;
				}
			}

			public List<string> SupportedCustomInstanceTypeFamilies
			{
				get
				{
					return supportedCustomInstanceTypeFamilies;
				}
				set	
				{
					supportedCustomInstanceTypeFamilies = value;
				}
			}

			public List<string> SupportedInstanceTypesList
			{
				get
				{
					return supportedInstanceTypesList;
				}
				set	
				{
					supportedInstanceTypesList = value;
				}
			}

			public DescribeDedicatedHosts_Capacity Capacity
			{
				get
				{
					return capacity;
				}
				set	
				{
					capacity = value;
				}
			}

			public DescribeDedicatedHosts_NetworkAttributes NetworkAttributes
			{
				get
				{
					return networkAttributes;
				}
				set	
				{
					networkAttributes = value;
				}
			}

			public DescribeDedicatedHosts_HostDetailInfo HostDetailInfo
			{
				get
				{
					return hostDetailInfo;
				}
				set	
				{
					hostDetailInfo = value;
				}
			}

			public class DescribeDedicatedHosts_Instance
			{

				private string instanceId;

				private string instanceType;

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public string InstanceType
				{
					get
					{
						return instanceType;
					}
					set	
					{
						instanceType = value;
					}
				}
			}

			public class DescribeDedicatedHosts_OperationLock
			{

				private string lockReason;

				public string LockReason
				{
					get
					{
						return lockReason;
					}
					set	
					{
						lockReason = value;
					}
				}
			}

			public class DescribeDedicatedHosts_Tag
			{

				private string tagKey;

				private string tagValue;

				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}
			}

			public class DescribeDedicatedHosts_Capacity
			{

				private int? totalVcpus;

				private int? availableVcpus;

				private int? totalVgpus;

				private int? availableVgpus;

				private float? totalMemory;

				private float? availableMemory;

				private int? totalLocalStorage;

				private int? availableLocalStorage;

				private string localStorageCategory;

				public int? TotalVcpus
				{
					get
					{
						return totalVcpus;
					}
					set	
					{
						totalVcpus = value;
					}
				}

				public int? AvailableVcpus
				{
					get
					{
						return availableVcpus;
					}
					set	
					{
						availableVcpus = value;
					}
				}

				public int? TotalVgpus
				{
					get
					{
						return totalVgpus;
					}
					set	
					{
						totalVgpus = value;
					}
				}

				public int? AvailableVgpus
				{
					get
					{
						return availableVgpus;
					}
					set	
					{
						availableVgpus = value;
					}
				}

				public float? TotalMemory
				{
					get
					{
						return totalMemory;
					}
					set	
					{
						totalMemory = value;
					}
				}

				public float? AvailableMemory
				{
					get
					{
						return availableMemory;
					}
					set	
					{
						availableMemory = value;
					}
				}

				public int? TotalLocalStorage
				{
					get
					{
						return totalLocalStorage;
					}
					set	
					{
						totalLocalStorage = value;
					}
				}

				public int? AvailableLocalStorage
				{
					get
					{
						return availableLocalStorage;
					}
					set	
					{
						availableLocalStorage = value;
					}
				}

				public string LocalStorageCategory
				{
					get
					{
						return localStorageCategory;
					}
					set	
					{
						localStorageCategory = value;
					}
				}
			}

			public class DescribeDedicatedHosts_NetworkAttributes
			{

				private int? slbUdpTimeout;

				private int? udpTimeout;

				public int? SlbUdpTimeout
				{
					get
					{
						return slbUdpTimeout;
					}
					set	
					{
						slbUdpTimeout = value;
					}
				}

				public int? UdpTimeout
				{
					get
					{
						return udpTimeout;
					}
					set	
					{
						udpTimeout = value;
					}
				}
			}

			public class DescribeDedicatedHosts_HostDetailInfo
			{

				private string serialNumber;

				public string SerialNumber
				{
					get
					{
						return serialNumber;
					}
					set	
					{
						serialNumber = value;
					}
				}
			}
		}
	}
}
