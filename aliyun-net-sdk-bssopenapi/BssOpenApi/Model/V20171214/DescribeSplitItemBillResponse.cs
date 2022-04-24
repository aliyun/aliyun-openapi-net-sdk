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
	public class DescribeSplitItemBillResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private DescribeSplitItemBill_Data data;

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

		public DescribeSplitItemBill_Data Data
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

		public class DescribeSplitItemBill_Data
		{

			private string nextToken;

			private string billingCycle;

			private int? maxResults;

			private string accountID;

			private int? totalCount;

			private string accountName;

			private List<DescribeSplitItemBill_Item> items;

			public string NextToken
			{
				get
				{
					return nextToken;
				}
				set	
				{
					nextToken = value;
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

			public int? MaxResults
			{
				get
				{
					return maxResults;
				}
				set	
				{
					maxResults = value;
				}
			}

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

			public List<DescribeSplitItemBill_Item> Items
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

			public class DescribeSplitItemBill_Item
			{

				private string splitAccountID;

				private string billAccountName;

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

				private string billAccountID;

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

				private string bizType;

				private string billingItem;

				private string billingItemCode;

				private string costUnit;

				private string listPriceUnit;

				private string resourceGroup;

				private float? pretaxAmount;

				private string servicePeriodUnit;

				private string splitBillingDate;

				private string productName;

				private string splitProductDetail;

				private float? adjustAmount;

				private string ownerID;

				private float? deductedByPrepaidCard;

				private float? invoiceDiscount;

				private string splitAccountName;

				private string billingType;

				private string productCode;

				private string itemName;

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

				public string BillAccountName
				{
					get
					{
						return billAccountName;
					}
					set	
					{
						billAccountName = value;
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

				public string BillAccountID
				{
					get
					{
						return billAccountID;
					}
					set	
					{
						billAccountID = value;
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

				public string BillingItemCode
				{
					get
					{
						return billingItemCode;
					}
					set	
					{
						billingItemCode = value;
					}
				}

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

				public string SplitBillingDate
				{
					get
					{
						return splitBillingDate;
					}
					set	
					{
						splitBillingDate = value;
					}
				}

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

				public string ItemName
				{
					get
					{
						return itemName;
					}
					set	
					{
						itemName = value;
					}
				}
			}
		}
	}
}
