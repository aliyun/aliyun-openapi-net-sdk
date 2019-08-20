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
	public class TaobaoFilmGetCinemasResponse : AcsResponse
	{

		private string errorCode;

		private string msg;

		private string subCode;

		private string subMsg;

		private long? totalCount;

		private string logsId;

		private string requestId;

		private List<TaobaoFilmGetCinemas_CinemasItem> cinemas;

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

		public long? TotalCount
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

		public List<TaobaoFilmGetCinemas_CinemasItem> Cinemas
		{
			get
			{
				return cinemas;
			}
			set	
			{
				cinemas = value;
			}
		}

		public class TaobaoFilmGetCinemas_CinemasItem
		{

			private string address;

			private string cinemaName;

			private long? cityId;

			private long? id;

			private string latitude;

			private string longitude;

			private string phone;

			private string regionName;

			private long? scheduleCloseTime;

			private string standardId;

			public string Address
			{
				get
				{
					return address;
				}
				set	
				{
					address = value;
				}
			}

			public string CinemaName
			{
				get
				{
					return cinemaName;
				}
				set	
				{
					cinemaName = value;
				}
			}

			public long? CityId
			{
				get
				{
					return cityId;
				}
				set	
				{
					cityId = value;
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

			public string Latitude
			{
				get
				{
					return latitude;
				}
				set	
				{
					latitude = value;
				}
			}

			public string Longitude
			{
				get
				{
					return longitude;
				}
				set	
				{
					longitude = value;
				}
			}

			public string Phone
			{
				get
				{
					return phone;
				}
				set	
				{
					phone = value;
				}
			}

			public string RegionName
			{
				get
				{
					return regionName;
				}
				set	
				{
					regionName = value;
				}
			}

			public long? ScheduleCloseTime
			{
				get
				{
					return scheduleCloseTime;
				}
				set	
				{
					scheduleCloseTime = value;
				}
			}

			public string StandardId
			{
				get
				{
					return standardId;
				}
				set	
				{
					standardId = value;
				}
			}
		}
	}
}
