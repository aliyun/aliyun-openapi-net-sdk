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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribePriceResponse : AcsResponse
	{

		private string orderParams;

		private string requestId;

		private List<DescribePrice_Rule> rules;

		private List<DescribePrice_SubOrder> subOrders;

		private DescribePrice_Order order;

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

		public class DescribePrice_SubOrder
		{

			private string originalAmount;

			private string instanceId;

			private string discountAmount;

			private string tradeAmount;

			private long? standDiscountPrice;

			private bool? isContractActivity;

			private long? standPrice;

			private bool? contractActivity;

			private List<DescribePrice_OptionalPromotion> optionalPromotions;

			private List<DescribePrice_ModuleInstanceItem> moduleInstance;

			private List<DescribePrice_PromDetail> promDetailList;

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

			public long? StandDiscountPrice
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

			public long? StandPrice
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

			public List<DescribePrice_PromDetail> PromDetailList
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

			public class DescribePrice_OptionalPromotion
			{

				private bool? selected;

				private string couponNo;

				private string name;

				private string description;

				private bool? show;

				private string activityExtInfo;

				private string optionCode;

				private string promotionName;

				private string promotionOptionNo;

				private string canPromFee;

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

				public string CanPromFee
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
			}

			public class DescribePrice_ModuleInstanceItem
			{

				private string moduleCode;

				private string moduleId;

				private double? standPrice;

				private bool? pricingModule;

				private string moduleName;

				private double? discountFee;

				private double? totalProductFee;

				private bool? needOrderPay;

				private double? payFee;

				private bool? contractActivity;

				private List<DescribePrice_ModuleAttr> moduleAttrs;

				private DescribePrice_DepreciateInfo1 depreciateInfo1;

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

				public string ModuleId
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

				public double? DiscountFee
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

				public class DescribePrice_ModuleAttr
				{

					private long? type;

					private string _value;

					private string code;

					private string name;

					public long? Type
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

					private bool? isShow;

					private string startTime;

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

					public bool? IsShow
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
				}
			}

			public class DescribePrice_PromDetail
			{

				private string promotionName;

				private long? promotionId;

				private double? finalPromFee;

				private string optionCode;

				private string promType;

				private string activityExtInfo;

				private string derivedPromType;

				private string promotionCode;

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
			}

			public class DescribePrice_DepreciateInfo
			{

				private long? listPrice;

				private long? originalStandAmount;

				private long? cheapStandAmount;

				private long? cheapRate;

				private long? differential;

				private string differentialName;

				private long? monthPrice;

				private bool? isContractActivity;

				private string startTime;

				private DescribePrice_ContractActivity contractActivity;

				public long? ListPrice
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

				public long? OriginalStandAmount
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

				public long? CheapStandAmount
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

				public long? CheapRate
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

				public long? Differential
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

				public long? MonthPrice
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

		public class DescribePrice_Order
		{

			private string originalAmount;

			private string handlingFeeAmount;

			private string currency;

			private string discountAmount;

			private string tradeAmount;

			private bool? showDiscountInfo;

			private long? standDiscountPrice;

			private bool? isContractActivity;

			private long? standPrice;

			private string code;

			private string message;

			private List<DescribePrice_Coupon> coupons;

			private List<string> ruleIds2;

			private DescribePrice_DepreciateInfo3 depreciateInfo3;

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

			public string HandlingFeeAmount
			{
				get
				{
					return handlingFeeAmount;
				}
				set	
				{
					handlingFeeAmount = value;
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

			public long? StandDiscountPrice
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

			public long? StandPrice
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

			public List<string> RuleIds2
			{
				get
				{
					return ruleIds2;
				}
				set	
				{
					ruleIds2 = value;
				}
			}

			public DescribePrice_DepreciateInfo3 DepreciateInfo3
			{
				get
				{
					return depreciateInfo3;
				}
				set	
				{
					depreciateInfo3 = value;
				}
			}

			public class DescribePrice_Coupon
			{

				private string isSelected;

				private string couponNo;

				private string name;

				private string description;

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
			}

			public class DescribePrice_DepreciateInfo3
			{

				private long? listPrice;

				private long? originalStandAmount;

				private long? cheapStandAmount;

				private long? cheapRate;

				private long? differential;

				private string differentialName;

				private long? monthPrice;

				private bool? isContractActivity;

				private bool? isShow;

				private DescribePrice_ContractActivity4 contractActivity4;

				public long? ListPrice
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

				public long? OriginalStandAmount
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

				public long? CheapStandAmount
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

				public long? CheapRate
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

				public long? Differential
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

				public long? MonthPrice
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

				public bool? IsShow
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

				public DescribePrice_ContractActivity4 ContractActivity4
				{
					get
					{
						return contractActivity4;
					}
					set	
					{
						contractActivity4 = value;
					}
				}

				public class DescribePrice_ContractActivity4
				{

					private double? finalPromFee;

					private double? finalFee;

					private double? prodFee;

					private long? activityId;

					private string optionCode;

					private string activityName;

					private List<string> optionIds5;

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

					public List<string> OptionIds5
					{
						get
						{
							return optionIds5;
						}
						set	
						{
							optionIds5 = value;
						}
					}
				}
			}
		}
	}
}
