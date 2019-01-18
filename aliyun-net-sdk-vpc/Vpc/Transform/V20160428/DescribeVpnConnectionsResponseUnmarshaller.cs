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
    public class DescribeVpnConnectionsResponseUnmarshaller
    {
        public static DescribeVpnConnectionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVpnConnectionsResponse describeVpnConnectionsResponse = new DescribeVpnConnectionsResponse();

			describeVpnConnectionsResponse.HttpResponse = context.HttpResponse;
			describeVpnConnectionsResponse.RequestId = context.StringValue("DescribeVpnConnections.RequestId");
			describeVpnConnectionsResponse.TotalCount = context.IntegerValue("DescribeVpnConnections.TotalCount");
			describeVpnConnectionsResponse.PageNumber = context.IntegerValue("DescribeVpnConnections.PageNumber");
			describeVpnConnectionsResponse.PageSize = context.IntegerValue("DescribeVpnConnections.PageSize");

			List<DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection> describeVpnConnectionsResponse_vpnConnections = new List<DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection>();
			for (int i = 0; i < context.Length("DescribeVpnConnections.VpnConnections.Length"); i++) {
				DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection vpnConnection = new DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection();
				vpnConnection.VpnConnectionId = context.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VpnConnectionId");
				vpnConnection.CustomerGatewayId = context.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].CustomerGatewayId");
				vpnConnection.VpnGatewayId = context.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VpnGatewayId");
				vpnConnection.Name = context.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].Name");
				vpnConnection.LocalSubnet = context.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].LocalSubnet");
				vpnConnection.RemoteSubnet = context.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].RemoteSubnet");
				vpnConnection.CreateTime = context.LongValue("DescribeVpnConnections.VpnConnections["+ i +"].CreateTime");
				vpnConnection.EffectImmediately = context.BooleanValue("DescribeVpnConnections.VpnConnections["+ i +"].EffectImmediately");
				vpnConnection.Status = context.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].Status");

				DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection.DescribeVpnConnections_IkeConfig ikeConfig = new DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection.DescribeVpnConnections_IkeConfig();
				ikeConfig.Psk = context.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.Psk");
				ikeConfig.IkeVersion = context.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.IkeVersion");
				ikeConfig.IkeMode = context.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.IkeMode");
				ikeConfig.IkeEncAlg = context.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.IkeEncAlg");
				ikeConfig.IkeAuthAlg = context.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.IkeAuthAlg");
				ikeConfig.IkePfs = context.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.IkePfs");
				ikeConfig.IkeLifetime = context.LongValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.IkeLifetime");
				ikeConfig.LocalId = context.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.LocalId");
				ikeConfig.RemoteId = context.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.RemoteId");
				vpnConnection.IkeConfig = ikeConfig;

				DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection.DescribeVpnConnections_IpsecConfig ipsecConfig = new DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection.DescribeVpnConnections_IpsecConfig();
				ipsecConfig.IpsecEncAlg = context.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IpsecConfig.IpsecEncAlg");
				ipsecConfig.IpsecAuthAlg = context.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IpsecConfig.IpsecAuthAlg");
				ipsecConfig.IpsecPfs = context.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IpsecConfig.IpsecPfs");
				ipsecConfig.IpsecLifetime = context.LongValue("DescribeVpnConnections.VpnConnections["+ i +"].IpsecConfig.IpsecLifetime");
				vpnConnection.IpsecConfig = ipsecConfig;

				describeVpnConnectionsResponse_vpnConnections.Add(vpnConnection);
			}
			describeVpnConnectionsResponse.VpnConnections = describeVpnConnectionsResponse_vpnConnections;
        
			return describeVpnConnectionsResponse;
        }
    }
}