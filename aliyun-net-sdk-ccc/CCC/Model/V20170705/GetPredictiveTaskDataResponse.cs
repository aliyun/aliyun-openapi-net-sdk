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

namespace Aliyun.Acs.CCC.Model.V20170705
{
	public class GetPredictiveTaskDataResponse : AcsResponse
	{

		private string requestId;

		private long? httpStatusCode;

		private string code;

		private string message;

		private string success;

		private GetPredictiveTaskData_Data data;

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

		public long? HttpStatusCode
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

		public string Success
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

		public GetPredictiveTaskData_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetPredictiveTaskData_Data
		{

			private bool? abandoned;

			private string contactId;

			private bool? answered;

			private bool? connected;

			private long? dialDuration;

			private long? endTime;

			private string jobGroupId;

			private long? queueDuration;

			private long? startTime;

			private long? talkDuration;

			private string taskId;

			public bool? Abandoned
			{
				get
				{
					return abandoned;
				}
				set	
				{
					abandoned = value;
				}
			}

			public string ContactId
			{
				get
				{
					return contactId;
				}
				set	
				{
					contactId = value;
				}
			}

			public bool? Answered
			{
				get
				{
					return answered;
				}
				set	
				{
					answered = value;
				}
			}

			public bool? Connected
			{
				get
				{
					return connected;
				}
				set	
				{
					connected = value;
				}
			}

			public long? DialDuration
			{
				get
				{
					return dialDuration;
				}
				set	
				{
					dialDuration = value;
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

			public long? QueueDuration
			{
				get
				{
					return queueDuration;
				}
				set	
				{
					queueDuration = value;
				}
			}

			public long? StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public long? TalkDuration
			{
				get
				{
					return talkDuration;
				}
				set	
				{
					talkDuration = value;
				}
			}

			public string TaskId
			{
				get
				{
					return taskId;
				}
				set	
				{
					taskId = value;
				}
			}
		}
	}
}
