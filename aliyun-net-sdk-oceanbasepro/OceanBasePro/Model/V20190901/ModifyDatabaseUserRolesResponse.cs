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

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
	public class ModifyDatabaseUserRolesResponse : AcsResponse
	{

		private string requestId;

		private ModifyDatabaseUserRoles_TenantUser tenantUser;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "TenantUser")]
		public ModifyDatabaseUserRoles_TenantUser TenantUser
		{
			get
			{
				return tenantUser;
			}
			set	
			{
				tenantUser = value;
			}
		}

		public class ModifyDatabaseUserRoles_TenantUser
		{

			private string databaseName;

			private string tenantId;

			private List<ModifyDatabaseUserRoles_UserRole> users;

			[JsonProperty(PropertyName = "DatabaseName")]
			public string DatabaseName
			{
				get
				{
					return databaseName;
				}
				set	
				{
					databaseName = value;
				}
			}

			[JsonProperty(PropertyName = "TenantId")]
			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			[JsonProperty(PropertyName = "Users")]
			public List<ModifyDatabaseUserRoles_UserRole> Users
			{
				get
				{
					return users;
				}
				set	
				{
					users = value;
				}
			}

			public class ModifyDatabaseUserRoles_UserRole
			{

				private string role;

				private string userName;

				[JsonProperty(PropertyName = "Role")]
				public string Role
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

				[JsonProperty(PropertyName = "UserName")]
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
			}
		}
	}
}
