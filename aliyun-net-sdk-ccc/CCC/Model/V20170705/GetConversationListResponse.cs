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

namespace Aliyun.Acs.CCC.Model.V20170705
{
	public class GetConversationListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private List<GetConversationList_ConversationDetail> conversations;

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

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public List<GetConversationList_ConversationDetail> Conversations
		{
			get
			{
				return conversations;
			}
			set	
			{
				conversations = value;
			}
		}

		public class GetConversationList_ConversationDetail
		{

			private long? timestamp;

			private string speaker;

			private string script;

			private List<GetConversationList_SummaryItem> summary;

			public long? Timestamp
			{
				get
				{
					return timestamp;
				}
				set	
				{
					timestamp = value;
				}
			}

			public string Speaker
			{
				get
				{
					return speaker;
				}
				set	
				{
					speaker = value;
				}
			}

			public string Script
			{
				get
				{
					return script;
				}
				set	
				{
					script = value;
				}
			}

			public List<GetConversationList_SummaryItem> Summary
			{
				get
				{
					return summary;
				}
				set	
				{
					summary = value;
				}
			}

			public class GetConversationList_SummaryItem
			{

				private string category;

				private string summaryName;

				private string content;

				public string Category
				{
					get
					{
						return category;
					}
					set	
					{
						category = value;
					}
				}

				public string SummaryName
				{
					get
					{
						return summaryName;
					}
					set	
					{
						summaryName = value;
					}
				}

				public string Content
				{
					get
					{
						return content;
					}
					set	
					{
						content = value;
					}
				}
			}
		}
	}
}
