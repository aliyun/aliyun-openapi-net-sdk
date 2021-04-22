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
	public class DescribeInstanceTypesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeInstanceTypes_InstanceType> instanceTypes;

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

		public List<DescribeInstanceTypes_InstanceType> InstanceTypes
		{
			get
			{
				return instanceTypes;
			}
			set	
			{
				instanceTypes = value;
			}
		}

		public class DescribeInstanceTypes_InstanceType
		{

			private string instanceTypeId;

			private int? cpuCoreCount;

			private float? memorySize;

			private string instanceTypeFamily;

			private long? localStorageCapacity;

			private int? localStorageAmount;

			private string localStorageCategory;

			private int? gPUAmount;

			private string gPUSpec;

			private int? initialCredit;

			private int? baselineCredit;

			private int? eniQuantity;

			private int? eniPrivateIpAddressQuantity;

			private int? eniIpv6AddressQuantity;

			private int? instanceBandwidthRx;

			private int? instanceBandwidthTx;

			private long? instancePpsRx;

			private long? instancePpsTx;

			private string instanceFamilyLevel;

			private int? totalEniQueueQuantity;

			private bool? eniTrunkSupported;

			private int? eniTotalQuantity;

			private int? maximumQueueNumberPerEni;

			private int? primaryEniQueueNumber;

			private int? secondaryEniQueueNumber;

			private int? diskQuantity;

			private int? eriQuantity;

			private int? queuePairNumber;

			private string nvmeSupport;

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

			public string InstanceTypeFamily
			{
				get
				{
					return instanceTypeFamily;
				}
				set	
				{
					instanceTypeFamily = value;
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

			public int? InitialCredit
			{
				get
				{
					return initialCredit;
				}
				set	
				{
					initialCredit = value;
				}
			}

			public int? BaselineCredit
			{
				get
				{
					return baselineCredit;
				}
				set	
				{
					baselineCredit = value;
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

			public int? EniPrivateIpAddressQuantity
			{
				get
				{
					return eniPrivateIpAddressQuantity;
				}
				set	
				{
					eniPrivateIpAddressQuantity = value;
				}
			}

			public int? EniIpv6AddressQuantity
			{
				get
				{
					return eniIpv6AddressQuantity;
				}
				set	
				{
					eniIpv6AddressQuantity = value;
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

			public long? InstancePpsRx
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

			public long? InstancePpsTx
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

			public string InstanceFamilyLevel
			{
				get
				{
					return instanceFamilyLevel;
				}
				set	
				{
					instanceFamilyLevel = value;
				}
			}

			public int? TotalEniQueueQuantity
			{
				get
				{
					return totalEniQueueQuantity;
				}
				set	
				{
					totalEniQueueQuantity = value;
				}
			}

			public bool? EniTrunkSupported
			{
				get
				{
					return eniTrunkSupported;
				}
				set	
				{
					eniTrunkSupported = value;
				}
			}

			public int? EniTotalQuantity
			{
				get
				{
					return eniTotalQuantity;
				}
				set	
				{
					eniTotalQuantity = value;
				}
			}

			public int? MaximumQueueNumberPerEni
			{
				get
				{
					return maximumQueueNumberPerEni;
				}
				set	
				{
					maximumQueueNumberPerEni = value;
				}
			}

			public int? PrimaryEniQueueNumber
			{
				get
				{
					return primaryEniQueueNumber;
				}
				set	
				{
					primaryEniQueueNumber = value;
				}
			}

			public int? SecondaryEniQueueNumber
			{
				get
				{
					return secondaryEniQueueNumber;
				}
				set	
				{
					secondaryEniQueueNumber = value;
				}
			}

			public int? DiskQuantity
			{
				get
				{
					return diskQuantity;
				}
				set	
				{
					diskQuantity = value;
				}
			}

			public int? EriQuantity
			{
				get
				{
					return eriQuantity;
				}
				set	
				{
					eriQuantity = value;
				}
			}

			public int? QueuePairNumber
			{
				get
				{
					return queuePairNumber;
				}
				set	
				{
					queuePairNumber = value;
				}
			}

			public string NvmeSupport
			{
				get
				{
					return nvmeSupport;
				}
				set	
				{
					nvmeSupport = value;
				}
			}
		}
	}
}
