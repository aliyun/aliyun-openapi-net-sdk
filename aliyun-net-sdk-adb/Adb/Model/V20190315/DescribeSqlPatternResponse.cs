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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeSqlPatternResponse : AcsResponse
	{

		private int? pageSize;

		private int? pageNumber;

		private int? totalCount;

		private string requestId;

		private List<DescribeSqlPattern_ItemsItem> items;

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

		public List<DescribeSqlPattern_ItemsItem> Items
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

		public class DescribeSqlPattern_ItemsItem
		{

			private string avgStageCount;

			private string maxCpuTime;

			private string accessIP;

			private string avgScanSize;

			private string maxScanSize;

			private string maxPeakMemory;

			private string avgCpuTime;

			private string user;

			private string avgPeakMemory;

			private string maxStageCount;

			private string maxTaskCount;

			private string instanceName;

			private string queryCount;

			private string reportDate;

			private string pattern;

			private string avgTaskCount;

			public string AvgStageCount
			{
				get
				{
					return avgStageCount;
				}
				set	
				{
					avgStageCount = value;
				}
			}

			public string MaxCpuTime
			{
				get
				{
					return maxCpuTime;
				}
				set	
				{
					maxCpuTime = value;
				}
			}

			public string AccessIP
			{
				get
				{
					return accessIP;
				}
				set	
				{
					accessIP = value;
				}
			}

			public string AvgScanSize
			{
				get
				{
					return avgScanSize;
				}
				set	
				{
					avgScanSize = value;
				}
			}

			public string MaxScanSize
			{
				get
				{
					return maxScanSize;
				}
				set	
				{
					maxScanSize = value;
				}
			}

			public string MaxPeakMemory
			{
				get
				{
					return maxPeakMemory;
				}
				set	
				{
					maxPeakMemory = value;
				}
			}

			public string AvgCpuTime
			{
				get
				{
					return avgCpuTime;
				}
				set	
				{
					avgCpuTime = value;
				}
			}

			public string User
			{
				get
				{
					return user;
				}
				set	
				{
					user = value;
				}
			}

			public string AvgPeakMemory
			{
				get
				{
					return avgPeakMemory;
				}
				set	
				{
					avgPeakMemory = value;
				}
			}

			public string MaxStageCount
			{
				get
				{
					return maxStageCount;
				}
				set	
				{
					maxStageCount = value;
				}
			}

			public string MaxTaskCount
			{
				get
				{
					return maxTaskCount;
				}
				set	
				{
					maxTaskCount = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public string QueryCount
			{
				get
				{
					return queryCount;
				}
				set	
				{
					queryCount = value;
				}
			}

			public string ReportDate
			{
				get
				{
					return reportDate;
				}
				set	
				{
					reportDate = value;
				}
			}

			public string Pattern
			{
				get
				{
					return pattern;
				}
				set	
				{
					pattern = value;
				}
			}

			public string AvgTaskCount
			{
				get
				{
					return avgTaskCount;
				}
				set	
				{
					avgTaskCount = value;
				}
			}
		}
	}
}
