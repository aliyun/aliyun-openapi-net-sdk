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

namespace Aliyun.Acs.linkedmall.Model.V20180116
{
	public class QueryAddressListResponse : AcsResponse
	{

		private string code;

		private string requestId;

		private string message;

		private List<QueryAddressList_Address> addressList;

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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public List<QueryAddressList_Address> AddressList
		{
			get
			{
				return addressList;
			}
			set	
			{
				addressList = value;
			}
		}

		public class QueryAddressList_Address
		{

			private long? addressId;

			private string fullName;

			private string mobile;

			private string country;

			private string province;

			private string city;

			private string town;

			private string townDivisionCode;

			private string addressDetail;

			private string postCode;

			private int? status;

			private string divisionCode;

			private string area;

			public long? AddressId
			{
				get
				{
					return addressId;
				}
				set	
				{
					addressId = value;
				}
			}

			public string FullName
			{
				get
				{
					return fullName;
				}
				set	
				{
					fullName = value;
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

			public string Town
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

			public string TownDivisionCode
			{
				get
				{
					return townDivisionCode;
				}
				set	
				{
					townDivisionCode = value;
				}
			}

			public string AddressDetail
			{
				get
				{
					return addressDetail;
				}
				set	
				{
					addressDetail = value;
				}
			}

			public string PostCode
			{
				get
				{
					return postCode;
				}
				set	
				{
					postCode = value;
				}
			}

			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string DivisionCode
			{
				get
				{
					return divisionCode;
				}
				set	
				{
					divisionCode = value;
				}
			}

			public string Area
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
		}
	}
}
