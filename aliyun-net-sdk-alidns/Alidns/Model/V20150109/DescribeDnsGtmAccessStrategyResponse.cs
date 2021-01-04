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
	public class DescribeDnsGtmAccessStrategyResponse : AcsResponse
	{

		private string requestId;

		private string strategyId;

		private string strategyName;

		private string strategyMode;

		private string instanceId;

		private string defaultAddrPoolType;

		private string defaultLbaStrategy;

		private int? defaultMinAvailableAddrNum;

		private int? defaultMaxReturnAddrNum;

		private string defaultLatencyOptimization;

		private string defaultAddrPoolGroupStatus;

		private string failoverAddrPoolType;

		private string failoverLbaStrategy;

		private int? failoverMinAvailableAddrNum;

		private int? failoverMaxReturnAddrNum;

		private string failoverLatencyOptimization;

		private string failoverAddrPoolGroupStatus;

		private string accessMode;

		private string effectiveAddrPoolGroupType;

		private string createTime;

		private long? createTimestamp;

		private int? defaultAvailableAddrNum;

		private int? failoverAvailableAddrNum;

		private List<DescribeDnsGtmAccessStrategy_Line> lines;

		private List<DescribeDnsGtmAccessStrategy_DefaultAddrPool> defaultAddrPools;

		private List<DescribeDnsGtmAccessStrategy_FailoverAddrPool> failoverAddrPools;

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

		public string StrategyMode
		{
			get
			{
				return strategyMode;
			}
			set	
			{
				strategyMode = value;
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

		public string DefaultAddrPoolType
		{
			get
			{
				return defaultAddrPoolType;
			}
			set	
			{
				defaultAddrPoolType = value;
			}
		}

		public string DefaultLbaStrategy
		{
			get
			{
				return defaultLbaStrategy;
			}
			set	
			{
				defaultLbaStrategy = value;
			}
		}

		public int? DefaultMinAvailableAddrNum
		{
			get
			{
				return defaultMinAvailableAddrNum;
			}
			set	
			{
				defaultMinAvailableAddrNum = value;
			}
		}

		public int? DefaultMaxReturnAddrNum
		{
			get
			{
				return defaultMaxReturnAddrNum;
			}
			set	
			{
				defaultMaxReturnAddrNum = value;
			}
		}

		public string DefaultLatencyOptimization
		{
			get
			{
				return defaultLatencyOptimization;
			}
			set	
			{
				defaultLatencyOptimization = value;
			}
		}

		public string DefaultAddrPoolGroupStatus
		{
			get
			{
				return defaultAddrPoolGroupStatus;
			}
			set	
			{
				defaultAddrPoolGroupStatus = value;
			}
		}

		public string FailoverAddrPoolType
		{
			get
			{
				return failoverAddrPoolType;
			}
			set	
			{
				failoverAddrPoolType = value;
			}
		}

		public string FailoverLbaStrategy
		{
			get
			{
				return failoverLbaStrategy;
			}
			set	
			{
				failoverLbaStrategy = value;
			}
		}

		public int? FailoverMinAvailableAddrNum
		{
			get
			{
				return failoverMinAvailableAddrNum;
			}
			set	
			{
				failoverMinAvailableAddrNum = value;
			}
		}

		public int? FailoverMaxReturnAddrNum
		{
			get
			{
				return failoverMaxReturnAddrNum;
			}
			set	
			{
				failoverMaxReturnAddrNum = value;
			}
		}

		public string FailoverLatencyOptimization
		{
			get
			{
				return failoverLatencyOptimization;
			}
			set	
			{
				failoverLatencyOptimization = value;
			}
		}

		public string FailoverAddrPoolGroupStatus
		{
			get
			{
				return failoverAddrPoolGroupStatus;
			}
			set	
			{
				failoverAddrPoolGroupStatus = value;
			}
		}

		public string AccessMode
		{
			get
			{
				return accessMode;
			}
			set	
			{
				accessMode = value;
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

		public int? DefaultAvailableAddrNum
		{
			get
			{
				return defaultAvailableAddrNum;
			}
			set	
			{
				defaultAvailableAddrNum = value;
			}
		}

		public int? FailoverAvailableAddrNum
		{
			get
			{
				return failoverAvailableAddrNum;
			}
			set	
			{
				failoverAvailableAddrNum = value;
			}
		}

		public List<DescribeDnsGtmAccessStrategy_Line> Lines
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

		public List<DescribeDnsGtmAccessStrategy_DefaultAddrPool> DefaultAddrPools
		{
			get
			{
				return defaultAddrPools;
			}
			set	
			{
				defaultAddrPools = value;
			}
		}

		public List<DescribeDnsGtmAccessStrategy_FailoverAddrPool> FailoverAddrPools
		{
			get
			{
				return failoverAddrPools;
			}
			set	
			{
				failoverAddrPools = value;
			}
		}

		public class DescribeDnsGtmAccessStrategy_Line
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

		public class DescribeDnsGtmAccessStrategy_DefaultAddrPool
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

		public class DescribeDnsGtmAccessStrategy_FailoverAddrPool
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
