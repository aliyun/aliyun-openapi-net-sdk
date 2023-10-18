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
	public class DescribeLiveHttpsDomainListResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private List<DescribeLiveHttpsDomainList_CertInfo> certInfos;

		[JsonProperty(PropertyName = "TotalCount")]
		public int? TotalCount
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
		public List<DescribeLiveHttpsDomainList_CertInfo> CertInfos
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

		public class DescribeLiveHttpsDomainList_CertInfo
		{

			private string certStartTime;

			private string certExpireTime;

			private string certUpdateTime;

			private string certType;

			private string certName;

			private string certStatus;

			private string domainName;

			private string certCommonName;

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

			[JsonProperty(PropertyName = "CertUpdateTime")]
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

			[JsonProperty(PropertyName = "CertStatus")]
			public string CertStatus
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

			[JsonProperty(PropertyName = "CertCommonName")]
			public string CertCommonName
			{
				get
				{
					return certCommonName;
				}
				set	
				{
					certCommonName = value;
				}
			}
		}
	}
}
