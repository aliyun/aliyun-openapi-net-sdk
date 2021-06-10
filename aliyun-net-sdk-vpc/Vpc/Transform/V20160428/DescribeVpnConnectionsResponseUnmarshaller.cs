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
    public class DescribeVpnConnectionsResponseUnmarshaller
    {
        public static DescribeVpnConnectionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVpnConnectionsResponse describeVpnConnectionsResponse = new DescribeVpnConnectionsResponse();

			describeVpnConnectionsResponse.HttpResponse = _ctx.HttpResponse;
			describeVpnConnectionsResponse.RequestId = _ctx.StringValue("DescribeVpnConnections.RequestId");
			describeVpnConnectionsResponse.TotalCount = _ctx.IntegerValue("DescribeVpnConnections.TotalCount");
			describeVpnConnectionsResponse.PageNumber = _ctx.IntegerValue("DescribeVpnConnections.PageNumber");
			describeVpnConnectionsResponse.PageSize = _ctx.IntegerValue("DescribeVpnConnections.PageSize");

			List<DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection> describeVpnConnectionsResponse_vpnConnections = new List<DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection>();
			for (int i = 0; i < _ctx.Length("DescribeVpnConnections.VpnConnections.Length"); i++) {
				DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection vpnConnection = new DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection();
				vpnConnection.VpnConnectionId = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VpnConnectionId");
				vpnConnection.CustomerGatewayId = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].CustomerGatewayId");
				vpnConnection.VpnGatewayId = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VpnGatewayId");
				vpnConnection.Name = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].Name");
				vpnConnection.LocalSubnet = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].LocalSubnet");
				vpnConnection.RemoteSubnet = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].RemoteSubnet");
				vpnConnection.CreateTime = _ctx.LongValue("DescribeVpnConnections.VpnConnections["+ i +"].CreateTime");
				vpnConnection.EffectImmediately = _ctx.BooleanValue("DescribeVpnConnections.VpnConnections["+ i +"].EffectImmediately");
				vpnConnection.Status = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].Status");
				vpnConnection.EnableDpd = _ctx.BooleanValue("DescribeVpnConnections.VpnConnections["+ i +"].EnableDpd");
				vpnConnection.EnableNatTraversal = _ctx.BooleanValue("DescribeVpnConnections.VpnConnections["+ i +"].EnableNatTraversal");
				vpnConnection.RemoteCaCertificate = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].RemoteCaCertificate");

				DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection.DescribeVpnConnections_IkeConfig ikeConfig = new DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection.DescribeVpnConnections_IkeConfig();
				ikeConfig.Psk = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.Psk");
				ikeConfig.IkeVersion = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.IkeVersion");
				ikeConfig.IkeMode = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.IkeMode");
				ikeConfig.IkeEncAlg = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.IkeEncAlg");
				ikeConfig.IkeAuthAlg = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.IkeAuthAlg");
				ikeConfig.IkePfs = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.IkePfs");
				ikeConfig.IkeLifetime = _ctx.LongValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.IkeLifetime");
				ikeConfig.LocalId = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.LocalId");
				ikeConfig.RemoteId = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.RemoteId");
				vpnConnection.IkeConfig = ikeConfig;

				DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection.DescribeVpnConnections_IpsecConfig ipsecConfig = new DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection.DescribeVpnConnections_IpsecConfig();
				ipsecConfig.IpsecEncAlg = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IpsecConfig.IpsecEncAlg");
				ipsecConfig.IpsecAuthAlg = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IpsecConfig.IpsecAuthAlg");
				ipsecConfig.IpsecPfs = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IpsecConfig.IpsecPfs");
				ipsecConfig.IpsecLifetime = _ctx.LongValue("DescribeVpnConnections.VpnConnections["+ i +"].IpsecConfig.IpsecLifetime");
				vpnConnection.IpsecConfig = ipsecConfig;

				DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection.DescribeVpnConnections_VcoHealthCheck vcoHealthCheck = new DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection.DescribeVpnConnections_VcoHealthCheck();
				vcoHealthCheck.Enable = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VcoHealthCheck.Enable");
				vcoHealthCheck.Sip = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VcoHealthCheck.Sip");
				vcoHealthCheck.Dip = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VcoHealthCheck.Dip");
				vcoHealthCheck.Interval = _ctx.IntegerValue("DescribeVpnConnections.VpnConnections["+ i +"].VcoHealthCheck.Interval");
				vcoHealthCheck.Retry = _ctx.IntegerValue("DescribeVpnConnections.VpnConnections["+ i +"].VcoHealthCheck.Retry");
				vcoHealthCheck.Status = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VcoHealthCheck.Status");
				vpnConnection.VcoHealthCheck = vcoHealthCheck;

				DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection.DescribeVpnConnections_VpnBgpConfig vpnBgpConfig = new DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection.DescribeVpnConnections_VpnBgpConfig();
				vpnBgpConfig.TunnelCidr = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VpnBgpConfig.TunnelCidr");
				vpnBgpConfig.LocalBgpIp = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VpnBgpConfig.LocalBgpIp");
				vpnBgpConfig.PeerBgpIp = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VpnBgpConfig.PeerBgpIp");
				vpnBgpConfig.LocalAsn = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VpnBgpConfig.LocalAsn");
				vpnBgpConfig.PeerAsn = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VpnBgpConfig.PeerAsn");
				vpnBgpConfig.Status = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VpnBgpConfig.Status");
				vpnConnection.VpnBgpConfig = vpnBgpConfig;

				describeVpnConnectionsResponse_vpnConnections.Add(vpnConnection);
			}
			describeVpnConnectionsResponse.VpnConnections = describeVpnConnectionsResponse_vpnConnections;
        
			return describeVpnConnectionsResponse;
        }
    }
}
