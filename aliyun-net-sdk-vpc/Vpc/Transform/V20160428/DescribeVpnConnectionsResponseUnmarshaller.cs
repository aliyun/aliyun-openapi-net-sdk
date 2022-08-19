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
			describeVpnConnectionsResponse.PageSize = _ctx.IntegerValue("DescribeVpnConnections.PageSize");
			describeVpnConnectionsResponse.RequestId = _ctx.StringValue("DescribeVpnConnections.RequestId");
			describeVpnConnectionsResponse.PageNumber = _ctx.IntegerValue("DescribeVpnConnections.PageNumber");
			describeVpnConnectionsResponse.TotalCount = _ctx.IntegerValue("DescribeVpnConnections.TotalCount");

			List<DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection> describeVpnConnectionsResponse_vpnConnections = new List<DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection>();
			for (int i = 0; i < _ctx.Length("DescribeVpnConnections.VpnConnections.Length"); i++) {
				DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection vpnConnection = new DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection();
				vpnConnection.Status = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].Status");
				vpnConnection.EnableNatTraversal = _ctx.BooleanValue("DescribeVpnConnections.VpnConnections["+ i +"].EnableNatTraversal");
				vpnConnection.RemoteCaCertificate = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].RemoteCaCertificate");
				vpnConnection.CreateTime = _ctx.LongValue("DescribeVpnConnections.VpnConnections["+ i +"].CreateTime");
				vpnConnection.EffectImmediately = _ctx.BooleanValue("DescribeVpnConnections.VpnConnections["+ i +"].EffectImmediately");
				vpnConnection.VpnGatewayId = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VpnGatewayId");
				vpnConnection.LocalSubnet = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].LocalSubnet");
				vpnConnection.VpnConnectionId = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VpnConnectionId");
				vpnConnection.RemoteSubnet = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].RemoteSubnet");
				vpnConnection.CustomerGatewayId = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].CustomerGatewayId");
				vpnConnection.Name = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].Name");
				vpnConnection.EnableDpd = _ctx.BooleanValue("DescribeVpnConnections.VpnConnections["+ i +"].EnableDpd");
				vpnConnection.AttachType = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].AttachType");
				vpnConnection.NetworkType = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].NetworkType");
				vpnConnection.AttachInstanceId = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].AttachInstanceId");
				vpnConnection.Spec = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].Spec");
				vpnConnection.State = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].State");
				vpnConnection.TransitRouterId = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].TransitRouterId");
				vpnConnection.TransitRouterName = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].TransitRouterName");
				vpnConnection.CrossAccountAuthorized = _ctx.BooleanValue("DescribeVpnConnections.VpnConnections["+ i +"].CrossAccountAuthorized");

				DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection.DescribeVpnConnections_IkeConfig ikeConfig = new DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection.DescribeVpnConnections_IkeConfig();
				ikeConfig.RemoteId = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.RemoteId");
				ikeConfig.IkeLifetime = _ctx.LongValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.IkeLifetime");
				ikeConfig.IkeEncAlg = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.IkeEncAlg");
				ikeConfig.LocalId = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.LocalId");
				ikeConfig.IkeMode = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.IkeMode");
				ikeConfig.IkeVersion = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.IkeVersion");
				ikeConfig.IkePfs = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.IkePfs");
				ikeConfig.Psk = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.Psk");
				ikeConfig.IkeAuthAlg = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IkeConfig.IkeAuthAlg");
				vpnConnection.IkeConfig = ikeConfig;

				DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection.DescribeVpnConnections_IpsecConfig ipsecConfig = new DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection.DescribeVpnConnections_IpsecConfig();
				ipsecConfig.IpsecAuthAlg = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IpsecConfig.IpsecAuthAlg");
				ipsecConfig.IpsecLifetime = _ctx.LongValue("DescribeVpnConnections.VpnConnections["+ i +"].IpsecConfig.IpsecLifetime");
				ipsecConfig.IpsecEncAlg = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IpsecConfig.IpsecEncAlg");
				ipsecConfig.IpsecPfs = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].IpsecConfig.IpsecPfs");
				vpnConnection.IpsecConfig = ipsecConfig;

				DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection.DescribeVpnConnections_VcoHealthCheck vcoHealthCheck = new DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection.DescribeVpnConnections_VcoHealthCheck();
				vcoHealthCheck.Status = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VcoHealthCheck.Status");
				vcoHealthCheck.Dip = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VcoHealthCheck.Dip");
				vcoHealthCheck.Interval = _ctx.IntegerValue("DescribeVpnConnections.VpnConnections["+ i +"].VcoHealthCheck.Interval");
				vcoHealthCheck.Retry = _ctx.IntegerValue("DescribeVpnConnections.VpnConnections["+ i +"].VcoHealthCheck.Retry");
				vcoHealthCheck.Sip = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VcoHealthCheck.Sip");
				vcoHealthCheck.Enable = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VcoHealthCheck.Enable");
				vcoHealthCheck.Policy = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VcoHealthCheck.Policy");
				vpnConnection.VcoHealthCheck = vcoHealthCheck;

				DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection.DescribeVpnConnections_VpnBgpConfig vpnBgpConfig = new DescribeVpnConnectionsResponse.DescribeVpnConnections_VpnConnection.DescribeVpnConnections_VpnBgpConfig();
				vpnBgpConfig.Status = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VpnBgpConfig.Status");
				vpnBgpConfig.PeerBgpIp = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VpnBgpConfig.PeerBgpIp");
				vpnBgpConfig.TunnelCidr = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VpnBgpConfig.TunnelCidr");
				vpnBgpConfig.LocalBgpIp = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VpnBgpConfig.LocalBgpIp");
				vpnBgpConfig.PeerAsn = _ctx.LongValue("DescribeVpnConnections.VpnConnections["+ i +"].VpnBgpConfig.PeerAsn");
				vpnBgpConfig.LocalAsn = _ctx.LongValue("DescribeVpnConnections.VpnConnections["+ i +"].VpnBgpConfig.LocalAsn");
				vpnBgpConfig.AuthKey = _ctx.StringValue("DescribeVpnConnections.VpnConnections["+ i +"].VpnBgpConfig.AuthKey");
				vpnConnection.VpnBgpConfig = vpnBgpConfig;

				describeVpnConnectionsResponse_vpnConnections.Add(vpnConnection);
			}
			describeVpnConnectionsResponse.VpnConnections = describeVpnConnectionsResponse_vpnConnections;
        
			return describeVpnConnectionsResponse;
        }
    }
}
