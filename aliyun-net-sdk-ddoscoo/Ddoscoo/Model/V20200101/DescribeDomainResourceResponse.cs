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
	public class DescribeDomainResourceResponse : AcsResponse
	{

		private long? totalCount;

		private string requestId;

		private List<DescribeDomainResource_WebRule> webRules;

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

		public List<DescribeDomainResource_WebRule> WebRules
		{
			get
			{
				return webRules;
			}
			set	
			{
				webRules = value;
			}
		}

		public class DescribeDomainResource_WebRule
		{

			private string domain;

			private bool? http2HttpsEnable;

			private string sslProtocols;

			private int? punishReason;

			private string ccTemplate;

			private string httpsExt;

			private bool? ccEnabled;

			private string sslCiphers;

			private bool? ccRuleEnabled;

			private bool? ssl13Enabled;

			private int? rsType;

			private bool? punishStatus;

			private bool? proxyEnabled;

			private string certName;

			private string policyMode;

			private string cname;

			private bool? http2Enable;

			private bool? https2HttpEnable;

			private List<DescribeDomainResource_ProxyConfig> proxyTypes;

			private List<string> instanceIds;

			private List<string> customCiphers;

			private List<string> whiteList;

			private List<string> blackList;

			private List<string> realServers;

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

			public bool? Http2HttpsEnable
			{
				get
				{
					return http2HttpsEnable;
				}
				set	
				{
					http2HttpsEnable = value;
				}
			}

			public string SslProtocols
			{
				get
				{
					return sslProtocols;
				}
				set	
				{
					sslProtocols = value;
				}
			}

			public int? PunishReason
			{
				get
				{
					return punishReason;
				}
				set	
				{
					punishReason = value;
				}
			}

			public string CcTemplate
			{
				get
				{
					return ccTemplate;
				}
				set	
				{
					ccTemplate = value;
				}
			}

			public string HttpsExt
			{
				get
				{
					return httpsExt;
				}
				set	
				{
					httpsExt = value;
				}
			}

			public bool? CcEnabled
			{
				get
				{
					return ccEnabled;
				}
				set	
				{
					ccEnabled = value;
				}
			}

			public string SslCiphers
			{
				get
				{
					return sslCiphers;
				}
				set	
				{
					sslCiphers = value;
				}
			}

			public bool? CcRuleEnabled
			{
				get
				{
					return ccRuleEnabled;
				}
				set	
				{
					ccRuleEnabled = value;
				}
			}

			public bool? Ssl13Enabled
			{
				get
				{
					return ssl13Enabled;
				}
				set	
				{
					ssl13Enabled = value;
				}
			}

			public int? RsType
			{
				get
				{
					return rsType;
				}
				set	
				{
					rsType = value;
				}
			}

			public bool? PunishStatus
			{
				get
				{
					return punishStatus;
				}
				set	
				{
					punishStatus = value;
				}
			}

			public bool? ProxyEnabled
			{
				get
				{
					return proxyEnabled;
				}
				set	
				{
					proxyEnabled = value;
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

			public string PolicyMode
			{
				get
				{
					return policyMode;
				}
				set	
				{
					policyMode = value;
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

			public bool? Http2Enable
			{
				get
				{
					return http2Enable;
				}
				set	
				{
					http2Enable = value;
				}
			}

			public bool? Https2HttpEnable
			{
				get
				{
					return https2HttpEnable;
				}
				set	
				{
					https2HttpEnable = value;
				}
			}

			public List<DescribeDomainResource_ProxyConfig> ProxyTypes
			{
				get
				{
					return proxyTypes;
				}
				set	
				{
					proxyTypes = value;
				}
			}

			public List<string> InstanceIds
			{
				get
				{
					return instanceIds;
				}
				set	
				{
					instanceIds = value;
				}
			}

			public List<string> CustomCiphers
			{
				get
				{
					return customCiphers;
				}
				set	
				{
					customCiphers = value;
				}
			}

			public List<string> WhiteList
			{
				get
				{
					return whiteList;
				}
				set	
				{
					whiteList = value;
				}
			}

			public List<string> BlackList
			{
				get
				{
					return blackList;
				}
				set	
				{
					blackList = value;
				}
			}

			public List<string> RealServers
			{
				get
				{
					return realServers;
				}
				set	
				{
					realServers = value;
				}
			}

			public class DescribeDomainResource_ProxyConfig
			{

				private string proxyType;

				private List<string> proxyPorts;

				public string ProxyType
				{
					get
					{
						return proxyType;
					}
					set	
					{
						proxyType = value;
					}
				}

				public List<string> ProxyPorts
				{
					get
					{
						return proxyPorts;
					}
					set	
					{
						proxyPorts = value;
					}
				}
			}
		}
	}
}
