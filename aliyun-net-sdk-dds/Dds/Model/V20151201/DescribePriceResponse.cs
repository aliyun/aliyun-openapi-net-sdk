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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribePriceResponse : AcsResponse
	{

		private string requestId;

		private string traceId;

		private string orderParams;

		private List<DescribePrice_SubOrder> subOrders;

		private List<DescribePrice_Rule> rules;

		private DescribePrice_Order order;

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

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
			}
		}

		public string OrderParams
		{
			get
			{
				return orderParams;
			}
			set	
			{
				orderParams = value;
			}
		}

		public List<DescribePrice_SubOrder> SubOrders
		{
			get
			{
				return subOrders;
			}
			set	
			{
				subOrders = value;
			}
		}

		public List<DescribePrice_Rule> Rules
		{
			get
			{
				return rules;
			}
			set	
			{
				rules = value;
			}
		}

		public DescribePrice_Order Order
		{
			get
			{
				return order;
			}
			set	
			{
				order = value;
			}
		}

		public class DescribePrice_SubOrder
		{

			private string originalAmount;

			private string discountAmount;

			private string tradeAmount;

			private string instanceId;

			private string isNewOfficialActivity;

			private bool? contractActivity;

			private double? standDiscountPrice;

			private double? standPrice;

			private bool? isContractActivity;

			private List<DescribePrice_ModuleInstanceItem> moduleInstance;

			private List<DescribePrice_OptionalPromotion> optionalPromotions;

			private List<DescribePrice_PromDetail3> promDetailList;

			private List<string> ruleIds;

			private DescribePrice_DepreciateInfo depreciateInfo;

			public string OriginalAmount
			{
				get
				{
					return originalAmount;
				}
				set	
				{
					originalAmount = value;
				}
			}

			public string DiscountAmount
			{
				get
				{
					return discountAmount;
				}
				set	
				{
					discountAmount = value;
				}
			}

			public string TradeAmount
			{
				get
				{
					return tradeAmount;
				}
				set	
				{
					tradeAmount = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string IsNewOfficialActivity
			{
				get
				{
					return isNewOfficialActivity;
				}
				set	
				{
					isNewOfficialActivity = value;
				}
			}

			public bool? ContractActivity
			{
				get
				{
					return contractActivity;
				}
				set	
				{
					contractActivity = value;
				}
			}

			public double? StandDiscountPrice
			{
				get
				{
					return standDiscountPrice;
				}
				set	
				{
					standDiscountPrice = value;
				}
			}

			public double? StandPrice
			{
				get
				{
					return standPrice;
				}
				set	
				{
					standPrice = value;
				}
			}

			public bool? IsContractActivity
			{
				get
				{
					return isContractActivity;
				}
				set	
				{
					isContractActivity = value;
				}
			}

			public List<DescribePrice_ModuleInstanceItem> ModuleInstance
			{
				get
				{
					return moduleInstance;
				}
				set	
				{
					moduleInstance = value;
				}
			}

			public List<DescribePrice_OptionalPromotion> OptionalPromotions
			{
				get
				{
					return optionalPromotions;
				}
				set	
				{
					optionalPromotions = value;
				}
			}

			public List<DescribePrice_PromDetail3> PromDetailList
			{
				get
				{
					return promDetailList;
				}
				set	
				{
					promDetailList = value;
				}
			}

			public List<string> RuleIds
			{
				get
				{
					return ruleIds;
				}
				set	
				{
					ruleIds = value;
				}
			}

			public DescribePrice_DepreciateInfo DepreciateInfo
			{
				get
				{
					return depreciateInfo;
				}
				set	
				{
					depreciateInfo = value;
				}
			}

			public class DescribePrice_ModuleInstanceItem
			{

				private string cycleFee;

				private string discountFee;

				private string moduleCode;

				private long? moduleId;

				private string moduleName;

				private bool? needOrderPay;

				private double? payFee;

				private bool? pricingModule;

				private double? standPrice;

				private double? totalProductFee;

				private bool? contractActivity;

				private double? standDiscountPrice;

				private string priceUnit;

				private string priceType;

				private List<DescribePrice_PromDetail> promDetailList2;

				private List<DescribePrice_ModuleAttr> moduleAttrs;

				private DescribePrice_DepreciateInfo1 depreciateInfo1;

				public string CycleFee
				{
					get
					{
						return cycleFee;
					}
					set	
					{
						cycleFee = value;
					}
				}

				public string DiscountFee
				{
					get
					{
						return discountFee;
					}
					set	
					{
						discountFee = value;
					}
				}

				public string ModuleCode
				{
					get
					{
						return moduleCode;
					}
					set	
					{
						moduleCode = value;
					}
				}

				public long? ModuleId
				{
					get
					{
						return moduleId;
					}
					set	
					{
						moduleId = value;
					}
				}

				public string ModuleName
				{
					get
					{
						return moduleName;
					}
					set	
					{
						moduleName = value;
					}
				}

				public bool? NeedOrderPay
				{
					get
					{
						return needOrderPay;
					}
					set	
					{
						needOrderPay = value;
					}
				}

				public double? PayFee
				{
					get
					{
						return payFee;
					}
					set	
					{
						payFee = value;
					}
				}

				public bool? PricingModule
				{
					get
					{
						return pricingModule;
					}
					set	
					{
						pricingModule = value;
					}
				}

				public double? StandPrice
				{
					get
					{
						return standPrice;
					}
					set	
					{
						standPrice = value;
					}
				}

				public double? TotalProductFee
				{
					get
					{
						return totalProductFee;
					}
					set	
					{
						totalProductFee = value;
					}
				}

				public bool? ContractActivity
				{
					get
					{
						return contractActivity;
					}
					set	
					{
						contractActivity = value;
					}
				}

				public double? StandDiscountPrice
				{
					get
					{
						return standDiscountPrice;
					}
					set	
					{
						standDiscountPrice = value;
					}
				}

				public string PriceUnit
				{
					get
					{
						return priceUnit;
					}
					set	
					{
						priceUnit = value;
					}
				}

				public string PriceType
				{
					get
					{
						return priceType;
					}
					set	
					{
						priceType = value;
					}
				}

				public List<DescribePrice_PromDetail> PromDetailList2
				{
					get
					{
						return promDetailList2;
					}
					set	
					{
						promDetailList2 = value;
					}
				}

				public List<DescribePrice_ModuleAttr> ModuleAttrs
				{
					get
					{
						return moduleAttrs;
					}
					set	
					{
						moduleAttrs = value;
					}
				}

				public DescribePrice_DepreciateInfo1 DepreciateInfo1
				{
					get
					{
						return depreciateInfo1;
					}
					set	
					{
						depreciateInfo1 = value;
					}
				}

				public class DescribePrice_PromDetail
				{

					private double? finalPromFee;

					private string activityExtInfo;

					private string optionCode;

					private string promType;

					private long? promotionId;

					private string promotionName;

					private string promotionCode;

					private string derivedPromType;

					public double? FinalPromFee
					{
						get
						{
							return finalPromFee;
						}
						set	
						{
							finalPromFee = value;
						}
					}

					public string ActivityExtInfo
					{
						get
						{
							return activityExtInfo;
						}
						set	
						{
							activityExtInfo = value;
						}
					}

					public string OptionCode
					{
						get
						{
							return optionCode;
						}
						set	
						{
							optionCode = value;
						}
					}

					public string PromType
					{
						get
						{
							return promType;
						}
						set	
						{
							promType = value;
						}
					}

					public long? PromotionId
					{
						get
						{
							return promotionId;
						}
						set	
						{
							promotionId = value;
						}
					}

					public string PromotionName
					{
						get
						{
							return promotionName;
						}
						set	
						{
							promotionName = value;
						}
					}

					public string PromotionCode
					{
						get
						{
							return promotionCode;
						}
						set	
						{
							promotionCode = value;
						}
					}

					public string DerivedPromType
					{
						get
						{
							return derivedPromType;
						}
						set	
						{
							derivedPromType = value;
						}
					}
				}

				public class DescribePrice_ModuleAttr
				{

					private string code;

					private string name;

					private string type;

					private string _value;

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

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public string Type
					{
						get
						{
							return type;
						}
						set	
						{
							type = value;
						}
					}

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}

				public class DescribePrice_DepreciateInfo1
				{

					private double? listPrice;

					private double? originalStandAmount;

					private double? cheapStandAmount;

					private double? cheapRate;

					private double? differential;

					private string differentialName;

					private double? monthPrice;

					private bool? isContractActivity;

					private string isShow;

					public double? ListPrice
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

					public double? OriginalStandAmount
					{
						get
						{
							return originalStandAmount;
						}
						set	
						{
							originalStandAmount = value;
						}
					}

					public double? CheapStandAmount
					{
						get
						{
							return cheapStandAmount;
						}
						set	
						{
							cheapStandAmount = value;
						}
					}

					public double? CheapRate
					{
						get
						{
							return cheapRate;
						}
						set	
						{
							cheapRate = value;
						}
					}

					public double? Differential
					{
						get
						{
							return differential;
						}
						set	
						{
							differential = value;
						}
					}

					public string DifferentialName
					{
						get
						{
							return differentialName;
						}
						set	
						{
							differentialName = value;
						}
					}

					public double? MonthPrice
					{
						get
						{
							return monthPrice;
						}
						set	
						{
							monthPrice = value;
						}
					}

					public bool? IsContractActivity
					{
						get
						{
							return isContractActivity;
						}
						set	
						{
							isContractActivity = value;
						}
					}

					public string IsShow
					{
						get
						{
							return isShow;
						}
						set	
						{
							isShow = value;
						}
					}
				}
			}

			public class DescribePrice_OptionalPromotion
			{

				private string activityCategory;

				private string activityExtInfo;

				private double? canPromFee;

				private string optionCode;

				private string promotionName;

				private string promotionOptionNo;

				private bool? selected;

				private bool? show;

				private List<string> targetArticleItemCodes;

				private List<string> promotionRuleIdList;

				public string ActivityCategory
				{
					get
					{
						return activityCategory;
					}
					set	
					{
						activityCategory = value;
					}
				}

				public string ActivityExtInfo
				{
					get
					{
						return activityExtInfo;
					}
					set	
					{
						activityExtInfo = value;
					}
				}

				public double? CanPromFee
				{
					get
					{
						return canPromFee;
					}
					set	
					{
						canPromFee = value;
					}
				}

				public string OptionCode
				{
					get
					{
						return optionCode;
					}
					set	
					{
						optionCode = value;
					}
				}

				public string PromotionName
				{
					get
					{
						return promotionName;
					}
					set	
					{
						promotionName = value;
					}
				}

				public string PromotionOptionNo
				{
					get
					{
						return promotionOptionNo;
					}
					set	
					{
						promotionOptionNo = value;
					}
				}

				public bool? Selected
				{
					get
					{
						return selected;
					}
					set	
					{
						selected = value;
					}
				}

				public bool? Show
				{
					get
					{
						return show;
					}
					set	
					{
						show = value;
					}
				}

				public List<string> TargetArticleItemCodes
				{
					get
					{
						return targetArticleItemCodes;
					}
					set	
					{
						targetArticleItemCodes = value;
					}
				}

				public List<string> PromotionRuleIdList
				{
					get
					{
						return promotionRuleIdList;
					}
					set	
					{
						promotionRuleIdList = value;
					}
				}
			}

			public class DescribePrice_PromDetail3
			{

				private double? finalPromFee;

				private string activityExtInfo;

				private string optionCode;

				private string promType;

				private long? promotionId;

				private string promotionName;

				private string promotionCode;

				private string derivedPromType;

				public double? FinalPromFee
				{
					get
					{
						return finalPromFee;
					}
					set	
					{
						finalPromFee = value;
					}
				}

				public string ActivityExtInfo
				{
					get
					{
						return activityExtInfo;
					}
					set	
					{
						activityExtInfo = value;
					}
				}

				public string OptionCode
				{
					get
					{
						return optionCode;
					}
					set	
					{
						optionCode = value;
					}
				}

				public string PromType
				{
					get
					{
						return promType;
					}
					set	
					{
						promType = value;
					}
				}

				public long? PromotionId
				{
					get
					{
						return promotionId;
					}
					set	
					{
						promotionId = value;
					}
				}

				public string PromotionName
				{
					get
					{
						return promotionName;
					}
					set	
					{
						promotionName = value;
					}
				}

				public string PromotionCode
				{
					get
					{
						return promotionCode;
					}
					set	
					{
						promotionCode = value;
					}
				}

				public string DerivedPromType
				{
					get
					{
						return derivedPromType;
					}
					set	
					{
						derivedPromType = value;
					}
				}
			}

			public class DescribePrice_DepreciateInfo
			{

				private double? listPrice;

				private double? originalStandAmount;

				private double? cheapStandAmount;

				private double? cheapRate;

				private double? differential;

				private string differentialName;

				private double? monthPrice;

				private bool? isContractActivity;

				private string isShow;

				private string startTime;

				private DescribePrice_ContractActivity contractActivity;

				public double? ListPrice
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

				public double? OriginalStandAmount
				{
					get
					{
						return originalStandAmount;
					}
					set	
					{
						originalStandAmount = value;
					}
				}

				public double? CheapStandAmount
				{
					get
					{
						return cheapStandAmount;
					}
					set	
					{
						cheapStandAmount = value;
					}
				}

				public double? CheapRate
				{
					get
					{
						return cheapRate;
					}
					set	
					{
						cheapRate = value;
					}
				}

				public double? Differential
				{
					get
					{
						return differential;
					}
					set	
					{
						differential = value;
					}
				}

				public string DifferentialName
				{
					get
					{
						return differentialName;
					}
					set	
					{
						differentialName = value;
					}
				}

				public double? MonthPrice
				{
					get
					{
						return monthPrice;
					}
					set	
					{
						monthPrice = value;
					}
				}

				public bool? IsContractActivity
				{
					get
					{
						return isContractActivity;
					}
					set	
					{
						isContractActivity = value;
					}
				}

				public string IsShow
				{
					get
					{
						return isShow;
					}
					set	
					{
						isShow = value;
					}
				}

				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public DescribePrice_ContractActivity ContractActivity
				{
					get
					{
						return contractActivity;
					}
					set	
					{
						contractActivity = value;
					}
				}

				public class DescribePrice_ContractActivity
				{

					private double? finalPromFee;

					private double? finalFee;

					private double? prodFee;

					private long? activityId;

					private string optionCode;

					private string activityName;

					private List<string> optionIds;

					public double? FinalPromFee
					{
						get
						{
							return finalPromFee;
						}
						set	
						{
							finalPromFee = value;
						}
					}

					public double? FinalFee
					{
						get
						{
							return finalFee;
						}
						set	
						{
							finalFee = value;
						}
					}

					public double? ProdFee
					{
						get
						{
							return prodFee;
						}
						set	
						{
							prodFee = value;
						}
					}

					public long? ActivityId
					{
						get
						{
							return activityId;
						}
						set	
						{
							activityId = value;
						}
					}

					public string OptionCode
					{
						get
						{
							return optionCode;
						}
						set	
						{
							optionCode = value;
						}
					}

					public string ActivityName
					{
						get
						{
							return activityName;
						}
						set	
						{
							activityName = value;
						}
					}

					public List<string> OptionIds
					{
						get
						{
							return optionIds;
						}
						set	
						{
							optionIds = value;
						}
					}
				}
			}
		}

		public class DescribePrice_Rule
		{

			private long? ruleDescId;

			private string title;

			private string name;

			public long? RuleDescId
			{
				get
				{
					return ruleDescId;
				}
				set	
				{
					ruleDescId = value;
				}
			}

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}
		}

		public class DescribePrice_Order
		{

			private string originalAmount;

			private string discountAmount;

			private string tradeAmount;

			private string currency;

			private bool? showDiscountInfo;

			private string optionalPromotions;

			private string promDetailList;

			private double? standDiscountPrice;

			private double? standPrice;

			private bool? contractActivity;

			private string code;

			private string message;

			private bool? isContractActivity;

			private double? totalCostAmount;

			private List<DescribePrice_Coupon> coupons;

			private List<string> ruleIds4;

			private DescribePrice_DepreciateInfo5 depreciateInfo5;

			public string OriginalAmount
			{
				get
				{
					return originalAmount;
				}
				set	
				{
					originalAmount = value;
				}
			}

			public string DiscountAmount
			{
				get
				{
					return discountAmount;
				}
				set	
				{
					discountAmount = value;
				}
			}

			public string TradeAmount
			{
				get
				{
					return tradeAmount;
				}
				set	
				{
					tradeAmount = value;
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

			public bool? ShowDiscountInfo
			{
				get
				{
					return showDiscountInfo;
				}
				set	
				{
					showDiscountInfo = value;
				}
			}

			public string OptionalPromotions
			{
				get
				{
					return optionalPromotions;
				}
				set	
				{
					optionalPromotions = value;
				}
			}

			public string PromDetailList
			{
				get
				{
					return promDetailList;
				}
				set	
				{
					promDetailList = value;
				}
			}

			public double? StandDiscountPrice
			{
				get
				{
					return standDiscountPrice;
				}
				set	
				{
					standDiscountPrice = value;
				}
			}

			public double? StandPrice
			{
				get
				{
					return standPrice;
				}
				set	
				{
					standPrice = value;
				}
			}

			public bool? ContractActivity
			{
				get
				{
					return contractActivity;
				}
				set	
				{
					contractActivity = value;
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

			public bool? IsContractActivity
			{
				get
				{
					return isContractActivity;
				}
				set	
				{
					isContractActivity = value;
				}
			}

			public double? TotalCostAmount
			{
				get
				{
					return totalCostAmount;
				}
				set	
				{
					totalCostAmount = value;
				}
			}

			public List<DescribePrice_Coupon> Coupons
			{
				get
				{
					return coupons;
				}
				set	
				{
					coupons = value;
				}
			}

			public List<string> RuleIds4
			{
				get
				{
					return ruleIds4;
				}
				set	
				{
					ruleIds4 = value;
				}
			}

			public DescribePrice_DepreciateInfo5 DepreciateInfo5
			{
				get
				{
					return depreciateInfo5;
				}
				set	
				{
					depreciateInfo5 = value;
				}
			}

			public class DescribePrice_Coupon
			{

				private string description;

				private string isSelected;

				private string couponNo;

				private string name;

				private double? canPromFee;

				private string promotionOptionCode;

				private double? lackForPriceBreak;

				private double? priceBreakThreshold;

				private double? priceBreakReduceValue;

				private string optionCode;

				private string activityCategory;

				private List<string> promotionRuleIdList6;

				private List<string> targetArticleItemCodes7;

				public string Description
				{
					get
					{
						return description;
					}
					set	
					{
						description = value;
					}
				}

				public string IsSelected
				{
					get
					{
						return isSelected;
					}
					set	
					{
						isSelected = value;
					}
				}

				public string CouponNo
				{
					get
					{
						return couponNo;
					}
					set	
					{
						couponNo = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public double? CanPromFee
				{
					get
					{
						return canPromFee;
					}
					set	
					{
						canPromFee = value;
					}
				}

				public string PromotionOptionCode
				{
					get
					{
						return promotionOptionCode;
					}
					set	
					{
						promotionOptionCode = value;
					}
				}

				public double? LackForPriceBreak
				{
					get
					{
						return lackForPriceBreak;
					}
					set	
					{
						lackForPriceBreak = value;
					}
				}

				public double? PriceBreakThreshold
				{
					get
					{
						return priceBreakThreshold;
					}
					set	
					{
						priceBreakThreshold = value;
					}
				}

				public double? PriceBreakReduceValue
				{
					get
					{
						return priceBreakReduceValue;
					}
					set	
					{
						priceBreakReduceValue = value;
					}
				}

				public string OptionCode
				{
					get
					{
						return optionCode;
					}
					set	
					{
						optionCode = value;
					}
				}

				public string ActivityCategory
				{
					get
					{
						return activityCategory;
					}
					set	
					{
						activityCategory = value;
					}
				}

				public List<string> PromotionRuleIdList6
				{
					get
					{
						return promotionRuleIdList6;
					}
					set	
					{
						promotionRuleIdList6 = value;
					}
				}

				public List<string> TargetArticleItemCodes7
				{
					get
					{
						return targetArticleItemCodes7;
					}
					set	
					{
						targetArticleItemCodes7 = value;
					}
				}
			}

			public class DescribePrice_DepreciateInfo5
			{

				private double? listPrice;

				private double? originalStandAmount;

				private double? cheapStandAmount;

				private double? cheapRate;

				private double? differential;

				private string differentialName;

				private double? monthPrice;

				private bool? isContractActivity;

				private string isShow;

				private DescribePrice_ContractActivity8 contractActivity8;

				public double? ListPrice
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

				public double? OriginalStandAmount
				{
					get
					{
						return originalStandAmount;
					}
					set	
					{
						originalStandAmount = value;
					}
				}

				public double? CheapStandAmount
				{
					get
					{
						return cheapStandAmount;
					}
					set	
					{
						cheapStandAmount = value;
					}
				}

				public double? CheapRate
				{
					get
					{
						return cheapRate;
					}
					set	
					{
						cheapRate = value;
					}
				}

				public double? Differential
				{
					get
					{
						return differential;
					}
					set	
					{
						differential = value;
					}
				}

				public string DifferentialName
				{
					get
					{
						return differentialName;
					}
					set	
					{
						differentialName = value;
					}
				}

				public double? MonthPrice
				{
					get
					{
						return monthPrice;
					}
					set	
					{
						monthPrice = value;
					}
				}

				public bool? IsContractActivity
				{
					get
					{
						return isContractActivity;
					}
					set	
					{
						isContractActivity = value;
					}
				}

				public string IsShow
				{
					get
					{
						return isShow;
					}
					set	
					{
						isShow = value;
					}
				}

				public DescribePrice_ContractActivity8 ContractActivity8
				{
					get
					{
						return contractActivity8;
					}
					set	
					{
						contractActivity8 = value;
					}
				}

				public class DescribePrice_ContractActivity8
				{

					private double? finalPromFee;

					private double? finalFee;

					private double? prodFee;

					private long? activityId;

					private string optionCode;

					private string activityName;

					private List<string> optionIds9;

					public double? FinalPromFee
					{
						get
						{
							return finalPromFee;
						}
						set	
						{
							finalPromFee = value;
						}
					}

					public double? FinalFee
					{
						get
						{
							return finalFee;
						}
						set	
						{
							finalFee = value;
						}
					}

					public double? ProdFee
					{
						get
						{
							return prodFee;
						}
						set	
						{
							prodFee = value;
						}
					}

					public long? ActivityId
					{
						get
						{
							return activityId;
						}
						set	
						{
							activityId = value;
						}
					}

					public string OptionCode
					{
						get
						{
							return optionCode;
						}
						set	
						{
							optionCode = value;
						}
					}

					public string ActivityName
					{
						get
						{
							return activityName;
						}
						set	
						{
							activityName = value;
						}
					}

					public List<string> OptionIds9
					{
						get
						{
							return optionIds9;
						}
						set	
						{
							optionIds9 = value;
						}
					}
				}
			}
		}
	}
}
