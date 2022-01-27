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

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribePdnsUserInfoResponse : AcsResponse
	{

		private string requestId;

		private DescribePdnsUserInfo_UserInfo userInfo;

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

		public DescribePdnsUserInfo_UserInfo UserInfo
		{
			get
			{
				return userInfo;
			}
			set	
			{
				userInfo = value;
			}
		}

		public class DescribePdnsUserInfo_UserInfo
		{

			private string availableService;

			private string serviceType;

			private string state;

			private string stoppedService;

			private long? pdnsId;

			public string AvailableService
			{
				get
				{
					return availableService;
				}
				set	
				{
					availableService = value;
				}
			}

			public string ServiceType
			{
				get
				{
					return serviceType;
				}
				set	
				{
					serviceType = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string StoppedService
			{
				get
				{
					return stoppedService;
				}
				set	
				{
					stoppedService = value;
				}
			}

			public long? PdnsId
			{
				get
				{
					return pdnsId;
				}
				set	
				{
					pdnsId = value;
				}
			}
		}
	}
}
