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
	public class GetJobInfoResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private bool? success;

		private GetJobInfo_Data data;

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

		public GetJobInfo_Data Data
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

		public class GetJobInfo_Data
		{

			private GetJobInfo_JobConfigInfo jobConfigInfo;

			public GetJobInfo_JobConfigInfo JobConfigInfo
			{
				get
				{
					return jobConfigInfo;
				}
				set	
				{
					jobConfigInfo = value;
				}
			}

			public class GetJobInfo_JobConfigInfo
			{

				private long? jobId;

				private int? status;

				private string parameters;

				private string description;

				private string executeMode;

				private string maxConcurrency;

				private string name;

				private int? maxAttempt;

				private string content;

				private string jarUrl;

				private string className;

				private int? attemptInterval;

				private GetJobInfo_MapTaskXAttrs mapTaskXAttrs;

				private GetJobInfo_TimeConfig timeConfig;

				private GetJobInfo_JobMonitorInfo jobMonitorInfo;

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

				public GetJobInfo_MapTaskXAttrs MapTaskXAttrs
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

				public GetJobInfo_TimeConfig TimeConfig
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

				public GetJobInfo_JobMonitorInfo JobMonitorInfo
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

				public class GetJobInfo_MapTaskXAttrs
				{

					private int? taskMaxAttempt;

					private int? taskAttemptInterval;

					private int? consumerSize;

					private int? queueSize;

					private int? dispatcherSize;

					private int? pageSize;

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
				}

				public class GetJobInfo_TimeConfig
				{

					private string calendar;

					private int? timeType;

					private int? dataOffset;

					private string timeExpression;

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
				}

				public class GetJobInfo_JobMonitorInfo
				{

					private List<GetJobInfo_ContactInfoItem> contactInfo;

					private GetJobInfo_MonitorConfig monitorConfig;

					public List<GetJobInfo_ContactInfoItem> ContactInfo
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

					public GetJobInfo_MonitorConfig MonitorConfig
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

					public class GetJobInfo_ContactInfoItem
					{

						private string userPhone;

						private string userName;

						private string userMail;

						private string ding;

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

						public string UserMail
						{
							get
							{
								return userMail;
							}
							set	
							{
								userMail = value;
							}
						}

						public string Ding
						{
							get
							{
								return ding;
							}
							set	
							{
								ding = value;
							}
						}
					}

					public class GetJobInfo_MonitorConfig
					{

						private long? timeout;

						private string sendChannel;

						private bool? timeoutKillEnable;

						private bool? timeoutEnable;

						private bool? failEnable;

						private bool? missWorkerEnable;

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

						public bool? MissWorkerEnable
						{
							get
							{
								return missWorkerEnable;
							}
							set	
							{
								missWorkerEnable = value;
							}
						}
					}
				}
			}
		}
	}
}
