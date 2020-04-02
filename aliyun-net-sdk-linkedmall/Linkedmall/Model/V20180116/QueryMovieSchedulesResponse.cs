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

namespace Aliyun.Acs.linkedmall.Model.V20180116
{
	public class QueryMovieSchedulesResponse : AcsResponse
	{

		private string requestId;

		private string logsId;

		private string subCode;

		private string subMessage;

		private string code;

		private bool? success;

		private string message;

		private List<QueryMovieSchedules_Schedule> schedules;

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

		public string LogsId
		{
			get
			{
				return logsId;
			}
			set	
			{
				logsId = value;
			}
		}

		public string SubCode
		{
			get
			{
				return subCode;
			}
			set	
			{
				subCode = value;
			}
		}

		public string SubMessage
		{
			get
			{
				return subMessage;
			}
			set	
			{
				subMessage = value;
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

		public List<QueryMovieSchedules_Schedule> Schedules
		{
			get
			{
				return schedules;
			}
			set	
			{
				schedules = value;
			}
		}

		public class QueryMovieSchedules_Schedule
		{

			private long? cinemaId;

			private string sessionEndingTime;

			private string hallName;

			private long? id;

			private bool? isExpired;

			private long? maxCanBuy;

			private long? price;

			private string scheduleArea;

			private string sectionId;

			private long? serviceFee;

			private string releaseDate;

			private long? movieId;

			private string sessionStartingTime;

			private string movieVersion;

			public long? CinemaId
			{
				get
				{
					return cinemaId;
				}
				set	
				{
					cinemaId = value;
				}
			}

			public string SessionEndingTime
			{
				get
				{
					return sessionEndingTime;
				}
				set	
				{
					sessionEndingTime = value;
				}
			}

			public string HallName
			{
				get
				{
					return hallName;
				}
				set	
				{
					hallName = value;
				}
			}

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public bool? IsExpired
			{
				get
				{
					return isExpired;
				}
				set	
				{
					isExpired = value;
				}
			}

			public long? MaxCanBuy
			{
				get
				{
					return maxCanBuy;
				}
				set	
				{
					maxCanBuy = value;
				}
			}

			public long? Price
			{
				get
				{
					return price;
				}
				set	
				{
					price = value;
				}
			}

			public string ScheduleArea
			{
				get
				{
					return scheduleArea;
				}
				set	
				{
					scheduleArea = value;
				}
			}

			public string SectionId
			{
				get
				{
					return sectionId;
				}
				set	
				{
					sectionId = value;
				}
			}

			public long? ServiceFee
			{
				get
				{
					return serviceFee;
				}
				set	
				{
					serviceFee = value;
				}
			}

			public string ReleaseDate
			{
				get
				{
					return releaseDate;
				}
				set	
				{
					releaseDate = value;
				}
			}

			public long? MovieId
			{
				get
				{
					return movieId;
				}
				set	
				{
					movieId = value;
				}
			}

			public string SessionStartingTime
			{
				get
				{
					return sessionStartingTime;
				}
				set	
				{
					sessionStartingTime = value;
				}
			}

			public string MovieVersion
			{
				get
				{
					return movieVersion;
				}
				set	
				{
					movieVersion = value;
				}
			}
		}
	}
}
