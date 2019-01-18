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

namespace Aliyun.Acs.Ram.Model.V20150501
{
	public class ListEntitiesForPolicyResponse : AcsResponse
	{

		private string requestId;

		private List<ListEntitiesForPolicy_Group> groups;

		private List<ListEntitiesForPolicy_User> users;

		private List<ListEntitiesForPolicy_Role> roles;

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

		public List<ListEntitiesForPolicy_Group> Groups
		{
			get
			{
				return groups;
			}
			set	
			{
				groups = value;
			}
		}

		public List<ListEntitiesForPolicy_User> Users
		{
			get
			{
				return users;
			}
			set	
			{
				users = value;
			}
		}

		public List<ListEntitiesForPolicy_Role> Roles
		{
			get
			{
				return roles;
			}
			set	
			{
				roles = value;
			}
		}

		public class ListEntitiesForPolicy_Group
		{

			private string groupName;

			private string comments;

			private string attachDate;

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

			public string Comments
			{
				get
				{
					return comments;
				}
				set	
				{
					comments = value;
				}
			}

			public string AttachDate
			{
				get
				{
					return attachDate;
				}
				set	
				{
					attachDate = value;
				}
			}
		}

		public class ListEntitiesForPolicy_User
		{

			private string userId;

			private string userName;

			private string displayName;

			private string attachDate;

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

			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
				}
			}

			public string DisplayName
			{
				get
				{
					return displayName;
				}
				set	
				{
					displayName = value;
				}
			}

			public string AttachDate
			{
				get
				{
					return attachDate;
				}
				set	
				{
					attachDate = value;
				}
			}
		}

		public class ListEntitiesForPolicy_Role
		{

			private string roleId;

			private string roleName;

			private string arn;

			private string description;

			private string attachDate;

			public string RoleId
			{
				get
				{
					return roleId;
				}
				set	
				{
					roleId = value;
				}
			}

			public string RoleName
			{
				get
				{
					return roleName;
				}
				set	
				{
					roleName = value;
				}
			}

			public string Arn
			{
				get
				{
					return arn;
				}
				set	
				{
					arn = value;
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

			public string AttachDate
			{
				get
				{
					return attachDate;
				}
				set	
				{
					attachDate = value;
				}
			}
		}
	}
}