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

namespace Aliyun.Acs.dcdn.Model.V20180115
{
	public class DescribeDcdnIpaUserDomainsResponse : AcsResponse
	{

		private string requestId;

		private long? pageNumber;

		private long? pageSize;

		private long? totalCount;

		private List<DescribeDcdnIpaUserDomains_PageData> domains;

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

		public List<DescribeDcdnIpaUserDomains_PageData> Domains
		{
			get
			{
				return domains;
			}
			set	
			{
				domains = value;
			}
		}

		public class DescribeDcdnIpaUserDomains_PageData
		{

			private string domainName;

			private string cname;

			private string domainStatus;

			private string gmtCreated;

			private string gmtModified;

			private string description;

			private string sSLProtocol;

			private string resourceGroupId;

			private string sandbox;

			private List<DescribeDcdnIpaUserDomains_Source> sources;

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

			public string Cname
			{
				get
				{
					return cname;
				}
				set	
				{
					cname = value;
				}
			}

			public string DomainStatus
			{
				get
				{
					return domainStatus;
				}
				set	
				{
					domainStatus = value;
				}
			}

			public string GmtCreated
			{
				get
				{
					return gmtCreated;
				}
				set	
				{
					gmtCreated = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string SSLProtocol
			{
				get
				{
					return sSLProtocol;
				}
				set	
				{
					sSLProtocol = value;
				}
			}

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
				}
			}

			public string Sandbox
			{
				get
				{
					return sandbox;
				}
				set	
				{
					sandbox = value;
				}
			}

			public List<DescribeDcdnIpaUserDomains_Source> Sources
			{
				get
				{
					return sources;
				}
				set	
				{
					sources = value;
				}
			}

			public class DescribeDcdnIpaUserDomains_Source
			{

				private string type;

				private string content;

				private int? port;

				private string priority;

				private string weight;

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string Content
				{
					get
					{
						return content;
					}
					set	
					{
						content = value;
					}
				}

				public int? Port
				{
					get
					{
						return port;
					}
					set	
					{
						port = value;
					}
				}

				public string Priority
				{
					get
					{
						return priority;
					}
					set	
					{
						priority = value;
					}
				}

				public string Weight
				{
					get
					{
						return weight;
					}
					set	
					{
						weight = value;
					}
				}
			}
		}
	}
}
