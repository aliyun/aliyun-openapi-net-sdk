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

namespace Aliyun.Acs.wss.Model.V20211221
{
	public class DescribePackageDeductionsResponse : AcsResponse
	{

		private int? pageNum;

		private string requestId;

		private int? pageSize;

		private long? totalCount;

		private List<DescribePackageDeductions_Deduction> deductions;

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
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

		public long? TotalCount
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

		public List<DescribePackageDeductions_Deduction> Deductions
		{
			get
			{
				return deductions;
			}
			set	
			{
				deductions = value;
			}
		}

		public class DescribePackageDeductions_Deduction
		{

			private string desktopName;

			private string desktopId;

			private string regionId;

			private string desktopType;

			private string osType;

			private string staTime;

			private string endTime;

			private string resourceType;

			private long? usedTime;

			private float? usedCoreTime;

			private string instanceState;

			private long? memory;

			private int? cpu;

			private string gpu;

			public string DesktopName
			{
				get
				{
					return desktopName;
				}
				set	
				{
					desktopName = value;
				}
			}

			public string DesktopId
			{
				get
				{
					return desktopId;
				}
				set	
				{
					desktopId = value;
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

			public string DesktopType
			{
				get
				{
					return desktopType;
				}
				set	
				{
					desktopType = value;
				}
			}

			public string OsType
			{
				get
				{
					return osType;
				}
				set	
				{
					osType = value;
				}
			}

			public string StaTime
			{
				get
				{
					return staTime;
				}
				set	
				{
					staTime = value;
				}
			}

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
				}
			}

			public long? UsedTime
			{
				get
				{
					return usedTime;
				}
				set	
				{
					usedTime = value;
				}
			}

			public float? UsedCoreTime
			{
				get
				{
					return usedCoreTime;
				}
				set	
				{
					usedCoreTime = value;
				}
			}

			public string InstanceState
			{
				get
				{
					return instanceState;
				}
				set	
				{
					instanceState = value;
				}
			}

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

			public int? Cpu
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
		}
	}
}
