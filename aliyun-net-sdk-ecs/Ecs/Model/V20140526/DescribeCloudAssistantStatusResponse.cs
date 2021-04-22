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
	public class DescribeCloudAssistantStatusResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private long? pageNumber;

		private long? pageSize;

		private List<DescribeCloudAssistantStatus_InstanceCloudAssistantStatus> instanceCloudAssistantStatusSet;

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

		public List<DescribeCloudAssistantStatus_InstanceCloudAssistantStatus> InstanceCloudAssistantStatusSet
		{
			get
			{
				return instanceCloudAssistantStatusSet;
			}
			set	
			{
				instanceCloudAssistantStatusSet = value;
			}
		}

		public class DescribeCloudAssistantStatus_InstanceCloudAssistantStatus
		{

			private string instanceId;

			private string oSType;

			private string cloudAssistantStatus;

			private string cloudAssistantVersion;

			private long? invocationCount;

			private long? activeTaskCount;

			private string lastInvokedTime;

			private string lastHeartbeatTime;

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

			public string OSType
			{
				get
				{
					return oSType;
				}
				set	
				{
					oSType = value;
				}
			}

			public string CloudAssistantStatus
			{
				get
				{
					return cloudAssistantStatus;
				}
				set	
				{
					cloudAssistantStatus = value;
				}
			}

			public string CloudAssistantVersion
			{
				get
				{
					return cloudAssistantVersion;
				}
				set	
				{
					cloudAssistantVersion = value;
				}
			}

			public long? InvocationCount
			{
				get
				{
					return invocationCount;
				}
				set	
				{
					invocationCount = value;
				}
			}

			public long? ActiveTaskCount
			{
				get
				{
					return activeTaskCount;
				}
				set	
				{
					activeTaskCount = value;
				}
			}

			public string LastInvokedTime
			{
				get
				{
					return lastInvokedTime;
				}
				set	
				{
					lastInvokedTime = value;
				}
			}

			public string LastHeartbeatTime
			{
				get
				{
					return lastHeartbeatTime;
				}
				set	
				{
					lastHeartbeatTime = value;
				}
			}
		}
	}
}
