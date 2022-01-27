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
	public class QueryJobsResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private bool? success;

		private QueryJobs_Jobs jobs;

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

				private string failureReason;

				private string jobGroupId;

				private string jobId;

				private int? priority;

				private string referenceId;

				private string scenarioId;

				private string status;

				private string strategyId;

				private List<QueryJobs_Contact> contacts;

				private List<QueryJobs_KeyValuePair> extras;

				private List<QueryJobs_SummaryItem> summary;

				private List<QueryJobs_Task> tasks;

				private List<string> callingNumbers;

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

					private string contactId;

					private string contactName;

					private string honorific;

					private string jobId;

					private string phoneNumber;

					private string referenceId;

					private string role;

					private string state;

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

					private string category;

					private string content;

					private string conversationDetailId;

					private string groupId;

					private string jobId;

					private string summaryId;

					private string summaryName;

					private string taskId;

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
				}

				public class QueryJobs_Task
				{

					private long? actualTime;

					private string brief;

					private string callId;

					private string calledNumber;

					private string callingNumber;

					private string chatbotId;

					private int? duration;

					private string jobId;

					private long? planedTime;

					private string scenarioId;

					private string status;

					private string taskId;

					private QueryJobs_Contact1 contact1;

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

						private string contactId;

						private string contactName;

						private string honorific;

						private string jobId;

						private string phoneNumber;

						private string referenceId;

						private string role;

						private string state;

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
					}
				}
			}
		}
	}
}
