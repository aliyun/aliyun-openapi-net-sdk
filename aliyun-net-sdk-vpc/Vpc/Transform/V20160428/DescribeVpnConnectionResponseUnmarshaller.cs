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
			describeVpnConnectionResponse.Status = _ctx.StringValue("DescribeVpnConnection.Status");
			describeVpnConnectionResponse.RemoteCaCertificate = _ctx.StringValue("DescribeVpnConnection.RemoteCaCertificate");
			describeVpnConnectionResponse.EnableNatTraversal = _ctx.BooleanValue("DescribeVpnConnection.EnableNatTraversal");
			describeVpnConnectionResponse.CreateTime = _ctx.LongValue("DescribeVpnConnection.CreateTime");
			describeVpnConnectionResponse.EffectImmediately = _ctx.BooleanValue("DescribeVpnConnection.EffectImmediately");
			describeVpnConnectionResponse.VpnGatewayId = _ctx.StringValue("DescribeVpnConnection.VpnGatewayId");
			describeVpnConnectionResponse.LocalSubnet = _ctx.StringValue("DescribeVpnConnection.LocalSubnet");
			describeVpnConnectionResponse.RequestId = _ctx.StringValue("DescribeVpnConnection.RequestId");
			describeVpnConnectionResponse.VpnConnectionId = _ctx.StringValue("DescribeVpnConnection.VpnConnectionId");
			describeVpnConnectionResponse.RemoteSubnet = _ctx.StringValue("DescribeVpnConnection.RemoteSubnet");
			describeVpnConnectionResponse.CustomerGatewayId = _ctx.StringValue("DescribeVpnConnection.CustomerGatewayId");
			describeVpnConnectionResponse.Name = _ctx.StringValue("DescribeVpnConnection.Name");
			describeVpnConnectionResponse.EnableDpd = _ctx.BooleanValue("DescribeVpnConnection.EnableDpd");
			describeVpnConnectionResponse.AttachType = _ctx.StringValue("DescribeVpnConnection.AttachType");
			describeVpnConnectionResponse.NetworkType = _ctx.StringValue("DescribeVpnConnection.NetworkType");
			describeVpnConnectionResponse.AttachInstanceId = _ctx.StringValue("DescribeVpnConnection.AttachInstanceId");
			describeVpnConnectionResponse.Spec = _ctx.StringValue("DescribeVpnConnection.Spec");
			describeVpnConnectionResponse.State = _ctx.StringValue("DescribeVpnConnection.State");
			describeVpnConnectionResponse.ZoneNo = _ctx.StringValue("DescribeVpnConnection.ZoneNo");
			describeVpnConnectionResponse.InternetIp = _ctx.StringValue("DescribeVpnConnection.InternetIp");
			describeVpnConnectionResponse.TransitRouterId = _ctx.StringValue("DescribeVpnConnection.TransitRouterId");
			describeVpnConnectionResponse.TransitRouterName = _ctx.StringValue("DescribeVpnConnection.TransitRouterName");
			describeVpnConnectionResponse.CrossAccountAuthorized = _ctx.BooleanValue("DescribeVpnConnection.CrossAccountAuthorized");

			DescribeVpnConnectionResponse.DescribeVpnConnection_IkeConfig ikeConfig = new DescribeVpnConnectionResponse.DescribeVpnConnection_IkeConfig();
			ikeConfig.RemoteId = _ctx.StringValue("DescribeVpnConnection.IkeConfig.RemoteId");
			ikeConfig.IkeLifetime = _ctx.LongValue("DescribeVpnConnection.IkeConfig.IkeLifetime");
			ikeConfig.IkeEncAlg = _ctx.StringValue("DescribeVpnConnection.IkeConfig.IkeEncAlg");
			ikeConfig.LocalId = _ctx.StringValue("DescribeVpnConnection.IkeConfig.LocalId");
			ikeConfig.IkeMode = _ctx.StringValue("DescribeVpnConnection.IkeConfig.IkeMode");
			ikeConfig.IkeVersion = _ctx.StringValue("DescribeVpnConnection.IkeConfig.IkeVersion");
			ikeConfig.IkePfs = _ctx.StringValue("DescribeVpnConnection.IkeConfig.IkePfs");
			ikeConfig.Psk = _ctx.StringValue("DescribeVpnConnection.IkeConfig.Psk");
			ikeConfig.IkeAuthAlg = _ctx.StringValue("DescribeVpnConnection.IkeConfig.IkeAuthAlg");
			describeVpnConnectionResponse.IkeConfig = ikeConfig;

			DescribeVpnConnectionResponse.DescribeVpnConnection_IpsecConfig ipsecConfig = new DescribeVpnConnectionResponse.DescribeVpnConnection_IpsecConfig();
			ipsecConfig.IpsecAuthAlg = _ctx.StringValue("DescribeVpnConnection.IpsecConfig.IpsecAuthAlg");
			ipsecConfig.IpsecLifetime = _ctx.LongValue("DescribeVpnConnection.IpsecConfig.IpsecLifetime");
			ipsecConfig.IpsecEncAlg = _ctx.StringValue("DescribeVpnConnection.IpsecConfig.IpsecEncAlg");
			ipsecConfig.IpsecPfs = _ctx.StringValue("DescribeVpnConnection.IpsecConfig.IpsecPfs");
			describeVpnConnectionResponse.IpsecConfig = ipsecConfig;

			DescribeVpnConnectionResponse.DescribeVpnConnection_VcoHealthCheck vcoHealthCheck = new DescribeVpnConnectionResponse.DescribeVpnConnection_VcoHealthCheck();
			vcoHealthCheck.Status = _ctx.StringValue("DescribeVpnConnection.VcoHealthCheck.Status");
			vcoHealthCheck.Dip = _ctx.StringValue("DescribeVpnConnection.VcoHealthCheck.Dip");
			vcoHealthCheck.Interval = _ctx.IntegerValue("DescribeVpnConnection.VcoHealthCheck.Interval");
			vcoHealthCheck.Retry = _ctx.IntegerValue("DescribeVpnConnection.VcoHealthCheck.Retry");
			vcoHealthCheck.Sip = _ctx.StringValue("DescribeVpnConnection.VcoHealthCheck.Sip");
			vcoHealthCheck.Enable = _ctx.StringValue("DescribeVpnConnection.VcoHealthCheck.Enable");
			vcoHealthCheck.Policy = _ctx.StringValue("DescribeVpnConnection.VcoHealthCheck.Policy");
			describeVpnConnectionResponse.VcoHealthCheck = vcoHealthCheck;

			DescribeVpnConnectionResponse.DescribeVpnConnection_VpnBgpConfig vpnBgpConfig = new DescribeVpnConnectionResponse.DescribeVpnConnection_VpnBgpConfig();
			vpnBgpConfig.Status = _ctx.StringValue("DescribeVpnConnection.VpnBgpConfig.Status");
			vpnBgpConfig.PeerBgpIp = _ctx.StringValue("DescribeVpnConnection.VpnBgpConfig.PeerBgpIp");
			vpnBgpConfig.TunnelCidr = _ctx.StringValue("DescribeVpnConnection.VpnBgpConfig.TunnelCidr");
			vpnBgpConfig.EnableBgp = _ctx.StringValue("DescribeVpnConnection.VpnBgpConfig.EnableBgp");
			vpnBgpConfig.LocalBgpIp = _ctx.StringValue("DescribeVpnConnection.VpnBgpConfig.LocalBgpIp");
			vpnBgpConfig.PeerAsn = _ctx.LongValue("DescribeVpnConnection.VpnBgpConfig.PeerAsn");
			vpnBgpConfig.LocalAsn = _ctx.LongValue("DescribeVpnConnection.VpnBgpConfig.LocalAsn");
			vpnBgpConfig.AuthKey = _ctx.StringValue("DescribeVpnConnection.VpnBgpConfig.AuthKey");
			describeVpnConnectionResponse.VpnBgpConfig = vpnBgpConfig;

			List<DescribeVpnConnectionResponse.DescribeVpnConnection_Tag> describeVpnConnectionResponse_tags = new List<DescribeVpnConnectionResponse.DescribeVpnConnection_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeVpnConnection.Tags.Length"); i++) {
				DescribeVpnConnectionResponse.DescribeVpnConnection_Tag tag = new DescribeVpnConnectionResponse.DescribeVpnConnection_Tag();
				tag.Key = _ctx.StringValue("DescribeVpnConnection.Tags["+ i +"].Key");
				tag._Value = _ctx.StringValue("DescribeVpnConnection.Tags["+ i +"].Value");

				describeVpnConnectionResponse_tags.Add(tag);
			}
			describeVpnConnectionResponse.Tags = describeVpnConnectionResponse_tags;
        
			return describeVpnConnectionResponse;
        }
    }
}
