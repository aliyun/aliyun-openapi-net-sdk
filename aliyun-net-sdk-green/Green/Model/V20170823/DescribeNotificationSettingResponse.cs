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

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeNotificationSettingResponse : AcsResponse
	{

		private string requestId;

		private string email;

		private string phone;

		private int? scheduleMessageTime;

		private int? scheduleMessageTimeZone;

		private List<string> realtimeMessageList;

		private List<string> reminderModeList;

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

		public string Email
		{
			get
			{
				return email;
			}
			set	
			{
				email = value;
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

		public int? ScheduleMessageTime
		{
			get
			{
				return scheduleMessageTime;
			}
			set	
			{
				scheduleMessageTime = value;
			}
		}

		public int? ScheduleMessageTimeZone
		{
			get
			{
				return scheduleMessageTimeZone;
			}
			set	
			{
				scheduleMessageTimeZone = value;
			}
		}

		public List<string> RealtimeMessageList
		{
			get
			{
				return realtimeMessageList;
			}
			set	
			{
				realtimeMessageList = value;
			}
		}

		public List<string> ReminderModeList
		{
			get
			{
				return reminderModeList;
			}
			set	
			{
				reminderModeList = value;
			}
		}
	}
}
