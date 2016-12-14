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

namespace Aliyun.Acs.Push.Model.V20160801
{
	public class QueryDeviceInfoResponse : AcsResponse
	{

		private DeviceInfo_ deviceInfo;

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

			private string deviceType;

			private string account;

			private string deviceToken;

			private string tags;

			private string alias;

			private string lastOnlineTime;

			private bool? online;

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
		}
	}
}