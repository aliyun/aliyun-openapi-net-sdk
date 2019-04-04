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

namespace Aliyun.Acs.Ess.Model.V20140828
{
	public class DescribeLifecycleHooksResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private string requestId;

		private List<DescribeLifecycleHooks_LifecycleHook> lifecycleHooks;

		public int? TotalCount
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

		public int? PageNumber
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

		public int? PageSize
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

		public List<DescribeLifecycleHooks_LifecycleHook> LifecycleHooks
		{
			get
			{
				return lifecycleHooks;
			}
			set	
			{
				lifecycleHooks = value;
			}
		}

		public class DescribeLifecycleHooks_LifecycleHook
		{

			private string scalingGroupId;

			private string lifecycleHookId;

			private string lifecycleHookName;

			private string defaultResult;

			private int? heartbeatTimeout;

			private string lifecycleTransition;

			private string notificationMetadata;

			private string notificationArn;

			public string ScalingGroupId
			{
				get
				{
					return scalingGroupId;
				}
				set	
				{
					scalingGroupId = value;
				}
			}

			public string LifecycleHookId
			{
				get
				{
					return lifecycleHookId;
				}
				set	
				{
					lifecycleHookId = value;
				}
			}

			public string LifecycleHookName
			{
				get
				{
					return lifecycleHookName;
				}
				set	
				{
					lifecycleHookName = value;
				}
			}

			public string DefaultResult
			{
				get
				{
					return defaultResult;
				}
				set	
				{
					defaultResult = value;
				}
			}

			public int? HeartbeatTimeout
			{
				get
				{
					return heartbeatTimeout;
				}
				set	
				{
					heartbeatTimeout = value;
				}
			}

			public string LifecycleTransition
			{
				get
				{
					return lifecycleTransition;
				}
				set	
				{
					lifecycleTransition = value;
				}
			}

			public string NotificationMetadata
			{
				get
				{
					return notificationMetadata;
				}
				set	
				{
					notificationMetadata = value;
				}
			}

			public string NotificationArn
			{
				get
				{
					return notificationArn;
				}
				set	
				{
					notificationArn = value;
				}
			}
		}
	}
}
