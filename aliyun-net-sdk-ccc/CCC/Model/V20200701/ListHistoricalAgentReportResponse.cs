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
	public class ListHistoricalAgentReportResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private ListHistoricalAgentReport_Data data;

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

		public ListHistoricalAgentReport_Data Data
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

		public class ListHistoricalAgentReport_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListHistoricalAgentReport_Items> list;

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

			public List<ListHistoricalAgentReport_Items> List
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

			public class ListHistoricalAgentReport_Items
			{

				private string agentName;

				private string agentId;

				private string displayId;

				private ListHistoricalAgentReport_Inbound inbound;

				private ListHistoricalAgentReport_Outbound outbound;

				private ListHistoricalAgentReport_Overall overall;

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

				public string DisplayId
				{
					get
					{
						return displayId;
					}
					set	
					{
						displayId = value;
					}
				}

				public ListHistoricalAgentReport_Inbound Inbound
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

				public ListHistoricalAgentReport_Outbound Outbound
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

				public ListHistoricalAgentReport_Overall Overall
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

				public class ListHistoricalAgentReport_Inbound
				{

					private float? averageRingTime;

					private long? callsHandled;

					private long? totalWorkTime;

					private long? callsAttendedTransferOut;

					private long? maxWorkTime;

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

					private long? callsOffered;

					private long? maxHoldTime;

					private float? averageTalkTime;

					private float? satisfactionRate;

					private long? callsHold;

					private long? satisfactionSurveysOffered;

					private float? handleRate;

					private long? satisfactionSurveysResponded;

					private float? averageHoldTime;

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
				}

				public class ListHistoricalAgentReport_Outbound
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

				public class ListHistoricalAgentReport_Overall
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
}
