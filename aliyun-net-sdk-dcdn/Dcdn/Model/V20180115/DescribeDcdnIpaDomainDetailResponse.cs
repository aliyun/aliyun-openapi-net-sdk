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
	public class DescribeDcdnIpaDomainDetailResponse : AcsResponse
	{

		private string requestId;

		private DescribeDcdnIpaDomainDetail_DomainDetail domainDetail;

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

		public DescribeDcdnIpaDomainDetail_DomainDetail DomainDetail
		{
			get
			{
				return domainDetail;
			}
			set	
			{
				domainDetail = value;
			}
		}

		public class DescribeDcdnIpaDomainDetail_DomainDetail
		{

			private string gmtCreated;

			private string gmtModified;

			private string domainStatus;

			private string cname;

			private string domainName;

			private string description;

			private string sSLProtocol;

			private string sSLPub;

			private string scope;

			private string certName;

			private string resourceGroupId;

			private List<DescribeDcdnIpaDomainDetail_Source> sources;

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

			public string SSLPub
			{
				get
				{
					return sSLPub;
				}
				set	
				{
					sSLPub = value;
				}
			}

			public string Scope
			{
				get
				{
					return scope;
				}
				set	
				{
					scope = value;
				}
			}

			public string CertName
			{
				get
				{
					return certName;
				}
				set	
				{
					certName = value;
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

			public List<DescribeDcdnIpaDomainDetail_Source> Sources
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

			public class DescribeDcdnIpaDomainDetail_Source
			{

				private string content;

				private string type;

				private int? port;

				private string enabled;

				private string priority;

				private string weight;

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

				public string Enabled
				{
					get
					{
						return enabled;
					}
					set	
					{
						enabled = value;
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
