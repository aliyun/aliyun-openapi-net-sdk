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
	public class DescribeDedicatedHostAttributeResponse : AcsResponse
	{

		private string requestId;

		private string dedicatedHostGroupId;

		private string dedicatedHostId;

		private string regionId;

		private string zoneId;

		private string vPCId;

		private string vSwitchId;

		private string iPAddress;

		private string hostName;

		private string hostStatus;

		private string hostClass;

		private int? hostCPU;

		private int? hostMem;

		private int? hostStorage;

		private string cPUAllocationRatio;

		private string memAllocationRatio;

		private string diskAllocationRatio;

		private int? instanceNumber;

		private int? instanceNumberMaster;

		private int? instanceNumberSlave;

		private int? instanceNumberROMaster;

		private int? instanceNumberROSlave;

		private string createdTime;

		private string expiredTime;

		private string autoRenew;

		private string allocationStatus;

		private string cpuUsed;

		private string memoryUsed;

		private string storageUsed;

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

		public int? HostCPU
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

		public int? HostMem
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

		public int? HostStorage
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

		public int? InstanceNumber
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

		public int? InstanceNumberMaster
		{
			get
			{
				return instanceNumberMaster;
			}
			set	
			{
				instanceNumberMaster = value;
			}
		}

		public int? InstanceNumberSlave
		{
			get
			{
				return instanceNumberSlave;
			}
			set	
			{
				instanceNumberSlave = value;
			}
		}

		public int? InstanceNumberROMaster
		{
			get
			{
				return instanceNumberROMaster;
			}
			set	
			{
				instanceNumberROMaster = value;
			}
		}

		public int? InstanceNumberROSlave
		{
			get
			{
				return instanceNumberROSlave;
			}
			set	
			{
				instanceNumberROSlave = value;
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

		public string AutoRenew
		{
			get
			{
				return autoRenew;
			}
			set	
			{
				autoRenew = value;
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
	}
}
