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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class ListTagsResponseUnmarshaller
    {
        public static ListTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTagsResponse listTagsResponse = new ListTagsResponse();

			listTagsResponse.HttpResponse = _ctx.HttpResponse;
			listTagsResponse.Code = _ctx.StringValue("ListTags.Code");
			listTagsResponse.HttpStatusCode = _ctx.IntegerValue("ListTags.HttpStatusCode");
			listTagsResponse.Message = _ctx.StringValue("ListTags.Message");
			listTagsResponse.RequestId = _ctx.StringValue("ListTags.RequestId");
			listTagsResponse.Success = _ctx.BooleanValue("ListTags.Success");

			List<ListTagsResponse.ListTags_TagGroup> listTagsResponse_tagGroups = new List<ListTagsResponse.ListTags_TagGroup>();
			for (int i = 0; i < _ctx.Length("ListTags.TagGroups.Length"); i++) {
				ListTagsResponse.ListTags_TagGroup tagGroup = new ListTagsResponse.ListTags_TagGroup();
				tagGroup.ScriptId = _ctx.StringValue("ListTags.TagGroups["+ i +"].ScriptId");
				tagGroup.TagGroup = _ctx.StringValue("ListTags.TagGroups["+ i +"].TagGroup");
				tagGroup.TagGroupId = _ctx.StringValue("ListTags.TagGroups["+ i +"].TagGroupId");
				tagGroup.TagGroupIndex = _ctx.IntegerValue("ListTags.TagGroups["+ i +"].TagGroupIndex");

				listTagsResponse_tagGroups.Add(tagGroup);
			}
			listTagsResponse.TagGroups = listTagsResponse_tagGroups;

			List<ListTagsResponse.ListTags_Tag> listTagsResponse_tags = new List<ListTagsResponse.ListTags_Tag>();
			for (int i = 0; i < _ctx.Length("ListTags.Tags.Length"); i++) {
				ListTagsResponse.ListTags_Tag tag = new ListTagsResponse.ListTags_Tag();
				tag.ScriptId = _ctx.StringValue("ListTags.Tags["+ i +"].ScriptId");
				tag.TagGroup = _ctx.StringValue("ListTags.Tags["+ i +"].TagGroup");
				tag.TagId = _ctx.StringValue("ListTags.Tags["+ i +"].TagId");
				tag.TagIndex = _ctx.IntegerValue("ListTags.Tags["+ i +"].TagIndex");
				tag.TagName = _ctx.StringValue("ListTags.Tags["+ i +"].TagName");

				listTagsResponse_tags.Add(tag);
			}
			listTagsResponse.Tags = listTagsResponse_tags;
        
			return listTagsResponse;
        }
    }
}
