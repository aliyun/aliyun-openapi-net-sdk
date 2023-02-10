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
    public class GetVpcPrefixListAssociationsResponseUnmarshaller
    {
        public static GetVpcPrefixListAssociationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVpcPrefixListAssociationsResponse getVpcPrefixListAssociationsResponse = new GetVpcPrefixListAssociationsResponse();

			getVpcPrefixListAssociationsResponse.HttpResponse = _ctx.HttpResponse;
			getVpcPrefixListAssociationsResponse.RequestId = _ctx.StringValue("GetVpcPrefixListAssociations.RequestId");
			getVpcPrefixListAssociationsResponse.NextToken = _ctx.StringValue("GetVpcPrefixListAssociations.NextToken");
			getVpcPrefixListAssociationsResponse.TotalCount = _ctx.LongValue("GetVpcPrefixListAssociations.TotalCount");
			getVpcPrefixListAssociationsResponse.Count = _ctx.LongValue("GetVpcPrefixListAssociations.Count");

			List<GetVpcPrefixListAssociationsResponse.GetVpcPrefixListAssociations_PrefixListAssociations> getVpcPrefixListAssociationsResponse_prefixListAssociation = new List<GetVpcPrefixListAssociationsResponse.GetVpcPrefixListAssociations_PrefixListAssociations>();
			for (int i = 0; i < _ctx.Length("GetVpcPrefixListAssociations.PrefixListAssociation.Length"); i++) {
				GetVpcPrefixListAssociationsResponse.GetVpcPrefixListAssociations_PrefixListAssociations prefixListAssociations = new GetVpcPrefixListAssociationsResponse.GetVpcPrefixListAssociations_PrefixListAssociations();
				prefixListAssociations.PrefixListId = _ctx.StringValue("GetVpcPrefixListAssociations.PrefixListAssociation["+ i +"].PrefixListId");
				prefixListAssociations.ResourceId = _ctx.StringValue("GetVpcPrefixListAssociations.PrefixListAssociation["+ i +"].ResourceId");
				prefixListAssociations.ResourceType = _ctx.StringValue("GetVpcPrefixListAssociations.PrefixListAssociation["+ i +"].ResourceType");
				prefixListAssociations.OwnerId = _ctx.StringValue("GetVpcPrefixListAssociations.PrefixListAssociation["+ i +"].OwnerId");
				prefixListAssociations.Status = _ctx.StringValue("GetVpcPrefixListAssociations.PrefixListAssociation["+ i +"].Status");
				prefixListAssociations.Reason = _ctx.StringValue("GetVpcPrefixListAssociations.PrefixListAssociation["+ i +"].Reason");
				prefixListAssociations.RegionId = _ctx.StringValue("GetVpcPrefixListAssociations.PrefixListAssociation["+ i +"].RegionId");
				prefixListAssociations.ResourceUid = _ctx.StringValue("GetVpcPrefixListAssociations.PrefixListAssociation["+ i +"].ResourceUid");

				getVpcPrefixListAssociationsResponse_prefixListAssociation.Add(prefixListAssociations);
			}
			getVpcPrefixListAssociationsResponse.PrefixListAssociation = getVpcPrefixListAssociationsResponse_prefixListAssociation;
        
			return getVpcPrefixListAssociationsResponse;
        }
    }
}
