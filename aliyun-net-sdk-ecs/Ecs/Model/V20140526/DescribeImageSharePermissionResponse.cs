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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeImageSharePermissionResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private string imageId;

		private List<DescribeImageSharePermission_ShareGroup> shareGroups;

		private List<DescribeImageSharePermission_Account> accounts;

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

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
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

		public string ImageId
		{
			get
			{
				return imageId;
			}
			set	
			{
				imageId = value;
			}
		}

		public List<DescribeImageSharePermission_ShareGroup> ShareGroups
		{
			get
			{
				return shareGroups;
			}
			set	
			{
				shareGroups = value;
			}
		}

		public List<DescribeImageSharePermission_Account> Accounts
		{
			get
			{
				return accounts;
			}
			set	
			{
				accounts = value;
			}
		}

		public class DescribeImageSharePermission_ShareGroup
		{

			private string group;

			public string Group
			{
				get
				{
					return group;
				}
				set	
				{
					group = value;
				}
			}
		}

		public class DescribeImageSharePermission_Account
		{

			private string aliyunId;

			public string AliyunId
			{
				get
				{
					return aliyunId;
				}
				set	
				{
					aliyunId = value;
				}
			}
		}
	}
}
