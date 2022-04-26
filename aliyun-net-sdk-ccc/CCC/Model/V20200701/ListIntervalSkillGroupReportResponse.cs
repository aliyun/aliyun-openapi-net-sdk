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
	public class ListIntervalSkillGroupReportResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private List<ListIntervalSkillGroupReport_DataItem> data;

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

		public List<ListIntervalSkillGroupReport_DataItem> Data
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

		public class ListIntervalSkillGroupReport_DataItem
		{

			private long? statsTime;

			private ListIntervalSkillGroupReport_Inbound inbound;

			private ListIntervalSkillGroupReport_Outbound outbound;

			private ListIntervalSkillGroupReport_Overall overall;

			public long? StatsTime
			{
				get
				{
					return statsTime;
				}
				set	
				{
					statsTime = value;
				}
			}

			public ListIntervalSkillGroupReport_Inbound Inbound
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

			public ListIntervalSkillGroupReport_Outbound Outbound
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

			public ListIntervalSkillGroupReport_Overall Overall
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

			public class ListIntervalSkillGroupReport_Inbound
			{

				private float? averageRingTime;

				private long? callsOverflow;

				private long? callsAbandonedInRing;

				private long? callsHandled;

				private long? totalWorkTime;

				private long? totalAbandonedInRingTime;

				private long? maxWorkTime;

				private long? callsAttendedTransferOut;

				private float? averageWaitTime;

				private long? totalHoldTime;

				private long? maxAbandonTime;

				private float? averageWorkTime;

				private long? callsQueued;

				private long? callsBlindTransferIn;

				private float? satisfactionIndex;

				private float? averageAbandonedInRingTime;

				private float? averageAbandonTime;

				private long? callsRinged;

				private long? callsBlindTransferOut;

				private long? callsAttendedTransferIn;

				private long? callsAbandoned;

				private long? maxAbandonedInQueueTime;

				private long? totalWaitTime;

				private long? totalRingTime;

				private long? maxTalkTime;

				private long? maxRingTime;

				private float? abandonRate;

				private long? totalTalkTime;

				private long? totalAbandonTime;

				private long? callsOffered;

				private long? maxAbandonedInRingTime;

				private long? maxWaitTime;

				private float? averageAbandonedInQueueTime;

				private float? serviceLevel20;

				private long? maxHoldTime;

				private float? satisfactionRate;

				private float? averageTalkTime;

				private long? callsHold;

				private long? satisfactionSurveysOffered;

				private float? handleRate;

				private long? callsTimeout;

				private long? satisfactionSurveysResponded;

				private float? averageHoldTime;

				private long? totalAbandonedInQueueTime;

				private long? callsAbandonedInQueue;

				public float? AverageRingTime
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

				public long? CallsOverflow
				{
					get
					{
						return callsOverflow;
					}
					set	
					{
						callsOverflow = value;
					}
				}

				public long? CallsAbandonedInRing
				{
					get
					{
						return callsAbandonedInRing;
					}
					set	
					{
						callsAbandonedInRing = value;
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

				public long? TotalAbandonedInRingTime
				{
					get
					{
						return totalAbandonedInRingTime;
					}
					set	
					{
						totalAbandonedInRingTime = value;
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

				public long? CallsAttendedTransferOut
				{
					get
					{
						return callsAttendedTransferOut;
					}
					set	
					{
						callsAttendedTransferOut = value;
					}
				}

				public float? AverageWaitTime
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

				public long? TotalHoldTime
				{
					get
					{
						return totalHoldTime;
					}
					set	
					{
						totalHoldTime = value;
					}
				}

				public long? MaxAbandonTime
				{
					get
					{
						return maxAbandonTime;
					}
					set	
					{
						maxAbandonTime = value;
					}
				}

				public float? AverageWorkTime
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

				public long? CallsQueued
				{
					get
					{
						return callsQueued;
					}
					set	
					{
						callsQueued = value;
					}
				}

				public long? CallsBlindTransferIn
				{
					get
					{
						return callsBlindTransferIn;
					}
					set	
					{
						callsBlindTransferIn = value;
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

				public float? AverageAbandonedInRingTime
				{
					get
					{
						return averageAbandonedInRingTime;
					}
					set	
					{
						averageAbandonedInRingTime = value;
					}
				}

				public float? AverageAbandonTime
				{
					get
					{
						return averageAbandonTime;
					}
					set	
					{
						averageAbandonTime = value;
					}
				}

				public long? CallsRinged
				{
					get
					{
						return callsRinged;
					}
					set	
					{
						callsRinged = value;
					}
				}

				public long? CallsBlindTransferOut
				{
					get
					{
						return callsBlindTransferOut;
					}
					set	
					{
						callsBlindTransferOut = value;
					}
				}

				public long? CallsAttendedTransferIn
				{
					get
					{
						return callsAttendedTransferIn;
					}
					set	
					{
						callsAttendedTransferIn = value;
					}
				}

				public long? CallsAbandoned
				{
					get
					{
						return callsAbandoned;
					}
					set	
					{
						callsAbandoned = value;
					}
				}

				public long? MaxAbandonedInQueueTime
				{
					get
					{
						return maxAbandonedInQueueTime;
					}
					set	
					{
						maxAbandonedInQueueTime = value;
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

				public float? AbandonRate
				{
					get
					{
						return abandonRate;
					}
					set	
					{
						abandonRate = value;
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

				public long? TotalAbandonTime
				{
					get
					{
						return totalAbandonTime;
					}
					set	
					{
						totalAbandonTime = value;
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

				public long? MaxAbandonedInRingTime
				{
					get
					{
						return maxAbandonedInRingTime;
					}
					set	
					{
						maxAbandonedInRingTime = value;
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

				public float? AverageAbandonedInQueueTime
				{
					get
					{
						return averageAbandonedInQueueTime;
					}
					set	
					{
						averageAbandonedInQueueTime = value;
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

				public long? MaxHoldTime
				{
					get
					{
						return maxHoldTime;
					}
					set	
					{
						maxHoldTime = value;
					}
				}

				public float? SatisfactionRate
				{
					get
					{
						return satisfactionRate;
					}
					set	
					{
						satisfactionRate = value;
					}
				}

				public float? AverageTalkTime
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

				public long? CallsHold
				{
					get
					{
						return callsHold;
					}
					set	
					{
						callsHold = value;
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

				public long? CallsTimeout
				{
					get
					{
						return callsTimeout;
					}
					set	
					{
						callsTimeout = value;
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

				public float? AverageHoldTime
				{
					get
					{
						return averageHoldTime;
					}
					set	
					{
						averageHoldTime = value;
					}
				}

				public long? TotalAbandonedInQueueTime
				{
					get
					{
						return totalAbandonedInQueueTime;
					}
					set	
					{
						totalAbandonedInQueueTime = value;
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

			public class ListIntervalSkillGroupReport_Outbound
			{

				private float? averageRingTime;

				private long? callsDialed;

				private long? callsAnswered;

				private long? totalWorkTime;

				private long? callsAttendedTransferOut;

				private long? maxWorkTime;

				private long? totalDialingTime;

				private long? totalHoldTime;

				private float? averageWorkTime;

				private long? callsBlindTransferIn;

				private float? satisfactionIndex;

				private long? callsRinged;

				private long? callsAttendedTransferIn;

				private long? callsBlindTransferOut;

				private long? totalRingTime;

				private long? maxTalkTime;

				private long? maxRingTime;

				private long? totalTalkTime;

				private long? maxDialingTime;

				private float? answerRate;

				private long? maxHoldTime;

				private float? averageTalkTime;

				private float? satisfactionRate;

				private long? callsHold;

				private long? satisfactionSurveysOffered;

				private long? satisfactionSurveysResponded;

				private float? averageHoldTime;

				private float? averageDialingTime;

				public float? AverageRingTime
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

				public long? CallsAttendedTransferOut
				{
					get
					{
						return callsAttendedTransferOut;
					}
					set	
					{
						callsAttendedTransferOut = value;
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

				public long? TotalHoldTime
				{
					get
					{
						return totalHoldTime;
					}
					set	
					{
						totalHoldTime = value;
					}
				}

				public float? AverageWorkTime
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

				public long? CallsBlindTransferIn
				{
					get
					{
						return callsBlindTransferIn;
					}
					set	
					{
						callsBlindTransferIn = value;
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

				public long? CallsRinged
				{
					get
					{
						return callsRinged;
					}
					set	
					{
						callsRinged = value;
					}
				}

				public long? CallsAttendedTransferIn
				{
					get
					{
						return callsAttendedTransferIn;
					}
					set	
					{
						callsAttendedTransferIn = value;
					}
				}

				public long? CallsBlindTransferOut
				{
					get
					{
						return callsBlindTransferOut;
					}
					set	
					{
						callsBlindTransferOut = value;
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

				public long? MaxHoldTime
				{
					get
					{
						return maxHoldTime;
					}
					set	
					{
						maxHoldTime = value;
					}
				}

				public float? AverageTalkTime
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

				public float? SatisfactionRate
				{
					get
					{
						return satisfactionRate;
					}
					set	
					{
						satisfactionRate = value;
					}
				}

				public long? CallsHold
				{
					get
					{
						return callsHold;
					}
					set	
					{
						callsHold = value;
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

				public float? AverageHoldTime
				{
					get
					{
						return averageHoldTime;
					}
					set	
					{
						averageHoldTime = value;
					}
				}

				public float? AverageDialingTime
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

			public class ListIntervalSkillGroupReport_Overall
			{

				private long? totalTalkTime;

				private long? totalLoggedInTime;

				private float? occupancyRate;

				private long? totalWorkTime;

				private long? maxHoldTime;

				private long? maxWorkTime;

				private float? averageBreakTime;

				private long? totalHoldTime;

				private float? satisfactionRate;

				private long? maxBreakTime;

				private float? averageWorkTime;

				private float? averageTalkTime;

				private float? satisfactionIndex;

				private long? satisfactionSurveysOffered;

				private long? satisfactionSurveysResponded;

				private long? maxReadyTime;

				private float? averageReadyTime;

				private float? averageHoldTime;

				private long? totalReadyTime;

				private long? totalBreakTime;

				private long? maxTalkTime;

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

				public long? MaxHoldTime
				{
					get
					{
						return maxHoldTime;
					}
					set	
					{
						maxHoldTime = value;
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

				public float? AverageBreakTime
				{
					get
					{
						return averageBreakTime;
					}
					set	
					{
						averageBreakTime = value;
					}
				}

				public long? TotalHoldTime
				{
					get
					{
						return totalHoldTime;
					}
					set	
					{
						totalHoldTime = value;
					}
				}

				public float? SatisfactionRate
				{
					get
					{
						return satisfactionRate;
					}
					set	
					{
						satisfactionRate = value;
					}
				}

				public long? MaxBreakTime
				{
					get
					{
						return maxBreakTime;
					}
					set	
					{
						maxBreakTime = value;
					}
				}

				public float? AverageWorkTime
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

				public float? AverageTalkTime
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

				public float? AverageReadyTime
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

				public float? AverageHoldTime
				{
					get
					{
						return averageHoldTime;
					}
					set	
					{
						averageHoldTime = value;
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
		}
	}
}
