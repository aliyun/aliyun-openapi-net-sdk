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
	public class ListRepositoryMemberWithInheritedResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private bool? success;

		private string errorMessage;

		private List<ListRepositoryMemberWithInherited_ResultItem> result;

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

		public List<ListRepositoryMemberWithInherited_ResultItem> Result
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

		public class ListRepositoryMemberWithInherited_ResultItem
		{

			private int? accessLevel;

			private string externUserId;

			private long? id;

			private string state;

			private string avatarUrl;

			private string email;

			private string name;

			private string username;

			private ListRepositoryMemberWithInherited_Inherited inherited;

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

			public string ExternUserId
			{
				get
				{
					return externUserId;
				}
				set	
				{
					externUserId = value;
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

			public string Email
			{
				get
				{
					return email;
				}
				set	
				{
					email = value;
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

			public string Username
			{
				get
				{
					return username;
				}
				set	
				{
					username = value;
				}
			}

			public ListRepositoryMemberWithInherited_Inherited Inherited
			{
				get
				{
					return inherited;
				}
				set	
				{
					inherited = value;
				}
			}

			public class ListRepositoryMemberWithInherited_Inherited
			{

				private long? id;

				private string name;

				private string path;

				private string nameWithNamespace;

				private string pathWithNamespace;

				private string type;

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

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
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
