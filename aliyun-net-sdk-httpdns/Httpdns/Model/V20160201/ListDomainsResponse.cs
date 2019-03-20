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

namespace Aliyun.Acs.Httpdns.Model.V20160201
{
	public class ListDomainsResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private long? pageNumber;

		private long? pageSize;

		private List<ListDomains_DomainInfo> domainInfos;

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

		public List<ListDomains_DomainInfo> DomainInfos
		{
			get
			{
				return domainInfos;
			}
			set	
			{
				domainInfos = value;
			}
		}

		public class ListDomains_DomainInfo
		{

			private string domainName;

			private long? resolved;

			private long? resolvedHttps;

			private long? resolved6;

			private long? resolvedHttps6;

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

			public long? Resolved
			{
				get
				{
					return resolved;
				}
				set	
				{
					resolved = value;
				}
			}

			public long? ResolvedHttps
			{
				get
				{
					return resolvedHttps;
				}
				set	
				{
					resolvedHttps = value;
				}
			}

			public long? Resolved6
			{
				get
				{
					return resolved6;
				}
				set	
				{
					resolved6 = value;
				}
			}

			public long? ResolvedHttps6
			{
				get
				{
					return resolvedHttps6;
				}
				set	
				{
					resolvedHttps6 = value;
				}
			}
		}
	}
}
