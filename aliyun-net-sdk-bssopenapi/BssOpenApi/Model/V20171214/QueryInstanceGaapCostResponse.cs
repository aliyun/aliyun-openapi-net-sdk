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
	public class QueryInstanceGaapCostResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryInstanceGaapCost_Data data;

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

			private int? pageNum;

			private int? pageSize;

			private int? totalCount;

			private string hostId;

			private List<QueryInstanceGaapCost_Module> modules;

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

			[JsonProperty(PropertyName = "HostId")]
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

			[JsonProperty(PropertyName = "Modules")]
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

				private string gaapDeductedByCashCoupons;

				private string subscriptionType;

				private string monthGaapPretaxAmount;

				private string deductedByCoupons;

				private string subOrderId;

				private string region;

				private string orderType;

				private string monthGaapDeductedByPrepaidCard;

				private string unallocatedDeductedByCashCoupons;

				private string pretaxAmountLocal;

				private string billingCycle;

				private string payerAccount;

				private string monthGaapPretaxAmountLocal;

				private string accountingUnit;

				private string gaapPretaxAmountLocal;

				private string unallocatedDeductedByPrepaidCard;

				private string productType;

				private string paymentAmount;

				private string monthGaapPretaxGrossAmount;

				private string billType;

				private string payTime;

				private string pretaxGrossAmount;

				private string orderId;

				private string unallocatedPricingDiscount;

				private string monthGaapDeductedByCashCoupons;

				private string unallocatedPretaxGrossAmount;

				private string instanceID;

				private string tag;

				private string currency;

				private string gaapDeductedByCoupons;

				private string deductedByCashCoupons;

				private string gaapDeductedByPrepaidCard;

				private string gaapPaymentAmount;

				private string unallocatedPretaxAmountLocal;

				private string monthGaapPricingDiscount;

				private string pricingDiscount;

				private string gaapPricingDiscount;

				private string resourceGroup;

				private string unallocatedDeductedByCoupons;

				private string pretaxAmount;

				private string unallocatedPretaxAmount;

				private string gaapPretaxGrossAmount;

				private string unallocatedPaymentAmount;

				private string paymentCurrency;

				private string ownerID;

				private string deductedByPrepaidCard;

				private string gaapPretaxAmount;

				private string monthGaapDeductedByCoupons;

				private string monthGaapPaymentAmount;

				private string usageEndDate;

				private string usageStartDate;

				private string productCode;

				[JsonProperty(PropertyName = "GaapDeductedByCashCoupons")]
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

				[JsonProperty(PropertyName = "MonthGaapPretaxAmount")]
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

				[JsonProperty(PropertyName = "DeductedByCoupons")]
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

				[JsonProperty(PropertyName = "SubOrderId")]
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

				[JsonProperty(PropertyName = "Region")]
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

				[JsonProperty(PropertyName = "MonthGaapDeductedByPrepaidCard")]
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

				[JsonProperty(PropertyName = "UnallocatedDeductedByCashCoupons")]
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

				[JsonProperty(PropertyName = "BillingCycle")]
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

				[JsonProperty(PropertyName = "PayerAccount")]
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

				[JsonProperty(PropertyName = "MonthGaapPretaxAmountLocal")]
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

				[JsonProperty(PropertyName = "AccountingUnit")]
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

				[JsonProperty(PropertyName = "GaapPretaxAmountLocal")]
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

				[JsonProperty(PropertyName = "UnallocatedDeductedByPrepaidCard")]
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

				[JsonProperty(PropertyName = "PaymentAmount")]
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

				[JsonProperty(PropertyName = "MonthGaapPretaxGrossAmount")]
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

				[JsonProperty(PropertyName = "BillType")]
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

				[JsonProperty(PropertyName = "PayTime")]
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

				[JsonProperty(PropertyName = "UnallocatedPricingDiscount")]
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

				[JsonProperty(PropertyName = "MonthGaapDeductedByCashCoupons")]
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

				[JsonProperty(PropertyName = "UnallocatedPretaxGrossAmount")]
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

				[JsonProperty(PropertyName = "InstanceID")]
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

				[JsonProperty(PropertyName = "Tag")]
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

				[JsonProperty(PropertyName = "GaapDeductedByCoupons")]
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

				[JsonProperty(PropertyName = "DeductedByCashCoupons")]
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

				[JsonProperty(PropertyName = "GaapDeductedByPrepaidCard")]
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

				[JsonProperty(PropertyName = "GaapPaymentAmount")]
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

				[JsonProperty(PropertyName = "UnallocatedPretaxAmountLocal")]
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

				[JsonProperty(PropertyName = "MonthGaapPricingDiscount")]
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

				[JsonProperty(PropertyName = "PricingDiscount")]
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

				[JsonProperty(PropertyName = "GaapPricingDiscount")]
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

				[JsonProperty(PropertyName = "ResourceGroup")]
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

				[JsonProperty(PropertyName = "UnallocatedDeductedByCoupons")]
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

				[JsonProperty(PropertyName = "UnallocatedPretaxAmount")]
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

				[JsonProperty(PropertyName = "GaapPretaxGrossAmount")]
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

				[JsonProperty(PropertyName = "UnallocatedPaymentAmount")]
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

				[JsonProperty(PropertyName = "OwnerID")]
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

				[JsonProperty(PropertyName = "DeductedByPrepaidCard")]
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

				[JsonProperty(PropertyName = "GaapPretaxAmount")]
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

				[JsonProperty(PropertyName = "MonthGaapDeductedByCoupons")]
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

				[JsonProperty(PropertyName = "MonthGaapPaymentAmount")]
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

				[JsonProperty(PropertyName = "UsageEndDate")]
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

				[JsonProperty(PropertyName = "UsageStartDate")]
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
