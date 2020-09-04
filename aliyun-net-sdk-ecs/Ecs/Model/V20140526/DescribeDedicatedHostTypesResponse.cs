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
	public class DescribeDedicatedHostTypesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDedicatedHostTypes_DedicatedHostType> dedicatedHostTypes;

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

		public List<DescribeDedicatedHostTypes_DedicatedHostType> DedicatedHostTypes
		{
			get
			{
				return dedicatedHostTypes;
			}
			set	
			{
				dedicatedHostTypes = value;
			}
		}

		public class DescribeDedicatedHostTypes_DedicatedHostType
		{

			private string dedicatedHostType;

			private int? sockets;

			private int? totalVcpus;

			private int? totalVgpus;

			private int? cores;

			private int? physicalGpus;

			private float? memorySize;

			private long? localStorageCapacity;

			private int? localStorageAmount;

			private string localStorageCategory;

			private string gPUSpec;

			private bool? supportCpuOverCommitRatio;

			private string cpuOverCommitRatioRange;

			private List<string> supportedInstanceTypeFamilies;

			private List<string> supportedInstanceTypesList;

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

			public float? MemorySize
			{
				get
				{
					return memorySize;
				}
				set	
				{
					memorySize = value;
				}
			}

			public long? LocalStorageCapacity
			{
				get
				{
					return localStorageCapacity;
				}
				set	
				{
					localStorageCapacity = value;
				}
			}

			public int? LocalStorageAmount
			{
				get
				{
					return localStorageAmount;
				}
				set	
				{
					localStorageAmount = value;
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

			public bool? SupportCpuOverCommitRatio
			{
				get
				{
					return supportCpuOverCommitRatio;
				}
				set	
				{
					supportCpuOverCommitRatio = value;
				}
			}

			public string CpuOverCommitRatioRange
			{
				get
				{
					return cpuOverCommitRatioRange;
				}
				set	
				{
					cpuOverCommitRatioRange = value;
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
		}
	}
}
