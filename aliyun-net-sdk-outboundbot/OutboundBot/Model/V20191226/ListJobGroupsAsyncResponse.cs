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

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
	public class ListJobGroupsAsyncResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private bool? vaild;

		private bool? timeout;

		private List<ListJobGroupsAsync_JobGroup> jobGroups;

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

			private string jobGroupId;

			private string jobGroupName;

			private string jobGroupDescription;

			private string scriptId;

			private string scriptName;

			private long? creationTime;

			private string status;

			private string jobDataParsingTaskId;

			private string modifyTime;

			private string scriptVersion;

			private ListJobGroupsAsync_Strategy strategy;

			private ListJobGroupsAsync_Progress progress;

			private ListJobGroupsAsync_ExportProgress exportProgress;

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

				private long? startTime;

				private long? endTime;

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
			}

			public class ListJobGroupsAsync_Progress
			{

				private int? totalJobs;

				private string status;

				private int? totalNotAnswered;

				private int? totalCompleted;

				private long? startTime;

				private int? duration;

				private int? executingNum;

				private int? cancelledNum;

				private int? scheduling;

				private int? failedNum;

				private int? pausedNum;

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
			}

			public class ListJobGroupsAsync_ExportProgress
			{

				private string fileHttpUrl;

				private string progress;

				private string status;

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
