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
	public class ListClassesResponse : AcsResponse
	{

		private string regionId;

		private string requestId;

		private List<ListClasses_ClassList> items;

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

			private string classCode;

			private string classGroup;

			private string cpu;

			private string maxConnections;

			private string maxIOMBPS;

			private string maxIOPS;

			private string memoryClass;

			private string referencePrice;

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
		}
	}
}
