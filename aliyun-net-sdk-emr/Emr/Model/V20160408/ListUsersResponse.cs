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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class ListUsersResponse : AcsResponse
	{

		private string requestId;

		private List<ListUsers_User> userList;

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

		public List<ListUsers_User> UserList
		{
			get
			{
				return userList;
			}
			set	
			{
				userList = value;
			}
		}

		public class ListUsers_User
		{

			private string userName;

			private string groupName;

			private string userId;

			private string knoxStatus;

			private string linuxStatus;

			private string kerberosStatus;

			private string k8sStatus;

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

			public string KnoxStatus
			{
				get
				{
					return knoxStatus;
				}
				set	
				{
					knoxStatus = value;
				}
			}

			public string LinuxStatus
			{
				get
				{
					return linuxStatus;
				}
				set	
				{
					linuxStatus = value;
				}
			}

			public string KerberosStatus
			{
				get
				{
					return kerberosStatus;
				}
				set	
				{
					kerberosStatus = value;
				}
			}

			public string K8sStatus
			{
				get
				{
					return k8sStatus;
				}
				set	
				{
					k8sStatus = value;
				}
			}
		}
	}
}
