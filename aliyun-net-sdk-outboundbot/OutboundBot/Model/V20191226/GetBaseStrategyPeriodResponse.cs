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

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
	public class GetBaseStrategyPeriodResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private bool? onlyWeekdays;

		private List<GetBaseStrategyPeriod_TimeFrame> workingTime;

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

		public bool? OnlyWeekdays
		{
			get
			{
				return onlyWeekdays;
			}
			set	
			{
				onlyWeekdays = value;
			}
		}

		public List<GetBaseStrategyPeriod_TimeFrame> WorkingTime
		{
			get
			{
				return workingTime;
			}
			set	
			{
				workingTime = value;
			}
		}

		public class GetBaseStrategyPeriod_TimeFrame
		{

			private long? beginTimeMillis;

			private string beginTime;

			private long? endTimeMillis;

			private string endTime;

			public long? BeginTimeMillis
			{
				get
				{
					return beginTimeMillis;
				}
				set	
				{
					beginTimeMillis = value;
				}
			}

			public string BeginTime
			{
				get
				{
					return beginTime;
				}
				set	
				{
					beginTime = value;
				}
			}

			public long? EndTimeMillis
			{
				get
				{
					return endTimeMillis;
				}
				set	
				{
					endTimeMillis = value;
				}
			}

			public string EndTime
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
		}
	}
}
