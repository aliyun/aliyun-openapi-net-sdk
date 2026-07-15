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

namespace Aliyun.Acs.schedulerx2.Model.V20190430
{
	public class GetJobInstanceResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private int? code;

		private bool? success;

		private GetJobInstance_Data data;

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

		public int? Code
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

		public GetJobInstance_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetJobInstance_Data
		{

			private GetJobInstance_JobInstanceDetail jobInstanceDetail;

			public GetJobInstance_JobInstanceDetail JobInstanceDetail
			{
				get
				{
					return jobInstanceDetail;
				}
				set	
				{
					jobInstanceDetail = value;
				}
			}

			public class GetJobInstance_JobInstanceDetail
			{

				private int? status;

				private int? triggerType;

				private string progress;

				private string parameters;

				private string endTime;

				private long? instanceId;

				private string workAddr;

				private string startTime;

				private string jobName;

				private string dataTime;

				private string result;

				private int? timeType;

				private string executor;

				private string scheduleTime;

				private string traceId;

				private long? jobId;

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

				public int? TriggerType
				{
					get
					{
						return triggerType;
					}
					set	
					{
						triggerType = value;
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

				public string Parameters
				{
					get
					{
						return parameters;
					}
					set	
					{
						parameters = value;
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

				public long? InstanceId
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

				public string WorkAddr
				{
					get
					{
						return workAddr;
					}
					set	
					{
						workAddr = value;
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

				public string JobName
				{
					get
					{
						return jobName;
					}
					set	
					{
						jobName = value;
					}
				}

				public string DataTime
				{
					get
					{
						return dataTime;
					}
					set	
					{
						dataTime = value;
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

				public int? TimeType
				{
					get
					{
						return timeType;
					}
					set	
					{
						timeType = value;
					}
				}

				public string Executor
				{
					get
					{
						return executor;
					}
					set	
					{
						executor = value;
					}
				}

				public string ScheduleTime
				{
					get
					{
						return scheduleTime;
					}
					set	
					{
						scheduleTime = value;
					}
				}

				public string TraceId
				{
					get
					{
						return traceId;
					}
					set	
					{
						traceId = value;
					}
				}

				public long? JobId
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
			}
		}
	}
}
