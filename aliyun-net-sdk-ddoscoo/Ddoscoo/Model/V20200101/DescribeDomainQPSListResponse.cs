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

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribeDomainQPSListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDomainQPSList_DomainQPS> domainQPSList;

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

		public List<DescribeDomainQPSList_DomainQPS> DomainQPSList
		{
			get
			{
				return domainQPSList;
			}
			set	
			{
				domainQPSList = value;
			}
		}

		public class DescribeDomainQPSList_DomainQPS
		{

			private long? index;

			private long? time;

			private long? maxAttackQps;

			private long? attackQps;

			private long? maxQps;

			private long? maxNormalQps;

			private long? totalQps;

			private long? totalCount;

			private long? cacheHits;

			public long? Index
			{
				get
				{
					return index;
				}
				set	
				{
					index = value;
				}
			}

			public long? Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
				}
			}

			public long? MaxAttackQps
			{
				get
				{
					return maxAttackQps;
				}
				set	
				{
					maxAttackQps = value;
				}
			}

			public long? AttackQps
			{
				get
				{
					return attackQps;
				}
				set	
				{
					attackQps = value;
				}
			}

			public long? MaxQps
			{
				get
				{
					return maxQps;
				}
				set	
				{
					maxQps = value;
				}
			}

			public long? MaxNormalQps
			{
				get
				{
					return maxNormalQps;
				}
				set	
				{
					maxNormalQps = value;
				}
			}

			public long? TotalQps
			{
				get
				{
					return totalQps;
				}
				set	
				{
					totalQps = value;
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

			public long? CacheHits
			{
				get
				{
					return cacheHits;
				}
				set	
				{
					cacheHits = value;
				}
			}
		}
	}
}
