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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeDedicatedHostsResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeDedicatedHosts_DedicatedHost> dedicatedHosts;

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

			private string creationTime;

			private string status;

			private int? cores;

			private string autoPlacement;

			private string gPUSpec;

			private string autoReleaseTime;

			private string chargeType;

			private float? cpuOverCommitRatio;

			private string actionOnMaintenance;

			private string saleCycle;

			private int? physicalGpus;

			private string regionId;

			private string dedicatedHostName;

			private string description;

			private string dedicatedHostClusterId;

			private string expiredTime;

			private string dedicatedHostType;

			private string resourceGroupId;

			private string zoneId;

			private string dedicatedHostId;

			private int? sockets;

			private string machineId;

			private List<DescribeDedicatedHosts_Instance> instances;

			private List<DescribeDedicatedHosts_OperationLock> operationLocks;

			private List<DescribeDedicatedHosts_Tag> tags;

			private List<string> supportedInstanceTypeFamilies;

			private List<string> supportedCustomInstanceTypeFamilies;

			private List<string> supportedInstanceTypesList;

			private DescribeDedicatedHosts_Capacity capacity;

			private DescribeDedicatedHosts_NetworkAttributes networkAttributes;

			private DescribeDedicatedHosts_HostDetailInfo hostDetailInfo;

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

				private string instanceType;

				private string instanceId;

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

				private string tagValue;

				private string tagKey;

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
			}

			public class DescribeDedicatedHosts_Capacity
			{

				private float? availableMemory;

				private string localStorageCategory;

				private float? totalMemory;

				private int? totalLocalStorage;

				private int? totalVcpus;

				private int? totalVgpus;

				private int? availableLocalStorage;

				private int? availableVcpus;

				private int? availableVgpus;

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
			}

			public class DescribeDedicatedHosts_NetworkAttributes
			{

				private int? udpTimeout;

				private int? slbUdpTimeout;

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
