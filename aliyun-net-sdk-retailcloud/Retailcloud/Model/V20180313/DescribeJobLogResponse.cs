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
	public class DescribeJobLogResponse : AcsResponse
	{

		private int? code;

		private string requestId;

		private string errMsg;

		private DescribeJobLog_Result result;

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

		public DescribeJobLog_Result Result
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

		public class DescribeJobLog_Result
		{

			private long? appId;

			private long? envId;

			private string podName;

			private string jobLog;

			private List<DescribeJobLog__Event> events;

			public long? AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public long? EnvId
			{
				get
				{
					return envId;
				}
				set	
				{
					envId = value;
				}
			}

			public string PodName
			{
				get
				{
					return podName;
				}
				set	
				{
					podName = value;
				}
			}

			public string JobLog
			{
				get
				{
					return jobLog;
				}
				set	
				{
					jobLog = value;
				}
			}

			public List<DescribeJobLog__Event> Events
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

			public class DescribeJobLog__Event
			{

				private string action;

				private int? count;

				private string eventTime;

				private string firstTimestamp;

				private string lastTimestamp;

				private string mesage;

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

				public string Mesage
				{
					get
					{
						return mesage;
					}
					set	
					{
						mesage = value;
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
