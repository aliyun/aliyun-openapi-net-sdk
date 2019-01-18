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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.afs.Model.V20180112
{
	public class DescribeCaptchaIpCityResponse : AcsResponse
	{

		private string requestId;

		private string bizCode;

		private bool? hasData;

		private List<DescribeCaptchaIpCity_CaptchaCitie> captchaCities;

		private List<DescribeCaptchaIpCity_CaptchaIp> captchaIps;

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

		public string BizCode
		{
			get
			{
				return bizCode;
			}
			set	
			{
				bizCode = value;
			}
		}

		public bool? HasData
		{
			get
			{
				return hasData;
			}
			set	
			{
				hasData = value;
			}
		}

		public List<DescribeCaptchaIpCity_CaptchaCitie> CaptchaCities
		{
			get
			{
				return captchaCities;
			}
			set	
			{
				captchaCities = value;
			}
		}

		public List<DescribeCaptchaIpCity_CaptchaIp> CaptchaIps
		{
			get
			{
				return captchaIps;
			}
			set	
			{
				captchaIps = value;
			}
		}

		public class DescribeCaptchaIpCity_CaptchaCitie
		{

			private string location;

			private string lat;

			private string lng;

			private int? pv;

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public string Lat
			{
				get
				{
					return lat;
				}
				set	
				{
					lat = value;
				}
			}

			public string Lng
			{
				get
				{
					return lng;
				}
				set	
				{
					lng = value;
				}
			}

			public int? Pv
			{
				get
				{
					return pv;
				}
				set	
				{
					pv = value;
				}
			}
		}

		public class DescribeCaptchaIpCity_CaptchaIp
		{

			private string ip;

			private int? _value;

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

			public int? _Value
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