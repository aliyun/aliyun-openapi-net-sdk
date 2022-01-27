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

namespace Aliyun.Acs.idrsservice.Model.V20200630
{
	public class ListUsersResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private ListUsers_Data data;

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

		public ListUsers_Data Data
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

		public class ListUsers_Data
		{

			private long? totalElements;

			private int? totalPages;

			private List<ListUsers_ItemsItem> items;

			public long? TotalElements
			{
				get
				{
					return totalElements;
				}
				set	
				{
					totalElements = value;
				}
			}

			public int? TotalPages
			{
				get
				{
					return totalPages;
				}
				set	
				{
					totalPages = value;
				}
			}

			public List<ListUsers_ItemsItem> Items
			{
				get
				{
					return items;
				}
				set	
				{
					items = value;
				}
			}

			public class ListUsers_ItemsItem
			{

				private string createdAt;

				private string email;

				private string id;

				private string name;

				private string phoneNumber;

				private string ramUsername;

				private string role;

				private string source;

				private string updatedAt;

				private string username;

				private List<ListUsers_DepartmentsItem> departments;

				public string CreatedAt
				{
					get
					{
						return createdAt;
					}
					set	
					{
						createdAt = value;
					}
				}

				public string Email
				{
					get
					{
						return email;
					}
					set	
					{
						email = value;
					}
				}

				public string Id
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

				public string PhoneNumber
				{
					get
					{
						return phoneNumber;
					}
					set	
					{
						phoneNumber = value;
					}
				}

				public string RamUsername
				{
					get
					{
						return ramUsername;
					}
					set	
					{
						ramUsername = value;
					}
				}

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

				public string Source
				{
					get
					{
						return source;
					}
					set	
					{
						source = value;
					}
				}

				public string UpdatedAt
				{
					get
					{
						return updatedAt;
					}
					set	
					{
						updatedAt = value;
					}
				}

				public string Username
				{
					get
					{
						return username;
					}
					set	
					{
						username = value;
					}
				}

				public List<ListUsers_DepartmentsItem> Departments
				{
					get
					{
						return departments;
					}
					set	
					{
						departments = value;
					}
				}

				public class ListUsers_DepartmentsItem
				{

					private string createdAt;

					private string description;

					private string id;

					private string name;

					private string updatedAt;

					public string CreatedAt
					{
						get
						{
							return createdAt;
						}
						set	
						{
							createdAt = value;
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

					public string Id
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

					public string UpdatedAt
					{
						get
						{
							return updatedAt;
						}
						set	
						{
							updatedAt = value;
						}
					}
				}
			}
		}
	}
}
