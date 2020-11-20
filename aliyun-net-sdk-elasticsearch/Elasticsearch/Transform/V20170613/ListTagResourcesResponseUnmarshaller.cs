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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class ListTagResourcesResponseUnmarshaller
    {
        public static ListTagResourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTagResourcesResponse listTagResourcesResponse = new ListTagResourcesResponse();

			listTagResourcesResponse.HttpResponse = _ctx.HttpResponse;
			listTagResourcesResponse.RequestId = _ctx.StringValue("ListTagResources.RequestId");
			listTagResourcesResponse.PageSize = _ctx.IntegerValue("ListTagResources.PageSize");

			ListTagResourcesResponse.ListTagResources_Headers headers = new ListTagResourcesResponse.ListTagResources_Headers();
			headers.XTotalCount = _ctx.IntegerValue("ListTagResources.Headers.X-Total-Count");
			listTagResourcesResponse.Headers = headers;

			ListTagResourcesResponse.ListTagResources_TagResources tagResources = new ListTagResourcesResponse.ListTagResources_TagResources();

			List<ListTagResourcesResponse.ListTagResources_TagResources.ListTagResources_TagResourceItem> tagResources_tagResource = new List<ListTagResourcesResponse.ListTagResources_TagResources.ListTagResources_TagResourceItem>();
			for (int i = 0; i < _ctx.Length("ListTagResources.TagResources.TagResource.Length"); i++) {
				ListTagResourcesResponse.ListTagResources_TagResources.ListTagResources_TagResourceItem tagResourceItem = new ListTagResourcesResponse.ListTagResources_TagResources.ListTagResources_TagResourceItem();
				tagResourceItem.ResourceId = _ctx.StringValue("ListTagResources.TagResources.TagResource["+ i +"].ResourceId");
				tagResourceItem.ResourceType = _ctx.StringValue("ListTagResources.TagResources.TagResource["+ i +"].ResourceType");
				tagResourceItem.TagKey = _ctx.StringValue("ListTagResources.TagResources.TagResource["+ i +"].TagKey");
				tagResourceItem.TagValue = _ctx.StringValue("ListTagResources.TagResources.TagResource["+ i +"].TagValue");

				tagResources_tagResource.Add(tagResourceItem);
			}
			tagResources.TagResource = tagResources_tagResource;
			listTagResourcesResponse.TagResources = tagResources;
        
			return listTagResourcesResponse;
        }
    }
}
