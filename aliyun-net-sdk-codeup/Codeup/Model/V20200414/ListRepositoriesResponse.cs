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
	public class ListRepositoriesResponse : AcsResponse
	{

		private int? errorCode;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private long? total;

		private List<ListRepositories_ResultItem> result;

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

		public long? Total
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

		public List<ListRepositories_ResultItem> Result
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

		public class ListRepositories_ResultItem
		{

			private long? id;

			private string description;

			private string visibilityLevel;

			private string webUrl;

			private string name;

			private string nameWithNamespace;

			private string path;

			private string pathWithNamespace;

			private string createdAt;

			private string lastActivityAt;

			private bool? archive;

			private string avatarUrl;

			private bool? demoProjectStatus;

			private int? accessLevel;

			private string importStatus;

			private long? namespaceId;

			private string updatedAt;

			private long? starCount;

			private bool? star;

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

			public int? AccessLevel
			{
				get
				{
					return accessLevel;
				}
				set	
				{
					accessLevel = value;
				}
			}

			public string ImportStatus
			{
				get
				{
					return importStatus;
				}
				set	
				{
					importStatus = value;
				}
			}

			public long? NamespaceId
			{
				get
				{
					return namespaceId;
				}
				set	
				{
					namespaceId = value;
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

			public long? StarCount
			{
				get
				{
					return starCount;
				}
				set	
				{
					starCount = value;
				}
			}

			public bool? Star
			{
				get
				{
					return star;
				}
				set	
				{
					star = value;
				}
			}
		}
	}
}
