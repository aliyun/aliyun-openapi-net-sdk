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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeTenantTagsResponseUnmarshaller
    {
        public static DescribeTenantTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTenantTagsResponse describeTenantTagsResponse = new DescribeTenantTagsResponse();

			describeTenantTagsResponse.HttpResponse = _ctx.HttpResponse;
			describeTenantTagsResponse.RequestId = _ctx.StringValue("DescribeTenantTags.RequestId");

			List<DescribeTenantTagsResponse.DescribeTenantTags_TagResourcesItem> describeTenantTagsResponse_tagResources = new List<DescribeTenantTagsResponse.DescribeTenantTags_TagResourcesItem>();
			for (int i = 0; i < _ctx.Length("DescribeTenantTags.TagResources.Length"); i++) {
				DescribeTenantTagsResponse.DescribeTenantTags_TagResourcesItem tagResourcesItem = new DescribeTenantTagsResponse.DescribeTenantTags_TagResourcesItem();
				tagResourcesItem.ResourceId = _ctx.StringValue("DescribeTenantTags.TagResources["+ i +"].ResourceId");
				tagResourcesItem.ResourceType = _ctx.StringValue("DescribeTenantTags.TagResources["+ i +"].ResourceType");
				tagResourcesItem.Tag = _ctx.StringValue("DescribeTenantTags.TagResources["+ i +"].Tag");

				describeTenantTagsResponse_tagResources.Add(tagResourcesItem);
			}
			describeTenantTagsResponse.TagResources = describeTenantTagsResponse_tagResources;
        
			return describeTenantTagsResponse;
        }
    }
}
