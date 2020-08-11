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
	public class ListProjectsResponse : AcsResponse
	{

		private string requestId;

		private ListProjects_PageResult pageResult;

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

		public ListProjects_PageResult PageResult
		{
			get
			{
				return pageResult;
			}
			set	
			{
				pageResult = value;
			}
		}

		public class ListProjects_PageResult
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListProjects_Project> projectList;

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

			public List<ListProjects_Project> ProjectList
			{
				get
				{
					return projectList;
				}
				set	
				{
					projectList = value;
				}
			}

			public class ListProjects_Project
			{

				private string projectName;

				private string projectIdentifier;

				private string projectDescription;

				private int? projectStatus;

				private long? projectId;

				private string projectOwnerBaseId;

				private string projectStatusCode;

				public string ProjectName
				{
					get
					{
						return projectName;
					}
					set	
					{
						projectName = value;
					}
				}

				public string ProjectIdentifier
				{
					get
					{
						return projectIdentifier;
					}
					set	
					{
						projectIdentifier = value;
					}
				}

				public string ProjectDescription
				{
					get
					{
						return projectDescription;
					}
					set	
					{
						projectDescription = value;
					}
				}

				public int? ProjectStatus
				{
					get
					{
						return projectStatus;
					}
					set	
					{
						projectStatus = value;
					}
				}

				public long? ProjectId
				{
					get
					{
						return projectId;
					}
					set	
					{
						projectId = value;
					}
				}

				public string ProjectOwnerBaseId
				{
					get
					{
						return projectOwnerBaseId;
					}
					set	
					{
						projectOwnerBaseId = value;
					}
				}

				public string ProjectStatusCode
				{
					get
					{
						return projectStatusCode;
					}
					set	
					{
						projectStatusCode = value;
					}
				}
			}
		}
	}
}
