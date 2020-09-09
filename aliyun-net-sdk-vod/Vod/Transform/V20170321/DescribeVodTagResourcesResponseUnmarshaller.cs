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
    public class DescribeVodTagResourcesResponseUnmarshaller
    {
        public static DescribeVodTagResourcesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodTagResourcesResponse describeVodTagResourcesResponse = new DescribeVodTagResourcesResponse();

			describeVodTagResourcesResponse.HttpResponse = context.HttpResponse;
			describeVodTagResourcesResponse.RequestId = context.StringValue("DescribeVodTagResources.RequestId");

			List<DescribeVodTagResourcesResponse.DescribeVodTagResources_TagResource> describeVodTagResourcesResponse_tagResources = new List<DescribeVodTagResourcesResponse.DescribeVodTagResources_TagResource>();
			for (int i = 0; i < context.Length("DescribeVodTagResources.TagResources.Length"); i++) {
				DescribeVodTagResourcesResponse.DescribeVodTagResources_TagResource tagResource = new DescribeVodTagResourcesResponse.DescribeVodTagResources_TagResource();
				tagResource.ResourceId = context.StringValue("DescribeVodTagResources.TagResources["+ i +"].ResourceId");

				List<DescribeVodTagResourcesResponse.DescribeVodTagResources_TagResource.DescribeVodTagResources_TagItem> tagResource_tag = new List<DescribeVodTagResourcesResponse.DescribeVodTagResources_TagResource.DescribeVodTagResources_TagItem>();
				for (int j = 0; j < context.Length("DescribeVodTagResources.TagResources["+ i +"].Tag.Length"); j++) {
					DescribeVodTagResourcesResponse.DescribeVodTagResources_TagResource.DescribeVodTagResources_TagItem tagItem = new DescribeVodTagResourcesResponse.DescribeVodTagResources_TagResource.DescribeVodTagResources_TagItem();
					tagItem.Key = context.StringValue("DescribeVodTagResources.TagResources["+ i +"].Tag["+ j +"].Key");
					tagItem._Value = context.StringValue("DescribeVodTagResources.TagResources["+ i +"].Tag["+ j +"].Value");

					tagResource_tag.Add(tagItem);
				}
				tagResource.Tag = tagResource_tag;

				describeVodTagResourcesResponse_tagResources.Add(tagResource);
			}
			describeVodTagResourcesResponse.TagResources = describeVodTagResourcesResponse_tagResources;
        
			return describeVodTagResourcesResponse;
        }
    }
}
