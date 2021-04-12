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

namespace Aliyun.Acs.CCC.Model.V20200701
{
	public class ListUserLevelsOfSkillGroupResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private ListUserLevelsOfSkillGroup_Data data;

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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public ListUserLevelsOfSkillGroup_Data Data
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

		public class ListUserLevelsOfSkillGroup_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListUserLevelsOfSkillGroup_UserSkillLevel> list;

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
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

			public int? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public List<ListUserLevelsOfSkillGroup_UserSkillLevel> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class ListUserLevelsOfSkillGroup_UserSkillLevel
			{

				private string displayName;

				private string loginName;

				private string roleId;

				private string roleName;

				private string skillGroupId;

				private string skillGroupName;

				private int? skillLevel;

				private string userId;

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

				public string LoginName
				{
					get
					{
						return loginName;
					}
					set	
					{
						loginName = value;
					}
				}

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

				public string SkillGroupId
				{
					get
					{
						return skillGroupId;
					}
					set	
					{
						skillGroupId = value;
					}
				}

				public string SkillGroupName
				{
					get
					{
						return skillGroupName;
					}
					set	
					{
						skillGroupName = value;
					}
				}

				public int? SkillLevel
				{
					get
					{
						return skillLevel;
					}
					set	
					{
						skillLevel = value;
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
			}
		}
	}
}
