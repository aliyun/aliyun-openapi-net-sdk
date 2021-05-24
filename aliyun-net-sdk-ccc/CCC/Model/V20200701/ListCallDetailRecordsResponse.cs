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
	public class ListCallDetailRecordsResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private ListCallDetailRecords_Data data;

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

		public ListCallDetailRecords_Data Data
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

		public class ListCallDetailRecords_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListCallDetailRecords_CallDetailRecord> list;

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

			public List<ListCallDetailRecords_CallDetailRecord> List
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

			public class ListCallDetailRecords_CallDetailRecord
			{

				private string agentIds;

				private string agentNames;

				private string callDuration;

				private string calledNumber;

				private string callingNumber;

				private string contactDisposition;

				private string contactId;

				private string contactType;

				private long? establishedTime;

				private string instanceId;

				private bool? recordingReady;

				private string releaseInitiator;

				private long? releaseTime;

				private int? satisfaction;

				private string satisfactionSurveyChannel;

				private bool? satisfactionSurveyOffered;

				private string skillGroupIds;

				private string skillGroupNames;

				private long? startTime;

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

				public string CallDuration
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
			}
		}
	}
}
