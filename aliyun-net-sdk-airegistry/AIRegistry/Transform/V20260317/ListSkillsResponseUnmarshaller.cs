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
    public class ListSkillsResponseUnmarshaller
    {
        public static ListSkillsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSkillsResponse listSkillsResponse = new ListSkillsResponse();

			listSkillsResponse.HttpResponse = _ctx.HttpResponse;
			listSkillsResponse.RequestId = _ctx.StringValue("ListSkills.RequestId");

			ListSkillsResponse.ListSkills_Data data = new ListSkillsResponse.ListSkills_Data();
			data.TotalCount = _ctx.IntegerValue("ListSkills.Data.TotalCount");
			data.PageNumber = _ctx.IntegerValue("ListSkills.Data.PageNumber");
			data.PagesAvailable = _ctx.IntegerValue("ListSkills.Data.PagesAvailable");

			List<ListSkillsResponse.ListSkills_Data.ListSkills_PageItem> data_pageItems = new List<ListSkillsResponse.ListSkills_Data.ListSkills_PageItem>();
			for (int i = 0; i < _ctx.Length("ListSkills.Data.PageItems.Length"); i++) {
				ListSkillsResponse.ListSkills_Data.ListSkills_PageItem pageItem = new ListSkillsResponse.ListSkills_Data.ListSkills_PageItem();
				pageItem.DraftMode = _ctx.StringValue("ListSkills.Data.PageItems["+ i +"].DraftMode");
				pageItem.EditingVersion = _ctx.StringValue("ListSkills.Data.PageItems["+ i +"].EditingVersion");
				pageItem.Owner = _ctx.StringValue("ListSkills.Data.PageItems["+ i +"].Owner");
				pageItem.Description = _ctx.StringValue("ListSkills.Data.PageItems["+ i +"].Description");
				pageItem.BizTags = _ctx.StringValue("ListSkills.Data.PageItems["+ i +"].BizTags");
				pageItem.Labels = _ctx.StringValue("ListSkills.Data.PageItems["+ i +"].Labels");
				pageItem.From = _ctx.StringValue("ListSkills.Data.PageItems["+ i +"].From");
				pageItem.Name = _ctx.StringValue("ListSkills.Data.PageItems["+ i +"].Name");
				pageItem.Scope = _ctx.StringValue("ListSkills.Data.PageItems["+ i +"].Scope");
				pageItem.UpdateTime = _ctx.LongValue("ListSkills.Data.PageItems["+ i +"].UpdateTime");
				pageItem.Enable = _ctx.BooleanValue("ListSkills.Data.PageItems["+ i +"].Enable");
				pageItem.NamespaceId = _ctx.StringValue("ListSkills.Data.PageItems["+ i +"].NamespaceId");
				pageItem.ReviewingVersion = _ctx.StringValue("ListSkills.Data.PageItems["+ i +"].ReviewingVersion");
				pageItem.OnlineCnt = _ctx.IntegerValue("ListSkills.Data.PageItems["+ i +"].OnlineCnt");
				pageItem.Writeable = _ctx.BooleanValue("ListSkills.Data.PageItems["+ i +"].Writeable");
				pageItem.DownloadCount = _ctx.LongValue("ListSkills.Data.PageItems["+ i +"].DownloadCount");

				data_pageItems.Add(pageItem);
			}
			data.PageItems = data_pageItems;
			listSkillsResponse.Data = data;
        
			return listSkillsResponse;
        }
    }
}
