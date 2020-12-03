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
	public class QuerySpeechModelPushJobResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private QuerySpeechModelPushJob_Data data;

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

		public QuerySpeechModelPushJob_Data Data
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

		public class QuerySpeechModelPushJob_Data
		{

			private int? total;

			private int? pageId;

			private int? pageSize;

			private List<QuerySpeechModelPushJob_Items> list;

			public int? Total
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

			public int? PageId
			{
				get
				{
					return pageId;
				}
				set	
				{
					pageId = value;
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

			public List<QuerySpeechModelPushJob_Items> List
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

			public class QuerySpeechModelPushJob_Items
			{

				private string code;

				private long? expiredTime;

				private string pushMode;

				private string iotId;

				private string status;

				private long? createdTime;

				private int? totalDeviceNum;

				private int? successDeviceNum;

				private bool? speechModelStatus;

				private int? failDeviceNum;

				private int? speechModelNum;

				private int? runningDeviceNum;

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

				public long? ExpiredTime
				{
					get
					{
						return expiredTime;
					}
					set	
					{
						expiredTime = value;
					}
				}

				public string PushMode
				{
					get
					{
						return pushMode;
					}
					set	
					{
						pushMode = value;
					}
				}

				public string IotId
				{
					get
					{
						return iotId;
					}
					set	
					{
						iotId = value;
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

				public long? CreatedTime
				{
					get
					{
						return createdTime;
					}
					set	
					{
						createdTime = value;
					}
				}

				public int? TotalDeviceNum
				{
					get
					{
						return totalDeviceNum;
					}
					set	
					{
						totalDeviceNum = value;
					}
				}

				public int? SuccessDeviceNum
				{
					get
					{
						return successDeviceNum;
					}
					set	
					{
						successDeviceNum = value;
					}
				}

				public bool? SpeechModelStatus
				{
					get
					{
						return speechModelStatus;
					}
					set	
					{
						speechModelStatus = value;
					}
				}

				public int? FailDeviceNum
				{
					get
					{
						return failDeviceNum;
					}
					set	
					{
						failDeviceNum = value;
					}
				}

				public int? SpeechModelNum
				{
					get
					{
						return speechModelNum;
					}
					set	
					{
						speechModelNum = value;
					}
				}

				public int? RunningDeviceNum
				{
					get
					{
						return runningDeviceNum;
					}
					set	
					{
						runningDeviceNum = value;
					}
				}
			}
		}
	}
}
