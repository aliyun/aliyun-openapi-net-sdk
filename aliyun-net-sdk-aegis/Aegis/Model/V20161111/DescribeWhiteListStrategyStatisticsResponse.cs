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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeWhiteListStrategyStatisticsResponse : AcsResponse
	{

		private string requestId;

		private int? count;

		private int? pageSize;

		private int? totalCount;

		private int? currentPage;

		private List<DescribeWhiteListStrategyStatistics_Strategy> strategies;

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

		public List<DescribeWhiteListStrategyStatistics_Strategy> Strategies
		{
			get
			{
				return strategies;
			}
			set	
			{
				strategies = value;
			}
		}

		public class DescribeWhiteListStrategyStatistics_Strategy
		{

			private long? strategyId;

			private string strategyName;

			private int? studyTime;

			private int? assetCount;

			private int? status;

			private int? trustProcCount;

			private int? suspiciousProcCount;

			private int? virusProcCount;

			private int? progress;

			public long? StrategyId
			{
				get
				{
					return strategyId;
				}
				set	
				{
					strategyId = value;
				}
			}

			public string StrategyName
			{
				get
				{
					return strategyName;
				}
				set	
				{
					strategyName = value;
				}
			}

			public int? StudyTime
			{
				get
				{
					return studyTime;
				}
				set	
				{
					studyTime = value;
				}
			}

			public int? AssetCount
			{
				get
				{
					return assetCount;
				}
				set	
				{
					assetCount = value;
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

			public int? TrustProcCount
			{
				get
				{
					return trustProcCount;
				}
				set	
				{
					trustProcCount = value;
				}
			}

			public int? SuspiciousProcCount
			{
				get
				{
					return suspiciousProcCount;
				}
				set	
				{
					suspiciousProcCount = value;
				}
			}

			public int? VirusProcCount
			{
				get
				{
					return virusProcCount;
				}
				set	
				{
					virusProcCount = value;
				}
			}

			public int? Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
				}
			}
		}
	}
}
