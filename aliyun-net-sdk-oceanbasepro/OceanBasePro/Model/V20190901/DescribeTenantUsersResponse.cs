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
	public class DescribeTenantUsersResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private List<DescribeTenantUsers_TenantUsersItem> tenantUsers;

		[JsonProperty(PropertyName = "TotalCount")]
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

		[JsonProperty(PropertyName = "TenantUsers")]
		public List<DescribeTenantUsers_TenantUsersItem> TenantUsers
		{
			get
			{
				return tenantUsers;
			}
			set	
			{
				tenantUsers = value;
			}
		}

		public class DescribeTenantUsers_TenantUsersItem
		{

			private string userType;

			private string description;

			private string userStatus;

			private string userName;

			private string tenantId;

			private string instanceId;

			private List<DescribeTenantUsers_DatabasesItem> databases;

			[JsonProperty(PropertyName = "UserType")]
			public string UserType
			{
				get
				{
					return userType;
				}
				set	
				{
					userType = value;
				}
			}

			[JsonProperty(PropertyName = "Description")]
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

			[JsonProperty(PropertyName = "UserStatus")]
			public string UserStatus
			{
				get
				{
					return userStatus;
				}
				set	
				{
					userStatus = value;
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

			[JsonProperty(PropertyName = "InstanceId")]
			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			[JsonProperty(PropertyName = "Databases")]
			public List<DescribeTenantUsers_DatabasesItem> Databases
			{
				get
				{
					return databases;
				}
				set	
				{
					databases = value;
				}
			}

			public class DescribeTenantUsers_DatabasesItem
			{

				private string database;

				private string role;

				private string table;

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
			}
		}
	}
}
