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

namespace Aliyun.Acs.Cloudauth.Model.V20190307
{
	public class DescribeDeviceInfoResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeDeviceInfo_DeviceInfo> deviceInfoList;

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

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
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

		public List<DescribeDeviceInfo_DeviceInfo> DeviceInfoList
		{
			get
			{
				return deviceInfoList;
			}
			set	
			{
				deviceInfoList = value;
			}
		}

		public class DescribeDeviceInfo_DeviceInfo
		{

			private string deviceId;

			private string userDeviceId;

			private string bizType;

			private string beginDay;

			private string expiredDay;

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

			public string UserDeviceId
			{
				get
				{
					return userDeviceId;
				}
				set	
				{
					userDeviceId = value;
				}
			}

			public string BizType
			{
				get
				{
					return bizType;
				}
				set	
				{
					bizType = value;
				}
			}

			public string BeginDay
			{
				get
				{
					return beginDay;
				}
				set	
				{
					beginDay = value;
				}
			}

			public string ExpiredDay
			{
				get
				{
					return expiredDay;
				}
				set	
				{
					expiredDay = value;
				}
			}
		}
	}
}
