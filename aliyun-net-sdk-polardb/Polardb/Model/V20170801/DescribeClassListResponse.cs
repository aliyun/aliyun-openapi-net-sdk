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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeClassListResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private List<DescribeClassList_ItemsItem> items;

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

		public List<DescribeClassList_ItemsItem> Items
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

		public class DescribeClassList_ItemsItem
		{

			private string psl4MaxIOPS;

			private string classTypeLevel;

			private string cpu;

			private string referencePrice;

			private string referenceExtPrice;

			private string maxConnections;

			private string memoryClass;

			private string classCode;

			private string classGroup;

			private string psl5MaxIOPS;

			private string maxIOPS;

			private string maxStorageCapacity;

			private string pl1MaxIOPS;

			private string pl2MaxIOPS;

			private string pl3MaxIOPS;

			private string essdMaxStorageCapacity;

			private string polarStoreMaxStorageCapacity;

			public string Psl4MaxIOPS
			{
				get
				{
					return psl4MaxIOPS;
				}
				set	
				{
					psl4MaxIOPS = value;
				}
			}

			public string ClassTypeLevel
			{
				get
				{
					return classTypeLevel;
				}
				set	
				{
					classTypeLevel = value;
				}
			}

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

			public string ReferenceExtPrice
			{
				get
				{
					return referenceExtPrice;
				}
				set	
				{
					referenceExtPrice = value;
				}
			}

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

			public string Psl5MaxIOPS
			{
				get
				{
					return psl5MaxIOPS;
				}
				set	
				{
					psl5MaxIOPS = value;
				}
			}

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

			public string MaxStorageCapacity
			{
				get
				{
					return maxStorageCapacity;
				}
				set	
				{
					maxStorageCapacity = value;
				}
			}

			public string Pl1MaxIOPS
			{
				get
				{
					return pl1MaxIOPS;
				}
				set	
				{
					pl1MaxIOPS = value;
				}
			}

			public string Pl2MaxIOPS
			{
				get
				{
					return pl2MaxIOPS;
				}
				set	
				{
					pl2MaxIOPS = value;
				}
			}

			public string Pl3MaxIOPS
			{
				get
				{
					return pl3MaxIOPS;
				}
				set	
				{
					pl3MaxIOPS = value;
				}
			}

			public string EssdMaxStorageCapacity
			{
				get
				{
					return essdMaxStorageCapacity;
				}
				set	
				{
					essdMaxStorageCapacity = value;
				}
			}

			public string PolarStoreMaxStorageCapacity
			{
				get
				{
					return polarStoreMaxStorageCapacity;
				}
				set	
				{
					polarStoreMaxStorageCapacity = value;
				}
			}
		}
	}
}
