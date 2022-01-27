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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListSetTagsResponseUnmarshaller
    {
        public static ListSetTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSetTagsResponse listSetTagsResponse = new ListSetTagsResponse();

			listSetTagsResponse.HttpResponse = _ctx.HttpResponse;
			listSetTagsResponse.RequestId = _ctx.StringValue("ListSetTags.RequestId");
			listSetTagsResponse.SetId = _ctx.StringValue("ListSetTags.SetId");

			List<ListSetTagsResponse.ListSetTags_TagsItem> listSetTagsResponse_tags = new List<ListSetTagsResponse.ListSetTags_TagsItem>();
			for (int i = 0; i < _ctx.Length("ListSetTags.Tags.Length"); i++) {
				ListSetTagsResponse.ListSetTags_TagsItem tagsItem = new ListSetTagsResponse.ListSetTags_TagsItem();
				tagsItem.TagName = _ctx.StringValue("ListSetTags.Tags["+ i +"].TagName");
				tagsItem.TagCount = _ctx.IntegerValue("ListSetTags.Tags["+ i +"].TagCount");
				tagsItem.TagLevel = _ctx.IntegerValue("ListSetTags.Tags["+ i +"].TagLevel");

				listSetTagsResponse_tags.Add(tagsItem);
			}
			listSetTagsResponse.Tags = listSetTagsResponse_tags;
        
			return listSetTagsResponse;
        }
    }
}
