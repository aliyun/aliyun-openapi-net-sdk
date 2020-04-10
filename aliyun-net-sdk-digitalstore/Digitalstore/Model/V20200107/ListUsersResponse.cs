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

namespace Aliyun.Acs.digitalstore.Model.V20200107
{
	public class ListUsersResponse : AcsResponse
	{

		private int? pageSize;

		private int? totalCount;

		private int? pageNumber;

		private string requestId;

		private bool? success;

		private List<ListUsers_SysUserModel> users;

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

		public List<ListUsers_SysUserModel> Users
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

		public class ListUsers_SysUserModel
		{

			private string mail;

			private string aliyunAccount;

			private string telephone;

			private string remark;

			private long? merchantId;

			private string userName;

			private int? status;

			private long? userId;

			private List<ListUsers_SysUserUnitModel> stores;

			private List<ListUsers_UserRoleModel> roles;

			private List<ListUsers_SysUserUnitModel> warehouses;

			private List<ListUsers_SysUserUnitModel> factories;

			public string Mail
			{
				get
				{
					return mail;
				}
				set	
				{
					mail = value;
				}
			}

			public string AliyunAccount
			{
				get
				{
					return aliyunAccount;
				}
				set	
				{
					aliyunAccount = value;
				}
			}

			public string Telephone
			{
				get
				{
					return telephone;
				}
				set	
				{
					telephone = value;
				}
			}

			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}

			public long? MerchantId
			{
				get
				{
					return merchantId;
				}
				set	
				{
					merchantId = value;
				}
			}

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

			public int? Status
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

			public long? UserId
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

			public List<ListUsers_SysUserUnitModel> Stores
			{
				get
				{
					return stores;
				}
				set	
				{
					stores = value;
				}
			}

			public List<ListUsers_UserRoleModel> Roles
			{
				get
				{
					return roles;
				}
				set	
				{
					roles = value;
				}
			}

			public List<ListUsers_SysUserUnitModel> Warehouses
			{
				get
				{
					return warehouses;
				}
				set	
				{
					warehouses = value;
				}
			}

			public List<ListUsers_SysUserUnitModel> Factories
			{
				get
				{
					return factories;
				}
				set	
				{
					factories = value;
				}
			}

			public class ListUsers_SysUserUnitModel
			{

				private string unitName;

				private string unitId;

				public string UnitName
				{
					get
					{
						return unitName;
					}
					set	
					{
						unitName = value;
					}
				}

				public string UnitId
				{
					get
					{
						return unitId;
					}
					set	
					{
						unitId = value;
					}
				}
			}

			public class ListUsers_UserRoleModel
			{

				private int? roleId;

				private string roleName;

				private int? status;

				public int? RoleId
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

				public int? Status
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
			}
		}
	}
}
