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
using Aliyun.Acs.CloudPhoto.Model.V20170711;

namespace Aliyun.Acs.CloudPhoto.Transform.V20170711
{
    public class ListTagsResponseUnmarshaller
    {
        public static ListTagsResponse Unmarshall(UnmarshallerContext context)
        {
			ListTagsResponse listTagsResponse = new ListTagsResponse();

			listTagsResponse.HttpResponse = context.HttpResponse;
			listTagsResponse.Code = context.StringValue("ListTags.Code");
			listTagsResponse.Message = context.StringValue("ListTags.Message");
			listTagsResponse.RequestId = context.StringValue("ListTags.RequestId");
			listTagsResponse.Action = context.StringValue("ListTags.Action");

			List<ListTagsResponse.ListTags_Tag> listTagsResponse_tags = new List<ListTagsResponse.ListTags_Tag>();
			for (int i = 0; i < context.Length("ListTags.Tags.Length"); i++) {
				ListTagsResponse.ListTags_Tag tag = new ListTagsResponse.ListTags_Tag();
				tag.Id = context.LongValue("ListTags.Tags["+ i +"].Id");
				tag.IdStr = context.StringValue("ListTags.Tags["+ i +"].IdStr");
				tag.Name = context.StringValue("ListTags.Tags["+ i +"].Name");
				tag.IsSubTag = context.BooleanValue("ListTags.Tags["+ i +"].IsSubTag");
				tag.ParentTag = context.StringValue("ListTags.Tags["+ i +"].ParentTag");

				ListTagsResponse.ListTags_Tag.ListTags_Cover cover = new ListTagsResponse.ListTags_Tag.ListTags_Cover();
				cover.Id = context.LongValue("ListTags.Tags["+ i +"].Cover.Id");
				cover.IdStr = context.StringValue("ListTags.Tags["+ i +"].Cover.IdStr");
				cover.Title = context.StringValue("ListTags.Tags["+ i +"].Cover.Title");
				cover.FileId = context.StringValue("ListTags.Tags["+ i +"].Cover.FileId");
				cover.State = context.StringValue("ListTags.Tags["+ i +"].Cover.State");
				cover.Md5 = context.StringValue("ListTags.Tags["+ i +"].Cover.Md5");
				cover.IsVideo = context.BooleanValue("ListTags.Tags["+ i +"].Cover.IsVideo");
				cover.Remark = context.StringValue("ListTags.Tags["+ i +"].Cover.Remark");
				cover.Width = context.LongValue("ListTags.Tags["+ i +"].Cover.Width");
				cover.Height = context.LongValue("ListTags.Tags["+ i +"].Cover.Height");
				cover.Ctime = context.LongValue("ListTags.Tags["+ i +"].Cover.Ctime");
				cover.Mtime = context.LongValue("ListTags.Tags["+ i +"].Cover.Mtime");
				tag.Cover = cover;

				listTagsResponse_tags.Add(tag);
			}
			listTagsResponse.Tags = listTagsResponse_tags;
        
			return listTagsResponse;
        }
    }
}
