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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class ListProjectMembersResponse : AcsResponse
	{

		private int? pageNum;

		private int? pageSize;

		private string requestId;

		private int? totalNum;

		private List<ListProjectMembers_ProjectMember> projectMemberList;

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
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

		public int? TotalNum
		{
			get
			{
				return totalNum;
			}
			set	
			{
				totalNum = value;
			}
		}

		public List<ListProjectMembers_ProjectMember> ProjectMemberList
		{
			get
			{
				return projectMemberList;
			}
			set	
			{
				projectMemberList = value;
			}
		}

		public class ListProjectMembers_ProjectMember
		{

			private string projectMemberId;

			private string projectMemberName;

			private string projectMemberType;

			private string createOn;

			private string nick;

			private string status;

			private List<ListProjectMembers_Role> projectRoleList;

			public string ProjectMemberId
			{
				get
				{
					return projectMemberId;
				}
				set	
				{
					projectMemberId = value;
				}
			}

			public string ProjectMemberName
			{
				get
				{
					return projectMemberName;
				}
				set	
				{
					projectMemberName = value;
				}
			}

			public string ProjectMemberType
			{
				get
				{
					return projectMemberType;
				}
				set	
				{
					projectMemberType = value;
				}
			}

			public string CreateOn
			{
				get
				{
					return createOn;
				}
				set	
				{
					createOn = value;
				}
			}

			public string Nick
			{
				get
				{
					return nick;
				}
				set	
				{
					nick = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public List<ListProjectMembers_Role> ProjectRoleList
			{
				get
				{
					return projectRoleList;
				}
				set	
				{
					projectRoleList = value;
				}
			}

			public class ListProjectMembers_Role
			{

				private string projectRoleCode;

				private int? projectRoleId;

				private string projectRoleName;

				private string projectRoleType;

				public string ProjectRoleCode
				{
					get
					{
						return projectRoleCode;
					}
					set	
					{
						projectRoleCode = value;
					}
				}

				public int? ProjectRoleId
				{
					get
					{
						return projectRoleId;
					}
					set	
					{
						projectRoleId = value;
					}
				}

				public string ProjectRoleName
				{
					get
					{
						return projectRoleName;
					}
					set	
					{
						projectRoleName = value;
					}
				}

				public string ProjectRoleType
				{
					get
					{
						return projectRoleType;
					}
					set	
					{
						projectRoleType = value;
					}
				}
			}
		}
	}
}
