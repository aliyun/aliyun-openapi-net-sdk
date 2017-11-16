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
    public class DescribeVpnConnectionResponseUnmarshaller
    {
        public static DescribeVpnConnectionResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVpnConnectionResponse describeVpnConnectionResponse = new DescribeVpnConnectionResponse();

			describeVpnConnectionResponse.HttpResponse = context.HttpResponse;
			describeVpnConnectionResponse.RequestId = context.StringValue("DescribeVpnConnection.RequestId");
			describeVpnConnectionResponse.VpnConnectionId = context.StringValue("DescribeVpnConnection.VpnConnectionId");
			describeVpnConnectionResponse.CustomerGatewayId = context.StringValue("DescribeVpnConnection.CustomerGatewayId");
			describeVpnConnectionResponse.VpnGatewayId = context.StringValue("DescribeVpnConnection.VpnGatewayId");
			describeVpnConnectionResponse.Name = context.StringValue("DescribeVpnConnection.Name");
			describeVpnConnectionResponse.LocalSubnet = context.StringValue("DescribeVpnConnection.LocalSubnet");
			describeVpnConnectionResponse.RemoteSubnet = context.StringValue("DescribeVpnConnection.RemoteSubnet");
			describeVpnConnectionResponse.CreateTime = context.LongValue("DescribeVpnConnection.CreateTime");
			describeVpnConnectionResponse.EffectImmediately = context.BooleanValue("DescribeVpnConnection.EffectImmediately");
			describeVpnConnectionResponse.Status = context.StringValue("DescribeVpnConnection.Status");

			DescribeVpnConnectionResponse.DescribeVpnConnection_IkeConfig ikeConfig = new DescribeVpnConnectionResponse.DescribeVpnConnection_IkeConfig();
			ikeConfig.Psk = context.StringValue("DescribeVpnConnection.IkeConfig.Psk");
			ikeConfig.IkeVersion = context.StringValue("DescribeVpnConnection.IkeConfig.IkeVersion");
			ikeConfig.IkeMode = context.StringValue("DescribeVpnConnection.IkeConfig.IkeMode");
			ikeConfig.IkeEncAlg = context.StringValue("DescribeVpnConnection.IkeConfig.IkeEncAlg");
			ikeConfig.IkeAuthAlg = context.StringValue("DescribeVpnConnection.IkeConfig.IkeAuthAlg");
			ikeConfig.IkePfs = context.StringValue("DescribeVpnConnection.IkeConfig.IkePfs");
			ikeConfig.IkeLifetime = context.LongValue("DescribeVpnConnection.IkeConfig.IkeLifetime");
			ikeConfig.LocalId = context.StringValue("DescribeVpnConnection.IkeConfig.LocalId");
			ikeConfig.RemoteId = context.StringValue("DescribeVpnConnection.IkeConfig.RemoteId");
			describeVpnConnectionResponse.IkeConfig = ikeConfig;

			DescribeVpnConnectionResponse.DescribeVpnConnection_IpsecConfig ipsecConfig = new DescribeVpnConnectionResponse.DescribeVpnConnection_IpsecConfig();
			ipsecConfig.IpsecEncAlg = context.StringValue("DescribeVpnConnection.IpsecConfig.IpsecEncAlg");
			ipsecConfig.IpsecAuthAlg = context.StringValue("DescribeVpnConnection.IpsecConfig.IpsecAuthAlg");
			ipsecConfig.IpsecPfs = context.StringValue("DescribeVpnConnection.IpsecConfig.IpsecPfs");
			ipsecConfig.IpsecLifetime = context.LongValue("DescribeVpnConnection.IpsecConfig.IpsecLifetime");
			describeVpnConnectionResponse.IpsecConfig = ipsecConfig;
        
			return describeVpnConnectionResponse;
        }
    }
}