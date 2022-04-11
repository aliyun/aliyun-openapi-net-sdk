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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class DescribeVodUserDomainsResponse : AcsResponse
	{

		private string requestId;

		private long? pageNumber;

		private long? pageSize;

		private long? totalCount;

		private List<DescribeVodUserDomains_PageData> domains;

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

		public List<DescribeVodUserDomains_PageData> Domains
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

		public class DescribeVodUserDomains_PageData
		{

			private string gmtCreated;

			private string sslProtocol;

			private string description;

			private string sandbox;

			private string cname;

			private string domainStatus;

			private string gmtModified;

			private string domainName;

			private List<DescribeVodUserDomains_Source> sources;

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

			public string SslProtocol
			{
				get
				{
					return sslProtocol;
				}
				set	
				{
					sslProtocol = value;
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

			public List<DescribeVodUserDomains_Source> Sources
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

			public class DescribeVodUserDomains_Source
			{

				private string type;

				private string priority;

				private int? port;

				private string content;

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
			}
		}
	}
}
