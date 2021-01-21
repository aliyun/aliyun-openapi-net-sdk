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

namespace Aliyun.Acs.ROS.Model.V20190910
{
	public class ListStacksResponse : AcsResponse
	{

		private int? pageNumber;

		private int? pageSize;

		private string requestId;

		private int? totalCount;

		private List<ListStacks_Stack> stacks;

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

		public List<ListStacks_Stack> Stacks
		{
			get
			{
				return stacks;
			}
			set	
			{
				stacks = value;
			}
		}

		public class ListStacks_Stack
		{

			private string createTime;

			private bool? disableRollback;

			private string regionId;

			private string stackId;

			private string stackName;

			private string status;

			private string statusReason;

			private int? timeoutInMinutes;

			private string parentStackId;

			private string updateTime;

			private string stackDriftStatus;

			private string driftDetectionTime;

			private string stackType;

			private List<ListStacks_Tag> tags;

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

			public bool? DisableRollback
			{
				get
				{
					return disableRollback;
				}
				set	
				{
					disableRollback = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string StackId
			{
				get
				{
					return stackId;
				}
				set	
				{
					stackId = value;
				}
			}

			public string StackName
			{
				get
				{
					return stackName;
				}
				set	
				{
					stackName = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string StatusReason
			{
				get
				{
					return statusReason;
				}
				set	
				{
					statusReason = value;
				}
			}

			public int? TimeoutInMinutes
			{
				get
				{
					return timeoutInMinutes;
				}
				set	
				{
					timeoutInMinutes = value;
				}
			}

			public string ParentStackId
			{
				get
				{
					return parentStackId;
				}
				set	
				{
					parentStackId = value;
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

			public string StackDriftStatus
			{
				get
				{
					return stackDriftStatus;
				}
				set	
				{
					stackDriftStatus = value;
				}
			}

			public string DriftDetectionTime
			{
				get
				{
					return driftDetectionTime;
				}
				set	
				{
					driftDetectionTime = value;
				}
			}

			public string StackType
			{
				get
				{
					return stackType;
				}
				set	
				{
					stackType = value;
				}
			}

			public List<ListStacks_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public class ListStacks_Tag
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
