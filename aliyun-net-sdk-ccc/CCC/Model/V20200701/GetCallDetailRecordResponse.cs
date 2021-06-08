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

namespace Aliyun.Acs.CCC.Model.V20200701
{
	public class GetCallDetailRecordResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private GetCallDetailRecord_Data data;

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

		public GetCallDetailRecord_Data Data
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

		public class GetCallDetailRecord_Data
		{

			private string agentIds;

			private string agentNames;

			private string calledNumber;

			private string callingNumber;

			private string contactDisposition;

			private string contactId;

			private string contactType;

			private long? callDuration;

			private long? establishedTime;

			private string instanceId;

			private long? startTime;

			private long? releaseTime;

			private string skillGroupIds;

			private string skillGroupNames;

			private bool? satisfactionSurveyOffered;

			private int? satisfaction;

			private string satisfactionSurveyChannel;

			private string releaseInitiator;

			private bool? recordingReady;

			private List<GetCallDetailRecord_AgentEventsItem> agentEvents;

			private List<GetCallDetailRecord_IvrEventsItem> ivrEvents;

			private List<GetCallDetailRecord_QueueEventsItem> queueEvents;

			public string AgentIds
			{
				get
				{
					return agentIds;
				}
				set	
				{
					agentIds = value;
				}
			}

			public string AgentNames
			{
				get
				{
					return agentNames;
				}
				set	
				{
					agentNames = value;
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

			public string ContactDisposition
			{
				get
				{
					return contactDisposition;
				}
				set	
				{
					contactDisposition = value;
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

			public string ContactType
			{
				get
				{
					return contactType;
				}
				set	
				{
					contactType = value;
				}
			}

			public long? CallDuration
			{
				get
				{
					return callDuration;
				}
				set	
				{
					callDuration = value;
				}
			}

			public long? EstablishedTime
			{
				get
				{
					return establishedTime;
				}
				set	
				{
					establishedTime = value;
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

			public long? StartTime
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

			public long? ReleaseTime
			{
				get
				{
					return releaseTime;
				}
				set	
				{
					releaseTime = value;
				}
			}

			public string SkillGroupIds
			{
				get
				{
					return skillGroupIds;
				}
				set	
				{
					skillGroupIds = value;
				}
			}

			public string SkillGroupNames
			{
				get
				{
					return skillGroupNames;
				}
				set	
				{
					skillGroupNames = value;
				}
			}

			public bool? SatisfactionSurveyOffered
			{
				get
				{
					return satisfactionSurveyOffered;
				}
				set	
				{
					satisfactionSurveyOffered = value;
				}
			}

			public int? Satisfaction
			{
				get
				{
					return satisfaction;
				}
				set	
				{
					satisfaction = value;
				}
			}

			public string SatisfactionSurveyChannel
			{
				get
				{
					return satisfactionSurveyChannel;
				}
				set	
				{
					satisfactionSurveyChannel = value;
				}
			}

			public string ReleaseInitiator
			{
				get
				{
					return releaseInitiator;
				}
				set	
				{
					releaseInitiator = value;
				}
			}

			public bool? RecordingReady
			{
				get
				{
					return recordingReady;
				}
				set	
				{
					recordingReady = value;
				}
			}

			public List<GetCallDetailRecord_AgentEventsItem> AgentEvents
			{
				get
				{
					return agentEvents;
				}
				set	
				{
					agentEvents = value;
				}
			}

			public List<GetCallDetailRecord_IvrEventsItem> IvrEvents
			{
				get
				{
					return ivrEvents;
				}
				set	
				{
					ivrEvents = value;
				}
			}

			public List<GetCallDetailRecord_QueueEventsItem> QueueEvents
			{
				get
				{
					return queueEvents;
				}
				set	
				{
					queueEvents = value;
				}
			}

			public class GetCallDetailRecord_AgentEventsItem
			{

				private string agentId;

				private string agentName;

				private string skillGroupId;

				private List<GetCallDetailRecord_EventSequenceItem> eventSequence;

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

				public string SkillGroupId
				{
					get
					{
						return skillGroupId;
					}
					set	
					{
						skillGroupId = value;
					}
				}

				public List<GetCallDetailRecord_EventSequenceItem> EventSequence
				{
					get
					{
						return eventSequence;
					}
					set	
					{
						eventSequence = value;
					}
				}

				public class GetCallDetailRecord_EventSequenceItem
				{

					private string _event;

					private long? eventTime;

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

					public long? EventTime
					{
						get
						{
							return eventTime;
						}
						set	
						{
							eventTime = value;
						}
					}
				}
			}

			public class GetCallDetailRecord_IvrEventsItem
			{

				private string flowId;

				private List<GetCallDetailRecord_EventSequenceItem2> eventSequence1;

				public string FlowId
				{
					get
					{
						return flowId;
					}
					set	
					{
						flowId = value;
					}
				}

				public List<GetCallDetailRecord_EventSequenceItem2> EventSequence1
				{
					get
					{
						return eventSequence1;
					}
					set	
					{
						eventSequence1 = value;
					}
				}

				public class GetCallDetailRecord_EventSequenceItem2
				{

					private string _event;

					private long? eventTime;

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

					public long? EventTime
					{
						get
						{
							return eventTime;
						}
						set	
						{
							eventTime = value;
						}
					}
				}
			}

			public class GetCallDetailRecord_QueueEventsItem
			{

				private string flowId;

				private string queueId;

				private string queueName;

				private int? queueType;

				private List<GetCallDetailRecord_EventSequenceItem4> eventSequence3;

				public string FlowId
				{
					get
					{
						return flowId;
					}
					set	
					{
						flowId = value;
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

				public string QueueName
				{
					get
					{
						return queueName;
					}
					set	
					{
						queueName = value;
					}
				}

				public int? QueueType
				{
					get
					{
						return queueType;
					}
					set	
					{
						queueType = value;
					}
				}

				public List<GetCallDetailRecord_EventSequenceItem4> EventSequence3
				{
					get
					{
						return eventSequence3;
					}
					set	
					{
						eventSequence3 = value;
					}
				}

				public class GetCallDetailRecord_EventSequenceItem4
				{

					private string _event;

					private long? eventTime;

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

					public long? EventTime
					{
						get
						{
							return eventTime;
						}
						set	
						{
							eventTime = value;
						}
					}
				}
			}
		}
	}
}
