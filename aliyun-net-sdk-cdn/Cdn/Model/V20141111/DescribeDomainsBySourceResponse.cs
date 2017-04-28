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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeDomainsBySourceResponse : AcsResponse
	{

		private string sources;

		private List<DomainsData> domainsList;

		public string Sources
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

		public List<DomainsData> DomainsList
		{
			get
			{
				return domainsList;
			}
			set	
			{
				domainsList = value;
			}
		}

		public class DomainsData{

			private string source;

			private List<domainInfo> domainInfos;

			private List<string> domains;

			public string Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
				}
			}

			public List<domainInfo> DomainInfos
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

			public List<string> Domains
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

			public class domainInfo{

				private string domainName;

				private string domainCname;

				private string createTime;

				private string updateTime;

				private string status;

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

				public string DomainCname
				{
					get
					{
						return domainCname;
					}
					set	
					{
						domainCname = value;
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

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}
		}
	}
}