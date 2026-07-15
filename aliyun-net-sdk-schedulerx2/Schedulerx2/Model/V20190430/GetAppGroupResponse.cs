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
	public class GetAppGroupResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private int? code;

		private bool? success;

		private GetAppGroup_Data data;

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

		public GetAppGroup_Data Data
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

		public class GetAppGroup_Data
		{

			private string description;

			private int? curJobs;

			private int? maxConcurrency;

			private string monitorContactsJson;

			private bool? enableLog;

			private string _namespace;

			private string appName;

			private string groupId;

			private string appVersion;

			private string monitorConfigJson;

			private int? readyInstanceNum;

			private long? appGroupId;

			private string appKey;

			private string metricsThresholdJson;

			private string notificationPolicyName;

			private int? runningInstanceNum;

			private string xattrs;

			private int? maxJobs;

			private string alarmJson;

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

			public int? CurJobs
			{
				get
				{
					return curJobs;
				}
				set	
				{
					curJobs = value;
				}
			}

			public int? MaxConcurrency
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

			public string MonitorContactsJson
			{
				get
				{
					return monitorContactsJson;
				}
				set	
				{
					monitorContactsJson = value;
				}
			}

			public bool? EnableLog
			{
				get
				{
					return enableLog;
				}
				set	
				{
					enableLog = value;
				}
			}

			public string _Namespace
			{
				get
				{
					return _namespace;
				}
				set	
				{
					_namespace = value;
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

			public string AppVersion
			{
				get
				{
					return appVersion;
				}
				set	
				{
					appVersion = value;
				}
			}

			public string MonitorConfigJson
			{
				get
				{
					return monitorConfigJson;
				}
				set	
				{
					monitorConfigJson = value;
				}
			}

			public int? ReadyInstanceNum
			{
				get
				{
					return readyInstanceNum;
				}
				set	
				{
					readyInstanceNum = value;
				}
			}

			public long? AppGroupId
			{
				get
				{
					return appGroupId;
				}
				set	
				{
					appGroupId = value;
				}
			}

			public string AppKey
			{
				get
				{
					return appKey;
				}
				set	
				{
					appKey = value;
				}
			}

			public string MetricsThresholdJson
			{
				get
				{
					return metricsThresholdJson;
				}
				set	
				{
					metricsThresholdJson = value;
				}
			}

			public string NotificationPolicyName
			{
				get
				{
					return notificationPolicyName;
				}
				set	
				{
					notificationPolicyName = value;
				}
			}

			public int? RunningInstanceNum
			{
				get
				{
					return runningInstanceNum;
				}
				set	
				{
					runningInstanceNum = value;
				}
			}

			public string Xattrs
			{
				get
				{
					return xattrs;
				}
				set	
				{
					xattrs = value;
				}
			}

			public int? MaxJobs
			{
				get
				{
					return maxJobs;
				}
				set	
				{
					maxJobs = value;
				}
			}

			public string AlarmJson
			{
				get
				{
					return alarmJson;
				}
				set	
				{
					alarmJson = value;
				}
			}
		}
	}
}
