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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Vpc.Model.V20160428;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeBgpGroupsResponseUnmarshaller
    {
        public static DescribeBgpGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBgpGroupsResponse describeBgpGroupsResponse = new DescribeBgpGroupsResponse();

			describeBgpGroupsResponse.HttpResponse = context.HttpResponse;
			describeBgpGroupsResponse.RequestId = context.StringValue("DescribeBgpGroups.RequestId");
			describeBgpGroupsResponse.TotalCount = context.IntegerValue("DescribeBgpGroups.TotalCount");
			describeBgpGroupsResponse.PageNumber = context.IntegerValue("DescribeBgpGroups.PageNumber");
			describeBgpGroupsResponse.PageSize = context.IntegerValue("DescribeBgpGroups.PageSize");

			List<DescribeBgpGroupsResponse.DescribeBgpGroups_BgpGroup> describeBgpGroupsResponse_bgpGroups = new List<DescribeBgpGroupsResponse.DescribeBgpGroups_BgpGroup>();
			for (int i = 0; i < context.Length("DescribeBgpGroups.BgpGroups.Length"); i++) {
				DescribeBgpGroupsResponse.DescribeBgpGroups_BgpGroup bgpGroup = new DescribeBgpGroupsResponse.DescribeBgpGroups_BgpGroup();
				bgpGroup.Name = context.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].Name");
				bgpGroup.Description = context.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].Description");
				bgpGroup.BgpGroupId = context.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].BgpGroupId");
				bgpGroup.PeerAsn = context.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].PeerAsn");
				bgpGroup.AuthKey = context.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].AuthKey");
				bgpGroup.RouterId = context.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].RouterId");
				bgpGroup.Status = context.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].Status");
				bgpGroup.Keepalive = context.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].Keepalive");
				bgpGroup.LocalAsn = context.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].LocalAsn");
				bgpGroup.Hold = context.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].Hold");
				bgpGroup.IsFake = context.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].IsFake");
				bgpGroup.RouteLimit = context.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].RouteLimit");
				bgpGroup.RegionId = context.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].RegionId");

				describeBgpGroupsResponse_bgpGroups.Add(bgpGroup);
			}
			describeBgpGroupsResponse.BgpGroups = describeBgpGroupsResponse_bgpGroups;
        
			return describeBgpGroupsResponse;
        }
    }
}