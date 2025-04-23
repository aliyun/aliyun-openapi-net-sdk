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

namespace Aliyun.Acs.eds_user.Model.V20210308
{
	public class DescribeMfaDevicesResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private List<DescribeMfaDevices_Data> mfaDevices;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public List<DescribeMfaDevices_Data> MfaDevices
		{
			get
			{
				return mfaDevices;
			}
			set	
			{
				mfaDevices = value;
			}
		}

		public class DescribeMfaDevices_Data
		{

			private long? id;

			private string endUserId;

			private string email;

			private string gmtEnabled;

			private string gmtUnlock;

			private int? consecutiveFails;

			private string serialNumber;

			private string status;

			private string deviceType;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string EndUserId
			{
				get
				{
					return endUserId;
				}
				set	
				{
					endUserId = value;
				}
			}

			public string Email
			{
				get
				{
					return email;
				}
				set	
				{
					email = value;
				}
			}

			public string GmtEnabled
			{
				get
				{
					return gmtEnabled;
				}
				set	
				{
					gmtEnabled = value;
				}
			}

			public string GmtUnlock
			{
				get
				{
					return gmtUnlock;
				}
				set	
				{
					gmtUnlock = value;
				}
			}

			public int? ConsecutiveFails
			{
				get
				{
					return consecutiveFails;
				}
				set	
				{
					consecutiveFails = value;
				}
			}

			public string SerialNumber
			{
				get
				{
					return serialNumber;
				}
				set	
				{
					serialNumber = value;
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
		}
	}
}
