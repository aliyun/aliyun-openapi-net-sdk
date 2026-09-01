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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class QueryWorksByOrganizationResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private QueryWorksByOrganization_Result result;

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

		public QueryWorksByOrganization_Result Result
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

		public class QueryWorksByOrganization_Result
		{

			private int? totalNum;

			private int? pageNum;

			private int? pageSize;

			private int? totalPages;

			private List<QueryWorksByOrganization_DataItem> data;

			public int? TotalNum
			{
				get
				{
					return totalNum;
				}
				set	
				{
					totalNum = value;
				}
			}

			public int? PageNum
			{
				get
				{
					return pageNum;
				}
				set	
				{
					pageNum = value;
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

			public List<QueryWorksByOrganization_DataItem> Data
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

			public class QueryWorksByOrganization_DataItem
			{

				private int? status;

				private string ownerName;

				private long? publicInvalidTime;

				private string description;

				private string workType;

				private string modifyName;

				private string workspaceId;

				private int? auth3rdFlag;

				private string gmtCreate;

				private string ownerId;

				private string gmtModify;

				private string securityLevel;

				private string workName;

				private string workspaceName;

				private bool? publicFlag;

				private string worksId;

				private QueryWorksByOrganization_Directory directory;

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

				public string OwnerName
				{
					get
					{
						return ownerName;
					}
					set	
					{
						ownerName = value;
					}
				}

				public long? PublicInvalidTime
				{
					get
					{
						return publicInvalidTime;
					}
					set	
					{
						publicInvalidTime = value;
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

				public string WorkType
				{
					get
					{
						return workType;
					}
					set	
					{
						workType = value;
					}
				}

				public string ModifyName
				{
					get
					{
						return modifyName;
					}
					set	
					{
						modifyName = value;
					}
				}

				public string WorkspaceId
				{
					get
					{
						return workspaceId;
					}
					set	
					{
						workspaceId = value;
					}
				}

				public int? Auth3rdFlag
				{
					get
					{
						return auth3rdFlag;
					}
					set	
					{
						auth3rdFlag = value;
					}
				}

				public string GmtCreate
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

				public string GmtModify
				{
					get
					{
						return gmtModify;
					}
					set	
					{
						gmtModify = value;
					}
				}

				public string SecurityLevel
				{
					get
					{
						return securityLevel;
					}
					set	
					{
						securityLevel = value;
					}
				}

				public string WorkName
				{
					get
					{
						return workName;
					}
					set	
					{
						workName = value;
					}
				}

				public string WorkspaceName
				{
					get
					{
						return workspaceName;
					}
					set	
					{
						workspaceName = value;
					}
				}

				public bool? PublicFlag
				{
					get
					{
						return publicFlag;
					}
					set	
					{
						publicFlag = value;
					}
				}

				public string WorksId
				{
					get
					{
						return worksId;
					}
					set	
					{
						worksId = value;
					}
				}

				public QueryWorksByOrganization_Directory Directory
				{
					get
					{
						return directory;
					}
					set	
					{
						directory = value;
					}
				}

				public class QueryWorksByOrganization_Directory
				{

					private string pathId;

					private string id;

					private string pathName;

					private string name;

					public string PathId
					{
						get
						{
							return pathId;
						}
						set	
						{
							pathId = value;
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

					public string PathName
					{
						get
						{
							return pathName;
						}
						set	
						{
							pathName = value;
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
				}
			}
		}
	}
}
