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
using Aliyun.Acs.Core;
using System.Collections.Generic;

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
		}
	}
}