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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeTagsResponseUnmarshaller
    {
        public static DescribeTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTagsResponse describeTagsResponse = new DescribeTagsResponse();

			describeTagsResponse.HttpResponse = _ctx.HttpResponse;
			describeTagsResponse.RequestId = _ctx.StringValue("DescribeTags.RequestId");
			describeTagsResponse.NextToken = _ctx.StringValue("DescribeTags.NextToken");

			List<DescribeTagsResponse.DescribeTags_Tag> describeTagsResponse_tags = new List<DescribeTagsResponse.DescribeTags_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeTags.Tags.Length"); i++) {
				DescribeTagsResponse.DescribeTags_Tag tag = new DescribeTagsResponse.DescribeTags_Tag();
				tag.TagKey = _ctx.StringValue("DescribeTags.Tags["+ i +"].TagKey");

				List<string> tag_tagValues = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeTags.Tags["+ i +"].TagValues.Length"); j++) {
					tag_tagValues.Add(_ctx.StringValue("DescribeTags.Tags["+ i +"].TagValues["+ j +"]"));
				}
				tag.TagValues = tag_tagValues;

				describeTagsResponse_tags.Add(tag);
			}
			describeTagsResponse.Tags = describeTagsResponse_tags;
        
			return describeTagsResponse;
        }
    }
}
