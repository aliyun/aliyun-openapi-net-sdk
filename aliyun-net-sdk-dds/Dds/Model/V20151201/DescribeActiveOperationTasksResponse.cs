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
	public class DescribeActiveOperationTasksResponse : AcsResponse
	{

		private int? pageNumber;

		private string requestId;

		private int? pageSize;

		private int? totalRecordCount;

		private List<DescribeActiveOperationTasks_ItemsItem> items;

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
