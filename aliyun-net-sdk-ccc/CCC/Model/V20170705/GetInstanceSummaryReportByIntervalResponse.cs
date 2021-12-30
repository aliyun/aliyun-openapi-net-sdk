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
	public class GetInstanceSummaryReportByIntervalResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport instanceTimeIntervalReport;

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

		public GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport InstanceTimeIntervalReport
		{
			get
			{
				return instanceTimeIntervalReport;
			}
			set	
			{
				instanceTimeIntervalReport = value;
			}
		}

		public class GetInstanceSummaryReportByInterval_InstanceTimeIntervalReport
		{

			private string instanceId;

			private List<GetInstanceSummaryReportByInterval_InstanceSummaryReport> intervalList;

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

			public List<GetInstanceSummaryReportByInterval_InstanceSummaryReport> IntervalList
			{
				get
				{
					return intervalList;
				}
				set	
				{
					intervalList = value;
				}
			}

			public class GetInstanceSummaryReportByInterval_InstanceSummaryReport
			{

				private string instanceId;

				private string timestamp;

				private GetInstanceSummaryReportByInterval_Overall overall;

				private GetInstanceSummaryReportByInterval_Inbound inbound;

				private GetInstanceSummaryReportByInterval_Outbound outbound;

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

				public GetInstanceSummaryReportByInterval_Overall Overall
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

				public GetInstanceSummaryReportByInterval_Inbound Inbound
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

				public GetInstanceSummaryReportByInterval_Outbound Outbound
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

				public class GetInstanceSummaryReportByInterval_Overall
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

				public class GetInstanceSummaryReportByInterval_Inbound
				{

					private long? callsIncomingLine;

					private long? averageRingTime;

					private long? callsHandled;

					private long? totalWorkTime;

					private long? callsAbandonedInIVR;

					private long? maxWorkTime;

					private long? averageWaitTime;

					private long? callsIncomingQueue;

					private long? averageWorkTime;

					private float? satisfactionIndex;

					private long? totalWaitTime;

					private long? totalRingTime;

					private string maxTalkTime;

					private long? maxRingTime;

					private long? callsIncomingIVR;

					private long? totalTalkTime;

					private long? callsOffered;

					private long? maxWaitTime;

					private float? serviceLevel20;

					private long? averageTalkTime;

					private long? satisfactionSurveysOffered;

					private float? handleRate;

					private long? satisfactionSurveysResponded;

					private long? callsAbandonedInQueue;

					public long? CallsIncomingLine
					{
						get
						{
							return callsIncomingLine;
						}
						set	
						{
							callsIncomingLine = value;
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

					public long? CallsAbandonedInIVR
					{
						get
						{
							return callsAbandonedInIVR;
						}
						set	
						{
							callsAbandonedInIVR = value;
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

					public long? AverageWaitTime
					{
						get
						{
							return averageWaitTime;
						}
						set	
						{
							averageWaitTime = value;
						}
					}

					public long? CallsIncomingQueue
					{
						get
						{
							return callsIncomingQueue;
						}
						set	
						{
							callsIncomingQueue = value;
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

					public long? TotalWaitTime
					{
						get
						{
							return totalWaitTime;
						}
						set	
						{
							totalWaitTime = value;
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

					public long? CallsIncomingIVR
					{
						get
						{
							return callsIncomingIVR;
						}
						set	
						{
							callsIncomingIVR = value;
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

					public long? MaxWaitTime
					{
						get
						{
							return maxWaitTime;
						}
						set	
						{
							maxWaitTime = value;
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

					public long? CallsAbandonedInQueue
					{
						get
						{
							return callsAbandonedInQueue;
						}
						set	
						{
							callsAbandonedInQueue = value;
						}
					}
				}

				public class GetInstanceSummaryReportByInterval_Outbound
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
