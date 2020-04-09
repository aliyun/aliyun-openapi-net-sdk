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
using Aliyun.Acs.Dds.Model.V20151201;

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
				networkAddress.NodeType = context.StringValue("DescribeShardingNetworkAddress.NetworkAddresses["+ i +"].NodeType");
				networkAddress.Role = context.StringValue("DescribeShardingNetworkAddress.NetworkAddresses["+ i +"].Role");

				describeShardingNetworkAddressResponse_networkAddresses.Add(networkAddress);
			}
			describeShardingNetworkAddressResponse.NetworkAddresses = describeShardingNetworkAddressResponse_networkAddresses;

			List<DescribeShardingNetworkAddressResponse.DescribeShardingNetworkAddress_CompatibleConnection> describeShardingNetworkAddressResponse_compatibleConnections = new List<DescribeShardingNetworkAddressResponse.DescribeShardingNetworkAddress_CompatibleConnection>();
			for (int i = 0; i < context.Length("DescribeShardingNetworkAddress.CompatibleConnections.Length"); i++) {
				DescribeShardingNetworkAddressResponse.DescribeShardingNetworkAddress_CompatibleConnection compatibleConnection = new DescribeShardingNetworkAddressResponse.DescribeShardingNetworkAddress_CompatibleConnection();
				compatibleConnection.NetworkAddress = context.StringValue("DescribeShardingNetworkAddress.CompatibleConnections["+ i +"].NetworkAddress");
				compatibleConnection.IPAddress = context.StringValue("DescribeShardingNetworkAddress.CompatibleConnections["+ i +"].IPAddress");
				compatibleConnection.NetworkType = context.StringValue("DescribeShardingNetworkAddress.CompatibleConnections["+ i +"].NetworkType");
				compatibleConnection.Port = context.StringValue("DescribeShardingNetworkAddress.CompatibleConnections["+ i +"].Port");
				compatibleConnection.VPCId = context.StringValue("DescribeShardingNetworkAddress.CompatibleConnections["+ i +"].VPCId");
				compatibleConnection.VswitchId = context.StringValue("DescribeShardingNetworkAddress.CompatibleConnections["+ i +"].VswitchId");
				compatibleConnection.ExpiredTime = context.StringValue("DescribeShardingNetworkAddress.CompatibleConnections["+ i +"].ExpiredTime");

				describeShardingNetworkAddressResponse_compatibleConnections.Add(compatibleConnection);
			}
			describeShardingNetworkAddressResponse.CompatibleConnections = describeShardingNetworkAddressResponse_compatibleConnections;
        
			return describeShardingNetworkAddressResponse;
        }
    }
}
