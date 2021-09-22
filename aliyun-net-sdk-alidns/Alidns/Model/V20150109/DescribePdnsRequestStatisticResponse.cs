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
	public class DescribePdnsRequestStatisticResponse : AcsResponse
	{

		private string requestId;

		private List<DescribePdnsRequestStatistic_StatisticItem> data;

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

		public List<DescribePdnsRequestStatistic_StatisticItem> Data
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

		public class DescribePdnsRequestStatistic_StatisticItem
		{

			private long? udpTotalCount;

			private long? ipCount;

			private long? totalCount;

			private long? v4HttpCount;

			private long? v6HttpCount;

			private long? v4Count;

			private long? httpsCount;

			private long? httpCount;

			private long? v4HttpsCount;

			private long? timestamp;

			private long? v6HttpsCount;

			private long? dohTotalCount;

			private long? v6Count;

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

			public long? Timestamp
			{
				get
				{
					return timestamp;
				}
				set	
				{
					timestamp = value;
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
		}
	}
}
