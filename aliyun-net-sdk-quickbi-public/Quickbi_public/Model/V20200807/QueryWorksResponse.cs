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

namespace Aliyun.Acs.quickbi_public.Model.V20200807
{
	public class QueryWorksResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private QueryWorks_Result result;

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

		public QueryWorks_Result Result
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

		public class QueryWorks_Result
		{

			private string worksId;

			private string workType;

			private string workName;

			private string workspaceId;

			private string workspaceName;

			private string securityLevel;

			private int? auth3rdFlag;

			private string description;

			private string ownerId;

			private string ownerName;

			private string modifyName;

			private string gmtCreate;

			private string gmtModify;

			private int? status;

			private QueryWorks_Directory directory;

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

			public QueryWorks_Directory Directory
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

			public class QueryWorks_Directory
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
