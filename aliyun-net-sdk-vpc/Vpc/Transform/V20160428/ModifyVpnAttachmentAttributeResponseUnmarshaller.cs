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
    public class ModifyVpnAttachmentAttributeResponseUnmarshaller
    {
        public static ModifyVpnAttachmentAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyVpnAttachmentAttributeResponse modifyVpnAttachmentAttributeResponse = new ModifyVpnAttachmentAttributeResponse();

			modifyVpnAttachmentAttributeResponse.HttpResponse = _ctx.HttpResponse;
			modifyVpnAttachmentAttributeResponse.VpnConnectionId = _ctx.StringValue("ModifyVpnAttachmentAttribute.VpnConnectionId");
			modifyVpnAttachmentAttributeResponse.CustomerGatewayId = _ctx.StringValue("ModifyVpnAttachmentAttribute.CustomerGatewayId");
			modifyVpnAttachmentAttributeResponse.VpnGatewayId = _ctx.StringValue("ModifyVpnAttachmentAttribute.VpnGatewayId");
			modifyVpnAttachmentAttributeResponse.Name = _ctx.StringValue("ModifyVpnAttachmentAttribute.Name");
			modifyVpnAttachmentAttributeResponse.Description = _ctx.StringValue("ModifyVpnAttachmentAttribute.Description");
			modifyVpnAttachmentAttributeResponse.LocalSubnet = _ctx.StringValue("ModifyVpnAttachmentAttribute.LocalSubnet");
			modifyVpnAttachmentAttributeResponse.RemoteSubnet = _ctx.StringValue("ModifyVpnAttachmentAttribute.RemoteSubnet");
			modifyVpnAttachmentAttributeResponse.CreateTime = _ctx.LongValue("ModifyVpnAttachmentAttribute.CreateTime");
			modifyVpnAttachmentAttributeResponse.EffectImmediately = _ctx.BooleanValue("ModifyVpnAttachmentAttribute.EffectImmediately");
			modifyVpnAttachmentAttributeResponse.Status = _ctx.StringValue("ModifyVpnAttachmentAttribute.Status");
			modifyVpnAttachmentAttributeResponse.EnableDpd = _ctx.BooleanValue("ModifyVpnAttachmentAttribute.EnableDpd");
			modifyVpnAttachmentAttributeResponse.EnableNatTraversal = _ctx.BooleanValue("ModifyVpnAttachmentAttribute.EnableNatTraversal");
			modifyVpnAttachmentAttributeResponse.AttachType = _ctx.StringValue("ModifyVpnAttachmentAttribute.AttachType");
			modifyVpnAttachmentAttributeResponse.NetworkType = _ctx.StringValue("ModifyVpnAttachmentAttribute.NetworkType");
			modifyVpnAttachmentAttributeResponse.AttachInstanceId = _ctx.StringValue("ModifyVpnAttachmentAttribute.AttachInstanceId");
			modifyVpnAttachmentAttributeResponse.Spec = _ctx.StringValue("ModifyVpnAttachmentAttribute.Spec");
			modifyVpnAttachmentAttributeResponse.RequestId = _ctx.StringValue("ModifyVpnAttachmentAttribute.RequestId");

			ModifyVpnAttachmentAttributeResponse.ModifyVpnAttachmentAttribute_IkeConfig ikeConfig = new ModifyVpnAttachmentAttributeResponse.ModifyVpnAttachmentAttribute_IkeConfig();
			ikeConfig.Psk = _ctx.StringValue("ModifyVpnAttachmentAttribute.IkeConfig.Psk");
			ikeConfig.IkeVersion = _ctx.StringValue("ModifyVpnAttachmentAttribute.IkeConfig.IkeVersion");
			ikeConfig.IkeMode = _ctx.StringValue("ModifyVpnAttachmentAttribute.IkeConfig.IkeMode");
			ikeConfig.IkeEncAlg = _ctx.StringValue("ModifyVpnAttachmentAttribute.IkeConfig.IkeEncAlg");
			ikeConfig.IkeAuthAlg = _ctx.StringValue("ModifyVpnAttachmentAttribute.IkeConfig.IkeAuthAlg");
			ikeConfig.IkePfs = _ctx.StringValue("ModifyVpnAttachmentAttribute.IkeConfig.IkePfs");
			ikeConfig.IkeLifetime = _ctx.LongValue("ModifyVpnAttachmentAttribute.IkeConfig.IkeLifetime");
			ikeConfig.LocalId = _ctx.StringValue("ModifyVpnAttachmentAttribute.IkeConfig.LocalId");
			ikeConfig.RemoteId = _ctx.StringValue("ModifyVpnAttachmentAttribute.IkeConfig.RemoteId");
			modifyVpnAttachmentAttributeResponse.IkeConfig = ikeConfig;

			ModifyVpnAttachmentAttributeResponse.ModifyVpnAttachmentAttribute_IpsecConfig ipsecConfig = new ModifyVpnAttachmentAttributeResponse.ModifyVpnAttachmentAttribute_IpsecConfig();
			ipsecConfig.IpsecEncAlg = _ctx.StringValue("ModifyVpnAttachmentAttribute.IpsecConfig.IpsecEncAlg");
			ipsecConfig.IpsecAuthAlg = _ctx.StringValue("ModifyVpnAttachmentAttribute.IpsecConfig.IpsecAuthAlg");
			ipsecConfig.IpsecPfs = _ctx.StringValue("ModifyVpnAttachmentAttribute.IpsecConfig.IpsecPfs");
			ipsecConfig.IpsecLifetime = _ctx.LongValue("ModifyVpnAttachmentAttribute.IpsecConfig.IpsecLifetime");
			modifyVpnAttachmentAttributeResponse.IpsecConfig = ipsecConfig;

			ModifyVpnAttachmentAttributeResponse.ModifyVpnAttachmentAttribute_VcoHealthCheck vcoHealthCheck = new ModifyVpnAttachmentAttributeResponse.ModifyVpnAttachmentAttribute_VcoHealthCheck();
			vcoHealthCheck.Enable = _ctx.StringValue("ModifyVpnAttachmentAttribute.VcoHealthCheck.Enable");
			vcoHealthCheck.Sip = _ctx.StringValue("ModifyVpnAttachmentAttribute.VcoHealthCheck.Sip");
			vcoHealthCheck.Dip = _ctx.StringValue("ModifyVpnAttachmentAttribute.VcoHealthCheck.Dip");
			vcoHealthCheck.Interval = _ctx.IntegerValue("ModifyVpnAttachmentAttribute.VcoHealthCheck.Interval");
			vcoHealthCheck.Retry = _ctx.IntegerValue("ModifyVpnAttachmentAttribute.VcoHealthCheck.Retry");
			vcoHealthCheck.Policy = _ctx.StringValue("ModifyVpnAttachmentAttribute.VcoHealthCheck.Policy");
			modifyVpnAttachmentAttributeResponse.VcoHealthCheck = vcoHealthCheck;

			ModifyVpnAttachmentAttributeResponse.ModifyVpnAttachmentAttribute_VpnBgpConfig vpnBgpConfig = new ModifyVpnAttachmentAttributeResponse.ModifyVpnAttachmentAttribute_VpnBgpConfig();
			vpnBgpConfig.EnableBgp = _ctx.StringValue("ModifyVpnAttachmentAttribute.VpnBgpConfig.EnableBgp");
			vpnBgpConfig.TunnelCidr = _ctx.StringValue("ModifyVpnAttachmentAttribute.VpnBgpConfig.TunnelCidr");
			vpnBgpConfig.LocalBgpIp = _ctx.StringValue("ModifyVpnAttachmentAttribute.VpnBgpConfig.LocalBgpIp");
			vpnBgpConfig.PeerBgpIp = _ctx.StringValue("ModifyVpnAttachmentAttribute.VpnBgpConfig.PeerBgpIp");
			vpnBgpConfig.LocalAsn = _ctx.LongValue("ModifyVpnAttachmentAttribute.VpnBgpConfig.LocalAsn");
			vpnBgpConfig.PeerAsn = _ctx.LongValue("ModifyVpnAttachmentAttribute.VpnBgpConfig.PeerAsn");
			vpnBgpConfig.Status = _ctx.StringValue("ModifyVpnAttachmentAttribute.VpnBgpConfig.Status");
			modifyVpnAttachmentAttributeResponse.VpnBgpConfig = vpnBgpConfig;
        
			return modifyVpnAttachmentAttributeResponse;
        }
    }
}
