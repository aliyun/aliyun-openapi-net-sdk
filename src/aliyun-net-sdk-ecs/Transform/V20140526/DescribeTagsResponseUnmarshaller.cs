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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ecs.Model.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeTagsResponseUnmarshaller
    {
        public static DescribeTagsResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeTagsResponse describeTagsResponse = new DescribeTagsResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeTags.RequestId"),
                PageSize = context.IntegerValue("DescribeTags.PageSize"),
                PageNumber = context.IntegerValue("DescribeTags.PageNumber"),
                TotalCount = context.IntegerValue("DescribeTags.TotalCount")
            };
            List<DescribeTagsResponse.Tag> tags = new List<DescribeTagsResponse.Tag>();
			for (int i = 0; i < context.Length("DescribeTags.Tags.Length"); i++) {
                DescribeTagsResponse.Tag tag = new DescribeTagsResponse.Tag()
                {
                    TagKey = context.StringValue($"DescribeTags.Tags[{i}].TagKey"),
                    TagValue = context.StringValue($"DescribeTags.Tags[{i}].TagValue")
                };
                DescribeTagsResponse.Tag.ResourceTypeCount_ resourceTypeCount = new DescribeTagsResponse.Tag.ResourceTypeCount_()
                {
                    Instance = context.IntegerValue($"DescribeTags.Tags[{i}].ResourceTypeCount.Instance"),
                    Disk = context.IntegerValue($"DescribeTags.Tags[{i}].ResourceTypeCount.Disk"),
                    Image = context.IntegerValue($"DescribeTags.Tags[{i}].ResourceTypeCount.Image"),
                    Snapshot = context.IntegerValue($"DescribeTags.Tags[{i}].ResourceTypeCount.Snapshot"),
                    Securitygroup = context.IntegerValue($"DescribeTags.Tags[{i}].ResourceTypeCount.Securitygroup")
                };
                tag.ResourceTypeCount = resourceTypeCount;

				tags.Add(tag);
			}
			describeTagsResponse.Tags = tags;
        
			return describeTagsResponse;
        }
    }
}