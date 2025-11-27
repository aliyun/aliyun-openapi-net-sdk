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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribePriceResponseUnmarshaller
    {
        public static DescribePriceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePriceResponse describePriceResponse = new DescribePriceResponse();

			describePriceResponse.HttpResponse = _ctx.HttpResponse;
			describePriceResponse.OrderParams = _ctx.StringValue("DescribePrice.OrderParams");
			describePriceResponse.RequestId = _ctx.StringValue("DescribePrice.RequestId");

			DescribePriceResponse.DescribePrice_Order order = new DescribePriceResponse.DescribePrice_Order();
			order.OriginalAmount = _ctx.StringValue("DescribePrice.Order.OriginalAmount");
			order.HandlingFeeAmount = _ctx.StringValue("DescribePrice.Order.HandlingFeeAmount");
			order.Currency = _ctx.StringValue("DescribePrice.Order.Currency");
			order.DiscountAmount = _ctx.StringValue("DescribePrice.Order.DiscountAmount");
			order.TradeAmount = _ctx.StringValue("DescribePrice.Order.TradeAmount");
			order.ShowDiscountInfo = _ctx.BooleanValue("DescribePrice.Order.ShowDiscountInfo");
			order.StandDiscountPrice = _ctx.LongValue("DescribePrice.Order.StandDiscountPrice");
			order.IsContractActivity = _ctx.BooleanValue("DescribePrice.Order.IsContractActivity");
			order.StandPrice = _ctx.LongValue("DescribePrice.Order.StandPrice");
			order.Code = _ctx.StringValue("DescribePrice.Order.Code");
			order.Message = _ctx.StringValue("DescribePrice.Order.Message");

			List<string> order_ruleIds2 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribePrice.Order.RuleIds.Length"); i++) {
				order_ruleIds2.Add(_ctx.StringValue("DescribePrice.Order.RuleIds["+ i +"]"));
			}
			order.RuleIds2 = order_ruleIds2;

			DescribePriceResponse.DescribePrice_Order.DescribePrice_DepreciateInfo3 depreciateInfo3 = new DescribePriceResponse.DescribePrice_Order.DescribePrice_DepreciateInfo3();
			depreciateInfo3.ListPrice = _ctx.LongValue("DescribePrice.Order.DepreciateInfo.ListPrice");
			depreciateInfo3.OriginalStandAmount = _ctx.LongValue("DescribePrice.Order.DepreciateInfo.OriginalStandAmount");
			depreciateInfo3.CheapStandAmount = _ctx.LongValue("DescribePrice.Order.DepreciateInfo.CheapStandAmount");
			depreciateInfo3.CheapRate = _ctx.LongValue("DescribePrice.Order.DepreciateInfo.CheapRate");
			depreciateInfo3.Differential = _ctx.LongValue("DescribePrice.Order.DepreciateInfo.Differential");
			depreciateInfo3.DifferentialName = _ctx.StringValue("DescribePrice.Order.DepreciateInfo.DifferentialName");
			depreciateInfo3.MonthPrice = _ctx.LongValue("DescribePrice.Order.DepreciateInfo.MonthPrice");
			depreciateInfo3.IsContractActivity = _ctx.BooleanValue("DescribePrice.Order.DepreciateInfo.IsContractActivity");
			depreciateInfo3.IsShow = _ctx.BooleanValue("DescribePrice.Order.DepreciateInfo.IsShow");

			DescribePriceResponse.DescribePrice_Order.DescribePrice_DepreciateInfo3.DescribePrice_ContractActivity4 contractActivity4 = new DescribePriceResponse.DescribePrice_Order.DescribePrice_DepreciateInfo3.DescribePrice_ContractActivity4();
			contractActivity4.FinalPromFee = _ctx.DoubleValue("DescribePrice.Order.DepreciateInfo.ContractActivity.FinalPromFee");
			contractActivity4.FinalFee = _ctx.DoubleValue("DescribePrice.Order.DepreciateInfo.ContractActivity.FinalFee");
			contractActivity4.ProdFee = _ctx.DoubleValue("DescribePrice.Order.DepreciateInfo.ContractActivity.ProdFee");
			contractActivity4.ActivityId = _ctx.LongValue("DescribePrice.Order.DepreciateInfo.ContractActivity.ActivityId");
			contractActivity4.OptionCode = _ctx.StringValue("DescribePrice.Order.DepreciateInfo.ContractActivity.OptionCode");
			contractActivity4.ActivityName = _ctx.StringValue("DescribePrice.Order.DepreciateInfo.ContractActivity.ActivityName");

			List<string> contractActivity4_optionIds5 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribePrice.Order.DepreciateInfo.ContractActivity.OptionIds.Length"); i++) {
				contractActivity4_optionIds5.Add(_ctx.StringValue("DescribePrice.Order.DepreciateInfo.ContractActivity.OptionIds["+ i +"]"));
			}
			contractActivity4.OptionIds5 = contractActivity4_optionIds5;
			depreciateInfo3.ContractActivity4 = contractActivity4;
			order.DepreciateInfo3 = depreciateInfo3;

			List<DescribePriceResponse.DescribePrice_Order.DescribePrice_Coupon> order_coupons = new List<DescribePriceResponse.DescribePrice_Order.DescribePrice_Coupon>();
			for (int i = 0; i < _ctx.Length("DescribePrice.Order.Coupons.Length"); i++) {
				DescribePriceResponse.DescribePrice_Order.DescribePrice_Coupon coupon = new DescribePriceResponse.DescribePrice_Order.DescribePrice_Coupon();
				coupon.IsSelected = _ctx.StringValue("DescribePrice.Order.Coupons["+ i +"].IsSelected");
				coupon.CouponNo = _ctx.StringValue("DescribePrice.Order.Coupons["+ i +"].CouponNo");
				coupon.Name = _ctx.StringValue("DescribePrice.Order.Coupons["+ i +"].Name");
				coupon.Description = _ctx.StringValue("DescribePrice.Order.Coupons["+ i +"].Description");

				order_coupons.Add(coupon);
			}
			order.Coupons = order_coupons;
			describePriceResponse.Order = order;

			List<DescribePriceResponse.DescribePrice_Rule> describePriceResponse_rules = new List<DescribePriceResponse.DescribePrice_Rule>();
			for (int i = 0; i < _ctx.Length("DescribePrice.Rules.Length"); i++) {
				DescribePriceResponse.DescribePrice_Rule rule = new DescribePriceResponse.DescribePrice_Rule();
				rule.RuleDescId = _ctx.LongValue("DescribePrice.Rules["+ i +"].RuleDescId");
				rule.Title = _ctx.StringValue("DescribePrice.Rules["+ i +"].Title");
				rule.Name = _ctx.StringValue("DescribePrice.Rules["+ i +"].Name");

				describePriceResponse_rules.Add(rule);
			}
			describePriceResponse.Rules = describePriceResponse_rules;

			List<DescribePriceResponse.DescribePrice_SubOrder> describePriceResponse_subOrders = new List<DescribePriceResponse.DescribePrice_SubOrder>();
			for (int i = 0; i < _ctx.Length("DescribePrice.SubOrders.Length"); i++) {
				DescribePriceResponse.DescribePrice_SubOrder subOrder = new DescribePriceResponse.DescribePrice_SubOrder();
				subOrder.OriginalAmount = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].OriginalAmount");
				subOrder.InstanceId = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].InstanceId");
				subOrder.DiscountAmount = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].DiscountAmount");
				subOrder.TradeAmount = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].TradeAmount");
				subOrder.StandDiscountPrice = _ctx.LongValue("DescribePrice.SubOrders["+ i +"].StandDiscountPrice");
				subOrder.IsContractActivity = _ctx.BooleanValue("DescribePrice.SubOrders["+ i +"].IsContractActivity");
				subOrder.StandPrice = _ctx.LongValue("DescribePrice.SubOrders["+ i +"].StandPrice");
				subOrder.ContractActivity = _ctx.BooleanValue("DescribePrice.SubOrders["+ i +"].ContractActivity");

				List<string> subOrder_ruleIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribePrice.SubOrders["+ i +"].RuleIds.Length"); j++) {
					subOrder_ruleIds.Add(_ctx.StringValue("DescribePrice.SubOrders["+ i +"].RuleIds["+ j +"]"));
				}
				subOrder.RuleIds = subOrder_ruleIds;

				DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_DepreciateInfo depreciateInfo = new DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_DepreciateInfo();
				depreciateInfo.ListPrice = _ctx.LongValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.ListPrice");
				depreciateInfo.OriginalStandAmount = _ctx.LongValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.OriginalStandAmount");
				depreciateInfo.CheapStandAmount = _ctx.LongValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.CheapStandAmount");
				depreciateInfo.CheapRate = _ctx.LongValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.CheapRate");
				depreciateInfo.Differential = _ctx.LongValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.Differential");
				depreciateInfo.DifferentialName = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.DifferentialName");
				depreciateInfo.MonthPrice = _ctx.LongValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.MonthPrice");
				depreciateInfo.IsContractActivity = _ctx.BooleanValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.IsContractActivity");
				depreciateInfo.StartTime = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.StartTime");

				DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_DepreciateInfo.DescribePrice_ContractActivity contractActivity = new DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_DepreciateInfo.DescribePrice_ContractActivity();
				contractActivity.FinalPromFee = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.ContractActivity.FinalPromFee");
				contractActivity.FinalFee = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.ContractActivity.FinalFee");
				contractActivity.ProdFee = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.ContractActivity.ProdFee");
				contractActivity.ActivityId = _ctx.LongValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.ContractActivity.ActivityId");
				contractActivity.OptionCode = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.ContractActivity.OptionCode");
				contractActivity.ActivityName = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.ContractActivity.ActivityName");

				List<string> contractActivity_optionIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribePrice.SubOrders["+ i +"].DepreciateInfo.ContractActivity.OptionIds.Length"); j++) {
					contractActivity_optionIds.Add(_ctx.StringValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.ContractActivity.OptionIds["+ j +"]"));
				}
				contractActivity.OptionIds = contractActivity_optionIds;
				depreciateInfo.ContractActivity = contractActivity;
				subOrder.DepreciateInfo = depreciateInfo;

				List<DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_OptionalPromotion> subOrder_optionalPromotions = new List<DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_OptionalPromotion>();
				for (int j = 0; j < _ctx.Length("DescribePrice.SubOrders["+ i +"].OptionalPromotions.Length"); j++) {
					DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_OptionalPromotion optionalPromotion = new DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_OptionalPromotion();
					optionalPromotion.Selected = _ctx.BooleanValue("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].Selected");
					optionalPromotion.CouponNo = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].CouponNo");
					optionalPromotion.Name = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].Name");
					optionalPromotion.Description = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].Description");
					optionalPromotion.Show = _ctx.BooleanValue("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].Show");
					optionalPromotion.ActivityExtInfo = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].ActivityExtInfo");
					optionalPromotion.OptionCode = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].OptionCode");
					optionalPromotion.PromotionName = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].PromotionName");
					optionalPromotion.PromotionOptionNo = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].PromotionOptionNo");
					optionalPromotion.CanPromFee = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].CanPromFee");

					subOrder_optionalPromotions.Add(optionalPromotion);
				}
				subOrder.OptionalPromotions = subOrder_optionalPromotions;

				List<DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem> subOrder_moduleInstance = new List<DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem>();
				for (int j = 0; j < _ctx.Length("DescribePrice.SubOrders["+ i +"].ModuleInstance.Length"); j++) {
					DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem moduleInstanceItem = new DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem();
					moduleInstanceItem.ModuleCode = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].ModuleCode");
					moduleInstanceItem.ModuleId = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].ModuleId");
					moduleInstanceItem.StandPrice = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].StandPrice");
					moduleInstanceItem.PricingModule = _ctx.BooleanValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].PricingModule");
					moduleInstanceItem.ModuleName = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].ModuleName");
					moduleInstanceItem.DiscountFee = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DiscountFee");
					moduleInstanceItem.TotalProductFee = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].TotalProductFee");
					moduleInstanceItem.NeedOrderPay = _ctx.BooleanValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].NeedOrderPay");
					moduleInstanceItem.PayFee = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].PayFee");
					moduleInstanceItem.ContractActivity = _ctx.BooleanValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].ContractActivity");

					DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem.DescribePrice_DepreciateInfo1 depreciateInfo1 = new DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem.DescribePrice_DepreciateInfo1();
					depreciateInfo1.ListPrice = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DepreciateInfo.ListPrice");
					depreciateInfo1.OriginalStandAmount = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DepreciateInfo.OriginalStandAmount");
					depreciateInfo1.CheapStandAmount = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DepreciateInfo.CheapStandAmount");
					depreciateInfo1.CheapRate = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DepreciateInfo.CheapRate");
					depreciateInfo1.Differential = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DepreciateInfo.Differential");
					depreciateInfo1.DifferentialName = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DepreciateInfo.DifferentialName");
					depreciateInfo1.MonthPrice = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DepreciateInfo.MonthPrice");
					depreciateInfo1.IsContractActivity = _ctx.BooleanValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DepreciateInfo.IsContractActivity");
					depreciateInfo1.IsShow = _ctx.BooleanValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DepreciateInfo.IsShow");
					depreciateInfo1.StartTime = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DepreciateInfo.StartTime");
					moduleInstanceItem.DepreciateInfo1 = depreciateInfo1;

					List<DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem.DescribePrice_ModuleAttr> moduleInstanceItem_moduleAttrs = new List<DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem.DescribePrice_ModuleAttr>();
					for (int k = 0; k < _ctx.Length("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].ModuleAttrs.Length"); k++) {
						DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem.DescribePrice_ModuleAttr moduleAttr = new DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem.DescribePrice_ModuleAttr();
						moduleAttr.Type = _ctx.LongValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].ModuleAttrs["+ k +"].Type");
						moduleAttr._Value = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].ModuleAttrs["+ k +"].Value");
						moduleAttr.Code = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].ModuleAttrs["+ k +"].Code");
						moduleAttr.Name = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].ModuleAttrs["+ k +"].Name");

						moduleInstanceItem_moduleAttrs.Add(moduleAttr);
					}
					moduleInstanceItem.ModuleAttrs = moduleInstanceItem_moduleAttrs;

					subOrder_moduleInstance.Add(moduleInstanceItem);
				}
				subOrder.ModuleInstance = subOrder_moduleInstance;

				List<DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_PromDetail> subOrder_promDetailList = new List<DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_PromDetail>();
				for (int j = 0; j < _ctx.Length("DescribePrice.SubOrders["+ i +"].PromDetailList.Length"); j++) {
					DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_PromDetail promDetail = new DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_PromDetail();
					promDetail.PromotionName = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].PromDetailList["+ j +"].PromotionName");
					promDetail.PromotionId = _ctx.LongValue("DescribePrice.SubOrders["+ i +"].PromDetailList["+ j +"].PromotionId");
					promDetail.FinalPromFee = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].PromDetailList["+ j +"].FinalPromFee");
					promDetail.OptionCode = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].PromDetailList["+ j +"].OptionCode");
					promDetail.PromType = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].PromDetailList["+ j +"].PromType");
					promDetail.ActivityExtInfo = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].PromDetailList["+ j +"].ActivityExtInfo");
					promDetail.DerivedPromType = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].PromDetailList["+ j +"].DerivedPromType");
					promDetail.PromotionCode = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].PromDetailList["+ j +"].PromotionCode");

					subOrder_promDetailList.Add(promDetail);
				}
				subOrder.PromDetailList = subOrder_promDetailList;

				describePriceResponse_subOrders.Add(subOrder);
			}
			describePriceResponse.SubOrders = describePriceResponse_subOrders;
        
			return describePriceResponse;
        }
    }
}
