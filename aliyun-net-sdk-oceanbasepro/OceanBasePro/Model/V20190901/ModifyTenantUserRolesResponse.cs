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
	public class ModifyTenantUserRolesResponse : AcsResponse
	{

		private string requestId;

		private ModifyTenantUserRoles_TenantUser tenantUser;

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
		public ModifyTenantUserRoles_TenantUser TenantUser
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

		public class ModifyTenantUserRoles_TenantUser
		{

			private string userName;

			private string tenantId;

			private List<ModifyTenantUserRoles_UserRoleItem> userRole;

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

			[JsonProperty(PropertyName = "UserRole")]
			public List<ModifyTenantUserRoles_UserRoleItem> UserRole
			{
				get
				{
					return userRole;
				}
				set	
				{
					userRole = value;
				}
			}

			public class ModifyTenantUserRoles_UserRoleItem
			{

				private string database;

				private string role;

				private string table;

				private bool? isSuccess;

				[JsonProperty(PropertyName = "Database")]
				public string Database
				{
					get
					{
						return database;
					}
					set	
					{
						database = value;
					}
				}

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

				[JsonProperty(PropertyName = "Table")]
				public string Table
				{
					get
					{
						return table;
					}
					set	
					{
						table = value;
					}
				}

				[JsonProperty(PropertyName = "IsSuccess")]
				public bool? IsSuccess
				{
					get
					{
						return isSuccess;
					}
					set	
					{
						isSuccess = value;
					}
				}
			}
		}
	}
}
