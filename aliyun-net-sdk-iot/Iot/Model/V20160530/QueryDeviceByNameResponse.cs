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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Model.V20160530
{
	public class QueryDeviceByNameResponse : AcsResponse
	{

		private bool? success;

		private string errorMessage;

		private DeviceInfo_ deviceInfo;

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

		public DeviceInfo_ DeviceInfo
		{
			get
			{
				return deviceInfo;
			}
			set	
			{
				deviceInfo = value;
			}
		}

		public class DeviceInfo_{

			private string deviceId;

			private string deviceSecret;

			private string productKey;

			private string deviceStatus;

			private string deviceName;

			private string gmtCreate;

			private string gmtModified;

			public string DeviceId
			{
				get
				{
					return deviceId;
				}
				set	
				{
					deviceId = value;
				}
			}

			public string DeviceSecret
			{
				get
				{
					return deviceSecret;
				}
				set	
				{
					deviceSecret = value;
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

			public string DeviceStatus
			{
				get
				{
					return deviceStatus;
				}
				set	
				{
					deviceStatus = value;
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

			public string GmtCreate
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

			public string GmtModified
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
		}
	}
}