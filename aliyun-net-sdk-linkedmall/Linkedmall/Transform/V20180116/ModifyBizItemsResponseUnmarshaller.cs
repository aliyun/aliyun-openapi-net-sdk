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
    public class ModifyBizItemsResponseUnmarshaller
    {
        public static ModifyBizItemsResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyBizItemsResponse modifyBizItemsResponse = new ModifyBizItemsResponse();

			modifyBizItemsResponse.HttpResponse = context.HttpResponse;
			modifyBizItemsResponse.Code = context.StringValue("ModifyBizItems.Code");
			modifyBizItemsResponse.Message = context.StringValue("ModifyBizItems.Message");
			modifyBizItemsResponse.TotalCount = context.IntegerValue("ModifyBizItems.TotalCount");
			modifyBizItemsResponse.PageNumber = context.IntegerValue("ModifyBizItems.PageNumber");
			modifyBizItemsResponse.PageSize = context.IntegerValue("ModifyBizItems.PageSize");
			modifyBizItemsResponse.RequestId = context.StringValue("ModifyBizItems.RequestId");

			List<ModifyBizItemsResponse.ModifyBizItems_Item> modifyBizItemsResponse_failedItemList = new List<ModifyBizItemsResponse.ModifyBizItems_Item>();
			for (int i = 0; i < context.Length("ModifyBizItems.FailedItemList.Length"); i++) {
				ModifyBizItemsResponse.ModifyBizItems_Item item = new ModifyBizItemsResponse.ModifyBizItems_Item();
				item.ItemId = context.LongValue("ModifyBizItems.FailedItemList["+ i +"].ItemId");
				item.LmItemId = context.StringValue("ModifyBizItems.FailedItemList["+ i +"].LmItemId");

				List<string> item_skuIdList = new List<string>();
				for (int j = 0; j < context.Length("ModifyBizItems.FailedItemList["+ i +"].SkuIdList.Length"); j++) {
					item_skuIdList.Add(context.StringValue("ModifyBizItems.FailedItemList["+ i +"].SkuIdList["+ j +"]"));
				}
				item.SkuIdList = item_skuIdList;

				modifyBizItemsResponse_failedItemList.Add(item);
			}
			modifyBizItemsResponse.FailedItemList = modifyBizItemsResponse_failedItemList;
        
			return modifyBizItemsResponse;
        }
    }
}
