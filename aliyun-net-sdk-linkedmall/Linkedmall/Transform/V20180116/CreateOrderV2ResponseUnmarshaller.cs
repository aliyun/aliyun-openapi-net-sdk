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
    public class CreateOrderV2ResponseUnmarshaller
    {
        public static CreateOrderV2Response Unmarshall(UnmarshallerContext context)
        {
			CreateOrderV2Response createOrderV2Response = new CreateOrderV2Response();

			createOrderV2Response.HttpResponse = context.HttpResponse;
			createOrderV2Response.RequestId = context.StringValue("CreateOrderV2.RequestId");
			createOrderV2Response.Code = context.StringValue("CreateOrderV2.Code");
			createOrderV2Response.Message = context.StringValue("CreateOrderV2.Message");
			createOrderV2Response.SubCode = context.StringValue("CreateOrderV2.SubCode");
			createOrderV2Response.SubMessage = context.StringValue("CreateOrderV2.SubMessage");
			createOrderV2Response.LogsId = context.StringValue("CreateOrderV2.LogsId");
			createOrderV2Response.Success = context.BooleanValue("CreateOrderV2.Success");
			createOrderV2Response.TotalCount = context.LongValue("CreateOrderV2.TotalCount");

			CreateOrderV2Response.CreateOrderV2_Model model = new CreateOrderV2Response.CreateOrderV2_Model();
			model.RedirectUrl = context.StringValue("CreateOrderV2.Model.RedirectUrl");

			List<string> model_orderIds = new List<string>();
			for (int i = 0; i < context.Length("CreateOrderV2.Model.OrderIds.Length"); i++) {
				model_orderIds.Add(context.StringValue("CreateOrderV2.Model.OrderIds["+ i +"]"));
			}
			model.OrderIds = model_orderIds;

			List<string> model_payTradeIds = new List<string>();
			for (int i = 0; i < context.Length("CreateOrderV2.Model.PayTradeIds.Length"); i++) {
				model_payTradeIds.Add(context.StringValue("CreateOrderV2.Model.PayTradeIds["+ i +"]"));
			}
			model.PayTradeIds = model_payTradeIds;

			List<CreateOrderV2Response.CreateOrderV2_Model.CreateOrderV2_LmOrderListItem> model_lmOrderList = new List<CreateOrderV2Response.CreateOrderV2_Model.CreateOrderV2_LmOrderListItem>();
			for (int i = 0; i < context.Length("CreateOrderV2.Model.LmOrderList.Length"); i++) {
				CreateOrderV2Response.CreateOrderV2_Model.CreateOrderV2_LmOrderListItem lmOrderListItem = new CreateOrderV2Response.CreateOrderV2_Model.CreateOrderV2_LmOrderListItem();
				lmOrderListItem.LmOrderId = context.StringValue("CreateOrderV2.Model.LmOrderList["+ i +"].LmOrderId");

				model_lmOrderList.Add(lmOrderListItem);
			}
			model.LmOrderList = model_lmOrderList;
			createOrderV2Response.Model = model;
        
			return createOrderV2Response;
        }
    }
}
