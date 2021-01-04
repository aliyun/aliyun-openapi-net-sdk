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

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeDnsGtmAccessStrategiesResponse : AcsResponse
	{

		private string requestId;

		private int? totalItems;

		private int? totalPages;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeDnsGtmAccessStrategies_Strategy> strategies;

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

		public int? TotalItems
		{
			get
			{
				return totalItems;
			}
			set	
			{
				totalItems = value;
			}
		}

		public int? TotalPages
		{
			get
			{
				return totalPages;
			}
			set	
			{
				totalPages = value;
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

		public List<DescribeDnsGtmAccessStrategies_Strategy> Strategies
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

		public class DescribeDnsGtmAccessStrategies_Strategy
		{

			private string strategyId;

			private string strategyName;

			private string createTime;

			private long? createTimestamp;

			private string effectiveAddrPoolGroupType;

			private string effectiveAddrPoolType;

			private string effectiveLbaStrategy;

			private List<DescribeDnsGtmAccessStrategies_Line> lines;

			private List<DescribeDnsGtmAccessStrategies_EffectiveAddrPool> effectiveAddrPools;

			public string StrategyId
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

			public string CreateTime
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

			public long? CreateTimestamp
			{
				get
				{
					return createTimestamp;
				}
				set	
				{
					createTimestamp = value;
				}
			}

			public string EffectiveAddrPoolGroupType
			{
				get
				{
					return effectiveAddrPoolGroupType;
				}
				set	
				{
					effectiveAddrPoolGroupType = value;
				}
			}

			public string EffectiveAddrPoolType
			{
				get
				{
					return effectiveAddrPoolType;
				}
				set	
				{
					effectiveAddrPoolType = value;
				}
			}

			public string EffectiveLbaStrategy
			{
				get
				{
					return effectiveLbaStrategy;
				}
				set	
				{
					effectiveLbaStrategy = value;
				}
			}

			public List<DescribeDnsGtmAccessStrategies_Line> Lines
			{
				get
				{
					return lines;
				}
				set	
				{
					lines = value;
				}
			}

			public List<DescribeDnsGtmAccessStrategies_EffectiveAddrPool> EffectiveAddrPools
			{
				get
				{
					return effectiveAddrPools;
				}
				set	
				{
					effectiveAddrPools = value;
				}
			}

			public class DescribeDnsGtmAccessStrategies_Line
			{

				private string lineCode;

				private string lineName;

				private string groupCode;

				private string groupName;

				public string LineCode
				{
					get
					{
						return lineCode;
					}
					set	
					{
						lineCode = value;
					}
				}

				public string LineName
				{
					get
					{
						return lineName;
					}
					set	
					{
						lineName = value;
					}
				}

				public string GroupCode
				{
					get
					{
						return groupCode;
					}
					set	
					{
						groupCode = value;
					}
				}

				public string GroupName
				{
					get
					{
						return groupName;
					}
					set	
					{
						groupName = value;
					}
				}
			}

			public class DescribeDnsGtmAccessStrategies_EffectiveAddrPool
			{

				private string id;

				private string name;

				private int? addrCount;

				private int? lbaWeight;

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public int? AddrCount
				{
					get
					{
						return addrCount;
					}
					set	
					{
						addrCount = value;
					}
				}

				public int? LbaWeight
				{
					get
					{
						return lbaWeight;
					}
					set	
					{
						lbaWeight = value;
					}
				}
			}
		}
	}
}
