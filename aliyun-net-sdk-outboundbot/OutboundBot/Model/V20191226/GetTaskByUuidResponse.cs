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
	public class GetTaskByUuidResponse : AcsResponse
	{

		private string requestId;

		private GetTaskByUuid_Task task;

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

		public GetTaskByUuid_Task Task
		{
			get
			{
				return task;
			}
			set	
			{
				task = value;
			}
		}

		public class GetTaskByUuid_Task
		{

			private string id;

			private string jobId;

			private long? plannedTime;

			private long? actualTime;

			private long? endTime;

			private string callingNumber;

			private string calledNumber;

			private string callId;

			private int? endReason;

			private string instanceId;

			private string jobGroupId;

			public string Id
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

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
				}
			}

			public long? PlannedTime
			{
				get
				{
					return plannedTime;
				}
				set	
				{
					plannedTime = value;
				}
			}

			public long? ActualTime
			{
				get
				{
					return actualTime;
				}
				set	
				{
					actualTime = value;
				}
			}

			public long? EndTime
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

			public string CallingNumber
			{
				get
				{
					return callingNumber;
				}
				set	
				{
					callingNumber = value;
				}
			}

			public string CalledNumber
			{
				get
				{
					return calledNumber;
				}
				set	
				{
					calledNumber = value;
				}
			}

			public string CallId
			{
				get
				{
					return callId;
				}
				set	
				{
					callId = value;
				}
			}

			public int? EndReason
			{
				get
				{
					return endReason;
				}
				set	
				{
					endReason = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string JobGroupId
			{
				get
				{
					return jobGroupId;
				}
				set	
				{
					jobGroupId = value;
				}
			}
		}
	}
}
