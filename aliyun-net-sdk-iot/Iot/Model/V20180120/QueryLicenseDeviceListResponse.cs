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
	public class QueryLicenseDeviceListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private QueryLicenseDeviceList_Data data;

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

		public QueryLicenseDeviceList_Data Data
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

		public class QueryLicenseDeviceList_Data
		{

			private int? pageSize;

			private int? pageId;

			private int? total;

			private List<QueryLicenseDeviceList_Item> deviceList;

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

			public int? PageId
			{
				get
				{
					return pageId;
				}
				set	
				{
					pageId = value;
				}
			}

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public List<QueryLicenseDeviceList_Item> DeviceList
			{
				get
				{
					return deviceList;
				}
				set	
				{
					deviceList = value;
				}
			}

			public class QueryLicenseDeviceList_Item
			{

				private string productName;

				private string licenseCode;

				private string productKey;

				private string deviceName;

				private long? expiryTime;

				private long? gmtCreate;

				private string iotId;

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

				public string LicenseCode
				{
					get
					{
						return licenseCode;
					}
					set	
					{
						licenseCode = value;
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

				public long? ExpiryTime
				{
					get
					{
						return expiryTime;
					}
					set	
					{
						expiryTime = value;
					}
				}

				public long? GmtCreate
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
			}
		}
	}
}
