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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class AddPlaylistItemsResponseUnmarshaller
    {
        public static AddPlaylistItemsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddPlaylistItemsResponse addPlaylistItemsResponse = new AddPlaylistItemsResponse();

			addPlaylistItemsResponse.HttpResponse = _ctx.HttpResponse;
			addPlaylistItemsResponse.RequestId = _ctx.StringValue("AddPlaylistItems.RequestId");
			addPlaylistItemsResponse.ProgramId = _ctx.StringValue("AddPlaylistItems.ProgramId");

			AddPlaylistItemsResponse.AddPlaylistItems_Items items = new AddPlaylistItemsResponse.AddPlaylistItems_Items();

			List<AddPlaylistItemsResponse.AddPlaylistItems_Items.AddPlaylistItems_SuccessItem> items_successItems = new List<AddPlaylistItemsResponse.AddPlaylistItems_Items.AddPlaylistItems_SuccessItem>();
			for (int i = 0; i < _ctx.Length("AddPlaylistItems.Items.SuccessItems.Length"); i++) {
				AddPlaylistItemsResponse.AddPlaylistItems_Items.AddPlaylistItems_SuccessItem successItem = new AddPlaylistItemsResponse.AddPlaylistItems_Items.AddPlaylistItems_SuccessItem();
				successItem.ItemId = _ctx.StringValue("AddPlaylistItems.Items.SuccessItems["+ i +"].ItemId");
				successItem.ItemName = _ctx.StringValue("AddPlaylistItems.Items.SuccessItems["+ i +"].ItemName");

				items_successItems.Add(successItem);
			}
			items.SuccessItems = items_successItems;

			List<AddPlaylistItemsResponse.AddPlaylistItems_Items.AddPlaylistItems_FailedItem> items_failedItems = new List<AddPlaylistItemsResponse.AddPlaylistItems_Items.AddPlaylistItems_FailedItem>();
			for (int i = 0; i < _ctx.Length("AddPlaylistItems.Items.FailedItems.Length"); i++) {
				AddPlaylistItemsResponse.AddPlaylistItems_Items.AddPlaylistItems_FailedItem failedItem = new AddPlaylistItemsResponse.AddPlaylistItems_Items.AddPlaylistItems_FailedItem();
				failedItem.ItemId = _ctx.StringValue("AddPlaylistItems.Items.FailedItems["+ i +"].ItemId");
				failedItem.ItemName = _ctx.StringValue("AddPlaylistItems.Items.FailedItems["+ i +"].ItemName");

				items_failedItems.Add(failedItem);
			}
			items.FailedItems = items_failedItems;
			addPlaylistItemsResponse.Items = items;
        
			return addPlaylistItemsResponse;
        }
    }
}
