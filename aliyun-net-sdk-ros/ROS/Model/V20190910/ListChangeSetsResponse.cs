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
	public class ListChangeSetsResponse : AcsResponse
	{

		private int? pageNumber;

		private int? pageSize;

		private string requestId;

		private int? totalCount;

		private List<ListChangeSets_ChangeSet> changeSets;

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

		public List<ListChangeSets_ChangeSet> ChangeSets
		{
			get
			{
				return changeSets;
			}
			set	
			{
				changeSets = value;
			}
		}

		public class ListChangeSets_ChangeSet
		{

			private string changeSetId;

			private string changeSetName;

			private string changeSetType;

			private string createTime;

			private string description;

			private string executionStatus;

			private string regionId;

			private string stackId;

			private string stackName;

			private string status;

			private string statusReason;

			public string ChangeSetId
			{
				get
				{
					return changeSetId;
				}
				set	
				{
					changeSetId = value;
				}
			}

			public string ChangeSetName
			{
				get
				{
					return changeSetName;
				}
				set	
				{
					changeSetName = value;
				}
			}

			public string ChangeSetType
			{
				get
				{
					return changeSetType;
				}
				set	
				{
					changeSetType = value;
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

			public string ExecutionStatus
			{
				get
				{
					return executionStatus;
				}
				set	
				{
					executionStatus = value;
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
		}
	}
}
