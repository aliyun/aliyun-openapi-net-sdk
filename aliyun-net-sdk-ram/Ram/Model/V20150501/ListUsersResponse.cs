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

namespace Aliyun.Acs.Ram.Model.V20150501
{
	public class ListUsersResponse : AcsResponse
	{

		private string requestId;

		private bool? isTruncated;

		private string marker;

		private List<ListUsers_User> users;

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

		public bool? IsTruncated
		{
			get
			{
				return isTruncated;
			}
			set	
			{
				isTruncated = value;
			}
		}

		public string Marker
		{
			get
			{
				return marker;
			}
			set	
			{
				marker = value;
			}
		}

		public List<ListUsers_User> Users
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

		public class ListUsers_User
		{

			private string displayName;

			private string email;

			private string updateDate;

			private string mobilePhone;

			private string userId;

			private string comments;

			private string createDate;

			private string userName;

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

			public string UpdateDate
			{
				get
				{
					return updateDate;
				}
				set	
				{
					updateDate = value;
				}
			}

			public string MobilePhone
			{
				get
				{
					return mobilePhone;
				}
				set	
				{
					mobilePhone = value;
				}
			}

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

			public string CreateDate
			{
				get
				{
					return createDate;
				}
				set	
				{
					createDate = value;
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
		}
	}
}
