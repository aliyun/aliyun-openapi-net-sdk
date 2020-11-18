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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class ListTagsResponseUnmarshaller
    {
        public static ListTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTagsResponse listTagsResponse = new ListTagsResponse();

			listTagsResponse.HttpResponse = _ctx.HttpResponse;
			listTagsResponse.RequestId = _ctx.StringValue("ListTags.RequestId");

			List<ListTagsResponse.ListTags_Tag> listTagsResponse_tags = new List<ListTagsResponse.ListTags_Tag>();
			for (int i = 0; i < _ctx.Length("ListTags.Tags.Length"); i++) {
				ListTagsResponse.ListTags_Tag tag = new ListTagsResponse.ListTags_Tag();
				tag.TagKey = _ctx.StringValue("ListTags.Tags["+ i +"].TagKey");
				tag.TagValue = _ctx.StringValue("ListTags.Tags["+ i +"].TagValue");

				listTagsResponse_tags.Add(tag);
			}
			listTagsResponse.Tags = listTagsResponse_tags;
        
			return listTagsResponse;
        }
    }
}
