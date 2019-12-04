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
	public class DescribeDedicatedHostGroupsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDedicatedHostGroups_DedicatedHostGroupsItem> dedicatedHostGroups;

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

			private string dedicatedHostGroupId;

			private string dedicatedHostGroupDesc;

			private int? cpuAllocationRatio;

			private int? memAllocationRatio;

			private int? diskAllocationRatio;

			private string allocationPolicy;

			private string hostReplacePolicy;

			private string createTime;

			private string vPCId;

			private int? hostNumber;

			private int? instanceNumber;

			private string engine;

			private string text;

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
		}
	}
}
