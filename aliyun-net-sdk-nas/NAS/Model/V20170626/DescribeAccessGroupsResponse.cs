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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class DescribeAccessGroupsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribeAccessGroups_AccessGroup> accessGroups;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public List<DescribeAccessGroups_AccessGroup> AccessGroups
		{
			get
			{
				return accessGroups;
			}
			set	
			{
				accessGroups = value;
			}
		}

		public class DescribeAccessGroups_AccessGroup
		{

			private string accessGroupName;

			private string accessGroupType;

			private int? ruleCount;

			private int? mountTargetCount;

			private string description;

			public string AccessGroupName
			{
				get
				{
					return accessGroupName;
				}
				set	
				{
					accessGroupName = value;
				}
			}

			public string AccessGroupType
			{
				get
				{
					return accessGroupType;
				}
				set	
				{
					accessGroupType = value;
				}
			}

			public int? RuleCount
			{
				get
				{
					return ruleCount;
				}
				set	
				{
					ruleCount = value;
				}
			}

			public int? MountTargetCount
			{
				get
				{
					return mountTargetCount;
				}
				set	
				{
					mountTargetCount = value;
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
		}
	}
}