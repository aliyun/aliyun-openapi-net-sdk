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
    public class RenderOrderResponseUnmarshaller
    {
        public static RenderOrderResponse Unmarshall(UnmarshallerContext context)
        {
			RenderOrderResponse renderOrderResponse = new RenderOrderResponse();

			renderOrderResponse.HttpResponse = context.HttpResponse;
			renderOrderResponse.RequestId = context.StringValue("RenderOrder.RequestId");
			renderOrderResponse.Code = context.StringValue("RenderOrder.Code");
			renderOrderResponse.Message = context.StringValue("RenderOrder.Message");
			renderOrderResponse.SubCode = context.StringValue("RenderOrder.SubCode");
			renderOrderResponse.SubMessage = context.StringValue("RenderOrder.SubMessage");
			renderOrderResponse.LogsId = context.StringValue("RenderOrder.LogsId");
			renderOrderResponse.Success = context.BooleanValue("RenderOrder.Success");
			renderOrderResponse.TotalCount = context.LongValue("RenderOrder.TotalCount");

			RenderOrderResponse.RenderOrder_Model model = new RenderOrderResponse.RenderOrder_Model();

			List<RenderOrderResponse.RenderOrder_Model.RenderOrder_RenderOrderInfosItem> model_renderOrderInfos = new List<RenderOrderResponse.RenderOrder_Model.RenderOrder_RenderOrderInfosItem>();
			for (int i = 0; i < context.Length("RenderOrder.Model.RenderOrderInfos.Length"); i++) {
				RenderOrderResponse.RenderOrder_Model.RenderOrder_RenderOrderInfosItem renderOrderInfosItem = new RenderOrderResponse.RenderOrder_Model.RenderOrder_RenderOrderInfosItem();
				renderOrderInfosItem.ExtInfo = context.StringValue("RenderOrder.Model.RenderOrderInfos["+ i +"].ExtInfo");

				List<RenderOrderResponse.RenderOrder_Model.RenderOrder_RenderOrderInfosItem.RenderOrder_LmItemInfosItem> renderOrderInfosItem_lmItemInfos = new List<RenderOrderResponse.RenderOrder_Model.RenderOrder_RenderOrderInfosItem.RenderOrder_LmItemInfosItem>();
				for (int j = 0; j < context.Length("RenderOrder.Model.RenderOrderInfos["+ i +"].LmItemInfos.Length"); j++) {
					RenderOrderResponse.RenderOrder_Model.RenderOrder_RenderOrderInfosItem.RenderOrder_LmItemInfosItem lmItemInfosItem = new RenderOrderResponse.RenderOrder_Model.RenderOrder_RenderOrderInfosItem.RenderOrder_LmItemInfosItem();
					lmItemInfosItem.ItemId = context.LongValue("RenderOrder.Model.RenderOrderInfos["+ i +"].LmItemInfos["+ j +"].ItemId");
					lmItemInfosItem.SkuId = context.LongValue("RenderOrder.Model.RenderOrderInfos["+ i +"].LmItemInfos["+ j +"].SkuId");
					lmItemInfosItem.Quantity = context.IntegerValue("RenderOrder.Model.RenderOrderInfos["+ i +"].LmItemInfos["+ j +"].Quantity");
					lmItemInfosItem.CanSell = context.BooleanValue("RenderOrder.Model.RenderOrderInfos["+ i +"].LmItemInfos["+ j +"].CanSell");
					lmItemInfosItem.Message = context.StringValue("RenderOrder.Model.RenderOrderInfos["+ i +"].LmItemInfos["+ j +"].Message");
					lmItemInfosItem.ItemName = context.StringValue("RenderOrder.Model.RenderOrderInfos["+ i +"].LmItemInfos["+ j +"].ItemName");
					lmItemInfosItem.SkuName = context.StringValue("RenderOrder.Model.RenderOrderInfos["+ i +"].LmItemInfos["+ j +"].SkuName");
					lmItemInfosItem.LmItemId = context.StringValue("RenderOrder.Model.RenderOrderInfos["+ i +"].LmItemInfos["+ j +"].LmItemId");
					lmItemInfosItem.SellerId = context.LongValue("RenderOrder.Model.RenderOrderInfos["+ i +"].LmItemInfos["+ j +"].SellerId");
					lmItemInfosItem.SellerNick = context.StringValue("RenderOrder.Model.RenderOrderInfos["+ i +"].LmItemInfos["+ j +"].SellerNick");
					lmItemInfosItem.Cash = context.LongValue("RenderOrder.Model.RenderOrderInfos["+ i +"].LmItemInfos["+ j +"].Cash");
					lmItemInfosItem.Points = context.LongValue("RenderOrder.Model.RenderOrderInfos["+ i +"].LmItemInfos["+ j +"].Points");
					lmItemInfosItem.ActualPrice = context.LongValue("RenderOrder.Model.RenderOrderInfos["+ i +"].LmItemInfos["+ j +"].ActualPrice");
					lmItemInfosItem.ItemPicUrl = context.StringValue("RenderOrder.Model.RenderOrderInfos["+ i +"].LmItemInfos["+ j +"].ItemPicUrl");
					lmItemInfosItem.Message1 = context.StringValue("RenderOrder.Model.RenderOrderInfos["+ i +"].LmItemInfos["+ j +"].Message");

					renderOrderInfosItem_lmItemInfos.Add(lmItemInfosItem);
				}
				renderOrderInfosItem.LmItemInfos = renderOrderInfosItem_lmItemInfos;

				List<RenderOrderResponse.RenderOrder_Model.RenderOrder_RenderOrderInfosItem.RenderOrder_DeliveryInfosItem> renderOrderInfosItem_deliveryInfos = new List<RenderOrderResponse.RenderOrder_Model.RenderOrder_RenderOrderInfosItem.RenderOrder_DeliveryInfosItem>();
				for (int j = 0; j < context.Length("RenderOrder.Model.RenderOrderInfos["+ i +"].DeliveryInfos.Length"); j++) {
					RenderOrderResponse.RenderOrder_Model.RenderOrder_RenderOrderInfosItem.RenderOrder_DeliveryInfosItem deliveryInfosItem = new RenderOrderResponse.RenderOrder_Model.RenderOrder_RenderOrderInfosItem.RenderOrder_DeliveryInfosItem();
					deliveryInfosItem.Id = context.StringValue("RenderOrder.Model.RenderOrderInfos["+ i +"].DeliveryInfos["+ j +"].Id");
					deliveryInfosItem.DisplayName = context.StringValue("RenderOrder.Model.RenderOrderInfos["+ i +"].DeliveryInfos["+ j +"].DisplayName");
					deliveryInfosItem.PostFee = context.LongValue("RenderOrder.Model.RenderOrderInfos["+ i +"].DeliveryInfos["+ j +"].PostFee");
					deliveryInfosItem.ServiceType = context.LongValue("RenderOrder.Model.RenderOrderInfos["+ i +"].DeliveryInfos["+ j +"].ServiceType");

					renderOrderInfosItem_deliveryInfos.Add(deliveryInfosItem);
				}
				renderOrderInfosItem.DeliveryInfos = renderOrderInfosItem_deliveryInfos;

				model_renderOrderInfos.Add(renderOrderInfosItem);
			}
			model.RenderOrderInfos = model_renderOrderInfos;
			renderOrderResponse.Model = model;
        
			return renderOrderResponse;
        }
    }
}
