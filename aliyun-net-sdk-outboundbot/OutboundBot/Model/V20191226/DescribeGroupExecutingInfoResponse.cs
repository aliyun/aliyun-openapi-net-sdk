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
	public class DescribeGroupExecutingInfoResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string requestId;

		private string groupId;

		private bool? success;

		private string code;

		private string message;

		private string instanceId;

		private DescribeGroupExecutingInfo_ExecutingInfo executingInfo;

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

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
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

		public DescribeGroupExecutingInfo_ExecutingInfo ExecutingInfo
		{
			get
			{
				return executingInfo;
			}
			set	
			{
				executingInfo = value;
			}
		}

		public class DescribeGroupExecutingInfo_ExecutingInfo
		{

			private long? endTime;

			private long? startTime;

			private int? hangUpByClientNum;

			private string creatorName;

			private int? transferByNoAnswer;

			private int? finishedNum;

			private int? transferByIntentNum;

			private int? callNum;

			private int? callFailedNum;

			private DescribeGroupExecutingInfo_JobsProgress jobsProgress;

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

			public int? HangUpByClientNum
			{
				get
				{
					return hangUpByClientNum;
				}
				set	
				{
					hangUpByClientNum = value;
				}
			}

			public string CreatorName
			{
				get
				{
					return creatorName;
				}
				set	
				{
					creatorName = value;
				}
			}

			public int? TransferByNoAnswer
			{
				get
				{
					return transferByNoAnswer;
				}
				set	
				{
					transferByNoAnswer = value;
				}
			}

			public int? FinishedNum
			{
				get
				{
					return finishedNum;
				}
				set	
				{
					finishedNum = value;
				}
			}

			public int? TransferByIntentNum
			{
				get
				{
					return transferByIntentNum;
				}
				set	
				{
					transferByIntentNum = value;
				}
			}

			public int? CallNum
			{
				get
				{
					return callNum;
				}
				set	
				{
					callNum = value;
				}
			}

			public int? CallFailedNum
			{
				get
				{
					return callFailedNum;
				}
				set	
				{
					callFailedNum = value;
				}
			}

			public DescribeGroupExecutingInfo_JobsProgress JobsProgress
			{
				get
				{
					return jobsProgress;
				}
				set	
				{
					jobsProgress = value;
				}
			}

			public class DescribeGroupExecutingInfo_JobsProgress
			{

				private int? schedulingNum;

				private int? totalCompletedNum;

				private int? failedNum;

				private int? pausedNum;

				private int? cancelledNum;

				private int? totalJobs;

				private int? totalNotAnsweredNum;

				private int? executingNum;

				public int? SchedulingNum
				{
					get
					{
						return schedulingNum;
					}
					set	
					{
						schedulingNum = value;
					}
				}

				public int? TotalCompletedNum
				{
					get
					{
						return totalCompletedNum;
					}
					set	
					{
						totalCompletedNum = value;
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

				public int? TotalNotAnsweredNum
				{
					get
					{
						return totalNotAnsweredNum;
					}
					set	
					{
						totalNotAnsweredNum = value;
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
		}
	}
}
