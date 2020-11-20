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
	public class DescribeDohDomainStatisticsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDohDomainStatistics_Statistic> statistics;

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

		public List<DescribeDohDomainStatistics_Statistic> Statistics
		{
			get
			{
				return statistics;
			}
			set	
			{
				statistics = value;
			}
		}

		public class DescribeDohDomainStatistics_Statistic
		{

			private long? timestamp;

			private long? v4HttpCount;

			private long? v6HttpCount;

			private long? v4HttpsCount;

			private long? v6HttpsCount;

			private long? totalCount;

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
		}
	}
}
