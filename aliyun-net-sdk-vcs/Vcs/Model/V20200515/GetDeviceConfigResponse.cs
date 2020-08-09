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

namespace Aliyun.Acs.Vcs.Model.V20200515
{
	public class GetDeviceConfigResponse : AcsResponse
	{

		private bool? audioEnable;

		private string audioFormat;

		private string bitRate;

		private string code;

		private string deviceAddress;

		private string deviceName;

		private string encodeFormat;

		private string frameRate;

		private int? govLength;

		private string latitude;

		private string longitude;

		private string message;

		private string oSDTimeEnable;

		private string oSDTimeType;

		private string oSDTimeX;

		private string oSDTimeY;

		private string requestId;

		private string resolution;

		private string retryInterval;

		private string deviceId;

		private string userName;

		private string passWord;

		private string protocol;

		private string serverId;

		private string serverPort;

		private string serverIp;

		private List<GetDeviceConfig_OSDListItem> oSDList;

		public bool? AudioEnable
		{
			get
			{
				return audioEnable;
			}
			set	
			{
				audioEnable = value;
			}
		}

		public string AudioFormat
		{
			get
			{
				return audioFormat;
			}
			set	
			{
				audioFormat = value;
			}
		}

		public string BitRate
		{
			get
			{
				return bitRate;
			}
			set	
			{
				bitRate = value;
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

		public string DeviceAddress
		{
			get
			{
				return deviceAddress;
			}
			set	
			{
				deviceAddress = value;
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

		public string EncodeFormat
		{
			get
			{
				return encodeFormat;
			}
			set	
			{
				encodeFormat = value;
			}
		}

		public string FrameRate
		{
			get
			{
				return frameRate;
			}
			set	
			{
				frameRate = value;
			}
		}

		public int? GovLength
		{
			get
			{
				return govLength;
			}
			set	
			{
				govLength = value;
			}
		}

		public string Latitude
		{
			get
			{
				return latitude;
			}
			set	
			{
				latitude = value;
			}
		}

		public string Longitude
		{
			get
			{
				return longitude;
			}
			set	
			{
				longitude = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public string OSDTimeEnable
		{
			get
			{
				return oSDTimeEnable;
			}
			set	
			{
				oSDTimeEnable = value;
			}
		}

		public string OSDTimeType
		{
			get
			{
				return oSDTimeType;
			}
			set	
			{
				oSDTimeType = value;
			}
		}

		public string OSDTimeX
		{
			get
			{
				return oSDTimeX;
			}
			set	
			{
				oSDTimeX = value;
			}
		}

		public string OSDTimeY
		{
			get
			{
				return oSDTimeY;
			}
			set	
			{
				oSDTimeY = value;
			}
		}

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

		public string Resolution
		{
			get
			{
				return resolution;
			}
			set	
			{
				resolution = value;
			}
		}

		public string RetryInterval
		{
			get
			{
				return retryInterval;
			}
			set	
			{
				retryInterval = value;
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

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
			}
		}

		public string PassWord
		{
			get
			{
				return passWord;
			}
			set	
			{
				passWord = value;
			}
		}

		public string Protocol
		{
			get
			{
				return protocol;
			}
			set	
			{
				protocol = value;
			}
		}

		public string ServerId
		{
			get
			{
				return serverId;
			}
			set	
			{
				serverId = value;
			}
		}

		public string ServerPort
		{
			get
			{
				return serverPort;
			}
			set	
			{
				serverPort = value;
			}
		}

		public string ServerIp
		{
			get
			{
				return serverIp;
			}
			set	
			{
				serverIp = value;
			}
		}

		public List<GetDeviceConfig_OSDListItem> OSDList
		{
			get
			{
				return oSDList;
			}
			set	
			{
				oSDList = value;
			}
		}

		public class GetDeviceConfig_OSDListItem
		{

			private string text;

			private string leftTopX;

			private string leftTopY;

			public string Text
			{
				get
				{
					return text;
				}
				set	
				{
					text = value;
				}
			}

			public string LeftTopX
			{
				get
				{
					return leftTopX;
				}
				set	
				{
					leftTopX = value;
				}
			}

			public string LeftTopY
			{
				get
				{
					return leftTopY;
				}
				set	
				{
					leftTopY = value;
				}
			}
		}
	}
}
