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
	public class ListAgentSummaryReportsSinceMidnightResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport pagedAgentSummaryReport;

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

		public ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport PagedAgentSummaryReport
		{
			get
			{
				return pagedAgentSummaryReport;
			}
			set	
			{
				pagedAgentSummaryReport = value;
			}
		}

		public class ListAgentSummaryReportsSinceMidnight_PagedAgentSummaryReport
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListAgentSummaryReportsSinceMidnight_AgentSummaryReport> list;

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

			public List<ListAgentSummaryReportsSinceMidnight_AgentSummaryReport> List
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

			public class ListAgentSummaryReportsSinceMidnight_AgentSummaryReport
			{

				private string loginName;

				private string agentId;

				private string agentName;

				private string skillGroupNames;

				private string timestamp;

				private string instanceId;

				private string skillGroupIds;

				private ListAgentSummaryReportsSinceMidnight_Overall overall;

				private ListAgentSummaryReportsSinceMidnight_Inbound inbound;

				private ListAgentSummaryReportsSinceMidnight_Outbound outbound;

				public string LoginName
				{
					get
					{
						return loginName;
					}
					set	
					{
						loginName = value;
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

				public string Timestamp
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

				public ListAgentSummaryReportsSinceMidnight_Overall Overall
				{
					get
					{
						return overall;
					}
					set	
					{
						overall = value;
					}
				}

				public ListAgentSummaryReportsSinceMidnight_Inbound Inbound
				{
					get
					{
						return inbound;
					}
					set	
					{
						inbound = value;
					}
				}

				public ListAgentSummaryReportsSinceMidnight_Outbound Outbound
				{
					get
					{
						return outbound;
					}
					set	
					{
						outbound = value;
					}
				}

				public class ListAgentSummaryReportsSinceMidnight_Overall
				{

					private long? totalTalkTime;

					private long? totalLoggedInTime;

					private float? occupancyRate;

					private long? totalWorkTime;

					private long? maxWorkTime;

					private long? averageWorkTime;

					private long? averageTalkTime;

					private float? satisfactionIndex;

					private long? satisfactionSurveysOffered;

					private long? satisfactionSurveysResponded;

					private long? averageReadyTime;

					private long? maxReadyTime;

					private long? oneTransferCalls;

					private long? maxTalkTime;

					private long? totalReadyTime;

					private long? totalBreakTime;

					private long? totalCalls;

					public long? TotalTalkTime
					{
						get
						{
							return totalTalkTime;
						}
						set	
						{
							totalTalkTime = value;
						}
					}

					public long? TotalLoggedInTime
					{
						get
						{
							return totalLoggedInTime;
						}
						set	
						{
							totalLoggedInTime = value;
						}
					}

					public float? OccupancyRate
					{
						get
						{
							return occupancyRate;
						}
						set	
						{
							occupancyRate = value;
						}
					}

					public long? TotalWorkTime
					{
						get
						{
							return totalWorkTime;
						}
						set	
						{
							totalWorkTime = value;
						}
					}

					public long? MaxWorkTime
					{
						get
						{
							return maxWorkTime;
						}
						set	
						{
							maxWorkTime = value;
						}
					}

					public long? AverageWorkTime
					{
						get
						{
							return averageWorkTime;
						}
						set	
						{
							averageWorkTime = value;
						}
					}

					public long? AverageTalkTime
					{
						get
						{
							return averageTalkTime;
						}
						set	
						{
							averageTalkTime = value;
						}
					}

					public float? SatisfactionIndex
					{
						get
						{
							return satisfactionIndex;
						}
						set	
						{
							satisfactionIndex = value;
						}
					}

					public long? SatisfactionSurveysOffered
					{
						get
						{
							return satisfactionSurveysOffered;
						}
						set	
						{
							satisfactionSurveysOffered = value;
						}
					}

					public long? SatisfactionSurveysResponded
					{
						get
						{
							return satisfactionSurveysResponded;
						}
						set	
						{
							satisfactionSurveysResponded = value;
						}
					}

					public long? AverageReadyTime
					{
						get
						{
							return averageReadyTime;
						}
						set	
						{
							averageReadyTime = value;
						}
					}

					public long? MaxReadyTime
					{
						get
						{
							return maxReadyTime;
						}
						set	
						{
							maxReadyTime = value;
						}
					}

					public long? OneTransferCalls
					{
						get
						{
							return oneTransferCalls;
						}
						set	
						{
							oneTransferCalls = value;
						}
					}

					public long? MaxTalkTime
					{
						get
						{
							return maxTalkTime;
						}
						set	
						{
							maxTalkTime = value;
						}
					}

					public long? TotalReadyTime
					{
						get
						{
							return totalReadyTime;
						}
						set	
						{
							totalReadyTime = value;
						}
					}

					public long? TotalBreakTime
					{
						get
						{
							return totalBreakTime;
						}
						set	
						{
							totalBreakTime = value;
						}
					}

					public long? TotalCalls
					{
						get
						{
							return totalCalls;
						}
						set	
						{
							totalCalls = value;
						}
					}
				}

				public class ListAgentSummaryReportsSinceMidnight_Inbound
				{

					private long? totalTalkTime;

					private long? callsOffered;

					private long? averageRingTime;

					private long? callsHandled;

					private float? serviceLevel20;

					private long? totalWorkTime;

					private long? maxWorkTime;

					private long? averageWorkTime;

					private long? averageTalkTime;

					private float? satisfactionIndex;

					private long? satisfactionSurveysOffered;

					private float? handleRate;

					private long? satisfactionSurveysResponded;

					private long? totalRingTime;

					private long? maxTalkTime;

					private long? maxRingTime;

					public long? TotalTalkTime
					{
						get
						{
							return totalTalkTime;
						}
						set	
						{
							totalTalkTime = value;
						}
					}

					public long? CallsOffered
					{
						get
						{
							return callsOffered;
						}
						set	
						{
							callsOffered = value;
						}
					}

					public long? AverageRingTime
					{
						get
						{
							return averageRingTime;
						}
						set	
						{
							averageRingTime = value;
						}
					}

					public long? CallsHandled
					{
						get
						{
							return callsHandled;
						}
						set	
						{
							callsHandled = value;
						}
					}

					public float? ServiceLevel20
					{
						get
						{
							return serviceLevel20;
						}
						set	
						{
							serviceLevel20 = value;
						}
					}

					public long? TotalWorkTime
					{
						get
						{
							return totalWorkTime;
						}
						set	
						{
							totalWorkTime = value;
						}
					}

					public long? MaxWorkTime
					{
						get
						{
							return maxWorkTime;
						}
						set	
						{
							maxWorkTime = value;
						}
					}

					public long? AverageWorkTime
					{
						get
						{
							return averageWorkTime;
						}
						set	
						{
							averageWorkTime = value;
						}
					}

					public long? AverageTalkTime
					{
						get
						{
							return averageTalkTime;
						}
						set	
						{
							averageTalkTime = value;
						}
					}

					public float? SatisfactionIndex
					{
						get
						{
							return satisfactionIndex;
						}
						set	
						{
							satisfactionIndex = value;
						}
					}

					public long? SatisfactionSurveysOffered
					{
						get
						{
							return satisfactionSurveysOffered;
						}
						set	
						{
							satisfactionSurveysOffered = value;
						}
					}

					public float? HandleRate
					{
						get
						{
							return handleRate;
						}
						set	
						{
							handleRate = value;
						}
					}

					public long? SatisfactionSurveysResponded
					{
						get
						{
							return satisfactionSurveysResponded;
						}
						set	
						{
							satisfactionSurveysResponded = value;
						}
					}

					public long? TotalRingTime
					{
						get
						{
							return totalRingTime;
						}
						set	
						{
							totalRingTime = value;
						}
					}

					public long? MaxTalkTime
					{
						get
						{
							return maxTalkTime;
						}
						set	
						{
							maxTalkTime = value;
						}
					}

					public long? MaxRingTime
					{
						get
						{
							return maxRingTime;
						}
						set	
						{
							maxRingTime = value;
						}
					}
				}

				public class ListAgentSummaryReportsSinceMidnight_Outbound
				{

					private long? totalTalkTime;

					private long? maxDialingTime;

					private long? callsDialed;

					private long? callsAnswered;

					private float? answerRate;

					private long? totalWorkTime;

					private string maxWorkTime;

					private long? totalDialingTime;

					private long? averageTalkTime;

					private long? averageWorkTime;

					private float? satisfactionIndex;

					private long? satisfactionSurveysOffered;

					private long? satisfactionSurveysResponded;

					private long? maxTalkTime;

					private long? averageDialingTime;

					public long? TotalTalkTime
					{
						get
						{
							return totalTalkTime;
						}
						set	
						{
							totalTalkTime = value;
						}
					}

					public long? MaxDialingTime
					{
						get
						{
							return maxDialingTime;
						}
						set	
						{
							maxDialingTime = value;
						}
					}

					public long? CallsDialed
					{
						get
						{
							return callsDialed;
						}
						set	
						{
							callsDialed = value;
						}
					}

					public long? CallsAnswered
					{
						get
						{
							return callsAnswered;
						}
						set	
						{
							callsAnswered = value;
						}
					}

					public float? AnswerRate
					{
						get
						{
							return answerRate;
						}
						set	
						{
							answerRate = value;
						}
					}

					public long? TotalWorkTime
					{
						get
						{
							return totalWorkTime;
						}
						set	
						{
							totalWorkTime = value;
						}
					}

					public string MaxWorkTime
					{
						get
						{
							return maxWorkTime;
						}
						set	
						{
							maxWorkTime = value;
						}
					}

					public long? TotalDialingTime
					{
						get
						{
							return totalDialingTime;
						}
						set	
						{
							totalDialingTime = value;
						}
					}

					public long? AverageTalkTime
					{
						get
						{
							return averageTalkTime;
						}
						set	
						{
							averageTalkTime = value;
						}
					}

					public long? AverageWorkTime
					{
						get
						{
							return averageWorkTime;
						}
						set	
						{
							averageWorkTime = value;
						}
					}

					public float? SatisfactionIndex
					{
						get
						{
							return satisfactionIndex;
						}
						set	
						{
							satisfactionIndex = value;
						}
					}

					public long? SatisfactionSurveysOffered
					{
						get
						{
							return satisfactionSurveysOffered;
						}
						set	
						{
							satisfactionSurveysOffered = value;
						}
					}

					public long? SatisfactionSurveysResponded
					{
						get
						{
							return satisfactionSurveysResponded;
						}
						set	
						{
							satisfactionSurveysResponded = value;
						}
					}

					public long? MaxTalkTime
					{
						get
						{
							return maxTalkTime;
						}
						set	
						{
							maxTalkTime = value;
						}
					}

					public long? AverageDialingTime
					{
						get
						{
							return averageDialingTime;
						}
						set	
						{
							averageDialingTime = value;
						}
					}
				}
			}
		}
	}
}
