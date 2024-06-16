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
using Aliyun.Acs.ResourceSharing.Model.V20200110;

namespace Aliyun.Acs.ResourceSharing.Transform.V20200110
{
    public class ListSharedResourcesResponseUnmarshaller
    {
        public static ListSharedResourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSharedResourcesResponse listSharedResourcesResponse = new ListSharedResourcesResponse();

			listSharedResourcesResponse.HttpResponse = _ctx.HttpResponse;
			listSharedResourcesResponse.NextToken = _ctx.StringValue("ListSharedResources.NextToken");
			listSharedResourcesResponse.RequestId = _ctx.StringValue("ListSharedResources.RequestId");

			List<ListSharedResourcesResponse.ListSharedResources_SharedResource> listSharedResourcesResponse_sharedResources = new List<ListSharedResourcesResponse.ListSharedResources_SharedResource>();
			for (int i = 0; i < _ctx.Length("ListSharedResources.SharedResources.Length"); i++) {
				ListSharedResourcesResponse.ListSharedResources_SharedResource sharedResource = new ListSharedResourcesResponse.ListSharedResources_SharedResource();
				sharedResource.UpdateTime = _ctx.StringValue("ListSharedResources.SharedResources["+ i +"].UpdateTime");
				sharedResource.ResourceType = _ctx.StringValue("ListSharedResources.SharedResources["+ i +"].ResourceType");
				sharedResource.CreateTime = _ctx.StringValue("ListSharedResources.SharedResources["+ i +"].CreateTime");
				sharedResource.ResourceShareId = _ctx.StringValue("ListSharedResources.SharedResources["+ i +"].ResourceShareId");
				sharedResource.ResourceId = _ctx.StringValue("ListSharedResources.SharedResources["+ i +"].ResourceId");
				sharedResource.ResourceStatus = _ctx.StringValue("ListSharedResources.SharedResources["+ i +"].ResourceStatus");
				sharedResource.ResourceStatusMessage = _ctx.StringValue("ListSharedResources.SharedResources["+ i +"].ResourceStatusMessage");

				listSharedResourcesResponse_sharedResources.Add(sharedResource);
			}
			listSharedResourcesResponse.SharedResources = listSharedResourcesResponse_sharedResources;
        
			return listSharedResourcesResponse;
        }
    }
}
