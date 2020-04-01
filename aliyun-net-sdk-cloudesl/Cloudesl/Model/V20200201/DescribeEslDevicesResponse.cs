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

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
	public class DescribeEslDevicesResponse : AcsResponse
	{

		private string errorMessage;

		private string errorCode;

		private int? pageSize;

		private string message;

		private int? totalCount;

		private string dynamicCode;

		private string code;

		private int? pageNumber;

		private string dynamicMessage;

		private string requestId;

		private bool? success;

		private List<DescribeEslDevices_EslDeviceInfo> eslDevices;

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

		public string ErrorCode
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

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
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

		public List<DescribeEslDevices_EslDeviceInfo> EslDevices
		{
			get
			{
				return eslDevices;
			}
			set	
			{
				eslDevices = value;
			}
		}

		public class DescribeEslDevices_EslDeviceInfo
		{

			private string lastCommunicateTime;

			private string model;

			private string eslStatus;

			private string storeId;

			private string eslBarCode;

			private string type;

			private string mac;

			private int? batteryLevel;

			private int? screenWidth;

			private int? screenHeight;

			public string LastCommunicateTime
			{
				get
				{
					return lastCommunicateTime;
				}
				set	
				{
					lastCommunicateTime = value;
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

			public string EslStatus
			{
				get
				{
					return eslStatus;
				}
				set	
				{
					eslStatus = value;
				}
			}

			public string StoreId
			{
				get
				{
					return storeId;
				}
				set	
				{
					storeId = value;
				}
			}

			public string EslBarCode
			{
				get
				{
					return eslBarCode;
				}
				set	
				{
					eslBarCode = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
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

			public int? BatteryLevel
			{
				get
				{
					return batteryLevel;
				}
				set	
				{
					batteryLevel = value;
				}
			}

			public int? ScreenWidth
			{
				get
				{
					return screenWidth;
				}
				set	
				{
					screenWidth = value;
				}
			}

			public int? ScreenHeight
			{
				get
				{
					return screenHeight;
				}
				set	
				{
					screenHeight = value;
				}
			}
		}
	}
}
