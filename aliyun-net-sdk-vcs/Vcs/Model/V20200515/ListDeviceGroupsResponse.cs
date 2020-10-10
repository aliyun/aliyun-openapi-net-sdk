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
	public class ListDeviceGroupsResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private List<ListDeviceGroups_DataItem> data;

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

		public List<ListDeviceGroups_DataItem> Data
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

		public class ListDeviceGroups_DataItem
		{

			private string totalCount;

			private List<ListDeviceGroups_ListItem> list;

			public string TotalCount
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

			public List<ListDeviceGroups_ListItem> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class ListDeviceGroups_ListItem
			{

				private string deviceGroup;

				private string deviceName;

				private string deviceCode;

				private string bitRate;

				private string codingFormat;

				private string resolvingPower;

				private string dataSourceType;

				private string regionName;

				private string regionId;

				private string installAddress;

				private string deviceSn;

				private string deviceStatus;

				private string deviceStreamStatus;

				private string deviceComputeStatus;

				public string DeviceGroup
				{
					get
					{
						return deviceGroup;
					}
					set	
					{
						deviceGroup = value;
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

				public string DeviceCode
				{
					get
					{
						return deviceCode;
					}
					set	
					{
						deviceCode = value;
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

				public string CodingFormat
				{
					get
					{
						return codingFormat;
					}
					set	
					{
						codingFormat = value;
					}
				}

				public string ResolvingPower
				{
					get
					{
						return resolvingPower;
					}
					set	
					{
						resolvingPower = value;
					}
				}

				public string DataSourceType
				{
					get
					{
						return dataSourceType;
					}
					set	
					{
						dataSourceType = value;
					}
				}

				public string RegionName
				{
					get
					{
						return regionName;
					}
					set	
					{
						regionName = value;
					}
				}

				public string RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
					}
				}

				public string InstallAddress
				{
					get
					{
						return installAddress;
					}
					set	
					{
						installAddress = value;
					}
				}

				public string DeviceSn
				{
					get
					{
						return deviceSn;
					}
					set	
					{
						deviceSn = value;
					}
				}

				public string DeviceStatus
				{
					get
					{
						return deviceStatus;
					}
					set	
					{
						deviceStatus = value;
					}
				}

				public string DeviceStreamStatus
				{
					get
					{
						return deviceStreamStatus;
					}
					set	
					{
						deviceStreamStatus = value;
					}
				}

				public string DeviceComputeStatus
				{
					get
					{
						return deviceComputeStatus;
					}
					set	
					{
						deviceComputeStatus = value;
					}
				}
			}
		}
	}
}
