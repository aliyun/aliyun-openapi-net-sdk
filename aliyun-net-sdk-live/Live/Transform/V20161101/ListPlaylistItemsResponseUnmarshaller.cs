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
    public class ListPlaylistItemsResponseUnmarshaller
    {
        public static ListPlaylistItemsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPlaylistItemsResponse listPlaylistItemsResponse = new ListPlaylistItemsResponse();

			listPlaylistItemsResponse.HttpResponse = _ctx.HttpResponse;
			listPlaylistItemsResponse.Total = _ctx.IntegerValue("ListPlaylistItems.Total");
			listPlaylistItemsResponse.RequestId = _ctx.StringValue("ListPlaylistItems.RequestId");

			List<ListPlaylistItemsResponse.ListPlaylistItems_ProgramItem> listPlaylistItemsResponse_programItems = new List<ListPlaylistItemsResponse.ListPlaylistItems_ProgramItem>();
			for (int i = 0; i < _ctx.Length("ListPlaylistItems.ProgramItems.Length"); i++) {
				ListPlaylistItemsResponse.ListPlaylistItems_ProgramItem programItem = new ListPlaylistItemsResponse.ListPlaylistItems_ProgramItem();
				programItem.Index = _ctx.IntegerValue("ListPlaylistItems.ProgramItems["+ i +"].Index");
				programItem.ResourceType = _ctx.StringValue("ListPlaylistItems.ProgramItems["+ i +"].ResourceType");
				programItem.ProgramItemId = _ctx.StringValue("ListPlaylistItems.ProgramItems["+ i +"].ProgramItemId");
				programItem.ProgramId = _ctx.StringValue("ListPlaylistItems.ProgramItems["+ i +"].ProgramId");
				programItem.ProgramItemName = _ctx.StringValue("ListPlaylistItems.ProgramItems["+ i +"].ProgramItemName");
				programItem.ResourceValue = _ctx.StringValue("ListPlaylistItems.ProgramItems["+ i +"].ResourceValue");

				listPlaylistItemsResponse_programItems.Add(programItem);
			}
			listPlaylistItemsResponse.ProgramItems = listPlaylistItemsResponse_programItems;
        
			return listPlaylistItemsResponse;
        }
    }
}
