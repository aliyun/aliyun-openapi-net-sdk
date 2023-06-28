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

namespace Aliyun.Acs.appstream_center.Model.V20210901
{
	public class ListNodeInstanceTypeResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private List<ListNodeInstanceType_Node> nodeInstanceTypeModels;

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

		[JsonProperty(PropertyName = "TotalCount")]
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

		[JsonProperty(PropertyName = "PageSize")]
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

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "NodeInstanceTypeModels")]
		public List<ListNodeInstanceType_Node> NodeInstanceTypeModels
		{
			get
			{
				return nodeInstanceTypeModels;
			}
			set	
			{
				nodeInstanceTypeModels = value;
			}
		}

		public class ListNodeInstanceType_Node
		{

			private string nodeInstanceType;

			private string nodeInstanceTypeFamily;

			private string cpu;

			private string gpu;

			private long? memory;

			private long? systemDiskSize;

			private long? dataDiskSize;

			private long? gpuMemory;

			private int? maxCapacity;

			private string nodeTypeName;

			[JsonProperty(PropertyName = "NodeInstanceType")]
			public string NodeInstanceType
			{
				get
				{
					return nodeInstanceType;
				}
				set	
				{
					nodeInstanceType = value;
				}
			}

			[JsonProperty(PropertyName = "NodeInstanceTypeFamily")]
			public string NodeInstanceTypeFamily
			{
				get
				{
					return nodeInstanceTypeFamily;
				}
				set	
				{
					nodeInstanceTypeFamily = value;
				}
			}

			[JsonProperty(PropertyName = "Cpu")]
			public string Cpu
			{
				get
				{
					return cpu;
				}
				set	
				{
					cpu = value;
				}
			}

			[JsonProperty(PropertyName = "Gpu")]
			public string Gpu
			{
				get
				{
					return gpu;
				}
				set	
				{
					gpu = value;
				}
			}

			[JsonProperty(PropertyName = "Memory")]
			public long? Memory
			{
				get
				{
					return memory;
				}
				set	
				{
					memory = value;
				}
			}

			[JsonProperty(PropertyName = "SystemDiskSize")]
			public long? SystemDiskSize
			{
				get
				{
					return systemDiskSize;
				}
				set	
				{
					systemDiskSize = value;
				}
			}

			[JsonProperty(PropertyName = "DataDiskSize")]
			public long? DataDiskSize
			{
				get
				{
					return dataDiskSize;
				}
				set	
				{
					dataDiskSize = value;
				}
			}

			[JsonProperty(PropertyName = "GpuMemory")]
			public long? GpuMemory
			{
				get
				{
					return gpuMemory;
				}
				set	
				{
					gpuMemory = value;
				}
			}

			[JsonProperty(PropertyName = "MaxCapacity")]
			public int? MaxCapacity
			{
				get
				{
					return maxCapacity;
				}
				set	
				{
					maxCapacity = value;
				}
			}

			[JsonProperty(PropertyName = "NodeTypeName")]
			public string NodeTypeName
			{
				get
				{
					return nodeTypeName;
				}
				set	
				{
					nodeTypeName = value;
				}
			}
		}
	}
}
