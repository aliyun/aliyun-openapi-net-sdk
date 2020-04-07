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
    public class DescribeLiveTagResourcesResponseUnmarshaller
    {
        public static DescribeLiveTagResourcesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveTagResourcesResponse describeLiveTagResourcesResponse = new DescribeLiveTagResourcesResponse();

			describeLiveTagResourcesResponse.HttpResponse = context.HttpResponse;
			describeLiveTagResourcesResponse.RequestId = context.StringValue("DescribeLiveTagResources.RequestId");

			List<DescribeLiveTagResourcesResponse.DescribeLiveTagResources_TagResource> describeLiveTagResourcesResponse_tagResources = new List<DescribeLiveTagResourcesResponse.DescribeLiveTagResources_TagResource>();
			for (int i = 0; i < context.Length("DescribeLiveTagResources.TagResources.Length"); i++) {
				DescribeLiveTagResourcesResponse.DescribeLiveTagResources_TagResource tagResource = new DescribeLiveTagResourcesResponse.DescribeLiveTagResources_TagResource();
				tagResource.ResourceId = context.StringValue("DescribeLiveTagResources.TagResources["+ i +"].ResourceId");

				List<DescribeLiveTagResourcesResponse.DescribeLiveTagResources_TagResource.DescribeLiveTagResources_TagItem> tagResource_tag = new List<DescribeLiveTagResourcesResponse.DescribeLiveTagResources_TagResource.DescribeLiveTagResources_TagItem>();
				for (int j = 0; j < context.Length("DescribeLiveTagResources.TagResources["+ i +"].Tag.Length"); j++) {
					DescribeLiveTagResourcesResponse.DescribeLiveTagResources_TagResource.DescribeLiveTagResources_TagItem tagItem = new DescribeLiveTagResourcesResponse.DescribeLiveTagResources_TagResource.DescribeLiveTagResources_TagItem();
					tagItem.Key = context.StringValue("DescribeLiveTagResources.TagResources["+ i +"].Tag["+ j +"].Key");
					tagItem._Value = context.StringValue("DescribeLiveTagResources.TagResources["+ i +"].Tag["+ j +"].Value");

					tagResource_tag.Add(tagItem);
				}
				tagResource.Tag = tagResource_tag;

				describeLiveTagResourcesResponse_tagResources.Add(tagResource);
			}
			describeLiveTagResourcesResponse.TagResources = describeLiveTagResourcesResponse_tagResources;
        
			return describeLiveTagResourcesResponse;
        }
    }
}
