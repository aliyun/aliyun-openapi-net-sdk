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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeUpgradeMajorVersionTasksResponse : AcsResponse
	{

		private string requestId;

		private int? totalRecordCount;

		private int? pageNumber;

		private int? pageRecordCount;

		private List<DescribeUpgradeMajorVersionTasks_Tasks> items;

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

		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
			}
		}

		public List<DescribeUpgradeMajorVersionTasks_Tasks> Items
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

		public class DescribeUpgradeMajorVersionTasks_Tasks
		{

			private int? taskId;

			private int? sourceInsName;

			private string sourceMajorVersion;

			private int? targetInsName;

			private string targetMajorVersion;

			private string upgradeMode;

			private string collectStatMode;

			private string startTime;

			private string endTime;

			private string switchTime;

			private string result;

			private string detail;

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

			public int? SourceInsName
			{
				get
				{
					return sourceInsName;
				}
				set	
				{
					sourceInsName = value;
				}
			}

			public string SourceMajorVersion
			{
				get
				{
					return sourceMajorVersion;
				}
				set	
				{
					sourceMajorVersion = value;
				}
			}

			public int? TargetInsName
			{
				get
				{
					return targetInsName;
				}
				set	
				{
					targetInsName = value;
				}
			}

			public string TargetMajorVersion
			{
				get
				{
					return targetMajorVersion;
				}
				set	
				{
					targetMajorVersion = value;
				}
			}

			public string UpgradeMode
			{
				get
				{
					return upgradeMode;
				}
				set	
				{
					upgradeMode = value;
				}
			}

			public string CollectStatMode
			{
				get
				{
					return collectStatMode;
				}
				set	
				{
					collectStatMode = value;
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

			public string Result
			{
				get
				{
					return result;
				}
				set	
				{
					result = value;
				}
			}

			public string Detail
			{
				get
				{
					return detail;
				}
				set	
				{
					detail = value;
				}
			}
		}
	}
}
