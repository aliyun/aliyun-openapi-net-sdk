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
	public class DescribePdnsThreatStatisticsResponse : AcsResponse
	{

		private long? totalCount;

		private string requestId;

		private long? pageSize;

		private long? pageNumber;

		private List<DescribePdnsThreatStatistics_StatisticItem> data;

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

		public long? PageSize
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

		public long? PageNumber
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

		public List<DescribePdnsThreatStatistics_StatisticItem> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribePdnsThreatStatistics_StatisticItem
		{

			private string subDomain;

			private long? udpTotalCount;

			private long? totalCount;

			private string sourceIp;

			private string threatLevel;

			private string domainName;

			private string threatType;

			private string maxThreatLevel;

			private long? latestThreatTime;

			private long? dohTotalCount;

			private long? domainCount;

			public string SubDomain
			{
				get
				{
					return subDomain;
				}
				set	
				{
					subDomain = value;
				}
			}

			public long? UdpTotalCount
			{
				get
				{
					return udpTotalCount;
				}
				set	
				{
					udpTotalCount = value;
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

			public string SourceIp
			{
				get
				{
					return sourceIp;
				}
				set	
				{
					sourceIp = value;
				}
			}

			public string ThreatLevel
			{
				get
				{
					return threatLevel;
				}
				set	
				{
					threatLevel = value;
				}
			}

			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

			public string ThreatType
			{
				get
				{
					return threatType;
				}
				set	
				{
					threatType = value;
				}
			}

			public string MaxThreatLevel
			{
				get
				{
					return maxThreatLevel;
				}
				set	
				{
					maxThreatLevel = value;
				}
			}

			public long? LatestThreatTime
			{
				get
				{
					return latestThreatTime;
				}
				set	
				{
					latestThreatTime = value;
				}
			}

			public long? DohTotalCount
			{
				get
				{
					return dohTotalCount;
				}
				set	
				{
					dohTotalCount = value;
				}
			}

			public long? DomainCount
			{
				get
				{
					return domainCount;
				}
				set	
				{
					domainCount = value;
				}
			}
		}
	}
}
