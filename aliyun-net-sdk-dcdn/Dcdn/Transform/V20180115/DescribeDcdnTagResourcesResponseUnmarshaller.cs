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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnTagResourcesResponseUnmarshaller
    {
        public static DescribeDcdnTagResourcesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnTagResourcesResponse describeDcdnTagResourcesResponse = new DescribeDcdnTagResourcesResponse();

			describeDcdnTagResourcesResponse.HttpResponse = context.HttpResponse;
			describeDcdnTagResourcesResponse.RequestId = context.StringValue("DescribeDcdnTagResources.RequestId");

			List<DescribeDcdnTagResourcesResponse.DescribeDcdnTagResources_TagResource> describeDcdnTagResourcesResponse_tagResources = new List<DescribeDcdnTagResourcesResponse.DescribeDcdnTagResources_TagResource>();
			for (int i = 0; i < context.Length("DescribeDcdnTagResources.TagResources.Length"); i++) {
				DescribeDcdnTagResourcesResponse.DescribeDcdnTagResources_TagResource tagResource = new DescribeDcdnTagResourcesResponse.DescribeDcdnTagResources_TagResource();
				tagResource.ResourceId = context.StringValue("DescribeDcdnTagResources.TagResources["+ i +"].ResourceId");

				List<DescribeDcdnTagResourcesResponse.DescribeDcdnTagResources_TagResource.DescribeDcdnTagResources_TagItem> tagResource_tag = new List<DescribeDcdnTagResourcesResponse.DescribeDcdnTagResources_TagResource.DescribeDcdnTagResources_TagItem>();
				for (int j = 0; j < context.Length("DescribeDcdnTagResources.TagResources["+ i +"].Tag.Length"); j++) {
					DescribeDcdnTagResourcesResponse.DescribeDcdnTagResources_TagResource.DescribeDcdnTagResources_TagItem tagItem = new DescribeDcdnTagResourcesResponse.DescribeDcdnTagResources_TagResource.DescribeDcdnTagResources_TagItem();
					tagItem.Key = context.StringValue("DescribeDcdnTagResources.TagResources["+ i +"].Tag["+ j +"].Key");
					tagItem._Value = context.StringValue("DescribeDcdnTagResources.TagResources["+ i +"].Tag["+ j +"].Value");

					tagResource_tag.Add(tagItem);
				}
				tagResource.Tag = tagResource_tag;

				describeDcdnTagResourcesResponse_tagResources.Add(tagResource);
			}
			describeDcdnTagResourcesResponse.TagResources = describeDcdnTagResourcesResponse_tagResources;
        
			return describeDcdnTagResourcesResponse;
        }
    }
}
