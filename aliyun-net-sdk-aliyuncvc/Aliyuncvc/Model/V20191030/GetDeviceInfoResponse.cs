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

namespace Aliyun.Acs.aliyuncvc.Model.V20191030
{
	public class GetDeviceInfoResponse : AcsResponse
	{

		private int? errorCode;

		private string message;

		private bool? success;

		private string requestId;

		private GetDeviceInfo_Device device;

		public int? ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public GetDeviceInfo_Device Device
		{
			get
			{
				return device;
			}
			set	
			{
				device = value;
			}
		}

		public class GetDeviceInfo_Device
		{

			private string activationCode;

			private string castScreenCode;

			private string sn;

			private int? status;

			private string iP;

			private string mac;

			private string ssid;

			public string ActivationCode
			{
				get
				{
					return activationCode;
				}
				set	
				{
					activationCode = value;
				}
			}

			public string CastScreenCode
			{
				get
				{
					return castScreenCode;
				}
				set	
				{
					castScreenCode = value;
				}
			}

			public string Sn
			{
				get
				{
					return sn;
				}
				set	
				{
					sn = value;
				}
			}

			public int? Status
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

			public string IP
			{
				get
				{
					return iP;
				}
				set	
				{
					iP = value;
				}
			}

			public string Mac
			{
				get
				{
					return mac;
				}
				set	
				{
					mac = value;
				}
			}

			public string Ssid
			{
				get
				{
					return ssid;
				}
				set	
				{
					ssid = value;
				}
			}
		}
	}
}
