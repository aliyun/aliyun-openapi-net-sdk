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

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class QueryIntlFixedPriceOrderListResponse : AcsResponse
	{

		private string requestId;

		private QueryIntlFixedPriceOrderList_Module module;

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

		public QueryIntlFixedPriceOrderList_Module Module
		{
			get
			{
				return module;
			}
			set	
			{
				module = value;
			}
		}

		public class QueryIntlFixedPriceOrderList_Module
		{

			private int? totalItemNum;

			private int? currentPageNum;

			private int? pageSize;

			private int? totalPageNum;

			private List<QueryIntlFixedPriceOrderList_OrderList> data;

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

			public List<QueryIntlFixedPriceOrderList_OrderList> Data
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

			public class QueryIntlFixedPriceOrderList_OrderList
			{

				private int? orderType;

				private string bizId;

				private string userId;

				private int? status;

				private long? price;

				private string domain;

				private long? createTime;

				private long? updateTime;

				public int? OrderType
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

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

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

				public long? Price
				{
					get
					{
						return price;
					}
					set	
					{
						price = value;
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

				public long? CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
					}
				}

				public long? UpdateTime
				{
					get
					{
						return updateTime;
					}
					set	
					{
						updateTime = value;
					}
				}
			}
		}
	}
}
