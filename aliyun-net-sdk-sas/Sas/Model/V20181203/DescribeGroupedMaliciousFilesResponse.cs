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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeGroupedMaliciousFilesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeGroupedMaliciousFiles_GroupedMaliciousFile> groupedMaliciousFileResponse;

		private DescribeGroupedMaliciousFiles_PageInfo pageInfo;

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

		public List<DescribeGroupedMaliciousFiles_GroupedMaliciousFile> GroupedMaliciousFileResponse
		{
			get
			{
				return groupedMaliciousFileResponse;
			}
			set	
			{
				groupedMaliciousFileResponse = value;
			}
		}

		public DescribeGroupedMaliciousFiles_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribeGroupedMaliciousFiles_GroupedMaliciousFile
		{

			private string maliciousName;

			private string maliciousMd5;

			private long? firstScanTimestamp;

			private long? latestScanTimestamp;

			private int? status;

			private string level;

			private long? imageCount;

			public string MaliciousName
			{
				get
				{
					return maliciousName;
				}
				set	
				{
					maliciousName = value;
				}
			}

			public string MaliciousMd5
			{
				get
				{
					return maliciousMd5;
				}
				set	
				{
					maliciousMd5 = value;
				}
			}

			public long? FirstScanTimestamp
			{
				get
				{
					return firstScanTimestamp;
				}
				set	
				{
					firstScanTimestamp = value;
				}
			}

			public long? LatestScanTimestamp
			{
				get
				{
					return latestScanTimestamp;
				}
				set	
				{
					latestScanTimestamp = value;
				}
			}

			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}

			public long? ImageCount
			{
				get
				{
					return imageCount;
				}
				set	
				{
					imageCount = value;
				}
			}
		}

		public class DescribeGroupedMaliciousFiles_PageInfo
		{

			private int? count;

			private int? pageSize;

			private int? totalCount;

			private int? currentPage;

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
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

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
				}
			}
		}
	}
}
