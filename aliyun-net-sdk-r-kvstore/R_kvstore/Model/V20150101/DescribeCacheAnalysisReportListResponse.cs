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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeCacheAnalysisReportListResponse : AcsResponse
	{

		private string requestId;

		private string instanceId;

		private int? totalRecordCount;

		private int? pageNumbers;

		private int? pageRecordCount;

		private List<DescribeCacheAnalysisReportList_DailyTask> dailyTasks;

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

		public int? PageNumbers
		{
			get
			{
				return pageNumbers;
			}
			set	
			{
				pageNumbers = value;
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

		public List<DescribeCacheAnalysisReportList_DailyTask> DailyTasks
		{
			get
			{
				return dailyTasks;
			}
			set	
			{
				dailyTasks = value;
			}
		}

		public class DescribeCacheAnalysisReportList_DailyTask
		{

			private string date;

			private List<DescribeCacheAnalysisReportList_Task> tasks;

			public string Date
			{
				get
				{
					return date;
				}
				set	
				{
					date = value;
				}
			}

			public List<DescribeCacheAnalysisReportList_Task> Tasks
			{
				get
				{
					return tasks;
				}
				set	
				{
					tasks = value;
				}
			}

			public class DescribeCacheAnalysisReportList_Task
			{

				private string taskId;

				private string nodeId;

				private string startTime;

				private string status;

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

				public string NodeId
				{
					get
					{
						return nodeId;
					}
					set	
					{
						nodeId = value;
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
			}
		}
	}
}
