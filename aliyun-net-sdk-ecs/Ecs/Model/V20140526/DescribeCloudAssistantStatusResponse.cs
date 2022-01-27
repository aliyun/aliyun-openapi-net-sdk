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
	public class DescribeCloudAssistantStatusResponse : AcsResponse
	{

		private long? pageSize;

		private string requestId;

		private long? pageNumber;

		private long? totalCount;

		private List<DescribeCloudAssistantStatus_InstanceCloudAssistantStatus> instanceCloudAssistantStatusSet;

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

			private string cloudAssistantStatus;

			private string lastInvokedTime;

			private string cloudAssistantVersion;

			private long? activeTaskCount;

			private long? invocationCount;

			private string instanceId;

			private string lastHeartbeatTime;

			private string oSType;

			private bool? supportSessionManager;

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

			public bool? SupportSessionManager
			{
				get
				{
					return supportSessionManager;
				}
				set	
				{
					supportSessionManager = value;
				}
			}
		}
	}
}
