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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribePriceResponseUnmarshaller
    {
        public static DescribePriceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePriceResponse describePriceResponse = new DescribePriceResponse();

			describePriceResponse.HttpResponse = _ctx.HttpResponse;
			describePriceResponse.RequestId = _ctx.StringValue("DescribePrice.RequestId");
			describePriceResponse.TraceId = _ctx.StringValue("DescribePrice.TraceId");
			describePriceResponse.OrderParams = _ctx.StringValue("DescribePrice.OrderParams");

			DescribePriceResponse.DescribePrice_Order order = new DescribePriceResponse.DescribePrice_Order();
			order.OriginalAmount = _ctx.StringValue("DescribePrice.Order.OriginalAmount");
			order.DiscountAmount = _ctx.StringValue("DescribePrice.Order.DiscountAmount");
			order.TradeAmount = _ctx.StringValue("DescribePrice.Order.TradeAmount");
			order.Currency = _ctx.StringValue("DescribePrice.Order.Currency");
			order.ShowDiscountInfo = _ctx.BooleanValue("DescribePrice.Order.ShowDiscountInfo");
			order.OptionalPromotions = _ctx.StringValue("DescribePrice.Order.OptionalPromotions");
			order.PromDetailList = _ctx.StringValue("DescribePrice.Order.PromDetailList");
			order.StandDiscountPrice = _ctx.DoubleValue("DescribePrice.Order.StandDiscountPrice");
			order.StandPrice = _ctx.DoubleValue("DescribePrice.Order.StandPrice");
			order.ContractActivity = _ctx.BooleanValue("DescribePrice.Order.ContractActivity");
			order.Code = _ctx.StringValue("DescribePrice.Order.Code");
			order.Message = _ctx.StringValue("DescribePrice.Order.Message");
			order.IsContractActivity = _ctx.BooleanValue("DescribePrice.Order.IsContractActivity");

			List<string> order_ruleIds4 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribePrice.Order.RuleIds.Length"); i++) {
				order_ruleIds4.Add(_ctx.StringValue("DescribePrice.Order.RuleIds["+ i +"]"));
			}
			order.RuleIds4 = order_ruleIds4;

			DescribePriceResponse.DescribePrice_Order.DescribePrice_DepreciateInfo5 depreciateInfo5 = new DescribePriceResponse.DescribePrice_Order.DescribePrice_DepreciateInfo5();
			depreciateInfo5.ListPrice = _ctx.DoubleValue("DescribePrice.Order.DepreciateInfo.ListPrice");
			depreciateInfo5.OriginalStandAmount = _ctx.DoubleValue("DescribePrice.Order.DepreciateInfo.OriginalStandAmount");
			depreciateInfo5.CheapStandAmount = _ctx.DoubleValue("DescribePrice.Order.DepreciateInfo.CheapStandAmount");
			depreciateInfo5.CheapRate = _ctx.DoubleValue("DescribePrice.Order.DepreciateInfo.CheapRate");
			depreciateInfo5.Differential = _ctx.DoubleValue("DescribePrice.Order.DepreciateInfo.Differential");
			depreciateInfo5.DifferentialName = _ctx.StringValue("DescribePrice.Order.DepreciateInfo.DifferentialName");
			depreciateInfo5.MonthPrice = _ctx.DoubleValue("DescribePrice.Order.DepreciateInfo.MonthPrice");
			depreciateInfo5.IsContractActivity = _ctx.BooleanValue("DescribePrice.Order.DepreciateInfo.IsContractActivity");
			depreciateInfo5.IsShow = _ctx.StringValue("DescribePrice.Order.DepreciateInfo.IsShow");

			DescribePriceResponse.DescribePrice_Order.DescribePrice_DepreciateInfo5.DescribePrice_ContractActivity8 contractActivity8 = new DescribePriceResponse.DescribePrice_Order.DescribePrice_DepreciateInfo5.DescribePrice_ContractActivity8();
			contractActivity8.FinalPromFee = _ctx.DoubleValue("DescribePrice.Order.DepreciateInfo.ContractActivity.FinalPromFee");
			contractActivity8.FinalFee = _ctx.DoubleValue("DescribePrice.Order.DepreciateInfo.ContractActivity.FinalFee");
			contractActivity8.ProdFee = _ctx.DoubleValue("DescribePrice.Order.DepreciateInfo.ContractActivity.ProdFee");
			contractActivity8.ActivityId = _ctx.LongValue("DescribePrice.Order.DepreciateInfo.ContractActivity.ActivityId");
			contractActivity8.OptionCode = _ctx.StringValue("DescribePrice.Order.DepreciateInfo.ContractActivity.OptionCode");
			contractActivity8.ActivityName = _ctx.StringValue("DescribePrice.Order.DepreciateInfo.ContractActivity.ActivityName");

			List<string> contractActivity8_optionIds9 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribePrice.Order.DepreciateInfo.ContractActivity.OptionIds.Length"); i++) {
				contractActivity8_optionIds9.Add(_ctx.StringValue("DescribePrice.Order.DepreciateInfo.ContractActivity.OptionIds["+ i +"]"));
			}
			contractActivity8.OptionIds9 = contractActivity8_optionIds9;
			depreciateInfo5.ContractActivity8 = contractActivity8;
			order.DepreciateInfo5 = depreciateInfo5;

			List<DescribePriceResponse.DescribePrice_Order.DescribePrice_Coupon> order_coupons = new List<DescribePriceResponse.DescribePrice_Order.DescribePrice_Coupon>();
			for (int i = 0; i < _ctx.Length("DescribePrice.Order.Coupons.Length"); i++) {
				DescribePriceResponse.DescribePrice_Order.DescribePrice_Coupon coupon = new DescribePriceResponse.DescribePrice_Order.DescribePrice_Coupon();
				coupon.Description = _ctx.StringValue("DescribePrice.Order.Coupons["+ i +"].Description");
				coupon.IsSelected = _ctx.StringValue("DescribePrice.Order.Coupons["+ i +"].IsSelected");
				coupon.CouponNo = _ctx.StringValue("DescribePrice.Order.Coupons["+ i +"].CouponNo");
				coupon.Name = _ctx.StringValue("DescribePrice.Order.Coupons["+ i +"].Name");
				coupon.CanPromFee = _ctx.DoubleValue("DescribePrice.Order.Coupons["+ i +"].CanPromFee");
				coupon.PromotionOptionCode = _ctx.StringValue("DescribePrice.Order.Coupons["+ i +"].PromotionOptionCode");
				coupon.LackForPriceBreak = _ctx.DoubleValue("DescribePrice.Order.Coupons["+ i +"].LackForPriceBreak");
				coupon.PriceBreakThreshold = _ctx.DoubleValue("DescribePrice.Order.Coupons["+ i +"].PriceBreakThreshold");
				coupon.PriceBreakReduceValue = _ctx.DoubleValue("DescribePrice.Order.Coupons["+ i +"].PriceBreakReduceValue");
				coupon.OptionCode = _ctx.StringValue("DescribePrice.Order.Coupons["+ i +"].OptionCode");
				coupon.ActivityCategory = _ctx.StringValue("DescribePrice.Order.Coupons["+ i +"].ActivityCategory");

				List<string> coupon_promotionRuleIdList6 = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribePrice.Order.Coupons["+ i +"].PromotionRuleIdList.Length"); j++) {
					coupon_promotionRuleIdList6.Add(_ctx.StringValue("DescribePrice.Order.Coupons["+ i +"].PromotionRuleIdList["+ j +"]"));
				}
				coupon.PromotionRuleIdList6 = coupon_promotionRuleIdList6;

				List<string> coupon_targetArticleItemCodes7 = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribePrice.Order.Coupons["+ i +"].TargetArticleItemCodes.Length"); j++) {
					coupon_targetArticleItemCodes7.Add(_ctx.StringValue("DescribePrice.Order.Coupons["+ i +"].TargetArticleItemCodes["+ j +"]"));
				}
				coupon.TargetArticleItemCodes7 = coupon_targetArticleItemCodes7;

				order_coupons.Add(coupon);
			}
			order.Coupons = order_coupons;
			describePriceResponse.Order = order;

			List<DescribePriceResponse.DescribePrice_SubOrder> describePriceResponse_subOrders = new List<DescribePriceResponse.DescribePrice_SubOrder>();
			for (int i = 0; i < _ctx.Length("DescribePrice.SubOrders.Length"); i++) {
				DescribePriceResponse.DescribePrice_SubOrder subOrder = new DescribePriceResponse.DescribePrice_SubOrder();
				subOrder.OriginalAmount = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].OriginalAmount");
				subOrder.DiscountAmount = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].DiscountAmount");
				subOrder.TradeAmount = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].TradeAmount");
				subOrder.InstanceId = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].InstanceId");
				subOrder.IsNewOfficialActivity = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].IsNewOfficialActivity");
				subOrder.ContractActivity = _ctx.BooleanValue("DescribePrice.SubOrders["+ i +"].ContractActivity");
				subOrder.StandDiscountPrice = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].StandDiscountPrice");
				subOrder.StandPrice = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].StandPrice");
				subOrder.IsContractActivity = _ctx.BooleanValue("DescribePrice.SubOrders["+ i +"].IsContractActivity");

				List<string> subOrder_ruleIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribePrice.SubOrders["+ i +"].RuleIds.Length"); j++) {
					subOrder_ruleIds.Add(_ctx.StringValue("DescribePrice.SubOrders["+ i +"].RuleIds["+ j +"]"));
				}
				subOrder.RuleIds = subOrder_ruleIds;

				DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_DepreciateInfo depreciateInfo = new DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_DepreciateInfo();
				depreciateInfo.ListPrice = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.ListPrice");
				depreciateInfo.OriginalStandAmount = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.OriginalStandAmount");
				depreciateInfo.CheapStandAmount = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.CheapStandAmount");
				depreciateInfo.CheapRate = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.CheapRate");
				depreciateInfo.Differential = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.Differential");
				depreciateInfo.DifferentialName = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.DifferentialName");
				depreciateInfo.MonthPrice = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.MonthPrice");
				depreciateInfo.IsContractActivity = _ctx.BooleanValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.IsContractActivity");
				depreciateInfo.IsShow = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].DepreciateInfo.IsShow");
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

				List<DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem> subOrder_moduleInstance = new List<DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem>();
				for (int j = 0; j < _ctx.Length("DescribePrice.SubOrders["+ i +"].ModuleInstance.Length"); j++) {
					DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem moduleInstanceItem = new DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem();
					moduleInstanceItem.CycleFee = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].CycleFee");
					moduleInstanceItem.DiscountFee = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DiscountFee");
					moduleInstanceItem.ModuleCode = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].ModuleCode");
					moduleInstanceItem.ModuleId = _ctx.LongValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].ModuleId");
					moduleInstanceItem.ModuleName = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].ModuleName");
					moduleInstanceItem.NeedOrderPay = _ctx.BooleanValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].NeedOrderPay");
					moduleInstanceItem.PayFee = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].PayFee");
					moduleInstanceItem.PricingModule = _ctx.BooleanValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].PricingModule");
					moduleInstanceItem.StandPrice = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].StandPrice");
					moduleInstanceItem.TotalProductFee = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].TotalProductFee");
					moduleInstanceItem.ContractActivity = _ctx.BooleanValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].ContractActivity");
					moduleInstanceItem.StandDiscountPrice = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].StandDiscountPrice");

					DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem.DescribePrice_DepreciateInfo1 depreciateInfo1 = new DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem.DescribePrice_DepreciateInfo1();
					depreciateInfo1.ListPrice = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DepreciateInfo.ListPrice");
					depreciateInfo1.OriginalStandAmount = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DepreciateInfo.OriginalStandAmount");
					depreciateInfo1.CheapStandAmount = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DepreciateInfo.CheapStandAmount");
					depreciateInfo1.CheapRate = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DepreciateInfo.CheapRate");
					depreciateInfo1.Differential = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DepreciateInfo.Differential");
					depreciateInfo1.DifferentialName = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DepreciateInfo.DifferentialName");
					depreciateInfo1.MonthPrice = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DepreciateInfo.MonthPrice");
					depreciateInfo1.IsContractActivity = _ctx.BooleanValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DepreciateInfo.IsContractActivity");
					depreciateInfo1.IsShow = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].DepreciateInfo.IsShow");
					moduleInstanceItem.DepreciateInfo1 = depreciateInfo1;

					List<DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem.DescribePrice_PromDetail> moduleInstanceItem_promDetailList2 = new List<DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem.DescribePrice_PromDetail>();
					for (int k = 0; k < _ctx.Length("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].PromDetailList.Length"); k++) {
						DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem.DescribePrice_PromDetail promDetail = new DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem.DescribePrice_PromDetail();
						promDetail.FinalPromFee = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].PromDetailList["+ k +"].FinalPromFee");
						promDetail.ActivityExtInfo = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].PromDetailList["+ k +"].ActivityExtInfo");
						promDetail.OptionCode = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].PromDetailList["+ k +"].OptionCode");
						promDetail.PromType = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].PromDetailList["+ k +"].PromType");
						promDetail.PromotionId = _ctx.LongValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].PromDetailList["+ k +"].PromotionId");
						promDetail.PromotionName = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].PromDetailList["+ k +"].PromotionName");
						promDetail.PromotionCode = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].PromDetailList["+ k +"].PromotionCode");
						promDetail.DerivedPromType = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].PromDetailList["+ k +"].DerivedPromType");

						moduleInstanceItem_promDetailList2.Add(promDetail);
					}
					moduleInstanceItem.PromDetailList2 = moduleInstanceItem_promDetailList2;

					List<DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem.DescribePrice_ModuleAttr> moduleInstanceItem_moduleAttrs = new List<DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem.DescribePrice_ModuleAttr>();
					for (int k = 0; k < _ctx.Length("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].ModuleAttrs.Length"); k++) {
						DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem.DescribePrice_ModuleAttr moduleAttr = new DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_ModuleInstanceItem.DescribePrice_ModuleAttr();
						moduleAttr.Code = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].ModuleAttrs["+ k +"].Code");
						moduleAttr.Name = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].ModuleAttrs["+ k +"].Name");
						moduleAttr.Type = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].ModuleAttrs["+ k +"].Type");
						moduleAttr._Value = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].ModuleInstance["+ j +"].ModuleAttrs["+ k +"].Value");

						moduleInstanceItem_moduleAttrs.Add(moduleAttr);
					}
					moduleInstanceItem.ModuleAttrs = moduleInstanceItem_moduleAttrs;

					subOrder_moduleInstance.Add(moduleInstanceItem);
				}
				subOrder.ModuleInstance = subOrder_moduleInstance;

				List<DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_OptionalPromotion> subOrder_optionalPromotions = new List<DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_OptionalPromotion>();
				for (int j = 0; j < _ctx.Length("DescribePrice.SubOrders["+ i +"].OptionalPromotions.Length"); j++) {
					DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_OptionalPromotion optionalPromotion = new DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_OptionalPromotion();
					optionalPromotion.ActivityCategory = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].ActivityCategory");
					optionalPromotion.ActivityExtInfo = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].ActivityExtInfo");
					optionalPromotion.CanPromFee = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].CanPromFee");
					optionalPromotion.OptionCode = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].OptionCode");
					optionalPromotion.PromotionName = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].PromotionName");
					optionalPromotion.PromotionOptionNo = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].PromotionOptionNo");
					optionalPromotion.Selected = _ctx.BooleanValue("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].Selected");
					optionalPromotion.Show = _ctx.BooleanValue("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].Show");

					List<string> optionalPromotion_targetArticleItemCodes = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].TargetArticleItemCodes.Length"); k++) {
						optionalPromotion_targetArticleItemCodes.Add(_ctx.StringValue("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].TargetArticleItemCodes["+ k +"]"));
					}
					optionalPromotion.TargetArticleItemCodes = optionalPromotion_targetArticleItemCodes;

					List<string> optionalPromotion_promotionRuleIdList = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].PromotionRuleIdList.Length"); k++) {
						optionalPromotion_promotionRuleIdList.Add(_ctx.StringValue("DescribePrice.SubOrders["+ i +"].OptionalPromotions["+ j +"].PromotionRuleIdList["+ k +"]"));
					}
					optionalPromotion.PromotionRuleIdList = optionalPromotion_promotionRuleIdList;

					subOrder_optionalPromotions.Add(optionalPromotion);
				}
				subOrder.OptionalPromotions = subOrder_optionalPromotions;

				List<DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_PromDetail3> subOrder_promDetailList = new List<DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_PromDetail3>();
				for (int j = 0; j < _ctx.Length("DescribePrice.SubOrders["+ i +"].PromDetailList.Length"); j++) {
					DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_PromDetail3 promDetail3 = new DescribePriceResponse.DescribePrice_SubOrder.DescribePrice_PromDetail3();
					promDetail3.FinalPromFee = _ctx.DoubleValue("DescribePrice.SubOrders["+ i +"].PromDetailList["+ j +"].FinalPromFee");
					promDetail3.ActivityExtInfo = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].PromDetailList["+ j +"].ActivityExtInfo");
					promDetail3.OptionCode = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].PromDetailList["+ j +"].OptionCode");
					promDetail3.PromType = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].PromDetailList["+ j +"].PromType");
					promDetail3.PromotionId = _ctx.LongValue("DescribePrice.SubOrders["+ i +"].PromDetailList["+ j +"].PromotionId");
					promDetail3.PromotionName = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].PromDetailList["+ j +"].PromotionName");
					promDetail3.PromotionCode = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].PromDetailList["+ j +"].PromotionCode");
					promDetail3.DerivedPromType = _ctx.StringValue("DescribePrice.SubOrders["+ i +"].PromDetailList["+ j +"].DerivedPromType");

					subOrder_promDetailList.Add(promDetail3);
				}
				subOrder.PromDetailList = subOrder_promDetailList;

				describePriceResponse_subOrders.Add(subOrder);
			}
			describePriceResponse.SubOrders = describePriceResponse_subOrders;

			List<DescribePriceResponse.DescribePrice_Rule> describePriceResponse_rules = new List<DescribePriceResponse.DescribePrice_Rule>();
			for (int i = 0; i < _ctx.Length("DescribePrice.Rules.Length"); i++) {
				DescribePriceResponse.DescribePrice_Rule rule = new DescribePriceResponse.DescribePrice_Rule();
				rule.RuleDescId = _ctx.LongValue("DescribePrice.Rules["+ i +"].RuleDescId");
				rule.Title = _ctx.StringValue("DescribePrice.Rules["+ i +"].Title");
				rule.Name = _ctx.StringValue("DescribePrice.Rules["+ i +"].Name");

				describePriceResponse_rules.Add(rule);
			}
			describePriceResponse.Rules = describePriceResponse_rules;
        
			return describePriceResponse;
        }
    }
}
