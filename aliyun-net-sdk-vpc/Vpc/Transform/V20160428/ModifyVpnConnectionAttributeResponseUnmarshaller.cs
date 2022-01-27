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
    public class ModifyVpnConnectionAttributeResponseUnmarshaller
    {
        public static ModifyVpnConnectionAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyVpnConnectionAttributeResponse modifyVpnConnectionAttributeResponse = new ModifyVpnConnectionAttributeResponse();

			modifyVpnConnectionAttributeResponse.HttpResponse = _ctx.HttpResponse;
			modifyVpnConnectionAttributeResponse.RequestId = _ctx.StringValue("ModifyVpnConnectionAttribute.RequestId");
			modifyVpnConnectionAttributeResponse.VpnConnectionId = _ctx.StringValue("ModifyVpnConnectionAttribute.VpnConnectionId");
			modifyVpnConnectionAttributeResponse.CustomerGatewayId = _ctx.StringValue("ModifyVpnConnectionAttribute.CustomerGatewayId");
			modifyVpnConnectionAttributeResponse.VpnGatewayId = _ctx.StringValue("ModifyVpnConnectionAttribute.VpnGatewayId");
			modifyVpnConnectionAttributeResponse.Name = _ctx.StringValue("ModifyVpnConnectionAttribute.Name");
			modifyVpnConnectionAttributeResponse.Description = _ctx.StringValue("ModifyVpnConnectionAttribute.Description");
			modifyVpnConnectionAttributeResponse.LocalSubnet = _ctx.StringValue("ModifyVpnConnectionAttribute.LocalSubnet");
			modifyVpnConnectionAttributeResponse.RemoteSubnet = _ctx.StringValue("ModifyVpnConnectionAttribute.RemoteSubnet");
			modifyVpnConnectionAttributeResponse.CreateTime = _ctx.LongValue("ModifyVpnConnectionAttribute.CreateTime");
			modifyVpnConnectionAttributeResponse.EffectImmediately = _ctx.BooleanValue("ModifyVpnConnectionAttribute.EffectImmediately");
			modifyVpnConnectionAttributeResponse.EnableDpd = _ctx.BooleanValue("ModifyVpnConnectionAttribute.EnableDpd");
			modifyVpnConnectionAttributeResponse.EnableNatTraversal = _ctx.BooleanValue("ModifyVpnConnectionAttribute.EnableNatTraversal");

			ModifyVpnConnectionAttributeResponse.ModifyVpnConnectionAttribute_IkeConfig ikeConfig = new ModifyVpnConnectionAttributeResponse.ModifyVpnConnectionAttribute_IkeConfig();
			ikeConfig.Psk = _ctx.StringValue("ModifyVpnConnectionAttribute.IkeConfig.Psk");
			ikeConfig.IkeVersion = _ctx.StringValue("ModifyVpnConnectionAttribute.IkeConfig.IkeVersion");
			ikeConfig.IkeMode = _ctx.StringValue("ModifyVpnConnectionAttribute.IkeConfig.IkeMode");
			ikeConfig.IkeEncAlg = _ctx.StringValue("ModifyVpnConnectionAttribute.IkeConfig.IkeEncAlg");
			ikeConfig.IkeAuthAlg = _ctx.StringValue("ModifyVpnConnectionAttribute.IkeConfig.IkeAuthAlg");
			ikeConfig.IkePfs = _ctx.StringValue("ModifyVpnConnectionAttribute.IkeConfig.IkePfs");
			ikeConfig.IkeLifetime = _ctx.LongValue("ModifyVpnConnectionAttribute.IkeConfig.IkeLifetime");
			ikeConfig.LocalId = _ctx.StringValue("ModifyVpnConnectionAttribute.IkeConfig.LocalId");
			ikeConfig.RemoteId = _ctx.StringValue("ModifyVpnConnectionAttribute.IkeConfig.RemoteId");
			modifyVpnConnectionAttributeResponse.IkeConfig = ikeConfig;

			ModifyVpnConnectionAttributeResponse.ModifyVpnConnectionAttribute_IpsecConfig ipsecConfig = new ModifyVpnConnectionAttributeResponse.ModifyVpnConnectionAttribute_IpsecConfig();
			ipsecConfig.IpsecEncAlg = _ctx.StringValue("ModifyVpnConnectionAttribute.IpsecConfig.IpsecEncAlg");
			ipsecConfig.IpsecAuthAlg = _ctx.StringValue("ModifyVpnConnectionAttribute.IpsecConfig.IpsecAuthAlg");
			ipsecConfig.IpsecPfs = _ctx.StringValue("ModifyVpnConnectionAttribute.IpsecConfig.IpsecPfs");
			ipsecConfig.IpsecLifetime = _ctx.LongValue("ModifyVpnConnectionAttribute.IpsecConfig.IpsecLifetime");
			modifyVpnConnectionAttributeResponse.IpsecConfig = ipsecConfig;

			ModifyVpnConnectionAttributeResponse.ModifyVpnConnectionAttribute_VcoHealthCheck vcoHealthCheck = new ModifyVpnConnectionAttributeResponse.ModifyVpnConnectionAttribute_VcoHealthCheck();
			vcoHealthCheck.Enable = _ctx.StringValue("ModifyVpnConnectionAttribute.VcoHealthCheck.Enable");
			vcoHealthCheck.Sip = _ctx.StringValue("ModifyVpnConnectionAttribute.VcoHealthCheck.Sip");
			vcoHealthCheck.Dip = _ctx.StringValue("ModifyVpnConnectionAttribute.VcoHealthCheck.Dip");
			vcoHealthCheck.Interval = _ctx.IntegerValue("ModifyVpnConnectionAttribute.VcoHealthCheck.Interval");
			vcoHealthCheck.Retry = _ctx.IntegerValue("ModifyVpnConnectionAttribute.VcoHealthCheck.Retry");
			modifyVpnConnectionAttributeResponse.VcoHealthCheck = vcoHealthCheck;

			ModifyVpnConnectionAttributeResponse.ModifyVpnConnectionAttribute_VpnBgpConfig vpnBgpConfig = new ModifyVpnConnectionAttributeResponse.ModifyVpnConnectionAttribute_VpnBgpConfig();
			vpnBgpConfig.EnableBgp = _ctx.StringValue("ModifyVpnConnectionAttribute.VpnBgpConfig.EnableBgp");
			vpnBgpConfig.TunnelCidr = _ctx.StringValue("ModifyVpnConnectionAttribute.VpnBgpConfig.TunnelCidr");
			vpnBgpConfig.LocalBgpIp = _ctx.StringValue("ModifyVpnConnectionAttribute.VpnBgpConfig.LocalBgpIp");
			vpnBgpConfig.PeerBgpIp = _ctx.StringValue("ModifyVpnConnectionAttribute.VpnBgpConfig.PeerBgpIp");
			vpnBgpConfig.LocalAsn = _ctx.IntegerValue("ModifyVpnConnectionAttribute.VpnBgpConfig.LocalAsn");
			vpnBgpConfig.PeerAsn = _ctx.IntegerValue("ModifyVpnConnectionAttribute.VpnBgpConfig.PeerAsn");
			vpnBgpConfig.Status = _ctx.StringValue("ModifyVpnConnectionAttribute.VpnBgpConfig.Status");
			modifyVpnConnectionAttributeResponse.VpnBgpConfig = vpnBgpConfig;
        
			return modifyVpnConnectionAttributeResponse;
        }
    }
}
