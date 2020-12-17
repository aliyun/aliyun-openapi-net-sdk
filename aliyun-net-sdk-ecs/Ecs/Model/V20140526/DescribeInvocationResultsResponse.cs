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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeInvocationResultsResponse : AcsResponse
	{

		private string requestId;

		private DescribeInvocationResults_Invocation invocation;

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

		public DescribeInvocationResults_Invocation Invocation
		{
			get
			{
				return invocation;
			}
			set	
			{
				invocation = value;
			}
		}

		public class DescribeInvocationResults_Invocation
		{

			private long? pageSize;

			private long? pageNumber;

			private long? totalCount;

			private List<DescribeInvocationResults_InvocationResult> invocationResults;

			public long? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			public long? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
				}
			}

			public long? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public List<DescribeInvocationResults_InvocationResult> InvocationResults
			{
				get
				{
					return invocationResults;
				}
				set	
				{
					invocationResults = value;
				}
			}

			public class DescribeInvocationResults_InvocationResult
			{

				private string commandId;

				private string invokeId;

				private string instanceId;

				private string startTime;

				private string stopTime;

				private string finishedTime;

				private int? repeats;

				private string output;

				private int? dropped;

				private string invokeRecordStatus;

				private string invocationStatus;

				private long? exitCode;

				private string errorCode;

				private string errorInfo;

				private string username;

				public string CommandId
				{
					get
					{
						return commandId;
					}
					set	
					{
						commandId = value;
					}
				}

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

				public string StopTime
				{
					get
					{
						return stopTime;
					}
					set	
					{
						stopTime = value;
					}
				}

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

				public int? Repeats
				{
					get
					{
						return repeats;
					}
					set	
					{
						repeats = value;
					}
				}

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

				public int? Dropped
				{
					get
					{
						return dropped;
					}
					set	
					{
						dropped = value;
					}
				}

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

				public string Username
				{
					get
					{
						return username;
					}
					set	
					{
						username = value;
					}
				}
			}
		}
	}
}
