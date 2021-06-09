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
	public class ListOTAUnfinishedTaskByDeviceResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private List<ListOTAUnfinishedTaskByDevice_SimpleOTATaskInfo> data;

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

		public List<ListOTAUnfinishedTaskByDevice_SimpleOTATaskInfo> Data
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

		public class ListOTAUnfinishedTaskByDevice_SimpleOTATaskInfo
		{

			private string taskId;

			private string utcModified;

			private string productKey;

			private string taskStatus;

			private string jobId;

			private string productName;

			private string deviceName;

			private string srcVersion;

			private string destVersion;

			private string iotId;

			private string utcCreate;

			private string moduleName;

			private string firmwareId;

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

			public string TaskStatus
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

			public string ProductName
			{
				get
				{
					return productName;
				}
				set	
				{
					productName = value;
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

			public string SrcVersion
			{
				get
				{
					return srcVersion;
				}
				set	
				{
					srcVersion = value;
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

			public string ModuleName
			{
				get
				{
					return moduleName;
				}
				set	
				{
					moduleName = value;
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
		}
	}
}
