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

namespace Aliyun.Acs.devops_rdc.Model.V20200303
{
	public class ListDevopsProjectsResponse : AcsResponse
	{

		private bool? successful;

		private string errorCode;

		private string errorMsg;

		private string requestId;

		private ListDevopsProjects__Object _object;

		public bool? Successful
		{
			get
			{
				return successful;
			}
			set	
			{
				successful = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
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

		public ListDevopsProjects__Object _Object
		{
			get
			{
				return _object;
			}
			set	
			{
				_object = value;
			}
		}

		public class ListDevopsProjects__Object
		{

			private string nextPageToken;

			private List<ListDevopsProjects_Project> result;

			public string NextPageToken
			{
				get
				{
					return nextPageToken;
				}
				set	
				{
					nextPageToken = value;
				}
			}

			public List<ListDevopsProjects_Project> Result
			{
				get
				{
					return result;
				}
				set	
				{
					result = value;
				}
			}

			public class ListDevopsProjects_Project
			{

				private int? roleId;

				private string organizationId;

				private string id;

				private string creatorId;

				private string visibility;

				private string updated;

				private int? tasksCount;

				private string name;

				private int? membersCount;

				private string logo;

				private bool? isTemplate;

				private bool? isStar;

				private bool? isPublic;

				private bool? isArchived;

				private string description;

				private string created;

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

				public string OrganizationId
				{
					get
					{
						return organizationId;
					}
					set	
					{
						organizationId = value;
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

				public string CreatorId
				{
					get
					{
						return creatorId;
					}
					set	
					{
						creatorId = value;
					}
				}

				public string Visibility
				{
					get
					{
						return visibility;
					}
					set	
					{
						visibility = value;
					}
				}

				public string Updated
				{
					get
					{
						return updated;
					}
					set	
					{
						updated = value;
					}
				}

				public int? TasksCount
				{
					get
					{
						return tasksCount;
					}
					set	
					{
						tasksCount = value;
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

				public int? MembersCount
				{
					get
					{
						return membersCount;
					}
					set	
					{
						membersCount = value;
					}
				}

				public string Logo
				{
					get
					{
						return logo;
					}
					set	
					{
						logo = value;
					}
				}

				public bool? IsTemplate
				{
					get
					{
						return isTemplate;
					}
					set	
					{
						isTemplate = value;
					}
				}

				public bool? IsStar
				{
					get
					{
						return isStar;
					}
					set	
					{
						isStar = value;
					}
				}

				public bool? IsPublic
				{
					get
					{
						return isPublic;
					}
					set	
					{
						isPublic = value;
					}
				}

				public bool? IsArchived
				{
					get
					{
						return isArchived;
					}
					set	
					{
						isArchived = value;
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

				public string Created
				{
					get
					{
						return created;
					}
					set	
					{
						created = value;
					}
				}
			}
		}
	}
}
