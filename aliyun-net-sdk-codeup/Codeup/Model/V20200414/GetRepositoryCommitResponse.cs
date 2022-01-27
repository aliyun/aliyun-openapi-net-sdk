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
	public class GetRepositoryCommitResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private GetRepositoryCommit_Result result;

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

		public GetRepositoryCommit_Result Result
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

		public class GetRepositoryCommit_Result
		{

			private string authorDate;

			private string authorEmail;

			private string authorName;

			private string committedDate;

			private string committerEmail;

			private string committerName;

			private string createdAt;

			private string id;

			private string message;

			private string shortId;

			private string title;

			private List<string> parentIds;

			private GetRepositoryCommit_Signature signature;

			public string AuthorDate
			{
				get
				{
					return authorDate;
				}
				set	
				{
					authorDate = value;
				}
			}

			public string AuthorEmail
			{
				get
				{
					return authorEmail;
				}
				set	
				{
					authorEmail = value;
				}
			}

			public string AuthorName
			{
				get
				{
					return authorName;
				}
				set	
				{
					authorName = value;
				}
			}

			public string CommittedDate
			{
				get
				{
					return committedDate;
				}
				set	
				{
					committedDate = value;
				}
			}

			public string CommitterEmail
			{
				get
				{
					return committerEmail;
				}
				set	
				{
					committerEmail = value;
				}
			}

			public string CommitterName
			{
				get
				{
					return committerName;
				}
				set	
				{
					committerName = value;
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

			public string Message
			{
				get
				{
					return message;
				}
				set	
				{
					message = value;
				}
			}

			public string ShortId
			{
				get
				{
					return shortId;
				}
				set	
				{
					shortId = value;
				}
			}

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public List<string> ParentIds
			{
				get
				{
					return parentIds;
				}
				set	
				{
					parentIds = value;
				}
			}

			public GetRepositoryCommit_Signature Signature
			{
				get
				{
					return signature;
				}
				set	
				{
					signature = value;
				}
			}

			public class GetRepositoryCommit_Signature
			{

				private string gpgKeyId;

				private string verificationStatus;

				public string GpgKeyId
				{
					get
					{
						return gpgKeyId;
					}
					set	
					{
						gpgKeyId = value;
					}
				}

				public string VerificationStatus
				{
					get
					{
						return verificationStatus;
					}
					set	
					{
						verificationStatus = value;
					}
				}
			}
		}
	}
}
