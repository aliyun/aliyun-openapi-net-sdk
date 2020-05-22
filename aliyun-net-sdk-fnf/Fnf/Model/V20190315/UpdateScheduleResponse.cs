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

namespace Aliyun.Acs.fnf.Model.V20190315
{
	public class UpdateScheduleResponse : AcsResponse
	{

		private string requestId;

		private string scheduleName;

		private string description;

		private string scheduleId;

		private string payload;

		private string cronExpression;

		private bool? enable;

		private string createdTime;

		private string lastModifiedTime;

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

		public string ScheduleName
		{
			get
			{
				return scheduleName;
			}
			set	
			{
				scheduleName = value;
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
			}
		}

		public string ScheduleId
		{
			get
			{
				return scheduleId;
			}
			set	
			{
				scheduleId = value;
			}
		}

		public string Payload
		{
			get
			{
				return payload;
			}
			set	
			{
				payload = value;
			}
		}

		public string CronExpression
		{
			get
			{
				return cronExpression;
			}
			set	
			{
				cronExpression = value;
			}
		}

		public bool? Enable
		{
			get
			{
				return enable;
			}
			set	
			{
				enable = value;
			}
		}

		public string CreatedTime
		{
			get
			{
				return createdTime;
			}
			set	
			{
				createdTime = value;
			}
		}

		public string LastModifiedTime
		{
			get
			{
				return lastModifiedTime;
			}
			set	
			{
				lastModifiedTime = value;
			}
		}
	}
}
