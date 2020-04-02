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
    public class InitApplyRefundResponseUnmarshaller
    {
        public static InitApplyRefundResponse Unmarshall(UnmarshallerContext context)
        {
			InitApplyRefundResponse initApplyRefundResponse = new InitApplyRefundResponse();

			initApplyRefundResponse.HttpResponse = context.HttpResponse;
			initApplyRefundResponse.RequestId = context.StringValue("InitApplyRefund.RequestId");
			initApplyRefundResponse.Code = context.StringValue("InitApplyRefund.Code");
			initApplyRefundResponse.Message = context.StringValue("InitApplyRefund.Message");
			initApplyRefundResponse.SubLmOrderId = context.StringValue("InitApplyRefund.SubLmOrderId");

			InitApplyRefundResponse.InitApplyRefund_InitApplyRefundData initApplyRefundData = new InitApplyRefundResponse.InitApplyRefund_InitApplyRefundData();
			initApplyRefundData.BizClaimType = context.IntegerValue("InitApplyRefund.InitApplyRefundData.BizClaimType");
			initApplyRefundData.MainOrderRefund = context.BooleanValue("InitApplyRefund.InitApplyRefundData.MainOrderRefund");

			InitApplyRefundResponse.InitApplyRefund_InitApplyRefundData.InitApplyRefund_MaxRefundFeeData maxRefundFeeData = new InitApplyRefundResponse.InitApplyRefund_InitApplyRefundData.InitApplyRefund_MaxRefundFeeData();
			maxRefundFeeData.MaxRefundFee = context.IntegerValue("InitApplyRefund.InitApplyRefundData.MaxRefundFeeData.MaxRefundFee");
			maxRefundFeeData.MinRefundFee = context.IntegerValue("InitApplyRefund.InitApplyRefundData.MaxRefundFeeData.MinRefundFee");
			initApplyRefundData.MaxRefundFeeData = maxRefundFeeData;

			List<InitApplyRefundResponse.InitApplyRefund_InitApplyRefundData.InitApplyRefund_RefundReasonListItem> initApplyRefundData_refundReasonList = new List<InitApplyRefundResponse.InitApplyRefund_InitApplyRefundData.InitApplyRefund_RefundReasonListItem>();
			for (int i = 0; i < context.Length("InitApplyRefund.InitApplyRefundData.RefundReasonList.Length"); i++) {
				InitApplyRefundResponse.InitApplyRefund_InitApplyRefundData.InitApplyRefund_RefundReasonListItem refundReasonListItem = new InitApplyRefundResponse.InitApplyRefund_InitApplyRefundData.InitApplyRefund_RefundReasonListItem();
				refundReasonListItem.ReasonTextId = context.LongValue("InitApplyRefund.InitApplyRefundData.RefundReasonList["+ i +"].ReasonTextId");
				refundReasonListItem.ReasonTips = context.StringValue("InitApplyRefund.InitApplyRefundData.RefundReasonList["+ i +"].ReasonTips");
				refundReasonListItem.ProofRequired = context.BooleanValue("InitApplyRefund.InitApplyRefundData.RefundReasonList["+ i +"].ProofRequired");
				refundReasonListItem.RefundDescRequired = context.BooleanValue("InitApplyRefund.InitApplyRefundData.RefundReasonList["+ i +"].RefundDescRequired");

				initApplyRefundData_refundReasonList.Add(refundReasonListItem);
			}
			initApplyRefundData.RefundReasonList = initApplyRefundData_refundReasonList;
			initApplyRefundResponse.InitApplyRefundData = initApplyRefundData;
        
			return initApplyRefundResponse;
        }
    }
}
