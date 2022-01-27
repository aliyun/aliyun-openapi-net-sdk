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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class GetSuccessInstanceTrendResponse : AcsResponse
	{

		private string requestId;

		private GetSuccessInstanceTrend_InstanceStatusTrend instanceStatusTrend;

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

		public GetSuccessInstanceTrend_InstanceStatusTrend InstanceStatusTrend
		{
			get
			{
				return instanceStatusTrend;
			}
			set	
			{
				instanceStatusTrend = value;
			}
		}

		public class GetSuccessInstanceTrend_InstanceStatusTrend
		{

			private List<GetSuccessInstanceTrend_TodayTrendItem> todayTrend;

			private List<GetSuccessInstanceTrend_YesterdayTrendItem> yesterdayTrend;

			private List<GetSuccessInstanceTrend_AvgTrendItem> avgTrend;

			public List<GetSuccessInstanceTrend_TodayTrendItem> TodayTrend
			{
				get
				{
					return todayTrend;
				}
				set	
				{
					todayTrend = value;
				}
			}

			public List<GetSuccessInstanceTrend_YesterdayTrendItem> YesterdayTrend
			{
				get
				{
					return yesterdayTrend;
				}
				set	
				{
					yesterdayTrend = value;
				}
			}

			public List<GetSuccessInstanceTrend_AvgTrendItem> AvgTrend
			{
				get
				{
					return avgTrend;
				}
				set	
				{
					avgTrend = value;
				}
			}

			public class GetSuccessInstanceTrend_TodayTrendItem
			{

				private int? count;

				private string timePoint;

				public int? Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}

				public string TimePoint
				{
					get
					{
						return timePoint;
					}
					set	
					{
						timePoint = value;
					}
				}
			}

			public class GetSuccessInstanceTrend_YesterdayTrendItem
			{

				private int? count;

				private string timePoint;

				public int? Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}

				public string TimePoint
				{
					get
					{
						return timePoint;
					}
					set	
					{
						timePoint = value;
					}
				}
			}

			public class GetSuccessInstanceTrend_AvgTrendItem
			{

				private int? count;

				private string timePoint;

				public int? Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}

				public string TimePoint
				{
					get
					{
						return timePoint;
					}
					set	
					{
						timePoint = value;
					}
				}
			}
		}
	}
}
