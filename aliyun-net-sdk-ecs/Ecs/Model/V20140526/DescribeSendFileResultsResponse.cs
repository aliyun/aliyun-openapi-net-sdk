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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeSendFileResultsResponse : AcsResponse
	{

		private long? pageSize;

		private string requestId;

		private long? pageNumber;

		private long? totalCount;

		private List<DescribeSendFileResults_Invocation> invocations;

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

			private string creationTime;

			private string invocationStatus;

			private string contentType;

			private string targetDir;

			private string fileOwner;

			private string description;

			private int? vmCount;

			private string fileMode;

			private string fileGroup;

			private string invokeId;

			private string name;

			private string content;

			private string overwrite;

			private List<DescribeSendFileResults_InvokeInstance> invokeInstances;

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

				private string creationTime;

				private string startTime;

				private string invocationStatus;

				private string finishTime;

				private string updateTime;

				private string errorInfo;

				private string errorCode;

				private string instanceId;

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
}
