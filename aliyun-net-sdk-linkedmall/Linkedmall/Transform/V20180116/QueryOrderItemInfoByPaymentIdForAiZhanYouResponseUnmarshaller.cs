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
    public class QueryOrderItemInfoByPaymentIdForAiZhanYouResponseUnmarshaller
    {
        public static QueryOrderItemInfoByPaymentIdForAiZhanYouResponse Unmarshall(UnmarshallerContext context)
        {
			QueryOrderItemInfoByPaymentIdForAiZhanYouResponse queryOrderItemInfoByPaymentIdForAiZhanYouResponse = new QueryOrderItemInfoByPaymentIdForAiZhanYouResponse();

			queryOrderItemInfoByPaymentIdForAiZhanYouResponse.HttpResponse = context.HttpResponse;
			queryOrderItemInfoByPaymentIdForAiZhanYouResponse.RequestId = context.StringValue("QueryOrderItemInfoByPaymentIdForAiZhanYou.RequestId");
			queryOrderItemInfoByPaymentIdForAiZhanYouResponse.Code = context.StringValue("QueryOrderItemInfoByPaymentIdForAiZhanYou.Code");
			queryOrderItemInfoByPaymentIdForAiZhanYouResponse.Message = context.StringValue("QueryOrderItemInfoByPaymentIdForAiZhanYou.Message");

			List<QueryOrderItemInfoByPaymentIdForAiZhanYouResponse.QueryOrderItemInfoByPaymentIdForAiZhanYou_LmOrderListItem> queryOrderItemInfoByPaymentIdForAiZhanYouResponse_lmOrderList = new List<QueryOrderItemInfoByPaymentIdForAiZhanYouResponse.QueryOrderItemInfoByPaymentIdForAiZhanYou_LmOrderListItem>();
			for (int i = 0; i < context.Length("QueryOrderItemInfoByPaymentIdForAiZhanYou.LmOrderList.Length"); i++) {
				QueryOrderItemInfoByPaymentIdForAiZhanYouResponse.QueryOrderItemInfoByPaymentIdForAiZhanYou_LmOrderListItem lmOrderListItem = new QueryOrderItemInfoByPaymentIdForAiZhanYouResponse.QueryOrderItemInfoByPaymentIdForAiZhanYou_LmOrderListItem();
				lmOrderListItem.ItemName = context.StringValue("QueryOrderItemInfoByPaymentIdForAiZhanYou.LmOrderList["+ i +"].ItemName");
				lmOrderListItem.LmOrderId = context.LongValue("QueryOrderItemInfoByPaymentIdForAiZhanYou.LmOrderList["+ i +"].LmOrderId");
				lmOrderListItem.SkuId = context.LongValue("QueryOrderItemInfoByPaymentIdForAiZhanYou.LmOrderList["+ i +"].SkuId");
				lmOrderListItem.SkuName = context.StringValue("QueryOrderItemInfoByPaymentIdForAiZhanYou.LmOrderList["+ i +"].SkuName");
				lmOrderListItem.ItemId = context.LongValue("QueryOrderItemInfoByPaymentIdForAiZhanYou.LmOrderList["+ i +"].ItemId");
				lmOrderListItem.LmItemId = context.StringValue("QueryOrderItemInfoByPaymentIdForAiZhanYou.LmOrderList["+ i +"].LmItemId");

				queryOrderItemInfoByPaymentIdForAiZhanYouResponse_lmOrderList.Add(lmOrderListItem);
			}
			queryOrderItemInfoByPaymentIdForAiZhanYouResponse.LmOrderList = queryOrderItemInfoByPaymentIdForAiZhanYouResponse_lmOrderList;
        
			return queryOrderItemInfoByPaymentIdForAiZhanYouResponse;
        }
    }
}
