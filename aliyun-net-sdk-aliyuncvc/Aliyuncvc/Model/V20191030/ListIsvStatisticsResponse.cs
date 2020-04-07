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

namespace Aliyun.Acs.aliyuncvc.Model.V20191030
{
	public class ListIsvStatisticsResponse : AcsResponse
	{

		private int? errorCode;

		private string message;

		private bool? success;

		private string requestId;

		private ListIsvStatistics_Data data;

		public int? ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public ListIsvStatistics_Data Data
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

		public class ListIsvStatistics_Data
		{

			private List<ListIsvStatistics_Statistic> statistics;

			private ListIsvStatistics_Total total;

			public List<ListIsvStatistics_Statistic> Statistics
			{
				get
				{
					return statistics;
				}
				set	
				{
					statistics = value;
				}
			}

			public ListIsvStatistics_Total Total
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

			public class ListIsvStatistics_Statistic
			{

				private string meetingNumber;

				private string meetingLength;

				private string memberNumber;

				private string day;

				public string MeetingNumber
				{
					get
					{
						return meetingNumber;
					}
					set	
					{
						meetingNumber = value;
					}
				}

				public string MeetingLength
				{
					get
					{
						return meetingLength;
					}
					set	
					{
						meetingLength = value;
					}
				}

				public string MemberNumber
				{
					get
					{
						return memberNumber;
					}
					set	
					{
						memberNumber = value;
					}
				}

				public string Day
				{
					get
					{
						return day;
					}
					set	
					{
						day = value;
					}
				}
			}

			public class ListIsvStatistics_Total
			{

				private int? meetingNumber;

				private int? meetingLength;

				private int? memberNumber;

				public int? MeetingNumber
				{
					get
					{
						return meetingNumber;
					}
					set	
					{
						meetingNumber = value;
					}
				}

				public int? MeetingLength
				{
					get
					{
						return meetingLength;
					}
					set	
					{
						meetingLength = value;
					}
				}

				public int? MemberNumber
				{
					get
					{
						return memberNumber;
					}
					set	
					{
						memberNumber = value;
					}
				}
			}
		}
	}
}
