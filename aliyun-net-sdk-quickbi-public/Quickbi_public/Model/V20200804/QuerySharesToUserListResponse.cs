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

namespace Aliyun.Acs.quickbi_public.Model.V20200804
{
	public class QuerySharesToUserListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<QuerySharesToUserList_Data> result;

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

		public List<QuerySharesToUserList_Data> Result
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

		public class QuerySharesToUserList_Data
		{

			private string worksId;

			private string workType;

			private string workName;

			private string workspaceId;

			private string workspaceName;

			private string securityLevel;

			private string description;

			private string ownerId;

			private string ownerName;

			private string modifyName;

			private string createTime;

			private string modifyTime;

			private int? thirdPartAuthFlag;

			private int? status;

			private QuerySharesToUserList_Directory directory;

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

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}

			public int? ThirdPartAuthFlag
			{
				get
				{
					return thirdPartAuthFlag;
				}
				set	
				{
					thirdPartAuthFlag = value;
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

			public QuerySharesToUserList_Directory Directory
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

			public class QuerySharesToUserList_Directory
			{

				private string id;

				private string name;

				private string pathId;

				private string pathName;

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
			}
		}
	}
}
