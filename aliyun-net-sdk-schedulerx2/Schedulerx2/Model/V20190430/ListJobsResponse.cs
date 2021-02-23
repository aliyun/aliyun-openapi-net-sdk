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

namespace Aliyun.Acs.schedulerx2.Model.V20190430
{
	public class ListJobsResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string message;

		private bool? success;

		private ListJobs_Data data;

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

		public ListJobs_Data Data
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

		public class ListJobs_Data
		{

			private List<ListJobs_Job> jobs;

			public List<ListJobs_Job> Jobs
			{
				get
				{
					return jobs;
				}
				set	
				{
					jobs = value;
				}
			}

			public class ListJobs_Job
			{

				private string className;

				private string jarUrl;

				private string content;

				private string name;

				private string description;

				private int? status;

				private string executeMode;

				private string parameters;

				private string maxConcurrency;

				private int? maxAttempt;

				private int? attemptInterval;

				private long? jobId;

				private ListJobs_MapTaskXAttrs mapTaskXAttrs;

				private ListJobs_TimeConfig timeConfig;

				private ListJobs_JobMonitorInfo jobMonitorInfo;

				public string ClassName
				{
					get
					{
						return className;
					}
					set	
					{
						className = value;
					}
				}

				public string JarUrl
				{
					get
					{
						return jarUrl;
					}
					set	
					{
						jarUrl = value;
					}
				}

				public string Content
				{
					get
					{
						return content;
					}
					set	
					{
						content = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string Description
				{
					get
					{
						return description;
					}
					set	
					{
						description = value;
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

				public string ExecuteMode
				{
					get
					{
						return executeMode;
					}
					set	
					{
						executeMode = value;
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

				public string MaxConcurrency
				{
					get
					{
						return maxConcurrency;
					}
					set	
					{
						maxConcurrency = value;
					}
				}

				public int? MaxAttempt
				{
					get
					{
						return maxAttempt;
					}
					set	
					{
						maxAttempt = value;
					}
				}

				public int? AttemptInterval
				{
					get
					{
						return attemptInterval;
					}
					set	
					{
						attemptInterval = value;
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

				public ListJobs_MapTaskXAttrs MapTaskXAttrs
				{
					get
					{
						return mapTaskXAttrs;
					}
					set	
					{
						mapTaskXAttrs = value;
					}
				}

				public ListJobs_TimeConfig TimeConfig
				{
					get
					{
						return timeConfig;
					}
					set	
					{
						timeConfig = value;
					}
				}

				public ListJobs_JobMonitorInfo JobMonitorInfo
				{
					get
					{
						return jobMonitorInfo;
					}
					set	
					{
						jobMonitorInfo = value;
					}
				}

				public class ListJobs_MapTaskXAttrs
				{

					private int? pageSize;

					private int? consumerSize;

					private int? queueSize;

					private int? dispatcherSize;

					private int? taskMaxAttempt;

					private int? taskAttemptInterval;

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

					public int? ConsumerSize
					{
						get
						{
							return consumerSize;
						}
						set	
						{
							consumerSize = value;
						}
					}

					public int? QueueSize
					{
						get
						{
							return queueSize;
						}
						set	
						{
							queueSize = value;
						}
					}

					public int? DispatcherSize
					{
						get
						{
							return dispatcherSize;
						}
						set	
						{
							dispatcherSize = value;
						}
					}

					public int? TaskMaxAttempt
					{
						get
						{
							return taskMaxAttempt;
						}
						set	
						{
							taskMaxAttempt = value;
						}
					}

					public int? TaskAttemptInterval
					{
						get
						{
							return taskAttemptInterval;
						}
						set	
						{
							taskAttemptInterval = value;
						}
					}
				}

				public class ListJobs_TimeConfig
				{

					private int? timeType;

					private string timeExpression;

					private string calendar;

					private int? dataOffset;

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

					public string TimeExpression
					{
						get
						{
							return timeExpression;
						}
						set	
						{
							timeExpression = value;
						}
					}

					public string Calendar
					{
						get
						{
							return calendar;
						}
						set	
						{
							calendar = value;
						}
					}

					public int? DataOffset
					{
						get
						{
							return dataOffset;
						}
						set	
						{
							dataOffset = value;
						}
					}
				}

				public class ListJobs_JobMonitorInfo
				{

					private List<ListJobs_ContactInfoItem> contactInfo;

					private ListJobs_MonitorConfig monitorConfig;

					public List<ListJobs_ContactInfoItem> ContactInfo
					{
						get
						{
							return contactInfo;
						}
						set	
						{
							contactInfo = value;
						}
					}

					public ListJobs_MonitorConfig MonitorConfig
					{
						get
						{
							return monitorConfig;
						}
						set	
						{
							monitorConfig = value;
						}
					}

					public class ListJobs_ContactInfoItem
					{

						private string userName;

						private string userPhone;

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

						public string UserPhone
						{
							get
							{
								return userPhone;
							}
							set	
							{
								userPhone = value;
							}
						}
					}

					public class ListJobs_MonitorConfig
					{

						private bool? timeoutEnable;

						private long? timeout;

						private bool? timeoutKillEnable;

						private bool? failEnable;

						private string sendChannel;

						public bool? TimeoutEnable
						{
							get
							{
								return timeoutEnable;
							}
							set	
							{
								timeoutEnable = value;
							}
						}

						public long? Timeout
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

						public bool? TimeoutKillEnable
						{
							get
							{
								return timeoutKillEnable;
							}
							set	
							{
								timeoutKillEnable = value;
							}
						}

						public bool? FailEnable
						{
							get
							{
								return failEnable;
							}
							set	
							{
								failEnable = value;
							}
						}

						public string SendChannel
						{
							get
							{
								return sendChannel;
							}
							set	
							{
								sendChannel = value;
							}
						}
					}
				}
			}
		}
	}
}
