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

namespace Aliyun.Acs.Domain_intl.Model.V20171218
{
	public class QueryDomainListResponse : AcsResponse
	{

		private string requestId;

		private int? totalItemNum;

		private int? currentPageNum;

		private int? totalPageNum;

		private int? pageSize;

		private bool? prePage;

		private bool? nextPage;

		private List<QueryDomainList_Domain> data;

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

		public int? TotalItemNum
		{
			get
			{
				return totalItemNum;
			}
			set	
			{
				totalItemNum = value;
			}
		}

		public int? CurrentPageNum
		{
			get
			{
				return currentPageNum;
			}
			set	
			{
				currentPageNum = value;
			}
		}

		public int? TotalPageNum
		{
			get
			{
				return totalPageNum;
			}
			set	
			{
				totalPageNum = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public bool? PrePage
		{
			get
			{
				return prePage;
			}
			set	
			{
				prePage = value;
			}
		}

		public bool? NextPage
		{
			get
			{
				return nextPage;
			}
			set	
			{
				nextPage = value;
			}
		}

		public List<QueryDomainList_Domain> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class QueryDomainList_Domain
		{

			private string domainName;

			private string instanceId;

			private string expirationDate;

			private string registrationDate;

			private string domainType;

			private string domainStatus;

			private string productId;

			private long? expirationDateLong;

			private long? registrationDateLong;

			private bool? premium;

			private string domainAuditStatus;

			private string expirationDateStatus;

			private string registrantType;

			private string remark;

			private int? expirationCurrDateDiff;

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

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string ExpirationDate
			{
				get
				{
					return expirationDate;
				}
				set	
				{
					expirationDate = value;
				}
			}

			public string RegistrationDate
			{
				get
				{
					return registrationDate;
				}
				set	
				{
					registrationDate = value;
				}
			}

			public string DomainType
			{
				get
				{
					return domainType;
				}
				set	
				{
					domainType = value;
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

			public string ProductId
			{
				get
				{
					return productId;
				}
				set	
				{
					productId = value;
				}
			}

			public long? ExpirationDateLong
			{
				get
				{
					return expirationDateLong;
				}
				set	
				{
					expirationDateLong = value;
				}
			}

			public long? RegistrationDateLong
			{
				get
				{
					return registrationDateLong;
				}
				set	
				{
					registrationDateLong = value;
				}
			}

			public bool? Premium
			{
				get
				{
					return premium;
				}
				set	
				{
					premium = value;
				}
			}

			public string DomainAuditStatus
			{
				get
				{
					return domainAuditStatus;
				}
				set	
				{
					domainAuditStatus = value;
				}
			}

			public string ExpirationDateStatus
			{
				get
				{
					return expirationDateStatus;
				}
				set	
				{
					expirationDateStatus = value;
				}
			}

			public string RegistrantType
			{
				get
				{
					return registrantType;
				}
				set	
				{
					registrantType = value;
				}
			}

			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}

			public int? ExpirationCurrDateDiff
			{
				get
				{
					return expirationCurrDateDiff;
				}
				set	
				{
					expirationCurrDateDiff = value;
				}
			}
		}
	}
}
