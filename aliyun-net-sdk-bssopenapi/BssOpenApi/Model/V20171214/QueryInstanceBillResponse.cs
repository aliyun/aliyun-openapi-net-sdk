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
	public class QueryInstanceBillResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private QueryInstanceBill_Data data;

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

		public QueryInstanceBill_Data Data
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

		public class QueryInstanceBill_Data
		{

			private string billingCycle;

			private string accountID;

			private string accountName;

			private int? totalCount;

			private int? pageNum;

			private int? pageSize;

			private List<QueryInstanceBill_Item> items;

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

			public List<QueryInstanceBill_Item> Items
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

			public class QueryInstanceBill_Item
			{

				private string instanceID;

				private string billingType;

				private string costUnit;

				private string productCode;

				private string productType;

				private string subscriptionType;

				private string productName;

				private string productDetail;

				private string ownerID;

				private string billingItem;

				private string listPrice;

				private string listPriceUnit;

				private string usage;

				private string usageUnit;

				private string deductedByResourcePackage;

				private float? pretaxGrossAmount;

				private float? invoiceDiscount;

				private float? deductedByCoupons;

				private float? pretaxAmount;

				private float? deductedByCashCoupons;

				private float? deductedByPrepaidCard;

				private float? paymentAmount;

				private float? outstandingAmount;

				private string currency;

				private string nickName;

				private string resourceGroup;

				private string tag;

				private string instanceConfig;

				private string instanceSpec;

				private string internetIP;

				private string intranetIP;

				private string region;

				private string zone;

				private string item;

				private string servicePeriod;

				private string billingDate;

				private string servicePeriodUnit;

				private string pipCode;

				private string commodityCode;

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
			}
		}
	}
}
