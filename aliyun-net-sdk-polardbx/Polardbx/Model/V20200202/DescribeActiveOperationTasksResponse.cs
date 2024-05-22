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

namespace Aliyun.Acs.polardbx.Model.V20200202
{
	public class DescribeActiveOperationTasksResponse : AcsResponse
	{

		private long? pageSize;

		private string requestId;

		private long? pageNumber;

		private long? totalRecordCount;

		private List<DescribeActiveOperationTasks_ItemsItem> items;

		public long? PageSize
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

		public long? PageNumber
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

		public long? TotalRecordCount
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

			private string allowCancel;

			private string allowChange;

			private string changeLevel;

			private string changeLevelEn;

			private string changeLevelZh;

			private string createdTime;

			private string currentAVZ;

			private string dbType;

			private string dbVersion;

			private string deadline;

			private long? id;

			private string impact;

			private string impactEn;

			private string impactZh;

			private string insComment;

			private string insName;

			private string modifiedTime;

			private string prepareInterval;

			private string region;

			private string resultInfo;

			private string startTime;

			private long? status;

			private string switchTime;

			private string taskType;

			private string taskTypeEn;

			private string taskTypeZh;

			private List<string> subInsNames;

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

			public long? Status
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
