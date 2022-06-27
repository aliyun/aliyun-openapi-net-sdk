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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeInstallCodesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeInstallCodes_InstallCode> installCodes;

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

		public List<DescribeInstallCodes_InstallCode> InstallCodes
		{
			get
			{
				return installCodes;
			}
			set	
			{
				installCodes = value;
			}
		}

		public class DescribeInstallCodes_InstallCode
		{

			private bool? onlyImage;

			private string captchaCode;

			private long? groupId;

			private string groupName;

			private long? expiredDate;

			private string vendorName;

			private string os;

			private string tag;

			private int? vendor;

			public bool? OnlyImage
			{
				get
				{
					return onlyImage;
				}
				set	
				{
					onlyImage = value;
				}
			}

			public string CaptchaCode
			{
				get
				{
					return captchaCode;
				}
				set	
				{
					captchaCode = value;
				}
			}

			public long? GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
				}
			}

			public long? ExpiredDate
			{
				get
				{
					return expiredDate;
				}
				set	
				{
					expiredDate = value;
				}
			}

			public string VendorName
			{
				get
				{
					return vendorName;
				}
				set	
				{
					vendorName = value;
				}
			}

			public string Os
			{
				get
				{
					return os;
				}
				set	
				{
					os = value;
				}
			}

			public string Tag
			{
				get
				{
					return tag;
				}
				set	
				{
					tag = value;
				}
			}

			public int? Vendor
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
		}
	}
}
