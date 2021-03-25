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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class ListTagResourcesResponseUnmarshaller
    {
        public static ListTagResourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTagResourcesResponse listTagResourcesResponse = new ListTagResourcesResponse();

			listTagResourcesResponse.HttpResponse = _ctx.HttpResponse;
			listTagResourcesResponse.Code = _ctx.StringValue("ListTagResources.Code");
			listTagResourcesResponse.ErrorCode = _ctx.StringValue("ListTagResources.ErrorCode");
			listTagResourcesResponse.Message = _ctx.StringValue("ListTagResources.Message");
			listTagResourcesResponse.RequestId = _ctx.StringValue("ListTagResources.RequestId");
			listTagResourcesResponse.Success = _ctx.BooleanValue("ListTagResources.Success");
			listTagResourcesResponse.TraceId = _ctx.StringValue("ListTagResources.TraceId");

			ListTagResourcesResponse.ListTagResources_Data data = new ListTagResourcesResponse.ListTagResources_Data();
			data.NextToken = _ctx.StringValue("ListTagResources.Data.NextToken");

			List<ListTagResourcesResponse.ListTagResources_Data.ListTagResources_TagResource> data_tagResources = new List<ListTagResourcesResponse.ListTagResources_Data.ListTagResources_TagResource>();
			for (int i = 0; i < _ctx.Length("ListTagResources.Data.TagResources.Length"); i++) {
				ListTagResourcesResponse.ListTagResources_Data.ListTagResources_TagResource tagResource = new ListTagResourcesResponse.ListTagResources_Data.ListTagResources_TagResource();
				tagResource.TagKey = _ctx.StringValue("ListTagResources.Data.TagResources["+ i +"].TagKey");
				tagResource.TagValue = _ctx.StringValue("ListTagResources.Data.TagResources["+ i +"].TagValue");
				tagResource.ResourceId = _ctx.StringValue("ListTagResources.Data.TagResources["+ i +"].ResourceId");
				tagResource.ResourceType = _ctx.StringValue("ListTagResources.Data.TagResources["+ i +"].ResourceType");

				data_tagResources.Add(tagResource);
			}
			data.TagResources = data_tagResources;
			listTagResourcesResponse.Data = data;
        
			return listTagResourcesResponse;
        }
    }
}
