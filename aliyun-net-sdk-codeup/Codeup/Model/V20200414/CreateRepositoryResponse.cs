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

namespace Aliyun.Acs.codeup.Model.V20200414
{
	public class CreateRepositoryResponse : AcsResponse
	{

		private int? errorCode;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private CreateRepository_Result result;

		public int? ErrorCode
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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public CreateRepository_Result Result
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

		public class CreateRepository_Result
		{

			private long? id;

			private string sshUrlToRepo;

			private string description;

			private string defaultBranch;

			private bool? _public;

			private string visibilityLevel;

			private string httpUrlToRepo;

			private string webUrl;

			private string name;

			private string nameWithNamespace;

			private string path;

			private string pathWithNamespace;

			private bool? issuesEnableStatus;

			private bool? mergeRequestEnableStatus;

			private bool? buildsEnableStatus;

			private bool? wikiEnableStatus;

			private bool? snippetsEnableStatus;

			private string createdAt;

			private string lastActivityAt;

			private long? creatorId;

			private bool? archive;

			private string avatarUrl;

			private bool? demoProjectStatus;

			private List<string> tagList;

			private CreateRepository__Namespace _namespace;

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

			public string SshUrlToRepo
			{
				get
				{
					return sshUrlToRepo;
				}
				set	
				{
					sshUrlToRepo = value;
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

			public string DefaultBranch
			{
				get
				{
					return defaultBranch;
				}
				set	
				{
					defaultBranch = value;
				}
			}

			public bool? _Public
			{
				get
				{
					return _public;
				}
				set	
				{
					_public = value;
				}
			}

			public string VisibilityLevel
			{
				get
				{
					return visibilityLevel;
				}
				set	
				{
					visibilityLevel = value;
				}
			}

			public string HttpUrlToRepo
			{
				get
				{
					return httpUrlToRepo;
				}
				set	
				{
					httpUrlToRepo = value;
				}
			}

			public string WebUrl
			{
				get
				{
					return webUrl;
				}
				set	
				{
					webUrl = value;
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

			public string NameWithNamespace
			{
				get
				{
					return nameWithNamespace;
				}
				set	
				{
					nameWithNamespace = value;
				}
			}

			public string Path
			{
				get
				{
					return path;
				}
				set	
				{
					path = value;
				}
			}

			public string PathWithNamespace
			{
				get
				{
					return pathWithNamespace;
				}
				set	
				{
					pathWithNamespace = value;
				}
			}

			public bool? IssuesEnableStatus
			{
				get
				{
					return issuesEnableStatus;
				}
				set	
				{
					issuesEnableStatus = value;
				}
			}

			public bool? MergeRequestEnableStatus
			{
				get
				{
					return mergeRequestEnableStatus;
				}
				set	
				{
					mergeRequestEnableStatus = value;
				}
			}

			public bool? BuildsEnableStatus
			{
				get
				{
					return buildsEnableStatus;
				}
				set	
				{
					buildsEnableStatus = value;
				}
			}

			public bool? WikiEnableStatus
			{
				get
				{
					return wikiEnableStatus;
				}
				set	
				{
					wikiEnableStatus = value;
				}
			}

			public bool? SnippetsEnableStatus
			{
				get
				{
					return snippetsEnableStatus;
				}
				set	
				{
					snippetsEnableStatus = value;
				}
			}

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

			public string LastActivityAt
			{
				get
				{
					return lastActivityAt;
				}
				set	
				{
					lastActivityAt = value;
				}
			}

			public long? CreatorId
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

			public bool? Archive
			{
				get
				{
					return archive;
				}
				set	
				{
					archive = value;
				}
			}

			public string AvatarUrl
			{
				get
				{
					return avatarUrl;
				}
				set	
				{
					avatarUrl = value;
				}
			}

			public bool? DemoProjectStatus
			{
				get
				{
					return demoProjectStatus;
				}
				set	
				{
					demoProjectStatus = value;
				}
			}

			public List<string> TagList
			{
				get
				{
					return tagList;
				}
				set	
				{
					tagList = value;
				}
			}

			public CreateRepository__Namespace _Namespace
			{
				get
				{
					return _namespace;
				}
				set	
				{
					_namespace = value;
				}
			}

			public class CreateRepository__Namespace
			{

				private long? id;

				private string name;

				private string path;

				private long? ownerId;

				private string createdAt;

				private string updatedAt;

				private string description;

				private string state;

				private string avatar;

				private bool? _public;

				private string visibilityLevel;

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

				public string Path
				{
					get
					{
						return path;
					}
					set	
					{
						path = value;
					}
				}

				public long? OwnerId
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

				public string State
				{
					get
					{
						return state;
					}
					set	
					{
						state = value;
					}
				}

				public string Avatar
				{
					get
					{
						return avatar;
					}
					set	
					{
						avatar = value;
					}
				}

				public bool? _Public
				{
					get
					{
						return _public;
					}
					set	
					{
						_public = value;
					}
				}

				public string VisibilityLevel
				{
					get
					{
						return visibilityLevel;
					}
					set	
					{
						visibilityLevel = value;
					}
				}
			}
		}
	}
}
