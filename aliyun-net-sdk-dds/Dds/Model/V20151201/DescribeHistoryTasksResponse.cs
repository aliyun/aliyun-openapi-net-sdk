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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeHistoryTasksResponse : AcsResponse
	{

		private int? pageNumber;

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeHistoryTasks_ItemsItem> items;

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

		public List<DescribeHistoryTasks_ItemsItem> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeHistoryTasks_ItemsItem
		{

			private int? status;

			private string taskId;

			private string currentStepName;

			private string startTime;

			private string endTime;

			private string taskType;

			private int? remainTime;

			private float? progress;

			private string regionId;

			private string instanceType;

			private string instanceId;

			private string instanceName;

			private string dbType;

			private string product;

			private string taskDetail;

			private string reasonCode;

			private string actionInfo;

			private string uid;

			private string callerSource;

			private string callerUid;

			public int? Status
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

			public string TaskId
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

			public string CurrentStepName
			{
				get
				{
					return currentStepName;
				}
				set	
				{
					currentStepName = value;
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

			public string TaskType
			{
				get
				{
					return taskType;
				}
				set	
				{
					taskType = value;
				}
			}

			public int? RemainTime
			{
				get
				{
					return remainTime;
				}
				set	
				{
					remainTime = value;
				}
			}

			public float? Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
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

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
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

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public string DbType
			{
				get
				{
					return dbType;
				}
				set	
				{
					dbType = value;
				}
			}

			public string Product
			{
				get
				{
					return product;
				}
				set	
				{
					product = value;
				}
			}

			public string TaskDetail
			{
				get
				{
					return taskDetail;
				}
				set	
				{
					taskDetail = value;
				}
			}

			public string ReasonCode
			{
				get
				{
					return reasonCode;
				}
				set	
				{
					reasonCode = value;
				}
			}

			public string ActionInfo
			{
				get
				{
					return actionInfo;
				}
				set	
				{
					actionInfo = value;
				}
			}

			public string Uid
			{
				get
				{
					return uid;
				}
				set	
				{
					uid = value;
				}
			}

			public string CallerSource
			{
				get
				{
					return callerSource;
				}
				set	
				{
					callerSource = value;
				}
			}

			public string CallerUid
			{
				get
				{
					return callerUid;
				}
				set	
				{
					callerUid = value;
				}
			}
		}
	}
}
