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

namespace Aliyun.Acs.Cdn.Model.V20180510
{
	public class DescribeCdnWafDomainResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private List<DescribeCdnWafDomain_OutPutDomain> outPutDomains;

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

		public List<DescribeCdnWafDomain_OutPutDomain> OutPutDomains
		{
			get
			{
				return outPutDomains;
			}
			set	
			{
				outPutDomains = value;
			}
		}

		public class DescribeCdnWafDomain_OutPutDomain
		{

			private string aclStatus;

			private string status;

			private string domain;

			private string ccStatus;

			private string wafStatus;

			public string AclStatus
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

			public string CcStatus
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

			public string WafStatus
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
		}
	}
}
