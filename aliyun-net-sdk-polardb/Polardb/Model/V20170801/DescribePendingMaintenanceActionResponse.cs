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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribePendingMaintenanceActionResponse : AcsResponse
	{

		private string requestId;

		private int? totalRecordCount;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribePendingMaintenanceAction_ItemsItem> items;

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

		public List<DescribePendingMaintenanceAction_ItemsItem> Items
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

		public class DescribePendingMaintenanceAction_ItemsItem
		{

			private int? id;

			private string dBClusterId;

			private string dBType;

			private string startTime;

			private string switchTime;

			private string deadline;

			private int? status;

			private string createdTime;

			private string modifiedTime;

			private string resultInfo;

			private string prepareInterval;

			private string taskType;

			private string dBVersion;

			private string region;

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
		}
	}
}
