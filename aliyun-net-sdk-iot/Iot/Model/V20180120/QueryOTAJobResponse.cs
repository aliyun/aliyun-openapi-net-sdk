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
	public class QueryOTAJobResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private QueryOTAJob_Data data;

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

		public QueryOTAJob_Data Data
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

		public class QueryOTAJob_Data
		{

			private string jobId;

			private string utcCreate;

			private string utcModified;

			private string productKey;

			private string firmwareId;

			private string utcStartTime;

			private string utcEndTime;

			private string jobStatus;

			private string jobType;

			private string jobDesc;

			private string name;

			private string utcScheduleTime;

			private int? retryInterval;

			private int? retryCount;

			private int? timeoutInMinutes;

			private string targetSelection;

			private string selectionType;

			private string grayPercent;

			private int? maximumPerMinute;

			private string destVersion;

			private string utcScheduleFinishTime;

			private int? overwriteMode;

			private int? dynamicMode;

			private bool? needPush;

			private bool? needConfirm;

			private List<QueryOTAJob_OtaTagDTO> tags;

			private List<string> srcVersions;

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

			public string FirmwareId
			{
				get
				{
					return firmwareId;
				}
				set	
				{
					firmwareId = value;
				}
			}

			public string UtcStartTime
			{
				get
				{
					return utcStartTime;
				}
				set	
				{
					utcStartTime = value;
				}
			}

			public string UtcEndTime
			{
				get
				{
					return utcEndTime;
				}
				set	
				{
					utcEndTime = value;
				}
			}

			public string JobStatus
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

			public string JobType
			{
				get
				{
					return jobType;
				}
				set	
				{
					jobType = value;
				}
			}

			public string JobDesc
			{
				get
				{
					return jobDesc;
				}
				set	
				{
					jobDesc = value;
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

			public string UtcScheduleTime
			{
				get
				{
					return utcScheduleTime;
				}
				set	
				{
					utcScheduleTime = value;
				}
			}

			public int? RetryInterval
			{
				get
				{
					return retryInterval;
				}
				set	
				{
					retryInterval = value;
				}
			}

			public int? RetryCount
			{
				get
				{
					return retryCount;
				}
				set	
				{
					retryCount = value;
				}
			}

			public int? TimeoutInMinutes
			{
				get
				{
					return timeoutInMinutes;
				}
				set	
				{
					timeoutInMinutes = value;
				}
			}

			public string TargetSelection
			{
				get
				{
					return targetSelection;
				}
				set	
				{
					targetSelection = value;
				}
			}

			public string SelectionType
			{
				get
				{
					return selectionType;
				}
				set	
				{
					selectionType = value;
				}
			}

			public string GrayPercent
			{
				get
				{
					return grayPercent;
				}
				set	
				{
					grayPercent = value;
				}
			}

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

			public string DestVersion
			{
				get
				{
					return destVersion;
				}
				set	
				{
					destVersion = value;
				}
			}

			public string UtcScheduleFinishTime
			{
				get
				{
					return utcScheduleFinishTime;
				}
				set	
				{
					utcScheduleFinishTime = value;
				}
			}

			public int? OverwriteMode
			{
				get
				{
					return overwriteMode;
				}
				set	
				{
					overwriteMode = value;
				}
			}

			public int? DynamicMode
			{
				get
				{
					return dynamicMode;
				}
				set	
				{
					dynamicMode = value;
				}
			}

			public bool? NeedPush
			{
				get
				{
					return needPush;
				}
				set	
				{
					needPush = value;
				}
			}

			public bool? NeedConfirm
			{
				get
				{
					return needConfirm;
				}
				set	
				{
					needConfirm = value;
				}
			}

			public List<QueryOTAJob_OtaTagDTO> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public List<string> SrcVersions
			{
				get
				{
					return srcVersions;
				}
				set	
				{
					srcVersions = value;
				}
			}

			public class QueryOTAJob_OtaTagDTO
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
