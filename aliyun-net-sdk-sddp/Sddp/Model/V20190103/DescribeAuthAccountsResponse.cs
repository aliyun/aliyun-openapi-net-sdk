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

namespace Aliyun.Acs.Sddp.Model.V20190103
{
	public class DescribeAuthAccountsResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeAuthAccounts_Account> items;

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

		public List<DescribeAuthAccounts_Account> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeAuthAccounts_Account
		{

			private long? id;

			private string loginName;

			private string fullName;

			private string authLoginName;

			private string authFullName;

			private long? authTime;

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

			public string LoginName
			{
				get
				{
					return loginName;
				}
				set	
				{
					loginName = value;
				}
			}

			public string FullName
			{
				get
				{
					return fullName;
				}
				set	
				{
					fullName = value;
				}
			}

			public string AuthLoginName
			{
				get
				{
					return authLoginName;
				}
				set	
				{
					authLoginName = value;
				}
			}

			public string AuthFullName
			{
				get
				{
					return authFullName;
				}
				set	
				{
					authFullName = value;
				}
			}

			public long? AuthTime
			{
				get
				{
					return authTime;
				}
				set	
				{
					authTime = value;
				}
			}
		}
	}
}
