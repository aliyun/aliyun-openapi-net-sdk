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
	public class CheckDevicesResponse : AcsResponse
	{

		private List<DeviceCheckInfo> deviceCheckInfos;

		public List<DeviceCheckInfo> DeviceCheckInfos
		{
			get
			{
				return deviceCheckInfos;
			}
			set	
			{
				deviceCheckInfos = value;
			}
		}

		public class DeviceCheckInfo{

			private string deviceId;

			private bool? available;

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

			public bool? Available
			{
				get
				{
					return available;
				}
				set	
				{
					available = value;
				}
			}
		}
	}
}