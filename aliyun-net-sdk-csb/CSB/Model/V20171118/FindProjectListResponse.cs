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

namespace Aliyun.Acs.CSB.Model.V20171118
{
	public class FindProjectListResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private FindProjectList_Data data;

		public int? Code
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

		public FindProjectList_Data Data
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

		public class FindProjectList_Data
		{

			private int? currentPage;

			private int? pageNumber;

			private int? total;

			private List<FindProjectList_Project> projectList;

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
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

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public List<FindProjectList_Project> ProjectList
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

			public class FindProjectList_Project
			{

				private int? apiNum;

				private long? csbId;

				private int? deleteFlag;

				private string description;

				private long? gmtCreate;

				private long? gmtModified;

				private long? id;

				private string interfaceJarLocation;

				private string interfaceJarName;

				private string jarFileKey;

				private string ownerId;

				private string projectName;

				private string projectOwnerEmail;

				private string projectOwnerName;

				private string projectOwnerPhoneNum;

				private int? status;

				private string userId;

				public int? ApiNum
				{
					get
					{
						return apiNum;
					}
					set	
					{
						apiNum = value;
					}
				}

				public long? CsbId
				{
					get
					{
						return csbId;
					}
					set	
					{
						csbId = value;
					}
				}

				public int? DeleteFlag
				{
					get
					{
						return deleteFlag;
					}
					set	
					{
						deleteFlag = value;
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

				public long? GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

				public long? GmtModified
				{
					get
					{
						return gmtModified;
					}
					set	
					{
						gmtModified = value;
					}
				}

				public long? Id
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

				public string InterfaceJarLocation
				{
					get
					{
						return interfaceJarLocation;
					}
					set	
					{
						interfaceJarLocation = value;
					}
				}

				public string InterfaceJarName
				{
					get
					{
						return interfaceJarName;
					}
					set	
					{
						interfaceJarName = value;
					}
				}

				public string JarFileKey
				{
					get
					{
						return jarFileKey;
					}
					set	
					{
						jarFileKey = value;
					}
				}

				public string OwnerId
				{
					get
					{
						return ownerId;
					}
					set	
					{
						ownerId = value;
					}
				}

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

				public string ProjectOwnerEmail
				{
					get
					{
						return projectOwnerEmail;
					}
					set	
					{
						projectOwnerEmail = value;
					}
				}

				public string ProjectOwnerName
				{
					get
					{
						return projectOwnerName;
					}
					set	
					{
						projectOwnerName = value;
					}
				}

				public string ProjectOwnerPhoneNum
				{
					get
					{
						return projectOwnerPhoneNum;
					}
					set	
					{
						projectOwnerPhoneNum = value;
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

				public string UserId
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
			}
		}
	}
}
