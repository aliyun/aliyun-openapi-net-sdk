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
    public class CreateVirtualProductOrderResponseUnmarshaller
    {
        public static CreateVirtualProductOrderResponse Unmarshall(UnmarshallerContext context)
        {
			CreateVirtualProductOrderResponse createVirtualProductOrderResponse = new CreateVirtualProductOrderResponse();

			createVirtualProductOrderResponse.HttpResponse = context.HttpResponse;
			createVirtualProductOrderResponse.RequestId = context.StringValue("CreateVirtualProductOrder.RequestId");
			createVirtualProductOrderResponse.Code = context.StringValue("CreateVirtualProductOrder.Code");
			createVirtualProductOrderResponse.Message = context.StringValue("CreateVirtualProductOrder.Message");
			createVirtualProductOrderResponse.SubCode = context.StringValue("CreateVirtualProductOrder.SubCode");
			createVirtualProductOrderResponse.SubMessage = context.StringValue("CreateVirtualProductOrder.SubMessage");
			createVirtualProductOrderResponse.LogsId = context.StringValue("CreateVirtualProductOrder.LogsId");
			createVirtualProductOrderResponse.Success = context.BooleanValue("CreateVirtualProductOrder.Success");
			createVirtualProductOrderResponse.TotalCount = context.LongValue("CreateVirtualProductOrder.TotalCount");

			CreateVirtualProductOrderResponse.CreateVirtualProductOrder_Model model = new CreateVirtualProductOrderResponse.CreateVirtualProductOrder_Model();
			model.RedirectUrl = context.StringValue("CreateVirtualProductOrder.Model.RedirectUrl");

			List<string> model_orderIds = new List<string>();
			for (int i = 0; i < context.Length("CreateVirtualProductOrder.Model.OrderIds.Length"); i++) {
				model_orderIds.Add(context.StringValue("CreateVirtualProductOrder.Model.OrderIds["+ i +"]"));
			}
			model.OrderIds = model_orderIds;

			List<string> model_payTradeIds = new List<string>();
			for (int i = 0; i < context.Length("CreateVirtualProductOrder.Model.PayTradeIds.Length"); i++) {
				model_payTradeIds.Add(context.StringValue("CreateVirtualProductOrder.Model.PayTradeIds["+ i +"]"));
			}
			model.PayTradeIds = model_payTradeIds;

			List<CreateVirtualProductOrderResponse.CreateVirtualProductOrder_Model.CreateVirtualProductOrder_LmOrderListItem> model_lmOrderList = new List<CreateVirtualProductOrderResponse.CreateVirtualProductOrder_Model.CreateVirtualProductOrder_LmOrderListItem>();
			for (int i = 0; i < context.Length("CreateVirtualProductOrder.Model.LmOrderList.Length"); i++) {
				CreateVirtualProductOrderResponse.CreateVirtualProductOrder_Model.CreateVirtualProductOrder_LmOrderListItem lmOrderListItem = new CreateVirtualProductOrderResponse.CreateVirtualProductOrder_Model.CreateVirtualProductOrder_LmOrderListItem();
				lmOrderListItem.LmOrderId = context.StringValue("CreateVirtualProductOrder.Model.LmOrderList["+ i +"].LmOrderId");

				model_lmOrderList.Add(lmOrderListItem);
			}
			model.LmOrderList = model_lmOrderList;
			createVirtualProductOrderResponse.Model = model;
        
			return createVirtualProductOrderResponse;
        }
    }
}
