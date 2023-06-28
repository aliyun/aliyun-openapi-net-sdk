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
	public class QueryDeviceProvisioningResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private QueryDeviceProvisioning_Data data;

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

		public QueryDeviceProvisioning_Data Data
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

		public class QueryDeviceProvisioning_Data
		{

			private long? gmtCreate;

			private long? gmtModified;

			private string aliyunUid;

			private string productKey;

			private string deviceName;

			private string sourceIotInstanceId;

			private string targetIotInstanceId;

			private string sourceRegion;

			private string targetRegion;

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string AliyunUid
			{
				get
				{
					return aliyunUid;
				}
				set	
				{
					aliyunUid = value;
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

			public string SourceIotInstanceId
			{
				get
				{
					return sourceIotInstanceId;
				}
				set	
				{
					sourceIotInstanceId = value;
				}
			}

			public string TargetIotInstanceId
			{
				get
				{
					return targetIotInstanceId;
				}
				set	
				{
					targetIotInstanceId = value;
				}
			}

			public string SourceRegion
			{
				get
				{
					return sourceRegion;
				}
				set	
				{
					sourceRegion = value;
				}
			}

			public string TargetRegion
			{
				get
				{
					return targetRegion;
				}
				set	
				{
					targetRegion = value;
				}
			}
		}
	}
}
