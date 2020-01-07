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

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
	public class DescribePodEventsResponse : AcsResponse
	{

		private int? code;

		private string errMsg;

		private string requestId;

		private bool? success;

		private DescribePodEvents_Result result;

		public int? Code
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

		public string ErrMsg
		{
			get
			{
				return errMsg;
			}
			set	
			{
				errMsg = value;
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

		public DescribePodEvents_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribePodEvents_Result
		{

			private string deployOrderName;

			private List<DescribePodEvents_PodEvent> podEvents;

			public string DeployOrderName
			{
				get
				{
					return deployOrderName;
				}
				set	
				{
					deployOrderName = value;
				}
			}

			public List<DescribePodEvents_PodEvent> PodEvents
			{
				get
				{
					return podEvents;
				}
				set	
				{
					podEvents = value;
				}
			}

			public class DescribePodEvents_PodEvent
			{

				private string action;

				private int? count;

				private string eventTime;

				private string firstTimestamp;

				private string lastTimestamp;

				private string message;

				private string reason;

				private string type;

				public string Action
				{
					get
					{
						return action;
					}
					set	
					{
						action = value;
					}
				}

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

				public string EventTime
				{
					get
					{
						return eventTime;
					}
					set	
					{
						eventTime = value;
					}
				}

				public string FirstTimestamp
				{
					get
					{
						return firstTimestamp;
					}
					set	
					{
						firstTimestamp = value;
					}
				}

				public string LastTimestamp
				{
					get
					{
						return lastTimestamp;
					}
					set	
					{
						lastTimestamp = value;
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

				public string Reason
				{
					get
					{
						return reason;
					}
					set	
					{
						reason = value;
					}
				}

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
			}
		}
	}
}
