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
    public class EnableOrderResponseUnmarshaller
    {
        public static EnableOrderResponse Unmarshall(UnmarshallerContext context)
        {
			EnableOrderResponse enableOrderResponse = new EnableOrderResponse();

			enableOrderResponse.HttpResponse = context.HttpResponse;
			enableOrderResponse.RequestId = context.StringValue("EnableOrder.RequestId");
			enableOrderResponse.Code = context.StringValue("EnableOrder.Code");
			enableOrderResponse.Message = context.StringValue("EnableOrder.Message");
			enableOrderResponse.SubCode = context.StringValue("EnableOrder.SubCode");
			enableOrderResponse.SubMessage = context.StringValue("EnableOrder.SubMessage");
			enableOrderResponse.LogsId = context.StringValue("EnableOrder.LogsId");
			enableOrderResponse.Success = context.BooleanValue("EnableOrder.Success");
			enableOrderResponse.TotalCount = context.LongValue("EnableOrder.TotalCount");

			EnableOrderResponse.EnableOrder_Model model = new EnableOrderResponse.EnableOrder_Model();
			model.RedirectUrl = context.StringValue("EnableOrder.Model.RedirectUrl");

			List<string> model_orderIds = new List<string>();
			for (int i = 0; i < context.Length("EnableOrder.Model.OrderIds.Length"); i++) {
				model_orderIds.Add(context.StringValue("EnableOrder.Model.OrderIds["+ i +"]"));
			}
			model.OrderIds = model_orderIds;

			List<string> model_payTradeIds = new List<string>();
			for (int i = 0; i < context.Length("EnableOrder.Model.PayTradeIds.Length"); i++) {
				model_payTradeIds.Add(context.StringValue("EnableOrder.Model.PayTradeIds["+ i +"]"));
			}
			model.PayTradeIds = model_payTradeIds;

			List<EnableOrderResponse.EnableOrder_Model.EnableOrder_LmOrderListItem> model_lmOrderList = new List<EnableOrderResponse.EnableOrder_Model.EnableOrder_LmOrderListItem>();
			for (int i = 0; i < context.Length("EnableOrder.Model.LmOrderList.Length"); i++) {
				EnableOrderResponse.EnableOrder_Model.EnableOrder_LmOrderListItem lmOrderListItem = new EnableOrderResponse.EnableOrder_Model.EnableOrder_LmOrderListItem();
				lmOrderListItem.LmOrderId = context.StringValue("EnableOrder.Model.LmOrderList["+ i +"].LmOrderId");

				model_lmOrderList.Add(lmOrderListItem);
			}
			model.LmOrderList = model_lmOrderList;
			enableOrderResponse.Model = model;
        
			return enableOrderResponse;
        }
    }
}
