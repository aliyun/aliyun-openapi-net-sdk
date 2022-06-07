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
	public class DescribeSQLPatternsResponse : AcsResponse
	{

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private string requestId;

		private List<DescribeSQLPatterns_PatternDetailsItem> patternDetails;

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

		public List<DescribeSQLPatterns_PatternDetailsItem> PatternDetails
		{
			get
			{
				return patternDetails;
			}
			set	
			{
				patternDetails = value;
			}
		}

		public class DescribeSQLPatterns_PatternDetailsItem
		{

			private string sQLPattern;

			private string patternId;

			private string user;

			private string accessIp;

			private string tables;

			private string patternCreationTime;

			private double? averageQueryTime;

			private long? maxQueryTime;

			private double? averageExecutionTime;

			private long? maxExecutionTime;

			private double? averagePeakMemory;

			private long? maxPeakMemory;

			private double? averageScanSize;

			private long? maxScanSize;

			private long? queryCount;

			private long? failedCount;

			private bool? blockable;

			public string SQLPattern
			{
				get
				{
					return sQLPattern;
				}
				set	
				{
					sQLPattern = value;
				}
			}

			public string PatternId
			{
				get
				{
					return patternId;
				}
				set	
				{
					patternId = value;
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

			public string AccessIp
			{
				get
				{
					return accessIp;
				}
				set	
				{
					accessIp = value;
				}
			}

			public string Tables
			{
				get
				{
					return tables;
				}
				set	
				{
					tables = value;
				}
			}

			public string PatternCreationTime
			{
				get
				{
					return patternCreationTime;
				}
				set	
				{
					patternCreationTime = value;
				}
			}

			public double? AverageQueryTime
			{
				get
				{
					return averageQueryTime;
				}
				set	
				{
					averageQueryTime = value;
				}
			}

			public long? MaxQueryTime
			{
				get
				{
					return maxQueryTime;
				}
				set	
				{
					maxQueryTime = value;
				}
			}

			public double? AverageExecutionTime
			{
				get
				{
					return averageExecutionTime;
				}
				set	
				{
					averageExecutionTime = value;
				}
			}

			public long? MaxExecutionTime
			{
				get
				{
					return maxExecutionTime;
				}
				set	
				{
					maxExecutionTime = value;
				}
			}

			public double? AveragePeakMemory
			{
				get
				{
					return averagePeakMemory;
				}
				set	
				{
					averagePeakMemory = value;
				}
			}

			public long? MaxPeakMemory
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

			public double? AverageScanSize
			{
				get
				{
					return averageScanSize;
				}
				set	
				{
					averageScanSize = value;
				}
			}

			public long? MaxScanSize
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

			public long? QueryCount
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

			public long? FailedCount
			{
				get
				{
					return failedCount;
				}
				set	
				{
					failedCount = value;
				}
			}

			public bool? Blockable
			{
				get
				{
					return blockable;
				}
				set	
				{
					blockable = value;
				}
			}
		}
	}
}
