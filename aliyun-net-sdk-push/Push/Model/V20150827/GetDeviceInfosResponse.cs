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

namespace Aliyun.Acs.Push.Model.V20150827
{
	public class GetDeviceInfosResponse : AcsResponse
	{

		private List<DeviceInfo> deviceInfos;

		public List<DeviceInfo> DeviceInfos
		{
			get
			{
				return deviceInfos;
			}
			set	
			{
				deviceInfos = value;
			}
		}

		public class DeviceInfo{

			private string deviceId;

			private bool? isOnline;

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

			public bool? IsOnline
			{
				get
				{
					return isOnline;
				}
				set	
				{
					isOnline = value;
				}
			}
		}
	}
}