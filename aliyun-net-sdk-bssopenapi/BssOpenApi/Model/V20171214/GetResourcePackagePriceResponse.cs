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
	public class GetResourcePackagePriceResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private GetResourcePackagePrice_Data data;

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
		public GetResourcePackagePrice_Data Data
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

		public class GetResourcePackagePrice_Data
		{

			private float? originalPrice;

			private float? discountPrice;

			private string currency;

			private float? tradePrice;

			private List<GetResourcePackagePrice_Promotion> promotions;

			[JsonProperty(PropertyName = "OriginalPrice")]
			public float? OriginalPrice
			{
				get
				{
					return originalPrice;
				}
				set	
				{
					originalPrice = value;
				}
			}

			[JsonProperty(PropertyName = "DiscountPrice")]
			public float? DiscountPrice
			{
				get
				{
					return discountPrice;
				}
				set	
				{
					discountPrice = value;
				}
			}

			[JsonProperty(PropertyName = "Currency")]
			public string Currency
			{
				get
				{
					return currency;
				}
				set	
				{
					currency = value;
				}
			}

			[JsonProperty(PropertyName = "TradePrice")]
			public float? TradePrice
			{
				get
				{
					return tradePrice;
				}
				set	
				{
					tradePrice = value;
				}
			}

			[JsonProperty(PropertyName = "Promotions")]
			public List<GetResourcePackagePrice_Promotion> Promotions
			{
				get
				{
					return promotions;
				}
				set	
				{
					promotions = value;
				}
			}

			public class GetResourcePackagePrice_Promotion
			{

				private string name;

				private long? id;

				[JsonProperty(PropertyName = "Name")]
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
			}
		}
	}
}
