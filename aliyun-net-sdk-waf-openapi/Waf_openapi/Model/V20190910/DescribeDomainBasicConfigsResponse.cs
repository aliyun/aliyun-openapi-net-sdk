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

namespace Aliyun.Acs.waf_openapi.Model.V20190910
{
	public class DescribeDomainBasicConfigsResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private List<DescribeDomainBasicConfigs_DomainConfig> domainConfigs;

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

		public List<DescribeDomainBasicConfigs_DomainConfig> DomainConfigs
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

		public class DescribeDomainBasicConfigs_DomainConfig
		{

			private int? status;

			private string domain;

			private string owner;

			private int? ccMode;

			private int? ccStatus;

			private string accessType;

			private long? version;

			private int? aclStatus;

			private int? wafStatus;

			private int? wafMode;

			public int? Status
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

			public string Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
				}
			}

			public int? CcMode
			{
				get
				{
					return ccMode;
				}
				set	
				{
					ccMode = value;
				}
			}

			public int? CcStatus
			{
				get
				{
					return ccStatus;
				}
				set	
				{
					ccStatus = value;
				}
			}

			public string AccessType
			{
				get
				{
					return accessType;
				}
				set	
				{
					accessType = value;
				}
			}

			public long? Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}

			public int? AclStatus
			{
				get
				{
					return aclStatus;
				}
				set	
				{
					aclStatus = value;
				}
			}

			public int? WafStatus
			{
				get
				{
					return wafStatus;
				}
				set	
				{
					wafStatus = value;
				}
			}

			public int? WafMode
			{
				get
				{
					return wafMode;
				}
				set	
				{
					wafMode = value;
				}
			}
		}
	}
}
