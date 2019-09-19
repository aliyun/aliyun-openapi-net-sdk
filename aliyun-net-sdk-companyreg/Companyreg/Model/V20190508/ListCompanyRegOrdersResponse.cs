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

namespace Aliyun.Acs.companyreg.Model.V20190508
{
	public class ListCompanyRegOrdersResponse : AcsResponse
	{

		private string requestId;

		private int? totalItemNum;

		private int? currentPageNum;

		private int? pageSize;

		private int? totalPageNum;

		private bool? prePage;

		private bool? nextPage;

		private List<ListCompanyRegOrders_CompanyRegOrder> data;

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

		public List<ListCompanyRegOrders_CompanyRegOrder> Data
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

		public class ListCompanyRegOrders_CompanyRegOrder
		{

			private string bizId;

			private string companyName;

			private string bizStatus;

			private string bizInfo;

			private string supplementBizInfo;

			private string aliyunOrderId;

			private long? gmtModified;

			private string extend;

			private string bizSubCode;

			public string BizId
			{
				get
				{
					return bizId;
				}
				set	
				{
					bizId = value;
				}
			}

			public string CompanyName
			{
				get
				{
					return companyName;
				}
				set	
				{
					companyName = value;
				}
			}

			public string BizStatus
			{
				get
				{
					return bizStatus;
				}
				set	
				{
					bizStatus = value;
				}
			}

			public string BizInfo
			{
				get
				{
					return bizInfo;
				}
				set	
				{
					bizInfo = value;
				}
			}

			public string SupplementBizInfo
			{
				get
				{
					return supplementBizInfo;
				}
				set	
				{
					supplementBizInfo = value;
				}
			}

			public string AliyunOrderId
			{
				get
				{
					return aliyunOrderId;
				}
				set	
				{
					aliyunOrderId = value;
				}
			}

			public long? GmtModified
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

			public string Extend
			{
				get
				{
					return extend;
				}
				set	
				{
					extend = value;
				}
			}

			public string BizSubCode
			{
				get
				{
					return bizSubCode;
				}
				set	
				{
					bizSubCode = value;
				}
			}
		}
	}
}
