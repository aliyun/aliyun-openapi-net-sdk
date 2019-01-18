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
using Aliyun.Acs.Dds.Model.V20151201;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeShardingNetworkAddressResponseUnmarshaller
    {
        public static DescribeShardingNetworkAddressResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeShardingNetworkAddressResponse describeShardingNetworkAddressResponse = new DescribeShardingNetworkAddressResponse();

			describeShardingNetworkAddressResponse.HttpResponse = context.HttpResponse;
			describeShardingNetworkAddressResponse.RequestId = context.StringValue("DescribeShardingNetworkAddress.RequestId");

			List<DescribeShardingNetworkAddressResponse.DescribeShardingNetworkAddress_NetworkAddress> describeShardingNetworkAddressResponse_networkAddresses = new List<DescribeShardingNetworkAddressResponse.DescribeShardingNetworkAddress_NetworkAddress>();
			for (int i = 0; i < context.Length("DescribeShardingNetworkAddress.NetworkAddresses.Length"); i++) {
				DescribeShardingNetworkAddressResponse.DescribeShardingNetworkAddress_NetworkAddress networkAddress = new DescribeShardingNetworkAddressResponse.DescribeShardingNetworkAddress_NetworkAddress();
				networkAddress.NetworkAddress = context.StringValue("DescribeShardingNetworkAddress.NetworkAddresses["+ i +"].NetworkAddress");
				networkAddress.IPAddress = context.StringValue("DescribeShardingNetworkAddress.NetworkAddresses["+ i +"].IPAddress");
				networkAddress.NetworkType = context.StringValue("DescribeShardingNetworkAddress.NetworkAddresses["+ i +"].NetworkType");
				networkAddress.Port = context.StringValue("DescribeShardingNetworkAddress.NetworkAddresses["+ i +"].Port");
				networkAddress.VPCId = context.StringValue("DescribeShardingNetworkAddress.NetworkAddresses["+ i +"].VPCId");
				networkAddress.VswitchId = context.StringValue("DescribeShardingNetworkAddress.NetworkAddresses["+ i +"].VswitchId");
				networkAddress.NodeId = context.StringValue("DescribeShardingNetworkAddress.NetworkAddresses["+ i +"].NodeId");
				networkAddress.ExpiredTime = context.StringValue("DescribeShardingNetworkAddress.NetworkAddresses["+ i +"].ExpiredTime");

				describeShardingNetworkAddressResponse_networkAddresses.Add(networkAddress);
			}
			describeShardingNetworkAddressResponse.NetworkAddresses = describeShardingNetworkAddressResponse_networkAddresses;
        
			return describeShardingNetworkAddressResponse;
        }
    }
}