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
    public class DescribeBgpPeersResponseUnmarshaller
    {
        public static DescribeBgpPeersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBgpPeersResponse describeBgpPeersResponse = new DescribeBgpPeersResponse();

			describeBgpPeersResponse.HttpResponse = _ctx.HttpResponse;
			describeBgpPeersResponse.PageSize = _ctx.IntegerValue("DescribeBgpPeers.PageSize");
			describeBgpPeersResponse.RequestId = _ctx.StringValue("DescribeBgpPeers.RequestId");
			describeBgpPeersResponse.PageNumber = _ctx.IntegerValue("DescribeBgpPeers.PageNumber");
			describeBgpPeersResponse.TotalCount = _ctx.IntegerValue("DescribeBgpPeers.TotalCount");

			List<DescribeBgpPeersResponse.DescribeBgpPeers_BgpPeer> describeBgpPeersResponse_bgpPeers = new List<DescribeBgpPeersResponse.DescribeBgpPeers_BgpPeer>();
			for (int i = 0; i < _ctx.Length("DescribeBgpPeers.BgpPeers.Length"); i++) {
				DescribeBgpPeersResponse.DescribeBgpPeers_BgpPeer bgpPeer = new DescribeBgpPeersResponse.DescribeBgpPeers_BgpPeer();
				bgpPeer.Status = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].Status");
				bgpPeer.PeerIpAddress = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].PeerIpAddress");
				bgpPeer.RouterId = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].RouterId");
				bgpPeer.BgpGroupId = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].BgpGroupId");
				bgpPeer.BgpStatus = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].BgpStatus");
				bgpPeer.BfdMultiHop = _ctx.IntegerValue("DescribeBgpPeers.BgpPeers["+ i +"].BfdMultiHop");
				bgpPeer.PeerAsn = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].PeerAsn");
				bgpPeer.LocalAsn = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].LocalAsn");
				bgpPeer.RegionId = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].RegionId");
				bgpPeer.BgpPeerId = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].BgpPeerId");
				bgpPeer.EnableBfd = _ctx.BooleanValue("DescribeBgpPeers.BgpPeers["+ i +"].EnableBfd");
				bgpPeer.Hold = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].Hold");
				bgpPeer.IpVersion = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].IpVersion");
				bgpPeer.Keepalive = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].Keepalive");
				bgpPeer.Description = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].Description");
				bgpPeer.RouteLimit = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].RouteLimit");
				bgpPeer.IsFake = _ctx.BooleanValue("DescribeBgpPeers.BgpPeers["+ i +"].IsFake");
				bgpPeer.AuthKey = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].AuthKey");
				bgpPeer.Name = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].Name");
				bgpPeer.AdvertisedRouteCount = _ctx.IntegerValue("DescribeBgpPeers.BgpPeers["+ i +"].AdvertisedRouteCount");
				bgpPeer.ReceivedRouteCount = _ctx.IntegerValue("DescribeBgpPeers.BgpPeers["+ i +"].ReceivedRouteCount");
				bgpPeer.GmtModified = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].GmtModified");

				describeBgpPeersResponse_bgpPeers.Add(bgpPeer);
			}
			describeBgpPeersResponse.BgpPeers = describeBgpPeersResponse_bgpPeers;
        
			return describeBgpPeersResponse;
        }
    }
}
