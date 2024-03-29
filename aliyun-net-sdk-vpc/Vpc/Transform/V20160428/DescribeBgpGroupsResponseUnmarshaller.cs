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
    public class DescribeBgpGroupsResponseUnmarshaller
    {
        public static DescribeBgpGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBgpGroupsResponse describeBgpGroupsResponse = new DescribeBgpGroupsResponse();

			describeBgpGroupsResponse.HttpResponse = _ctx.HttpResponse;
			describeBgpGroupsResponse.PageSize = _ctx.IntegerValue("DescribeBgpGroups.PageSize");
			describeBgpGroupsResponse.RequestId = _ctx.StringValue("DescribeBgpGroups.RequestId");
			describeBgpGroupsResponse.PageNumber = _ctx.IntegerValue("DescribeBgpGroups.PageNumber");
			describeBgpGroupsResponse.TotalCount = _ctx.IntegerValue("DescribeBgpGroups.TotalCount");

			List<DescribeBgpGroupsResponse.DescribeBgpGroups_BgpGroup> describeBgpGroupsResponse_bgpGroups = new List<DescribeBgpGroupsResponse.DescribeBgpGroups_BgpGroup>();
			for (int i = 0; i < _ctx.Length("DescribeBgpGroups.BgpGroups.Length"); i++) {
				DescribeBgpGroupsResponse.DescribeBgpGroups_BgpGroup bgpGroup = new DescribeBgpGroupsResponse.DescribeBgpGroups_BgpGroup();
				bgpGroup.Status = _ctx.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].Status");
				bgpGroup.BgpGroupId = _ctx.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].BgpGroupId");
				bgpGroup.RouterId = _ctx.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].RouterId");
				bgpGroup.PeerAsn = _ctx.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].PeerAsn");
				bgpGroup.LocalAsn = _ctx.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].LocalAsn");
				bgpGroup.RegionId = _ctx.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].RegionId");
				bgpGroup.Hold = _ctx.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].Hold");
				bgpGroup.IpVersion = _ctx.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].IpVersion");
				bgpGroup.Description = _ctx.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].Description");
				bgpGroup.Keepalive = _ctx.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].Keepalive");
				bgpGroup.IsFake = _ctx.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].IsFake");
				bgpGroup.RouteLimit = _ctx.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].RouteLimit");
				bgpGroup.RouteQuota = _ctx.IntegerValue("DescribeBgpGroups.BgpGroups["+ i +"].RouteQuota");
				bgpGroup.Name = _ctx.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].Name");
				bgpGroup.AuthKey = _ctx.StringValue("DescribeBgpGroups.BgpGroups["+ i +"].AuthKey");

				describeBgpGroupsResponse_bgpGroups.Add(bgpGroup);
			}
			describeBgpGroupsResponse.BgpGroups = describeBgpGroupsResponse_bgpGroups;
        
			return describeBgpGroupsResponse;
        }
    }
}
