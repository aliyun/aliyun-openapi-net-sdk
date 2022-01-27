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
	public class AddWebhookResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private bool? success;

		private string errorMessage;

		private AddWebhook_Result result;

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

		public AddWebhook_Result Result
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

		public class AddWebhook_Result
		{

			private long? id;

			private string url;

			private string createdAt;

			private long? projectId;

			private bool? pushEvents;

			private bool? issuesEvents;

			private bool? mergeRequestsEvents;

			private bool? tagPushEvents;

			private bool? buildEvents;

			private bool? noteEvents;

			private bool? enableSslVerification;

			private string lastTestResult;

			private string description;

			private string secretToken;

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

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
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

			public bool? PushEvents
			{
				get
				{
					return pushEvents;
				}
				set	
				{
					pushEvents = value;
				}
			}

			public bool? IssuesEvents
			{
				get
				{
					return issuesEvents;
				}
				set	
				{
					issuesEvents = value;
				}
			}

			public bool? MergeRequestsEvents
			{
				get
				{
					return mergeRequestsEvents;
				}
				set	
				{
					mergeRequestsEvents = value;
				}
			}

			public bool? TagPushEvents
			{
				get
				{
					return tagPushEvents;
				}
				set	
				{
					tagPushEvents = value;
				}
			}

			public bool? BuildEvents
			{
				get
				{
					return buildEvents;
				}
				set	
				{
					buildEvents = value;
				}
			}

			public bool? NoteEvents
			{
				get
				{
					return noteEvents;
				}
				set	
				{
					noteEvents = value;
				}
			}

			public bool? EnableSslVerification
			{
				get
				{
					return enableSslVerification;
				}
				set	
				{
					enableSslVerification = value;
				}
			}

			public string LastTestResult
			{
				get
				{
					return lastTestResult;
				}
				set	
				{
					lastTestResult = value;
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

			public string SecretToken
			{
				get
				{
					return secretToken;
				}
				set	
				{
					secretToken = value;
				}
			}
		}
	}
}
