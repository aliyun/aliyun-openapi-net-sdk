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
using Aliyun.Acs.ivision.Model.V20190308;

namespace Aliyun.Acs.ivision.Transform.V20190308
{
    public class DescribeTagsResponseUnmarshaller
    {
        public static DescribeTagsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTagsResponse describeTagsResponse = new DescribeTagsResponse();

			describeTagsResponse.HttpResponse = context.HttpResponse;
			describeTagsResponse.RequestId = context.StringValue("DescribeTags.RequestId");
			describeTagsResponse.TotalNum = context.LongValue("DescribeTags.TotalNum");
			describeTagsResponse.CurrentPage = context.LongValue("DescribeTags.CurrentPage");
			describeTagsResponse.PageSize = context.LongValue("DescribeTags.PageSize");
			describeTagsResponse.NextPageToken = context.StringValue("DescribeTags.NextPageToken");

			List<DescribeTagsResponse.DescribeTags_Tag> describeTagsResponse_tags = new List<DescribeTagsResponse.DescribeTags_Tag>();
			for (int i = 0; i < context.Length("DescribeTags.Tags.Length"); i++) {
				DescribeTagsResponse.DescribeTags_Tag tag = new DescribeTagsResponse.DescribeTags_Tag();
				tag.ProjectId = context.StringValue("DescribeTags.Tags["+ i +"].ProjectId");
				tag.TagId = context.StringValue("DescribeTags.Tags["+ i +"].TagId");
				tag.TagName = context.StringValue("DescribeTags.Tags["+ i +"].TagName");
				tag.Description = context.StringValue("DescribeTags.Tags["+ i +"].Description");
				tag.Count = context.IntegerValue("DescribeTags.Tags["+ i +"].Count");
				tag.CreationTime = context.StringValue("DescribeTags.Tags["+ i +"].CreationTime");

				describeTagsResponse_tags.Add(tag);
			}
			describeTagsResponse.Tags = describeTagsResponse_tags;
        
			return describeTagsResponse;
        }
    }
}
