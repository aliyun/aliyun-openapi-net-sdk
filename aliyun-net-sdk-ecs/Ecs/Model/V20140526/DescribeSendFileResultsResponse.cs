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
	public class DescribeSendFileResultsResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private long? pageNumber;

		private long? pageSize;

		private List<DescribeSendFileResults_Invocation> invocations;

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

		public List<DescribeSendFileResults_Invocation> Invocations
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

		public class DescribeSendFileResults_Invocation
		{

			private string invokeId;

			private string name;

			private string description;

			private string targetDir;

			private string contentType;

			private string content;

			private string fileOwner;

			private string fileGroup;

			private string fileMode;

			private string overwrite;

			private int? vmCount;

			private string creationTime;

			private string invocationStatus;

			private List<DescribeSendFileResults_InvokeInstance> invokeInstances;

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

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string TargetDir
			{
				get
				{
					return targetDir;
				}
				set	
				{
					targetDir = value;
				}
			}

			public string ContentType
			{
				get
				{
					return contentType;
				}
				set	
				{
					contentType = value;
				}
			}

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public string FileOwner
			{
				get
				{
					return fileOwner;
				}
				set	
				{
					fileOwner = value;
				}
			}

			public string FileGroup
			{
				get
				{
					return fileGroup;
				}
				set	
				{
					fileGroup = value;
				}
			}

			public string FileMode
			{
				get
				{
					return fileMode;
				}
				set	
				{
					fileMode = value;
				}
			}

			public string Overwrite
			{
				get
				{
					return overwrite;
				}
				set	
				{
					overwrite = value;
				}
			}

			public int? VmCount
			{
				get
				{
					return vmCount;
				}
				set	
				{
					vmCount = value;
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

			public List<DescribeSendFileResults_InvokeInstance> InvokeInstances
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

			public class DescribeSendFileResults_InvokeInstance
			{

				private string instanceId;

				private string invocationStatus;

				private string creationTime;

				private string startTime;

				private string finishTime;

				private string updateTime;

				private string errorCode;

				private string errorInfo;

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
			}
		}
	}
}
