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
	public class DescribeActiveOperationTasksResponse : AcsResponse
	{

		private int? pageNumber;

		private string requestId;

		private int? pageSize;

		private int? totalRecordCount;

		private List<DescribeActiveOperationTasks_ItemsItem> items;

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

		[JsonProperty(PropertyName = "TotalRecordCount")]
		public int? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		[JsonProperty(PropertyName = "Items")]
		public List<DescribeActiveOperationTasks_ItemsItem> Items
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

		public class DescribeActiveOperationTasks_ItemsItem
		{

			private int? status;

			private string changeLevelEn;

			private string taskType;

			private string insName;

			private string region;

			private string impactZh;

			private string createdTime;

			private string switchTime;

			private string changeLevelZh;

			private string deadline;

			private string prepareInterval;

			private string impact;

			private string taskTypeZh;

			private string currentAVZ;

			private string allowChange;

			private string dbVersion;

			private string impactEn;

			private string insComment;

			private string startTime;

			private string modifiedTime;

			private string allowCancel;

			private string dbType;

			private string changeLevel;

			private string taskTypeEn;

			private string resultInfo;

			private int? id;

			private List<string> subInsNames;

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "ChangeLevelEn")]
			public string ChangeLevelEn
			{
				get
				{
					return changeLevelEn;
				}
				set	
				{
					changeLevelEn = value;
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

			[JsonProperty(PropertyName = "InsName")]
			public string InsName
			{
				get
				{
					return insName;
				}
				set	
				{
					insName = value;
				}
			}

			[JsonProperty(PropertyName = "Region")]
			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			[JsonProperty(PropertyName = "ImpactZh")]
			public string ImpactZh
			{
				get
				{
					return impactZh;
				}
				set	
				{
					impactZh = value;
				}
			}

			[JsonProperty(PropertyName = "CreatedTime")]
			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			[JsonProperty(PropertyName = "SwitchTime")]
			public string SwitchTime
			{
				get
				{
					return switchTime;
				}
				set	
				{
					switchTime = value;
				}
			}

			[JsonProperty(PropertyName = "ChangeLevelZh")]
			public string ChangeLevelZh
			{
				get
				{
					return changeLevelZh;
				}
				set	
				{
					changeLevelZh = value;
				}
			}

			[JsonProperty(PropertyName = "Deadline")]
			public string Deadline
			{
				get
				{
					return deadline;
				}
				set	
				{
					deadline = value;
				}
			}

			[JsonProperty(PropertyName = "PrepareInterval")]
			public string PrepareInterval
			{
				get
				{
					return prepareInterval;
				}
				set	
				{
					prepareInterval = value;
				}
			}

			[JsonProperty(PropertyName = "Impact")]
			public string Impact
			{
				get
				{
					return impact;
				}
				set	
				{
					impact = value;
				}
			}

			[JsonProperty(PropertyName = "TaskTypeZh")]
			public string TaskTypeZh
			{
				get
				{
					return taskTypeZh;
				}
				set	
				{
					taskTypeZh = value;
				}
			}

			[JsonProperty(PropertyName = "CurrentAVZ")]
			public string CurrentAVZ
			{
				get
				{
					return currentAVZ;
				}
				set	
				{
					currentAVZ = value;
				}
			}

			[JsonProperty(PropertyName = "AllowChange")]
			public string AllowChange
			{
				get
				{
					return allowChange;
				}
				set	
				{
					allowChange = value;
				}
			}

			[JsonProperty(PropertyName = "DbVersion")]
			public string DbVersion
			{
				get
				{
					return dbVersion;
				}
				set	
				{
					dbVersion = value;
				}
			}

			[JsonProperty(PropertyName = "ImpactEn")]
			public string ImpactEn
			{
				get
				{
					return impactEn;
				}
				set	
				{
					impactEn = value;
				}
			}

			[JsonProperty(PropertyName = "InsComment")]
			public string InsComment
			{
				get
				{
					return insComment;
				}
				set	
				{
					insComment = value;
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

			[JsonProperty(PropertyName = "ModifiedTime")]
			public string ModifiedTime
			{
				get
				{
					return modifiedTime;
				}
				set	
				{
					modifiedTime = value;
				}
			}

			[JsonProperty(PropertyName = "AllowCancel")]
			public string AllowCancel
			{
				get
				{
					return allowCancel;
				}
				set	
				{
					allowCancel = value;
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

			[JsonProperty(PropertyName = "ChangeLevel")]
			public string ChangeLevel
			{
				get
				{
					return changeLevel;
				}
				set	
				{
					changeLevel = value;
				}
			}

			[JsonProperty(PropertyName = "TaskTypeEn")]
			public string TaskTypeEn
			{
				get
				{
					return taskTypeEn;
				}
				set	
				{
					taskTypeEn = value;
				}
			}

			[JsonProperty(PropertyName = "ResultInfo")]
			public string ResultInfo
			{
				get
				{
					return resultInfo;
				}
				set	
				{
					resultInfo = value;
				}
			}

			[JsonProperty(PropertyName = "Id")]
			public int? Id
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

			[JsonProperty(PropertyName = "SubInsNames")]
			public List<string> SubInsNames
			{
				get
				{
					return subInsNames;
				}
				set	
				{
					subInsNames = value;
				}
			}
		}
	}
}
