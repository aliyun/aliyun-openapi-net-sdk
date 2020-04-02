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
using Aliyun.Acs.linkedmall.Model.V20180116;

namespace Aliyun.Acs.linkedmall.Transform.V20180116
{
    public class QueryRefundApplicationDetailResponseUnmarshaller
    {
        public static QueryRefundApplicationDetailResponse Unmarshall(UnmarshallerContext context)
        {
			QueryRefundApplicationDetailResponse queryRefundApplicationDetailResponse = new QueryRefundApplicationDetailResponse();

			queryRefundApplicationDetailResponse.HttpResponse = context.HttpResponse;
			queryRefundApplicationDetailResponse.RequestId = context.StringValue("QueryRefundApplicationDetail.RequestId");
			queryRefundApplicationDetailResponse.Code = context.StringValue("QueryRefundApplicationDetail.Code");
			queryRefundApplicationDetailResponse.Message = context.StringValue("QueryRefundApplicationDetail.Message");

			QueryRefundApplicationDetailResponse.QueryRefundApplicationDetail_RefundApplicationDetail refundApplicationDetail = new QueryRefundApplicationDetailResponse.QueryRefundApplicationDetail_RefundApplicationDetail();
			refundApplicationDetail.BizClaimType = context.IntegerValue("QueryRefundApplicationDetail.RefundApplicationDetail.BizClaimType");
			refundApplicationDetail.OrderLogisticsStatus = context.IntegerValue("QueryRefundApplicationDetail.RefundApplicationDetail.OrderLogisticsStatus");
			refundApplicationDetail.DisputeStatus = context.IntegerValue("QueryRefundApplicationDetail.RefundApplicationDetail.DisputeStatus");
			refundApplicationDetail.ReturnGoodLogisticsStatus = context.IntegerValue("QueryRefundApplicationDetail.RefundApplicationDetail.ReturnGoodLogisticsStatus");
			refundApplicationDetail.LmOrderId = context.StringValue("QueryRefundApplicationDetail.RefundApplicationDetail.LmOrderId");
			refundApplicationDetail.SubLmOrderId = context.StringValue("QueryRefundApplicationDetail.RefundApplicationDetail.SubLmOrderId");
			refundApplicationDetail.DisputeType = context.IntegerValue("QueryRefundApplicationDetail.RefundApplicationDetail.DisputeType");
			refundApplicationDetail.RefundFee = context.LongValue("QueryRefundApplicationDetail.RefundApplicationDetail.RefundFee");
			refundApplicationDetail.RealRefundFee = context.LongValue("QueryRefundApplicationDetail.RefundApplicationDetail.RealRefundFee");
			refundApplicationDetail.ReturnGoodCount = context.IntegerValue("QueryRefundApplicationDetail.RefundApplicationDetail.ReturnGoodCount");
			refundApplicationDetail.DisputeDesc = context.StringValue("QueryRefundApplicationDetail.RefundApplicationDetail.DisputeDesc");
			refundApplicationDetail.SellerAgreeMsg = context.StringValue("QueryRefundApplicationDetail.RefundApplicationDetail.SellerAgreeMsg");
			refundApplicationDetail.SellerRefuseAgreementMessage = context.StringValue("QueryRefundApplicationDetail.RefundApplicationDetail.SellerRefuseAgreementMessage");
			refundApplicationDetail.ApplyDisputeDesc = context.StringValue("QueryRefundApplicationDetail.RefundApplicationDetail.ApplyDisputeDesc");
			refundApplicationDetail.DisputeCreateTime = context.StringValue("QueryRefundApplicationDetail.RefundApplicationDetail.DisputeCreateTime");
			refundApplicationDetail.DisputeEndTime = context.StringValue("QueryRefundApplicationDetail.RefundApplicationDetail.DisputeEndTime");
			refundApplicationDetail.DisputeId = context.LongValue("QueryRefundApplicationDetail.RefundApplicationDetail.DisputeId");
			refundApplicationDetail.RefunderAddress = context.StringValue("QueryRefundApplicationDetail.RefundApplicationDetail.RefunderAddress");
			refundApplicationDetail.RefunderName = context.StringValue("QueryRefundApplicationDetail.RefundApplicationDetail.RefunderName");
			refundApplicationDetail.RefunderTel = context.StringValue("QueryRefundApplicationDetail.RefundApplicationDetail.RefunderTel");
			refundApplicationDetail.RefunderZipCode = context.StringValue("QueryRefundApplicationDetail.RefundApplicationDetail.RefunderZipCode");
			refundApplicationDetail.SellerRefuseReason = context.StringValue("QueryRefundApplicationDetail.RefundApplicationDetail.SellerRefuseReason");

			QueryRefundApplicationDetailResponse.QueryRefundApplicationDetail_RefundApplicationDetail.QueryRefundApplicationDetail_MaxRefundFeeData maxRefundFeeData = new QueryRefundApplicationDetailResponse.QueryRefundApplicationDetail_RefundApplicationDetail.QueryRefundApplicationDetail_MaxRefundFeeData();
			maxRefundFeeData.MaxRefundFee = context.IntegerValue("QueryRefundApplicationDetail.RefundApplicationDetail.MaxRefundFeeData.MaxRefundFee");
			maxRefundFeeData.MinRefundFee = context.IntegerValue("QueryRefundApplicationDetail.RefundApplicationDetail.MaxRefundFeeData.MinRefundFee");
			refundApplicationDetail.MaxRefundFeeData = maxRefundFeeData;

			QueryRefundApplicationDetailResponse.QueryRefundApplicationDetail_RefundApplicationDetail.QueryRefundApplicationDetail_ApplyReasonText applyReasonText = new QueryRefundApplicationDetailResponse.QueryRefundApplicationDetail_RefundApplicationDetail.QueryRefundApplicationDetail_ApplyReasonText();
			applyReasonText.ReasonTextId = context.LongValue("QueryRefundApplicationDetail.RefundApplicationDetail.ApplyReasonText.ReasonTextId");
			applyReasonText.ReasonTips = context.StringValue("QueryRefundApplicationDetail.RefundApplicationDetail.ApplyReasonText.ReasonTips");
			refundApplicationDetail.ApplyReasonText = applyReasonText;
			queryRefundApplicationDetailResponse.RefundApplicationDetail = refundApplicationDetail;
        
			return queryRefundApplicationDetailResponse;
        }
    }
}
