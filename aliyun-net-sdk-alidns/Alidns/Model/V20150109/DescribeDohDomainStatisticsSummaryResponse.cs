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
	public class DescribeDohDomainStatisticsSummaryResponse : AcsResponse
	{

		private string requestId;

		private int? totalItems;

		private int? totalPages;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribeDohDomainStatisticsSummary_Statistic> statistics;

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

		public List<DescribeDohDomainStatisticsSummary_Statistic> Statistics
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

		public class DescribeDohDomainStatisticsSummary_Statistic
		{

			private string domainName;

			private long? v4HttpCount;

			private long? v6HttpCount;

			private long? v4HttpsCount;

			private long? v6HttpsCount;

			private long? totalCount;

			private long? ipCount;

			private long? httpCount;

			private long? httpsCount;

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
		}
	}
}
