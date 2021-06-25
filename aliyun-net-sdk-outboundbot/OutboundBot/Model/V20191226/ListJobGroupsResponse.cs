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
	public class ListJobGroupsResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private bool? success;

		private string asyncTaskId;

		private ListJobGroups_JobGroups jobGroups;

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

		public string AsyncTaskId
		{
			get
			{
				return asyncTaskId;
			}
			set	
			{
				asyncTaskId = value;
			}
		}

		public ListJobGroups_JobGroups JobGroups
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

		public class ListJobGroups_JobGroups
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListJobGroups_JobGroup> list;

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

			public List<ListJobGroups_JobGroup> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class ListJobGroups_JobGroup
			{

				private long? creationTime;

				private string jobGroupDescription;

				private string jobGroupId;

				private string jobGroupName;

				private string scriptId;

				private string scriptName;

				private string jobDataParsingTaskId;

				private string modifyTime;

				private string scriptVersion;

				private string status;

				private ListJobGroups_Progress progress;

				private ListJobGroups_ExportProgress exportProgress;

				private ListJobGroups_Strategy strategy;

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

				public ListJobGroups_Progress Progress
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

				public ListJobGroups_ExportProgress ExportProgress
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

				public ListJobGroups_Strategy Strategy
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

				public class ListJobGroups_Progress
				{

					private int? duration;

					private long? startTime;

					private string status;

					private int? totalCompleted;

					private int? totalJobs;

					private int? totalNotAnswered;

					private int? cancelledNum;

					private int? failedNum;

					private int? scheduling;

					private int? pausedNum;

					private int? executingNum;

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

				public class ListJobGroups_ExportProgress
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

				public class ListJobGroups_Strategy
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
			}
		}
	}
}
