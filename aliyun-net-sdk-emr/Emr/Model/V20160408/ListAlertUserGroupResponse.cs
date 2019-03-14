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
	public class ListAlertUserGroupResponse : AcsResponse
	{

		private List<ListAlertUserGroup_Group> alertUserGroupList;

		public List<ListAlertUserGroup_Group> AlertUserGroupList
		{
			get
			{
				return alertUserGroupList;
			}
			set	
			{
				alertUserGroupList = value;
			}
		}

		public class ListAlertUserGroup_Group
		{

			private long? id;

			private string gmtCreate;

			private string gmtModified;

			private string bizId;

			private string name;

			private string description;

			private List<ListAlertUserGroup_UserInfo> userList;

			public long? Id
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

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string BizId
			{
				get
				{
					return bizId;
				}
				set	
				{
					bizId = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
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

			public List<ListAlertUserGroup_UserInfo> UserList
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

			public class ListAlertUserGroup_UserInfo
			{

				private string userId;

				private string userName;

				private bool? enableSMS;

				private bool? enableEmail;

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

				public bool? EnableSMS
				{
					get
					{
						return enableSMS;
					}
					set	
					{
						enableSMS = value;
					}
				}

				public bool? EnableEmail
				{
					get
					{
						return enableEmail;
					}
					set	
					{
						enableEmail = value;
					}
				}
			}
		}
	}
}
