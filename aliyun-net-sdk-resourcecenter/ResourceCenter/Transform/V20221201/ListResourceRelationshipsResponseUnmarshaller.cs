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
using Aliyun.Acs.ResourceCenter.Model.V20221201;

namespace Aliyun.Acs.ResourceCenter.Transform.V20221201
{
    public class ListResourceRelationshipsResponseUnmarshaller
    {
        public static ListResourceRelationshipsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListResourceRelationshipsResponse listResourceRelationshipsResponse = new ListResourceRelationshipsResponse();

			listResourceRelationshipsResponse.HttpResponse = _ctx.HttpResponse;
			listResourceRelationshipsResponse.RequestId = _ctx.StringValue("ListResourceRelationships.RequestId");
			listResourceRelationshipsResponse.MaxResults = _ctx.IntegerValue("ListResourceRelationships.MaxResults");
			listResourceRelationshipsResponse.NextToken = _ctx.StringValue("ListResourceRelationships.NextToken");

			List<ListResourceRelationshipsResponse.ListResourceRelationships_ResourceRelationship> listResourceRelationshipsResponse_resourceRelationships = new List<ListResourceRelationshipsResponse.ListResourceRelationships_ResourceRelationship>();
			for (int i = 0; i < _ctx.Length("ListResourceRelationships.ResourceRelationships.Length"); i++) {
				ListResourceRelationshipsResponse.ListResourceRelationships_ResourceRelationship resourceRelationship = new ListResourceRelationshipsResponse.ListResourceRelationships_ResourceRelationship();
				resourceRelationship.RegionId = _ctx.StringValue("ListResourceRelationships.ResourceRelationships["+ i +"].RegionId");
				resourceRelationship.ResourceType = _ctx.StringValue("ListResourceRelationships.ResourceRelationships["+ i +"].ResourceType");
				resourceRelationship.ResourceId = _ctx.StringValue("ListResourceRelationships.ResourceRelationships["+ i +"].ResourceId");
				resourceRelationship.RelatedResourceRegionId = _ctx.StringValue("ListResourceRelationships.ResourceRelationships["+ i +"].RelatedResourceRegionId");
				resourceRelationship.RelatedResourceType = _ctx.StringValue("ListResourceRelationships.ResourceRelationships["+ i +"].RelatedResourceType");
				resourceRelationship.RelatedResourceId = _ctx.StringValue("ListResourceRelationships.ResourceRelationships["+ i +"].RelatedResourceId");

				listResourceRelationshipsResponse_resourceRelationships.Add(resourceRelationship);
			}
			listResourceRelationshipsResponse.ResourceRelationships = listResourceRelationshipsResponse_resourceRelationships;
        
			return listResourceRelationshipsResponse;
        }
    }
}
