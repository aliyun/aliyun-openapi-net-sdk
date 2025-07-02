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

namespace Aliyun.Acs.eds_user.Model.V20210308
{
	public class DescribeGroupUserResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeGroupUser_Group> groups;

		private List<DescribeGroupUser_User> users;

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

		public List<DescribeGroupUser_Group> Groups
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

		public List<DescribeGroupUser_User> Users
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

		public class DescribeGroupUser_Group
		{

			private string groupName;

			private string groupId;

			private string userCount;

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

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string UserCount
			{
				get
				{
					return userCount;
				}
				set	
				{
					userCount = value;
				}
			}
		}

		public class DescribeGroupUser_User
		{

			private string endUserId;

			private string avatar;

			private string address;

			private string phone;

			private string email;

			private string nickName;

			private string jobNumber;

			private string gmtJoinGroup;

			private string gmtCreated;

			public string EndUserId
			{
				get
				{
					return endUserId;
				}
				set	
				{
					endUserId = value;
				}
			}

			public string Avatar
			{
				get
				{
					return avatar;
				}
				set	
				{
					avatar = value;
				}
			}

			public string Address
			{
				get
				{
					return address;
				}
				set	
				{
					address = value;
				}
			}

			public string Phone
			{
				get
				{
					return phone;
				}
				set	
				{
					phone = value;
				}
			}

			public string Email
			{
				get
				{
					return email;
				}
				set	
				{
					email = value;
				}
			}

			public string NickName
			{
				get
				{
					return nickName;
				}
				set	
				{
					nickName = value;
				}
			}

			public string JobNumber
			{
				get
				{
					return jobNumber;
				}
				set	
				{
					jobNumber = value;
				}
			}

			public string GmtJoinGroup
			{
				get
				{
					return gmtJoinGroup;
				}
				set	
				{
					gmtJoinGroup = value;
				}
			}

			public string GmtCreated
			{
				get
				{
					return gmtCreated;
				}
				set	
				{
					gmtCreated = value;
				}
			}
		}
	}
}
