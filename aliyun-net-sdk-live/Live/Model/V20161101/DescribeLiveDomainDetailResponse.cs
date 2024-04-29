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
	public class DescribeLiveDomainDetailResponse : AcsResponse
	{

		private string requestId;

		private DescribeLiveDomainDetail_DomainDetail domainDetail;

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

		[JsonProperty(PropertyName = "DomainDetail")]
		public DescribeLiveDomainDetail_DomainDetail DomainDetail
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

		public class DescribeLiveDomainDetail_DomainDetail
		{

			private string certName;

			private string cname;

			private string description;

			private string domainName;

			private string domainStatus;

			private string gmtCreated;

			private string gmtModified;

			private string liveDomainType;

			private string region;

			private string sSLProtocol;

			private string sSLPub;

			private string scope;

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

			[JsonProperty(PropertyName = "Cname")]
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

			[JsonProperty(PropertyName = "Description")]
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

			[JsonProperty(PropertyName = "DomainStatus")]
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

			[JsonProperty(PropertyName = "GmtCreated")]
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

			[JsonProperty(PropertyName = "GmtModified")]
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

			[JsonProperty(PropertyName = "LiveDomainType")]
			public string LiveDomainType
			{
				get
				{
					return liveDomainType;
				}
				set	
				{
					liveDomainType = value;
				}
			}

			[JsonProperty(PropertyName = "Region")]
			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
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

			[JsonProperty(PropertyName = "Scope")]
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
		}
	}
}
