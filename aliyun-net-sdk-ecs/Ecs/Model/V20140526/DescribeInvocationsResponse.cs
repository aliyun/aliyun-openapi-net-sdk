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
	public class DescribeInvocationsResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private long? pageNumber;

		private long? pageSize;

		private List<DescribeInvocations_Invocation> invocations;

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

		public List<DescribeInvocations_Invocation> Invocations
		{
			get
			{
				return invocations;
			}
			set	
			{
				invocations = value;
			}
		}

		public class DescribeInvocations_Invocation
		{

			private string invokeId;

			private string creationTime;

			private string commandId;

			private string commandType;

			private string commandName;

			private string commandContent;

			private string frequency;

			private bool? timed;

			private string invokeStatus;

			private string parameters;

			private List<DescribeInvocations_InvokeInstance> invokeInstances;

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

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

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

			public string CommandType
			{
				get
				{
					return commandType;
				}
				set	
				{
					commandType = value;
				}
			}

			public string CommandName
			{
				get
				{
					return commandName;
				}
				set	
				{
					commandName = value;
				}
			}

			public string CommandContent
			{
				get
				{
					return commandContent;
				}
				set	
				{
					commandContent = value;
				}
			}

			public string Frequency
			{
				get
				{
					return frequency;
				}
				set	
				{
					frequency = value;
				}
			}

			public bool? Timed
			{
				get
				{
					return timed;
				}
				set	
				{
					timed = value;
				}
			}

			public string InvokeStatus
			{
				get
				{
					return invokeStatus;
				}
				set	
				{
					invokeStatus = value;
				}
			}

			public string Parameters
			{
				get
				{
					return parameters;
				}
				set	
				{
					parameters = value;
				}
			}

			public List<DescribeInvocations_InvokeInstance> InvokeInstances
			{
				get
				{
					return invokeInstances;
				}
				set	
				{
					invokeInstances = value;
				}
			}

			public class DescribeInvocations_InvokeInstance
			{

				private string instanceId;

				private int? repeats;

				private string instanceInvokeStatus;

				private string invocationStatus;

				private string output;

				private long? exitCode;

				private int? dropped;

				private string errorCode;

				private string errorInfo;

				private string creationTime;

				private string startTime;

				private string stopTime;

				private string finishTime;

				private string updateTime;

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

				public string InstanceInvokeStatus
				{
					get
					{
						return instanceInvokeStatus;
					}
					set	
					{
						instanceInvokeStatus = value;
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

				public string CreationTime
				{
					get
					{
						return creationTime;
					}
					set	
					{
						creationTime = value;
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

				public string FinishTime
				{
					get
					{
						return finishTime;
					}
					set	
					{
						finishTime = value;
					}
				}

				public string UpdateTime
				{
					get
					{
						return updateTime;
					}
					set	
					{
						updateTime = value;
					}
				}
			}
		}
	}
}
