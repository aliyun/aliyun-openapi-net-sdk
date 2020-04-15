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

namespace Aliyun.Acs.Smartag.Model.V20180313
{
	public class DescribeRouteDistributionStrategiesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeRouteDistributionStrategies_Strategy> strategies;

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

		public List<DescribeRouteDistributionStrategies_Strategy> Strategies
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

		public class DescribeRouteDistributionStrategies_Strategy
		{

			private long? createTime;

			private string instanceId;

			private string smartAGId;

			private string hcInstanceId;

			private string sourceType;

			private string destCidrBlock;

			private string routeSource;

			private string routeDistribution;

			private string status;

			private bool? isConflict;

			private string strategyPublishStatus;

			private string conflictInfo;

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string SmartAGId
			{
				get
				{
					return smartAGId;
				}
				set	
				{
					smartAGId = value;
				}
			}

			public string HcInstanceId
			{
				get
				{
					return hcInstanceId;
				}
				set	
				{
					hcInstanceId = value;
				}
			}

			public string SourceType
			{
				get
				{
					return sourceType;
				}
				set	
				{
					sourceType = value;
				}
			}

			public string DestCidrBlock
			{
				get
				{
					return destCidrBlock;
				}
				set	
				{
					destCidrBlock = value;
				}
			}

			public string RouteSource
			{
				get
				{
					return routeSource;
				}
				set	
				{
					routeSource = value;
				}
			}

			public string RouteDistribution
			{
				get
				{
					return routeDistribution;
				}
				set	
				{
					routeDistribution = value;
				}
			}

			public string Status
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

			public bool? IsConflict
			{
				get
				{
					return isConflict;
				}
				set	
				{
					isConflict = value;
				}
			}

			public string StrategyPublishStatus
			{
				get
				{
					return strategyPublishStatus;
				}
				set	
				{
					strategyPublishStatus = value;
				}
			}

			public string ConflictInfo
			{
				get
				{
					return conflictInfo;
				}
				set	
				{
					conflictInfo = value;
				}
			}
		}
	}
}
