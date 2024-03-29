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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeLiveDomainCertificateInfoResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveDomainCertificateInfo_CertInfo> certInfos;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "CertInfos")]
		public List<DescribeLiveDomainCertificateInfo_CertInfo> CertInfos
		{
			get
			{
				return certInfos;
			}
			set	
			{
				certInfos = value;
			}
		}

		public class DescribeLiveDomainCertificateInfo_CertInfo
		{

			private string status;

			private string certLife;

			private string certExpireTime;

			private string sSLPub;

			private string sSLProtocol;

			private string certType;

			private string certDomainName;

			private string certName;

			private string certOrg;

			private string domainName;

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "CertLife")]
			public string CertLife
			{
				get
				{
					return certLife;
				}
				set	
				{
					certLife = value;
				}
			}

			[JsonProperty(PropertyName = "CertExpireTime")]
			public string CertExpireTime
			{
				get
				{
					return certExpireTime;
				}
				set	
				{
					certExpireTime = value;
				}
			}

			[JsonProperty(PropertyName = "SSLPub")]
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

			[JsonProperty(PropertyName = "SSLProtocol")]
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

			[JsonProperty(PropertyName = "CertType")]
			public string CertType
			{
				get
				{
					return certType;
				}
				set	
				{
					certType = value;
				}
			}

			[JsonProperty(PropertyName = "CertDomainName")]
			public string CertDomainName
			{
				get
				{
					return certDomainName;
				}
				set	
				{
					certDomainName = value;
				}
			}

			[JsonProperty(PropertyName = "CertName")]
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

			[JsonProperty(PropertyName = "CertOrg")]
			public string CertOrg
			{
				get
				{
					return certOrg;
				}
				set	
				{
					certOrg = value;
				}
			}

			[JsonProperty(PropertyName = "DomainName")]
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
		}
	}
}
