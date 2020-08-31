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
        public static ListDiscoveredResourcesResponse Unmarshall(UnmarshallerContext context)
        {
			ListDiscoveredResourcesResponse listDiscoveredResourcesResponse = new ListDiscoveredResourcesResponse();

			listDiscoveredResourcesResponse.HttpResponse = context.HttpResponse;
			listDiscoveredResourcesResponse.RequestId = context.StringValue("ListDiscoveredResources.RequestId");

			ListDiscoveredResourcesResponse.ListDiscoveredResources_DiscoveredResourceProfiles discoveredResourceProfiles = new ListDiscoveredResourcesResponse.ListDiscoveredResources_DiscoveredResourceProfiles();
			discoveredResourceProfiles.PageNumber = context.IntegerValue("ListDiscoveredResources.DiscoveredResourceProfiles.PageNumber");
			discoveredResourceProfiles.PageSize = context.IntegerValue("ListDiscoveredResources.DiscoveredResourceProfiles.PageSize");
			discoveredResourceProfiles.TotalCount = context.IntegerValue("ListDiscoveredResources.DiscoveredResourceProfiles.TotalCount");

			List<ListDiscoveredResourcesResponse.ListDiscoveredResources_DiscoveredResourceProfiles.ListDiscoveredResources_DiscoveredResourceProfile> discoveredResourceProfiles_discoveredResourceProfileList = new List<ListDiscoveredResourcesResponse.ListDiscoveredResources_DiscoveredResourceProfiles.ListDiscoveredResources_DiscoveredResourceProfile>();
			for (int i = 0; i < context.Length("ListDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList.Length"); i++) {
				ListDiscoveredResourcesResponse.ListDiscoveredResources_DiscoveredResourceProfiles.ListDiscoveredResources_DiscoveredResourceProfile discoveredResourceProfile = new ListDiscoveredResourcesResponse.ListDiscoveredResources_DiscoveredResourceProfiles.ListDiscoveredResources_DiscoveredResourceProfile();
				discoveredResourceProfile.AccountId = context.LongValue("ListDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].AccountId");
				discoveredResourceProfile.Region = context.StringValue("ListDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].Region");
				discoveredResourceProfile.ResourceCreationTime = context.LongValue("ListDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].ResourceCreationTime");
				discoveredResourceProfile.ResourceDeleted = context.IntegerValue("ListDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].ResourceDeleted");
				discoveredResourceProfile.ResourceId = context.StringValue("ListDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].ResourceId");
				discoveredResourceProfile.ResourceName = context.StringValue("ListDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].ResourceName");
				discoveredResourceProfile.ResourceStatus = context.StringValue("ListDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].ResourceStatus");
				discoveredResourceProfile.ResourceType = context.StringValue("ListDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].ResourceType");
				discoveredResourceProfile.Tags = context.StringValue("ListDiscoveredResources.DiscoveredResourceProfiles.DiscoveredResourceProfileList["+ i +"].Tags");

				discoveredResourceProfiles_discoveredResourceProfileList.Add(discoveredResourceProfile);
			}
			discoveredResourceProfiles.DiscoveredResourceProfileList = discoveredResourceProfiles_discoveredResourceProfileList;
			listDiscoveredResourcesResponse.DiscoveredResourceProfiles = discoveredResourceProfiles;
        
			return listDiscoveredResourcesResponse;
        }
    }
}
