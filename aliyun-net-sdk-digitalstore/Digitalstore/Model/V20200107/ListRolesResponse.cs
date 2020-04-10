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
	public class ListRolesResponse : AcsResponse
	{

		private int? pageSize;

		private int? totalCount;

		private int? pageNumber;

		private string requestId;

		private bool? success;

		private List<ListRoles_SysRoleModel> roles;

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

		public List<ListRoles_SysRoleModel> Roles
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

		public class ListRoles_SysRoleModel
		{

			private long? merchantId;

			private int? roleId;

			private string remark;

			private string name;

			private int? status;

			private List<ListRoles_BaseModel> apis;

			private List<ListRoles_BaseModel> menus;

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

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
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

			public List<ListRoles_BaseModel> Apis
			{
				get
				{
					return apis;
				}
				set	
				{
					apis = value;
				}
			}

			public List<ListRoles_BaseModel> Menus
			{
				get
				{
					return menus;
				}
				set	
				{
					menus = value;
				}
			}

			public class ListRoles_BaseModel
			{

				private int? id;

				private string name;

				private string code;

				public int? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

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
			}
		}
	}
}
