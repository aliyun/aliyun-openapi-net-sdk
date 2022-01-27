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
using Aliyun.Acs.Config.Model.V20190108;

namespace Aliyun.Acs.Config.Transform.V20190108
{
    public class ListAggregateDiscoveredResourcesResponseUnmarshaller
    {
        public static ListAggregateDiscoveredResourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAggregateDiscoveredResourcesResponse listAggregateDiscoveredResourcesResponse = new ListAggregateDiscoveredResourcesResponse();

			listAggregateDiscoveredResourcesResponse.HttpResponse = _ctx.HttpResponse;
			listAggregateDiscoveredResourcesResponse.RequestId = _ctx.StringValue("ListAggregateDiscoveredResources.RequestId");

			ListAggregateDiscoveredResourcesResponse.ListAggregateDiscoveredResources_DiscoveredResourceProfiles discoveredResourceProfiles = new ListAggregateDiscoveredResourcesResponse.ListAggregateDiscoveredResources_DiscoveredResourceProfiles();
			discoveredResourceProfiles.PageNumber = _ctx.IntegerValue("ListAggregateDiscoveredResources.DiscoveredResourceProfiles.PageNumber");
			discoveredResourceProfiles.PageSize = _ctx.IntegerValue("ListAggregateDiscoveredResources.DiscoveredResourceProfiles.PageSize");
			discoveredResourceProfiles.TotalCount = _ctx.IntegerValue("ListAggregateDiscoveredResources.DiscoveredResourceProfiles.TotalCount");

			List<ListAggregateDiscoveredResourcesResponse.ListAggregateDiscoveredResources_DiscoveredResourceProfiles.ListAggregateDiscoveredResources_DiscoveredResourceProfile> discoveredResourceProfiles_discoveredResourceProfileList = new List<ListAggregateDiscoveredResourcesResponse.ListAggregateDiscoveredResources_DiscoveredResourceProfiles.ListAggregateDiscoveredResources_DiscoveredResourceProfile>();
			for (int i = 0; i < _ctx.Length("ListAggregateDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList.Length"); i++) {
				ListAggregateDiscoveredResourcesResponse.ListAggregateDiscoveredResources_DiscoveredResourceProfiles.ListAggregateDiscoveredResources_DiscoveredResourceProfile discoveredResourceProfile = new ListAggregateDiscoveredResourcesResponse.ListAggregateDiscoveredResources_DiscoveredResourceProfiles.ListAggregateDiscoveredResources_DiscoveredResourceProfile();
				discoveredResourceProfile.ResourceType = _ctx.StringValue("ListAggregateDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].ResourceType");
				discoveredResourceProfile.Region = _ctx.StringValue("ListAggregateDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].Region");
				discoveredResourceProfile.ResourceCreationTime = _ctx.LongValue("ListAggregateDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].ResourceCreationTime");
				discoveredResourceProfile.Tags = _ctx.StringValue("ListAggregateDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].Tags");
				discoveredResourceProfile.AccountId = _ctx.LongValue("ListAggregateDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].AccountId");
				discoveredResourceProfile.ResourceId = _ctx.StringValue("ListAggregateDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].ResourceId");
				discoveredResourceProfile.ResourceName = _ctx.StringValue("ListAggregateDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].ResourceName");
				discoveredResourceProfile.ResourceDeleted = _ctx.IntegerValue("ListAggregateDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].ResourceDeleted");
				discoveredResourceProfile.ResourceStatus = _ctx.StringValue("ListAggregateDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].ResourceStatus");
				discoveredResourceProfile.ResourceOwnerId = _ctx.LongValue("ListAggregateDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].ResourceOwnerId");

				discoveredResourceProfiles_discoveredResourceProfileList.Add(discoveredResourceProfile);
			}
			discoveredResourceProfiles.DiscoveredResourceProfileList = discoveredResourceProfiles_discoveredResourceProfileList;
			listAggregateDiscoveredResourcesResponse.DiscoveredResourceProfiles = discoveredResourceProfiles;
        
			return listAggregateDiscoveredResourcesResponse;
        }
    }
}
