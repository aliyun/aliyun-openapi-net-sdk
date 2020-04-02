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
    public class CreateOrderResponseUnmarshaller
    {
        public static CreateOrderResponse Unmarshall(UnmarshallerContext context)
        {
			CreateOrderResponse createOrderResponse = new CreateOrderResponse();

			createOrderResponse.HttpResponse = context.HttpResponse;
			createOrderResponse.RequestId = context.StringValue("CreateOrder.RequestId");
			createOrderResponse.Code = context.StringValue("CreateOrder.Code");
			createOrderResponse.Message = context.StringValue("CreateOrder.Message");
			createOrderResponse.SubCode = context.StringValue("CreateOrder.SubCode");
			createOrderResponse.SubMessage = context.StringValue("CreateOrder.SubMessage");
			createOrderResponse.LogsId = context.StringValue("CreateOrder.LogsId");
			createOrderResponse.Success = context.BooleanValue("CreateOrder.Success");
			createOrderResponse.TotalCount = context.LongValue("CreateOrder.TotalCount");

			CreateOrderResponse.CreateOrder_Model model = new CreateOrderResponse.CreateOrder_Model();
			model.RedirectUrl = context.StringValue("CreateOrder.Model.RedirectUrl");

			List<string> model_orderIds = new List<string>();
			for (int i = 0; i < context.Length("CreateOrder.Model.OrderIds.Length"); i++) {
				model_orderIds.Add(context.StringValue("CreateOrder.Model.OrderIds["+ i +"]"));
			}
			model.OrderIds = model_orderIds;

			List<string> model_payTradeIds = new List<string>();
			for (int i = 0; i < context.Length("CreateOrder.Model.PayTradeIds.Length"); i++) {
				model_payTradeIds.Add(context.StringValue("CreateOrder.Model.PayTradeIds["+ i +"]"));
			}
			model.PayTradeIds = model_payTradeIds;

			List<CreateOrderResponse.CreateOrder_Model.CreateOrder_LmOrderListItem> model_lmOrderList = new List<CreateOrderResponse.CreateOrder_Model.CreateOrder_LmOrderListItem>();
			for (int i = 0; i < context.Length("CreateOrder.Model.LmOrderList.Length"); i++) {
				CreateOrderResponse.CreateOrder_Model.CreateOrder_LmOrderListItem lmOrderListItem = new CreateOrderResponse.CreateOrder_Model.CreateOrder_LmOrderListItem();
				lmOrderListItem.LmOrderId = context.StringValue("CreateOrder.Model.LmOrderList["+ i +"].LmOrderId");

				model_lmOrderList.Add(lmOrderListItem);
			}
			model.LmOrderList = model_lmOrderList;
			createOrderResponse.Model = model;
        
			return createOrderResponse;
        }
    }
}
