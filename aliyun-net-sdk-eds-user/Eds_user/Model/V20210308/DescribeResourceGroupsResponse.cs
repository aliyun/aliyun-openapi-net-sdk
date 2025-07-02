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

namespace Aliyun.Acs.eds_user.Model.V20210308
{
	public class DescribeResourceGroupsResponse : AcsResponse
	{

		private string requestId;

		private string totalCount;

		private List<DescribeResourceGroups_ResourceGroupItem> resourceGroup;

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

		public string TotalCount
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

		public List<DescribeResourceGroups_ResourceGroupItem> ResourceGroup
		{
			get
			{
				return resourceGroup;
			}
			set	
			{
				resourceGroup = value;
			}
		}

		public class DescribeResourceGroups_ResourceGroupItem
		{

			private string resourceGroupId;

			private string resourceGroupName;

			private string resourceCount;

			private string authCount;

			private string createTime;

			private List<DescribeResourceGroups_Policy> policies;

			private List<DescribeResourceGroups_Timer> timers;

			private List<DescribeResourceGroups_AppRule> appRules;

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
				}
			}

			public string ResourceGroupName
			{
				get
				{
					return resourceGroupName;
				}
				set	
				{
					resourceGroupName = value;
				}
			}

			public string ResourceCount
			{
				get
				{
					return resourceCount;
				}
				set	
				{
					resourceCount = value;
				}
			}

			public string AuthCount
			{
				get
				{
					return authCount;
				}
				set	
				{
					authCount = value;
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

			public List<DescribeResourceGroups_Policy> Policies
			{
				get
				{
					return policies;
				}
				set	
				{
					policies = value;
				}
			}

			public List<DescribeResourceGroups_Timer> Timers
			{
				get
				{
					return timers;
				}
				set	
				{
					timers = value;
				}
			}

			public List<DescribeResourceGroups_AppRule> AppRules
			{
				get
				{
					return appRules;
				}
				set	
				{
					appRules = value;
				}
			}

			public class DescribeResourceGroups_Policy
			{

				private string id;

				private string name;

				private bool? isDefault;

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
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

				public bool? IsDefault
				{
					get
					{
						return isDefault;
					}
					set	
					{
						isDefault = value;
					}
				}
			}

			public class DescribeResourceGroups_Timer
			{

				private string id;

				private string name;

				private string timerStatus;

				private string bindStatus;

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
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

				public string TimerStatus
				{
					get
					{
						return timerStatus;
					}
					set	
					{
						timerStatus = value;
					}
				}

				public string BindStatus
				{
					get
					{
						return bindStatus;
					}
					set	
					{
						bindStatus = value;
					}
				}
			}

			public class DescribeResourceGroups_AppRule
			{

				private string id;

				private string name;

				private int? type;

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
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

				public int? Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}
			}
		}
	}
}
