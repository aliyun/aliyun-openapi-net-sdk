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

namespace Aliyun.Acs.Domain.Model.V20160511
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

			private string saleId;

			private string deadDate;

			private string regDate;

			private string domainAuditStatus;

			private string domainRegType;

			private string groupId;

			private string domainType;

			private string domainStatus;

			private string deadDateStatus;

			private string productId;

			private long? deadDateLong;

			private long? regDateLong;

			private string remark;

			private bool? premium;

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

			public string SaleId
			{
				get
				{
					return saleId;
				}
				set	
				{
					saleId = value;
				}
			}

			public string DeadDate
			{
				get
				{
					return deadDate;
				}
				set	
				{
					deadDate = value;
				}
			}

			public string RegDate
			{
				get
				{
					return regDate;
				}
				set	
				{
					regDate = value;
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

			public string DomainRegType
			{
				get
				{
					return domainRegType;
				}
				set	
				{
					domainRegType = value;
				}
			}

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
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

			public string DeadDateStatus
			{
				get
				{
					return deadDateStatus;
				}
				set	
				{
					deadDateStatus = value;
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

			public long? DeadDateLong
			{
				get
				{
					return deadDateLong;
				}
				set	
				{
					deadDateLong = value;
				}
			}

			public long? RegDateLong
			{
				get
				{
					return regDateLong;
				}
				set	
				{
					regDateLong = value;
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
		}
	}
}