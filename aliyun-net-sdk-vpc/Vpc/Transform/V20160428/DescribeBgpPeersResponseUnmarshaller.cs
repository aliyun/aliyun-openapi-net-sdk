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
    public class DescribeBgpPeersResponseUnmarshaller
    {
        public static DescribeBgpPeersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBgpPeersResponse describeBgpPeersResponse = new DescribeBgpPeersResponse();

			describeBgpPeersResponse.HttpResponse = context.HttpResponse;
			describeBgpPeersResponse.RequestId = context.StringValue("DescribeBgpPeers.RequestId");
			describeBgpPeersResponse.TotalCount = context.IntegerValue("DescribeBgpPeers.TotalCount");
			describeBgpPeersResponse.PageNumber = context.IntegerValue("DescribeBgpPeers.PageNumber");
			describeBgpPeersResponse.PageSize = context.IntegerValue("DescribeBgpPeers.PageSize");

			List<DescribeBgpPeersResponse.DescribeBgpPeers_BgpPeer> describeBgpPeersResponse_bgpPeers = new List<DescribeBgpPeersResponse.DescribeBgpPeers_BgpPeer>();
			for (int i = 0; i < context.Length("DescribeBgpPeers.BgpPeers.Length"); i++) {
				DescribeBgpPeersResponse.DescribeBgpPeers_BgpPeer bgpPeer = new DescribeBgpPeersResponse.DescribeBgpPeers_BgpPeer();
				bgpPeer.Name = context.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].Name");
				bgpPeer.Description = context.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].Description");
				bgpPeer.BgpPeerId = context.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].BgpPeerId");
				bgpPeer.BgpGroupId = context.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].BgpGroupId");
				bgpPeer.PeerIpAddress = context.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].PeerIpAddress");
				bgpPeer.PeerAsn = context.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].PeerAsn");
				bgpPeer.AuthKey = context.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].AuthKey");
				bgpPeer.RouterId = context.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].RouterId");
				bgpPeer.BgpStatus = context.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].BgpStatus");
				bgpPeer.Status = context.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].Status");
				bgpPeer.Keepalive = context.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].Keepalive");
				bgpPeer.LocalAsn = context.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].LocalAsn");
				bgpPeer.Hold = context.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].Hold");
				bgpPeer.IsFake = context.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].IsFake");
				bgpPeer.RouteLimit = context.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].RouteLimit");
				bgpPeer.RegionId = context.StringValue("DescribeBgpPeers.BgpPeers["+ i +"].RegionId");

				describeBgpPeersResponse_bgpPeers.Add(bgpPeer);
			}
			describeBgpPeersResponse.BgpPeers = describeBgpPeersResponse_bgpPeers;
        
			return describeBgpPeersResponse;
        }
    }
}