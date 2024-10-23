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

namespace Aliyun.Acs.Push.Model.V20160801
{
	public class QueryDeviceInfoResponse : AcsResponse
	{

		private string requestId;

		private QueryDeviceInfo_DeviceInfo deviceInfo;

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

		public QueryDeviceInfo_DeviceInfo DeviceInfo
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

		public class QueryDeviceInfo_DeviceInfo
		{

			private string account;

			private string alias;

			private string brand;

			private string deviceId;

			private string deviceToken;

			private string deviceType;

			private string lastOnlineTime;

			private string model;

			private bool? online;

			private string phoneNumber;

			private bool? pushEnabled;

			private string tags;

			public string Account
			{
				get
				{
					return account;
				}
				set	
				{
					account = value;
				}
			}

			public string Alias
			{
				get
				{
					return alias;
				}
				set	
				{
					alias = value;
				}
			}

			public string Brand
			{
				get
				{
					return brand;
				}
				set	
				{
					brand = value;
				}
			}

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

			public string DeviceToken
			{
				get
				{
					return deviceToken;
				}
				set	
				{
					deviceToken = value;
				}
			}

			public string DeviceType
			{
				get
				{
					return deviceType;
				}
				set	
				{
					deviceType = value;
				}
			}

			public string LastOnlineTime
			{
				get
				{
					return lastOnlineTime;
				}
				set	
				{
					lastOnlineTime = value;
				}
			}

			public string Model
			{
				get
				{
					return model;
				}
				set	
				{
					model = value;
				}
			}

			public bool? Online
			{
				get
				{
					return online;
				}
				set	
				{
					online = value;
				}
			}

			public string PhoneNumber
			{
				get
				{
					return phoneNumber;
				}
				set	
				{
					phoneNumber = value;
				}
			}

			public bool? PushEnabled
			{
				get
				{
					return pushEnabled;
				}
				set	
				{
					pushEnabled = value;
				}
			}

			public string Tags
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
		}
	}
}
