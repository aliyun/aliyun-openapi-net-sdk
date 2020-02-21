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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class ListTagResourcesResponseUnmarshaller
    {
        public static ListTagResourcesResponse Unmarshall(UnmarshallerContext context)
        {
			ListTagResourcesResponse listTagResourcesResponse = new ListTagResourcesResponse();

			listTagResourcesResponse.HttpResponse = context.HttpResponse;
			listTagResourcesResponse.RequestId = context.StringValue("ListTagResources.RequestId");
			listTagResourcesResponse.NextToken = context.StringValue("ListTagResources.NextToken");

			List<ListTagResourcesResponse.ListTagResources_TagResource> listTagResourcesResponse_tagResources = new List<ListTagResourcesResponse.ListTagResources_TagResource>();
			for (int i = 0; i < context.Length("ListTagResources.TagResources.Length"); i++) {
				ListTagResourcesResponse.ListTagResources_TagResource tagResource = new ListTagResourcesResponse.ListTagResources_TagResource();
				tagResource.TagKey = context.StringValue("ListTagResources.TagResources["+ i +"].TagKey");
				tagResource.TagValue = context.StringValue("ListTagResources.TagResources["+ i +"].TagValue");
				tagResource.ResourceId = context.StringValue("ListTagResources.TagResources["+ i +"].ResourceId");
				tagResource.ResourceType = context.StringValue("ListTagResources.TagResources["+ i +"].ResourceType");

				listTagResourcesResponse_tagResources.Add(tagResource);
			}
			listTagResourcesResponse.TagResources = listTagResourcesResponse_tagResources;
        
			return listTagResourcesResponse;
        }
    }
}
