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

namespace Aliyun.Acs.Cdn.Model.V20180510
{
	public class DescribeCdnHttpsDomainListResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeCdnHttpsDomainList_CertInfo> certInfos;

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

		public List<DescribeCdnHttpsDomainList_CertInfo> CertInfos
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

		public class DescribeCdnHttpsDomainList_CertInfo
		{

			private string certCommonName;

			private string certName;

			private string certStartTime;

			private string certExpireTime;

			private string certStatus;

			private string certType;

			private string domainName;

			private string certUpdateTime;

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
		}
	}
}
