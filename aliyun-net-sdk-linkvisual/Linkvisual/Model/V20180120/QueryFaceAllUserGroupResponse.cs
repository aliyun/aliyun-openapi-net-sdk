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

namespace Aliyun.Acs.Linkvisual.Model.V20180120
{
	public class QueryFaceAllUserGroupResponse : AcsResponse
	{

		private string code;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private QueryFaceAllUserGroup_Data data;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public QueryFaceAllUserGroup_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class QueryFaceAllUserGroup_Data
		{

			private int? pageNo;

			private int? pageSize;

			private int? total;

			private List<QueryFaceAllUserGroup_UserGroupListItem> userGroupList;

			public int? PageNo
			{
				get
				{
					return pageNo;
				}
				set	
				{
					pageNo = value;
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

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public List<QueryFaceAllUserGroup_UserGroupListItem> UserGroupList
			{
				get
				{
					return userGroupList;
				}
				set	
				{
					userGroupList = value;
				}
			}

			public class QueryFaceAllUserGroup_UserGroupListItem
			{

				private string userGroupName;

				private string modifiedTime;

				private string userGroupId;

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
			}
		}
	}
}
