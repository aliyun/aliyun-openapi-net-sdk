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
	public class ListCallEventDetailByContactIdResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private ListCallEventDetailByContactId_Data data;

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

		public ListCallEventDetailByContactId_Data Data
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

		public class ListCallEventDetailByContactId_Data
		{

			private string caller;

			private string callee;

			private string callType;

			private string startTime;

			private string privacyNumber;

			private string releaseAgent;

			private string releaseReason;

			private List<ListCallEventDetailByContactId_CallEventDetail> events;

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

			public string CallType
			{
				get
				{
					return callType;
				}
				set	
				{
					callType = value;
				}
			}

			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public string PrivacyNumber
			{
				get
				{
					return privacyNumber;
				}
				set	
				{
					privacyNumber = value;
				}
			}

			public string ReleaseAgent
			{
				get
				{
					return releaseAgent;
				}
				set	
				{
					releaseAgent = value;
				}
			}

			public string ReleaseReason
			{
				get
				{
					return releaseReason;
				}
				set	
				{
					releaseReason = value;
				}
			}

			public List<ListCallEventDetailByContactId_CallEventDetail> Events
			{
				get
				{
					return events;
				}
				set	
				{
					events = value;
				}
			}

			public class ListCallEventDetailByContactId_CallEventDetail
			{

				private string timeStamp;

				private string _event;

				private string agentName;

				private string status;

				private string callMode;

				private int? duration;

				private ListCallEventDetailByContactId_DetailData detailData;

				public string TimeStamp
				{
					get
					{
						return timeStamp;
					}
					set	
					{
						timeStamp = value;
					}
				}

				public string _Event
				{
					get
					{
						return _event;
					}
					set	
					{
						_event = value;
					}
				}

				public string AgentName
				{
					get
					{
						return agentName;
					}
					set	
					{
						agentName = value;
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

				public string CallMode
				{
					get
					{
						return callMode;
					}
					set	
					{
						callMode = value;
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

				public ListCallEventDetailByContactId_DetailData DetailData
				{
					get
					{
						return detailData;
					}
					set	
					{
						detailData = value;
					}
				}

				public class ListCallEventDetailByContactId_DetailData
				{

					private string eventType;

					private string helper;

					private string satisfactionalResearch;

					private string skillGroup;

					private string hangUper;

					public string EventType
					{
						get
						{
							return eventType;
						}
						set	
						{
							eventType = value;
						}
					}

					public string Helper
					{
						get
						{
							return helper;
						}
						set	
						{
							helper = value;
						}
					}

					public string SatisfactionalResearch
					{
						get
						{
							return satisfactionalResearch;
						}
						set	
						{
							satisfactionalResearch = value;
						}
					}

					public string SkillGroup
					{
						get
						{
							return skillGroup;
						}
						set	
						{
							skillGroup = value;
						}
					}

					public string HangUper
					{
						get
						{
							return hangUper;
						}
						set	
						{
							hangUper = value;
						}
					}
				}
			}
		}
	}
}
