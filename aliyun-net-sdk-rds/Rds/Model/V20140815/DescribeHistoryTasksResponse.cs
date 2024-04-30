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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeHistoryTasksResponse : AcsResponse
	{

		private int? pageNumber;

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeHistoryTasks_ItemsItem> items;

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "PageSize")]
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

		[JsonProperty(PropertyName = "TotalCount")]
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

		[JsonProperty(PropertyName = "Items")]
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

			private string status;

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

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "TaskId")]
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

			[JsonProperty(PropertyName = "CurrentStepName")]
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

			[JsonProperty(PropertyName = "StartTime")]
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

			[JsonProperty(PropertyName = "EndTime")]
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

			[JsonProperty(PropertyName = "TaskType")]
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

			[JsonProperty(PropertyName = "RemainTime")]
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

			[JsonProperty(PropertyName = "Progress")]
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

			[JsonProperty(PropertyName = "RegionId")]
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

			[JsonProperty(PropertyName = "InstanceType")]
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

			[JsonProperty(PropertyName = "InstanceId")]
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

			[JsonProperty(PropertyName = "InstanceName")]
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

			[JsonProperty(PropertyName = "DbType")]
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

			[JsonProperty(PropertyName = "Product")]
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

			[JsonProperty(PropertyName = "TaskDetail")]
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

			[JsonProperty(PropertyName = "ReasonCode")]
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

			[JsonProperty(PropertyName = "ActionInfo")]
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

			[JsonProperty(PropertyName = "Uid")]
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

			[JsonProperty(PropertyName = "CallerSource")]
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

			[JsonProperty(PropertyName = "CallerUid")]
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
