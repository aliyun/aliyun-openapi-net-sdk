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
    public class DescribeBgpNetworksResponseUnmarshaller
    {
        public static DescribeBgpNetworksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBgpNetworksResponse describeBgpNetworksResponse = new DescribeBgpNetworksResponse();

			describeBgpNetworksResponse.HttpResponse = _ctx.HttpResponse;
			describeBgpNetworksResponse.RequestId = _ctx.StringValue("DescribeBgpNetworks.RequestId");
			describeBgpNetworksResponse.TotalCount = _ctx.IntegerValue("DescribeBgpNetworks.TotalCount");
			describeBgpNetworksResponse.PageNumber = _ctx.IntegerValue("DescribeBgpNetworks.PageNumber");
			describeBgpNetworksResponse.PageSize = _ctx.IntegerValue("DescribeBgpNetworks.PageSize");

			List<DescribeBgpNetworksResponse.DescribeBgpNetworks_BgpNetwork> describeBgpNetworksResponse_bgpNetworks = new List<DescribeBgpNetworksResponse.DescribeBgpNetworks_BgpNetwork>();
			for (int i = 0; i < _ctx.Length("DescribeBgpNetworks.BgpNetworks.Length"); i++) {
				DescribeBgpNetworksResponse.DescribeBgpNetworks_BgpNetwork bgpNetwork = new DescribeBgpNetworksResponse.DescribeBgpNetworks_BgpNetwork();
				bgpNetwork.VpcId = _ctx.StringValue("DescribeBgpNetworks.BgpNetworks["+ i +"].VpcId");
				bgpNetwork.DstCidrBlock = _ctx.StringValue("DescribeBgpNetworks.BgpNetworks["+ i +"].DstCidrBlock");
				bgpNetwork.RouterId = _ctx.StringValue("DescribeBgpNetworks.BgpNetworks["+ i +"].RouterId");
				bgpNetwork.Status = _ctx.StringValue("DescribeBgpNetworks.BgpNetworks["+ i +"].Status");

				describeBgpNetworksResponse_bgpNetworks.Add(bgpNetwork);
			}
			describeBgpNetworksResponse.BgpNetworks = describeBgpNetworksResponse_bgpNetworks;
        
			return describeBgpNetworksResponse;
        }
    }
}
