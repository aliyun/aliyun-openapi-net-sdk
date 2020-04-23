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

namespace Aliyun.Acs.geoip.Model.V20200101
{
	public class DescribeIpv4LocationResponse : AcsResponse
	{

		private string requestId;

		private string ip;

		private string country;

		private string province;

		private string city;

		private string county;

		private string isp;

		private string countryCode;

		private string countryEn;

		private string provinceEn;

		private string cityEn;

		private string longitude;

		private string latitude;

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

		public string Ip
		{
			get
			{
				return ip;
			}
			set	
			{
				ip = value;
			}
		}

		public string Country
		{
			get
			{
				return country;
			}
			set	
			{
				country = value;
			}
		}

		public string Province
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

		public string City
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

		public string County
		{
			get
			{
				return county;
			}
			set	
			{
				county = value;
			}
		}

		public string Isp
		{
			get
			{
				return isp;
			}
			set	
			{
				isp = value;
			}
		}

		public string CountryCode
		{
			get
			{
				return countryCode;
			}
			set	
			{
				countryCode = value;
			}
		}

		public string CountryEn
		{
			get
			{
				return countryEn;
			}
			set	
			{
				countryEn = value;
			}
		}

		public string ProvinceEn
		{
			get
			{
				return provinceEn;
			}
			set	
			{
				provinceEn = value;
			}
		}

		public string CityEn
		{
			get
			{
				return cityEn;
			}
			set	
			{
				cityEn = value;
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
	}
}
