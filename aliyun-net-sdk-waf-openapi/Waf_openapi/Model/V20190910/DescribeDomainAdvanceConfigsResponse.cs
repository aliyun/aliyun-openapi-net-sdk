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

namespace Aliyun.Acs.waf_openapi.Model.V20190910
{
	public class DescribeDomainAdvanceConfigsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDomainAdvanceConfigs_DomainConfig> domainConfigs;

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

		public List<DescribeDomainAdvanceConfigs_DomainConfig> DomainConfigs
		{
			get
			{
				return domainConfigs;
			}
			set	
			{
				domainConfigs = value;
			}
		}

		public class DescribeDomainAdvanceConfigs_DomainConfig
		{

			private string domain;

			private DescribeDomainAdvanceConfigs_Profile profile;

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			public DescribeDomainAdvanceConfigs_Profile Profile
			{
				get
				{
					return profile;
				}
				set	
				{
					profile = value;
				}
			}

			public class DescribeDomainAdvanceConfigs_Profile
			{

				private int? ipv6Status;

				private string gSLBStatus;

				private int? vipServiceStatus;

				private int? clusterType;

				private int? exclusiveVipStatus;

				private string cname;

				private int? certStatus;

				private int? resolvedType;

				private List<string> http2Port;

				private List<string> httpPort;

				private List<string> rs;

				private List<string> httpsPort;

				public int? Ipv6Status
				{
					get
					{
						return ipv6Status;
					}
					set	
					{
						ipv6Status = value;
					}
				}

				public string GSLBStatus
				{
					get
					{
						return gSLBStatus;
					}
					set	
					{
						gSLBStatus = value;
					}
				}

				public int? VipServiceStatus
				{
					get
					{
						return vipServiceStatus;
					}
					set	
					{
						vipServiceStatus = value;
					}
				}

				public int? ClusterType
				{
					get
					{
						return clusterType;
					}
					set	
					{
						clusterType = value;
					}
				}

				public int? ExclusiveVipStatus
				{
					get
					{
						return exclusiveVipStatus;
					}
					set	
					{
						exclusiveVipStatus = value;
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

				public int? CertStatus
				{
					get
					{
						return certStatus;
					}
					set	
					{
						certStatus = value;
					}
				}

				public int? ResolvedType
				{
					get
					{
						return resolvedType;
					}
					set	
					{
						resolvedType = value;
					}
				}

				public List<string> Http2Port
				{
					get
					{
						return http2Port;
					}
					set	
					{
						http2Port = value;
					}
				}

				public List<string> HttpPort
				{
					get
					{
						return httpPort;
					}
					set	
					{
						httpPort = value;
					}
				}

				public List<string> Rs
				{
					get
					{
						return rs;
					}
					set	
					{
						rs = value;
					}
				}

				public List<string> HttpsPort
				{
					get
					{
						return httpsPort;
					}
					set	
					{
						httpsPort = value;
					}
				}
			}
		}
	}
}
