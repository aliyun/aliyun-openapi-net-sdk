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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeScheduleTasksResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private bool? success;

		private List<DescribeScheduleTasks_Items> data;

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

		public List<DescribeScheduleTasks_Items> Data
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

		public class DescribeScheduleTasks_Items
		{

			private string action;

			private string args;

			private long? gmtCreate;

			private long? gmtModified;

			private string dBClusterId;

			private int? maxRetryTime;

			private string mutex;

			private string orderId;

			private long? plannedEndTime;

			private long? plannedStartTime;

			private long? plannedTime;

			private string productCode;

			private string region;

			private string response;

			private int? retryTime;

			private string status;

			private string taskId;

			private int? type;

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

			public string Args
			{
				get
				{
					return args;
				}
				set	
				{
					args = value;
				}
			}

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string DBClusterId
			{
				get
				{
					return dBClusterId;
				}
				set	
				{
					dBClusterId = value;
				}
			}

			public int? MaxRetryTime
			{
				get
				{
					return maxRetryTime;
				}
				set	
				{
					maxRetryTime = value;
				}
			}

			public string Mutex
			{
				get
				{
					return mutex;
				}
				set	
				{
					mutex = value;
				}
			}

			public string OrderId
			{
				get
				{
					return orderId;
				}
				set	
				{
					orderId = value;
				}
			}

			public long? PlannedEndTime
			{
				get
				{
					return plannedEndTime;
				}
				set	
				{
					plannedEndTime = value;
				}
			}

			public long? PlannedStartTime
			{
				get
				{
					return plannedStartTime;
				}
				set	
				{
					plannedStartTime = value;
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

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public string Response
			{
				get
				{
					return response;
				}
				set	
				{
					response = value;
				}
			}

			public int? RetryTime
			{
				get
				{
					return retryTime;
				}
				set	
				{
					retryTime = value;
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

			public int? Type
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
