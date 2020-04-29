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
	public class DescribeDcdnDomainByCertificateResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDcdnDomainByCertificate_CertInfo> certInfos;

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

		public List<DescribeDcdnDomainByCertificate_CertInfo> CertInfos
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

		public class DescribeDcdnDomainByCertificate_CertInfo
		{

			private string issuer;

			private string certType;

			private string certSubjectCommonName;

			private string certExpireTime;

			private string certStartTime;

			private string domainNames;

			private string domainList;

			private string certExpired;

			private string certCaIsLegacy;

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
		}
	}
}
