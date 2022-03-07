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
	public class SearchTaskResponse : AcsResponse
	{

		private int? httpStatusCode;

		private int? pageIndex;

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? pageSize;

		private long? total;

		private List<SearchTask_SearchTaskInfo> searchTaskInfoList;

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

		public int? PageIndex
		{
			get
			{
				return pageIndex;
			}
			set	
			{
				pageIndex = value;
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

		public long? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<SearchTask_SearchTaskInfo> SearchTaskInfoList
		{
			get
			{
				return searchTaskInfoList;
			}
			set	
			{
				searchTaskInfoList = value;
			}
		}

		public class SearchTask_SearchTaskInfo
		{

			private string jobGroupName;

			private string userId;

			private long? actualTime;

			private string calledNumber;

			private string taskStatusString;

			private string taskStatusName;

			private int? jobStatus;

			private string dialException;

			private string userName;

			private string callDurationDisplay;

			private bool? hasAnswered;

			private string jobStatusName;

			private int? callDuration;

			private long? taskCreateTime;

			private string jobStatusString;

			private bool? hasReachedEndOfFlow;

			private string instanceId;

			private bool? hasHangUpByRejection;

			private int? taskEndReason;

			private string jobGroupId;

			private int? taskStatus;

			private string jobId;

			private int? recordingDuration;

			private string taskId;

			private string dialExceptionOld;

			private bool? hasLastPlaybackCompleted;

			private string scriptName;

			private List<string> dialExceptionCodes;

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

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public long? ActualTime
			{
				get
				{
					return actualTime;
				}
				set	
				{
					actualTime = value;
				}
			}

			public string CalledNumber
			{
				get
				{
					return calledNumber;
				}
				set	
				{
					calledNumber = value;
				}
			}

			public string TaskStatusString
			{
				get
				{
					return taskStatusString;
				}
				set	
				{
					taskStatusString = value;
				}
			}

			public string TaskStatusName
			{
				get
				{
					return taskStatusName;
				}
				set	
				{
					taskStatusName = value;
				}
			}

			public int? JobStatus
			{
				get
				{
					return jobStatus;
				}
				set	
				{
					jobStatus = value;
				}
			}

			public string DialException
			{
				get
				{
					return dialException;
				}
				set	
				{
					dialException = value;
				}
			}

			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
				}
			}

			public string CallDurationDisplay
			{
				get
				{
					return callDurationDisplay;
				}
				set	
				{
					callDurationDisplay = value;
				}
			}

			public bool? HasAnswered
			{
				get
				{
					return hasAnswered;
				}
				set	
				{
					hasAnswered = value;
				}
			}

			public string JobStatusName
			{
				get
				{
					return jobStatusName;
				}
				set	
				{
					jobStatusName = value;
				}
			}

			public int? CallDuration
			{
				get
				{
					return callDuration;
				}
				set	
				{
					callDuration = value;
				}
			}

			public long? TaskCreateTime
			{
				get
				{
					return taskCreateTime;
				}
				set	
				{
					taskCreateTime = value;
				}
			}

			public string JobStatusString
			{
				get
				{
					return jobStatusString;
				}
				set	
				{
					jobStatusString = value;
				}
			}

			public bool? HasReachedEndOfFlow
			{
				get
				{
					return hasReachedEndOfFlow;
				}
				set	
				{
					hasReachedEndOfFlow = value;
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

			public bool? HasHangUpByRejection
			{
				get
				{
					return hasHangUpByRejection;
				}
				set	
				{
					hasHangUpByRejection = value;
				}
			}

			public int? TaskEndReason
			{
				get
				{
					return taskEndReason;
				}
				set	
				{
					taskEndReason = value;
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

			public int? TaskStatus
			{
				get
				{
					return taskStatus;
				}
				set	
				{
					taskStatus = value;
				}
			}

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
				}
			}

			public int? RecordingDuration
			{
				get
				{
					return recordingDuration;
				}
				set	
				{
					recordingDuration = value;
				}
			}

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

			public string DialExceptionOld
			{
				get
				{
					return dialExceptionOld;
				}
				set	
				{
					dialExceptionOld = value;
				}
			}

			public bool? HasLastPlaybackCompleted
			{
				get
				{
					return hasLastPlaybackCompleted;
				}
				set	
				{
					hasLastPlaybackCompleted = value;
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

			public List<string> DialExceptionCodes
			{
				get
				{
					return dialExceptionCodes;
				}
				set	
				{
					dialExceptionCodes = value;
				}
			}
		}
	}
}
