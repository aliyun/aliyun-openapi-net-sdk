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
	public class DescribeVulTargetStatisticsResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeVulTargetStatistics_TargetStat> targetStats;

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

		public List<DescribeVulTargetStatistics_TargetStat> TargetStats
		{
			get
			{
				return targetStats;
			}
			set	
			{
				targetStats = value;
			}
		}

		public class DescribeVulTargetStatistics_TargetStat
		{

			private string vulType;

			private string uuidCount;

			private string totalCount;

			private List<DescribeVulTargetStatistics_Target> targets;

			public string VulType
			{
				get
				{
					return vulType;
				}
				set	
				{
					vulType = value;
				}
			}

			public string UuidCount
			{
				get
				{
					return uuidCount;
				}
				set	
				{
					uuidCount = value;
				}
			}

			public string TotalCount
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

			public List<DescribeVulTargetStatistics_Target> Targets
			{
				get
				{
					return targets;
				}
				set	
				{
					targets = value;
				}
			}

			public class DescribeVulTargetStatistics_Target
			{

				private string target;

				private string targetType;

				private string flag;

				public string Target
				{
					get
					{
						return target;
					}
					set	
					{
						target = value;
					}
				}

				public string TargetType
				{
					get
					{
						return targetType;
					}
					set	
					{
						targetType = value;
					}
				}

				public string Flag
				{
					get
					{
						return flag;
					}
					set	
					{
						flag = value;
					}
				}
			}
		}
	}
}
