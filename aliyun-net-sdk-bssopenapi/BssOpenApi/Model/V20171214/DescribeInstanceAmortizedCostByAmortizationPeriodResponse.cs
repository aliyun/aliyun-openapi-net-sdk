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
	public class DescribeInstanceAmortizedCostByAmortizationPeriodResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private DescribeInstanceAmortizedCostByAmortizationPeriod_Data data;

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

		[JsonProperty(PropertyName = "Data")]
		public DescribeInstanceAmortizedCostByAmortizationPeriod_Data Data
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

		public class DescribeInstanceAmortizedCostByAmortizationPeriod_Data
		{

			private string nextToken;

			private string accountID;

			private string accountName;

			private int? maxResults;

			private int? totalCount;

			private List<DescribeInstanceAmortizedCostByAmortizationPeriod_Item> items;

			[JsonProperty(PropertyName = "NextToken")]
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

			[JsonProperty(PropertyName = "MaxResults")]
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

			[JsonProperty(PropertyName = "Items")]
			public List<DescribeInstanceAmortizedCostByAmortizationPeriod_Item> Items
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

			public class DescribeInstanceAmortizedCostByAmortizationPeriod_Item
			{

				private string costUnit;

				private string costUnitCode;

				private string instanceID;

				private string resourceGroup;

				private string tag;

				private string internetIP;

				private string intranetIP;

				private string region;

				private string zone;

				private string splitAccountName;

				private string splitProductDetail;

				private string splitItemID;

				private string splitItemName;

				private string consumePeriod;

				private string amortizationStatus;

				private string amortizationPeriod;

				private long? billAccountID;

				private string billAccountName;

				private long? billOwnerID;

				private string billOwnerName;

				private string productCode;

				private string productName;

				private string productDetailCode;

				private string productDetail;

				private string bizType;

				private string subscriptionType;

				private double? pretaxGrossAmount;

				private double? invoiceDiscount;

				private double? roundDownDiscount;

				private double? pretaxAmount;

				private double? deductedByCashCoupons;

				private double? deductedByCoupons;

				private double? deductedByPrepaidCard;

				private double? expenditureAmount;

				private double? previouslyAmortizedPretaxGrossAmount;

				private double? previouslyAmortizedInvoiceDiscount;

				private double? previouslyAmortizedRoundDownDiscount;

				private double? previouslyAmortizedPretaxAmount;

				private double? previouslyAmortizedDeductedByCashCoupons;

				private double? previouslyAmortizedDeductedByCoupons;

				private double? previouslyAmortizedDeductedByPrepaidCard;

				private double? previouslyAmortizedExpenditureAmount;

				private double? currentAmortizationPretaxGrossAmount;

				private double? currentAmortizationInvoiceDiscount;

				private double? currentAmortizationRoundDownDiscount;

				private double? currentAmortizationPretaxAmount;

				private double? currentAmortizationDeductedByCashCoupons;

				private double? currentAmortizationDeductedByCoupons;

				private double? currentAmortizationDeductedByPrepaidCard;

				private double? currentAmortizationExpenditureAmount;

				private double? remainingAmortizationPretaxGrossAmount;

				private double? remainingAmortizationInvoiceDiscount;

				private double? remainingAmortizationRoundDownDiscount;

				private double? remainingAmortizationPretaxAmount;

				private double? remainingAmortizationDeductedByCashCoupons;

				private double? remainingAmortizationDeductedByCoupons;

				private double? remainingAmortizationDeductedByPrepaidCard;

				private double? remainingAmortizationExpenditureAmount;

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

				[JsonProperty(PropertyName = "CostUnitCode")]
				public string CostUnitCode
				{
					get
					{
						return costUnitCode;
					}
					set	
					{
						costUnitCode = value;
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

				[JsonProperty(PropertyName = "ConsumePeriod")]
				public string ConsumePeriod
				{
					get
					{
						return consumePeriod;
					}
					set	
					{
						consumePeriod = value;
					}
				}

				[JsonProperty(PropertyName = "AmortizationStatus")]
				public string AmortizationStatus
				{
					get
					{
						return amortizationStatus;
					}
					set	
					{
						amortizationStatus = value;
					}
				}

				[JsonProperty(PropertyName = "AmortizationPeriod")]
				public string AmortizationPeriod
				{
					get
					{
						return amortizationPeriod;
					}
					set	
					{
						amortizationPeriod = value;
					}
				}

				[JsonProperty(PropertyName = "BillAccountID")]
				public long? BillAccountID
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

				[JsonProperty(PropertyName = "BillAccountName")]
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

				[JsonProperty(PropertyName = "BillOwnerID")]
				public long? BillOwnerID
				{
					get
					{
						return billOwnerID;
					}
					set	
					{
						billOwnerID = value;
					}
				}

				[JsonProperty(PropertyName = "BillOwnerName")]
				public string BillOwnerName
				{
					get
					{
						return billOwnerName;
					}
					set	
					{
						billOwnerName = value;
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

				[JsonProperty(PropertyName = "ProductDetailCode")]
				public string ProductDetailCode
				{
					get
					{
						return productDetailCode;
					}
					set	
					{
						productDetailCode = value;
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

				[JsonProperty(PropertyName = "BizType")]
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

				[JsonProperty(PropertyName = "PretaxGrossAmount")]
				public double? PretaxGrossAmount
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

				[JsonProperty(PropertyName = "InvoiceDiscount")]
				public double? InvoiceDiscount
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

				[JsonProperty(PropertyName = "RoundDownDiscount")]
				public double? RoundDownDiscount
				{
					get
					{
						return roundDownDiscount;
					}
					set	
					{
						roundDownDiscount = value;
					}
				}

				[JsonProperty(PropertyName = "PretaxAmount")]
				public double? PretaxAmount
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

				[JsonProperty(PropertyName = "DeductedByCashCoupons")]
				public double? DeductedByCashCoupons
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

				[JsonProperty(PropertyName = "DeductedByCoupons")]
				public double? DeductedByCoupons
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

				[JsonProperty(PropertyName = "DeductedByPrepaidCard")]
				public double? DeductedByPrepaidCard
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

				[JsonProperty(PropertyName = "ExpenditureAmount")]
				public double? ExpenditureAmount
				{
					get
					{
						return expenditureAmount;
					}
					set	
					{
						expenditureAmount = value;
					}
				}

				[JsonProperty(PropertyName = "PreviouslyAmortizedPretaxGrossAmount")]
				public double? PreviouslyAmortizedPretaxGrossAmount
				{
					get
					{
						return previouslyAmortizedPretaxGrossAmount;
					}
					set	
					{
						previouslyAmortizedPretaxGrossAmount = value;
					}
				}

				[JsonProperty(PropertyName = "PreviouslyAmortizedInvoiceDiscount")]
				public double? PreviouslyAmortizedInvoiceDiscount
				{
					get
					{
						return previouslyAmortizedInvoiceDiscount;
					}
					set	
					{
						previouslyAmortizedInvoiceDiscount = value;
					}
				}

				[JsonProperty(PropertyName = "PreviouslyAmortizedRoundDownDiscount")]
				public double? PreviouslyAmortizedRoundDownDiscount
				{
					get
					{
						return previouslyAmortizedRoundDownDiscount;
					}
					set	
					{
						previouslyAmortizedRoundDownDiscount = value;
					}
				}

				[JsonProperty(PropertyName = "PreviouslyAmortizedPretaxAmount")]
				public double? PreviouslyAmortizedPretaxAmount
				{
					get
					{
						return previouslyAmortizedPretaxAmount;
					}
					set	
					{
						previouslyAmortizedPretaxAmount = value;
					}
				}

				[JsonProperty(PropertyName = "PreviouslyAmortizedDeductedByCashCoupons")]
				public double? PreviouslyAmortizedDeductedByCashCoupons
				{
					get
					{
						return previouslyAmortizedDeductedByCashCoupons;
					}
					set	
					{
						previouslyAmortizedDeductedByCashCoupons = value;
					}
				}

				[JsonProperty(PropertyName = "PreviouslyAmortizedDeductedByCoupons")]
				public double? PreviouslyAmortizedDeductedByCoupons
				{
					get
					{
						return previouslyAmortizedDeductedByCoupons;
					}
					set	
					{
						previouslyAmortizedDeductedByCoupons = value;
					}
				}

				[JsonProperty(PropertyName = "PreviouslyAmortizedDeductedByPrepaidCard")]
				public double? PreviouslyAmortizedDeductedByPrepaidCard
				{
					get
					{
						return previouslyAmortizedDeductedByPrepaidCard;
					}
					set	
					{
						previouslyAmortizedDeductedByPrepaidCard = value;
					}
				}

				[JsonProperty(PropertyName = "PreviouslyAmortizedExpenditureAmount")]
				public double? PreviouslyAmortizedExpenditureAmount
				{
					get
					{
						return previouslyAmortizedExpenditureAmount;
					}
					set	
					{
						previouslyAmortizedExpenditureAmount = value;
					}
				}

				[JsonProperty(PropertyName = "CurrentAmortizationPretaxGrossAmount")]
				public double? CurrentAmortizationPretaxGrossAmount
				{
					get
					{
						return currentAmortizationPretaxGrossAmount;
					}
					set	
					{
						currentAmortizationPretaxGrossAmount = value;
					}
				}

				[JsonProperty(PropertyName = "CurrentAmortizationInvoiceDiscount")]
				public double? CurrentAmortizationInvoiceDiscount
				{
					get
					{
						return currentAmortizationInvoiceDiscount;
					}
					set	
					{
						currentAmortizationInvoiceDiscount = value;
					}
				}

				[JsonProperty(PropertyName = "CurrentAmortizationRoundDownDiscount")]
				public double? CurrentAmortizationRoundDownDiscount
				{
					get
					{
						return currentAmortizationRoundDownDiscount;
					}
					set	
					{
						currentAmortizationRoundDownDiscount = value;
					}
				}

				[JsonProperty(PropertyName = "CurrentAmortizationPretaxAmount")]
				public double? CurrentAmortizationPretaxAmount
				{
					get
					{
						return currentAmortizationPretaxAmount;
					}
					set	
					{
						currentAmortizationPretaxAmount = value;
					}
				}

				[JsonProperty(PropertyName = "CurrentAmortizationDeductedByCashCoupons")]
				public double? CurrentAmortizationDeductedByCashCoupons
				{
					get
					{
						return currentAmortizationDeductedByCashCoupons;
					}
					set	
					{
						currentAmortizationDeductedByCashCoupons = value;
					}
				}

				[JsonProperty(PropertyName = "CurrentAmortizationDeductedByCoupons")]
				public double? CurrentAmortizationDeductedByCoupons
				{
					get
					{
						return currentAmortizationDeductedByCoupons;
					}
					set	
					{
						currentAmortizationDeductedByCoupons = value;
					}
				}

				[JsonProperty(PropertyName = "CurrentAmortizationDeductedByPrepaidCard")]
				public double? CurrentAmortizationDeductedByPrepaidCard
				{
					get
					{
						return currentAmortizationDeductedByPrepaidCard;
					}
					set	
					{
						currentAmortizationDeductedByPrepaidCard = value;
					}
				}

				[JsonProperty(PropertyName = "CurrentAmortizationExpenditureAmount")]
				public double? CurrentAmortizationExpenditureAmount
				{
					get
					{
						return currentAmortizationExpenditureAmount;
					}
					set	
					{
						currentAmortizationExpenditureAmount = value;
					}
				}

				[JsonProperty(PropertyName = "RemainingAmortizationPretaxGrossAmount")]
				public double? RemainingAmortizationPretaxGrossAmount
				{
					get
					{
						return remainingAmortizationPretaxGrossAmount;
					}
					set	
					{
						remainingAmortizationPretaxGrossAmount = value;
					}
				}

				[JsonProperty(PropertyName = "RemainingAmortizationInvoiceDiscount")]
				public double? RemainingAmortizationInvoiceDiscount
				{
					get
					{
						return remainingAmortizationInvoiceDiscount;
					}
					set	
					{
						remainingAmortizationInvoiceDiscount = value;
					}
				}

				[JsonProperty(PropertyName = "RemainingAmortizationRoundDownDiscount")]
				public double? RemainingAmortizationRoundDownDiscount
				{
					get
					{
						return remainingAmortizationRoundDownDiscount;
					}
					set	
					{
						remainingAmortizationRoundDownDiscount = value;
					}
				}

				[JsonProperty(PropertyName = "RemainingAmortizationPretaxAmount")]
				public double? RemainingAmortizationPretaxAmount
				{
					get
					{
						return remainingAmortizationPretaxAmount;
					}
					set	
					{
						remainingAmortizationPretaxAmount = value;
					}
				}

				[JsonProperty(PropertyName = "RemainingAmortizationDeductedByCashCoupons")]
				public double? RemainingAmortizationDeductedByCashCoupons
				{
					get
					{
						return remainingAmortizationDeductedByCashCoupons;
					}
					set	
					{
						remainingAmortizationDeductedByCashCoupons = value;
					}
				}

				[JsonProperty(PropertyName = "RemainingAmortizationDeductedByCoupons")]
				public double? RemainingAmortizationDeductedByCoupons
				{
					get
					{
						return remainingAmortizationDeductedByCoupons;
					}
					set	
					{
						remainingAmortizationDeductedByCoupons = value;
					}
				}

				[JsonProperty(PropertyName = "RemainingAmortizationDeductedByPrepaidCard")]
				public double? RemainingAmortizationDeductedByPrepaidCard
				{
					get
					{
						return remainingAmortizationDeductedByPrepaidCard;
					}
					set	
					{
						remainingAmortizationDeductedByPrepaidCard = value;
					}
				}

				[JsonProperty(PropertyName = "RemainingAmortizationExpenditureAmount")]
				public double? RemainingAmortizationExpenditureAmount
				{
					get
					{
						return remainingAmortizationExpenditureAmount;
					}
					set	
					{
						remainingAmortizationExpenditureAmount = value;
					}
				}
			}
		}
	}
}
