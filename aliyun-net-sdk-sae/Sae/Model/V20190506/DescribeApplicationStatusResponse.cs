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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class DescribeApplicationStatusResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string traceId;

		private string errorCode;

		private string code;

		private bool? success;

		private DescribeApplicationStatus_Data data;

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

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public DescribeApplicationStatus_Data Data
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

		public class DescribeApplicationStatus_Data
		{

			private string armsAdvancedEnabled;

			private string lastChangeOrderId;

			private string armsApmInfo;

			private string createTime;

			private string currentStatus;

			private string appId;

			private bool? lastChangeOrderRunning;

			private int? runningInstances;

			private string lastChangeOrderStatus;

			private string subStatus;

			private bool? enableAgent;

			private long? fileSizeLimit;

			public string ArmsAdvancedEnabled
			{
				get
				{
					return armsAdvancedEnabled;
				}
				set	
				{
					armsAdvancedEnabled = value;
				}
			}

			public string LastChangeOrderId
			{
				get
				{
					return lastChangeOrderId;
				}
				set	
				{
					lastChangeOrderId = value;
				}
			}

			public string ArmsApmInfo
			{
				get
				{
					return armsApmInfo;
				}
				set	
				{
					armsApmInfo = value;
				}
			}

			public string CreateTime
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

			public string CurrentStatus
			{
				get
				{
					return currentStatus;
				}
				set	
				{
					currentStatus = value;
				}
			}

			public string AppId
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

			public bool? LastChangeOrderRunning
			{
				get
				{
					return lastChangeOrderRunning;
				}
				set	
				{
					lastChangeOrderRunning = value;
				}
			}

			public int? RunningInstances
			{
				get
				{
					return runningInstances;
				}
				set	
				{
					runningInstances = value;
				}
			}

			public string LastChangeOrderStatus
			{
				get
				{
					return lastChangeOrderStatus;
				}
				set	
				{
					lastChangeOrderStatus = value;
				}
			}

			public string SubStatus
			{
				get
				{
					return subStatus;
				}
				set	
				{
					subStatus = value;
				}
			}

			public bool? EnableAgent
			{
				get
				{
					return enableAgent;
				}
				set	
				{
					enableAgent = value;
				}
			}

			public long? FileSizeLimit
			{
				get
				{
					return fileSizeLimit;
				}
				set	
				{
					fileSizeLimit = value;
				}
			}
		}
	}
}
