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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodUserTagsResponseUnmarshaller
    {
        public static DescribeVodUserTagsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodUserTagsResponse describeVodUserTagsResponse = new DescribeVodUserTagsResponse();

			describeVodUserTagsResponse.HttpResponse = context.HttpResponse;
			describeVodUserTagsResponse.RequestId = context.StringValue("DescribeVodUserTags.RequestId");

			List<DescribeVodUserTagsResponse.DescribeVodUserTags_Tag> describeVodUserTagsResponse_tags = new List<DescribeVodUserTagsResponse.DescribeVodUserTags_Tag>();
			for (int i = 0; i < context.Length("DescribeVodUserTags.Tags.Length"); i++) {
				DescribeVodUserTagsResponse.DescribeVodUserTags_Tag tag = new DescribeVodUserTagsResponse.DescribeVodUserTags_Tag();
				tag.Key = context.StringValue("DescribeVodUserTags.Tags["+ i +"].Key");

				List<string> tag_value = new List<string>();
				for (int j = 0; j < context.Length("DescribeVodUserTags.Tags["+ i +"].Value.Length"); j++) {
					tag_value.Add(context.StringValue("DescribeVodUserTags.Tags["+ i +"].Value["+ j +"]"));
				}
				tag._Value = tag_value;

				describeVodUserTagsResponse_tags.Add(tag);
			}
			describeVodUserTagsResponse.Tags = describeVodUserTagsResponse_tags;
        
			return describeVodUserTagsResponse;
        }
    }
}
