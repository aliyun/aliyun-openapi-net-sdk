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
	public class ListStackInstancesResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<ListStackInstances_StackInstance> stackInstances;

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

		public List<ListStackInstances_StackInstance> StackInstances
		{
			get
			{
				return stackInstances;
			}
			set	
			{
				stackInstances = value;
			}
		}

		public class ListStackInstances_StackInstance
		{

			private string stackGroupName;

			private string stackGroupId;

			private string stackId;

			private string accountId;

			private string regionId;

			private string status;

			private string statusReason;

			private string stackDriftStatus;

			private string driftDetectionTime;

			public string StackGroupName
			{
				get
				{
					return stackGroupName;
				}
				set	
				{
					stackGroupName = value;
				}
			}

			public string StackGroupId
			{
				get
				{
					return stackGroupId;
				}
				set	
				{
					stackGroupId = value;
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

			public string AccountId
			{
				get
				{
					return accountId;
				}
				set	
				{
					accountId = value;
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
		}
	}
}
