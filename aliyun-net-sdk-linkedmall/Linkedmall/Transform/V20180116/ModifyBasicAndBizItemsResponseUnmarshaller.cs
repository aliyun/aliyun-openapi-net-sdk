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
    public class ModifyBasicAndBizItemsResponseUnmarshaller
    {
        public static ModifyBasicAndBizItemsResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyBasicAndBizItemsResponse modifyBasicAndBizItemsResponse = new ModifyBasicAndBizItemsResponse();

			modifyBasicAndBizItemsResponse.HttpResponse = context.HttpResponse;
			modifyBasicAndBizItemsResponse.Code = context.StringValue("ModifyBasicAndBizItems.Code");
			modifyBasicAndBizItemsResponse.Message = context.StringValue("ModifyBasicAndBizItems.Message");
			modifyBasicAndBizItemsResponse.RequestId = context.StringValue("ModifyBasicAndBizItems.RequestId");

			List<ModifyBasicAndBizItemsResponse.ModifyBasicAndBizItems_Item> modifyBasicAndBizItemsResponse_failedItemList = new List<ModifyBasicAndBizItemsResponse.ModifyBasicAndBizItems_Item>();
			for (int i = 0; i < context.Length("ModifyBasicAndBizItems.FailedItemList.Length"); i++) {
				ModifyBasicAndBizItemsResponse.ModifyBasicAndBizItems_Item item = new ModifyBasicAndBizItemsResponse.ModifyBasicAndBizItems_Item();
				item.ItemId = context.LongValue("ModifyBasicAndBizItems.FailedItemList["+ i +"].ItemId");
				item.LmItemId = context.StringValue("ModifyBasicAndBizItems.FailedItemList["+ i +"].LmItemId");

				List<string> item_skuIdList = new List<string>();
				for (int j = 0; j < context.Length("ModifyBasicAndBizItems.FailedItemList["+ i +"].SkuIdList.Length"); j++) {
					item_skuIdList.Add(context.StringValue("ModifyBasicAndBizItems.FailedItemList["+ i +"].SkuIdList["+ j +"]"));
				}
				item.SkuIdList = item_skuIdList;

				modifyBasicAndBizItemsResponse_failedItemList.Add(item);
			}
			modifyBasicAndBizItemsResponse.FailedItemList = modifyBasicAndBizItemsResponse_failedItemList;
        
			return modifyBasicAndBizItemsResponse;
        }
    }
}
