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

namespace Aliyun.Acs.scdn.Model.V20171115
{
	public class DescribeScdnTopDomainsByFlowResponse : AcsResponse
	{

		private long? domainOnlineCount;

		private string endTime;

		private string startTime;

		private string requestId;

		private long? domainCount;

		private List<DescribeScdnTopDomainsByFlow_TopDomain> topDomains;

		public long? DomainOnlineCount
		{
			get
			{
				return domainOnlineCount;
			}
			set	
			{
				domainOnlineCount = value;
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
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

		public List<DescribeScdnTopDomainsByFlow_TopDomain> TopDomains
		{
			get
			{
				return topDomains;
			}
			set	
			{
				topDomains = value;
			}
		}

		public class DescribeScdnTopDomainsByFlow_TopDomain
		{

			private long? maxBps;

			private long? rank;

			private long? totalAccess;

			private string trafficPercent;

			private string domainName;

			private string totalTraffic;

			private string maxBpsTime;

			public long? MaxBps
			{
				get
				{
					return maxBps;
				}
				set	
				{
					maxBps = value;
				}
			}

			public long? Rank
			{
				get
				{
					return rank;
				}
				set	
				{
					rank = value;
				}
			}

			public long? TotalAccess
			{
				get
				{
					return totalAccess;
				}
				set	
				{
					totalAccess = value;
				}
			}

			public string TrafficPercent
			{
				get
				{
					return trafficPercent;
				}
				set	
				{
					trafficPercent = value;
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

			public string TotalTraffic
			{
				get
				{
					return totalTraffic;
				}
				set	
				{
					totalTraffic = value;
				}
			}

			public string MaxBpsTime
			{
				get
				{
					return maxBpsTime;
				}
				set	
				{
					maxBpsTime = value;
				}
			}
		}
	}
}
