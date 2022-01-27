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
    public class DescribeLiveUserTagsResponseUnmarshaller
    {
        public static DescribeLiveUserTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveUserTagsResponse describeLiveUserTagsResponse = new DescribeLiveUserTagsResponse();

			describeLiveUserTagsResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveUserTagsResponse.RequestId = _ctx.StringValue("DescribeLiveUserTags.RequestId");

			List<DescribeLiveUserTagsResponse.DescribeLiveUserTags_Tag> describeLiveUserTagsResponse_tags = new List<DescribeLiveUserTagsResponse.DescribeLiveUserTags_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeLiveUserTags.Tags.Length"); i++) {
				DescribeLiveUserTagsResponse.DescribeLiveUserTags_Tag tag = new DescribeLiveUserTagsResponse.DescribeLiveUserTags_Tag();
				tag.Key = _ctx.StringValue("DescribeLiveUserTags.Tags["+ i +"].Key");

				List<string> tag_value = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeLiveUserTags.Tags["+ i +"].Value.Length"); j++) {
					tag_value.Add(_ctx.StringValue("DescribeLiveUserTags.Tags["+ i +"].Value["+ j +"]"));
				}
				tag._Value = tag_value;

				describeLiveUserTagsResponse_tags.Add(tag);
			}
			describeLiveUserTagsResponse.Tags = describeLiveUserTagsResponse_tags;
        
			return describeLiveUserTagsResponse;
        }
    }
}
