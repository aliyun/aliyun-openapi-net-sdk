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
	public class ListSkillGroupSummaryReportsSinceMidnightResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport pagedSkillGroupSummaryReport;

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

		public ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport PagedSkillGroupSummaryReport
		{
			get
			{
				return pagedSkillGroupSummaryReport;
			}
			set	
			{
				pagedSkillGroupSummaryReport = value;
			}
		}

		public class ListSkillGroupSummaryReportsSinceMidnight_PagedSkillGroupSummaryReport
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport> list;

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

			public List<ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport> List
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

			public class ListSkillGroupSummaryReportsSinceMidnight_SkillGroupSummaryReport
			{

				private string timestamp;

				private string instanceId;

				private string skillGroupName;

				private string skillGroupId;

				private ListSkillGroupSummaryReportsSinceMidnight_Overall overall;

				private ListSkillGroupSummaryReportsSinceMidnight_Inbound inbound;

				private ListSkillGroupSummaryReportsSinceMidnight_Outbound outbound;

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

				public string SkillGroupName
				{
					get
					{
						return skillGroupName;
					}
					set	
					{
						skillGroupName = value;
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

				public ListSkillGroupSummaryReportsSinceMidnight_Overall Overall
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

				public ListSkillGroupSummaryReportsSinceMidnight_Inbound Inbound
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

				public ListSkillGroupSummaryReportsSinceMidnight_Outbound Outbound
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

				public class ListSkillGroupSummaryReportsSinceMidnight_Overall
				{

					private long? totalLoggedInTime;

					private long? totalTalkTime;

					private float? occupancyRate;

					private long? totalWorkTime;

					private long? maxWorkTime;

					private long? averageWorkTime;

					private long? averageTalkTime;

					private float? satisfactionIndex;

					private long? satisfactionSurveysOffered;

					private long? satisfactionSurveysResponded;

					private long? maxReadyTime;

					private long? averageReadyTime;

					private long? totalBreakTime;

					private long? totalReadyTime;

					private long? maxTalkTime;

					private long? totalCalls;

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

				public class ListSkillGroupSummaryReportsSinceMidnight_Inbound
				{

					private long? averageRingTime;

					private long? callsHandled;

					private long? totalWorkTime;

					private long? maxWorkTime;

					private long? queueMaxWaitTimeDuration;

					private long? averageWorkTime;

					private float? satisfactionIndex;

					private long? answeredByAgentOfQueueWaitTimeDuration;

					private long? totalRingTime;

					private long? inComingQueueOfQueueCount;

					private string maxTalkTime;

					private long? maxRingTime;

					private long? totalTalkTime;

					private long? callsOffered;

					private long? abandonedInQueueOfQueueCount;

					private long? overFlowInQueueOfQueueCount;

					private long? answeredByAgentOfQueueMaxWaitTimeDuration;

					private float? serviceLevel20;

					private long? averageTalkTime;

					private long? answeredByAgentOfQueueCount;

					private long? satisfactionSurveysOffered;

					private float? handleRate;

					private long? satisfactionSurveysResponded;

					private long? giveUpByAgentOfQueueCount;

					private long? queueWaitTimeDuration;

					private long? callsServiceLevel20;

					private long? callsServiceLevel30;

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

					public long? QueueMaxWaitTimeDuration
					{
						get
						{
							return queueMaxWaitTimeDuration;
						}
						set	
						{
							queueMaxWaitTimeDuration = value;
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

					public long? AnsweredByAgentOfQueueWaitTimeDuration
					{
						get
						{
							return answeredByAgentOfQueueWaitTimeDuration;
						}
						set	
						{
							answeredByAgentOfQueueWaitTimeDuration = value;
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

					public long? InComingQueueOfQueueCount
					{
						get
						{
							return inComingQueueOfQueueCount;
						}
						set	
						{
							inComingQueueOfQueueCount = value;
						}
					}

					public string MaxTalkTime
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

					public long? AbandonedInQueueOfQueueCount
					{
						get
						{
							return abandonedInQueueOfQueueCount;
						}
						set	
						{
							abandonedInQueueOfQueueCount = value;
						}
					}

					public long? OverFlowInQueueOfQueueCount
					{
						get
						{
							return overFlowInQueueOfQueueCount;
						}
						set	
						{
							overFlowInQueueOfQueueCount = value;
						}
					}

					public long? AnsweredByAgentOfQueueMaxWaitTimeDuration
					{
						get
						{
							return answeredByAgentOfQueueMaxWaitTimeDuration;
						}
						set	
						{
							answeredByAgentOfQueueMaxWaitTimeDuration = value;
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

					public long? AnsweredByAgentOfQueueCount
					{
						get
						{
							return answeredByAgentOfQueueCount;
						}
						set	
						{
							answeredByAgentOfQueueCount = value;
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

					public long? GiveUpByAgentOfQueueCount
					{
						get
						{
							return giveUpByAgentOfQueueCount;
						}
						set	
						{
							giveUpByAgentOfQueueCount = value;
						}
					}

					public long? QueueWaitTimeDuration
					{
						get
						{
							return queueWaitTimeDuration;
						}
						set	
						{
							queueWaitTimeDuration = value;
						}
					}

					public long? CallsServiceLevel20
					{
						get
						{
							return callsServiceLevel20;
						}
						set	
						{
							callsServiceLevel20 = value;
						}
					}

					public long? CallsServiceLevel30
					{
						get
						{
							return callsServiceLevel30;
						}
						set	
						{
							callsServiceLevel30 = value;
						}
					}
				}

				public class ListSkillGroupSummaryReportsSinceMidnight_Outbound
				{

					private long? totalTalkTime;

					private long? maxDialingTime;

					private long? callsDialed;

					private long? callsAnswered;

					private float? answerRate;

					private long? totalWorkTime;

					private long? maxWorkTime;

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
