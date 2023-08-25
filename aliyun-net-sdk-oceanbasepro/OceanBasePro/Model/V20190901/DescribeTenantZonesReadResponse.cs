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

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
	public class DescribeTenantZonesReadResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeTenantZonesRead_TenantZonesItem> tenantZones;

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

		[JsonProperty(PropertyName = "TenantZones")]
		public List<DescribeTenantZonesRead_TenantZonesItem> TenantZones
		{
			get
			{
				return tenantZones;
			}
			set	
			{
				tenantZones = value;
			}
		}

		public class DescribeTenantZonesRead_TenantZonesItem
		{

			private bool? isElectable;

			private bool? isPrimary;

			private string zone;

			private string isReadable;

			[JsonProperty(PropertyName = "IsElectable")]
			public bool? IsElectable
			{
				get
				{
					return isElectable;
				}
				set	
				{
					isElectable = value;
				}
			}

			[JsonProperty(PropertyName = "IsPrimary")]
			public bool? IsPrimary
			{
				get
				{
					return isPrimary;
				}
				set	
				{
					isPrimary = value;
				}
			}

			[JsonProperty(PropertyName = "Zone")]
			public string Zone
			{
				get
				{
					return zone;
				}
				set	
				{
					zone = value;
				}
			}

			[JsonProperty(PropertyName = "IsReadable")]
			public string IsReadable
			{
				get
				{
					return isReadable;
				}
				set	
				{
					isReadable = value;
				}
			}
		}
	}
}
