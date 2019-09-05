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

namespace Aliyun.Acs.Slb.Model.V20140515
{
	public class DescribeAccessControlListsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? count;

		private int? pageNumber;

		private List<DescribeAccessControlLists_Acl> acls;

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

		public List<DescribeAccessControlLists_Acl> Acls
		{
			get
			{
				return acls;
			}
			set	
			{
				acls = value;
			}
		}

		public class DescribeAccessControlLists_Acl
		{

			private string aclId;

			private string aclName;

			private string addressIPVersion;

			private string resourceGroupId;

			private List<DescribeAccessControlLists_Tag> tags;

			public string AclId
			{
				get
				{
					return aclId;
				}
				set	
				{
					aclId = value;
				}
			}

			public string AclName
			{
				get
				{
					return aclName;
				}
				set	
				{
					aclName = value;
				}
			}

			public string AddressIPVersion
			{
				get
				{
					return addressIPVersion;
				}
				set	
				{
					addressIPVersion = value;
				}
			}

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
				}
			}

			public List<DescribeAccessControlLists_Tag> Tags
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

			public class DescribeAccessControlLists_Tag
			{

				private string tagKey;

				private string tagValue;

				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}
			}
		}
	}
}
