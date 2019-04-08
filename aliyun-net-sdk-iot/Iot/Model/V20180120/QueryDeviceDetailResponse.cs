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
	public class QueryDeviceDetailResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private QueryDeviceDetail_Data data;

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

		public QueryDeviceDetail_Data Data
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

		public class QueryDeviceDetail_Data
		{

			private string iotId;

			private string productKey;

			private string productName;

			private string deviceName;

			private string deviceSecret;

			private string firmwareVersion;

			private string gmtCreate;

			private string utcCreate;

			private string gmtActive;

			private string utcActive;

			private string gmtOnline;

			private string utcOnline;

			private string status;

			private string ipAddress;

			private int? nodeType;

			private string region;

			private bool? owner;

			private string nickname;

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

			public string FirmwareVersion
			{
				get
				{
					return firmwareVersion;
				}
				set	
				{
					firmwareVersion = value;
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

			public string GmtActive
			{
				get
				{
					return gmtActive;
				}
				set	
				{
					gmtActive = value;
				}
			}

			public string UtcActive
			{
				get
				{
					return utcActive;
				}
				set	
				{
					utcActive = value;
				}
			}

			public string GmtOnline
			{
				get
				{
					return gmtOnline;
				}
				set	
				{
					gmtOnline = value;
				}
			}

			public string UtcOnline
			{
				get
				{
					return utcOnline;
				}
				set	
				{
					utcOnline = value;
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

			public string IpAddress
			{
				get
				{
					return ipAddress;
				}
				set	
				{
					ipAddress = value;
				}
			}

			public int? NodeType
			{
				get
				{
					return nodeType;
				}
				set	
				{
					nodeType = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public bool? Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
				}
			}

			public string Nickname
			{
				get
				{
					return nickname;
				}
				set	
				{
					nickname = value;
				}
			}
		}
	}
}
