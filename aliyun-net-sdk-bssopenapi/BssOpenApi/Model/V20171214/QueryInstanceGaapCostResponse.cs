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
	public class QueryInstanceGaapCostResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private QueryInstanceGaapCost_Data data;

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

		public QueryInstanceGaapCost_Data Data
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

		public class QueryInstanceGaapCost_Data
		{

			private string hostId;

			private int? pageNum;

			private int? pageSize;

			private int? totalCount;

			private List<QueryInstanceGaapCost_Module> modules;

			public string HostId
			{
				get
				{
					return hostId;
				}
				set	
				{
					hostId = value;
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

			public List<QueryInstanceGaapCost_Module> Modules
			{
				get
				{
					return modules;
				}
				set	
				{
					modules = value;
				}
			}

			public class QueryInstanceGaapCost_Module
			{

				private string billingCycle;

				private string instanceID;

				private string productCode;

				private string productType;

				private string subscriptionType;

				private string tag;

				private string resourceGroup;

				private string accountingUnit;

				private string payerAccount;

				private string ownerID;

				private string region;

				private string currency;

				private string paymentCurrency;

				private string orderType;

				private string payTime;

				private string pretaxGrossAmount;

				private string pricingDiscount;

				private string deductedByCoupons;

				private string pretaxAmount;

				private string pretaxAmountLocal;

				private string deductedByCashCoupons;

				private string deductedByPrepaidCard;

				private string paymentAmount;

				private string gaapPretaxGrossAmount;

				private string gaapPricingDiscount;

				private string gaapDeductedByCoupons;

				private string gaapPretaxAmount;

				private string gaapPretaxAmountLocal;

				private string gaapDeductedByCashCoupons;

				private string gaapDeductedByPrepaidCard;

				private string gaapPaymentAmount;

				private string monthGaapPretaxGrossAmount;

				private string monthGaapPricingDiscount;

				private string monthGaapDeductedByCoupons;

				private string monthGaapPretaxAmount;

				private string monthGaapPretaxAmountLocal;

				private string monthGaapDeductedByCashCoupons;

				private string monthGaapDeductedByPrepaidCard;

				private string monthGaapPaymentAmount;

				private string unallocatedPaymentAmount;

				private string usageStartDate;

				private string usageEndDate;

				private string billType;

				private string orderId;

				private string subOrderId;

				private string unallocatedPretaxGrossAmount;

				private string unallocatedPricingDiscount;

				private string unallocatedDeductedByCoupons;

				private string unallocatedPretaxAmount;

				private string unallocatedPretaxAmountLocal;

				private string unallocatedDeductedByCashCoupons;

				private string unallocatedDeductedByPrepaidCard;

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

				public string InstanceID
				{
					get
					{
						return instanceID;
					}
					set	
					{
						instanceID = value;
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

				public string Tag
				{
					get
					{
						return tag;
					}
					set	
					{
						tag = value;
					}
				}

				public string ResourceGroup
				{
					get
					{
						return resourceGroup;
					}
					set	
					{
						resourceGroup = value;
					}
				}

				public string AccountingUnit
				{
					get
					{
						return accountingUnit;
					}
					set	
					{
						accountingUnit = value;
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

				public string PayTime
				{
					get
					{
						return payTime;
					}
					set	
					{
						payTime = value;
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

				public string PricingDiscount
				{
					get
					{
						return pricingDiscount;
					}
					set	
					{
						pricingDiscount = value;
					}
				}

				public string DeductedByCoupons
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

				public string DeductedByCashCoupons
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

				public string DeductedByPrepaidCard
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

				public string PaymentAmount
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

				public string GaapPretaxGrossAmount
				{
					get
					{
						return gaapPretaxGrossAmount;
					}
					set	
					{
						gaapPretaxGrossAmount = value;
					}
				}

				public string GaapPricingDiscount
				{
					get
					{
						return gaapPricingDiscount;
					}
					set	
					{
						gaapPricingDiscount = value;
					}
				}

				public string GaapDeductedByCoupons
				{
					get
					{
						return gaapDeductedByCoupons;
					}
					set	
					{
						gaapDeductedByCoupons = value;
					}
				}

				public string GaapPretaxAmount
				{
					get
					{
						return gaapPretaxAmount;
					}
					set	
					{
						gaapPretaxAmount = value;
					}
				}

				public string GaapPretaxAmountLocal
				{
					get
					{
						return gaapPretaxAmountLocal;
					}
					set	
					{
						gaapPretaxAmountLocal = value;
					}
				}

				public string GaapDeductedByCashCoupons
				{
					get
					{
						return gaapDeductedByCashCoupons;
					}
					set	
					{
						gaapDeductedByCashCoupons = value;
					}
				}

				public string GaapDeductedByPrepaidCard
				{
					get
					{
						return gaapDeductedByPrepaidCard;
					}
					set	
					{
						gaapDeductedByPrepaidCard = value;
					}
				}

				public string GaapPaymentAmount
				{
					get
					{
						return gaapPaymentAmount;
					}
					set	
					{
						gaapPaymentAmount = value;
					}
				}

				public string MonthGaapPretaxGrossAmount
				{
					get
					{
						return monthGaapPretaxGrossAmount;
					}
					set	
					{
						monthGaapPretaxGrossAmount = value;
					}
				}

				public string MonthGaapPricingDiscount
				{
					get
					{
						return monthGaapPricingDiscount;
					}
					set	
					{
						monthGaapPricingDiscount = value;
					}
				}

				public string MonthGaapDeductedByCoupons
				{
					get
					{
						return monthGaapDeductedByCoupons;
					}
					set	
					{
						monthGaapDeductedByCoupons = value;
					}
				}

				public string MonthGaapPretaxAmount
				{
					get
					{
						return monthGaapPretaxAmount;
					}
					set	
					{
						monthGaapPretaxAmount = value;
					}
				}

				public string MonthGaapPretaxAmountLocal
				{
					get
					{
						return monthGaapPretaxAmountLocal;
					}
					set	
					{
						monthGaapPretaxAmountLocal = value;
					}
				}

				public string MonthGaapDeductedByCashCoupons
				{
					get
					{
						return monthGaapDeductedByCashCoupons;
					}
					set	
					{
						monthGaapDeductedByCashCoupons = value;
					}
				}

				public string MonthGaapDeductedByPrepaidCard
				{
					get
					{
						return monthGaapDeductedByPrepaidCard;
					}
					set	
					{
						monthGaapDeductedByPrepaidCard = value;
					}
				}

				public string MonthGaapPaymentAmount
				{
					get
					{
						return monthGaapPaymentAmount;
					}
					set	
					{
						monthGaapPaymentAmount = value;
					}
				}

				public string UnallocatedPaymentAmount
				{
					get
					{
						return unallocatedPaymentAmount;
					}
					set	
					{
						unallocatedPaymentAmount = value;
					}
				}

				public string UsageStartDate
				{
					get
					{
						return usageStartDate;
					}
					set	
					{
						usageStartDate = value;
					}
				}

				public string UsageEndDate
				{
					get
					{
						return usageEndDate;
					}
					set	
					{
						usageEndDate = value;
					}
				}

				public string BillType
				{
					get
					{
						return billType;
					}
					set	
					{
						billType = value;
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

				public string UnallocatedPretaxGrossAmount
				{
					get
					{
						return unallocatedPretaxGrossAmount;
					}
					set	
					{
						unallocatedPretaxGrossAmount = value;
					}
				}

				public string UnallocatedPricingDiscount
				{
					get
					{
						return unallocatedPricingDiscount;
					}
					set	
					{
						unallocatedPricingDiscount = value;
					}
				}

				public string UnallocatedDeductedByCoupons
				{
					get
					{
						return unallocatedDeductedByCoupons;
					}
					set	
					{
						unallocatedDeductedByCoupons = value;
					}
				}

				public string UnallocatedPretaxAmount
				{
					get
					{
						return unallocatedPretaxAmount;
					}
					set	
					{
						unallocatedPretaxAmount = value;
					}
				}

				public string UnallocatedPretaxAmountLocal
				{
					get
					{
						return unallocatedPretaxAmountLocal;
					}
					set	
					{
						unallocatedPretaxAmountLocal = value;
					}
				}

				public string UnallocatedDeductedByCashCoupons
				{
					get
					{
						return unallocatedDeductedByCashCoupons;
					}
					set	
					{
						unallocatedDeductedByCashCoupons = value;
					}
				}

				public string UnallocatedDeductedByPrepaidCard
				{
					get
					{
						return unallocatedDeductedByPrepaidCard;
					}
					set	
					{
						unallocatedDeductedByPrepaidCard = value;
					}
				}
			}
		}
	}
}
