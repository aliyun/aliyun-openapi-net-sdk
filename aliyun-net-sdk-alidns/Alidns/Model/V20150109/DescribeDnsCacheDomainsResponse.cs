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
	public class DescribeDnsCacheDomainsResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private long? pageNumber;

		private long? pageSize;

		private List<DescribeDnsCacheDomains_Domain> domains;

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

		public List<DescribeDnsCacheDomains_Domain> Domains
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

		public class DescribeDnsCacheDomains_Domain
		{

			private string domainId;

			private string domainName;

			private string instanceId;

			private string versionCode;

			private string remark;

			private string updateTime;

			private long? updateTimestamp;

			private string createTime;

			private long? createTimestamp;

			private int? cacheTtlMin;

			private int? cacheTtlMax;

			private string sourceProtocol;

			private string sourceEdns;

			private string expireTime;

			private long? expireTimestamp;

			private List<DescribeDnsCacheDomains_SourceDnsServer> sourceDnsServers;

			public string DomainId
			{
				get
				{
					return domainId;
				}
				set	
				{
					domainId = value;
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

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string VersionCode
			{
				get
				{
					return versionCode;
				}
				set	
				{
					versionCode = value;
				}
			}

			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public long? UpdateTimestamp
			{
				get
				{
					return updateTimestamp;
				}
				set	
				{
					updateTimestamp = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public long? CreateTimestamp
			{
				get
				{
					return createTimestamp;
				}
				set	
				{
					createTimestamp = value;
				}
			}

			public int? CacheTtlMin
			{
				get
				{
					return cacheTtlMin;
				}
				set	
				{
					cacheTtlMin = value;
				}
			}

			public int? CacheTtlMax
			{
				get
				{
					return cacheTtlMax;
				}
				set	
				{
					cacheTtlMax = value;
				}
			}

			public string SourceProtocol
			{
				get
				{
					return sourceProtocol;
				}
				set	
				{
					sourceProtocol = value;
				}
			}

			public string SourceEdns
			{
				get
				{
					return sourceEdns;
				}
				set	
				{
					sourceEdns = value;
				}
			}

			public string ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
				}
			}

			public long? ExpireTimestamp
			{
				get
				{
					return expireTimestamp;
				}
				set	
				{
					expireTimestamp = value;
				}
			}

			public List<DescribeDnsCacheDomains_SourceDnsServer> SourceDnsServers
			{
				get
				{
					return sourceDnsServers;
				}
				set	
				{
					sourceDnsServers = value;
				}
			}

			public class DescribeDnsCacheDomains_SourceDnsServer
			{

				private string host;

				private string port;

				public string Host
				{
					get
					{
						return host;
					}
					set	
					{
						host = value;
					}
				}

				public string Port
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
			}
		}
	}
}
