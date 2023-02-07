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
