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

namespace Aliyun.Acs.Market.Model.V20151101
{
	public class DescribeLicenseResponse : AcsResponse
	{

		private string requestId;

		private DescribeLicense_License license;

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

		public DescribeLicense_License License
		{
			get
			{
				return license;
			}
			set	
			{
				license = value;
			}
		}

		public class DescribeLicense_License
		{

			private string licenseStatus;

			private string licenseCode;

			private string instanceId;

			private string createTime;

			private string expiredTime;

			private string activateTime;

			private string productSkuId;

			private string productCode;

			private string productName;

			private string supplierName;

			private List<DescribeLicense_LicenseAttribute> extendArray;

			private DescribeLicense_ExtendInfo extendInfo;

			public string LicenseStatus
			{
				get
				{
					return licenseStatus;
				}
				set	
				{
					licenseStatus = value;
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

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
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

			public string ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
				}
			}

			public string ActivateTime
			{
				get
				{
					return activateTime;
				}
				set	
				{
					activateTime = value;
				}
			}

			public string ProductSkuId
			{
				get
				{
					return productSkuId;
				}
				set	
				{
					productSkuId = value;
				}
			}

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}

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

			public string SupplierName
			{
				get
				{
					return supplierName;
				}
				set	
				{
					supplierName = value;
				}
			}

			public List<DescribeLicense_LicenseAttribute> ExtendArray
			{
				get
				{
					return extendArray;
				}
				set	
				{
					extendArray = value;
				}
			}

			public DescribeLicense_ExtendInfo ExtendInfo
			{
				get
				{
					return extendInfo;
				}
				set	
				{
					extendInfo = value;
				}
			}

			public class DescribeLicense_LicenseAttribute
			{

				private string code;

				private string _value;

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

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class DescribeLicense_ExtendInfo
			{

				private long? aliUid;

				private string email;

				private string mobile;

				private long? accountQuantity;

				public long? AliUid
				{
					get
					{
						return aliUid;
					}
					set	
					{
						aliUid = value;
					}
				}

				public string Email
				{
					get
					{
						return email;
					}
					set	
					{
						email = value;
					}
				}

				public string Mobile
				{
					get
					{
						return mobile;
					}
					set	
					{
						mobile = value;
					}
				}

				public long? AccountQuantity
				{
					get
					{
						return accountQuantity;
					}
					set	
					{
						accountQuantity = value;
					}
				}
			}
		}
	}
}
