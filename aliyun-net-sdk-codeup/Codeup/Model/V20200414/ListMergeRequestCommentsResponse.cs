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
	public class ListMergeRequestCommentsResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private long? total;

		private List<ListMergeRequestComments_ResultItem> result;

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

		public List<ListMergeRequestComments_ResultItem> Result
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

		public class ListMergeRequestComments_ResultItem
		{

			private int? closed;

			private string createdAt;

			private long? id;

			private bool? isDraft;

			private long? line;

			private string note;

			private bool? outDated;

			private long? parentNoteId;

			private string path;

			private long? projectId;

			private string rangeContext;

			private string side;

			private string updatedAt;

			private ListMergeRequestComments_Author author;

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

			public ListMergeRequestComments_Author Author
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

			public class ListMergeRequestComments_Author
			{

				private string avatarUrl;

				private string email;

				private string externUserId;

				private long? id;

				private string name;

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
