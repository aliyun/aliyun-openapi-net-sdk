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
	public class DescribeImageSupportInstanceTypesResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private string imageId;

		private List<DescribeImageSupportInstanceTypes_InstanceType> instanceTypes;

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

		public string ImageId
		{
			get
			{
				return imageId;
			}
			set	
			{
				imageId = value;
			}
		}

		public List<DescribeImageSupportInstanceTypes_InstanceType> InstanceTypes
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

		public class DescribeImageSupportInstanceTypes_InstanceType
		{

			private string instanceTypeId;

			private int? cpuCoreCount;

			private float? memorySize;

			private string instanceTypeFamily;

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
		}
	}
}
