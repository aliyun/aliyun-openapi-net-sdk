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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QueryCustomerAddressListResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryCustomerAddressList_Data data;

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

		public QueryCustomerAddressList_Data Data
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

		public class QueryCustomerAddressList_Data
		{

			private List<QueryCustomerAddressList_CustomerInvoiceAddress> customerInvoiceAddressList;

			public List<QueryCustomerAddressList_CustomerInvoiceAddress> CustomerInvoiceAddressList
			{
				get
				{
					return customerInvoiceAddressList;
				}
				set	
				{
					customerInvoiceAddressList = value;
				}
			}

			public class QueryCustomerAddressList_CustomerInvoiceAddress
			{

				private string addressee;

				private string postalCode;

				private long? userId;

				private string city;

				private string userNick;

				private string street;

				private string phone;

				private string county;

				private string bizType;

				private string deliveryAddress;

				private long? id;

				private string province;

				public string Addressee
				{
					get
					{
						return addressee;
					}
					set	
					{
						addressee = value;
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

				public long? UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
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

				public string UserNick
				{
					get
					{
						return userNick;
					}
					set	
					{
						userNick = value;
					}
				}

				public string Street
				{
					get
					{
						return street;
					}
					set	
					{
						street = value;
					}
				}

				public string Phone
				{
					get
					{
						return phone;
					}
					set	
					{
						phone = value;
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

				public string BizType
				{
					get
					{
						return bizType;
					}
					set	
					{
						bizType = value;
					}
				}

				public string DeliveryAddress
				{
					get
					{
						return deliveryAddress;
					}
					set	
					{
						deliveryAddress = value;
					}
				}

				public long? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
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
			}
		}
	}
}
