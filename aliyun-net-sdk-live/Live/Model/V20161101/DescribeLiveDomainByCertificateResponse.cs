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
	public class DescribeLiveDomainByCertificateResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveDomainByCertificate_CertInfo> certInfos;

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
		public List<DescribeLiveDomainByCertificate_CertInfo> CertInfos
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

		public class DescribeLiveDomainByCertificate_CertInfo
		{

			private string certExpireTime;

			private string certStartTime;

			private string certType;

			private string certSubjectCommonName;

			private string certCaIsLegacy;

			private string domainNames;

			private string certExpired;

			private string issuer;

			private string domainList;

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

			[JsonProperty(PropertyName = "CertStartTime")]
			public string CertStartTime
			{
				get
				{
					return certStartTime;
				}
				set	
				{
					certStartTime = value;
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

			[JsonProperty(PropertyName = "CertSubjectCommonName")]
			public string CertSubjectCommonName
			{
				get
				{
					return certSubjectCommonName;
				}
				set	
				{
					certSubjectCommonName = value;
				}
			}

			[JsonProperty(PropertyName = "CertCaIsLegacy")]
			public string CertCaIsLegacy
			{
				get
				{
					return certCaIsLegacy;
				}
				set	
				{
					certCaIsLegacy = value;
				}
			}

			[JsonProperty(PropertyName = "DomainNames")]
			public string DomainNames
			{
				get
				{
					return domainNames;
				}
				set	
				{
					domainNames = value;
				}
			}

			[JsonProperty(PropertyName = "CertExpired")]
			public string CertExpired
			{
				get
				{
					return certExpired;
				}
				set	
				{
					certExpired = value;
				}
			}

			[JsonProperty(PropertyName = "Issuer")]
			public string Issuer
			{
				get
				{
					return issuer;
				}
				set	
				{
					issuer = value;
				}
			}

			[JsonProperty(PropertyName = "DomainList")]
			public string DomainList
			{
				get
				{
					return domainList;
				}
				set	
				{
					domainList = value;
				}
			}
		}
	}
}
