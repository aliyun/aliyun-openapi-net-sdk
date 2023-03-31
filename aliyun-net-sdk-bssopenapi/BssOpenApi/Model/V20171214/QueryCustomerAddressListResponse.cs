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

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "Data")]
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

			[JsonProperty(PropertyName = "CustomerInvoiceAddressList")]
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

				[JsonProperty(PropertyName = "Addressee")]
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

				[JsonProperty(PropertyName = "PostalCode")]
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

				[JsonProperty(PropertyName = "UserId")]
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

				[JsonProperty(PropertyName = "City")]
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

				[JsonProperty(PropertyName = "UserNick")]
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

				[JsonProperty(PropertyName = "Street")]
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

				[JsonProperty(PropertyName = "Phone")]
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

				[JsonProperty(PropertyName = "County")]
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

				[JsonProperty(PropertyName = "BizType")]
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

				[JsonProperty(PropertyName = "DeliveryAddress")]
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

				[JsonProperty(PropertyName = "Id")]
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

				[JsonProperty(PropertyName = "Province")]
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
