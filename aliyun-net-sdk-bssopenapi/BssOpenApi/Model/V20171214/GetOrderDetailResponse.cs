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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class GetOrderDetailResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string code;

		private bool? success;

		private GetOrderDetail_Data data;

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

		public GetOrderDetail_Data Data
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

		public class GetOrderDetail_Data
		{

			private int? totalCount;

			private int? pageSize;

			private int? pageNum;

			private string hostName;

			private List<GetOrderDetail_Order> orderList;

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

			public List<GetOrderDetail_Order> OrderList
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

			public class GetOrderDetail_Order
			{

				private string _operator;

				private string afterTaxAmount;

				private string subOrderId;

				private string config;

				private string tax;

				private string paymentTime;

				private string paymentCurrency;

				private string usageEndTime;

				private string subscriptionType;

				private string pretaxGrossAmount;

				private string orderType;

				private string currency;

				private string usageStartTime;

				private string originalConfig;

				private string paymentStatus;

				private string productCode;

				private string createTime;

				private string productType;

				private string relatedOrderId;

				private string quantity;

				private string orderId;

				private string pretaxAmount;

				private string orderSubType;

				private string region;

				private string instanceIDs;

				private string pretaxAmountLocal;

				private string commodityCode;

				public string _Operator
				{
					get
					{
						return _operator;
					}
					set	
					{
						_operator = value;
					}
				}

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

				public string SubOrderId
				{
					get
					{
						return subOrderId;
					}
					set	
					{
						subOrderId = value;
					}
				}

				public string Config
				{
					get
					{
						return config;
					}
					set	
					{
						config = value;
					}
				}

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

				public string UsageEndTime
				{
					get
					{
						return usageEndTime;
					}
					set	
					{
						usageEndTime = value;
					}
				}

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

				public string UsageStartTime
				{
					get
					{
						return usageStartTime;
					}
					set	
					{
						usageStartTime = value;
					}
				}

				public string OriginalConfig
				{
					get
					{
						return originalConfig;
					}
					set	
					{
						originalConfig = value;
					}
				}

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

				public string Quantity
				{
					get
					{
						return quantity;
					}
					set	
					{
						quantity = value;
					}
				}

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

				public string OrderSubType
				{
					get
					{
						return orderSubType;
					}
					set	
					{
						orderSubType = value;
					}
				}

				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				public string InstanceIDs
				{
					get
					{
						return instanceIDs;
					}
					set	
					{
						instanceIDs = value;
					}
				}

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
			}
		}
	}
}
