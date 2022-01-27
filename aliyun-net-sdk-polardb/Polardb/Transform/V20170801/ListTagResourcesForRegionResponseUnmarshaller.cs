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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class ListTagResourcesForRegionResponseUnmarshaller
    {
        public static ListTagResourcesForRegionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTagResourcesForRegionResponse listTagResourcesForRegionResponse = new ListTagResourcesForRegionResponse();

			listTagResourcesForRegionResponse.HttpResponse = _ctx.HttpResponse;
			listTagResourcesForRegionResponse.NextToken = _ctx.StringValue("ListTagResourcesForRegion.NextToken");
			listTagResourcesForRegionResponse.RequestId = _ctx.StringValue("ListTagResourcesForRegion.RequestId");

			List<ListTagResourcesForRegionResponse.ListTagResourcesForRegion_TagResource> listTagResourcesForRegionResponse_tagResources = new List<ListTagResourcesForRegionResponse.ListTagResourcesForRegion_TagResource>();
			for (int i = 0; i < _ctx.Length("ListTagResourcesForRegion.TagResources.Length"); i++) {
				ListTagResourcesForRegionResponse.ListTagResourcesForRegion_TagResource tagResource = new ListTagResourcesForRegionResponse.ListTagResourcesForRegion_TagResource();
				tagResource.ResourceType = _ctx.StringValue("ListTagResourcesForRegion.TagResources["+ i +"].ResourceType");
				tagResource.TagValue = _ctx.StringValue("ListTagResourcesForRegion.TagResources["+ i +"].TagValue");
				tagResource.ResourceId = _ctx.StringValue("ListTagResourcesForRegion.TagResources["+ i +"].ResourceId");
				tagResource.TagKey = _ctx.StringValue("ListTagResourcesForRegion.TagResources["+ i +"].TagKey");

				listTagResourcesForRegionResponse_tagResources.Add(tagResource);
			}
			listTagResourcesForRegionResponse.TagResources = listTagResourcesForRegionResponse_tagResources;
        
			return listTagResourcesForRegionResponse;
        }
    }
}
