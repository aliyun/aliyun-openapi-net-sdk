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
	public class GetHistoricalInstanceReportResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private GetHistoricalInstanceReport_Data data;

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

		public GetHistoricalInstanceReport_Data Data
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

		public class GetHistoricalInstanceReport_Data
		{

			private GetHistoricalInstanceReport_Inbound inbound;

			private GetHistoricalInstanceReport_Outbound outbound;

			private GetHistoricalInstanceReport_Overall overall;

			public GetHistoricalInstanceReport_Inbound Inbound
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

			public GetHistoricalInstanceReport_Outbound Outbound
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

			public GetHistoricalInstanceReport_Overall Overall
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

			public class GetHistoricalInstanceReport_Inbound
			{

				private float? averageRingTime;

				private long? callsVoicemail;

				private long? maxAbandonedInIVRTime;

				private long? callsHandled;

				private long? callsIVRException;

				private long? callsAbandonedInIVR;

				private long? maxWorkTime;

				private long? totalHoldTime;

				private long? maxAbandonTime;

				private float? averageAbandonTime;

				private long? callsRinged;

				private long? callsQueuingFailed;

				private long? totalRingTime;

				private float? abandonRate;

				private long? totalTalkTime;

				private long? maxAbandonedInRingTime;

				private long? callsBlindTransferred;

				private float? averageAbandonedInIVRTime;

				private float? averageAbandonedInQueueTime;

				private long? maxWaitTime;

				private float? averageTalkTime;

				private long? callsAttendedTransferred;

				private long? totalAbandonedInIVRTime;

				private long? callsQueuingOverflow;

				private long? callsAbandonedInRing;

				private long? totalAbandonedInRingTime;

				private long? totalWorkTime;

				private float? averageWaitTime;

				private float? averageWorkTime;

				private long? callsQueued;

				private float? averageAbandonedInRingTime;

				private float? satisfactionIndex;

				private long? callsAbandoned;

				private long? maxAbandonedInQueueTime;

				private long? callsAbandonedInVoiceNavigator;

				private long? totalWaitTime;

				private long? maxTalkTime;

				private long? maxRingTime;

				private long? totalAbandonTime;

				private long? callsOffered;

				private long? callsQueuingTimeout;

				private float? serviceLevel20;

				private long? maxHoldTime;

				private long? callsForwardToOutsideNumber;

				private float? satisfactionRate;

				private long? callsHold;

				private long? satisfactionSurveysOffered;

				private float? handleRate;

				private long? satisfactionSurveysResponded;

				private float? averageHoldTime;

				private long? callsAbandonedInQueue;

				private long? totalAbandonedInQueueTime;

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

				public long? CallsVoicemail
				{
					get
					{
						return callsVoicemail;
					}
					set	
					{
						callsVoicemail = value;
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

				public long? CallsIVRException
				{
					get
					{
						return callsIVRException;
					}
					set	
					{
						callsIVRException = value;
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

				public long? CallsQueuingFailed
				{
					get
					{
						return callsQueuingFailed;
					}
					set	
					{
						callsQueuingFailed = value;
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

				public long? CallsBlindTransferred
				{
					get
					{
						return callsBlindTransferred;
					}
					set	
					{
						callsBlindTransferred = value;
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

				public long? CallsAttendedTransferred
				{
					get
					{
						return callsAttendedTransferred;
					}
					set	
					{
						callsAttendedTransferred = value;
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

				public long? CallsQueuingOverflow
				{
					get
					{
						return callsQueuingOverflow;
					}
					set	
					{
						callsQueuingOverflow = value;
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

				public long? CallsAbandonedInVoiceNavigator
				{
					get
					{
						return callsAbandonedInVoiceNavigator;
					}
					set	
					{
						callsAbandonedInVoiceNavigator = value;
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

				public long? CallsQueuingTimeout
				{
					get
					{
						return callsQueuingTimeout;
					}
					set	
					{
						callsQueuingTimeout = value;
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

				public long? CallsForwardToOutsideNumber
				{
					get
					{
						return callsForwardToOutsideNumber;
					}
					set	
					{
						callsForwardToOutsideNumber = value;
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
			}

			public class GetHistoricalInstanceReport_Outbound
			{

				private float? averageRingTime;

				private long? callsDialed;

				private long? callsAnswered;

				private long? totalWorkTime;

				private long? maxWorkTime;

				private long? totalDialingTime;

				private long? totalHoldTime;

				private float? averageWorkTime;

				private float? satisfactionIndex;

				private long? callsRinged;

				private long? totalRingTime;

				private long? maxTalkTime;

				private long? maxRingTime;

				private long? totalTalkTime;

				private long? maxDialingTime;

				private long? callsBlindTransferred;

				private float? answerRate;

				private long? maxHoldTime;

				private float? averageTalkTime;

				private float? satisfactionRate;

				private long? callsAttendedTransferred;

				private int? callsHold;

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

				public long? CallsBlindTransferred
				{
					get
					{
						return callsBlindTransferred;
					}
					set	
					{
						callsBlindTransferred = value;
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

				public long? CallsAttendedTransferred
				{
					get
					{
						return callsAttendedTransferred;
					}
					set	
					{
						callsAttendedTransferred = value;
					}
				}

				public int? CallsHold
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

			public class GetHistoricalInstanceReport_Overall
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
