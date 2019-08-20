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

namespace Aliyun.Acs.AppMallsService.Model.V20180224
{
	public class TaobaoFilmGetSchedulesResponse : AcsResponse
	{

		private string errorCode;

		private string msg;

		private string subCode;

		private string subMsg;

		private string logsId;

		private string requestId;

		private List<TaobaoFilmGetSchedules_SchedulesItem> schedules;

		public string ErrorCode
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

		public string Msg
		{
			get
			{
				return msg;
			}
			set	
			{
				msg = value;
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

		public string SubMsg
		{
			get
			{
				return subMsg;
			}
			set	
			{
				subMsg = value;
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

		public List<TaobaoFilmGetSchedules_SchedulesItem> Schedules
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

		public class TaobaoFilmGetSchedules_SchedulesItem
		{

			private long? cinemaId;

			private string closeTime;

			private string hallName;

			private long? id;

			private bool? isExpired;

			private long? maxCanBuy;

			private long? price;

			private string scheduleArea;

			private string sectionId;

			private long? serviceFee;

			private string showDate;

			private long? showId;

			private string showTime;

			private string showVersion;

			private string hallId;

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

			public string CloseTime
			{
				get
				{
					return closeTime;
				}
				set	
				{
					closeTime = value;
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

			public string ShowDate
			{
				get
				{
					return showDate;
				}
				set	
				{
					showDate = value;
				}
			}

			public long? ShowId
			{
				get
				{
					return showId;
				}
				set	
				{
					showId = value;
				}
			}

			public string ShowTime
			{
				get
				{
					return showTime;
				}
				set	
				{
					showTime = value;
				}
			}

			public string ShowVersion
			{
				get
				{
					return showVersion;
				}
				set	
				{
					showVersion = value;
				}
			}

			public string HallId
			{
				get
				{
					return hallId;
				}
				set	
				{
					hallId = value;
				}
			}
		}
	}
}
