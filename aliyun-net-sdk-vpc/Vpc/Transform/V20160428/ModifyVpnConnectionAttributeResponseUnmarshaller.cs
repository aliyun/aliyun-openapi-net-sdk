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
    public class ModifyVpnConnectionAttributeResponseUnmarshaller
    {
        public static ModifyVpnConnectionAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyVpnConnectionAttributeResponse modifyVpnConnectionAttributeResponse = new ModifyVpnConnectionAttributeResponse();

			modifyVpnConnectionAttributeResponse.HttpResponse = context.HttpResponse;
			modifyVpnConnectionAttributeResponse.RequestId = context.StringValue("ModifyVpnConnectionAttribute.RequestId");
			modifyVpnConnectionAttributeResponse.VpnConnectionId = context.StringValue("ModifyVpnConnectionAttribute.VpnConnectionId");
			modifyVpnConnectionAttributeResponse.CustomerGatewayId = context.StringValue("ModifyVpnConnectionAttribute.CustomerGatewayId");
			modifyVpnConnectionAttributeResponse.VpnGatewayId = context.StringValue("ModifyVpnConnectionAttribute.VpnGatewayId");
			modifyVpnConnectionAttributeResponse.Name = context.StringValue("ModifyVpnConnectionAttribute.Name");
			modifyVpnConnectionAttributeResponse.Description = context.StringValue("ModifyVpnConnectionAttribute.Description");
			modifyVpnConnectionAttributeResponse.LocalSubnet = context.StringValue("ModifyVpnConnectionAttribute.LocalSubnet");
			modifyVpnConnectionAttributeResponse.RemoteSubnet = context.StringValue("ModifyVpnConnectionAttribute.RemoteSubnet");
			modifyVpnConnectionAttributeResponse.CreateTime = context.LongValue("ModifyVpnConnectionAttribute.CreateTime");
			modifyVpnConnectionAttributeResponse.EffectImmediately = context.BooleanValue("ModifyVpnConnectionAttribute.EffectImmediately");

			ModifyVpnConnectionAttributeResponse.ModifyVpnConnectionAttribute_IkeConfig ikeConfig = new ModifyVpnConnectionAttributeResponse.ModifyVpnConnectionAttribute_IkeConfig();
			ikeConfig.Psk = context.StringValue("ModifyVpnConnectionAttribute.IkeConfig.Psk");
			ikeConfig.IkeVersion = context.StringValue("ModifyVpnConnectionAttribute.IkeConfig.IkeVersion");
			ikeConfig.IkeMode = context.StringValue("ModifyVpnConnectionAttribute.IkeConfig.IkeMode");
			ikeConfig.IkeEncAlg = context.StringValue("ModifyVpnConnectionAttribute.IkeConfig.IkeEncAlg");
			ikeConfig.IkeAuthAlg = context.StringValue("ModifyVpnConnectionAttribute.IkeConfig.IkeAuthAlg");
			ikeConfig.IkePfs = context.StringValue("ModifyVpnConnectionAttribute.IkeConfig.IkePfs");
			ikeConfig.IkeLifetime = context.LongValue("ModifyVpnConnectionAttribute.IkeConfig.IkeLifetime");
			ikeConfig.LocalId = context.StringValue("ModifyVpnConnectionAttribute.IkeConfig.LocalId");
			ikeConfig.RemoteId = context.StringValue("ModifyVpnConnectionAttribute.IkeConfig.RemoteId");
			modifyVpnConnectionAttributeResponse.IkeConfig = ikeConfig;

			ModifyVpnConnectionAttributeResponse.ModifyVpnConnectionAttribute_IpsecConfig ipsecConfig = new ModifyVpnConnectionAttributeResponse.ModifyVpnConnectionAttribute_IpsecConfig();
			ipsecConfig.IpsecEncAlg = context.StringValue("ModifyVpnConnectionAttribute.IpsecConfig.IpsecEncAlg");
			ipsecConfig.IpsecAuthAlg = context.StringValue("ModifyVpnConnectionAttribute.IpsecConfig.IpsecAuthAlg");
			ipsecConfig.IpsecPfs = context.StringValue("ModifyVpnConnectionAttribute.IpsecConfig.IpsecPfs");
			ipsecConfig.IpsecLifetime = context.LongValue("ModifyVpnConnectionAttribute.IpsecConfig.IpsecLifetime");
			modifyVpnConnectionAttributeResponse.IpsecConfig = ipsecConfig;
        
			return modifyVpnConnectionAttributeResponse;
        }
    }
}