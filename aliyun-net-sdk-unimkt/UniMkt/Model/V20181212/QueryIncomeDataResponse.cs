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

namespace Aliyun.Acs.UniMkt.Model.V20181212
{
	public class QueryIncomeDataResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private string requestId;

		private QueryIncomeData_Model model;

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

		public QueryIncomeData_Model Model
		{
			get
			{
				return model;
			}
			set	
			{
				model = value;
			}
		}

		public class QueryIncomeData_Model
		{

			private long? startTime;

			private long? endTime;

			private string mediaId;

			private string mediaName;

			private string adSlotType;

			private string adSlotId;

			private string adSlotName;

			private long? estimatedIncome;

			private long? adSlotRequests;

			private long? accessStatus;

			private long? adSlotHitTimes;

			private long? showTimes;

			private long? clickTimes;

			private long? lastDayEstimatedIncome;

			private long? thisMonEstimatedIncome;

			private long? thisYearIncome;

			private long? accumulatedIncome;

			private string channelId;

			private string channelName;

			private long? thisDaysEstIncome;

			private string adSlotHitRate;

			private string adSlotShowRate;

			private string adSlotClickRate;

			private long? ecpm;

			private string ecpmRate;

			private string thisDaysEstIncomeRate;

			private string thisMonEstIncomeRate;

			private string thisYearEstIncomeRate;

			private string accEstIncomeRate;

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

			public long? EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string MediaId
			{
				get
				{
					return mediaId;
				}
				set	
				{
					mediaId = value;
				}
			}

			public string MediaName
			{
				get
				{
					return mediaName;
				}
				set	
				{
					mediaName = value;
				}
			}

			public string AdSlotType
			{
				get
				{
					return adSlotType;
				}
				set	
				{
					adSlotType = value;
				}
			}

			public string AdSlotId
			{
				get
				{
					return adSlotId;
				}
				set	
				{
					adSlotId = value;
				}
			}

			public string AdSlotName
			{
				get
				{
					return adSlotName;
				}
				set	
				{
					adSlotName = value;
				}
			}

			public long? EstimatedIncome
			{
				get
				{
					return estimatedIncome;
				}
				set	
				{
					estimatedIncome = value;
				}
			}

			public long? AdSlotRequests
			{
				get
				{
					return adSlotRequests;
				}
				set	
				{
					adSlotRequests = value;
				}
			}

			public long? AccessStatus
			{
				get
				{
					return accessStatus;
				}
				set	
				{
					accessStatus = value;
				}
			}

			public long? AdSlotHitTimes
			{
				get
				{
					return adSlotHitTimes;
				}
				set	
				{
					adSlotHitTimes = value;
				}
			}

			public long? ShowTimes
			{
				get
				{
					return showTimes;
				}
				set	
				{
					showTimes = value;
				}
			}

			public long? ClickTimes
			{
				get
				{
					return clickTimes;
				}
				set	
				{
					clickTimes = value;
				}
			}

			public long? LastDayEstimatedIncome
			{
				get
				{
					return lastDayEstimatedIncome;
				}
				set	
				{
					lastDayEstimatedIncome = value;
				}
			}

			public long? ThisMonEstimatedIncome
			{
				get
				{
					return thisMonEstimatedIncome;
				}
				set	
				{
					thisMonEstimatedIncome = value;
				}
			}

			public long? ThisYearIncome
			{
				get
				{
					return thisYearIncome;
				}
				set	
				{
					thisYearIncome = value;
				}
			}

			public long? AccumulatedIncome
			{
				get
				{
					return accumulatedIncome;
				}
				set	
				{
					accumulatedIncome = value;
				}
			}

			public string ChannelId
			{
				get
				{
					return channelId;
				}
				set	
				{
					channelId = value;
				}
			}

			public string ChannelName
			{
				get
				{
					return channelName;
				}
				set	
				{
					channelName = value;
				}
			}

			public long? ThisDaysEstIncome
			{
				get
				{
					return thisDaysEstIncome;
				}
				set	
				{
					thisDaysEstIncome = value;
				}
			}

			public string AdSlotHitRate
			{
				get
				{
					return adSlotHitRate;
				}
				set	
				{
					adSlotHitRate = value;
				}
			}

			public string AdSlotShowRate
			{
				get
				{
					return adSlotShowRate;
				}
				set	
				{
					adSlotShowRate = value;
				}
			}

			public string AdSlotClickRate
			{
				get
				{
					return adSlotClickRate;
				}
				set	
				{
					adSlotClickRate = value;
				}
			}

			public long? Ecpm
			{
				get
				{
					return ecpm;
				}
				set	
				{
					ecpm = value;
				}
			}

			public string EcpmRate
			{
				get
				{
					return ecpmRate;
				}
				set	
				{
					ecpmRate = value;
				}
			}

			public string ThisDaysEstIncomeRate
			{
				get
				{
					return thisDaysEstIncomeRate;
				}
				set	
				{
					thisDaysEstIncomeRate = value;
				}
			}

			public string ThisMonEstIncomeRate
			{
				get
				{
					return thisMonEstIncomeRate;
				}
				set	
				{
					thisMonEstIncomeRate = value;
				}
			}

			public string ThisYearEstIncomeRate
			{
				get
				{
					return thisYearEstIncomeRate;
				}
				set	
				{
					thisYearEstIncomeRate = value;
				}
			}

			public string AccEstIncomeRate
			{
				get
				{
					return accEstIncomeRate;
				}
				set	
				{
					accEstIncomeRate = value;
				}
			}
		}
	}
}
