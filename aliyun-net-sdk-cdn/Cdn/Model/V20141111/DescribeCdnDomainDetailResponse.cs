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
	public class DescribeCdnDomainDetailResponse : AcsResponse
	{

		private GetDomainDetailModel_ getDomainDetailModel;

		public GetDomainDetailModel_ GetDomainDetailModel
		{
			get
			{
				return getDomainDetailModel;
			}
			set	
			{
				getDomainDetailModel = value;
			}
		}

		public class GetDomainDetailModel_{

			private string gmtCreated;

			private string gmtModified;

			private string sourceType;

			private string domainStatus;

			private int? sourcePort;

			private string cdnType;

			private string cname;

			private string httpsCname;

			private string domainName;

			private string description;

			private string serverCertificateStatus;

			private string serverCertificate;

			private string scope;

			private string certificateName;

			private List<string> sources;

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

			public string SourceType
			{
				get
				{
					return sourceType;
				}
				set	
				{
					sourceType = value;
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

			public int? SourcePort
			{
				get
				{
					return sourcePort;
				}
				set	
				{
					sourcePort = value;
				}
			}

			public string CdnType
			{
				get
				{
					return cdnType;
				}
				set	
				{
					cdnType = value;
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

			public string HttpsCname
			{
				get
				{
					return httpsCname;
				}
				set	
				{
					httpsCname = value;
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

			public string CertificateName
			{
				get
				{
					return certificateName;
				}
				set	
				{
					certificateName = value;
				}
			}

			public List<string> Sources
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
		}
	}
}