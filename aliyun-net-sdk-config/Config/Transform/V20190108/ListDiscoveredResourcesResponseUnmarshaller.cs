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
    public class ListDiscoveredResourcesResponseUnmarshaller
    {
        public static ListDiscoveredResourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDiscoveredResourcesResponse listDiscoveredResourcesResponse = new ListDiscoveredResourcesResponse();

			listDiscoveredResourcesResponse.HttpResponse = _ctx.HttpResponse;
			listDiscoveredResourcesResponse.RequestId = _ctx.StringValue("ListDiscoveredResources.RequestId");

			ListDiscoveredResourcesResponse.ListDiscoveredResources_DiscoveredResourceProfiles discoveredResourceProfiles = new ListDiscoveredResourcesResponse.ListDiscoveredResources_DiscoveredResourceProfiles();
			discoveredResourceProfiles.PageNumber = _ctx.IntegerValue("ListDiscoveredResources.DiscoveredResourceProfiles.PageNumber");
			discoveredResourceProfiles.PageSize = _ctx.IntegerValue("ListDiscoveredResources.DiscoveredResourceProfiles.PageSize");
			discoveredResourceProfiles.TotalCount = _ctx.IntegerValue("ListDiscoveredResources.DiscoveredResourceProfiles.TotalCount");

			List<ListDiscoveredResourcesResponse.ListDiscoveredResources_DiscoveredResourceProfiles.ListDiscoveredResources_DiscoveredResourceProfile> discoveredResourceProfiles_discoveredResourceProfileList = new List<ListDiscoveredResourcesResponse.ListDiscoveredResources_DiscoveredResourceProfiles.ListDiscoveredResources_DiscoveredResourceProfile>();
			for (int i = 0; i < _ctx.Length("ListDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList.Length"); i++) {
				ListDiscoveredResourcesResponse.ListDiscoveredResources_DiscoveredResourceProfiles.ListDiscoveredResources_DiscoveredResourceProfile discoveredResourceProfile = new ListDiscoveredResourcesResponse.ListDiscoveredResources_DiscoveredResourceProfiles.ListDiscoveredResources_DiscoveredResourceProfile();
				discoveredResourceProfile.AccountId = _ctx.LongValue("ListDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].AccountId");
				discoveredResourceProfile.Region = _ctx.StringValue("ListDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].Region");
				discoveredResourceProfile.ResourceCreationTime = _ctx.LongValue("ListDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].ResourceCreationTime");
				discoveredResourceProfile.ResourceDeleted = _ctx.IntegerValue("ListDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].ResourceDeleted");
				discoveredResourceProfile.ResourceId = _ctx.StringValue("ListDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].ResourceId");
				discoveredResourceProfile.ResourceName = _ctx.StringValue("ListDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].ResourceName");
				discoveredResourceProfile.ResourceStatus = _ctx.StringValue("ListDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].ResourceStatus");
				discoveredResourceProfile.ResourceType = _ctx.StringValue("ListDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].ResourceType");
				discoveredResourceProfile.Tags = _ctx.StringValue("ListDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].Tags");

				discoveredResourceProfiles_discoveredResourceProfileList.Add(discoveredResourceProfile);
			}
			discoveredResourceProfiles.DiscoveredResourceProfileList = discoveredResourceProfiles_discoveredResourceProfileList;
			listDiscoveredResourcesResponse.DiscoveredResourceProfiles = discoveredResourceProfiles;
        
			return listDiscoveredResourcesResponse;
        }
    }
}
