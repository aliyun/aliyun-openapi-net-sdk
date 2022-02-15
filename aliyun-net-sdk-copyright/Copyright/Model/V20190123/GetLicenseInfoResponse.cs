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

namespace Aliyun.Acs.Copyright.Model.V20190123
{
	public class GetLicenseInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private GetLicenseInfo_Data data;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public GetLicenseInfo_Data Data
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

		public class GetLicenseInfo_Data
		{

			private string companyName;

			private string cardNum;

			private string address;

			private string enterpriseTime;

			private string name;

			private string effectivePeriod;

			private string province;

			private string city;

			public string CompanyName
			{
				get
				{
					return companyName;
				}
				set	
				{
					companyName = value;
				}
			}

			public string CardNum
			{
				get
				{
					return cardNum;
				}
				set	
				{
					cardNum = value;
				}
			}

			public string Address
			{
				get
				{
					return address;
				}
				set	
				{
					address = value;
				}
			}

			public string EnterpriseTime
			{
				get
				{
					return enterpriseTime;
				}
				set	
				{
					enterpriseTime = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string EffectivePeriod
			{
				get
				{
					return effectivePeriod;
				}
				set	
				{
					effectivePeriod = value;
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
		}
	}
}
