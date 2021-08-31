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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class ListRoleResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private List<ListRole_RoleItem> roleList;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public List<ListRole_RoleItem> RoleList
		{
			get
			{
				return roleList;
			}
			set	
			{
				roleList = value;
			}
		}

		public class ListRole_RoleItem
		{

			private List<ListRole_Action> actionList;

			private ListRole_Role role;

			public List<ListRole_Action> ActionList
			{
				get
				{
					return actionList;
				}
				set	
				{
					actionList = value;
				}
			}

			public ListRole_Role Role
			{
				get
				{
					return role;
				}
				set	
				{
					role = value;
				}
			}

			public class ListRole_Action
			{

				private string groupId;

				private string code;

				private string name;

				private string description;

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

				public string Code
				{
					get
					{
						return code;
					}
					set	
					{
						code = value;
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
			}

			public class ListRole_Role
			{

				private int? id;

				private string adminUserId;

				private string name;

				private long? createTime;

				private long? updateTime;

				private bool? isDefault;

				public int? Id
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

				public string AdminUserId
				{
					get
					{
						return adminUserId;
					}
					set	
					{
						adminUserId = value;
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

				public long? CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
					}
				}

				public long? UpdateTime
				{
					get
					{
						return updateTime;
					}
					set	
					{
						updateTime = value;
					}
				}

				public bool? IsDefault
				{
					get
					{
						return isDefault;
					}
					set	
					{
						isDefault = value;
					}
				}
			}
		}
	}
}
