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
        public static ListTagsResponse Unmarshall(UnmarshallerContext context)
        {
			ListTagsResponse listTagsResponse = new ListTagsResponse();

			listTagsResponse.HttpResponse = context.HttpResponse;
			listTagsResponse.RequestId = context.StringValue("ListTags.RequestId");
			listTagsResponse.Success = context.BooleanValue("ListTags.Success");
			listTagsResponse.Code = context.StringValue("ListTags.Code");
			listTagsResponse.Message = context.StringValue("ListTags.Message");
			listTagsResponse.HttpStatusCode = context.IntegerValue("ListTags.HttpStatusCode");

			List<ListTagsResponse.ListTags_Tag> listTagsResponse_tags = new List<ListTagsResponse.ListTags_Tag>();
			for (int i = 0; i < context.Length("ListTags.Tags.Length"); i++) {
				ListTagsResponse.ListTags_Tag tag = new ListTagsResponse.ListTags_Tag();
				tag.TagId = context.StringValue("ListTags.Tags["+ i +"].TagId");
				tag.TagName = context.StringValue("ListTags.Tags["+ i +"].TagName");
				tag.TagIndex = context.IntegerValue("ListTags.Tags["+ i +"].TagIndex");
				tag.ScriptId = context.StringValue("ListTags.Tags["+ i +"].ScriptId");
				tag.TagGroup = context.StringValue("ListTags.Tags["+ i +"].TagGroup");

				listTagsResponse_tags.Add(tag);
			}
			listTagsResponse.Tags = listTagsResponse_tags;

			List<ListTagsResponse.ListTags_TagGroup> listTagsResponse_tagGroups = new List<ListTagsResponse.ListTags_TagGroup>();
			for (int i = 0; i < context.Length("ListTags.TagGroups.Length"); i++) {
				ListTagsResponse.ListTags_TagGroup tagGroup = new ListTagsResponse.ListTags_TagGroup();
				tagGroup.TagGroupId = context.StringValue("ListTags.TagGroups["+ i +"].TagGroupId");
				tagGroup.TagGroupIndex = context.IntegerValue("ListTags.TagGroups["+ i +"].TagGroupIndex");
				tagGroup.ScriptId = context.StringValue("ListTags.TagGroups["+ i +"].ScriptId");
				tagGroup.TagGroup = context.StringValue("ListTags.TagGroups["+ i +"].TagGroup");

				listTagsResponse_tagGroups.Add(tagGroup);
			}
			listTagsResponse.TagGroups = listTagsResponse_tagGroups;
        
			return listTagsResponse;
        }
    }
}
