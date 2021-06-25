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
	public class DescribeJobResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private bool? success;

		private DescribeJob_Job job;

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

		public DescribeJob_Job Job
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

		public class DescribeJob_Job
		{

			private string failureReason;

			private string jobGroupId;

			private string jobId;

			private int? priority;

			private string referenceId;

			private string scenarioId;

			private string status;

			private string strategyId;

			private int? systemPriority;

			private string instanceId;

			private string dsReport;

			private int? endReason;

			private long? actualTime;

			private string calledNumber;

			private long? nextExecutionTime;

			private List<DescribeJob_Contact> contacts;

			private List<DescribeJob_KeyValuePair> extras;

			private List<DescribeJob_SummaryItem> summary;

			private List<DescribeJob_Task> tasks;

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

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string DsReport
			{
				get
				{
					return dsReport;
				}
				set	
				{
					dsReport = value;
				}
			}

			public int? EndReason
			{
				get
				{
					return endReason;
				}
				set	
				{
					endReason = value;
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

			public long? NextExecutionTime
			{
				get
				{
					return nextExecutionTime;
				}
				set	
				{
					nextExecutionTime = value;
				}
			}

			public List<DescribeJob_Contact> Contacts
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

			public List<DescribeJob_KeyValuePair> Extras
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

			public List<DescribeJob_SummaryItem> Summary
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

			public List<DescribeJob_Task> Tasks
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

			public class DescribeJob_Contact
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

			public class DescribeJob_KeyValuePair
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

			public class DescribeJob_SummaryItem
			{

				private string category;

				private string content;

				private string summaryName;

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
			}

			public class DescribeJob_Task
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

				private long? endTime;

				private List<DescribeJob_ConversationDetail> conversation;

				private DescribeJob_Contact3 contact3;

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

				public long? EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}

				public List<DescribeJob_ConversationDetail> Conversation
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

				public DescribeJob_Contact3 Contact3
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

				public class DescribeJob_ConversationDetail
				{

					private string script;

					private string speaker;

					private long? timestamp;

					private string action;

					private string actionParams;

					private List<DescribeJob_SummaryItem2> summary1;

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

					public string Action
					{
						get
						{
							return action;
						}
						set	
						{
							action = value;
						}
					}

					public string ActionParams
					{
						get
						{
							return actionParams;
						}
						set	
						{
							actionParams = value;
						}
					}

					public List<DescribeJob_SummaryItem2> Summary1
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

					public class DescribeJob_SummaryItem2
					{

						private string category;

						private string content;

						private string summaryName;

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
					}
				}

				public class DescribeJob_Contact3
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
