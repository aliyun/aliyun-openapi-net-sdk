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
    public class QueryItemInventoryResponseUnmarshaller
    {
        public static QueryItemInventoryResponse Unmarshall(UnmarshallerContext context)
        {
			QueryItemInventoryResponse queryItemInventoryResponse = new QueryItemInventoryResponse();

			queryItemInventoryResponse.HttpResponse = context.HttpResponse;
			queryItemInventoryResponse.RequestId = context.StringValue("QueryItemInventory.RequestId");
			queryItemInventoryResponse.Code = context.StringValue("QueryItemInventory.Code");
			queryItemInventoryResponse.Message = context.StringValue("QueryItemInventory.Message");
			queryItemInventoryResponse.SubCode = context.StringValue("QueryItemInventory.SubCode");
			queryItemInventoryResponse.SubMessage = context.StringValue("QueryItemInventory.SubMessage");
			queryItemInventoryResponse.Success = context.BooleanValue("QueryItemInventory.Success");

			List<QueryItemInventoryResponse.QueryItemInventory_Item> queryItemInventoryResponse_itemList = new List<QueryItemInventoryResponse.QueryItemInventory_Item>();
			for (int i = 0; i < context.Length("QueryItemInventory.ItemList.Length"); i++) {
				QueryItemInventoryResponse.QueryItemInventory_Item item = new QueryItemInventoryResponse.QueryItemInventory_Item();
				item.ItemId = context.LongValue("QueryItemInventory.ItemList["+ i +"].ItemId");
				item.LmItemId = context.StringValue("QueryItemInventory.ItemList["+ i +"].LmItemId");

				List<QueryItemInventoryResponse.QueryItemInventory_Item.QueryItemInventory_Sku> item_skuList = new List<QueryItemInventoryResponse.QueryItemInventory_Item.QueryItemInventory_Sku>();
				for (int j = 0; j < context.Length("QueryItemInventory.ItemList["+ i +"].SkuList.Length"); j++) {
					QueryItemInventoryResponse.QueryItemInventory_Item.QueryItemInventory_Sku sku = new QueryItemInventoryResponse.QueryItemInventory_Item.QueryItemInventory_Sku();
					sku.SkuId = context.LongValue("QueryItemInventory.ItemList["+ i +"].SkuList["+ j +"].SkuId");

					QueryItemInventoryResponse.QueryItemInventory_Item.QueryItemInventory_Sku.QueryItemInventory_Inventory inventory = new QueryItemInventoryResponse.QueryItemInventory_Item.QueryItemInventory_Sku.QueryItemInventory_Inventory();
					inventory.Quantity = context.LongValue("QueryItemInventory.ItemList["+ i +"].SkuList["+ j +"].Inventory.Quantity");
					sku.Inventory = inventory;

					item_skuList.Add(sku);
				}
				item.SkuList = item_skuList;

				queryItemInventoryResponse_itemList.Add(item);
			}
			queryItemInventoryResponse.ItemList = queryItemInventoryResponse_itemList;
        
			return queryItemInventoryResponse;
        }
    }
}
