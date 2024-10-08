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

namespace Aliyun.Acs.ResourceCenter.Model.V20221201
{
	public class GetMultiAccountResourceConfigurationResponse : AcsResponse
	{

		private string accountId;

		private string configuration;

		private string createTime;

		private string expireTime;

		private string regionId;

		private string requestId;

		private string resourceGroupId;

		private string resourceId;

		private string resourceName;

		private string resourceType;

		private string zoneId;

		private List<GetMultiAccountResourceConfiguration_IpAddressAttribute> ipAddressAttributes;

		private List<GetMultiAccountResourceConfiguration_Tag> tags;

		private List<string> ipAddresses;

		public string AccountId
		{
			get
			{
				return accountId;
			}
			set	
			{
				accountId = value;
			}
		}

		public string Configuration
		{
			get
			{
				return configuration;
			}
			set	
			{
				configuration = value;
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

		public string ExpireTime
		{
			get
			{
				return expireTime;
			}
			set	
			{
				expireTime = value;
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

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
			}
		}

		public string ResourceId
		{
			get
			{
				return resourceId;
			}
			set	
			{
				resourceId = value;
			}
		}

		public string ResourceName
		{
			get
			{
				return resourceName;
			}
			set	
			{
				resourceName = value;
			}
		}

		public string ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
			}
		}

		public string ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
			}
		}

		public List<GetMultiAccountResourceConfiguration_IpAddressAttribute> IpAddressAttributes
		{
			get
			{
				return ipAddressAttributes;
			}
			set	
			{
				ipAddressAttributes = value;
			}
		}

		public List<GetMultiAccountResourceConfiguration_Tag> Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
			}
		}

		public List<string> IpAddresses
		{
			get
			{
				return ipAddresses;
			}
			set	
			{
				ipAddresses = value;
			}
		}

		public class GetMultiAccountResourceConfiguration_IpAddressAttribute
		{

			private string ipAddress;

			private string networkType;

			private string version;

			public string IpAddress
			{
				get
				{
					return ipAddress;
				}
				set	
				{
					ipAddress = value;
				}
			}

			public string NetworkType
			{
				get
				{
					return networkType;
				}
				set	
				{
					networkType = value;
				}
			}

			public string Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}
		}

		public class GetMultiAccountResourceConfiguration_Tag
		{

			private string key;

			private string _value;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
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
	}
}
