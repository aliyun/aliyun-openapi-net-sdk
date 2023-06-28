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

namespace Aliyun.Acs.Mns_open.Model.V20220119
{
	public class GetQueueAttributesResponse : AcsResponse
	{

		private string requestId;

		private long? code;

		private string status;

		private string message;

		private bool? success;

		private GetQueueAttributes_Data data;

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

		public long? Code
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

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
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

		public GetQueueAttributes_Data Data
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

		public class GetQueueAttributes_Data
		{

			private string queueName;

			private long? createTime;

			private long? lastModifyTime;

			private long? delaySeconds;

			private long? maximumMessageSize;

			private long? messageRetentionPeriod;

			private long? visibilityTimeout;

			private long? pollingWaitSeconds;

			private long? activeMessages;

			private long? inactiveMessages;

			private long? delayMessages;

			private bool? loggingEnabled;

			public string QueueName
			{
				get
				{
					return queueName;
				}
				set	
				{
					queueName = value;
				}
			}

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public long? LastModifyTime
			{
				get
				{
					return lastModifyTime;
				}
				set	
				{
					lastModifyTime = value;
				}
			}

			public long? DelaySeconds
			{
				get
				{
					return delaySeconds;
				}
				set	
				{
					delaySeconds = value;
				}
			}

			public long? MaximumMessageSize
			{
				get
				{
					return maximumMessageSize;
				}
				set	
				{
					maximumMessageSize = value;
				}
			}

			public long? MessageRetentionPeriod
			{
				get
				{
					return messageRetentionPeriod;
				}
				set	
				{
					messageRetentionPeriod = value;
				}
			}

			public long? VisibilityTimeout
			{
				get
				{
					return visibilityTimeout;
				}
				set	
				{
					visibilityTimeout = value;
				}
			}

			public long? PollingWaitSeconds
			{
				get
				{
					return pollingWaitSeconds;
				}
				set	
				{
					pollingWaitSeconds = value;
				}
			}

			public long? ActiveMessages
			{
				get
				{
					return activeMessages;
				}
				set	
				{
					activeMessages = value;
				}
			}

			public long? InactiveMessages
			{
				get
				{
					return inactiveMessages;
				}
				set	
				{
					inactiveMessages = value;
				}
			}

			public long? DelayMessages
			{
				get
				{
					return delayMessages;
				}
				set	
				{
					delayMessages = value;
				}
			}

			public bool? LoggingEnabled
			{
				get
				{
					return loggingEnabled;
				}
				set	
				{
					loggingEnabled = value;
				}
			}
		}
	}
}
