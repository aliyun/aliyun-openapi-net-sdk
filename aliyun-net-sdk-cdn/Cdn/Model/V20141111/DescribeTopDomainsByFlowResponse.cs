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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeTopDomainsByFlowResponse : AcsResponse
	{

		private string requestId;

		private string startTime;

		private string endTime;

		private long? domainCount;

		private long? domainOnlineCount;

		private List<DescribeTopDomainsByFlow_TopDomain> topDomains;

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

		public List<DescribeTopDomainsByFlow_TopDomain> TopDomains
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

		public class DescribeTopDomainsByFlow_TopDomain
		{

			private string domainName;

			private long? rank;

			private string totalTraffic;

			private string trafficPercent;

			private long? maxBps;

			private string maxBpsTime;

			private long? totalAccess;

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
		}
	}
}