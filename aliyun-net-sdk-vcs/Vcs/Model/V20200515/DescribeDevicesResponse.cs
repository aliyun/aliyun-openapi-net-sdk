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
	public class DescribeDevicesResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private DescribeDevices_Data data;

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

		public DescribeDevices_Data Data
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

		public class DescribeDevices_Data
		{

			private int? pageNum;

			private int? pageSize;

			private int? totalCount;

			private int? totalPage;

			private List<DescribeDevices_Record> records;

			public int? PageNum
			{
				get
				{
					return pageNum;
				}
				set	
				{
					pageNum = value;
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

			public int? TotalPage
			{
				get
				{
					return totalPage;
				}
				set	
				{
					totalPage = value;
				}
			}

			public List<DescribeDevices_Record> Records
			{
				get
				{
					return records;
				}
				set	
				{
					records = value;
				}
			}

			public class DescribeDevices_Record
			{

				private string inProtocol;

				private string createTime;

				private string deviceAddress;

				private string deviceId;

				private string deviceName;

				private string deviceType;

				private string latitude;

				private string longitude;

				private string status;

				private string vendor;

				private string corpId;

				public string InProtocol
				{
					get
					{
						return inProtocol;
					}
					set	
					{
						inProtocol = value;
					}
				}

				public string CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
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

				public string CorpId
				{
					get
					{
						return corpId;
					}
					set	
					{
						corpId = value;
					}
				}
			}
		}
	}
}
