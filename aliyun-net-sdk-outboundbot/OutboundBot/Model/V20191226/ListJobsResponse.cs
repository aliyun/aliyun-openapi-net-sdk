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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
	public class ListJobsResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private List<ListJobs_Job> jobs;

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

		public List<ListJobs_Job> Jobs
		{
			get
			{
				return jobs;
			}
			set	
			{
				jobs = value;
			}
		}

		public class ListJobs_Job
		{

			private string status;

			private string scenarioId;

			private string jobGroupId;

			private string strategyId;

			private string jobId;

			private int? priority;

			private int? systemPriority;

			private string failureReason;

			private string referenceId;

			private List<ListJobs_Contact> contacts;

			private List<ListJobs_KeyValuePair> extras;

			private List<ListJobs_SummaryItem> summary;

			private List<ListJobs_Task> tasks;

			private List<string> callingNumbers;

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

			public string JobGroupId
			{
				get
				{
					return jobGroupId;
				}
				set	
				{
					jobGroupId = value;
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

			public List<ListJobs_Contact> Contacts
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

			public List<ListJobs_KeyValuePair> Extras
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

			public List<ListJobs_SummaryItem> Summary
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

			public List<ListJobs_Task> Tasks
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

			public class ListJobs_Contact
			{

				private string phoneNumber;

				private string state;

				private string contactId;

				private string honorific;

				private string jobId;

				private string contactName;

				private string role;

				private string referenceId;

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

			public class ListJobs_KeyValuePair
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

			public class ListJobs_SummaryItem
			{

				private string summaryName;

				private string category;

				private string content;

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

			public class ListJobs_Task
			{

				private string status;

				private long? planedTime;

				private string chatbotId;

				private long? actualTime;

				private string calledNumber;

				private string scenarioId;

				private string jobId;

				private string callId;

				private string callingNumber;

				private string brief;

				private int? duration;

				private string taskId;

				private List<ListJobs_ConversationDetail> conversation;

				private ListJobs_Contact3 contact3;

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

				public List<ListJobs_ConversationDetail> Conversation
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

				public ListJobs_Contact3 Contact3
				{
					get
					{
						return contact3;
					}
					set	
					{
						contact3 = value;
					}
				}

				public class ListJobs_ConversationDetail
				{

					private string speaker;

					private long? timestamp;

					private string script;

					private List<ListJobs_SummaryItem2> summary1;

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

					public List<ListJobs_SummaryItem2> Summary1
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

					public class ListJobs_SummaryItem2
					{

						private string summaryName;

						private string category;

						private string content;

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

				public class ListJobs_Contact3
				{

					private string phoneNumber;

					private string state;

					private string contactId;

					private string honorific;

					private string jobId;

					private string contactName;

					private string role;

					private string referenceId;

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
		}
	}
}
