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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeImageSharePermissionResponse : AcsResponse
	{

		private string regionId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private string imageId;

		private List<ShareGroup> shareGroups;

		private List<Account> accounts;

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

		public List<ShareGroup> ShareGroups
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

		public List<Account> Accounts
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

		public class ShareGroup{

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

		public class Account{

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