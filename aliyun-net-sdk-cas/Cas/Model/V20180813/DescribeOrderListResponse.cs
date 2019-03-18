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

namespace Aliyun.Acs.cas.Model.V20180813
{
	public class DescribeOrderListResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? showSize;

		private int? currentPage;

		private List<DescribeOrderList_Order> orderList;

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

		public int? ShowSize
		{
			get
			{
				return showSize;
			}
			set	
			{
				showSize = value;
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
			}
		}

		public List<DescribeOrderList_Order> OrderList
		{
			get
			{
				return orderList;
			}
			set	
			{
				orderList = value;
			}
		}

		public class DescribeOrderList_Order
		{

			private long? id;

			private string sourceType;

			private string certType;

			private string instanceId;

			private long? year;

			private long? orderId;

			private string orderType;

			private string brandName;

			private long? buyDate;

			private string statusCode;

			private string domain;

			private string productAliasName;

			private int? domainCount;

			private int? wildDomainCount;

			private int? verifyStatus;

			private long? maybeIssueDate;

			private long? beforeDate;

			private long? afterDate;

			private bool? showCancel;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
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

			public long? Year
			{
				get
				{
					return year;
				}
				set	
				{
					year = value;
				}
			}

			public long? OrderId
			{
				get
				{
					return orderId;
				}
				set	
				{
					orderId = value;
				}
			}

			public string OrderType
			{
				get
				{
					return orderType;
				}
				set	
				{
					orderType = value;
				}
			}

			public string BrandName
			{
				get
				{
					return brandName;
				}
				set	
				{
					brandName = value;
				}
			}

			public long? BuyDate
			{
				get
				{
					return buyDate;
				}
				set	
				{
					buyDate = value;
				}
			}

			public string StatusCode
			{
				get
				{
					return statusCode;
				}
				set	
				{
					statusCode = value;
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

			public string ProductAliasName
			{
				get
				{
					return productAliasName;
				}
				set	
				{
					productAliasName = value;
				}
			}

			public int? DomainCount
			{
				get
				{
					return domainCount;
				}
				set	
				{
					domainCount = value;
				}
			}

			public int? WildDomainCount
			{
				get
				{
					return wildDomainCount;
				}
				set	
				{
					wildDomainCount = value;
				}
			}

			public int? VerifyStatus
			{
				get
				{
					return verifyStatus;
				}
				set	
				{
					verifyStatus = value;
				}
			}

			public long? MaybeIssueDate
			{
				get
				{
					return maybeIssueDate;
				}
				set	
				{
					maybeIssueDate = value;
				}
			}

			public long? BeforeDate
			{
				get
				{
					return beforeDate;
				}
				set	
				{
					beforeDate = value;
				}
			}

			public long? AfterDate
			{
				get
				{
					return afterDate;
				}
				set	
				{
					afterDate = value;
				}
			}

			public bool? ShowCancel
			{
				get
				{
					return showCancel;
				}
				set	
				{
					showCancel = value;
				}
			}
		}
	}
}
