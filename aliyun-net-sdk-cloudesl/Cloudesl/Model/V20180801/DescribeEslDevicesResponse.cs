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

namespace Aliyun.Acs.cloudesl.Model.V20180801
{
	public class DescribeEslDevicesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string message;

		private string errorCode;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeEslDevices_EslDeviceInfo> eslDevices;

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

			private string companyId;

			private string storeId;

			private string mac;

			private string eslBarCode;

			private string itemBarCode;

			private string vendor;

			private string connectAp;

			private string type;

			private string model;

			private string beBind;

			private string screenWidth;

			private string screenHeight;

			private string lastCommunicateTime;

			private int? batteryLevel;

			private string eslStatus;

			private string shelfCode;

			private string positionCode;

			private long? itemId;

			private string itemTitle;

			private int? itemActionPrice;

			private string itemPriceUnit;

			public string CompanyId
			{
				get
				{
					return companyId;
				}
				set	
				{
					companyId = value;
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

			public string ItemBarCode
			{
				get
				{
					return itemBarCode;
				}
				set	
				{
					itemBarCode = value;
				}
			}

			public string Vendor
			{
				get
				{
					return vendor;
				}
				set	
				{
					vendor = value;
				}
			}

			public string ConnectAp
			{
				get
				{
					return connectAp;
				}
				set	
				{
					connectAp = value;
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

			public string BeBind
			{
				get
				{
					return beBind;
				}
				set	
				{
					beBind = value;
				}
			}

			public string ScreenWidth
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

			public string ScreenHeight
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

			public string ShelfCode
			{
				get
				{
					return shelfCode;
				}
				set	
				{
					shelfCode = value;
				}
			}

			public string PositionCode
			{
				get
				{
					return positionCode;
				}
				set	
				{
					positionCode = value;
				}
			}

			public long? ItemId
			{
				get
				{
					return itemId;
				}
				set	
				{
					itemId = value;
				}
			}

			public string ItemTitle
			{
				get
				{
					return itemTitle;
				}
				set	
				{
					itemTitle = value;
				}
			}

			public int? ItemActionPrice
			{
				get
				{
					return itemActionPrice;
				}
				set	
				{
					itemActionPrice = value;
				}
			}

			public string ItemPriceUnit
			{
				get
				{
					return itemPriceUnit;
				}
				set	
				{
					itemPriceUnit = value;
				}
			}
		}
	}
}
