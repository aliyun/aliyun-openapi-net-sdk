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

namespace Aliyun.Acs.cusanalytic_sc_online.Model.V20190524
{
	public class GetHourlyStatisticsDataResponse : AcsResponse
	{

		private string errorMsg;

		private string cursorTime;

		private bool? success;

		private List<GetHourlyStatisticsData_BaseStatisticsData> baseStatisticsDatas;

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
			}
		}

		public string CursorTime
		{
			get
			{
				return cursorTime;
			}
			set	
			{
				cursorTime = value;
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

		public List<GetHourlyStatisticsData_BaseStatisticsData> BaseStatisticsDatas
		{
			get
			{
				return baseStatisticsDatas;
			}
			set	
			{
				baseStatisticsDatas = value;
			}
		}

		public class GetHourlyStatisticsData_BaseStatisticsData
		{

			private int? maleUvCount;

			private long? storeId;

			private string day;

			private long? locationId;

			private int? stayPeriod;

			private int? uvCount;

			private int? onlyBodyUvCount;

			private string hour;

			private int? femaleUvCount;

			private int? oldCount;

			private int? newCount;

			public int? MaleUvCount
			{
				get
				{
					return maleUvCount;
				}
				set	
				{
					maleUvCount = value;
				}
			}

			public long? StoreId
			{
				get
				{
					return storeId;
				}
				set	
				{
					storeId = value;
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

			public long? LocationId
			{
				get
				{
					return locationId;
				}
				set	
				{
					locationId = value;
				}
			}

			public int? StayPeriod
			{
				get
				{
					return stayPeriod;
				}
				set	
				{
					stayPeriod = value;
				}
			}

			public int? UvCount
			{
				get
				{
					return uvCount;
				}
				set	
				{
					uvCount = value;
				}
			}

			public int? OnlyBodyUvCount
			{
				get
				{
					return onlyBodyUvCount;
				}
				set	
				{
					onlyBodyUvCount = value;
				}
			}

			public string Hour
			{
				get
				{
					return hour;
				}
				set	
				{
					hour = value;
				}
			}

			public int? FemaleUvCount
			{
				get
				{
					return femaleUvCount;
				}
				set	
				{
					femaleUvCount = value;
				}
			}

			public int? OldCount
			{
				get
				{
					return oldCount;
				}
				set	
				{
					oldCount = value;
				}
			}

			public int? NewCount
			{
				get
				{
					return newCount;
				}
				set	
				{
					newCount = value;
				}
			}
		}
	}
}
