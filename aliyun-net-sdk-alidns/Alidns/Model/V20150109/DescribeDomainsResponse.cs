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
	public class DescribeDomainsResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private long? pageNumber;

		private long? pageSize;

		private List<DescribeDomains_Domain> domains;

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

		public List<DescribeDomains_Domain> Domains
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

		public class DescribeDomains_Domain
		{

			private string domainId;

			private string domainName;

			private string punyCode;

			private bool? aliDomain;

			private long? recordCount;

			private string registrantEmail;

			private string remark;

			private string groupId;

			private string groupName;

			private string instanceId;

			private string versionCode;

			private string versionName;

			private string instanceEndTime;

			private bool? instanceExpired;

			private bool? starmark;

			private string createTime;

			private long? createTimestamp;

			private string resourceGroupId;

			private List<DescribeDomains_Tag> tags;

			private List<string> dnsServers;

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

			public string PunyCode
			{
				get
				{
					return punyCode;
				}
				set	
				{
					punyCode = value;
				}
			}

			public bool? AliDomain
			{
				get
				{
					return aliDomain;
				}
				set	
				{
					aliDomain = value;
				}
			}

			public long? RecordCount
			{
				get
				{
					return recordCount;
				}
				set	
				{
					recordCount = value;
				}
			}

			public string RegistrantEmail
			{
				get
				{
					return registrantEmail;
				}
				set	
				{
					registrantEmail = value;
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

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
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

			public string VersionName
			{
				get
				{
					return versionName;
				}
				set	
				{
					versionName = value;
				}
			}

			public string InstanceEndTime
			{
				get
				{
					return instanceEndTime;
				}
				set	
				{
					instanceEndTime = value;
				}
			}

			public bool? InstanceExpired
			{
				get
				{
					return instanceExpired;
				}
				set	
				{
					instanceExpired = value;
				}
			}

			public bool? Starmark
			{
				get
				{
					return starmark;
				}
				set	
				{
					starmark = value;
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

			public List<DescribeDomains_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public List<string> DnsServers
			{
				get
				{
					return dnsServers;
				}
				set	
				{
					dnsServers = value;
				}
			}

			public class DescribeDomains_Tag
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
