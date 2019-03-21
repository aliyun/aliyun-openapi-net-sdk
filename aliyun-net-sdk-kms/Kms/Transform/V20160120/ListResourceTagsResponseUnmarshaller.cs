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
using Aliyun.Acs.Kms.Model.V20160120;

namespace Aliyun.Acs.Kms.Transform.V20160120
{
    public class ListResourceTagsResponseUnmarshaller
    {
        public static ListResourceTagsResponse Unmarshall(UnmarshallerContext context)
        {
			ListResourceTagsResponse listResourceTagsResponse = new ListResourceTagsResponse();

			listResourceTagsResponse.HttpResponse = context.HttpResponse;
			listResourceTagsResponse.RequestId = context.StringValue("ListResourceTags.RequestId");

			List<ListResourceTagsResponse.ListResourceTags_Tag> listResourceTagsResponse_tags = new List<ListResourceTagsResponse.ListResourceTags_Tag>();
			for (int i = 0; i < context.Length("ListResourceTags.Tags.Length"); i++) {
				ListResourceTagsResponse.ListResourceTags_Tag tag = new ListResourceTagsResponse.ListResourceTags_Tag();
				tag.KeyId = context.StringValue("ListResourceTags.Tags["+ i +"].KeyId");
				tag.TagKey = context.StringValue("ListResourceTags.Tags["+ i +"].TagKey");
				tag.TagValue = context.StringValue("ListResourceTags.Tags["+ i +"].TagValue");

				listResourceTagsResponse_tags.Add(tag);
			}
			listResourceTagsResponse.Tags = listResourceTagsResponse_tags;
        
			return listResourceTagsResponse;
        }
    }
}
