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
    public class ListPromptVersionsResponseUnmarshaller
    {
        public static ListPromptVersionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPromptVersionsResponse listPromptVersionsResponse = new ListPromptVersionsResponse();

			listPromptVersionsResponse.HttpResponse = _ctx.HttpResponse;
			listPromptVersionsResponse.RequestId = _ctx.StringValue("ListPromptVersions.RequestId");

			ListPromptVersionsResponse.ListPromptVersions_Data data = new ListPromptVersionsResponse.ListPromptVersions_Data();
			data.TotalCount = _ctx.IntegerValue("ListPromptVersions.Data.TotalCount");
			data.PageNumber = _ctx.IntegerValue("ListPromptVersions.Data.PageNumber");
			data.PagesAvailable = _ctx.IntegerValue("ListPromptVersions.Data.PagesAvailable");

			List<ListPromptVersionsResponse.ListPromptVersions_Data.ListPromptVersions_Item> data_pageItems = new List<ListPromptVersionsResponse.ListPromptVersions_Data.ListPromptVersions_Item>();
			for (int i = 0; i < _ctx.Length("ListPromptVersions.Data.PageItems.Length"); i++) {
				ListPromptVersionsResponse.ListPromptVersions_Data.ListPromptVersions_Item item = new ListPromptVersionsResponse.ListPromptVersions_Data.ListPromptVersions_Item();
				item.Status = _ctx.StringValue("ListPromptVersions.Data.PageItems["+ i +"].Status");
				item.Version = _ctx.StringValue("ListPromptVersions.Data.PageItems["+ i +"].Version");
				item.SrcUser = _ctx.StringValue("ListPromptVersions.Data.PageItems["+ i +"].SrcUser");
				item.PromptKey = _ctx.StringValue("ListPromptVersions.Data.PageItems["+ i +"].PromptKey");
				item.GmtModified = _ctx.LongValue("ListPromptVersions.Data.PageItems["+ i +"].GmtModified");
				item.CommitMsg = _ctx.StringValue("ListPromptVersions.Data.PageItems["+ i +"].CommitMsg");

				data_pageItems.Add(item);
			}
			data.PageItems = data_pageItems;
			listPromptVersionsResponse.Data = data;
        
			return listPromptVersionsResponse;
        }
    }
}
