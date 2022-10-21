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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class ListTagResourcesForExpressConnectResponseUnmarshaller
    {
        public static ListTagResourcesForExpressConnectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTagResourcesForExpressConnectResponse listTagResourcesForExpressConnectResponse = new ListTagResourcesForExpressConnectResponse();

			listTagResourcesForExpressConnectResponse.HttpResponse = _ctx.HttpResponse;
			listTagResourcesForExpressConnectResponse.NextToken = _ctx.StringValue("ListTagResourcesForExpressConnect.NextToken");
			listTagResourcesForExpressConnectResponse.RequestId = _ctx.StringValue("ListTagResourcesForExpressConnect.RequestId");

			List<ListTagResourcesForExpressConnectResponse.ListTagResourcesForExpressConnect_TagResource> listTagResourcesForExpressConnectResponse_tagResources = new List<ListTagResourcesForExpressConnectResponse.ListTagResourcesForExpressConnect_TagResource>();
			for (int i = 0; i < _ctx.Length("ListTagResourcesForExpressConnect.TagResources.Length"); i++) {
				ListTagResourcesForExpressConnectResponse.ListTagResourcesForExpressConnect_TagResource tagResource = new ListTagResourcesForExpressConnectResponse.ListTagResourcesForExpressConnect_TagResource();
				tagResource.ResourcId = _ctx.StringValue("ListTagResourcesForExpressConnect.TagResources["+ i +"].ResourcId");
				tagResource.ResourceType = _ctx.StringValue("ListTagResourcesForExpressConnect.TagResources["+ i +"].ResourceType");
				tagResource.TagValue = _ctx.StringValue("ListTagResourcesForExpressConnect.TagResources["+ i +"].TagValue");
				tagResource.ResourceId = _ctx.StringValue("ListTagResourcesForExpressConnect.TagResources["+ i +"].ResourceId");
				tagResource.TagKey = _ctx.StringValue("ListTagResourcesForExpressConnect.TagResources["+ i +"].TagKey");

				listTagResourcesForExpressConnectResponse_tagResources.Add(tagResource);
			}
			listTagResourcesForExpressConnectResponse.TagResources = listTagResourcesForExpressConnectResponse_tagResources;
        
			return listTagResourcesForExpressConnectResponse;
        }
    }
}
