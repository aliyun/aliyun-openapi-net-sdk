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

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
	public class ListJobGroupsAsyncResponse : AcsResponse
	{

		private bool? timeout;

		private int? httpStatusCode;

		private string requestId;

		private bool? success;

		private bool? vaild;

		private string code;

		private string message;

		private int? pageSize;

		private int? pageNumber;

		private int? totalCount;

		private List<ListJobGroupsAsync_JobGroup> jobGroups;

		public bool? Timeout
		{
			get
			{
				return timeout;
			}
			set	
			{
				timeout = value;
			}
		}

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public bool? Vaild
		{
			get
			{
				return vaild;
			}
			set	
			{
				vaild = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public List<ListJobGroupsAsync_JobGroup> JobGroups
		{
			get
			{
				return jobGroups;
			}
			set	
			{
				jobGroups = value;
			}
		}

		public class ListJobGroupsAsync_JobGroup
		{

			private string status;

			private long? creationTime;

			private string jobGroupId;

			private string jobGroupName;

			private int? totalCallNum;

			private string scriptId;

			private string jobGroupDescription;

			private string jobDataParsingTaskId;

			private string scriptName;

			private string scriptVersion;

			private string modifyTime;

			private ListJobGroupsAsync_Strategy strategy;

			private ListJobGroupsAsync_Progress progress;

			private ListJobGroupsAsync_ExportProgress exportProgress;

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

			public long? CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string JobGroupId
			{
				get
				{
					return jobGroupId;
				}
				set	
				{
					jobGroupId = value;
				}
			}

			public string JobGroupName
			{
				get
				{
					return jobGroupName;
				}
				set	
				{
					jobGroupName = value;
				}
			}

			public int? TotalCallNum
			{
				get
				{
					return totalCallNum;
				}
				set	
				{
					totalCallNum = value;
				}
			}

			public string ScriptId
			{
				get
				{
					return scriptId;
				}
				set	
				{
					scriptId = value;
				}
			}

			public string JobGroupDescription
			{
				get
				{
					return jobGroupDescription;
				}
				set	
				{
					jobGroupDescription = value;
				}
			}

			public string JobDataParsingTaskId
			{
				get
				{
					return jobDataParsingTaskId;
				}
				set	
				{
					jobDataParsingTaskId = value;
				}
			}

			public string ScriptName
			{
				get
				{
					return scriptName;
				}
				set	
				{
					scriptName = value;
				}
			}

			public string ScriptVersion
			{
				get
				{
					return scriptVersion;
				}
				set	
				{
					scriptVersion = value;
				}
			}

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}

			public ListJobGroupsAsync_Strategy Strategy
			{
				get
				{
					return strategy;
				}
				set	
				{
					strategy = value;
				}
			}

			public ListJobGroupsAsync_Progress Progress
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

			public ListJobGroupsAsync_ExportProgress ExportProgress
			{
				get
				{
					return exportProgress;
				}
				set	
				{
					exportProgress = value;
				}
			}

			public class ListJobGroupsAsync_Strategy
			{

				private long? endTime;

				private long? startTime;

				public long? EndTime
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

				public long? StartTime
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
			}

			public class ListJobGroupsAsync_Progress
			{

				private int? totalNotAnswered;

				private string status;

				private long? startTime;

				private int? failedNum;

				private int? pausedNum;

				private int? cancelledNum;

				private int? totalCompleted;

				private int? totalJobs;

				private int? duration;

				private int? scheduling;

				private int? executingNum;

				public int? TotalNotAnswered
				{
					get
					{
						return totalNotAnswered;
					}
					set	
					{
						totalNotAnswered = value;
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

				public long? StartTime
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

				public int? FailedNum
				{
					get
					{
						return failedNum;
					}
					set	
					{
						failedNum = value;
					}
				}

				public int? PausedNum
				{
					get
					{
						return pausedNum;
					}
					set	
					{
						pausedNum = value;
					}
				}

				public int? CancelledNum
				{
					get
					{
						return cancelledNum;
					}
					set	
					{
						cancelledNum = value;
					}
				}

				public int? TotalCompleted
				{
					get
					{
						return totalCompleted;
					}
					set	
					{
						totalCompleted = value;
					}
				}

				public int? TotalJobs
				{
					get
					{
						return totalJobs;
					}
					set	
					{
						totalJobs = value;
					}
				}

				public int? Duration
				{
					get
					{
						return duration;
					}
					set	
					{
						duration = value;
					}
				}

				public int? Scheduling
				{
					get
					{
						return scheduling;
					}
					set	
					{
						scheduling = value;
					}
				}

				public int? ExecutingNum
				{
					get
					{
						return executingNum;
					}
					set	
					{
						executingNum = value;
					}
				}
			}

			public class ListJobGroupsAsync_ExportProgress
			{

				private string status;

				private string fileHttpUrl;

				private string progress;

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

				public string FileHttpUrl
				{
					get
					{
						return fileHttpUrl;
					}
					set	
					{
						fileHttpUrl = value;
					}
				}

				public string Progress
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
			}
		}
	}
}
