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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class QueryUserGroupListByParentIdResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private List<QueryUserGroupListByParentId_Data> result;

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

		public List<QueryUserGroupListByParentId_Data> Result
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

		public class QueryUserGroupListByParentId_Data
		{

			private string identifiedPath;

			private string modifiedTime;

			private string createUser;

			private string createTime;

			private string userGroupId;

			private string userGroupName;

			private string modifyUser;

			private string parentUserGroupId;

			private string userGroupDescription;

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

			public string UserGroupId
			{
				get
				{
					return userGroupId;
				}
				set	
				{
					userGroupId = value;
				}
			}

			public string UserGroupName
			{
				get
				{
					return userGroupName;
				}
				set	
				{
					userGroupName = value;
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

			public string ParentUserGroupId
			{
				get
				{
					return parentUserGroupId;
				}
				set	
				{
					parentUserGroupId = value;
				}
			}

			public string UserGroupDescription
			{
				get
				{
					return userGroupDescription;
				}
				set	
				{
					userGroupDescription = value;
				}
			}
		}
	}
}
