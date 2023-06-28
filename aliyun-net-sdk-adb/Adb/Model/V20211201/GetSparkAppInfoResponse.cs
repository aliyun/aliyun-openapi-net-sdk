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

namespace Aliyun.Acs.adb.Model.V20211201
{
	public class GetSparkAppInfoResponse : AcsResponse
	{

		private string requestId;

		private GetSparkAppInfo_Data data;

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

		public GetSparkAppInfo_Data Data
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

		public class GetSparkAppInfo_Data
		{

			private string appId;

			private string appName;

			private string state;

			private string message;

			private string dBClusterId;

			private GetSparkAppInfo_Detail detail;

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
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

			public string DBClusterId
			{
				get
				{
					return dBClusterId;
				}
				set	
				{
					dBClusterId = value;
				}
			}

			public GetSparkAppInfo_Detail Detail
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

			public class GetSparkAppInfo_Detail
			{

				private string data;

				private long? estimateExecutionCpuTimeInSeconds;

				private string logRootPath;

				private string lastAttemptId;

				private string webUiAddress;

				private long? submittedTimeInMillis;

				private long? startedTimeInMillis;

				private long? lastUpdatedTimeInMillis;

				private long? terminatedTimeInMillis;

				private string dBClusterId;

				private string resourceGroupName;

				private long? durationInMillis;

				public string Data
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

				public long? EstimateExecutionCpuTimeInSeconds
				{
					get
					{
						return estimateExecutionCpuTimeInSeconds;
					}
					set	
					{
						estimateExecutionCpuTimeInSeconds = value;
					}
				}

				public string LogRootPath
				{
					get
					{
						return logRootPath;
					}
					set	
					{
						logRootPath = value;
					}
				}

				public string LastAttemptId
				{
					get
					{
						return lastAttemptId;
					}
					set	
					{
						lastAttemptId = value;
					}
				}

				public string WebUiAddress
				{
					get
					{
						return webUiAddress;
					}
					set	
					{
						webUiAddress = value;
					}
				}

				public long? SubmittedTimeInMillis
				{
					get
					{
						return submittedTimeInMillis;
					}
					set	
					{
						submittedTimeInMillis = value;
					}
				}

				public long? StartedTimeInMillis
				{
					get
					{
						return startedTimeInMillis;
					}
					set	
					{
						startedTimeInMillis = value;
					}
				}

				public long? LastUpdatedTimeInMillis
				{
					get
					{
						return lastUpdatedTimeInMillis;
					}
					set	
					{
						lastUpdatedTimeInMillis = value;
					}
				}

				public long? TerminatedTimeInMillis
				{
					get
					{
						return terminatedTimeInMillis;
					}
					set	
					{
						terminatedTimeInMillis = value;
					}
				}

				public string DBClusterId
				{
					get
					{
						return dBClusterId;
					}
					set	
					{
						dBClusterId = value;
					}
				}

				public string ResourceGroupName
				{
					get
					{
						return resourceGroupName;
					}
					set	
					{
						resourceGroupName = value;
					}
				}

				public long? DurationInMillis
				{
					get
					{
						return durationInMillis;
					}
					set	
					{
						durationInMillis = value;
					}
				}
			}
		}
	}
}
