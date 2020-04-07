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
	public class ListCallDetailRecordsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private ListCallDetailRecords_CallDetailRecords callDetailRecords;

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

		public ListCallDetailRecords_CallDetailRecords CallDetailRecords
		{
			get
			{
				return callDetailRecords;
			}
			set	
			{
				callDetailRecords = value;
			}
		}

		public class ListCallDetailRecords_CallDetailRecords
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<ListCallDetailRecords_CallDetailRecord> list;

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

				private string contactId;

				private long? startTime;

				private int? duration;

				private int? satisfaction;

				private string satisfactionDesc;

				private string feedback;

				private string contactType;

				private string contactDisposition;

				private string callingNumber;

				private string calledNumber;

				private string agentNames;

				private string skillGroupNames;

				private string instanceId;

				private string skillGroupIdList;

				private List<ListCallDetailRecords_CallDetailAgent> agents;

				private List<ListCallDetailRecords_Recording> recordings;

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

				public string SatisfactionDesc
				{
					get
					{
						return satisfactionDesc;
					}
					set	
					{
						satisfactionDesc = value;
					}
				}

				public string Feedback
				{
					get
					{
						return feedback;
					}
					set	
					{
						feedback = value;
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

				public string SkillGroupIdList
				{
					get
					{
						return skillGroupIdList;
					}
					set	
					{
						skillGroupIdList = value;
					}
				}

				public List<ListCallDetailRecords_CallDetailAgent> Agents
				{
					get
					{
						return agents;
					}
					set	
					{
						agents = value;
					}
				}

				public List<ListCallDetailRecords_Recording> Recordings
				{
					get
					{
						return recordings;
					}
					set	
					{
						recordings = value;
					}
				}

				public class ListCallDetailRecords_CallDetailAgent
				{

					private string agentId;

					private string satisfaction;

					private string feedback;

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

					public string Satisfaction
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

					public string Feedback
					{
						get
						{
							return feedback;
						}
						set	
						{
							feedback = value;
						}
					}
				}

				public class ListCallDetailRecords_Recording
				{

					private string contactId;

					private string agentId;

					private string agentName;

					private long? startTime;

					private int? duration;

					private string fileName;

					private string fileDescription;

					private string qualityCheckTid;

					private string qualityCheckTaskId;

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

					public string FileName
					{
						get
						{
							return fileName;
						}
						set	
						{
							fileName = value;
						}
					}

					public string FileDescription
					{
						get
						{
							return fileDescription;
						}
						set	
						{
							fileDescription = value;
						}
					}

					public string QualityCheckTid
					{
						get
						{
							return qualityCheckTid;
						}
						set	
						{
							qualityCheckTid = value;
						}
					}

					public string QualityCheckTaskId
					{
						get
						{
							return qualityCheckTaskId;
						}
						set	
						{
							qualityCheckTaskId = value;
						}
					}
				}
			}
		}
	}
}
