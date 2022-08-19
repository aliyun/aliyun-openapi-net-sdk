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
			modifyVpnConnectionAttributeResponse.EnableNatTraversal = _ctx.BooleanValue("ModifyVpnConnectionAttribute.EnableNatTraversal");
			modifyVpnConnectionAttributeResponse.CreateTime = _ctx.LongValue("ModifyVpnConnectionAttribute.CreateTime");
			modifyVpnConnectionAttributeResponse.EffectImmediately = _ctx.BooleanValue("ModifyVpnConnectionAttribute.EffectImmediately");
			modifyVpnConnectionAttributeResponse.VpnGatewayId = _ctx.StringValue("ModifyVpnConnectionAttribute.VpnGatewayId");
			modifyVpnConnectionAttributeResponse.LocalSubnet = _ctx.StringValue("ModifyVpnConnectionAttribute.LocalSubnet");
			modifyVpnConnectionAttributeResponse.RequestId = _ctx.StringValue("ModifyVpnConnectionAttribute.RequestId");
			modifyVpnConnectionAttributeResponse.VpnConnectionId = _ctx.StringValue("ModifyVpnConnectionAttribute.VpnConnectionId");
			modifyVpnConnectionAttributeResponse.Description = _ctx.StringValue("ModifyVpnConnectionAttribute.Description");
			modifyVpnConnectionAttributeResponse.RemoteSubnet = _ctx.StringValue("ModifyVpnConnectionAttribute.RemoteSubnet");
			modifyVpnConnectionAttributeResponse.CustomerGatewayId = _ctx.StringValue("ModifyVpnConnectionAttribute.CustomerGatewayId");
			modifyVpnConnectionAttributeResponse.Name = _ctx.StringValue("ModifyVpnConnectionAttribute.Name");
			modifyVpnConnectionAttributeResponse.EnableDpd = _ctx.BooleanValue("ModifyVpnConnectionAttribute.EnableDpd");

			ModifyVpnConnectionAttributeResponse.ModifyVpnConnectionAttribute_IkeConfig ikeConfig = new ModifyVpnConnectionAttributeResponse.ModifyVpnConnectionAttribute_IkeConfig();
			ikeConfig.RemoteId = _ctx.StringValue("ModifyVpnConnectionAttribute.IkeConfig.RemoteId");
			ikeConfig.IkeLifetime = _ctx.LongValue("ModifyVpnConnectionAttribute.IkeConfig.IkeLifetime");
			ikeConfig.IkeEncAlg = _ctx.StringValue("ModifyVpnConnectionAttribute.IkeConfig.IkeEncAlg");
			ikeConfig.LocalId = _ctx.StringValue("ModifyVpnConnectionAttribute.IkeConfig.LocalId");
			ikeConfig.IkeMode = _ctx.StringValue("ModifyVpnConnectionAttribute.IkeConfig.IkeMode");
			ikeConfig.IkeVersion = _ctx.StringValue("ModifyVpnConnectionAttribute.IkeConfig.IkeVersion");
			ikeConfig.IkePfs = _ctx.StringValue("ModifyVpnConnectionAttribute.IkeConfig.IkePfs");
			ikeConfig.Psk = _ctx.StringValue("ModifyVpnConnectionAttribute.IkeConfig.Psk");
			ikeConfig.IkeAuthAlg = _ctx.StringValue("ModifyVpnConnectionAttribute.IkeConfig.IkeAuthAlg");
			modifyVpnConnectionAttributeResponse.IkeConfig = ikeConfig;

			ModifyVpnConnectionAttributeResponse.ModifyVpnConnectionAttribute_IpsecConfig ipsecConfig = new ModifyVpnConnectionAttributeResponse.ModifyVpnConnectionAttribute_IpsecConfig();
			ipsecConfig.IpsecAuthAlg = _ctx.StringValue("ModifyVpnConnectionAttribute.IpsecConfig.IpsecAuthAlg");
			ipsecConfig.IpsecLifetime = _ctx.LongValue("ModifyVpnConnectionAttribute.IpsecConfig.IpsecLifetime");
			ipsecConfig.IpsecEncAlg = _ctx.StringValue("ModifyVpnConnectionAttribute.IpsecConfig.IpsecEncAlg");
			ipsecConfig.IpsecPfs = _ctx.StringValue("ModifyVpnConnectionAttribute.IpsecConfig.IpsecPfs");
			modifyVpnConnectionAttributeResponse.IpsecConfig = ipsecConfig;

			ModifyVpnConnectionAttributeResponse.ModifyVpnConnectionAttribute_VcoHealthCheck vcoHealthCheck = new ModifyVpnConnectionAttributeResponse.ModifyVpnConnectionAttribute_VcoHealthCheck();
			vcoHealthCheck.Dip = _ctx.StringValue("ModifyVpnConnectionAttribute.VcoHealthCheck.Dip");
			vcoHealthCheck.Interval = _ctx.IntegerValue("ModifyVpnConnectionAttribute.VcoHealthCheck.Interval");
			vcoHealthCheck.Retry = _ctx.IntegerValue("ModifyVpnConnectionAttribute.VcoHealthCheck.Retry");
			vcoHealthCheck.Sip = _ctx.StringValue("ModifyVpnConnectionAttribute.VcoHealthCheck.Sip");
			vcoHealthCheck.Enable = _ctx.StringValue("ModifyVpnConnectionAttribute.VcoHealthCheck.Enable");
			modifyVpnConnectionAttributeResponse.VcoHealthCheck = vcoHealthCheck;

			ModifyVpnConnectionAttributeResponse.ModifyVpnConnectionAttribute_VpnBgpConfig vpnBgpConfig = new ModifyVpnConnectionAttributeResponse.ModifyVpnConnectionAttribute_VpnBgpConfig();
			vpnBgpConfig.Status = _ctx.StringValue("ModifyVpnConnectionAttribute.VpnBgpConfig.Status");
			vpnBgpConfig.PeerBgpIp = _ctx.StringValue("ModifyVpnConnectionAttribute.VpnBgpConfig.PeerBgpIp");
			vpnBgpConfig.TunnelCidr = _ctx.StringValue("ModifyVpnConnectionAttribute.VpnBgpConfig.TunnelCidr");
			vpnBgpConfig.EnableBgp = _ctx.StringValue("ModifyVpnConnectionAttribute.VpnBgpConfig.EnableBgp");
			vpnBgpConfig.LocalBgpIp = _ctx.StringValue("ModifyVpnConnectionAttribute.VpnBgpConfig.LocalBgpIp");
			vpnBgpConfig.PeerAsn = _ctx.IntegerValue("ModifyVpnConnectionAttribute.VpnBgpConfig.PeerAsn");
			vpnBgpConfig.LocalAsn = _ctx.IntegerValue("ModifyVpnConnectionAttribute.VpnBgpConfig.LocalAsn");
			modifyVpnConnectionAttributeResponse.VpnBgpConfig = vpnBgpConfig;
        
			return modifyVpnConnectionAttributeResponse;
        }
    }
}
