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
	public class DescribeDedicatedHostGroupsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDedicatedHostGroups_DedicatedHostGroupsItem> dedicatedHostGroups;

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

		[JsonProperty(PropertyName = "DedicatedHostGroups")]
		public List<DescribeDedicatedHostGroups_DedicatedHostGroupsItem> DedicatedHostGroups
		{
			get
			{
				return dedicatedHostGroups;
			}
			set	
			{
				dedicatedHostGroups = value;
			}
		}

		public class DescribeDedicatedHostGroups_DedicatedHostGroupsItem
		{

			private float? diskAllocateRation;

			private string createTime;

			private string dedicatedHostCountGroupByHostType;

			private string text;

			private string dedicatedHostGroupId;

			private float? diskUtility;

			private float? memUsedAmount;

			private float? memAllocatedAmount;

			private int? cpuAllocationRatio;

			private int? memAllocationRatio;

			private float? memUtility;

			private float? memAllocateRation;

			private float? cpuAllocatedAmount;

			private string dedicatedHostGroupDesc;

			private float? cpuAllocateRation;

			private int? instanceNumber;

			private string openPermission;

			private string vPCId;

			private float? diskAllocatedAmount;

			private int? hostNumber;

			private float? diskUsedAmount;

			private string allocationPolicy;

			private string engine;

			private int? diskAllocationRatio;

			private string bastionInstanceId;

			private string hostReplacePolicy;

			private List<string> zoneIDList;

			[JsonProperty(PropertyName = "DiskAllocateRation")]
			public float? DiskAllocateRation
			{
				get
				{
					return diskAllocateRation;
				}
				set	
				{
					diskAllocateRation = value;
				}
			}

			[JsonProperty(PropertyName = "CreateTime")]
			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			[JsonProperty(PropertyName = "DedicatedHostCountGroupByHostType")]
			public string DedicatedHostCountGroupByHostType
			{
				get
				{
					return dedicatedHostCountGroupByHostType;
				}
				set	
				{
					dedicatedHostCountGroupByHostType = value;
				}
			}

			[JsonProperty(PropertyName = "Text")]
			public string Text
			{
				get
				{
					return text;
				}
				set	
				{
					text = value;
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

			[JsonProperty(PropertyName = "DiskUtility")]
			public float? DiskUtility
			{
				get
				{
					return diskUtility;
				}
				set	
				{
					diskUtility = value;
				}
			}

			[JsonProperty(PropertyName = "MemUsedAmount")]
			public float? MemUsedAmount
			{
				get
				{
					return memUsedAmount;
				}
				set	
				{
					memUsedAmount = value;
				}
			}

			[JsonProperty(PropertyName = "MemAllocatedAmount")]
			public float? MemAllocatedAmount
			{
				get
				{
					return memAllocatedAmount;
				}
				set	
				{
					memAllocatedAmount = value;
				}
			}

			[JsonProperty(PropertyName = "CpuAllocationRatio")]
			public int? CpuAllocationRatio
			{
				get
				{
					return cpuAllocationRatio;
				}
				set	
				{
					cpuAllocationRatio = value;
				}
			}

			[JsonProperty(PropertyName = "MemAllocationRatio")]
			public int? MemAllocationRatio
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

			[JsonProperty(PropertyName = "MemUtility")]
			public float? MemUtility
			{
				get
				{
					return memUtility;
				}
				set	
				{
					memUtility = value;
				}
			}

			[JsonProperty(PropertyName = "MemAllocateRation")]
			public float? MemAllocateRation
			{
				get
				{
					return memAllocateRation;
				}
				set	
				{
					memAllocateRation = value;
				}
			}

			[JsonProperty(PropertyName = "CpuAllocatedAmount")]
			public float? CpuAllocatedAmount
			{
				get
				{
					return cpuAllocatedAmount;
				}
				set	
				{
					cpuAllocatedAmount = value;
				}
			}

			[JsonProperty(PropertyName = "DedicatedHostGroupDesc")]
			public string DedicatedHostGroupDesc
			{
				get
				{
					return dedicatedHostGroupDesc;
				}
				set	
				{
					dedicatedHostGroupDesc = value;
				}
			}

			[JsonProperty(PropertyName = "CpuAllocateRation")]
			public float? CpuAllocateRation
			{
				get
				{
					return cpuAllocateRation;
				}
				set	
				{
					cpuAllocateRation = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceNumber")]
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

			[JsonProperty(PropertyName = "DiskAllocatedAmount")]
			public float? DiskAllocatedAmount
			{
				get
				{
					return diskAllocatedAmount;
				}
				set	
				{
					diskAllocatedAmount = value;
				}
			}

			[JsonProperty(PropertyName = "HostNumber")]
			public int? HostNumber
			{
				get
				{
					return hostNumber;
				}
				set	
				{
					hostNumber = value;
				}
			}

			[JsonProperty(PropertyName = "DiskUsedAmount")]
			public float? DiskUsedAmount
			{
				get
				{
					return diskUsedAmount;
				}
				set	
				{
					diskUsedAmount = value;
				}
			}

			[JsonProperty(PropertyName = "AllocationPolicy")]
			public string AllocationPolicy
			{
				get
				{
					return allocationPolicy;
				}
				set	
				{
					allocationPolicy = value;
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
			public int? DiskAllocationRatio
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

			[JsonProperty(PropertyName = "HostReplacePolicy")]
			public string HostReplacePolicy
			{
				get
				{
					return hostReplacePolicy;
				}
				set	
				{
					hostReplacePolicy = value;
				}
			}

			[JsonProperty(PropertyName = "ZoneIDList")]
			public List<string> ZoneIDList
			{
				get
				{
					return zoneIDList;
				}
				set	
				{
					zoneIDList = value;
				}
			}
		}
	}
}
