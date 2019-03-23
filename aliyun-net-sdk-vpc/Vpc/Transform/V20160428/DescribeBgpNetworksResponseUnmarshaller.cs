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
    public class DescribeBgpNetworksResponseUnmarshaller
    {
        public static DescribeBgpNetworksResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeBgpNetworksResponse describeBgpNetworksResponse = new DescribeBgpNetworksResponse();

            describeBgpNetworksResponse.HttpResponse = context.HttpResponse;
            describeBgpNetworksResponse.RequestId = context.StringValue("DescribeBgpNetworks.RequestId");
            describeBgpNetworksResponse.TotalCount = context.IntegerValue("DescribeBgpNetworks.TotalCount");
            describeBgpNetworksResponse.PageNumber = context.IntegerValue("DescribeBgpNetworks.PageNumber");
            describeBgpNetworksResponse.PageSize = context.IntegerValue("DescribeBgpNetworks.PageSize");

            List<DescribeBgpNetworksResponse.DescribeBgpNetworks_BgpNetwork> describeBgpNetworksResponse_bgpNetworks = new List<DescribeBgpNetworksResponse.DescribeBgpNetworks_BgpNetwork>();
            for (int i = 0; i < context.Length("DescribeBgpNetworks.BgpNetworks.Length"); i++)
            {
                DescribeBgpNetworksResponse.DescribeBgpNetworks_BgpNetwork bgpNetwork = new DescribeBgpNetworksResponse.DescribeBgpNetworks_BgpNetwork();
                bgpNetwork.VpcId = context.StringValue("DescribeBgpNetworks.BgpNetworks[" + i + "].VpcId");
                bgpNetwork.DstCidrBlock = context.StringValue("DescribeBgpNetworks.BgpNetworks[" + i + "].DstCidrBlock");
                bgpNetwork.RouterId = context.StringValue("DescribeBgpNetworks.BgpNetworks[" + i + "].RouterId");

                describeBgpNetworksResponse_bgpNetworks.Add(bgpNetwork);
            }
            describeBgpNetworksResponse.BgpNetworks = describeBgpNetworksResponse_bgpNetworks;

            return describeBgpNetworksResponse;
        }
    }
}