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

namespace Aliyun.Acs.SWAS_OPEN.Model.V20200601
{
	public class DescribeInvocationResultResponse : AcsResponse
	{

		private string requestId;

		private DescribeInvocationResult_InvocationResult invocationResult;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "InvocationResult")]
		public DescribeInvocationResult_InvocationResult InvocationResult
		{
			get
			{
				return invocationResult;
			}
			set	
			{
				invocationResult = value;
			}
		}

		public class DescribeInvocationResult_InvocationResult
		{

			private string startTime;

			private string finishedTime;

			private string invocationStatus;

			private long? exitCode;

			private string errorInfo;

			private string errorCode;

			private string invokeId;

			private string invokeRecordStatus;

			private string invokeUser;

			private string output;

			private string instanceId;

			[JsonProperty(PropertyName = "StartTime")]
			public string StartTime
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

			[JsonProperty(PropertyName = "FinishedTime")]
			public string FinishedTime
			{
				get
				{
					return finishedTime;
				}
				set	
				{
					finishedTime = value;
				}
			}

			[JsonProperty(PropertyName = "InvocationStatus")]
			public string InvocationStatus
			{
				get
				{
					return invocationStatus;
				}
				set	
				{
					invocationStatus = value;
				}
			}

			[JsonProperty(PropertyName = "ExitCode")]
			public long? ExitCode
			{
				get
				{
					return exitCode;
				}
				set	
				{
					exitCode = value;
				}
			}

			[JsonProperty(PropertyName = "ErrorInfo")]
			public string ErrorInfo
			{
				get
				{
					return errorInfo;
				}
				set	
				{
					errorInfo = value;
				}
			}

			[JsonProperty(PropertyName = "ErrorCode")]
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

			[JsonProperty(PropertyName = "InvokeId")]
			public string InvokeId
			{
				get
				{
					return invokeId;
				}
				set	
				{
					invokeId = value;
				}
			}

			[JsonProperty(PropertyName = "InvokeRecordStatus")]
			public string InvokeRecordStatus
			{
				get
				{
					return invokeRecordStatus;
				}
				set	
				{
					invokeRecordStatus = value;
				}
			}

			[JsonProperty(PropertyName = "InvokeUser")]
			public string InvokeUser
			{
				get
				{
					return invokeUser;
				}
				set	
				{
					invokeUser = value;
				}
			}

			[JsonProperty(PropertyName = "Output")]
			public string Output
			{
				get
				{
					return output;
				}
				set	
				{
					output = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceId")]
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
		}
	}
}
