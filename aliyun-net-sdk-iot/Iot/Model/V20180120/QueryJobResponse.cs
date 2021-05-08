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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class QueryJobResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private QueryJob_Data data;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public QueryJob_Data Data
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

		public class QueryJob_Data
		{

			private string jobId;

			private string jobName;

			private string utcCreate;

			private string status;

			private string description;

			private string type;

			private string jobDocument;

			private string utcModified;

			private long? scheduledTime;

			private QueryJob_RolloutConfig rolloutConfig;

			private QueryJob_TimeoutConfig timeoutConfig;

			private QueryJob_JobFile jobFile;

			private QueryJob_TargetConfig targetConfig;

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

			public string UtcCreate
			{
				get
				{
					return utcCreate;
				}
				set	
				{
					utcCreate = value;
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

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string JobDocument
			{
				get
				{
					return jobDocument;
				}
				set	
				{
					jobDocument = value;
				}
			}

			public string UtcModified
			{
				get
				{
					return utcModified;
				}
				set	
				{
					utcModified = value;
				}
			}

			public long? ScheduledTime
			{
				get
				{
					return scheduledTime;
				}
				set	
				{
					scheduledTime = value;
				}
			}

			public QueryJob_RolloutConfig RolloutConfig
			{
				get
				{
					return rolloutConfig;
				}
				set	
				{
					rolloutConfig = value;
				}
			}

			public QueryJob_TimeoutConfig TimeoutConfig
			{
				get
				{
					return timeoutConfig;
				}
				set	
				{
					timeoutConfig = value;
				}
			}

			public QueryJob_JobFile JobFile
			{
				get
				{
					return jobFile;
				}
				set	
				{
					jobFile = value;
				}
			}

			public QueryJob_TargetConfig TargetConfig
			{
				get
				{
					return targetConfig;
				}
				set	
				{
					targetConfig = value;
				}
			}

			public class QueryJob_RolloutConfig
			{

				private int? maximumPerMinute;

				public int? MaximumPerMinute
				{
					get
					{
						return maximumPerMinute;
					}
					set	
					{
						maximumPerMinute = value;
					}
				}
			}

			public class QueryJob_TimeoutConfig
			{

				private int? inProgressTimeoutInMinutes;

				public int? InProgressTimeoutInMinutes
				{
					get
					{
						return inProgressTimeoutInMinutes;
					}
					set	
					{
						inProgressTimeoutInMinutes = value;
					}
				}
			}

			public class QueryJob_JobFile
			{

				private string fileUrl;

				private string signMethod;

				private string sign;

				public string FileUrl
				{
					get
					{
						return fileUrl;
					}
					set	
					{
						fileUrl = value;
					}
				}

				public string SignMethod
				{
					get
					{
						return signMethod;
					}
					set	
					{
						signMethod = value;
					}
				}

				public string Sign
				{
					get
					{
						return sign;
					}
					set	
					{
						sign = value;
					}
				}
			}

			public class QueryJob_TargetConfig
			{

				private string targetGroup;

				private string targetProduct;

				private string targetType;

				private List<QueryJob_TargetDevicesItem> targetDevices;

				public string TargetGroup
				{
					get
					{
						return targetGroup;
					}
					set	
					{
						targetGroup = value;
					}
				}

				public string TargetProduct
				{
					get
					{
						return targetProduct;
					}
					set	
					{
						targetProduct = value;
					}
				}

				public string TargetType
				{
					get
					{
						return targetType;
					}
					set	
					{
						targetType = value;
					}
				}

				public List<QueryJob_TargetDevicesItem> TargetDevices
				{
					get
					{
						return targetDevices;
					}
					set	
					{
						targetDevices = value;
					}
				}

				public class QueryJob_TargetDevicesItem
				{

					private string productKey;

					private string deviceName;

					public string ProductKey
					{
						get
						{
							return productKey;
						}
						set	
						{
							productKey = value;
						}
					}

					public string DeviceName
					{
						get
						{
							return deviceName;
						}
						set	
						{
							deviceName = value;
						}
					}
				}
			}
		}
	}
}
