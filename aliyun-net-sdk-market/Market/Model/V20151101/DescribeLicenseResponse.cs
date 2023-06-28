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

namespace Aliyun.Acs.Market.Model.V20151101
{
	public class DescribeLicenseResponse : AcsResponse
	{

		private string requestId;

		private DescribeLicense_License license;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "License")]
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

			private string activateTime;

			private string licenseStatus;

			private string productName;

			private string expiredTime;

			private string productSkuId;

			private string createTime;

			private string licenseCode;

			private string instanceId;

			private string supplierName;

			private string productCode;

			private List<DescribeLicense_LicenseAttribute> extendArray;

			private DescribeLicense_ExtendInfo extendInfo;

			[JsonProperty(PropertyName = "ActivateTime")]
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

			[JsonProperty(PropertyName = "LicenseStatus")]
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

			[JsonProperty(PropertyName = "ProductName")]
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

			[JsonProperty(PropertyName = "ExpiredTime")]
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

			[JsonProperty(PropertyName = "ProductSkuId")]
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

			[JsonProperty(PropertyName = "CreateTime")]
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

			[JsonProperty(PropertyName = "LicenseCode")]
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

			[JsonProperty(PropertyName = "InstanceId")]
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

			[JsonProperty(PropertyName = "SupplierName")]
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

			[JsonProperty(PropertyName = "ProductCode")]
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

			[JsonProperty(PropertyName = "ExtendArray")]
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

			[JsonProperty(PropertyName = "ExtendInfo")]
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

				[JsonProperty(PropertyName = "Code")]
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

				[JsonProperty(PropertyName = "_Value")]
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

				private long? accountQuantity;

				private string email;

				private string mobile;

				[JsonProperty(PropertyName = "AliUid")]
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

				[JsonProperty(PropertyName = "AccountQuantity")]
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

				[JsonProperty(PropertyName = "Email")]
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

				[JsonProperty(PropertyName = "Mobile")]
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
			}
		}
	}
}
