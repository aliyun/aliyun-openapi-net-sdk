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

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class QueryContactInfoResponse : AcsResponse
	{

		private string requestId;

		private string createDate;

		private string registrantName;

		private string registrantOrganization;

		private string country;

		private string province;

		private string city;

		private string address;

		private string email;

		private string postalCode;

		private string telArea;

		private string telephone;

		private string telExt;

		private string zhRegistrantName;

		private string zhRegistrantOrganization;

		private string zhProvince;

		private string zhCity;

		private string zhAddress;

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

		public string CreateDate
		{
			get
			{
				return createDate;
			}
			set	
			{
				createDate = value;
			}
		}

		public string RegistrantName
		{
			get
			{
				return registrantName;
			}
			set	
			{
				registrantName = value;
			}
		}

		public string RegistrantOrganization
		{
			get
			{
				return registrantOrganization;
			}
			set	
			{
				registrantOrganization = value;
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

		public string TelArea
		{
			get
			{
				return telArea;
			}
			set	
			{
				telArea = value;
			}
		}

		public string Telephone
		{
			get
			{
				return telephone;
			}
			set	
			{
				telephone = value;
			}
		}

		public string TelExt
		{
			get
			{
				return telExt;
			}
			set	
			{
				telExt = value;
			}
		}

		public string ZhRegistrantName
		{
			get
			{
				return zhRegistrantName;
			}
			set	
			{
				zhRegistrantName = value;
			}
		}

		public string ZhRegistrantOrganization
		{
			get
			{
				return zhRegistrantOrganization;
			}
			set	
			{
				zhRegistrantOrganization = value;
			}
		}

		public string ZhProvince
		{
			get
			{
				return zhProvince;
			}
			set	
			{
				zhProvince = value;
			}
		}

		public string ZhCity
		{
			get
			{
				return zhCity;
			}
			set	
			{
				zhCity = value;
			}
		}

		public string ZhAddress
		{
			get
			{
				return zhAddress;
			}
			set	
			{
				zhAddress = value;
			}
		}
	}
}