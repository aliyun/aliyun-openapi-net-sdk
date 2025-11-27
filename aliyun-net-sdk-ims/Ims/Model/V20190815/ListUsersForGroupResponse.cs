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

namespace Aliyun.Acs.Ims.Model.V20190815
{
	public class ListUsersForGroupResponse : AcsResponse
	{

		private string requestId;

		private bool? isTruncated;

		private string marker;

		private List<ListUsersForGroup_User> users;

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

		public List<ListUsersForGroup_User> Users
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

		public class ListUsersForGroup_User
		{

			private string userPrincipalName;

			private string displayName;

			private string userId;

			private string joinDate;

			public string UserPrincipalName
			{
				get
				{
					return userPrincipalName;
				}
				set	
				{
					userPrincipalName = value;
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

			public string JoinDate
			{
				get
				{
					return joinDate;
				}
				set	
				{
					joinDate = value;
				}
			}
		}
	}
}
