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
	public class DescribeVodDomainCertificateInfoResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeVodDomainCertificateInfo_CertInfo> certInfos;

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

		public List<DescribeVodDomainCertificateInfo_CertInfo> CertInfos
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

		public class DescribeVodDomainCertificateInfo_CertInfo
		{

			private string certExpireTime;

			private string certLife;

			private string status;

			private string certUpdateTime;

			private string certDomainName;

			private string serverCertificateStatus;

			private string certOrg;

			private string domainName;

			private string certStartTime;

			private string certType;

			private string certName;

			private string domainCnameStatus;

			private string serverCertificate;

			private string certId;

			private string certRegion;

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

			public string CertUpdateTime
			{
				get
				{
					return certUpdateTime;
				}
				set	
				{
					certUpdateTime = value;
				}
			}

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

			public string ServerCertificateStatus
			{
				get
				{
					return serverCertificateStatus;
				}
				set	
				{
					serverCertificateStatus = value;
				}
			}

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

			public string DomainCnameStatus
			{
				get
				{
					return domainCnameStatus;
				}
				set	
				{
					domainCnameStatus = value;
				}
			}

			public string ServerCertificate
			{
				get
				{
					return serverCertificate;
				}
				set	
				{
					serverCertificate = value;
				}
			}

			public string CertId
			{
				get
				{
					return certId;
				}
				set	
				{
					certId = value;
				}
			}

			public string CertRegion
			{
				get
				{
					return certRegion;
				}
				set	
				{
					certRegion = value;
				}
			}
		}
	}
}
