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

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeUsageBillResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? currentPage;

		private List<DescribeUsageBill_Bill> billList;

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

		public List<DescribeUsageBill_Bill> BillList
		{
			get
			{
				return billList;
			}
			set	
			{
				billList = value;
			}
		}

		public class DescribeUsageBill_Bill
		{

			private string region;

			private string scene;

			private long? totalCount;

			private long? confirmCount;

			private long? reviewCount;

			private long? freeCount;

			private string subUid;

			private string bizType;

			private string day;

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public string Scene
			{
				get
				{
					return scene;
				}
				set	
				{
					scene = value;
				}
			}

			public long? TotalCount
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

			public long? ConfirmCount
			{
				get
				{
					return confirmCount;
				}
				set	
				{
					confirmCount = value;
				}
			}

			public long? ReviewCount
			{
				get
				{
					return reviewCount;
				}
				set	
				{
					reviewCount = value;
				}
			}

			public long? FreeCount
			{
				get
				{
					return freeCount;
				}
				set	
				{
					freeCount = value;
				}
			}

			public string SubUid
			{
				get
				{
					return subUid;
				}
				set	
				{
					subUid = value;
				}
			}

			public string BizType
			{
				get
				{
					return bizType;
				}
				set	
				{
					bizType = value;
				}
			}

			public string Day
			{
				get
				{
					return day;
				}
				set	
				{
					day = value;
				}
			}
		}
	}
}
