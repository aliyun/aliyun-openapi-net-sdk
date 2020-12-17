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
using Aliyun.Acs.ROS.Model.V20190910;

namespace Aliyun.Acs.ROS.Transform.V20190910
{
    public class ListTagResourcesResponseUnmarshaller
    {
        public static ListTagResourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTagResourcesResponse listTagResourcesResponse = new ListTagResourcesResponse();

			listTagResourcesResponse.HttpResponse = _ctx.HttpResponse;
			listTagResourcesResponse.RequestId = _ctx.StringValue("ListTagResources.RequestId");
			listTagResourcesResponse.NextToken = _ctx.StringValue("ListTagResources.NextToken");

			List<ListTagResourcesResponse.ListTagResources_TagResource> listTagResourcesResponse_tagResources = new List<ListTagResourcesResponse.ListTagResources_TagResource>();
			for (int i = 0; i < _ctx.Length("ListTagResources.TagResources.Length"); i++) {
				ListTagResourcesResponse.ListTagResources_TagResource tagResource = new ListTagResourcesResponse.ListTagResources_TagResource();
				tagResource.ResourceId = _ctx.StringValue("ListTagResources.TagResources["+ i +"].ResourceId");
				tagResource.ResourceType = _ctx.StringValue("ListTagResources.TagResources["+ i +"].ResourceType");
				tagResource.TagKey = _ctx.StringValue("ListTagResources.TagResources["+ i +"].TagKey");
				tagResource.TagValue = _ctx.StringValue("ListTagResources.TagResources["+ i +"].TagValue");

				listTagResourcesResponse_tagResources.Add(tagResource);
			}
			listTagResourcesResponse.TagResources = listTagResourcesResponse_tagResources;
        
			return listTagResourcesResponse;
        }
    }
}
