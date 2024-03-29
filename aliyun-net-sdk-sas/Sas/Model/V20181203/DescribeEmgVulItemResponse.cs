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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeEmgVulItemResponse : AcsResponse
	{

		private int? currentPage;

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeEmgVulItem_GroupedVulItem> groupedVulItems;

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

		public List<DescribeEmgVulItem_GroupedVulItem> GroupedVulItems
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

		public class DescribeEmgVulItem_GroupedVulItem
		{

			private int? status;

			private string type;

			private int? checkType;

			private long? gmtLastCheck;

			private int? progress;

			private string description;

			private long? gmtPublish;

			private int? pendingCount;

			private string aliasName;

			private string name;

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

			public int? CheckType
			{
				get
				{
					return checkType;
				}
				set	
				{
					checkType = value;
				}
			}

			public long? GmtLastCheck
			{
				get
				{
					return gmtLastCheck;
				}
				set	
				{
					gmtLastCheck = value;
				}
			}

			public int? Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public long? GmtPublish
			{
				get
				{
					return gmtPublish;
				}
				set	
				{
					gmtPublish = value;
				}
			}

			public int? PendingCount
			{
				get
				{
					return pendingCount;
				}
				set	
				{
					pendingCount = value;
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
		}
	}
}
