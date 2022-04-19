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
	public class DescribeImageBaselineCheckSummaryResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeImageBaselineCheckSummary_BaselineResultSummaryItem> baselineResultSummary;

		private DescribeImageBaselineCheckSummary_PageInfo pageInfo;

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

		public List<DescribeImageBaselineCheckSummary_BaselineResultSummaryItem> BaselineResultSummary
		{
			get
			{
				return baselineResultSummary;
			}
			set	
			{
				baselineResultSummary = value;
			}
		}

		public DescribeImageBaselineCheckSummary_PageInfo PageInfo
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

		public class DescribeImageBaselineCheckSummary_BaselineResultSummaryItem
		{

			private int? status;

			private int? middleRiskImage;

			private string baselineNameLevel;

			private long? lastScanTime;

			private int? highRiskImage;

			private string baselineNameKey;

			private string baselineClassKey;

			private string baselineNameAlias;

			private string baselineClassAlias;

			private long? firstScanTime;

			private int? lowRiskImage;

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

			public int? MiddleRiskImage
			{
				get
				{
					return middleRiskImage;
				}
				set	
				{
					middleRiskImage = value;
				}
			}

			public string BaselineNameLevel
			{
				get
				{
					return baselineNameLevel;
				}
				set	
				{
					baselineNameLevel = value;
				}
			}

			public long? LastScanTime
			{
				get
				{
					return lastScanTime;
				}
				set	
				{
					lastScanTime = value;
				}
			}

			public int? HighRiskImage
			{
				get
				{
					return highRiskImage;
				}
				set	
				{
					highRiskImage = value;
				}
			}

			public string BaselineNameKey
			{
				get
				{
					return baselineNameKey;
				}
				set	
				{
					baselineNameKey = value;
				}
			}

			public string BaselineClassKey
			{
				get
				{
					return baselineClassKey;
				}
				set	
				{
					baselineClassKey = value;
				}
			}

			public string BaselineNameAlias
			{
				get
				{
					return baselineNameAlias;
				}
				set	
				{
					baselineNameAlias = value;
				}
			}

			public string BaselineClassAlias
			{
				get
				{
					return baselineClassAlias;
				}
				set	
				{
					baselineClassAlias = value;
				}
			}

			public long? FirstScanTime
			{
				get
				{
					return firstScanTime;
				}
				set	
				{
					firstScanTime = value;
				}
			}

			public int? LowRiskImage
			{
				get
				{
					return lowRiskImage;
				}
				set	
				{
					lowRiskImage = value;
				}
			}
		}

		public class DescribeImageBaselineCheckSummary_PageInfo
		{

			private int? currentPage;

			private int? pageSize;

			private int? totalCount;

			private int? count;

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
		}
	}
}
