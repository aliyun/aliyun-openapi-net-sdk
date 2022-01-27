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
	public class UpdateRepositoryResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private UpdateRepository_Result result;

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

		public UpdateRepository_Result Result
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

		public class UpdateRepository_Result
		{

			private bool? archive;

			private string avatarUrl;

			private string createdAt;

			private long? creatorId;

			private string defaultBranch;

			private string description;

			private string httpUrlToRepo;

			private long? id;

			private string lastActivityAt;

			private string name;

			private string nameWithNamespace;

			private string path;

			private string pathWithNamespace;

			private string sshUrlToRepo;

			private string visibilityLevel;

			private string webUrl;

			private UpdateRepository__Namespace _namespace;

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

			public UpdateRepository__Namespace _Namespace
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

			public class UpdateRepository__Namespace
			{

				private string avatar;

				private string createdAt;

				private string description;

				private long? id;

				private string name;

				private long? ownerId;

				private string path;

				private bool? _public;

				private string updatedAt;

				private string visibilityLevel;

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
