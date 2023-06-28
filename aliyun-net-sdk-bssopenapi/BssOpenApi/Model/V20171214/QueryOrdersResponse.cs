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
	public class QueryOrdersResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryOrders_Data data;

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
		public QueryOrders_Data Data
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

		public class QueryOrders_Data
		{

			private string hostName;

			private int? pageNum;

			private int? pageSize;

			private int? totalCount;

			private List<QueryOrders_Order> orderList;

			[JsonProperty(PropertyName = "HostName")]
			public string HostName
			{
				get
				{
					return hostName;
				}
				set	
				{
					hostName = value;
				}
			}

			[JsonProperty(PropertyName = "PageNum")]
			public int? PageNum
			{
				get
				{
					return pageNum;
				}
				set	
				{
					pageNum = value;
				}
			}

			[JsonProperty(PropertyName = "PageSize")]
			public int? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			[JsonProperty(PropertyName = "TotalCount")]
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

			[JsonProperty(PropertyName = "OrderList")]
			public List<QueryOrders_Order> OrderList
			{
				get
				{
					return orderList;
				}
				set	
				{
					orderList = value;
				}
			}

			public class QueryOrders_Order
			{

				private string pretaxAmount;

				private string commodityCode;

				private string relatedOrderId;

				private string createTime;

				private string currency;

				private string subscriptionType;

				private string paymentCurrency;

				private string productType;

				private string afterTaxAmount;

				private string paymentTime;

				private string pretaxGrossAmount;

				private string orderType;

				private string paymentStatus;

				private string orderId;

				private string tax;

				private string pretaxAmountLocal;

				private string productCode;

				[JsonProperty(PropertyName = "PretaxAmount")]
				public string PretaxAmount
				{
					get
					{
						return pretaxAmount;
					}
					set	
					{
						pretaxAmount = value;
					}
				}

				[JsonProperty(PropertyName = "CommodityCode")]
				public string CommodityCode
				{
					get
					{
						return commodityCode;
					}
					set	
					{
						commodityCode = value;
					}
				}

				[JsonProperty(PropertyName = "RelatedOrderId")]
				public string RelatedOrderId
				{
					get
					{
						return relatedOrderId;
					}
					set	
					{
						relatedOrderId = value;
					}
				}

				[JsonProperty(PropertyName = "CreateTime")]
				public string CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
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

				[JsonProperty(PropertyName = "SubscriptionType")]
				public string SubscriptionType
				{
					get
					{
						return subscriptionType;
					}
					set	
					{
						subscriptionType = value;
					}
				}

				[JsonProperty(PropertyName = "PaymentCurrency")]
				public string PaymentCurrency
				{
					get
					{
						return paymentCurrency;
					}
					set	
					{
						paymentCurrency = value;
					}
				}

				[JsonProperty(PropertyName = "ProductType")]
				public string ProductType
				{
					get
					{
						return productType;
					}
					set	
					{
						productType = value;
					}
				}

				[JsonProperty(PropertyName = "AfterTaxAmount")]
				public string AfterTaxAmount
				{
					get
					{
						return afterTaxAmount;
					}
					set	
					{
						afterTaxAmount = value;
					}
				}

				[JsonProperty(PropertyName = "PaymentTime")]
				public string PaymentTime
				{
					get
					{
						return paymentTime;
					}
					set	
					{
						paymentTime = value;
					}
				}

				[JsonProperty(PropertyName = "PretaxGrossAmount")]
				public string PretaxGrossAmount
				{
					get
					{
						return pretaxGrossAmount;
					}
					set	
					{
						pretaxGrossAmount = value;
					}
				}

				[JsonProperty(PropertyName = "OrderType")]
				public string OrderType
				{
					get
					{
						return orderType;
					}
					set	
					{
						orderType = value;
					}
				}

				[JsonProperty(PropertyName = "PaymentStatus")]
				public string PaymentStatus
				{
					get
					{
						return paymentStatus;
					}
					set	
					{
						paymentStatus = value;
					}
				}

				[JsonProperty(PropertyName = "OrderId")]
				public string OrderId
				{
					get
					{
						return orderId;
					}
					set	
					{
						orderId = value;
					}
				}

				[JsonProperty(PropertyName = "Tax")]
				public string Tax
				{
					get
					{
						return tax;
					}
					set	
					{
						tax = value;
					}
				}

				[JsonProperty(PropertyName = "PretaxAmountLocal")]
				public string PretaxAmountLocal
				{
					get
					{
						return pretaxAmountLocal;
					}
					set	
					{
						pretaxAmountLocal = value;
					}
				}

				[JsonProperty(PropertyName = "ProductCode")]
				public string ProductCode
				{
					get
					{
						return productCode;
					}
					set	
					{
						productCode = value;
					}
				}
			}
		}
	}
}
