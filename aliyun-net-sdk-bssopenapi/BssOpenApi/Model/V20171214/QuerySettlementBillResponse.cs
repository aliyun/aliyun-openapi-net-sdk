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
	public class QuerySettlementBillResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QuerySettlementBill_Data data;

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

		public QuerySettlementBill_Data Data
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

		public class QuerySettlementBill_Data
		{

			private int? pageNum;

			private string billingCycle;

			private int? pageSize;

			private int? totalCount;

			private List<QuerySettlementBill_Item> items;

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

			public string BillingCycle
			{
				get
				{
					return billingCycle;
				}
				set	
				{
					billingCycle = value;
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

			public List<QuerySettlementBill_Item> Items
			{
				get
				{
					return items;
				}
				set	
				{
					items = value;
				}
			}

			public class QuerySettlementBill_Item
			{

				private string status;

				private string invoiceNo;

				private string billID;

				private string createTime;

				private string item;

				private string seller;

				private string currency;

				private float? chargeDiscount;

				private float? deductedByCashCoupons;

				private string config;

				private string subscriptionType;

				private string usageStartTime;

				private string usageEndTime;

				private float? deductedByCoupons;

				private string region;

				private float? outstandingAmount;

				private float? afterTaxAmount;

				private string paymentTime;

				private string solutionID;

				private string orderType;

				private string clearedTime;

				private string quantity;

				private float? tax;

				private float? pretaxAmountLocal;

				private float? pretaxAmount;

				private string linkedCustomerOrderID;

				private float? accountDiscount;

				private string recordID;

				private string payerAccount;

				private string promotion;

				private string originalOrderID;

				private float? previousBillingCycleBalance;

				private float? mybankPaymentAmount;

				private string paymentCurrency;

				private string orderID;

				private string ownerID;

				private float? deductedByPrepaidCard;

				private float? paymentAmount;

				private string productType;

				private float? pretaxGrossAmount;

				private string suborderID;

				private string solutionName;

				private string productCode;

				public string Status
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

				public string InvoiceNo
				{
					get
					{
						return invoiceNo;
					}
					set	
					{
						invoiceNo = value;
					}
				}

				public string BillID
				{
					get
					{
						return billID;
					}
					set	
					{
						billID = value;
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

				public string Item
				{
					get
					{
						return item;
					}
					set	
					{
						item = value;
					}
				}

				public string Seller
				{
					get
					{
						return seller;
					}
					set	
					{
						seller = value;
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

				public float? ChargeDiscount
				{
					get
					{
						return chargeDiscount;
					}
					set	
					{
						chargeDiscount = value;
					}
				}

				public float? DeductedByCashCoupons
				{
					get
					{
						return deductedByCashCoupons;
					}
					set	
					{
						deductedByCashCoupons = value;
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

				public float? DeductedByCoupons
				{
					get
					{
						return deductedByCoupons;
					}
					set	
					{
						deductedByCoupons = value;
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

				public float? OutstandingAmount
				{
					get
					{
						return outstandingAmount;
					}
					set	
					{
						outstandingAmount = value;
					}
				}

				public float? AfterTaxAmount
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

				public string SolutionID
				{
					get
					{
						return solutionID;
					}
					set	
					{
						solutionID = value;
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

				public string ClearedTime
				{
					get
					{
						return clearedTime;
					}
					set	
					{
						clearedTime = value;
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

				public float? Tax
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

				public float? PretaxAmountLocal
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

				public float? PretaxAmount
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

				public string LinkedCustomerOrderID
				{
					get
					{
						return linkedCustomerOrderID;
					}
					set	
					{
						linkedCustomerOrderID = value;
					}
				}

				public float? AccountDiscount
				{
					get
					{
						return accountDiscount;
					}
					set	
					{
						accountDiscount = value;
					}
				}

				public string RecordID
				{
					get
					{
						return recordID;
					}
					set	
					{
						recordID = value;
					}
				}

				public string PayerAccount
				{
					get
					{
						return payerAccount;
					}
					set	
					{
						payerAccount = value;
					}
				}

				public string Promotion
				{
					get
					{
						return promotion;
					}
					set	
					{
						promotion = value;
					}
				}

				public string OriginalOrderID
				{
					get
					{
						return originalOrderID;
					}
					set	
					{
						originalOrderID = value;
					}
				}

				public float? PreviousBillingCycleBalance
				{
					get
					{
						return previousBillingCycleBalance;
					}
					set	
					{
						previousBillingCycleBalance = value;
					}
				}

				public float? MybankPaymentAmount
				{
					get
					{
						return mybankPaymentAmount;
					}
					set	
					{
						mybankPaymentAmount = value;
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

				public string OrderID
				{
					get
					{
						return orderID;
					}
					set	
					{
						orderID = value;
					}
				}

				public string OwnerID
				{
					get
					{
						return ownerID;
					}
					set	
					{
						ownerID = value;
					}
				}

				public float? DeductedByPrepaidCard
				{
					get
					{
						return deductedByPrepaidCard;
					}
					set	
					{
						deductedByPrepaidCard = value;
					}
				}

				public float? PaymentAmount
				{
					get
					{
						return paymentAmount;
					}
					set	
					{
						paymentAmount = value;
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

				public float? PretaxGrossAmount
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

				public string SuborderID
				{
					get
					{
						return suborderID;
					}
					set	
					{
						suborderID = value;
					}
				}

				public string SolutionName
				{
					get
					{
						return solutionName;
					}
					set	
					{
						solutionName = value;
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
			}
		}
	}
}
