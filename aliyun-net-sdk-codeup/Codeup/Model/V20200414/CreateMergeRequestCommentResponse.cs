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
	public class CreateMergeRequestCommentResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private CreateMergeRequestComment_Result result;

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

		public CreateMergeRequestComment_Result Result
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

		public class CreateMergeRequestComment_Result
		{

			private long? id;

			private string note;

			private string createdAt;

			private string updatedAt;

			private long? projectId;

			private bool? isDraft;

			private long? parentNoteId;

			private long? line;

			private string side;

			private string path;

			private string rangeContext;

			private bool? outDated;

			private int? closed;

			private CreateMergeRequestComment_Author author;

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

			public string Note
			{
				get
				{
					return note;
				}
				set	
				{
					note = value;
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

			public bool? IsDraft
			{
				get
				{
					return isDraft;
				}
				set	
				{
					isDraft = value;
				}
			}

			public long? ParentNoteId
			{
				get
				{
					return parentNoteId;
				}
				set	
				{
					parentNoteId = value;
				}
			}

			public long? Line
			{
				get
				{
					return line;
				}
				set	
				{
					line = value;
				}
			}

			public string Side
			{
				get
				{
					return side;
				}
				set	
				{
					side = value;
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

			public string RangeContext
			{
				get
				{
					return rangeContext;
				}
				set	
				{
					rangeContext = value;
				}
			}

			public bool? OutDated
			{
				get
				{
					return outDated;
				}
				set	
				{
					outDated = value;
				}
			}

			public int? Closed
			{
				get
				{
					return closed;
				}
				set	
				{
					closed = value;
				}
			}

			public CreateMergeRequestComment_Author Author
			{
				get
				{
					return author;
				}
				set	
				{
					author = value;
				}
			}

			public class CreateMergeRequestComment_Author
			{

				private long? id;

				private string avatarUrl;

				private string externUserId;

				private string name;

				private string email;

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
			}
		}
	}
}
