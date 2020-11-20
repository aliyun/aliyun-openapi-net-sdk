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
	public class DescribeLifecycleActionsResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private int? maxResults;

		private int? totalCount;

		private List<DescribeLifecycleActions_LifecycleAction> lifecycleActions;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

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

		public List<DescribeLifecycleActions_LifecycleAction> LifecycleActions
		{
			get
			{
				return lifecycleActions;
			}
			set	
			{
				lifecycleActions = value;
			}
		}

		public class DescribeLifecycleActions_LifecycleAction
		{

			private string lifecycleActionToken;

			private string lifecycleActionStatus;

			private string lifecycleActionResult;

			private string lifecycleHookId;

			private List<string> instanceIds;

			public string LifecycleActionToken
			{
				get
				{
					return lifecycleActionToken;
				}
				set	
				{
					lifecycleActionToken = value;
				}
			}

			public string LifecycleActionStatus
			{
				get
				{
					return lifecycleActionStatus;
				}
				set	
				{
					lifecycleActionStatus = value;
				}
			}

			public string LifecycleActionResult
			{
				get
				{
					return lifecycleActionResult;
				}
				set	
				{
					lifecycleActionResult = value;
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

			public List<string> InstanceIds
			{
				get
				{
					return instanceIds;
				}
				set	
				{
					instanceIds = value;
				}
			}
		}
	}
}
