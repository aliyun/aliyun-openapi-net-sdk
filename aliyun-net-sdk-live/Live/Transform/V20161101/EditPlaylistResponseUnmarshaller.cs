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
    public class EditPlaylistResponseUnmarshaller
    {
        public static EditPlaylistResponse Unmarshall(UnmarshallerContext _ctx)
        {
			EditPlaylistResponse editPlaylistResponse = new EditPlaylistResponse();

			editPlaylistResponse.HttpResponse = _ctx.HttpResponse;
			editPlaylistResponse.RequestId = _ctx.StringValue("EditPlaylist.RequestId");
			editPlaylistResponse.ProgramId = _ctx.StringValue("EditPlaylist.ProgramId");
			editPlaylistResponse.CasterId = _ctx.StringValue("EditPlaylist.CasterId");

			EditPlaylistResponse.EditPlaylist_Items items = new EditPlaylistResponse.EditPlaylist_Items();

			List<EditPlaylistResponse.EditPlaylist_Items.EditPlaylist_SuccessItem> items_successItems = new List<EditPlaylistResponse.EditPlaylist_Items.EditPlaylist_SuccessItem>();
			for (int i = 0; i < _ctx.Length("EditPlaylist.Items.SuccessItems.Length"); i++) {
				EditPlaylistResponse.EditPlaylist_Items.EditPlaylist_SuccessItem successItem = new EditPlaylistResponse.EditPlaylist_Items.EditPlaylist_SuccessItem();
				successItem.ItemId = _ctx.StringValue("EditPlaylist.Items.SuccessItems["+ i +"].ItemId");
				successItem.ItemName = _ctx.StringValue("EditPlaylist.Items.SuccessItems["+ i +"].ItemName");

				items_successItems.Add(successItem);
			}
			items.SuccessItems = items_successItems;

			List<EditPlaylistResponse.EditPlaylist_Items.EditPlaylist_FailedItem> items_failedItems = new List<EditPlaylistResponse.EditPlaylist_Items.EditPlaylist_FailedItem>();
			for (int i = 0; i < _ctx.Length("EditPlaylist.Items.FailedItems.Length"); i++) {
				EditPlaylistResponse.EditPlaylist_Items.EditPlaylist_FailedItem failedItem = new EditPlaylistResponse.EditPlaylist_Items.EditPlaylist_FailedItem();
				failedItem.ItemId = _ctx.StringValue("EditPlaylist.Items.FailedItems["+ i +"].ItemId");
				failedItem.ItemName = _ctx.StringValue("EditPlaylist.Items.FailedItems["+ i +"].ItemName");

				items_failedItems.Add(failedItem);
			}
			items.FailedItems = items_failedItems;
			editPlaylistResponse.Items = items;
        
			return editPlaylistResponse;
        }
    }
}
