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
	public class GetJobResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private GetJob_Job job;

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

		public GetJob_Job Job
		{
			get
			{
				return job;
			}
			set	
			{
				job = value;
			}
		}

		public class GetJob_Job
		{

			private string jobId;

			private string groupId;

			private string scenarioId;

			private string strategyId;

			private int? priority;

			private int? systemPriority;

			private string status;

			private string referenceId;

			private string failureReason;

			private List<GetJob_Contact> contacts;

			private List<GetJob_KeyValuePair> extras;

			private List<GetJob_Task> tasks;

			private List<GetJob_SummaryItem3> summary;

			private List<string> callingNumbers;

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

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string ScenarioId
			{
				get
				{
					return scenarioId;
				}
				set	
				{
					scenarioId = value;
				}
			}

			public string StrategyId
			{
				get
				{
					return strategyId;
				}
				set	
				{
					strategyId = value;
				}
			}

			public int? Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public int? SystemPriority
			{
				get
				{
					return systemPriority;
				}
				set	
				{
					systemPriority = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
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

			public string FailureReason
			{
				get
				{
					return failureReason;
				}
				set	
				{
					failureReason = value;
				}
			}

			public List<GetJob_Contact> Contacts
			{
				get
				{
					return contacts;
				}
				set	
				{
					contacts = value;
				}
			}

			public List<GetJob_KeyValuePair> Extras
			{
				get
				{
					return extras;
				}
				set	
				{
					extras = value;
				}
			}

			public List<GetJob_Task> Tasks
			{
				get
				{
					return tasks;
				}
				set	
				{
					tasks = value;
				}
			}

			public List<GetJob_SummaryItem3> Summary
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

			public List<string> CallingNumbers
			{
				get
				{
					return callingNumbers;
				}
				set	
				{
					callingNumbers = value;
				}
			}

			public class GetJob_Contact
			{

				private string contactId;

				private string contactName;

				private string honorific;

				private string role;

				private string phoneNumber;

				private string state;

				private string referenceId;

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
			}

			public class GetJob_KeyValuePair
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class GetJob_Task
			{

				private string taskId;

				private string jobId;

				private string scenarioId;

				private string chatbotId;

				private long? planedTime;

				private long? actualTime;

				private string callingNumber;

				private string calledNumber;

				private string callId;

				private string status;

				private string brief;

				private int? duration;

				private List<GetJob_ConversationDetail> conversation;

				private GetJob_Contact2 contact2;

				public string TaskId
				{
					get
					{
						return taskId;
					}
					set	
					{
						taskId = value;
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

				public string ScenarioId
				{
					get
					{
						return scenarioId;
					}
					set	
					{
						scenarioId = value;
					}
				}

				public string ChatbotId
				{
					get
					{
						return chatbotId;
					}
					set	
					{
						chatbotId = value;
					}
				}

				public long? PlanedTime
				{
					get
					{
						return planedTime;
					}
					set	
					{
						planedTime = value;
					}
				}

				public long? ActualTime
				{
					get
					{
						return actualTime;
					}
					set	
					{
						actualTime = value;
					}
				}

				public string CallingNumber
				{
					get
					{
						return callingNumber;
					}
					set	
					{
						callingNumber = value;
					}
				}

				public string CalledNumber
				{
					get
					{
						return calledNumber;
					}
					set	
					{
						calledNumber = value;
					}
				}

				public string CallId
				{
					get
					{
						return callId;
					}
					set	
					{
						callId = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public string Brief
				{
					get
					{
						return brief;
					}
					set	
					{
						brief = value;
					}
				}

				public int? Duration
				{
					get
					{
						return duration;
					}
					set	
					{
						duration = value;
					}
				}

				public List<GetJob_ConversationDetail> Conversation
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

				public GetJob_Contact2 Contact2
				{
					get
					{
						return contact2;
					}
					set	
					{
						contact2 = value;
					}
				}

				public class GetJob_ConversationDetail
				{

					private long? timestamp;

					private string speaker;

					private string script;

					private List<GetJob_SummaryItem> summary1;

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

					public List<GetJob_SummaryItem> Summary1
					{
						get
						{
							return summary1;
						}
						set	
						{
							summary1 = value;
						}
					}

					public class GetJob_SummaryItem
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

				public class GetJob_Contact2
				{

					private string contactId;

					private string contactName;

					private string honorific;

					private string role;

					private string phoneNumber;

					private string state;

					private string referenceId;

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
				}
			}

			public class GetJob_SummaryItem3
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
