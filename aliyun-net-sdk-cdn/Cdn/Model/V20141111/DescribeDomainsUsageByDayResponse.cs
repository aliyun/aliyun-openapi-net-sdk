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

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeDomainsUsageByDayResponse : AcsResponse
	{

		private string endTime;

		private string startTime;

		private string requestId;

		private string domainName;

		private string dataInterval;

		private List<DescribeDomainsUsageByDay_UsageByDay> usageByDays;

		private DescribeDomainsUsageByDay_UsageTotal usageTotal;

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

		public string DataInterval
		{
			get
			{
				return dataInterval;
			}
			set	
			{
				dataInterval = value;
			}
		}

		public List<DescribeDomainsUsageByDay_UsageByDay> UsageByDays
		{
			get
			{
				return usageByDays;
			}
			set	
			{
				usageByDays = value;
			}
		}

		public DescribeDomainsUsageByDay_UsageTotal UsageTotal
		{
			get
			{
				return usageTotal;
			}
			set	
			{
				usageTotal = value;
			}
		}

		public class DescribeDomainsUsageByDay_UsageByDay
		{

			private string maxSrcBpsTime;

			private string qps;

			private string requestHitRate;

			private string maxBps;

			private string totalAccess;

			private string timeStamp;

			private string bytesHitRate;

			private string totalTraffic;

			private string maxSrcBps;

			private string maxBpsTime;

			public string MaxSrcBpsTime
			{
				get
				{
					return maxSrcBpsTime;
				}
				set	
				{
					maxSrcBpsTime = value;
				}
			}

			public string Qps
			{
				get
				{
					return qps;
				}
				set	
				{
					qps = value;
				}
			}

			public string RequestHitRate
			{
				get
				{
					return requestHitRate;
				}
				set	
				{
					requestHitRate = value;
				}
			}

			public string MaxBps
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

			public string TotalAccess
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

			public string TimeStamp
			{
				get
				{
					return timeStamp;
				}
				set	
				{
					timeStamp = value;
				}
			}

			public string BytesHitRate
			{
				get
				{
					return bytesHitRate;
				}
				set	
				{
					bytesHitRate = value;
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

			public string MaxSrcBps
			{
				get
				{
					return maxSrcBps;
				}
				set	
				{
					maxSrcBps = value;
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

		public class DescribeDomainsUsageByDay_UsageTotal
		{

			private string maxSrcBpsTime;

			private string requestHitRate;

			private string maxBps;

			private string totalAccess;

			private string bytesHitRate;

			private string totalTraffic;

			private string maxBpsTime;

			private string maxSrcBps;

			public string MaxSrcBpsTime
			{
				get
				{
					return maxSrcBpsTime;
				}
				set	
				{
					maxSrcBpsTime = value;
				}
			}

			public string RequestHitRate
			{
				get
				{
					return requestHitRate;
				}
				set	
				{
					requestHitRate = value;
				}
			}

			public string MaxBps
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

			public string TotalAccess
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

			public string BytesHitRate
			{
				get
				{
					return bytesHitRate;
				}
				set	
				{
					bytesHitRate = value;
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

			public string MaxSrcBps
			{
				get
				{
					return maxSrcBps;
				}
				set	
				{
					maxSrcBps = value;
				}
			}
		}
	}
}
