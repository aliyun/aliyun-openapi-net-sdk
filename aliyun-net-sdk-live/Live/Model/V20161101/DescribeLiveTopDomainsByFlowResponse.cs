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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeLiveTopDomainsByFlowResponse : AcsResponse
	{

		private long? domainOnlineCount;

		private string endTime;

		private string startTime;

		private string requestId;

		private long? domainCount;

		private List<DescribeLiveTopDomainsByFlow_TopDomain> topDomains;

		[JsonProperty(PropertyName = "DomainOnlineCount")]
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

		[JsonProperty(PropertyName = "EndTime")]
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

		[JsonProperty(PropertyName = "StartTime")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "DomainCount")]
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

		[JsonProperty(PropertyName = "TopDomains")]
		public List<DescribeLiveTopDomainsByFlow_TopDomain> TopDomains
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

		public class DescribeLiveTopDomainsByFlow_TopDomain
		{

			private long? maxBps;

			private long? rank;

			private long? totalAccess;

			private string trafficPercent;

			private string domainName;

			private string totalTraffic;

			private string maxBpsTime;

			[JsonProperty(PropertyName = "MaxBps")]
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

			[JsonProperty(PropertyName = "Rank")]
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

			[JsonProperty(PropertyName = "TotalAccess")]
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

			[JsonProperty(PropertyName = "TrafficPercent")]
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

			[JsonProperty(PropertyName = "DomainName")]
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

			[JsonProperty(PropertyName = "TotalTraffic")]
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

			[JsonProperty(PropertyName = "MaxBpsTime")]
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
