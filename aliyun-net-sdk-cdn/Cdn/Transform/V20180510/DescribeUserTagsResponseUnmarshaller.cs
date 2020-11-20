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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeUserTagsResponseUnmarshaller
    {
        public static DescribeUserTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUserTagsResponse describeUserTagsResponse = new DescribeUserTagsResponse();

			describeUserTagsResponse.HttpResponse = _ctx.HttpResponse;
			describeUserTagsResponse.RequestId = _ctx.StringValue("DescribeUserTags.RequestId");

			List<DescribeUserTagsResponse.DescribeUserTags_Tag> describeUserTagsResponse_tags = new List<DescribeUserTagsResponse.DescribeUserTags_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeUserTags.Tags.Length"); i++) {
				DescribeUserTagsResponse.DescribeUserTags_Tag tag = new DescribeUserTagsResponse.DescribeUserTags_Tag();
				tag.Key = _ctx.StringValue("DescribeUserTags.Tags["+ i +"].Key");

				List<string> tag_value = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeUserTags.Tags["+ i +"].Value.Length"); j++) {
					tag_value.Add(_ctx.StringValue("DescribeUserTags.Tags["+ i +"].Value["+ j +"]"));
				}
				tag._Value = tag_value;

				describeUserTagsResponse_tags.Add(tag);
			}
			describeUserTagsResponse.Tags = describeUserTagsResponse_tags;
        
			return describeUserTagsResponse;
        }
    }
}
