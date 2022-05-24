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
	public class ListClassesResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private List<ListClasses_ClassList> items;

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

		[JsonProperty(PropertyName = "RegionId")]
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

		[JsonProperty(PropertyName = "Items")]
		public List<ListClasses_ClassList> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class ListClasses_ClassList
		{

			private string maxIOPS;

			private string cpu;

			private string referencePrice;

			private string maxConnections;

			private string memoryClass;

			private string classCode;

			private string classGroup;

			private string maxIOMBPS;

			[JsonProperty(PropertyName = "MaxIOPS")]
			public string MaxIOPS
			{
				get
				{
					return maxIOPS;
				}
				set	
				{
					maxIOPS = value;
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

			[JsonProperty(PropertyName = "ReferencePrice")]
			public string ReferencePrice
			{
				get
				{
					return referencePrice;
				}
				set	
				{
					referencePrice = value;
				}
			}

			[JsonProperty(PropertyName = "MaxConnections")]
			public string MaxConnections
			{
				get
				{
					return maxConnections;
				}
				set	
				{
					maxConnections = value;
				}
			}

			[JsonProperty(PropertyName = "MemoryClass")]
			public string MemoryClass
			{
				get
				{
					return memoryClass;
				}
				set	
				{
					memoryClass = value;
				}
			}

			[JsonProperty(PropertyName = "ClassCode")]
			public string ClassCode
			{
				get
				{
					return classCode;
				}
				set	
				{
					classCode = value;
				}
			}

			[JsonProperty(PropertyName = "ClassGroup")]
			public string ClassGroup
			{
				get
				{
					return classGroup;
				}
				set	
				{
					classGroup = value;
				}
			}

			[JsonProperty(PropertyName = "MaxIOMBPS")]
			public string MaxIOMBPS
			{
				get
				{
					return maxIOMBPS;
				}
				set	
				{
					maxIOMBPS = value;
				}
			}
		}
	}
}
