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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeActiveOperationTasksResponse : AcsResponse
	{

		private int? totalRecordCount;

		private string requestId;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribeActiveOperationTasks_ItemsItem> items;

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

			private string prepareInterval;

			private string deadline;

			private string dBType;

			private string taskType;

			private string startTime;

			private string dBVersion;

			private string modifiedTime;

			private string dBClusterId;

			private string region;

			private string resultInfo;

			private string createdTime;

			private int? taskId;

			private string switchTime;

			private string currentAVZ;

			private string insComment;

			private string taskTypeZh;

			private string taskTypeEn;

			private string changeLevel;

			private string changeLevelZh;

			private string changeLevelEn;

			private string impactZh;

			private string impactEn;

			private long? allowChange;

			private long? allowCancel;

			private string impact;

			private string taskParams;

			private List<string> dBNodeIds;

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

			public string DBType
			{
				get
				{
					return dBType;
				}
				set	
				{
					dBType = value;
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

			public string DBVersion
			{
				get
				{
					return dBVersion;
				}
				set	
				{
					dBVersion = value;
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

			public string DBClusterId
			{
				get
				{
					return dBClusterId;
				}
				set	
				{
					dBClusterId = value;
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

			public int? TaskId
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

			public long? AllowChange
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

			public long? AllowCancel
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

			public string TaskParams
			{
				get
				{
					return taskParams;
				}
				set	
				{
					taskParams = value;
				}
			}

			public List<string> DBNodeIds
			{
				get
				{
					return dBNodeIds;
				}
				set	
				{
					dBNodeIds = value;
				}
			}
		}
	}
}
