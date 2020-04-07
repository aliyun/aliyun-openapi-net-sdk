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

namespace Aliyun.Acs.Ram.Model.V20150501
{
	public class GetRoleResponse : AcsResponse
	{

		private string requestId;

		private GetRole_Role role;

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

		public GetRole_Role Role
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

		public class GetRole_Role
		{

			private string roleId;

			private string roleName;

			private string arn;

			private string description;

			private string assumeRolePolicyDocument;

			private string createDate;

			private string updateDate;

			private long? maxSessionDuration;

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

			public string Arn
			{
				get
				{
					return arn;
				}
				set	
				{
					arn = value;
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

			public string AssumeRolePolicyDocument
			{
				get
				{
					return assumeRolePolicyDocument;
				}
				set	
				{
					assumeRolePolicyDocument = value;
				}
			}

			public string CreateDate
			{
				get
				{
					return createDate;
				}
				set	
				{
					createDate = value;
				}
			}

			public string UpdateDate
			{
				get
				{
					return updateDate;
				}
				set	
				{
					updateDate = value;
				}
			}

			public long? MaxSessionDuration
			{
				get
				{
					return maxSessionDuration;
				}
				set	
				{
					maxSessionDuration = value;
				}
			}
		}
	}
}
