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
	public class ListProjectRolesResponse : AcsResponse
	{

		private string requestId;

		private List<ListProjectRoles_Role> projectRoleList;

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

		public List<ListProjectRoles_Role> ProjectRoleList
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

		public class ListProjectRoles_Role
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
