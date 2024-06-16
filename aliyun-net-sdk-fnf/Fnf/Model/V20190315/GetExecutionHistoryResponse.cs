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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.fnf.Model.V20190315
{
	public class GetExecutionHistoryResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private List<GetExecutionHistory_EventsItem> events;

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
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

		public List<GetExecutionHistory_EventsItem> Events
		{
			get
			{
				return events;
			}
			set	
			{
				events = value;
			}
		}

		public class GetExecutionHistory_EventsItem
		{

			private string type;

			private long? eventId;

			private string time;

			private long? scheduleEventId;

			private string eventDetail;

			private string stepName;

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public long? EventId
			{
				get
				{
					return eventId;
				}
				set	
				{
					eventId = value;
				}
			}

			public string Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
				}
			}

			public long? ScheduleEventId
			{
				get
				{
					return scheduleEventId;
				}
				set	
				{
					scheduleEventId = value;
				}
			}

			public string EventDetail
			{
				get
				{
					return eventDetail;
				}
				set	
				{
					eventDetail = value;
				}
			}

			public string StepName
			{
				get
				{
					return stepName;
				}
				set	
				{
					stepName = value;
				}
			}
		}
	}
}
