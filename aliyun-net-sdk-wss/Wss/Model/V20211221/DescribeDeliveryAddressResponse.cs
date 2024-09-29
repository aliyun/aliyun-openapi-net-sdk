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

namespace Aliyun.Acs.wss.Model.V20211221
{
	public class DescribeDeliveryAddressResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private List<DescribeDeliveryAddress_Address> addresses;

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

		public List<DescribeDeliveryAddress_Address> Addresses
		{
			get
			{
				return addresses;
			}
			set	
			{
				addresses = value;
			}
		}

		public class DescribeDeliveryAddress_Address
		{

			private string postalCode;

			private string contacts;

			private string mobile;

			private bool? defaultAddress;

			private string detail;

			private DescribeDeliveryAddress_Province province;

			private DescribeDeliveryAddress_City city;

			private DescribeDeliveryAddress_Area area;

			private DescribeDeliveryAddress_Town town;

			public string PostalCode
			{
				get
				{
					return postalCode;
				}
				set	
				{
					postalCode = value;
				}
			}

			public string Contacts
			{
				get
				{
					return contacts;
				}
				set	
				{
					contacts = value;
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

			public bool? DefaultAddress
			{
				get
				{
					return defaultAddress;
				}
				set	
				{
					defaultAddress = value;
				}
			}

			public string Detail
			{
				get
				{
					return detail;
				}
				set	
				{
					detail = value;
				}
			}

			public DescribeDeliveryAddress_Province Province
			{
				get
				{
					return province;
				}
				set	
				{
					province = value;
				}
			}

			public DescribeDeliveryAddress_City City
			{
				get
				{
					return city;
				}
				set	
				{
					city = value;
				}
			}

			public DescribeDeliveryAddress_Area Area
			{
				get
				{
					return area;
				}
				set	
				{
					area = value;
				}
			}

			public DescribeDeliveryAddress_Town Town
			{
				get
				{
					return town;
				}
				set	
				{
					town = value;
				}
			}

			public class DescribeDeliveryAddress_Province
			{

				private long? provinceId;

				private string provinceName;

				public long? ProvinceId
				{
					get
					{
						return provinceId;
					}
					set	
					{
						provinceId = value;
					}
				}

				public string ProvinceName
				{
					get
					{
						return provinceName;
					}
					set	
					{
						provinceName = value;
					}
				}
			}

			public class DescribeDeliveryAddress_City
			{

				private long? cityId;

				private string cityName;

				public long? CityId
				{
					get
					{
						return cityId;
					}
					set	
					{
						cityId = value;
					}
				}

				public string CityName
				{
					get
					{
						return cityName;
					}
					set	
					{
						cityName = value;
					}
				}
			}

			public class DescribeDeliveryAddress_Area
			{

				private string areaName;

				private long? areaId;

				public string AreaName
				{
					get
					{
						return areaName;
					}
					set	
					{
						areaName = value;
					}
				}

				public long? AreaId
				{
					get
					{
						return areaId;
					}
					set	
					{
						areaId = value;
					}
				}
			}

			public class DescribeDeliveryAddress_Town
			{

				private string townName;

				private long? townId;

				public string TownName
				{
					get
					{
						return townName;
					}
					set	
					{
						townName = value;
					}
				}

				public long? TownId
				{
					get
					{
						return townId;
					}
					set	
					{
						townId = value;
					}
				}
			}
		}
	}
}
