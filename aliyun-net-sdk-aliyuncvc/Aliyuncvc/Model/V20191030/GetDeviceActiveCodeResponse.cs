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
	public class GetDeviceActiveCodeResponse : AcsResponse
	{

		private int? errorCode;

		private string message;

		private bool? success;

		private List<GetDeviceActiveCode_Data> devices;

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

		public List<GetDeviceActiveCode_Data> Devices
		{
			get
			{
				return devices;
			}
			set	
			{
				devices = value;
			}
		}

		public class GetDeviceActiveCode_Data
		{

			private int? deviceErrorCode;

			private string deviceMessage;

			private string sN;

			private string activeCode;

			public int? DeviceErrorCode
			{
				get
				{
					return deviceErrorCode;
				}
				set	
				{
					deviceErrorCode = value;
				}
			}

			public string DeviceMessage
			{
				get
				{
					return deviceMessage;
				}
				set	
				{
					deviceMessage = value;
				}
			}

			public string SN
			{
				get
				{
					return sN;
				}
				set	
				{
					sN = value;
				}
			}

			public string ActiveCode
			{
				get
				{
					return activeCode;
				}
				set	
				{
					activeCode = value;
				}
			}
		}
	}
}
