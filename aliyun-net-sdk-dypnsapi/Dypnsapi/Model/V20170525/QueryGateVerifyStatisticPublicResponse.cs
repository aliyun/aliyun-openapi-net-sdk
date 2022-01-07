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

namespace Aliyun.Acs.Dypnsapi.Model.V20170525
{
	public class QueryGateVerifyStatisticPublicResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private QueryGateVerifyStatisticPublic_Data data;

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

		public QueryGateVerifyStatisticPublic_Data Data
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

		public class QueryGateVerifyStatisticPublic_Data
		{

			private long? totalFail;

			private long? total;

			private long? totalSuccess;

			private long? totalUnknown;

			private List<QueryGateVerifyStatisticPublic_DayStatisticItem> dayStatistic;

			public long? TotalFail
			{
				get
				{
					return totalFail;
				}
				set	
				{
					totalFail = value;
				}
			}

			public long? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public long? TotalSuccess
			{
				get
				{
					return totalSuccess;
				}
				set	
				{
					totalSuccess = value;
				}
			}

			public long? TotalUnknown
			{
				get
				{
					return totalUnknown;
				}
				set	
				{
					totalUnknown = value;
				}
			}

			public List<QueryGateVerifyStatisticPublic_DayStatisticItem> DayStatistic
			{
				get
				{
					return dayStatistic;
				}
				set	
				{
					dayStatistic = value;
				}
			}

			public class QueryGateVerifyStatisticPublic_DayStatisticItem
			{

				private string statisticDateStr;

				private long? totalSuccess;

				private long? totalFail;

				private long? totalUnknown;

				public string StatisticDateStr
				{
					get
					{
						return statisticDateStr;
					}
					set	
					{
						statisticDateStr = value;
					}
				}

				public long? TotalSuccess
				{
					get
					{
						return totalSuccess;
					}
					set	
					{
						totalSuccess = value;
					}
				}

				public long? TotalFail
				{
					get
					{
						return totalFail;
					}
					set	
					{
						totalFail = value;
					}
				}

				public long? TotalUnknown
				{
					get
					{
						return totalUnknown;
					}
					set	
					{
						totalUnknown = value;
					}
				}
			}
		}
	}
}
