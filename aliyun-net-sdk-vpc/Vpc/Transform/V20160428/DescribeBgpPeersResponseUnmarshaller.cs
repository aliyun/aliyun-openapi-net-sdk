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
			describeBgpPeersResponse.RequestId = _ctx.StringValue("DescribeBgpPeers.RequestId");
			describeBgpPeersResponse.TotalCount = _ctx.IntegerValue("DescribeBgpPeers.TotalCount");
			describeBgpPeersResponse.PageNumber = _ctx.IntegerValue("DescribeBgpPeers.PageNumber");
			describeBgpPeersResponse.PageSize = _ctx.IntegerValue("DescribeBgpPeers.PageSize");

			List<DescribeBgpPeersResponse.DescribeBgpPeers_BgpPeer> describeBgpPeersResponse_bgpPeers = new List<DescribeBgpPeersResponse.DescribeBgpPeers_BgpPeer>();
			for (int i = 0; i < _ctx.Length("DescribeBgpPeers.BgpPeers.Length"); i++) {
				DescribeBgpPeersResponse.DescribeBgpPeers_BgpPeer bgpPeer = new DescribeBgpPeersResponse.DescribeBgpPeers_BgpPeer();
				bgpPeer.Name = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].Name");
				bgpPeer.Description = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].Description");
				bgpPeer.BgpPeerId = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].BgpPeerId");
				bgpPeer.BgpGroupId = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].BgpGroupId");
				bgpPeer.PeerIpAddress = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].PeerIpAddress");
				bgpPeer.PeerAsn = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].PeerAsn");
				bgpPeer.AuthKey = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].AuthKey");
				bgpPeer.RouterId = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].RouterId");
				bgpPeer.BgpStatus = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].BgpStatus");
				bgpPeer.Status = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].Status");
				bgpPeer.Keepalive = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].Keepalive");
				bgpPeer.LocalAsn = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].LocalAsn");
				bgpPeer.Hold = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].Hold");
				bgpPeer.IsFake = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].IsFake");
				bgpPeer.RouteLimit = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].RouteLimit");
				bgpPeer.RegionId = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].RegionId");
				bgpPeer.EnableBfd = _ctx.BooleanValue("DescribeBgpPeers.BgpPeers["+ i +"].EnableBfd");
				bgpPeer.IpVersion = _ctx.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].IpVersion");
				bgpPeer.BfdMultiHop = _ctx.IntegerValue("DescribeBgpPeers.BgpPeers["+ i +"].BfdMultiHop");

				describeBgpPeersResponse_bgpPeers.Add(bgpPeer);
			}
			describeBgpPeersResponse.BgpPeers = describeBgpPeersResponse_bgpPeers;
        
			return describeBgpPeersResponse;
        }
    }
}
