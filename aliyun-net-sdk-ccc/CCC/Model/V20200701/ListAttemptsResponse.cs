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

namespace Aliyun.Acs.CCC.Model.V20200701
{
	public class ListAttemptsResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private ListAttempts_Data data;

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

		public ListAttempts_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ListAttempts_Data
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<ListAttempts_AttemptList> list;

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

			public List<ListAttempts_AttemptList> List
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

			public class ListAttempts_AttemptList
			{

				private string attemptId;

				private string contactId;

				private string caseId;

				private string campaignId;

				private string instanceId;

				private string queueId;

				private string caller;

				private string callee;

				private string agentId;

				private long? dialTime;

				private long? dialDuration;

				private long? customerEstablishedTime;

				private long? customerReleasedTime;

				private long? enterIvrTime;

				private long? ivrDuration;

				private long? enqueueTime;

				private long? queueDuration;

				private long? assignAgentTime;

				private long? agentRingDuration;

				private long? agentEstablishedTime;

				public string AttemptId
				{
					get
					{
						return attemptId;
					}
					set	
					{
						attemptId = value;
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

				public string CaseId
				{
					get
					{
						return caseId;
					}
					set	
					{
						caseId = value;
					}
				}

				public string CampaignId
				{
					get
					{
						return campaignId;
					}
					set	
					{
						campaignId = value;
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

				public string QueueId
				{
					get
					{
						return queueId;
					}
					set	
					{
						queueId = value;
					}
				}

				public string Caller
				{
					get
					{
						return caller;
					}
					set	
					{
						caller = value;
					}
				}

				public string Callee
				{
					get
					{
						return callee;
					}
					set	
					{
						callee = value;
					}
				}

				public string AgentId
				{
					get
					{
						return agentId;
					}
					set	
					{
						agentId = value;
					}
				}

				public long? DialTime
				{
					get
					{
						return dialTime;
					}
					set	
					{
						dialTime = value;
					}
				}

				public long? DialDuration
				{
					get
					{
						return dialDuration;
					}
					set	
					{
						dialDuration = value;
					}
				}

				public long? CustomerEstablishedTime
				{
					get
					{
						return customerEstablishedTime;
					}
					set	
					{
						customerEstablishedTime = value;
					}
				}

				public long? CustomerReleasedTime
				{
					get
					{
						return customerReleasedTime;
					}
					set	
					{
						customerReleasedTime = value;
					}
				}

				public long? EnterIvrTime
				{
					get
					{
						return enterIvrTime;
					}
					set	
					{
						enterIvrTime = value;
					}
				}

				public long? IvrDuration
				{
					get
					{
						return ivrDuration;
					}
					set	
					{
						ivrDuration = value;
					}
				}

				public long? EnqueueTime
				{
					get
					{
						return enqueueTime;
					}
					set	
					{
						enqueueTime = value;
					}
				}

				public long? QueueDuration
				{
					get
					{
						return queueDuration;
					}
					set	
					{
						queueDuration = value;
					}
				}

				public long? AssignAgentTime
				{
					get
					{
						return assignAgentTime;
					}
					set	
					{
						assignAgentTime = value;
					}
				}

				public long? AgentRingDuration
				{
					get
					{
						return agentRingDuration;
					}
					set	
					{
						agentRingDuration = value;
					}
				}

				public long? AgentEstablishedTime
				{
					get
					{
						return agentEstablishedTime;
					}
					set	
					{
						agentEstablishedTime = value;
					}
				}
			}
		}
	}
}
