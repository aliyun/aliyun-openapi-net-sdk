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
	public class QueryJobsResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryJobs_Jobs jobs;

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

		public QueryJobs_Jobs Jobs
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

		public class QueryJobs_Jobs
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<QueryJobs_Job> list;

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
				}
			}

			public int? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			public int? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public List<QueryJobs_Job> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class QueryJobs_Job
			{

				private string status;

				private string jobGroupId;

				private string scenarioId;

				private string strategyId;

				private string jobId;

				private int? priority;

				private string failureReason;

				private string referenceId;

				private List<QueryJobs_Contact> contacts;

				private List<QueryJobs_KeyValuePair> extras;

				private List<QueryJobs_SummaryItem> summary;

				private List<QueryJobs_Task> tasks;

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

				public List<QueryJobs_Contact> Contacts
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

				public List<QueryJobs_KeyValuePair> Extras
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

				public List<QueryJobs_SummaryItem> Summary
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

				public List<QueryJobs_Task> Tasks
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

				public class QueryJobs_Contact
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

				public class QueryJobs_KeyValuePair
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

				public class QueryJobs_SummaryItem
				{

					private string summaryName;

					private string groupId;

					private string jobId;

					private string category;

					private string taskId;

					private string content;

					private string conversationDetailId;

					private string summaryId;

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

					public string ConversationDetailId
					{
						get
						{
							return conversationDetailId;
						}
						set	
						{
							conversationDetailId = value;
						}
					}

					public string SummaryId
					{
						get
						{
							return summaryId;
						}
						set	
						{
							summaryId = value;
						}
					}
				}

				public class QueryJobs_Task
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

					private QueryJobs_Contact1 contact1;

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

					public QueryJobs_Contact1 Contact1
					{
						get
						{
							return contact1;
						}
						set	
						{
							contact1 = value;
						}
					}

					public class QueryJobs_Contact1
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
}
