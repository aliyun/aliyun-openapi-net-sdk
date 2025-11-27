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
    public class ListMultiAccountResourceRelationshipsResponseUnmarshaller
    {
        public static ListMultiAccountResourceRelationshipsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMultiAccountResourceRelationshipsResponse listMultiAccountResourceRelationshipsResponse = new ListMultiAccountResourceRelationshipsResponse();

			listMultiAccountResourceRelationshipsResponse.HttpResponse = _ctx.HttpResponse;
			listMultiAccountResourceRelationshipsResponse.RequestId = _ctx.StringValue("ListMultiAccountResourceRelationships.RequestId");
			listMultiAccountResourceRelationshipsResponse.MaxResults = _ctx.IntegerValue("ListMultiAccountResourceRelationships.MaxResults");
			listMultiAccountResourceRelationshipsResponse.NextToken = _ctx.StringValue("ListMultiAccountResourceRelationships.NextToken");
			listMultiAccountResourceRelationshipsResponse.Scope = _ctx.StringValue("ListMultiAccountResourceRelationships.Scope");

			List<ListMultiAccountResourceRelationshipsResponse.ListMultiAccountResourceRelationships_ResourceRelationship> listMultiAccountResourceRelationshipsResponse_resourceRelationships = new List<ListMultiAccountResourceRelationshipsResponse.ListMultiAccountResourceRelationships_ResourceRelationship>();
			for (int i = 0; i < _ctx.Length("ListMultiAccountResourceRelationships.ResourceRelationships.Length"); i++) {
				ListMultiAccountResourceRelationshipsResponse.ListMultiAccountResourceRelationships_ResourceRelationship resourceRelationship = new ListMultiAccountResourceRelationshipsResponse.ListMultiAccountResourceRelationships_ResourceRelationship();
				resourceRelationship.AccountId = _ctx.StringValue("ListMultiAccountResourceRelationships.ResourceRelationships["+ i +"].AccountId");
				resourceRelationship.RegionId = _ctx.StringValue("ListMultiAccountResourceRelationships.ResourceRelationships["+ i +"].RegionId");
				resourceRelationship.ResourceType = _ctx.StringValue("ListMultiAccountResourceRelationships.ResourceRelationships["+ i +"].ResourceType");
				resourceRelationship.ResourceId = _ctx.StringValue("ListMultiAccountResourceRelationships.ResourceRelationships["+ i +"].ResourceId");
				resourceRelationship.RelatedResourceRegionId = _ctx.StringValue("ListMultiAccountResourceRelationships.ResourceRelationships["+ i +"].RelatedResourceRegionId");
				resourceRelationship.RelatedResourceType = _ctx.StringValue("ListMultiAccountResourceRelationships.ResourceRelationships["+ i +"].RelatedResourceType");
				resourceRelationship.RelatedResourceId = _ctx.StringValue("ListMultiAccountResourceRelationships.ResourceRelationships["+ i +"].RelatedResourceId");

				listMultiAccountResourceRelationshipsResponse_resourceRelationships.Add(resourceRelationship);
			}
			listMultiAccountResourceRelationshipsResponse.ResourceRelationships = listMultiAccountResourceRelationshipsResponse_resourceRelationships;
        
			return listMultiAccountResourceRelationshipsResponse;
        }
    }
}
