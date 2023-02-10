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
	public class QuerySplitItemBillResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QuerySplitItemBill_Data data;

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
		public QuerySplitItemBill_Data Data
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

		public class QuerySplitItemBill_Data
		{

			private int? pageNum;

			private string billingCycle;

			private string accountID;

			private int? pageSize;

			private int? totalCount;

			private string accountName;

			private List<QuerySplitItemBill_Item> items;

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

			[JsonProperty(PropertyName = "AccountID")]
			public string AccountID
			{
				get
				{
					return accountID;
				}
				set	
				{
					accountID = value;
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

			[JsonProperty(PropertyName = "AccountName")]
			public string AccountName
			{
				get
				{
					return accountName;
				}
				set	
				{
					accountName = value;
				}
			}

			[JsonProperty(PropertyName = "Items")]
			public List<QuerySplitItemBill_Item> Items
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

			public class QuerySplitItemBill_Item
			{

				private string splitAccountID;

				private string subscriptionType;

				private string instanceSpec;

				private float? deductedByCoupons;

				private string region;

				private float? outstandingAmount;

				private string pipCode;

				private string commodityCode;

				private string nickName;

				private string productDetail;

				private string usage;

				private string intranetIP;

				private string usageUnit;

				private string splitCommodityCode;

				private string productType;

				private string deductedByResourcePackage;

				private float? paymentAmount;

				private string splitBillingCycle;

				private string servicePeriod;

				private string splitItemName;

				private string listPrice;

				private string zone;

				private float? pretaxGrossAmount;

				private float? cashAmount;

				private string instanceConfig;

				private string billingDate;

				private string internetIP;

				private string item;

				private string splitItemID;

				private string instanceID;

				private string tag;

				private string currency;

				private float? deductedByCashCoupons;

				private string billingItem;

				private string costUnit;

				private string listPriceUnit;

				private string resourceGroup;

				private float? pretaxAmount;

				private string servicePeriodUnit;

				private string productName;

				private string splitProductDetail;

				private float? adjustAmount;

				private string ownerID;

				private float? deductedByPrepaidCard;

				private float? invoiceDiscount;

				private string splitAccountName;

				private string billingType;

				private string productCode;

				[JsonProperty(PropertyName = "SplitAccountID")]
				public string SplitAccountID
				{
					get
					{
						return splitAccountID;
					}
					set	
					{
						splitAccountID = value;
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

				[JsonProperty(PropertyName = "InstanceSpec")]
				public string InstanceSpec
				{
					get
					{
						return instanceSpec;
					}
					set	
					{
						instanceSpec = value;
					}
				}

				[JsonProperty(PropertyName = "DeductedByCoupons")]
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

				[JsonProperty(PropertyName = "OutstandingAmount")]
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

				[JsonProperty(PropertyName = "PipCode")]
				public string PipCode
				{
					get
					{
						return pipCode;
					}
					set	
					{
						pipCode = value;
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

				[JsonProperty(PropertyName = "NickName")]
				public string NickName
				{
					get
					{
						return nickName;
					}
					set	
					{
						nickName = value;
					}
				}

				[JsonProperty(PropertyName = "ProductDetail")]
				public string ProductDetail
				{
					get
					{
						return productDetail;
					}
					set	
					{
						productDetail = value;
					}
				}

				[JsonProperty(PropertyName = "Usage")]
				public string Usage
				{
					get
					{
						return usage;
					}
					set	
					{
						usage = value;
					}
				}

				[JsonProperty(PropertyName = "IntranetIP")]
				public string IntranetIP
				{
					get
					{
						return intranetIP;
					}
					set	
					{
						intranetIP = value;
					}
				}

				[JsonProperty(PropertyName = "UsageUnit")]
				public string UsageUnit
				{
					get
					{
						return usageUnit;
					}
					set	
					{
						usageUnit = value;
					}
				}

				[JsonProperty(PropertyName = "SplitCommodityCode")]
				public string SplitCommodityCode
				{
					get
					{
						return splitCommodityCode;
					}
					set	
					{
						splitCommodityCode = value;
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

				[JsonProperty(PropertyName = "DeductedByResourcePackage")]
				public string DeductedByResourcePackage
				{
					get
					{
						return deductedByResourcePackage;
					}
					set	
					{
						deductedByResourcePackage = value;
					}
				}

				[JsonProperty(PropertyName = "PaymentAmount")]
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

				[JsonProperty(PropertyName = "SplitBillingCycle")]
				public string SplitBillingCycle
				{
					get
					{
						return splitBillingCycle;
					}
					set	
					{
						splitBillingCycle = value;
					}
				}

				[JsonProperty(PropertyName = "ServicePeriod")]
				public string ServicePeriod
				{
					get
					{
						return servicePeriod;
					}
					set	
					{
						servicePeriod = value;
					}
				}

				[JsonProperty(PropertyName = "SplitItemName")]
				public string SplitItemName
				{
					get
					{
						return splitItemName;
					}
					set	
					{
						splitItemName = value;
					}
				}

				[JsonProperty(PropertyName = "ListPrice")]
				public string ListPrice
				{
					get
					{
						return listPrice;
					}
					set	
					{
						listPrice = value;
					}
				}

				[JsonProperty(PropertyName = "Zone")]
				public string Zone
				{
					get
					{
						return zone;
					}
					set	
					{
						zone = value;
					}
				}

				[JsonProperty(PropertyName = "PretaxGrossAmount")]
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

				[JsonProperty(PropertyName = "CashAmount")]
				public float? CashAmount
				{
					get
					{
						return cashAmount;
					}
					set	
					{
						cashAmount = value;
					}
				}

				[JsonProperty(PropertyName = "InstanceConfig")]
				public string InstanceConfig
				{
					get
					{
						return instanceConfig;
					}
					set	
					{
						instanceConfig = value;
					}
				}

				[JsonProperty(PropertyName = "BillingDate")]
				public string BillingDate
				{
					get
					{
						return billingDate;
					}
					set	
					{
						billingDate = value;
					}
				}

				[JsonProperty(PropertyName = "InternetIP")]
				public string InternetIP
				{
					get
					{
						return internetIP;
					}
					set	
					{
						internetIP = value;
					}
				}

				[JsonProperty(PropertyName = "Item")]
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

				[JsonProperty(PropertyName = "SplitItemID")]
				public string SplitItemID
				{
					get
					{
						return splitItemID;
					}
					set	
					{
						splitItemID = value;
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

				[JsonProperty(PropertyName = "DeductedByCashCoupons")]
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

				[JsonProperty(PropertyName = "BillingItem")]
				public string BillingItem
				{
					get
					{
						return billingItem;
					}
					set	
					{
						billingItem = value;
					}
				}

				[JsonProperty(PropertyName = "CostUnit")]
				public string CostUnit
				{
					get
					{
						return costUnit;
					}
					set	
					{
						costUnit = value;
					}
				}

				[JsonProperty(PropertyName = "ListPriceUnit")]
				public string ListPriceUnit
				{
					get
					{
						return listPriceUnit;
					}
					set	
					{
						listPriceUnit = value;
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

				[JsonProperty(PropertyName = "PretaxAmount")]
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

				[JsonProperty(PropertyName = "ServicePeriodUnit")]
				public string ServicePeriodUnit
				{
					get
					{
						return servicePeriodUnit;
					}
					set	
					{
						servicePeriodUnit = value;
					}
				}

				[JsonProperty(PropertyName = "ProductName")]
				public string ProductName
				{
					get
					{
						return productName;
					}
					set	
					{
						productName = value;
					}
				}

				[JsonProperty(PropertyName = "SplitProductDetail")]
				public string SplitProductDetail
				{
					get
					{
						return splitProductDetail;
					}
					set	
					{
						splitProductDetail = value;
					}
				}

				[JsonProperty(PropertyName = "AdjustAmount")]
				public float? AdjustAmount
				{
					get
					{
						return adjustAmount;
					}
					set	
					{
						adjustAmount = value;
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

				[JsonProperty(PropertyName = "InvoiceDiscount")]
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

				[JsonProperty(PropertyName = "SplitAccountName")]
				public string SplitAccountName
				{
					get
					{
						return splitAccountName;
					}
					set	
					{
						splitAccountName = value;
					}
				}

				[JsonProperty(PropertyName = "BillingType")]
				public string BillingType
				{
					get
					{
						return billingType;
					}
					set	
					{
						billingType = value;
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
