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

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
	public class ListConversationsWithUnrecognizedIntentsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private List<ListConversationsWithUnrecognizedIntents_ConversationsWithUnrecognizedIntent> conversationsWithUnrecognizedIntents;

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

		public List<ListConversationsWithUnrecognizedIntents_ConversationsWithUnrecognizedIntent> ConversationsWithUnrecognizedIntents
		{
			get
			{
				return conversationsWithUnrecognizedIntents;
			}
			set	
			{
				conversationsWithUnrecognizedIntents = value;
			}
		}

		public class ListConversationsWithUnrecognizedIntents_ConversationsWithUnrecognizedIntent
		{

			private string conversationsWithUnrecognizedIntentId;

			private string jobId;

			private List<ListConversationsWithUnrecognizedIntents_ConversationDetail> conversation;

			private ListConversationsWithUnrecognizedIntents_Contact contact;

			public string ConversationsWithUnrecognizedIntentId
			{
				get
				{
					return conversationsWithUnrecognizedIntentId;
				}
				set	
				{
					conversationsWithUnrecognizedIntentId = value;
				}
			}

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
				}
			}

			public List<ListConversationsWithUnrecognizedIntents_ConversationDetail> Conversation
			{
				get
				{
					return conversation;
				}
				set	
				{
					conversation = value;
				}
			}

			public ListConversationsWithUnrecognizedIntents_Contact Contact
			{
				get
				{
					return contact;
				}
				set	
				{
					contact = value;
				}
			}

			public class ListConversationsWithUnrecognizedIntents_ConversationDetail
			{

				private string id;

				private long? timestamp;

				private string speaker;

				private string script;

				private string nodeId;

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

				public string NodeId
				{
					get
					{
						return nodeId;
					}
					set	
					{
						nodeId = value;
					}
				}
			}

			public class ListConversationsWithUnrecognizedIntents_Contact
			{

				private string contactId;

				private string contactName;

				private string honorific;

				private string role;

				private string phoneNumber;

				private string state;

				private string referenceId;

				private string jobId;

				public string ContactId
				{
					get
					{
						return contactId;
					}
					set	
					{
						contactId = value;
					}
				}

				public string ContactName
				{
					get
					{
						return contactName;
					}
					set	
					{
						contactName = value;
					}
				}

				public string Honorific
				{
					get
					{
						return honorific;
					}
					set	
					{
						honorific = value;
					}
				}

				public string Role
				{
					get
					{
						return role;
					}
					set	
					{
						role = value;
					}
				}

				public string PhoneNumber
				{
					get
					{
						return phoneNumber;
					}
					set	
					{
						phoneNumber = value;
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

				public string ReferenceId
				{
					get
					{
						return referenceId;
					}
					set	
					{
						referenceId = value;
					}
				}

				public string JobId
				{
					get
					{
						return jobId;
					}
					set	
					{
						jobId = value;
					}
				}
			}
		}
	}
}
