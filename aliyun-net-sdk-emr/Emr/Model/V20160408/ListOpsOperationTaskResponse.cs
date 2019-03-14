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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class ListOpsOperationTaskResponse : AcsResponse
	{

		private string requestId;

		private int? total;

		private int? pageNumber;

		private int? pageSize;

		private List<ListOpsOperationTask_TaskListItem> taskList;

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

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
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

		public List<ListOpsOperationTask_TaskListItem> TaskList
		{
			get
			{
				return taskList;
			}
			set	
			{
				taskList = value;
			}
		}

		public class ListOpsOperationTask_TaskListItem
		{

			private long? id;

			private long? opsOperationId;

			private long? taskId;

			private string status;

			private string regionId;

			private string userId;

			private long? clusterId;

			private string externalClusterId;

			private long? hostId;

			private string startTime;

			private string endTime;

			private string commandName;

			private string hostName;

			public long? Id
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

			public long? OpsOperationId
			{
				get
				{
					return opsOperationId;
				}
				set	
				{
					opsOperationId = value;
				}
			}

			public long? TaskId
			{
				get
				{
					return taskId;
				}
				set	
				{
					taskId = value;
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

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public long? ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
				}
			}

			public string ExternalClusterId
			{
				get
				{
					return externalClusterId;
				}
				set	
				{
					externalClusterId = value;
				}
			}

			public long? HostId
			{
				get
				{
					return hostId;
				}
				set	
				{
					hostId = value;
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

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string CommandName
			{
				get
				{
					return commandName;
				}
				set	
				{
					commandName = value;
				}
			}

			public string HostName
			{
				get
				{
					return hostName;
				}
				set	
				{
					hostName = value;
				}
			}
		}
	}
}
