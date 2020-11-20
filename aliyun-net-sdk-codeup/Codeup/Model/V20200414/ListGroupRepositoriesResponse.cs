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
	public class ListGroupRepositoriesResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private bool? success;

		private string errorMessage;

		private long? total;

		private List<ListGroupRepositories_ResultItem> result;

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

		public List<ListGroupRepositories_ResultItem> Result
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

		public class ListGroupRepositories_ResultItem
		{

			private bool? archive;

			private string createdAt;

			private string updatedAt;

			private string lastActivityAt;

			private long? id;

			private long? creatorId;

			private string name;

			private string nameWithNamespace;

			private string path;

			private string pathWithNamespace;

			private long? namespaceId;

			private string httpCloneUrl;

			private string sshCloneUrl;

			private int? visibilityLevel;

			private string webUrl;

			private string importStatus;

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

			public string HttpCloneUrl
			{
				get
				{
					return httpCloneUrl;
				}
				set	
				{
					httpCloneUrl = value;
				}
			}

			public string SshCloneUrl
			{
				get
				{
					return sshCloneUrl;
				}
				set	
				{
					sshCloneUrl = value;
				}
			}

			public int? VisibilityLevel
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
		}
	}
}
