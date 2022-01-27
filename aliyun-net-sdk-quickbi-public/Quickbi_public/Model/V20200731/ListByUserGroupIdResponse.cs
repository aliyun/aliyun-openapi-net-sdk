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

namespace Aliyun.Acs.quickbi_public.Model.V20200731
{
	public class ListByUserGroupIdResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private ListByUserGroupId_Result result;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public ListByUserGroupId_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class ListByUserGroupId_Result
		{

			private List<ListByUserGroupId_UserGroupModelsItem> userGroupModels;

			private List<string> failedUserGroupIds;

			public List<ListByUserGroupId_UserGroupModelsItem> UserGroupModels
			{
				get
				{
					return userGroupModels;
				}
				set	
				{
					userGroupModels = value;
				}
			}

			public List<string> FailedUserGroupIds
			{
				get
				{
					return failedUserGroupIds;
				}
				set	
				{
					failedUserGroupIds = value;
				}
			}

			public class ListByUserGroupId_UserGroupModelsItem
			{

				private string usergroupId;

				private string usergroupName;

				private string usergroupDesc;

				private string parentUsergroupId;

				private string identifiedPath;

				private string createUser;

				private string modifyUser;

				private string createTime;

				private string modifiedTime;

				public string UsergroupId
				{
					get
					{
						return usergroupId;
					}
					set	
					{
						usergroupId = value;
					}
				}

				public string UsergroupName
				{
					get
					{
						return usergroupName;
					}
					set	
					{
						usergroupName = value;
					}
				}

				public string UsergroupDesc
				{
					get
					{
						return usergroupDesc;
					}
					set	
					{
						usergroupDesc = value;
					}
				}

				public string ParentUsergroupId
				{
					get
					{
						return parentUsergroupId;
					}
					set	
					{
						parentUsergroupId = value;
					}
				}

				public string IdentifiedPath
				{
					get
					{
						return identifiedPath;
					}
					set	
					{
						identifiedPath = value;
					}
				}

				public string CreateUser
				{
					get
					{
						return createUser;
					}
					set	
					{
						createUser = value;
					}
				}

				public string ModifyUser
				{
					get
					{
						return modifyUser;
					}
					set	
					{
						modifyUser = value;
					}
				}

				public string CreateTime
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

				public string ModifiedTime
				{
					get
					{
						return modifiedTime;
					}
					set	
					{
						modifiedTime = value;
					}
				}
			}
		}
	}
}
