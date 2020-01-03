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

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class ListAvailableEcsTypesResponse : AcsResponse
	{

		private string requestId;

		private bool? supportSpotInstance;

		private List<ListAvailableEcsTypes_InstanceTypeFamilyInfo> instanceTypeFamilies;

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

		public bool? SupportSpotInstance
		{
			get
			{
				return supportSpotInstance;
			}
			set	
			{
				supportSpotInstance = value;
			}
		}

		public List<ListAvailableEcsTypes_InstanceTypeFamilyInfo> InstanceTypeFamilies
		{
			get
			{
				return instanceTypeFamilies;
			}
			set	
			{
				instanceTypeFamilies = value;
			}
		}

		public class ListAvailableEcsTypes_InstanceTypeFamilyInfo
		{

			private string instanceTypeFamilyId;

			private string generation;

			private List<ListAvailableEcsTypes_TypesInfo> types;

			public string InstanceTypeFamilyId
			{
				get
				{
					return instanceTypeFamilyId;
				}
				set	
				{
					instanceTypeFamilyId = value;
				}
			}

			public string Generation
			{
				get
				{
					return generation;
				}
				set	
				{
					generation = value;
				}
			}

			public List<ListAvailableEcsTypes_TypesInfo> Types
			{
				get
				{
					return types;
				}
				set	
				{
					types = value;
				}
			}

			public class ListAvailableEcsTypes_TypesInfo
			{

				private int? cpuCoreCount;

				private int? memorySize;

				private int? gPUAmount;

				private int? instanceBandwidthRx;

				private int? instancePpsRx;

				private int? instancePpsTx;

				private int? eniQuantity;

				private int? instanceBandwidthTx;

				private string instanceTypeId;

				private string gPUSpec;

				private string status;

				public int? CpuCoreCount
				{
					get
					{
						return cpuCoreCount;
					}
					set	
					{
						cpuCoreCount = value;
					}
				}

				public int? MemorySize
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

				public int? GPUAmount
				{
					get
					{
						return gPUAmount;
					}
					set	
					{
						gPUAmount = value;
					}
				}

				public int? InstanceBandwidthRx
				{
					get
					{
						return instanceBandwidthRx;
					}
					set	
					{
						instanceBandwidthRx = value;
					}
				}

				public int? InstancePpsRx
				{
					get
					{
						return instancePpsRx;
					}
					set	
					{
						instancePpsRx = value;
					}
				}

				public int? InstancePpsTx
				{
					get
					{
						return instancePpsTx;
					}
					set	
					{
						instancePpsTx = value;
					}
				}

				public int? EniQuantity
				{
					get
					{
						return eniQuantity;
					}
					set	
					{
						eniQuantity = value;
					}
				}

				public int? InstanceBandwidthTx
				{
					get
					{
						return instanceBandwidthTx;
					}
					set	
					{
						instanceBandwidthTx = value;
					}
				}

				public string InstanceTypeId
				{
					get
					{
						return instanceTypeId;
					}
					set	
					{
						instanceTypeId = value;
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
			}
		}
	}
}
