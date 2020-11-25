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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeTagsResponseUnmarshaller
    {
        public static DescribeTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTagsResponse describeTagsResponse = new DescribeTagsResponse();

			describeTagsResponse.HttpResponse = _ctx.HttpResponse;
			describeTagsResponse.RequestId = _ctx.StringValue("DescribeTags.RequestId");
			describeTagsResponse.PageSize = _ctx.IntegerValue("DescribeTags.PageSize");
			describeTagsResponse.PageNumber = _ctx.IntegerValue("DescribeTags.PageNumber");
			describeTagsResponse.TotalCount = _ctx.IntegerValue("DescribeTags.TotalCount");

			List<DescribeTagsResponse.DescribeTags_Tag> describeTagsResponse_tags = new List<DescribeTagsResponse.DescribeTags_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeTags.Tags.Length"); i++) {
				DescribeTagsResponse.DescribeTags_Tag tag = new DescribeTagsResponse.DescribeTags_Tag();
				tag.TagKey = _ctx.StringValue("DescribeTags.Tags["+ i +"].TagKey");
				tag.TagValue = _ctx.StringValue("DescribeTags.Tags["+ i +"].TagValue");

				DescribeTagsResponse.DescribeTags_Tag.DescribeTags_ResourceTypeCount resourceTypeCount = new DescribeTagsResponse.DescribeTags_Tag.DescribeTags_ResourceTypeCount();
				resourceTypeCount.Instance = _ctx.IntegerValue("DescribeTags.Tags["+ i +"].ResourceTypeCount.Instance");
				resourceTypeCount.Disk = _ctx.IntegerValue("DescribeTags.Tags["+ i +"].ResourceTypeCount.Disk");
				resourceTypeCount.Volume = _ctx.IntegerValue("DescribeTags.Tags["+ i +"].ResourceTypeCount.Volume");
				resourceTypeCount.Image = _ctx.IntegerValue("DescribeTags.Tags["+ i +"].ResourceTypeCount.Image");
				resourceTypeCount.Snapshot = _ctx.IntegerValue("DescribeTags.Tags["+ i +"].ResourceTypeCount.Snapshot");
				resourceTypeCount.Securitygroup = _ctx.IntegerValue("DescribeTags.Tags["+ i +"].ResourceTypeCount.Securitygroup");
				resourceTypeCount.LaunchTemplate = _ctx.IntegerValue("DescribeTags.Tags["+ i +"].ResourceTypeCount.LaunchTemplate");
				resourceTypeCount.Eni = _ctx.IntegerValue("DescribeTags.Tags["+ i +"].ResourceTypeCount.Eni");
				resourceTypeCount.Ddh = _ctx.IntegerValue("DescribeTags.Tags["+ i +"].ResourceTypeCount.Ddh");
				resourceTypeCount.KeyPair = _ctx.IntegerValue("DescribeTags.Tags["+ i +"].ResourceTypeCount.KeyPair");
				resourceTypeCount.SnapshotPolicy = _ctx.IntegerValue("DescribeTags.Tags["+ i +"].ResourceTypeCount.SnapshotPolicy");
				resourceTypeCount.ReservedInstance = _ctx.IntegerValue("DescribeTags.Tags["+ i +"].ResourceTypeCount.ReservedInstance");
				tag.ResourceTypeCount = resourceTypeCount;

				describeTagsResponse_tags.Add(tag);
			}
			describeTagsResponse.Tags = describeTagsResponse_tags;
        
			return describeTagsResponse;
        }
    }
}
