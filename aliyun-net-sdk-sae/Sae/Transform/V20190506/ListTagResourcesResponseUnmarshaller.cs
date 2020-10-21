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
        public static ListTagResourcesResponse Unmarshall(UnmarshallerContext context)
        {
			ListTagResourcesResponse listTagResourcesResponse = new ListTagResourcesResponse();

			listTagResourcesResponse.HttpResponse = context.HttpResponse;
			listTagResourcesResponse.Code = context.StringValue("ListTagResources.Code");
			listTagResourcesResponse.ErrorCode = context.StringValue("ListTagResources.ErrorCode");
			listTagResourcesResponse.Message = context.StringValue("ListTagResources.Message");
			listTagResourcesResponse.RequestId = context.StringValue("ListTagResources.RequestId");
			listTagResourcesResponse.Success = context.BooleanValue("ListTagResources.Success");
			listTagResourcesResponse.TraceId = context.StringValue("ListTagResources.TraceId");

			ListTagResourcesResponse.ListTagResources_Data data = new ListTagResourcesResponse.ListTagResources_Data();
			data.NextToken = context.StringValue("ListTagResources.Data.NextToken");

			List<ListTagResourcesResponse.ListTagResources_Data.ListTagResources_TagResource> data_tagResources = new List<ListTagResourcesResponse.ListTagResources_Data.ListTagResources_TagResource>();
			for (int i = 0; i < context.Length("ListTagResources.Data.TagResources.Length"); i++) {
				ListTagResourcesResponse.ListTagResources_Data.ListTagResources_TagResource tagResource = new ListTagResourcesResponse.ListTagResources_Data.ListTagResources_TagResource();
				tagResource.TagKey = context.StringValue("ListTagResources.Data.TagResources["+ i +"].TagKey");
				tagResource.TagValue = context.StringValue("ListTagResources.Data.TagResources["+ i +"].TagValue");
				tagResource.ResourceId = context.StringValue("ListTagResources.Data.TagResources["+ i +"].ResourceId");
				tagResource.ResourceType = context.StringValue("ListTagResources.Data.TagResources["+ i +"].ResourceType");

				data_tagResources.Add(tagResource);
			}
			data.TagResources = data_tagResources;
			listTagResourcesResponse.Data = data;
        
			return listTagResourcesResponse;
        }
    }
}
