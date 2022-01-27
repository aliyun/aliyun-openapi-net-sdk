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
	public class ListJobsByGroupResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private bool? success;

		private ListJobsByGroup_Jobs jobs;

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

		public ListJobsByGroup_Jobs Jobs
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

		public class ListJobsByGroup_Jobs
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListJobsByGroup_Job> list;

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

			public List<ListJobsByGroup_Job> List
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

			public class ListJobsByGroup_Job
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

				private List<ListJobsByGroup_Contact> contacts;

				private List<ListJobsByGroup_KeyValuePair> extras;

				private List<ListJobsByGroup_SummaryItem> summary;

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

				public List<ListJobsByGroup_Contact> Contacts
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

				public List<ListJobsByGroup_KeyValuePair> Extras
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

				public List<ListJobsByGroup_SummaryItem> Summary
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

				public class ListJobsByGroup_Contact
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

				public class ListJobsByGroup_KeyValuePair
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

				public class ListJobsByGroup_SummaryItem
				{

					private string category;

					private string content;

					private string conversationDetailId;

					private string jobGroupId;

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
			}
		}
	}
}
