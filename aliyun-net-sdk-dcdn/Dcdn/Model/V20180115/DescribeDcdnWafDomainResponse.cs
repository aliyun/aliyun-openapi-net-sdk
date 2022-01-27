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
	public class DescribeDcdnWafDomainResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeDcdnWafDomain_OutPutDomain> outPutDomains;

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

		public List<DescribeDcdnWafDomain_OutPutDomain> OutPutDomains
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

		public class DescribeDcdnWafDomain_OutPutDomain
		{

			private int? status;

			private string domain;

			private int? wafStatus;

			private int? ccStatus;

			private int? aclStatus;

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
		}
	}
}
