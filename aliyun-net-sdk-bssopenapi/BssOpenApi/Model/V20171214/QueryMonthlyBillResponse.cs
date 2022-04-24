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
	public class QueryMonthlyBillResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryMonthlyBill_Data data;

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

		public QueryMonthlyBill_Data Data
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

		public class QueryMonthlyBill_Data
		{

			private float? outstandingAmount;

			private string billingCycle;

			private float? totalOutstandingAmount;

			private float? newInvoiceAmount;

			private List<QueryMonthlyBill_Item> items;

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

			public float? TotalOutstandingAmount
			{
				get
				{
					return totalOutstandingAmount;
				}
				set	
				{
					totalOutstandingAmount = value;
				}
			}

			public float? NewInvoiceAmount
			{
				get
				{
					return newInvoiceAmount;
				}
				set	
				{
					newInvoiceAmount = value;
				}
			}

			public List<QueryMonthlyBill_Item> Items
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

			public class QueryMonthlyBill_Item
			{

				private float? pretaxAmount;

				private string solutionCode;

				private string item;

				private string currency;

				private float? deductedByCashCoupons;

				private string subscriptionType;

				private string paymentCurrency;

				private float? deductedByPrepaidCard;

				private float? deductedByCoupons;

				private float? paymentAmount;

				private float? invoiceDiscount;

				private string productType;

				private float? outstandingAmount;

				private float? afterTaxAmount;

				private float? pretaxGrossAmount;

				private string solutionName;

				private float? tax;

				private float? pretaxAmountLocal;

				private string productCode;

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

				public string SolutionCode
				{
					get
					{
						return solutionCode;
					}
					set	
					{
						solutionCode = value;
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

				public float? InvoiceDiscount
				{
					get
					{
						return invoiceDiscount;
					}
					set	
					{
						invoiceDiscount = value;
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
