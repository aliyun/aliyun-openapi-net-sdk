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
    public class DescribeVpnConnectionResponseUnmarshaller
    {
        public static DescribeVpnConnectionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVpnConnectionResponse describeVpnConnectionResponse = new DescribeVpnConnectionResponse();

			describeVpnConnectionResponse.HttpResponse = _ctx.HttpResponse;
			describeVpnConnectionResponse.RequestId = _ctx.StringValue("DescribeVpnConnection.RequestId");
			describeVpnConnectionResponse.VpnConnectionId = _ctx.StringValue("DescribeVpnConnection.VpnConnectionId");
			describeVpnConnectionResponse.CustomerGatewayId = _ctx.StringValue("DescribeVpnConnection.CustomerGatewayId");
			describeVpnConnectionResponse.VpnGatewayId = _ctx.StringValue("DescribeVpnConnection.VpnGatewayId");
			describeVpnConnectionResponse.Name = _ctx.StringValue("DescribeVpnConnection.Name");
			describeVpnConnectionResponse.LocalSubnet = _ctx.StringValue("DescribeVpnConnection.LocalSubnet");
			describeVpnConnectionResponse.RemoteSubnet = _ctx.StringValue("DescribeVpnConnection.RemoteSubnet");
			describeVpnConnectionResponse.CreateTime = _ctx.LongValue("DescribeVpnConnection.CreateTime");
			describeVpnConnectionResponse.EffectImmediately = _ctx.BooleanValue("DescribeVpnConnection.EffectImmediately");
			describeVpnConnectionResponse.Status = _ctx.StringValue("DescribeVpnConnection.Status");
			describeVpnConnectionResponse.EnableDpd = _ctx.BooleanValue("DescribeVpnConnection.EnableDpd");
			describeVpnConnectionResponse.EnableNatTraversal = _ctx.BooleanValue("DescribeVpnConnection.EnableNatTraversal");
			describeVpnConnectionResponse.RemoteCaCertificate = _ctx.StringValue("DescribeVpnConnection.RemoteCaCertificate");

			DescribeVpnConnectionResponse.DescribeVpnConnection_IkeConfig ikeConfig = new DescribeVpnConnectionResponse.DescribeVpnConnection_IkeConfig();
			ikeConfig.Psk = _ctx.StringValue("DescribeVpnConnection.IkeConfig.Psk");
			ikeConfig.IkeVersion = _ctx.StringValue("DescribeVpnConnection.IkeConfig.IkeVersion");
			ikeConfig.IkeMode = _ctx.StringValue("DescribeVpnConnection.IkeConfig.IkeMode");
			ikeConfig.IkeEncAlg = _ctx.StringValue("DescribeVpnConnection.IkeConfig.IkeEncAlg");
			ikeConfig.IkeAuthAlg = _ctx.StringValue("DescribeVpnConnection.IkeConfig.IkeAuthAlg");
			ikeConfig.IkePfs = _ctx.StringValue("DescribeVpnConnection.IkeConfig.IkePfs");
			ikeConfig.IkeLifetime = _ctx.LongValue("DescribeVpnConnection.IkeConfig.IkeLifetime");
			ikeConfig.LocalId = _ctx.StringValue("DescribeVpnConnection.IkeConfig.LocalId");
			ikeConfig.RemoteId = _ctx.StringValue("DescribeVpnConnection.IkeConfig.RemoteId");
			describeVpnConnectionResponse.IkeConfig = ikeConfig;

			DescribeVpnConnectionResponse.DescribeVpnConnection_IpsecConfig ipsecConfig = new DescribeVpnConnectionResponse.DescribeVpnConnection_IpsecConfig();
			ipsecConfig.IpsecEncAlg = _ctx.StringValue("DescribeVpnConnection.IpsecConfig.IpsecEncAlg");
			ipsecConfig.IpsecAuthAlg = _ctx.StringValue("DescribeVpnConnection.IpsecConfig.IpsecAuthAlg");
			ipsecConfig.IpsecPfs = _ctx.StringValue("DescribeVpnConnection.IpsecConfig.IpsecPfs");
			ipsecConfig.IpsecLifetime = _ctx.LongValue("DescribeVpnConnection.IpsecConfig.IpsecLifetime");
			describeVpnConnectionResponse.IpsecConfig = ipsecConfig;

			DescribeVpnConnectionResponse.DescribeVpnConnection_VcoHealthCheck vcoHealthCheck = new DescribeVpnConnectionResponse.DescribeVpnConnection_VcoHealthCheck();
			vcoHealthCheck.Enable = _ctx.StringValue("DescribeVpnConnection.VcoHealthCheck.Enable");
			vcoHealthCheck.Sip = _ctx.StringValue("DescribeVpnConnection.VcoHealthCheck.Sip");
			vcoHealthCheck.Dip = _ctx.StringValue("DescribeVpnConnection.VcoHealthCheck.Dip");
			vcoHealthCheck.Interval = _ctx.IntegerValue("DescribeVpnConnection.VcoHealthCheck.Interval");
			vcoHealthCheck.Retry = _ctx.IntegerValue("DescribeVpnConnection.VcoHealthCheck.Retry");
			vcoHealthCheck.Status = _ctx.StringValue("DescribeVpnConnection.VcoHealthCheck.Status");
			describeVpnConnectionResponse.VcoHealthCheck = vcoHealthCheck;

			DescribeVpnConnectionResponse.DescribeVpnConnection_VpnBgpConfig vpnBgpConfig = new DescribeVpnConnectionResponse.DescribeVpnConnection_VpnBgpConfig();
			vpnBgpConfig.EnableBgp = _ctx.StringValue("DescribeVpnConnection.VpnBgpConfig.EnableBgp");
			vpnBgpConfig.TunnelCidr = _ctx.StringValue("DescribeVpnConnection.VpnBgpConfig.TunnelCidr");
			vpnBgpConfig.LocalBgpIp = _ctx.StringValue("DescribeVpnConnection.VpnBgpConfig.LocalBgpIp");
			vpnBgpConfig.PeerBgpIp = _ctx.StringValue("DescribeVpnConnection.VpnBgpConfig.PeerBgpIp");
			vpnBgpConfig.LocalAsn = _ctx.StringValue("DescribeVpnConnection.VpnBgpConfig.LocalAsn");
			vpnBgpConfig.PeerAsn = _ctx.StringValue("DescribeVpnConnection.VpnBgpConfig.PeerAsn");
			vpnBgpConfig.Status = _ctx.StringValue("DescribeVpnConnection.VpnBgpConfig.Status");
			describeVpnConnectionResponse.VpnBgpConfig = vpnBgpConfig;
        
			return describeVpnConnectionResponse;
        }
    }
}
