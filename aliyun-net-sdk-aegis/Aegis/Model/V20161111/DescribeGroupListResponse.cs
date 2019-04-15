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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeGroupListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<DescribeGroupList_RuleGroupsItem> ruleGroups;

		private DescribeGroupList_PageInfo pageInfo;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<DescribeGroupList_RuleGroupsItem> RuleGroups
		{
			get
			{
				return ruleGroups;
			}
			set	
			{
				ruleGroups = value;
			}
		}

		public DescribeGroupList_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribeGroupList_RuleGroupsItem
		{

			private string groupName;

			private int? ruleNum;

			private long? modified;

			private long? create;

			private string description;

			private int? id;

			private long? aliUid;

			private int? status;

			private string machineGroupIds;

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
				}
			}

			public int? RuleNum
			{
				get
				{
					return ruleNum;
				}
				set	
				{
					ruleNum = value;
				}
			}

			public long? Modified
			{
				get
				{
					return modified;
				}
				set	
				{
					modified = value;
				}
			}

			public long? Create
			{
				get
				{
					return create;
				}
				set	
				{
					create = value;
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

			public int? Id
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

			public long? AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
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

			public string MachineGroupIds
			{
				get
				{
					return machineGroupIds;
				}
				set	
				{
					machineGroupIds = value;
				}
			}
		}

		public class DescribeGroupList_PageInfo
		{

			private int? count;

			private int? pageSize;

			private int? currentPage;

			private int? totalCount;

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
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
		}
	}
}
