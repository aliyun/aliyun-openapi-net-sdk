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
using Aliyun.Acs.AIRegistry.Model.V20260317;

namespace Aliyun.Acs.AIRegistry.Transform.V20260317
{
    public class ListPromptsResponseUnmarshaller
    {
        public static ListPromptsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPromptsResponse listPromptsResponse = new ListPromptsResponse();

			listPromptsResponse.HttpResponse = _ctx.HttpResponse;
			listPromptsResponse.RequestId = _ctx.StringValue("ListPrompts.RequestId");

			ListPromptsResponse.ListPrompts_Data data = new ListPromptsResponse.ListPrompts_Data();
			data.TotalCount = _ctx.IntegerValue("ListPrompts.Data.TotalCount");
			data.PageNumber = _ctx.IntegerValue("ListPrompts.Data.PageNumber");
			data.PagesAvailable = _ctx.IntegerValue("ListPrompts.Data.PagesAvailable");

			List<ListPromptsResponse.ListPrompts_Data.ListPrompts_Item> data_pageItems = new List<ListPromptsResponse.ListPrompts_Data.ListPrompts_Item>();
			for (int i = 0; i < _ctx.Length("ListPrompts.Data.PageItems.Length"); i++) {
				ListPromptsResponse.ListPrompts_Data.ListPrompts_Item item = new ListPromptsResponse.ListPrompts_Data.ListPrompts_Item();
				item.EditingVersion = _ctx.StringValue("ListPrompts.Data.PageItems["+ i +"].EditingVersion");
				item.Description = _ctx.StringValue("ListPrompts.Data.PageItems["+ i +"].Description");
				item.SchemaVersion = _ctx.IntegerValue("ListPrompts.Data.PageItems["+ i +"].SchemaVersion");
				item.LatestVersion = _ctx.StringValue("ListPrompts.Data.PageItems["+ i +"].LatestVersion");
				item.PromptKey = _ctx.StringValue("ListPrompts.Data.PageItems["+ i +"].PromptKey");
				item.GmtModified = _ctx.LongValue("ListPrompts.Data.PageItems["+ i +"].GmtModified");
				item.Labels = _ctx.StringValue("ListPrompts.Data.PageItems["+ i +"].Labels");
				item.ReviewingVersion = _ctx.StringValue("ListPrompts.Data.PageItems["+ i +"].ReviewingVersion");
				item.OnlineCnt = _ctx.IntegerValue("ListPrompts.Data.PageItems["+ i +"].OnlineCnt");

				List<string> item_bizTags = new List<string>();
				for (int j = 0; j < _ctx.Length("ListPrompts.Data.PageItems["+ i +"].BizTags.Length"); j++) {
					item_bizTags.Add(_ctx.StringValue("ListPrompts.Data.PageItems["+ i +"].BizTags["+ j +"]"));
				}
				item.BizTags = item_bizTags;

				data_pageItems.Add(item);
			}
			data.PageItems = data_pageItems;
			listPromptsResponse.Data = data;
        
			return listPromptsResponse;
        }
    }
}
