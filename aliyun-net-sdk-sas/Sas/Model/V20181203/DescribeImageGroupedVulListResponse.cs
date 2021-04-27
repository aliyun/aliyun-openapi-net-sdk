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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeImageGroupedVulListResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeImageGroupedVulList_GroupedVulItem> groupedVulItems;

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

		public List<DescribeImageGroupedVulList_GroupedVulItem> GroupedVulItems
		{
			get
			{
				return groupedVulItems;
			}
			set	
			{
				groupedVulItems = value;
			}
		}

		public class DescribeImageGroupedVulList_GroupedVulItem
		{

			private string name;

			private string aliasName;

			private string type;

			private int? status;

			private long? lastScanTime;

			private long? gmtLast;

			private int? asapCount;

			private int? laterCount;

			private int? nntfCount;

			private string tags;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string AliasName
			{
				get
				{
					return aliasName;
				}
				set	
				{
					aliasName = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
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

			public long? LastScanTime
			{
				get
				{
					return lastScanTime;
				}
				set	
				{
					lastScanTime = value;
				}
			}

			public long? GmtLast
			{
				get
				{
					return gmtLast;
				}
				set	
				{
					gmtLast = value;
				}
			}

			public int? AsapCount
			{
				get
				{
					return asapCount;
				}
				set	
				{
					asapCount = value;
				}
			}

			public int? LaterCount
			{
				get
				{
					return laterCount;
				}
				set	
				{
					laterCount = value;
				}
			}

			public int? NntfCount
			{
				get
				{
					return nntfCount;
				}
				set	
				{
					nntfCount = value;
				}
			}

			public string Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}
		}
	}
}
