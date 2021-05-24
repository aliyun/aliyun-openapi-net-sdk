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
	public class ListIntervalInstanceReportResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private List<ListIntervalInstanceReport_DataItem> data;

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

		public List<ListIntervalInstanceReport_DataItem> Data
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

		public class ListIntervalInstanceReport_DataItem
		{

			private long? statsTime;

			private ListIntervalInstanceReport_Inbound inbound;

			private ListIntervalInstanceReport_Outbound outbound;

			private ListIntervalInstanceReport_Overall overall;

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

			public ListIntervalInstanceReport_Inbound Inbound
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

			public ListIntervalInstanceReport_Outbound Outbound
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

			public ListIntervalInstanceReport_Overall Overall
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

			public class ListIntervalInstanceReport_Inbound
			{

				private float? abandonedRate;

				private float? averageAbandonTime;

				private float? averageAbandonedInIVRTime;

				private float? averageAbandonedInQueueTime;

				private float? averageAbandonedInRingTime;

				private float? averageHoldTime;

				private float? averageRingTime;

				private float? averageTalkTime;

				private float? averageWaitTime;

				private float? averageWorkTime;

				private long? callsAbandoned;

				private long? callsAbandonedInIVR;

				private long? callsAbandonedInQueue;

				private long? callsAbandonedInRinging;

				private long? callsConsulted;

				private long? callsHandled;

				private long? callsHold;

				private long? callsOffered;

				private long? callsQueued;

				private long? callsRinged;

				private long? callsTransferred;

				private float? handleRate;

				private long? maxAbandonTime;

				private long? maxAbandonedInIVRTime;

				private long? maxAbandonedInQueueTime;

				private long? maxAbandonedInRingTime;

				private long? maxHoldTime;

				private long? maxRingTime;

				private long? maxTalkTime;

				private long? maxWaitTime;

				private long? maxWorkTime;

				private float? satisfactionIndex;

				private long? satisfactionSurveysOffered;

				private long? satisfactionSurveysResponded;

				private float? serviceLevel20;

				private long? totalAbandonTime;

				private long? totalAbandonedInIVRTime;

				private long? totalAbandonedInQueueTime;

				private long? totalAbandonedInRingTime;

				private long? totalHoldTime;

				private long? totalRingTime;

				private long? totalTalkTime;

				private long? totalWaitTime;

				private long? totalWorkTime;

				public float? AbandonedRate
				{
					get
					{
						return abandonedRate;
					}
					set	
					{
						abandonedRate = value;
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

				public float? AverageAbandonedInIVRTime
				{
					get
					{
						return averageAbandonedInIVRTime;
					}
					set	
					{
						averageAbandonedInIVRTime = value;
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

				public long? CallsAbandonedInRinging
				{
					get
					{
						return callsAbandonedInRinging;
					}
					set	
					{
						callsAbandonedInRinging = value;
					}
				}

				public long? CallsConsulted
				{
					get
					{
						return callsConsulted;
					}
					set	
					{
						callsConsulted = value;
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

				public long? CallsTransferred
				{
					get
					{
						return callsTransferred;
					}
					set	
					{
						callsTransferred = value;
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

				public long? MaxAbandonedInIVRTime
				{
					get
					{
						return maxAbandonedInIVRTime;
					}
					set	
					{
						maxAbandonedInIVRTime = value;
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

				public long? TotalAbandonedInIVRTime
				{
					get
					{
						return totalAbandonedInIVRTime;
					}
					set	
					{
						totalAbandonedInIVRTime = value;
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
			}

			public class ListIntervalInstanceReport_Outbound
			{

				private float? answerRate;

				private float? averageDialingTime;

				private float? averageTalkTime;

				private float? averageWorkTime;

				private long? callsAnswered;

				private long? callsDialed;

				private long? callsDialedSuccess;

				private long? maxDialingTime;

				private long? maxTalkTime;

				private long? maxWorkTime;

				private float? satisfactionIndex;

				private long? satisfactionSurveysOffered;

				private long? satisfactionSurveysResponded;

				private long? totalDialingTime;

				private long? totalHoldTime;

				private long? totalTalkTime;

				private long? totalWorkTime;

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

				public long? CallsDialedSuccess
				{
					get
					{
						return callsDialedSuccess;
					}
					set	
					{
						callsDialedSuccess = value;
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
			}

			public class ListIntervalInstanceReport_Overall
			{

				private float? averageBreakTime;

				private float? averageHoldTime;

				private float? averageReadyTime;

				private float? averageTalkTime;

				private float? averageWorkTime;

				private long? maxBreakTime;

				private long? maxHoldTime;

				private long? maxReadyTime;

				private long? maxTalkTime;

				private long? maxWorkTime;

				private float? occupancyRate;

				private float? satisfactionIndex;

				private long? satisfactionSurveysOffered;

				private long? satisfactionSurveysResponded;

				private long? totalBreakTime;

				private long? totalCalls;

				private long? totalHoldTime;

				private long? totalLoggedInTime;

				private long? totalReadyTime;

				private long? totalTalkTime;

				private long? totalWorkTime;

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
			}
		}
	}
}
