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
	public class DescribePdnsRequestStatisticsResponse : AcsResponse
	{

		private long? totalCount;

		private string requestId;

		private long? pageSize;

		private long? pageNumber;

		private List<DescribePdnsRequestStatistics_StatisticItem> data;

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

		public List<DescribePdnsRequestStatistics_StatisticItem> Data
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

		public class DescribePdnsRequestStatistics_StatisticItem
		{

			private long? udpTotalCount;

			private long? ipCount;

			private string domainName;

			private long? v6HttpCount;

			private long? v4Count;

			private long? httpsCount;

			private long? v4HttpsCount;

			private long? v6Count;

			private string subDomain;

			private long? totalCount;

			private long? v4HttpCount;

			private long? threatCount;

			private string maxThreatLevel;

			private long? httpCount;

			private long? v6HttpsCount;

			private long? dohTotalCount;

			private List<DescribePdnsRequestStatistics_ThreatItem> threatInfo;

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

			public long? IpCount
			{
				get
				{
					return ipCount;
				}
				set	
				{
					ipCount = value;
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

			public long? V6HttpCount
			{
				get
				{
					return v6HttpCount;
				}
				set	
				{
					v6HttpCount = value;
				}
			}

			public long? V4Count
			{
				get
				{
					return v4Count;
				}
				set	
				{
					v4Count = value;
				}
			}

			public long? HttpsCount
			{
				get
				{
					return httpsCount;
				}
				set	
				{
					httpsCount = value;
				}
			}

			public long? V4HttpsCount
			{
				get
				{
					return v4HttpsCount;
				}
				set	
				{
					v4HttpsCount = value;
				}
			}

			public long? V6Count
			{
				get
				{
					return v6Count;
				}
				set	
				{
					v6Count = value;
				}
			}

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

			public long? V4HttpCount
			{
				get
				{
					return v4HttpCount;
				}
				set	
				{
					v4HttpCount = value;
				}
			}

			public long? ThreatCount
			{
				get
				{
					return threatCount;
				}
				set	
				{
					threatCount = value;
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

			public long? HttpCount
			{
				get
				{
					return httpCount;
				}
				set	
				{
					httpCount = value;
				}
			}

			public long? V6HttpsCount
			{
				get
				{
					return v6HttpsCount;
				}
				set	
				{
					v6HttpsCount = value;
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

			public List<DescribePdnsRequestStatistics_ThreatItem> ThreatInfo
			{
				get
				{
					return threatInfo;
				}
				set	
				{
					threatInfo = value;
				}
			}

			public class DescribePdnsRequestStatistics_ThreatItem
			{

				private string threatLevel;

				private string threatType;

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
			}
		}
	}
}
