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
	public class DescribeUpgradeMajorVersionTasksResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageRecordCount;

		private int? totalRecordCount;

		private List<DescribeUpgradeMajorVersionTasks_Tasks> items;

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

		[JsonProperty(PropertyName = "PageRecordCount")]
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

			private string targetMajorVersion;

			private string result;

			private string endTime;

			private string startTime;

			private string sourceMajorVersion;

			private string upgradeMode;

			private string collectStatMode;

			private string sourceInsName;

			private int? taskId;

			private string targetInsName;

			private string switchTime;

			private string detail;

			[JsonProperty(PropertyName = "TargetMajorVersion")]
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

			[JsonProperty(PropertyName = "Result")]
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

			[JsonProperty(PropertyName = "SourceMajorVersion")]
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

			[JsonProperty(PropertyName = "UpgradeMode")]
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

			[JsonProperty(PropertyName = "CollectStatMode")]
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

			[JsonProperty(PropertyName = "SourceInsName")]
			public string SourceInsName
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

			[JsonProperty(PropertyName = "TaskId")]
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

			[JsonProperty(PropertyName = "TargetInsName")]
			public string TargetInsName
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

			[JsonProperty(PropertyName = "Detail")]
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
